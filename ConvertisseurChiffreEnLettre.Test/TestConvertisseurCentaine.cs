using Convertisseur.Extension;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertisseurCentaine
    {
        [TestMethod]
        public void PeutConvertirLesCentaines()
        {
            272.ConvertirEnLettre().Should().Be("deux-cent-soixante-douze");
            377.ConvertirEnLettre().Should().Be("trois-cent-soixante-dix-sept");
        }

        [TestMethod]
        public void PeutGererLesAccordsDeCent()
        {
            100.ConvertirEnLettre().Should().Be("cent");
            200.ConvertirEnLettre().Should().Be("deux-cents");
            204.ConvertirEnLettre().Should().Be("deux-cent-quatre");
        }
    }
}
