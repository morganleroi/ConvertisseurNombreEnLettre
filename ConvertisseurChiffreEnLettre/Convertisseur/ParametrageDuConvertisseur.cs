namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        public partial class ParametrageDuConvertisseur
        {
            public bool RegleDesTiretsDe1990 { get; set; }
            public bool RegleDeTraductionBelgeEtSuisse { get; set; }

            public static ParametrageDuConvertisseur ParDefaut()
            {
                return new ParametrageDuConvertisseur();
            }
        }
    }
}
