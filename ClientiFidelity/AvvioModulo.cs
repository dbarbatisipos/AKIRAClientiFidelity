using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;


namespace AKIRAClientiFidelity
{
    public class AvvioModulo
    {
        ClientiFidelity Elencoclienti = new ClientiFidelity();
        string Fidelity;

        public AvvioModulo()
        {}

        #region "Avvio Form Principale "
        public string RicercaFidelity()
        {
            Elencoclienti.ShowDialog();
            StringBuilder _BapFile = new StringBuilder();
            int i = 0;
            int RigaBap = i + 5;
            Fidelity = Elencoclienti.Fidelity.ToString();
            if (Fidelity == "")
                return Fidelity;
            else
                _BapFile.AppendLine(i + RigaBap + " EXECUTE BACKALL C ");
            RigaBap = RigaBap + 5;
            _BapFile.AppendLine(RigaBap + " EXECUTE " + Fidelity + " H SCANNER C");
            RigaBap = RigaBap + 5;
            Fidelity = _BapFile.ToString();

            return Fidelity;

        }
        #endregion

    }
}
