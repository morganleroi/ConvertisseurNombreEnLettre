namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnMillion : PartieDuNombre
    {
        public PartieDuNombreEnMillion(Nombre nombreInitial, Nombre partieDuNomAConvertir) : base(nombreInitial, partieDuNomAConvertir)
        {
        }

        protected override string Libelle
        {
            get { return (PartieDuNombreAConvertir.NombreCentaineDizaineUnite > 1) ? "millions" : "million"; }
        }
    }
}