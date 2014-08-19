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
    }
}