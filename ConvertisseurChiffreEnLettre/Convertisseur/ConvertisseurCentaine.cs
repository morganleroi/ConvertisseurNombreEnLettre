namespace ConvertisseurNombreEnLettre
{
    public class ConvertisseurCentaine : Convertisseur
    {
        private readonly ConvertisseurNombreEnLettre.ParametrageDuConvertisseur _parametrage;

        public ConvertisseurCentaine(Nombre nombre, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
            : base(nombre)
        {
            _parametrage = parametrage;
        }

        public override string Convertir()
        {
            var resultat = string.Empty;
            if (Nombre.NombreDeCentaine > 0)
            {
                resultat = AjouterAuResultat(Unite[Nombre.NombreDeCentaine], resultat) + " cent";
            }

            return resultat.Trim();
        }
    }
}