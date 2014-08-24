using System;

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

        public static string ConvertirAvecParametrageParDefaut(decimal chiffre)
        {
            return new ConvertisseurNombreEnLettre(ParametrageDuConvertisseur.ParDefaut())
                .Convertir(chiffre);
        }

        public string Convertir(decimal chiffreAConvertir)
        {
            var partieAvantDecimale = (int)Decimal.Truncate(chiffreAConvertir);
            decimal d = chiffreAConvertir - partieAvantDecimale;
            decimal u = (decimal)Math.Pow(10, BitConverter.GetBytes(decimal.GetBits(chiffreAConvertir)[3])[2]);
            decimal t = d * u;
            var partieApresDecimale = (int)t;


            return Convertir(new Nombre(partieAvantDecimale), new Nombre(partieApresDecimale));
        }

        private string Convertir(Nombre nombre, Nombre chiffreAConvertirApresDecimale)
        {
            var resultat = string.Empty;

            foreach (var partieDuNombre in nombre.RecupererLaDecomposition(_parametrage))
                resultat = Convertisseur.AjouterAuResultat(partieDuNombre.Convertir(), resultat, _parametrage.RecupererSeparateur());

            if (_parametrage.DoitGenererUneDevise())
                resultat = AjouterLaDevise(nombre, resultat);

            if (!chiffreAConvertirApresDecimale.EstZero())
            {
                resultat += " virgule ";

                var resultatApresVirgule = string.Empty;
                foreach (var partieDuNombre in chiffreAConvertirApresDecimale.RecupererLaDecomposition(_parametrage))
                    resultatApresVirgule = Convertisseur.AjouterAuResultat(partieDuNombre.Convertir(), resultatApresVirgule, _parametrage.RecupererSeparateur());

                resultat += resultatApresVirgule;
            }
            return resultat;
        }

        private string AjouterLaDevise(Nombre nombre, string resultat)
        {
            resultat = string.Format("{0} {1}", resultat, _parametrage.RecupererLaDevisePourLeNombre(nombre));
            return resultat;
        }
    }
}