namespace Convertisseur.Entite
{
    internal class PartieDuNombreEnMillier : PartieDuNombre
    {
        private const string Mille = "mille";
        public PartieDuNombreEnMillier(Nombre partieDuNomAConvertir, Nombre nombreOriginal, ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage) : base(partieDuNomAConvertir, nombreOriginal, parametrage) { }

        public override string Convertir()
        {
            if (PartieDuNombreAConvertir.NombreUnite == 1)
                return Mille;

            return base.Convertir();
        }

        protected override string Libelle
        {
            get { return Mille; }
        }
    }
}