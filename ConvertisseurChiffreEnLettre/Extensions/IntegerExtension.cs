namespace ConvertisseurNombreEnLettre
{
   public static class IntegerExtension
    {
       public static string ConvertirEnLettre(this int nombre)
       {
           return ConvertisseurNombreEnLettre.ConvertirAvecParametrageParDefaut(nombre);
       }

       public static string ConvertirEnLettre(this decimal nombre)
       {
           return ConvertisseurNombreEnLettre.ConvertirAvecParametrageParDefaut(nombre);
       }
    }
}
