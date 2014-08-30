using Convertisseur.Entite;

namespace Convertisseur
{
    internal abstract class Convertisseur
    {
        public static readonly string[] Unite = { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf" };

        protected readonly Nombre NombreOriginal;
        protected readonly Nombre PartieDuNombreAConvertir;
        protected readonly ConvertisseurNombreEnLettre.ParametrageDuConvertisseur Parametrage;

        protected Convertisseur(Nombre partieDuNombreAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
        {
            NombreOriginal = nombreOriginal;
            PartieDuNombreAConvertir = partieDuNombreAConvertir;
            Parametrage = parametrage;
        }

        public abstract string Convertir();


        public static string AjouterAuResultat(string termeAAjouter, string resultat, string separateur)
        {
            if (string.IsNullOrWhiteSpace(termeAAjouter))
                return resultat;

            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0}{1}{2}", resultat, separateur, termeAAjouter.Trim());

            return resultat + termeAAjouter;
        }
    }
}