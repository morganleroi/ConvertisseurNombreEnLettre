namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        public class FabriqueParametrageDuConvertisseur
        {
            private ParametrageDuConvertisseur _parametrageDuConvertisseur;

            public FabriqueParametrageDuConvertisseur()
            {
                _parametrageDuConvertisseur = new ParametrageDuConvertisseur();
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
        }
    }
}
