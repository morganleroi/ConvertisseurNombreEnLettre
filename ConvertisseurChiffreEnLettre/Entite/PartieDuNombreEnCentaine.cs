namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnCentaine : PartieDuNombre
    {

        //public override Convertisseur Convertisseur { get; set; }

        public PartieDuNombreEnCentaine(Nombre nombreInitial, Nombre partieDuNomAConvertir) : base(nombreInitial, partieDuNomAConvertir)
        {
        }

        protected override string Libelle
        {
            get { return "cent"; }
        }
    }
}