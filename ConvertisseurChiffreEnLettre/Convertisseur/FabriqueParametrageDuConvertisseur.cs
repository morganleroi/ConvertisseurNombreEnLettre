namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        public class FabriqueParametrageDuConvertisseur
        {
            private readonly ParametrageDuConvertisseur _parametrageDuConvertisseur;

            public FabriqueParametrageDuConvertisseur()
            {
                _parametrageDuConvertisseur = ParametrageDuConvertisseur.ParDefaut();
            }

            public FabriqueParametrageDuConvertisseur AppliquerLaRegleDesTiretsDe1990(bool appliquerLaRegle)
            {
                _parametrageDuConvertisseur.RegleDesTiretsDe1990 = appliquerLaRegle;
                return this;
            }

            public FabriqueParametrageDuConvertisseur AppliquerLaRegleDeTraductionBelgeEtSuisse(bool appliquerLaRegle)
            {
                _parametrageDuConvertisseur.RegleDeTraductionBelgeEtSuisse = appliquerLaRegle;
                return this;
            }

            public ConvertisseurNombreEnLettre ValiderLeParametrage()
            {
                return new ConvertisseurNombreEnLettre(_parametrageDuConvertisseur);
            }

            public FabriqueParametrageDuConvertisseur AppliquerUneDevises(Devise devise)
            {
                _parametrageDuConvertisseur.Devise = devise;
                return this;
            }
        }
    }

    public class Devise
    {
        private readonly string _singulier;
        private readonly string _pluriel;

        private Devise(string singulier, string pluriel)
        {
            _singulier = singulier;
            _pluriel = pluriel;
        }

        public static Devise EUR
        {
            get
            {
                return new Devise("euro", "euros");
            }
        }

        public string Singulier()
        {
            return _singulier;
        }

        public string Pluriel()
        {
            return _pluriel;
        }
    }
}
