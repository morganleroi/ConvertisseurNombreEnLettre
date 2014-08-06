namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        static readonly string[] Unite = { "zéro", " un", " deux", " trois", " quatre", " cinq", " six", " sept", " huit", " neuf" };
        static readonly string[] PremiereDizaine = { " ", " dix", " onze", " douze", " treize", " quatorze", " quinze", " seize", " dix-sept", "dix-huit", "dix-neuf" };
        static readonly string[] Dizaine = { " ", " ", " vingt", " trente", " quarante", " cinquante", " soixante", " soixante-dix", " quatre-vingt", " quatre-vingt-dix" };
        static readonly string[] ExceptionDizaineBelgeEtSuisse = { " ", " ", " ", " ", " ", " ", " ", " septante", " ", " nonante" };

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

        public static string ConvertirAvecParametrageParDefaut(int chiffre)
        {
            return new ConvertisseurNombreEnLettre(ParametrageDuConvertisseur.ParDefaut())
                .Convertir(chiffre);
        }

        public static string ConvertirAvecParametrageParDefaut(Nombre chiffre)
        {
            return new ConvertisseurNombreEnLettre(ParametrageDuConvertisseur.ParDefaut())
                .Convertir(chiffre);
        }

        public string ConvertirTT(Nombre nombre)
        {
            var resultat = string.Empty;

            ////if (chiffreAConvertir == 0)
            ////    return Unite[0];

            if (nombre.NombreDeDizaine == 1)
            {
                return ConvertirLaPremiereDizaine(resultat, nombre);
            }

            if (nombre.NombreDeDizaine > 1)
            {
                if (nombre.NombreDeDizaine == 7 && nombre.NombreUnite > 0)
                {
                    resultat = AjouterAuResultat(Dizaine[nombre.NombreDeDizaine].Replace("-dix", string.Empty), resultat);
                    return ConvertirLaPremiereDizaine(resultat, nombre);
                }

                resultat = AjouterAuResultat(RecupererLaDizaine(nombre.NombreDeDizaine), resultat);
            }
            if (nombre.NombreUnite > 0)
            {
                string convertionUnite = Unite[nombre.NombreUnite];

                if (nombre.NombreUnite == 1 && nombre.EstUneDizaineAvecExceptionPourUneUnite())
                {
                    resultat = AjouterAuResultat(" et" + convertionUnite, resultat);
                }
                else resultat = AjouterAuResultat(convertionUnite, resultat);
            }

            return RenvoyerLeResultat(resultat);
        }

        public string Convertir(int chiffreAConvertir)
        {
            var chiffre = new Nombre(chiffreAConvertir);
            return ConvertirTT(chiffre);
        }

        public string Convertir(Nombre chiffreAConvertir)
        {
            return ConvertirTT(chiffreAConvertir);
        }

        private string ConvertirLaPremiereDizaine(string resultat, Nombre chiffre)
        {
            resultat = AjouterAuResultat(PremiereDizaine[chiffre.NombreUnite + 1], resultat);
            return RenvoyerLeResultat(resultat);
        }

        private string RecupererLaDizaine(int nombreDeDizaine)
        {
            if (_parametrage.RegleDeTraductionBelgeEtSuisse)
            {
                return ExceptionDizaineBelgeEtSuisse[nombreDeDizaine];
            }
            
            return Dizaine[nombreDeDizaine];
        }

        private string AjouterAuResultat(string termeAAjouter, string resultat)
        {

            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0}-{1}", resultat, termeAAjouter.Trim());

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