using Convertisseur;
using Convertisseur.Extension;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertisseurDizaine
    {
        [TestMethod]
        public void PeutConvertirEntre10Et20()
        {
            10.ConvertirEnLettre().Should().Be("dix");
            11.ConvertirEnLettre().Should().Be("onze");
            12.ConvertirEnLettre().Should().Be("douze");
            13.ConvertirEnLettre().Should().Be("treize");
            14.ConvertirEnLettre().Should().Be("quatorze");
            15.ConvertirEnLettre().Should().Be("quinze");
            16.ConvertirEnLettre().Should().Be("seize");
            17.ConvertirEnLettre().Should().Be("dix-sept");
            18.ConvertirEnLettre().Should().Be("dix-huit");
            19.ConvertirEnLettre().Should().Be("dix-neuf");
        }

        [TestMethod]
        public void PeutConvertirLesDizaines()
        {
            20.ConvertirEnLettre().Should().Be("vingt");
            30.ConvertirEnLettre().Should().Be("trente");
            40.ConvertirEnLettre().Should().Be("quarante");
            50.ConvertirEnLettre().Should().Be("cinquante");
            60.ConvertirEnLettre().Should().Be("soixante");
            70.ConvertirEnLettre().Should().Be("soixante-dix");
            80.ConvertirEnLettre().Should().Be("quatre-vingts");
            90.ConvertirEnLettre().Should().Be("quatre-vingt-dix");
        }

        [TestMethod]
        public void PeutGererLesExceptionsPremiereUnitesPourLesDizaines()
        {
            21.ConvertirEnLettre().Should().Be("vingt-et-un");
            31.ConvertirEnLettre().Should().Be("trente-et-un");
            41.ConvertirEnLettre().Should().Be("quarante-et-un");
            51.ConvertirEnLettre().Should().Be("cinquante-et-un");
            61.ConvertirEnLettre().Should().Be("soixante-et-un");
        }

        [TestMethod]
        public void PeutGererLesExceptionsPourLaDizaineSoixanteDix()
        {
            71.ConvertirEnLettre().Should().Be("soixante-et-onze");
            72.ConvertirEnLettre().Should().Be("soixante-douze");
            73.ConvertirEnLettre().Should().Be("soixante-treize");
            79.ConvertirEnLettre().Should().Be("soixante-dix-neuf");
        }

        [TestMethod]
        public void PeutCombinerDizaineEtUnite()
        {
            22.ConvertirEnLettre().Should().Be("vingt-deux");
            33.ConvertirEnLettre().Should().Be("trente-trois");
            44.ConvertirEnLettre().Should().Be("quarante-quatre");
            55.ConvertirEnLettre().Should().Be("cinquante-cinq");
            66.ConvertirEnLettre().Should().Be("soixante-six");
            87.ConvertirEnLettre().Should().Be("quatre-vingt-sept");
            98.ConvertirEnLettre().Should().Be("quatre-vingt-dix-huit");
        }

        [TestMethod]
        public void PeutAppliquerLExceptionBelgeEtSuisse()
        {
            var convertisseur = ConvertisseurNombreEnLettre.Parametrage
                  .AppliquerLaRegleDeTraductionBelgeEtSuisse(true)
                  .ValiderLeParametrage();

            convertisseur.Convertir(70).Should().Be("septante");
            convertisseur.Convertir(93).Should().Be("nonante-trois");
        }

        [TestMethod]
        public void PeutGererLesAccordsDeVingt()
        {
            20.ConvertirEnLettre().Should().Be("vingt");
            80.ConvertirEnLettre().Should().Be("quatre-vingts");
            83.ConvertirEnLettre().Should().Be("quatre-vingt-trois");
        }
    }
}
