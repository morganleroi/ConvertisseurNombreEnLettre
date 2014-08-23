using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertionAvecDevise
    {
        [TestMethod]
        public void PeutConvertirAvecLesDevises()
        {
            var convertisseur = ConvertisseurNombreEnLettre.ConvertisseurNombreEnLettre.Parametrage.AppliquerUneDevises(Devise.EUR)
                .ValiderLeParametrage();

          convertisseur.Convertir(1).Should().Be("un euro");
          convertisseur.Convertir(42).Should().Be("quarante-deux euros");
        }
    }
}