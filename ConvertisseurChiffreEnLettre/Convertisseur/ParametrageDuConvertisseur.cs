namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        public partial class ParametrageDuConvertisseur
        {
            public bool RegleDesTiretsDe1990 { get; set; }
            public bool RegleDeTraductionBelgeEtSuisse { get; set; }
            public Unite Unite { get; set; }
            public string Virgule { get; set; }

            public static ParametrageDuConvertisseur ParDefaut()
            {
                return new ParametrageDuConvertisseur
                {
                    RegleDeTraductionBelgeEtSuisse = false,
                    RegleDesTiretsDe1990 = true,
                    Virgule = ","
                };
            }

            public string RecupererSeparateur()
            {
                return RegleDesTiretsDe1990 ? "-" : " ";
            }

            public string RecupererUnitePourLeNombre(Nombre nombre, bool unitePourDecimale)
            {
                return (nombre.EstZero() || nombre.EstUn()) ? Unite.Singulier(unitePourDecimale) : Unite.Pluriel(unitePourDecimale);
            }

            public bool DoitGenererUneDevise()
            {
                return Unite != null;
            }

            public string RecupererLaVirgule()
            {
                if (Virgule == ",")
                    return string.Format("{0} ", Virgule);
                return string.Format(" {0} ",Virgule);
            }
        }
    }
}
