namespace ConvertisseurNombreEnLettre
{
    public class ConvertisseurUnite : Convertisseur
    {
        public ConvertisseurUnite(Nombre nombre): base(nombre) {}

        public override string Convertir()
        {
            if (Nombre.PossedeUneSeuleDizaine() || Nombre.EstUneExceptionDizaineSoixanteDix())
                return string.Empty;

            var resultat = string.Empty;

            if (Nombre.NombreUnite > 0)
            {
                string convertionUnite = Unite[Nombre.NombreUnite];

                if (Nombre.NombreUnite == 1 && Nombre.EstUneDizaineAvecExceptionPourUneUnite())
                {
                    resultat = AjouterAuResultat(" et" + convertionUnite, resultat);
                }
                else resultat = AjouterAuResultat(convertionUnite, resultat);
            }

            return resultat.Trim();
        }
    }
}