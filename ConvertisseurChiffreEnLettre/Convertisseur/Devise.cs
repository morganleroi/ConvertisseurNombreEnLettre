namespace ConvertisseurNombreEnLettre
{
    public class Devise
    {
        private readonly string _singulier;
        private readonly string _pluriel;

        private Devise(string singulier, string pluriel)
        {
            _singulier = singulier;
            _pluriel = pluriel;
        }

        public static Devise EUR
        {
            get
            {
                return new Devise("euro", "euros");
            }
        }

        public string Singulier()
        {
            return _singulier;
        }

        public string Pluriel()
        {
            return _pluriel;
        }
    }
}