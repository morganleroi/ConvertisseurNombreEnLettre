using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertisseurMillier
    {
        [TestMethod]
        public void PeutConvertirLesMilliers()
        {
            3272.ConvertirEnLettre().Should().Be("trois-mille-deux-cent-soixante-douze");
            23272.ConvertirEnLettre().Should().Be("vingt-trois-mille-deux-cent-soixante-douze");
            235272.ConvertirEnLettre().Should().Be("deux-cent-trente-cinq-mille-deux-cent-soixante-douze");
        }
    }
}
