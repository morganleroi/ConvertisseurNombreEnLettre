namespace ConvertisseurNombreEnLettre
{
    public class ConvertisseurDizaine : Convertisseur
    {
        private readonly ConvertisseurNombreEnLettre.ParametrageDuConvertisseur _parametrage;
        static readonly string[] ExceptionDizaineBelgeEtSuisse = { " ", " ", " ", " ", " ", " ", " ", " septante", " ", " nonante" };
        static readonly string[] PremiereDizaine = { " ", " dix", " onze", " douze", " treize", " quatorze", " quinze", " seize", " dix-sept", "dix-huit", "dix-neuf" };
        static readonly string[] Dizaine = { " ", " ", " vingt", " trente", " quarante", " cinquante", " soixante", " soixante-dix", " quatre-vingt", " quatre-vingt-dix" };
        
        public ConvertisseurDizaine(Nombre nombre, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
            : base(nombre)
        {
            _parametrage = parametrage;
        }

        public override string Convertir()
        {
            var resultat = string.Empty;

            if (Nombre.PossedeUneSeuleDizaine())
            {
                return ConvertirLaPremiereDizaine(resultat, Nombre);
            }

            if (Nombre.NombreDeDizaine > 1)
            {
                if (Nombre.EstUneExceptionDizaineSoixanteDix())
                {
                    resultat = AjouterAuResultat(Dizaine[Nombre.NombreDeDizaine].Replace("-dix", string.Empty), resultat);
                    return ConvertirLaPremiereDizaine(resultat, Nombre);
                }

                resultat = AjouterAuResultat(RecupererLaDizaine(Nombre.NombreDeDizaine), resultat);
            }

            return resultat.Trim();
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