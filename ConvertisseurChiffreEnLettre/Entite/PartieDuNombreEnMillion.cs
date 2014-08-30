namespace Convertisseur.Entite
{
    internal class PartieDuNombreEnMillion : PartieDuNombre
    {
        private const string Millions = "millions";
        private const string Million = "million";

        public PartieDuNombreEnMillion(Nombre partieDuNomAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage) : base(partieDuNomAConvertir, nombreOriginal, parametrage) { }

        protected override string Libelle
        {
            get { return (PartieDuNombreAConvertir.NombreCentaineDizaineUnite > 1) ? Millions : Million; }
        }
    }
}