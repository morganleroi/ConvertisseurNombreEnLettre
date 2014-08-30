using Convertisseur.Entite;

namespace Convertisseur
{
    internal class ConvertisseurDizaine : Convertisseur
    {
        static readonly string[] ExceptionDizaineBelgeEtSuisse = { " ", " ", " ", " ", " ", " ", " ", " septante", " ", " nonante" };
        static readonly string[] PremiereDizaine = { " ", " dix", " onze", " douze", " treize", " quatorze", " quinze", " seize", " dix-sept", "dix-huit", "dix-neuf" };
        static readonly string[] Dizaine = { " ", " ", " vingt", " trente", " quarante", " cinquante", " soixante", " soixante-dix", " quatre-vingt", " quatre-vingt-dix" };
        
        public ConvertisseurDizaine(Nombre partieDuNombreAConvertir,Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
            : base(partieDuNombreAConvertir,nombreOriginal, parametrage) {}

        public override string Convertir()
        {
            var resultat = string.Empty;

            if (PartieDuNombreAConvertir.PossedeUneSeuleDizaine())
                return ConvertirLaPremiereDizaine(resultat, PartieDuNombreAConvertir);

            if (PartieDuNombreAConvertir.PossedePlusieursDizaine())
            {
                if (PartieDuNombreAConvertir.EstUneExceptionDizaineSoixanteDix())
                    return GererExceptionSoixanteDix(resultat);

                var dizaine = RecupererLaDizaine(PartieDuNombreAConvertir.NombreDeDizaine);

                if (NombreOriginal.EstQuatreVingt())
                    dizaine = GererAccordQuatreVingt(dizaine);

                resultat = AjouterAuResultat(dizaine, resultat, Parametrage.RecupererSeparateur());
            }

            return resultat.Trim();
        }

        private string GererExceptionSoixanteDix(string resultat)
        {
            resultat = AjouterAuResultat(Dizaine[PartieDuNombreAConvertir.NombreDeDizaine].Replace("-dix", string.Empty),
                resultat, Parametrage.RecupererSeparateur());

            if (PartieDuNombreAConvertir.NombreUnite == 1)
                resultat = GererExceptionSoixanteEtOnze(resultat);

            return ConvertirLaPremiereDizaine(resultat, PartieDuNombreAConvertir);
        }

        private static string GererAccordQuatreVingt(string dizaine)
        {
            dizaine += "s";
            return dizaine;
        }

        private string GererExceptionSoixanteEtOnze(string resultat)
        {
            resultat = AjouterAuResultat("et", resultat, Parametrage.RecupererSeparateur());
            return resultat;
        }

        private string ConvertirLaPremiereDizaine(string resultat, Nombre chiffre)
        {
            resultat = AjouterAuResultat(PremiereDizaine[chiffre.NombreUnite + 1], resultat, Parametrage.RecupererSeparateur());
            return resultat.Trim();
        }

        private string RecupererLaDizaine(int nombreDeDizaine)
        {
            if (Parametrage.RegleDeTraductionBelgeEtSuisse)
            {
                return ExceptionDizaineBelgeEtSuisse[nombreDeDizaine];
            }

            return Dizaine[nombreDeDizaine];
        }
    }
}