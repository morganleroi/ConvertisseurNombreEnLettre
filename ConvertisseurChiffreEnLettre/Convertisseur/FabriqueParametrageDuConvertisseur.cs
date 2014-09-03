using Convertisseur.Entite;

namespace Convertisseur
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

            public FabriqueParametrageDuConvertisseur AppliquerUneUnite(Unite unite)
            {
                _parametrageDuConvertisseur.Unite = unite;
                return this;
            }

            public FabriqueParametrageDuConvertisseur ModifierLaVirgule(string terme)
            {
                _parametrageDuConvertisseur.Virgule = terme;
                return this;
            }

            public ConvertisseurNombreEnLettre ParDefaut()
            {
                return new ConvertisseurNombreEnLettre(_parametrageDuConvertisseur);
            }

            public FabriqueParametrageDuConvertisseur AppliquerLaRegleDesTirets(RegleTirets regle)
            {
                _parametrageDuConvertisseur.RegleDesTirets = regle;
                return this;
            }
        }
    }

    public enum RegleTirets
    {
        TiretsPartoutSaufMillierMillionsMilliards
    }
}
