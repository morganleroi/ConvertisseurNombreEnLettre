namespace ConvertisseurNombreEnLettre
{
    public partial class ConvertisseurNombreEnLettre
    {
        static readonly string[] Unite = { "zéro", " un", " deux", " trois", " quatre", " cinq", " six", " sept", " huit", " neuf" };

        private readonly ParametrageDuConvertisseur _parametrage;

        private ConvertisseurNombreEnLettre(ParametrageDuConvertisseur parametrage)
        {
            _parametrage = parametrage;
        }

        public static FabriqueParametrageDuConvertisseur Parametrage
        {
            get
            {
                return new FabriqueParametrageDuConvertisseur();
            }
        }

        public static string ConvertirAvecParametrageParDefaut(Nombre chiffre)
        {
            return new ConvertisseurNombreEnLettre(ParametrageDuConvertisseur.ParDefaut())
                .Convertir(chiffre);
        }

        public string Convertir(int chiffreAConvertir)
        {
            var chiffre = new Nombre(chiffreAConvertir);
            return Convertir(chiffre);
        }

        private string Convertir(Nombre nombre)
        {
            //if (nombre.EstZero())
            //    return Unite[0];
            //if (nombre.EstMille())
            //    return "mille";

            var resultat = string.Empty;
            foreach (var partieDuNombre in nombre.RecupererLaDecomposition(_parametrage))
            {
                //bool estMille = partieDuNombre is PartieDuNombreEnMillier && nombre.NombreDeMillier == 1;

                //// Todo : Qui doit avoir la responsabilité de gérer le dernier - ajouté dans le cas du PartieDuNombreEnCentaine
                //// soixante-douze-
                //if (string.IsNullOrEmpty(partieDuNombre.Libelle))
                //    resultat = ConvertirUnePartieDuNombre(partieDuNombre.PartieDuNombreAConvertir, nombre, resultat, estMille);
                //else
                //    resultat = ConvertirUnePartieDuNombre(partieDuNombre.PartieDuNombreAConvertir, nombre, resultat, estMille) +
                //               _parametrage.RecupererSeparateur() + partieDuNombre.Libelle;

             resultat =  AjouterAuResultat(partieDuNombre.Convertir(), resultat);
            }

            //// todo
            //// Gérer le cas de mille qui ajoute un tiret devant ...
            //if (resultat.StartsWith("-"))
            //  resultat = resultat.Remove(0, 1);

            return resultat.Trim();
        }

        //private string ConvertirUnePartieDuNombre(Nombre nombre, Nombre nombreInitial, string resultat, bool estMille)
        //{
        //    var convertisseurCentaine = new ConvertisseurCentaine(nombre,nombreInitial, _parametrage);
        //    resultat = AjouterAuResultat(convertisseurCentaine.Convertir(), resultat);

        //    var convertisseurDizaine = new ConvertisseurDizaine(nombre,nombreInitial, _parametrage);
        //    resultat = AjouterAuResultat(convertisseurDizaine.Convertir(), resultat);

        //    var convertisseurUnite = new ConvertisseurUnite(nombre,nombreInitial, _parametrage, estMille);
        //    resultat = AjouterAuResultat(convertisseurUnite.Convertir(), resultat);

        //    return RenvoyerLeResultat(resultat);
        //}

        private string AjouterAuResultat(string termeAAjouter, string resultat)
        {
            if (string.IsNullOrWhiteSpace(termeAAjouter))
                return resultat;

            if (!string.IsNullOrEmpty(resultat))
                return string.Format("{0}{1}{2}", resultat, _parametrage.RecupererSeparateur(), termeAAjouter.Trim());

            return resultat + termeAAjouter;
        }

        private static string RenvoyerLeResultat(string resultat)
        {
            resultat = resultat.TrimEnd('-');
            return resultat.Trim();
        }
    }
}