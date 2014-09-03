using Convertisseur;
using Convertisseur.Extension;
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

        [TestMethod]
        public void PeutModifierLeTermeVirgule()
        {
            var convertisseur = ConvertisseurNombreEnLettre
                .Parametrage
                .ModifierLaVirgule(",")
                .ValiderLeParametrage();

            convertisseur.Convertir(1.54m).Should().Be("un, cinquante-quatre");
            convertisseur.Convertir(1.1205m).Should().Be("un, mille-deux-cent-cinq");
            convertisseur.Convertir(1001000.1001000m).Should().Be("un-million-mille, un-million-mille");
        }
    }
}