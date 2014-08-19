namespace ConvertisseurNombreEnLettre
{
    public class ConvertisseurCentaine : Convertisseur
    {
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
                    return "cent";

                var cent = "cent";
                if(PartieDuNombreAConvertir.NombreDeDizaine == 0 && PartieDuNombreAConvertir.NombreUnite == 0)
                    cent = "cents";

                resultat = string.Format("{0}{1}{2}", AjouterAuResultat(Unite[PartieDuNombreAConvertir.NombreDeCentaine], resultat), _parametrage.RecupererSeparateur(), cent);
            }

            return resultat.Trim();
        }
    }
}