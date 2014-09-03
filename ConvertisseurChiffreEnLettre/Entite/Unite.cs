namespace Convertisseur.Entite
{
    public class Unite
    {
        private readonly string _singulierPartieEntiere;
        private readonly string _singulierPartieDecimale;
        private readonly string _plurielPartieEntiere;
        private readonly string _plurielPartieDecimale;

        private Unite(string singulierPartieEntiere, string plurielPartieEntiere, string singulierePartieDecimale, string plurielPartieDecimale)
        {
            _singulierPartieEntiere = singulierPartieEntiere;
            _singulierPartieDecimale = singulierePartieDecimale;
            _plurielPartieEntiere = plurielPartieEntiere;
            _plurielPartieDecimale = plurielPartieDecimale;
        }

        public static Unite EUR
        {
            get
            {
                return new Unite("euro", "euros", "centime", "centimes");
            }
        }

        public static Unite Kilogramme
        {
            get
            {
                return new Unite("kilo", "kilos", "gramme", "grammes");
            }
        }

        public string Singulier(bool unitePourDecimale)
        {
            return unitePourDecimale ? _singulierPartieDecimale : _singulierPartieEntiere;
        }

        public string Pluriel(bool unitePourDecimale)
        {
            return unitePourDecimale ? _plurielPartieDecimale : _plurielPartieEntiere;
        }

        public static Unite Creer(string singulierPartieEntiere, string plurielPartieEntiere, string singulierePartieDecimale, string plurielPartieDecimale)
        {
           return new Unite(singulierPartieEntiere, plurielPartieEntiere, singulierePartieDecimale, plurielPartieDecimale);
        }
    }
}