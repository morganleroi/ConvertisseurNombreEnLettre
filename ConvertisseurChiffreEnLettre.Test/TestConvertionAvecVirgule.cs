using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertionAvecVirgule
    {
        [TestMethod]
        public void PeutConvertirAvecUneVirgule()
        {
            1.54m.ConvertirEnLettre().Should().Be("un virgule cinquante-quatre");
            1.1205m.ConvertirEnLettre().Should().Be("un virgule mille-deux-cent-cinq");
            1001000.1001000m.ConvertirEnLettre().Should().Be("un-million-mille virgule un-million-mille");
        }
    }
}