namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        static readonly string[] Unite = { "zéro", " un", " deux", " trois", " quatre", " cinq", " six", " sept", " huit", " neuf" };

        private readonly ParametrageDuConvertisseur _parametrage;

        private ConvertisseurNombreEnLettre(ParametrageDuConvertisseur parametrage)
        {
            _parametrage = parametrage;
        }

        public static FabriqueParametrageDuConvertisseur Parametrage
        {
            get
            {
                return new FabriqueParametrageDuConvertisseur();
            }
        }

        public static string ConvertirAvecParametrageParDefaut(Nombre chiffre)
        {
            return new ConvertisseurNombreEnLettre(ParametrageDuConvertisseur.ParDefaut())
                .Convertir(chiffre);
        }

        public string Convertir(int chiffreAConvertir)
        {
            var chiffre = new Nombre(chiffreAConvertir);
            return Convertir(chiffre);
        }

        private string Convertir(Nombre nombre)
        {
            var resultat = string.Empty;

            foreach (var partieDuNombre in nombre.RecupererLaDecomposition(_parametrage))
             resultat =  AjouterAuResultat(partieDuNombre.Convertir(), resultat);
            
            resultat = resultat.Trim();

            if (_parametrage.Devise != null)
                resultat += " " + _parametrage.RecupererLaDevisePourLeNombre(nombre);

            return resultat;
        }

        private string AjouterAuResultat(string termeAAjouter, string resultat)
        {
            if (string.IsNullOrWhiteSpace(termeAAjouter))
                return resultat;

            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0}{1}{2}", resultat, _parametrage.RecupererSeparateur(), termeAAjouter.Trim());

            return resultat + termeAAjouter;
        }
    }
}