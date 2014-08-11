namespace ConvertisseurNombreEnLettre
{
    public abstract class Convertisseur
    {
        protected static readonly string[] Unite = { "zéro", " un", " deux", " trois", " quatre", " cinq", " six", " sept", " huit", " neuf" };

        protected readonly Nombre Nombre;

        protected Convertisseur(Nombre nombre)
        {
            Nombre = nombre;
        }

        public abstract string Convertir();

        protected string AjouterAuResultat(string termeAAjouter, string resultat)
        {
            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0} {1}", resultat, termeAAjouter.Trim());

            //if (_parametrage.RegleDesTiretsDe1990 && !string.IsNullOrEmpty(resultat))
            //    return string.Format("{0}-{1}", resultat, termeAAjouter.Trim());
            return resultat + termeAAjouter;
        }
    }
}