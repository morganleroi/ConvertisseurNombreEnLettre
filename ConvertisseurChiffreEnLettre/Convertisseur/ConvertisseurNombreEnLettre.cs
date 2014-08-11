namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        static readonly string[] Unite = { "zéro", " un", " deux", " trois", " quatre", " cinq", " six", " sept", " huit", " neuf" };

        private ParametrageDuConvertisseur _parametrage;

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
            foreach (var partieDuNombre in nombre.RecupererLaDecomposition())
            {
                resultat = ConvertirUnePartieDuNombre(partieDuNombre.PartieDuNombreAConvertir, resultat) + " " + partieDuNombre.Libelle;
            }

            return resultat.Trim();
        }

        private string ConvertirUnePartieDuNombre(Nombre nombre, string resultat)
        {
            var convertisseurCentaine = new ConvertisseurCentaine(nombre, _parametrage);
            resultat = AjouterAuResultat(convertisseurCentaine.Convertir(), resultat);

            var convertisseurDizaine = new ConvertisseurDizaine(nombre, _parametrage);
            resultat = AjouterAuResultat(convertisseurDizaine.Convertir(), resultat);

            var convertisseurUnite = new ConvertisseurUnite(nombre);
            resultat = AjouterAuResultat(convertisseurUnite.Convertir(), resultat);

            return RenvoyerLeResultat(resultat);
        }



        private string AjouterAuResultat(string termeAAjouter, string resultat)
        {
            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0} {1}", resultat, termeAAjouter.Trim());

            //if (_parametrage.RegleDesTiretsDe1990 && !string.IsNullOrEmpty(resultat))
            //    return string.Format("{0}-{1}", resultat, termeAAjouter.Trim());
            return resultat + termeAAjouter;
        }

        private static string RenvoyerLeResultat(string resultat)
        {
            return resultat.Trim();
        }
    }
}