namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnCentaine : PartieDuNombre
    {
        public PartieDuNombreEnCentaine(Nombre partieDuNomAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage) : base(partieDuNomAConvertir, nombreOriginal, parametrage) { }

        public override string Convertir()
        {
            if (NombreOriginal.EstZero())
                return Convertisseur.Unite[0];

            return base.Convertir();
        }

        protected override string Libelle
        {
            get { return string.Empty; }
        }
    }
}