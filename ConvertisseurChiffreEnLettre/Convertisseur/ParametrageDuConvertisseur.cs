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
                return new ParametrageDuConvertisseur
                {
                    RegleDeTraductionBelgeEtSuisse = false,
                    RegleDesTiretsDe1990 = true
                };
            }

            public string RecupererSeparateur()
            {
                return RegleDesTiretsDe1990 ? "-" : " ";
            }
        }
    }
}
