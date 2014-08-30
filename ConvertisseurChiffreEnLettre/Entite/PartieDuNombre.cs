
namespace Convertisseur.Entite
{
    public abstract class PartieDuNombre
    {
        protected Nombre NombreOriginal { get; set; }
        protected readonly Nombre PartieDuNombreAConvertir;
        private ConvertisseurNombreEnLettre.ParametrageDuConvertisseur Parametrage { get; set; }


        protected PartieDuNombre(Nombre partieDuNomAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
        {
            NombreOriginal = nombreOriginal;
            Parametrage = parametrage;
            PartieDuNombreAConvertir = partieDuNomAConvertir;
        }

        public virtual string Convertir()
        {
            var resultat = string.Empty;

            Convertisseur convertisseur = new ConvertisseurCentaine(PartieDuNombreAConvertir, NombreOriginal, Parametrage);
            resultat = AjouterAuResultat(convertisseur.Convertir(), resultat);

            convertisseur = new ConvertisseurDizaine(PartieDuNombreAConvertir, NombreOriginal, Parametrage);
            resultat = AjouterAuResultat(convertisseur.Convertir(), resultat);

            convertisseur = new ConvertisseurUnite(PartieDuNombreAConvertir, NombreOriginal, Parametrage);
            resultat = AjouterAuResultat(convertisseur.Convertir(), resultat);

            return RenvoyerLeResultat(resultat);
        }

        protected abstract string Libelle { get; }

        private string AjouterAuResultat(string termeAAjouter, string resultat)
        {
            if (string.IsNullOrWhiteSpace(termeAAjouter))
                return resultat;

            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0}{1}{2}", resultat, Parametrage.RecupererSeparateur(), termeAAjouter.Trim());

            return resultat + termeAAjouter;
        }

        private string RenvoyerLeResultat(string resultat)
        {
            resultat += Parametrage.RecupererSeparateur() + Libelle;
            resultat = resultat.TrimEnd('-');
            return resultat.Trim();
        }
    }
}