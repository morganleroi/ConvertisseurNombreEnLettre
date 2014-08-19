namespace ConvertisseurNombreEnLettre
{
    public abstract class Convertisseur
    {
        public Nombre NombreOriginal { get; set; }
        protected static readonly string[] Unite = { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf" };

        protected readonly Nombre PartieDuNombreAConvertir;
        protected readonly ConvertisseurNombreEnLettre.ParametrageDuConvertisseur _parametrage;

        protected Convertisseur(Nombre partieDuNombreAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
        {
            NombreOriginal = nombreOriginal;
            PartieDuNombreAConvertir = partieDuNombreAConvertir;
            _parametrage = parametrage;
        }

        public abstract string Convertir();

        protected string AjouterAuResultat(string termeAAjouter, string resultat)
        {
            if (!string.IsNullOrEmpty(resultat))
            {
                string separateur = _parametrage.RegleDesTiretsDe1990 ? "-" : " ";
                return string.Format("{0}{1}{2}", resultat,separateur, termeAAjouter.Trim());
            }
            return resultat + termeAAjouter;
        }
    }
}