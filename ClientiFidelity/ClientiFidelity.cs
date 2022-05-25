using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace AKIRAClientiFidelity
{
    public partial class ClientiFidelity : Form

        #region "Caricamento Configurazione"


    {
        Configurazione Parametri = new Configurazione();
        

        string carattere = "";

        int numeroRighe = 0;
        int RigaSelezionata = 0;
        string _Fidelity;

        public string Fidelity
        {
            set
            { _Fidelity = value; }
            get
            { return _Fidelity; }

        }
        #endregion


        public ClientiFidelity()
        {
            InitializeComponent();
        }

        #region "Metodo di connessione al DB KANEDA"
        public string ConnessioneDB(string ConnectionString, string sqlQuery)
        {
            ClientiFidelity ClientiFidelity = new ClientiFidelity();


            BindingSource BindingSource = new BindingSource();
            SqlConnection dbConnessione = new SqlConnection(ConnectionString);
            SqlDataAdapter dAdapter = new SqlDataAdapter(sqlQuery, dbConnessione);
            dbConnessione.Open();
            DataSet lstFidelity = new DataSet();
            DataTable DataTable = new DataTable();
            DataTable.TableName = "Lista Clienti";

            SqlCommandBuilder dbQuery = new SqlCommandBuilder(dAdapter);
            dAdapter.Fill(lstFidelity, DataTable.TableName);
            BindingSource.DataSource = lstFidelity.Tables[DataTable.TableName];
            GrigliaFidelity.DataSource = BindingSource;
            dbConnessione.Close();
            return GrigliaFidelity.DataSource.ToString();
        }
        #endregion

        #region "Filtro da casella"
        private void txtRicerca_TextChanged(object sender, EventArgs e)
        {


        }
        #endregion

        #region "Caricamento Griglia"
        public void PopolaGriglia(string Query)

        {
            ClientiFidelity ClientiFidelity = new ClientiFidelity();
            Parametri.LeggiConfigurazione();
            try
            {
                ConnessioneDB(Parametri.ConnectionString, Query);
            }
            catch
            {
                MessageBox.Show("Attenzione!, Connessione non riuscita");
            }
            GrigliaFidelity.Refresh();

        }
        #endregion

        #region "Gestione Configurazione Tastiera"
        private void btnQ_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'Q';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'Q';
                StringaCreata(carattere.ToString());

            }

        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'W';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'W';
                StringaCreata(carattere.ToString());
            }
        }

        public string StringaCreata(string carattere)
        {
            if (carattere != "")
            {
                switch (carattere)
                {
                    case "A":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "B":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "C":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "D":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "E":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "F":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "G":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "J":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "K":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "H":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "I":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "L":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "M":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "N":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "O":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "P":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "Q":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "R":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "S":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "T":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "U":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "V":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "X":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "Y":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "Z":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "W":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "0":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "1":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "2":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "3":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "4":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "5":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "6":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "7":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "8":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                    case "9":
                        txtRicerca.Text = txtRicerca.Text + carattere.ToString();
                        break;
                }

            }
            return txtRicerca.Text.ToString();
        }


        private void btnE_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'E';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'E';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'R';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'R';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'T';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'T';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'Y';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'Y';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'U';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'U';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'I';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'I';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'O';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'O';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'P';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'P';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'A';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'A';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'S';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'S';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'D';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'D';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'F';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'F';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'G';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'G';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'H';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'H';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'J';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'J';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'K';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'K';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'L';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'L';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'Z';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'Z';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'X';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'X';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'C';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'C';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'V';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'V';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'B';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'B';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'N';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'N';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = 'M';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = 'M';
                StringaCreata(carattere.ToString());
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            txtRicerca.Text = "";
            GrigliaFidelity.DataSource = "";
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Fidelity = "";
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '1';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '1';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '2';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '2';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '3';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '3';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '4';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '4';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '5';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '5';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '6';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '6';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '7';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '7';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '8';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '8';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '9';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '9';
                StringaCreata(carattere.ToString());

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtRicerca.Text == "")
            {
                char carattere = '0';
                txtRicerca.Text = carattere.ToString();
            }
            else
            {
                char carattere = '0';
                StringaCreata(carattere.ToString());

            }
        }
        private void btnCancChar_Click(object sender, EventArgs e)
        {
            string casella = txtRicerca.Text;
            char LastChar;
            string output;
            output = string.Empty;
            if (casella.Length != 0)
            {
                output = casella.Substring(0, casella.Length - 1);
                txtRicerca.Text = output;
            }
        }


        private void btnConferma_Click(object sender, EventArgs e)
        {
            numeroRighe = GrigliaFidelity.RowCount;
            RigaSelezionata = GrigliaFidelity.Rows[GrigliaFidelity.CurrentRow.Index].Index;
            Fidelity = GrigliaFidelity.Rows[GrigliaFidelity.CurrentRow.Index].Cells[0].Value.ToString();
            txtRicerca.Text = string.Empty;
            GrigliaFidelity.DataSource = "";
            this.Close();
        }

        private void btnScorriSu_Click(object sender, EventArgs e)
        {
            if (GrigliaFidelity.Rows.Count > 0)
            {
                int totalRows = GrigliaFidelity.SelectedRows[0].Index;
                if (totalRows < GrigliaFidelity.RowCount)
                {
                    GrigliaFidelity.Rows[totalRows].Selected = false;
                    GrigliaFidelity.Rows[--totalRows].Selected = true;
                    
                    GrigliaFidelity.Rows[totalRows].Selected = true;
                }


            }
        }

        private void btnScorriGiu_Click(object sender, EventArgs e)
        {
            if (GrigliaFidelity.Rows.Count > 0)
            {
                int totalRows = GrigliaFidelity.SelectedRows[0].Index ;
                if (totalRows < GrigliaFidelity.RowCount)
                {
                    GrigliaFidelity.Rows[totalRows].Selected = false;                    
                    GrigliaFidelity.Rows[++totalRows].Selected = true;
                    GrigliaFidelity.FirstDisplayedScrollingColumnIndex = 1;
                }
            }
        }
        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string sqlQuery = "select cardnr as TESSERA,desc_ as NOMECLIENTE from debtcredit_anag" +
            " where desc_ like '%" + txtRicerca.Text.ToString() + "%'" +
            "or CARDNR like '%" + txtRicerca.Text.ToString() + "%'";

            PopolaGriglia(sqlQuery);
            GrigliaFidelity.Refresh();
            txtRicerca.Text = string.Empty;
        }

        #endregion "/Gestione Tastiera"


    }
}


