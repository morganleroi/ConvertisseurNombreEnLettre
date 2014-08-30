using Convertisseur.Entite;

namespace Convertisseur
{
    internal class ConvertisseurUnite : Convertisseur
    {
        public ConvertisseurUnite(Nombre partieDuNombreAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage): base(partieDuNombreAConvertir, nombreOriginal, parametrage) {
        }

        public override string Convertir()
        {
            if (PartieDuNombreAConvertir.PossedeUneSeuleDizaine() || PartieDuNombreAConvertir.EstUneExceptionDizaineSoixanteDix())
                return string.Empty;

            var resultat = string.Empty;

            if (PartieDuNombreAConvertir.NombreUnite > 0)
            {
                var convertionUnite = Unite[PartieDuNombreAConvertir.NombreUnite];

                if (PartieDuNombreAConvertir.NombreUnite == 1 && PartieDuNombreAConvertir.EstUneDizaineAvecExceptionPourUneUnite())
                    resultat = AjouterAuResultat(string.Format("{0}{1}", "et", Parametrage.RecupererSeparateur()) + convertionUnite, resultat, Parametrage.RecupererSeparateur());
                else resultat = AjouterAuResultat(convertionUnite, resultat, Parametrage.RecupererSeparateur());
            }

            return resultat.Trim();
        }
    }
}