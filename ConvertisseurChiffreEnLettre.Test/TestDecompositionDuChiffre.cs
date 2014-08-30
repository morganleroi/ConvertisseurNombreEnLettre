using Convertisseur.Entite;
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
    }
}
