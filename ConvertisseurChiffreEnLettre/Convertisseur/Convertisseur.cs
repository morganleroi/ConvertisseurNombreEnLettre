namespace ConvertisseurNombreEnLettre
{
    public abstract class Convertisseur
    {
        protected readonly PartieDuNombre PartieDuNombreAConvertir;

        protected Convertisseur(PartieDuNombre partieDuNombreAConvertir)
        {
            PartieDuNombreAConvertir = partieDuNombreAConvertir;
        }

        public abstract void Convertir();
    }
}