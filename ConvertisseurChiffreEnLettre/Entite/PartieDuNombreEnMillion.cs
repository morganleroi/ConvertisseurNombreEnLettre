namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnMillion : PartieDuNombre
    {
        public PartieDuNombreEnMillion(Nombre partieDuNomAConvertir) : base(partieDuNomAConvertir){}

        public override string Libelle
        {
            get { return (PartieDuNombreAConvertir.NombreCentaineDizaineUnite > 1) ? "millions" : "million"; }
        }
    }
}