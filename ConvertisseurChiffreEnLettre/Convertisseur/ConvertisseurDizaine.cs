namespace ConvertisseurNombreEnLettre
{
    public class ConvertisseurDizaine : Convertisseur
    {
        static readonly string[] ExceptionDizaineBelgeEtSuisse = { " ", " ", " ", " ", " ", " ", " ", " septante", " ", " nonante" };
        static readonly string[] PremiereDizaine = { " ", " dix", " onze", " douze", " treize", " quatorze", " quinze", " seize", " dix-sept", "dix-huit", "dix-neuf" };
        static readonly string[] Dizaine = { " ", " ", " vingt", " trente", " quarante", " cinquante", " soixante", " soixante-dix", " quatre-vingt", " quatre-vingt-dix" };
        
        public ConvertisseurDizaine(Nombre partieDuNombreAConvertir,Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
            : base(partieDuNombreAConvertir,nombreOriginal, parametrage)
        {
        }

        public override string Convertir()
        {
            var resultat = string.Empty;

            if (PartieDuNombreAConvertir.PossedeUneSeuleDizaine())
            {
                return ConvertirLaPremiereDizaine(resultat, PartieDuNombreAConvertir);
            }

            if (PartieDuNombreAConvertir.NombreDeDizaine > 1)
            {
                if (PartieDuNombreAConvertir.EstUneExceptionDizaineSoixanteDix())
                {
                    resultat = AjouterAuResultat(Dizaine[PartieDuNombreAConvertir.NombreDeDizaine].Replace("-dix", string.Empty), resultat);

                    if (PartieDuNombreAConvertir.NombreUnite == 1)
                        resultat = GererExceptionSoixanteEtOnze(resultat);
                    
                    return ConvertirLaPremiereDizaine(resultat, PartieDuNombreAConvertir);
                }


                string dizaine = RecupererLaDizaine(PartieDuNombreAConvertir.NombreDeDizaine);

                if (NombreOriginal.EstQuatreVingt())
                    dizaine += "s";

                resultat = AjouterAuResultat(dizaine, resultat);
            }

            return resultat.Trim();
        }

        private string GererExceptionSoixanteEtOnze(string resultat)
        {
            resultat = AjouterAuResultat("et", resultat);
            return resultat;
        }

        private string ConvertirLaPremiereDizaine(string resultat, Nombre chiffre)
        {
            resultat = AjouterAuResultat(PremiereDizaine[chiffre.NombreUnite + 1], resultat);
            return resultat.Trim();
        }

        private string RecupererLaDizaine(int nombreDeDizaine)
        {
            if (_parametrage.RegleDeTraductionBelgeEtSuisse)
            {
                return ExceptionDizaineBelgeEtSuisse[nombreDeDizaine];
            }

            return Dizaine[nombreDeDizaine];
        }
    }
}