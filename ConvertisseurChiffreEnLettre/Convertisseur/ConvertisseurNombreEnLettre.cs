using System;
using Convertisseur.Entite;

namespace Convertisseur
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
            var partieEntiere = (int)Decimal.Truncate(chiffreAConvertir);
            var reste = chiffreAConvertir - partieEntiere;
            var nombreDeChiffreDansPartieDecimale = (decimal)Math.Pow(10, BitConverter.GetBytes(decimal.GetBits(chiffreAConvertir)[3])[2]);
            var partieDecimale = reste * nombreDeChiffreDansPartieDecimale;

            return Convertir(new Nombre(partieEntiere), new Nombre((int)partieDecimale));
        }

        private string Convertir(Nombre nombrePartieEntiere, Nombre nombrePartieDecimale)
        {
            var resultat = string.Empty;

            foreach (var partieDuNombre in nombrePartieEntiere.RecupererLaDecomposition(_parametrage))
                resultat = Convertisseur.AjouterAuResultat(partieDuNombre.Convertir(), resultat, _parametrage.RecupererSeparateur());

            if (_parametrage.DoitGenererUneDevise())
                resultat = AjouterLaDevise(nombrePartieEntiere,false, resultat);

            if (DoitConvertirLaVirgule(nombrePartieDecimale))
            {
                resultat += _parametrage.RecupererLaVirgule();

                var resultatApresVirgule = string.Empty;
                foreach (var partieDuNombre in nombrePartieDecimale.RecupererLaDecomposition(_parametrage))
                    resultatApresVirgule = Convertisseur.AjouterAuResultat(partieDuNombre.Convertir(), resultatApresVirgule, _parametrage.RecupererSeparateur());

                resultat += resultatApresVirgule;

                if (_parametrage.DoitGenererUneDevise())
                    resultat = AjouterLaDevise(nombrePartieDecimale, true, resultat);
            }
            return resultat;
        }

        private static bool DoitConvertirLaVirgule(Nombre chiffreAConvertirApresDecimale)
        {
            return !chiffreAConvertirApresDecimale.EstZero();
        }

        private string AjouterLaDevise(Nombre nombre, bool unitePourDecimale, string resultat)
        {
            resultat = string.Format("{0} {1}", resultat, _parametrage.RecupererUnitePourLeNombre(nombre, unitePourDecimale));
            return resultat;
        }
    }
}