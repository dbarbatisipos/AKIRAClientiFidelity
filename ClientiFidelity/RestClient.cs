using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;


namespace AKIRAClientiFidelity
{
    public enum httpRestVerb
    { 
        GET,
        POST,
        PUT,
        DELETE    
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpRestVerb httpMethod { get; set; }
        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpRestVerb.GET;
        }

        public string ExecRichiesta()

        {
            string Risposta = string.Empty;
            HttpWebRequest Richiesta = (HttpWebRequest)WebRequest.Create(endPoint);
            Richiesta.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)Richiesta.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException("Errore " +
                       response.StatusCode + " " + response.StatusDescription.ToString());
            using (Stream responseStream= response.GetResponseStream())
                {
                    if(responseStream != null)
                        using (StreamReader reader = new StreamReader(responseStream))
                        { Risposta = reader.ReadToEnd().ToString(); }
                }
            {
                return Risposta;
            }
        }
        }

    }
}
