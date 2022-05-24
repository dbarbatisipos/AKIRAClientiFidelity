using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Data.Sql;

namespace AKIRAClientiFidelity
{

    class Configurazione
    {
        string PathXML = @"C:\AKIRA\BIN\BAP\Libs\SearchCli\Parametri.xml";
        string DataSource;
        string UserID;
        string Password;
        public string ConnectionString {get;set;}

        #region "Caricamento file configurazione XML"
        public void LeggiConfigurazione()

        {
            if (!File.Exists(PathXML))
            {
                throw new Exception("Attenzione! File XML non presente");
            }
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(PathXML);
            XmlNodeList nodeList = XmlDoc.DocumentElement.SelectNodes("/configuration/appSettings");
            XmlElement value = XmlDoc.DocumentElement;

            foreach (XmlNode node in nodeList)
            {               
                //Console.WriteLine(node.Name);
                foreach (XmlElement elemento in node)                {
                    string reader = elemento.FirstChild.Value.ToString();
                        switch (elemento.Name)                        {
                        case "DataSource":
                            DataSource = reader;                            
                            break;
                        case "uID":
                            UserID = reader;
                            break;
                        case "Password":
                            Password = reader;
                            break;
                        }
                        ConnectionString = "Password=" +
                        Password + ";Persist Security Info=True;User ID=" +
                        UserID + ";Initial Catalog=kanedadb;Data Source=" +
                        DataSource + ";Connection Timeout=120";
                }
               
            }
        }
        #endregion

    }
}