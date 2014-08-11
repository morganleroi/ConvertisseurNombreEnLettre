namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnCentaine : PartieDuNombre
    {
        public PartieDuNombreEnCentaine(Nombre partieDuNomAConvertir) : base(partieDuNomAConvertir){}

        public override string Libelle
        {
            get { return ""; }
        }
    }
}