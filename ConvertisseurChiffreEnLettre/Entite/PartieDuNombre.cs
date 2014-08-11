namespace ConvertisseurNombreEnLettre
{
    public abstract class PartieDuNombre
    {
        public readonly Nombre PartieDuNombreAConvertir;

        protected PartieDuNombre(Nombre partieDuNomAConvertir)
        {
            PartieDuNombreAConvertir = partieDuNomAConvertir;
        }

        public abstract string Libelle { get; }

        public virtual string Convertir()
        {
            return string.Format("{0} {1}", ConvertisseurNombreEnLettre.ConvertirAvecParametrageParDefaut(PartieDuNombreAConvertir), Libelle);
        }
    }
}