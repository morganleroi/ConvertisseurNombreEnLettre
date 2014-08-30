using System;
using System.Collections.Generic;
using System.Linq;

namespace Convertisseur.Entite
{
    public class Nombre
    {
        // 21, 31, 41, 51, 61
        private static readonly int[] DizaineAvecExceptionPourUneUnite = { 2, 3, 4, 5, 6 };
        private readonly int _nombre;

        public Nombre(int nombre)
        {
            _nombre = nombre;
            DecomposerLeNombre();
        }

        public int NombreDeMillion { get; private set; }

        public int NombreDeMillier { get; private set; }

        public int NombreDeCentaine { get; private set; }

        public int NombreDeDizaine { get; private set; }

        public int NombreUnite { get; private set; }

        public int NombreCentaineDizaineUnite { get; private set; }

        public bool EstUneDizaineAvecExceptionPourUneUnite()
        {
            return DizaineAvecExceptionPourUneUnite.Any(x => x == NombreDeDizaine);
        }

        public IEnumerable<PartieDuNombre> RecupererLaDecomposition(ConvertisseurNombreEnLettre.ParametrageDuConvertisseur parametrage)
        {
            var chiffreDeCompose = new List<PartieDuNombre>();

            if (NombreDeMillion > 0)
                chiffreDeCompose.Add(new PartieDuNombreEnMillion(new Nombre(NombreDeMillion), new Nombre(_nombre), parametrage));

            if (NombreDeMillier > 0)
                chiffreDeCompose.Add(new PartieDuNombreEnMillier(new Nombre(NombreDeMillier), new Nombre(_nombre), parametrage));

            if (NombreCentaineDizaineUnite >= 0)
                chiffreDeCompose.Add(new PartieDuNombreEnCentaineDizaineUnite(new Nombre(NombreCentaineDizaineUnite), new Nombre(_nombre), parametrage));

            return chiffreDeCompose;
        }

        private void DecomposerLeNombre()
        {
            var decompositionDuChiffre = new int[10];

            for (int i = 0; i < 10; i++)
                decompositionDuChiffre[i] = (int)((_nombre / Math.Pow(10, i)) % 10);

            NombreDeMillion = RecupererAPartirDeLaDecomposition(decompositionDuChiffre, 6, 8);
            NombreDeMillier = RecupererAPartirDeLaDecomposition(decompositionDuChiffre, 3, 5);
            NombreCentaineDizaineUnite = RecupererAPartirDeLaDecomposition(decompositionDuChiffre, 0, 2);
            NombreDeCentaine = RecupererAPartirDeLaDecomposition(decompositionDuChiffre, 2, 2);
            NombreDeDizaine = RecupererAPartirDeLaDecomposition(decompositionDuChiffre, 1, 1);
            NombreUnite = RecupererAPartirDeLaDecomposition(decompositionDuChiffre, 0, 0);
        }

        private int RecupererAPartirDeLaDecomposition(int[] decompositionDuChiffre, int indexDebut, int indexFin)
        {
            var nombre = 0;
            for (var i = indexDebut; i <= indexFin; i++)
                nombre += (int)(decompositionDuChiffre[i] * Math.Pow(10, i));
            return (int)(nombre / Math.Pow(10, indexDebut));
        }

        public bool PossedeUneSeuleDizaine()
        {
            return this.NombreDeDizaine == 1;
        }

        public bool PossedePlusieursDizaine()
        {
            return this.NombreDeDizaine > 1;
        }

        public bool EstUneExceptionDizaineSoixanteDix()
        {
            return this.NombreDeDizaine == 7 && this.NombreUnite > 0;
        }

        public bool EstZero()
        {
            return _nombre == 0;
        }

        public bool EstQuatreVingt()
        {
            return _nombre == 80;
        }

        public bool EstUn()
        {
            return _nombre == 1;
        }
    }
}