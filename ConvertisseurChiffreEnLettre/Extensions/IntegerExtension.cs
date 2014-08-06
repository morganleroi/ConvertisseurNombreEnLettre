namespace ConvertisseurNombreEnLettre
{
   public static class IntegerExtension
    {
       public static string ConvertirEnLettre(this int nombre)
       {
           return ConvertisseurNombreEnLettre.ConvertirAvecParametrageParDefaut(nombre);
       }
    }
}
