using ConvertisseurNombreEnLettre;
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
            2344678.ConvertirEnLettre().Should().Be("deux-millions-trois-cent-quarante-quatre-mille-six-cent-soixante-dix-huit");
        }
    }
}
