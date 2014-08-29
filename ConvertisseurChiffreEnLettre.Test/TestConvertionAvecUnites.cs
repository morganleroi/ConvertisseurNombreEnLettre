using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertionAvecUnites
    {
        [TestMethod]
        public void PeutConvertirAvecLesDevises()
        {
            var convertisseur = ConvertisseurNombreEnLettre.ConvertisseurNombreEnLettre.Parametrage
                .AppliquerUneUnite(Unite.EUR)
                .ValiderLeParametrage();

          convertisseur.Convertir(1).Should().Be("un euro");
          convertisseur.Convertir(42).Should().Be("quarante-deux euros");
        }


        [TestMethod]
        public void PeutConvertirAvecLesDevisesAvecDecimal()
        {
            var convertisseur = ConvertisseurNombreEnLettre.ConvertisseurNombreEnLettre.Parametrage
                .AppliquerUneUnite(Unite.EUR)
                .ModifierLaVirgule("et")
                .ValiderLeParametrage();

            convertisseur.Convertir(1.54m).Should().Be("un euro et cinquante-quatre centimes");
            convertisseur.Convertir(41.700m).Should().Be("quarante-et-un euros et sept-cents centimes");
        }

        [TestMethod]
        public void PeutConvertirAvecLesKg()
        {
            var convertisseur = ConvertisseurNombreEnLettre.ConvertisseurNombreEnLettre.Parametrage
                .AppliquerUneUnite(Unite.Kilogramme)
                .ValiderLeParametrage();

            convertisseur.Convertir(1).Should().Be("un kilo");
            convertisseur.Convertir(42).Should().Be("quarante-deux kilos");
        }
    }
}