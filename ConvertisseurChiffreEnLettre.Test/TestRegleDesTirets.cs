using Convertisseur;
using Convertisseur.Extension;
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

        //[TestMethod]
        //public void PeutAppliquerLaRegleDesTirets1990SaufMillierMillionsMilliars()
        //{
        //  var convertisseur = ConvertisseurNombreEnLettre.Parametrage
        //        .AppliquerLaRegleDesTirets(RegleTirets.TiretsPartoutSaufMillierMillionsMilliards)
        //        .ValiderLeParametrage();

        //    272.ConvertirEnLettre().Should().Be("deux-cent-soixante-douze");
        //   convertisseur.Convertir(1272).Should().Be("mille deux-cent-soixante-douze");
        //}
    }
}
