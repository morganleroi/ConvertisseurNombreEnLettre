namespace ConvertisseurNombreEnLettre
{
    public class ConvertisseurUnite : Convertisseur
    {
        public ConvertisseurUnite(Nombre partieDuNombreAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage): base(partieDuNombreAConvertir, nombreOriginal, parametrage) {}

        public override string Convertir()
        {
            if (PartieDuNombreAConvertir.PossedeUneSeuleDizaine() || PartieDuNombreAConvertir.EstUneExceptionDizaineSoixanteDix())
                return string.Empty;

            var resultat = string.Empty;

            if (PartieDuNombreAConvertir.NombreUnite > 0)
            {
                string convertionUnite = Unite[PartieDuNombreAConvertir.NombreUnite];

                if (PartieDuNombreAConvertir.NombreUnite == 1 && PartieDuNombreAConvertir.EstUneDizaineAvecExceptionPourUneUnite())
                {
                    resultat = AjouterAuResultat(string.Format("{0}{1}", "et", _parametrage.RecupererSeparateur()) + convertionUnite, resultat);
                }
                else resultat = AjouterAuResultat(convertionUnite, resultat);
            }

            return resultat.Trim();
        }
    }
}