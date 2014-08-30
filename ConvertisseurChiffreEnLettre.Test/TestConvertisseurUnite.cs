using Convertisseur.Extension;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertisseurUnite
    {
        [TestMethod]
        public void PeutConvertirLesUnites()
        {
            0.ConvertirEnLettre().Should().Be("zéro");
            1.ConvertirEnLettre().Should().Be("un");
            2.ConvertirEnLettre().Should().Be("deux");
            3.ConvertirEnLettre().Should().Be("trois");
            4.ConvertirEnLettre().Should().Be("quatre");
            5.ConvertirEnLettre().Should().Be("cinq");
            6.ConvertirEnLettre().Should().Be("six");
            7.ConvertirEnLettre().Should().Be("sept");
            8.ConvertirEnLettre().Should().Be("huit");
            9.ConvertirEnLettre().Should().Be("neuf");
        }
    }
}
