namespace ConvertisseurNombreEnLettre
{
    public abstract class PartieDuNombre
    {
        public Nombre NombreInitial;
        protected Nombre PartieDuNombreAConvertir;

        public PartieDuNombre(Nombre nombreInitial, Nombre partieDuNomAConvertir)
        {
            NombreInitial = nombreInitial;
            PartieDuNombreAConvertir = partieDuNomAConvertir;
        }

        protected abstract string Libelle { get; }

        public virtual string Convertir()
        {
            //return string.Empty;
            return string.Format("{0} {1}", ConvertisseurNombreEnLettre.ConvertirAvecParametrageParDefaut(PartieDuNombreAConvertir), Libelle);
        }
    }
}