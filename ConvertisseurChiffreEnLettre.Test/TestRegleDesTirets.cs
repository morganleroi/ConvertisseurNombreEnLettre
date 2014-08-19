using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestRegleDesTirets
    {
        [TestMethod]
        public void PeutAppliquerLaRegleDesTiretsParDefaut()
        {
            272.ConvertirEnLettre().Should().Be("deux-cent-soixante-douze");
        }
    }
}
