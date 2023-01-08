namespace Tramway
{
    public class Ligne
    {
        private string codeLigne;
        private string departLigne;
        private string terminusLigne;

        public string CodeLigne
        {
            get => codeLigne;
            set => codeLigne = value;
        }

        public string DepartLigne
        {
            get => departLigne;
            set => departLigne = value;
        }

        public string TerminusLigne
        {
            get => terminusLigne;
            set => terminusLigne = value;
        }
        public Ligne()
        {
            codeLigne = "Z";
            departLigne = "CHARLIER";
            terminusLigne = "CHARLIER";
        }

        public Ligne(string codeligne)
        {
            departLigne = "CHARLIER";
            terminusLigne = "CHARLIER";
            this.codeLigne = codeligne;
        }
        
        public Ligne(string codeLigne, string departLigne, string terminusLigne)
        {
            this.codeLigne = codeLigne;
            this.departLigne = departLigne;
            this.terminusLigne = terminusLigne;
        }
    }
}