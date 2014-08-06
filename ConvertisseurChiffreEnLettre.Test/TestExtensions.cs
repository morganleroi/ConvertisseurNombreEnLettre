using ConvertisseurNombreEnLettre;
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
    }
}
