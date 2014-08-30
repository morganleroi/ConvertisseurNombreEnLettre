using Convertisseur.Entite;

namespace Convertisseur
{
    internal class ConvertisseurCentaine : Convertisseur
    {
        private const string Cent = "cent";
        private const string Cents = "cents";

        public ConvertisseurCentaine(Nombre partieDuNombreAConvertir, Nombre nombreOriginal,ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
            : base(partieDuNombreAConvertir, nombreOriginal, parametrage)
        {
        }

        public override string Convertir()
        {
            var resultat = string.Empty;
            
            if (PartieDuNombreAConvertir.NombreDeCentaine > 0)
            {
                if (PartieDuNombreAConvertir.NombreDeCentaine == 1)
                    return Cent;
                    
                var libelle = Cent;
                if(PartieDuNombreAConvertir.NombreDeDizaine == 0 && PartieDuNombreAConvertir.NombreUnite == 0)
                    libelle = Cents;

                resultat = string.Format("{0}{1}{2}", AjouterAuResultat(Unite[PartieDuNombreAConvertir.NombreDeCentaine], resultat, Parametrage.RecupererSeparateur()), Parametrage.RecupererSeparateur(), libelle);
            }

            return resultat.Trim();
        }
    }
}