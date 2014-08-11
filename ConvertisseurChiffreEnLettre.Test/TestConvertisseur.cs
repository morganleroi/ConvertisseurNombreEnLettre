using ConvertisseurNombreEnLettre;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertisseurChiffreEnLettre.Test
{
    [TestClass]
    public class TestConvertisseur
    {
        [TestMethod]
        public void PeutConvertirLesUnites()
        {
            //0.ConvertirEnLettre().Should().Be("zéro");
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
            80.ConvertirEnLettre().Should().Be("quatre-vingt");
            90.ConvertirEnLettre().Should().Be("quatre-vingt-dix");
        }

        //todo
        // 31, 41, 51, ...
        [TestMethod]
        public void PeutGererLesExceptionsPremiereUnitesPourLesDizaines()
        {
            //21.ConvertirEnLettre().Should().Be("vingt et un");
            //31.ConvertirEnLettre().Should().Be("trente et un");
            //41.ConvertirEnLettre().Should().Be("quarante et un");
            //51.ConvertirEnLettre().Should().Be("cinquante et un");
            //61.ConvertirEnLettre().Should().Be("soixante et un");
        }

        //todo
        // 71, 72 , ...
        [TestMethod]
        public void PeutGererLesExceptionsPourLaDizaineSoixanteDix()
        {
            72.ConvertirEnLettre().Should().Be("soixante douze");
        }

        [TestMethod]
        public void PeutCombinerDizaineEtUnite()
        {
            22.ConvertirEnLettre().Should().Be("vingt deux");
            33.ConvertirEnLettre().Should().Be("trente trois");
            44.ConvertirEnLettre().Should().Be("quarante quatre");
            55.ConvertirEnLettre().Should().Be("cinquante cinq");
            66.ConvertirEnLettre().Should().Be("soixante six");
            87.ConvertirEnLettre().Should().Be("quatre-vingt sept");
            98.ConvertirEnLettre().Should().Be("quatre-vingt-dix huit");    
        }

        [TestMethod]
        public void PeutAppliquerLaRegleDesTiretsDe1990()
        {
          //var convertisseur = ConvertisseurNombreEnLettre.ConvertisseurNombreEnLettre.Parametrage
          //      .AppliquerLaRegleDesTiretsDe1990(true)
          //      .ValiderLeParametrage();

          //convertisseur.Convertir(22).Should().Be("vingt deux");
          //convertisseur.Convertir(98).Should().Be("quatre vingt dix huit");
        }

        [TestMethod]
        public void PeutAppliquerLExceptionBelgeEtSuisse()
        {
            var convertisseur = ConvertisseurNombreEnLettre.ConvertisseurNombreEnLettre.Parametrage
                  .AppliquerLaRegleDeTraductionBelgeEtSuisse(true)
                  .ValiderLeParametrage();

            convertisseur.Convertir(70).Should().Be("septante");
            convertisseur.Convertir(93).Should().Be("nonante trois");
        }

        [TestMethod]
        public void PeutConvertirLesCentaines()
        {
            272.ConvertirEnLettre().Should().Be("deux cent soixante douze");
        }

        [TestMethod]
        public void PeutConvertirLesMilliers()
        {
            3272.ConvertirEnLettre().Should().Be("trois mille deux cent soixante douze");
            23272.ConvertirEnLettre().Should().Be("vingt trois mille deux cent soixante douze");
            235272.ConvertirEnLettre().Should().Be("deux cent trente cinq mille deux cent soixante douze");
        }

        [TestMethod]
        public void PeutConvertirLesMillions()
        {
            2344678.ConvertirEnLettre().Should().Be("deux millions trois cent quarante quatre mille six cent soixante dix-huit");
        }
    }
}
