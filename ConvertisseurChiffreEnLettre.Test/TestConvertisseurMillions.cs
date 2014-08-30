using Convertisseur.Extension;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertisseurMillion
    {
        [TestMethod]
        public void PeutConvertirLesMillions()
        {
            1000000.ConvertirEnLettre().Should().Be("un-million");
            1000100.ConvertirEnLettre().Should().Be("un-million-cent");
            1001000.ConvertirEnLettre().Should().Be("un-million-mille");
            1001001.ConvertirEnLettre().Should().Be("un-million-mille-un");
            2344678.ConvertirEnLettre().Should().Be("deux-millions-trois-cent-quarante-quatre-mille-six-cent-soixante-dix-huit");
        }
    }
}
