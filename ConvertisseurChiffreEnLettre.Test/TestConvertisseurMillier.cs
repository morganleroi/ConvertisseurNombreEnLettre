using Convertisseur.Extension;
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
            1000.ConvertirEnLettre().Should().Be("mille");
            2000.ConvertirEnLettre().Should().Be("deux-mille");
            1001.ConvertirEnLettre().Should().Be("mille-un");
            1010.ConvertirEnLettre().Should().Be("mille-dix");
            1100.ConvertirEnLettre().Should().Be("mille-cent");
            1101.ConvertirEnLettre().Should().Be("mille-cent-un");
            1111.ConvertirEnLettre().Should().Be("mille-cent-onze");
            3272.ConvertirEnLettre().Should().Be("trois-mille-deux-cent-soixante-douze");
            23272.ConvertirEnLettre().Should().Be("vingt-trois-mille-deux-cent-soixante-douze");
            235272.ConvertirEnLettre().Should().Be("deux-cent-trente-cinq-mille-deux-cent-soixante-douze");
        }
    }
}
