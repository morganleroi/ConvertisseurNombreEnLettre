namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnMillier : PartieDuNombre
    {
        public PartieDuNombreEnMillier(Nombre partieDuNomAConvertir) : base(partieDuNomAConvertir){}

        public override string Libelle
        {
            get { return "mille"; }
        }
    }
}