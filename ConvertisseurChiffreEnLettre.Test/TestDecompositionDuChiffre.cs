using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestDecompositionDuChiffre
    {
        [TestMethod]
        public void PeutDecomposerUnNombre()
        {
            new Nombre(1).NombreCentaineDizaineUnite.Should().Be(1);
            new Nombre(1).NombreDeMillier.Should().Be(0);
            new Nombre(1).NombreDeMillion.Should().Be(0);

            new Nombre(8).NombreCentaineDizaineUnite.Should().Be(8);
            new Nombre(8).NombreDeMillier.Should().Be(0);
            new Nombre(8).NombreDeMillion.Should().Be(0);

            new Nombre(10).NombreCentaineDizaineUnite.Should().Be(10);
            new Nombre(10).NombreDeMillier.Should().Be(0);
            new Nombre(10).NombreDeMillion.Should().Be(0);

            new Nombre(98).NombreCentaineDizaineUnite.Should().Be(98);
            new Nombre(98).NombreDeMillier.Should().Be(0);
            new Nombre(98).NombreDeMillion.Should().Be(0);

            new Nombre(100).NombreCentaineDizaineUnite.Should().Be(100);
            new Nombre(100).NombreDeMillier.Should().Be(0);
            new Nombre(100).NombreDeMillion.Should().Be(0);

            new Nombre(1546567).NombreCentaineDizaineUnite.Should().Be(567);
            new Nombre(1546567).NombreDeMillier.Should().Be(546);
            new Nombre(1546567).NombreDeMillion.Should().Be(1);
        }

        [TestMethod]
        public void PeutConvertirUnePartieEnMillion()
        {
            var partieEnMillion = new PartieDuNombreEnMillion(new Nombre(1),new Nombre(1));
            partieEnMillion.Convertir().Should().Be("un million");
        }

        [TestMethod]
        public void PeutConvertirUnePartieEnMillionAvecAccord()
        {
            var partieEnMillion = new PartieDuNombreEnMillion(new Nombre(2),new Nombre(2));
            partieEnMillion.Convertir().Should().Be("deux millions");
        }

        [TestMethod]
        public void PeutConvertirUnePartieEnMillier()
        {
            var partieEnMillier = new PartieDuNombreEnMillier(new Nombre(2),new Nombre(2));
            partieEnMillier.Convertir().Should().Be("deux mille");
        }

        //[TestMethod]
        //public void PeutConvertirUnePartieEnCentaine()
        //{
        //    var partieEnMillier = new PartieDuNombreEnCentaine(2);
        //    partieEnMillier.Convertir().Should().Be("deux mille");
        //}

        //[TestMethod]
        //public void PeutDecomposerUnNombreEnSousPartie()
        //{
        //    var decomposition = new Nombre(1546567);
        //    var listeDesPartiesDuNombre = decomposition.RecupererLaDecomposition();
        //    listeDesPartiesDuNombre.Should().HaveCount(3);

        //    listeDesPartiesDuNombre[0].Should().BeOfType<PartieDuNombreEnMillion>();
        //    listeDesPartiesDuNombre[1].Should().BeOfType<PartieDuNombreEnMillier>();
        //    listeDesPartiesDuNombre[2].Should().BeOfType<PartieDuNombreEnCentaine>();

        //    listeDesPartiesDuNombre[0].Convertir().Should().Be("un million");
        //    listeDesPartiesDuNombre[1].Convertir().Should().Be("cinq cent quarante six mille");
        //    listeDesPartiesDuNombre[2].Convertir().Should().Be("cinq cent soixante sept");
        //}
    }
}
