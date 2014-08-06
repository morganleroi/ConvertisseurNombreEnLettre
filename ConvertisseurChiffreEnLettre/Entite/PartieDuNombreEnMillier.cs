namespace ConvertisseurNombreEnLettre
{
    public class PartieDuNombreEnMillier : PartieDuNombre
    {


        //public override Convertisseur Convertisseur { get; set; }

        public PartieDuNombreEnMillier(Nombre nombreInitial, Nombre partieDuNomAConvertir) : base(nombreInitial, partieDuNomAConvertir)
        {
        }

        protected override string Libelle
        {
            get { return "mille"; }
        }
    }
}