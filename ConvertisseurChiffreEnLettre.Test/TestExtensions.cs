using Convertisseur.Extension;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestExtensions
    {
        [TestMethod]
        public void PeutConvertirDepuisUnInt()
        {
            42.ConvertirEnLettre().Should().Be("quarante-deux");
        }

        [TestMethod]
        public void PeutConvertirDepuisUnDecimal()
        {
            42.50m.ConvertirEnLettre().Should().Be("quarante-deux virgule cinquante");
        }
    }
}
