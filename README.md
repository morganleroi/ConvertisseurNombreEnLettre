Convertisseur Nombre en Lettre (C#)
===========================

Ce convertisseur francais prend en charge les fonctionnalités suivantes :
- Convertion de nombre avec et sans partie décimale.
- Prise en compte des règles orthographiques en vigueur. (Régle des tirets, Accords, exceptions Suisse et Belge).
- Paramétrage avancé pour paramétrer l'ajout d'unités, les régles à appliquer, ...


**Comment utiliser le convertisseur ?**
- Télécharger la dll (Derniére release sur Gitub)
- Ajouter une réfèrence a la dll dans votre projet Visual Studio
- Ajouter la directive using dans votre classe

Pour convertir, deux solutions :
- Utiliser l'extension pour les types int et decimal.
- Configurer le convertisseur et l'utiliser ensuite.

**Utilisation via l'extension**
L'extension est disponible pour les type int et decimal. Le paramétrage appliqué est celui par défaut.

```C#
1.54m.ConvertirEnLettre()
```

donne le résultat : "un virgule cinquante-quatre".

** Utilisation via la classe Convertisseur**
L'utilisation via la classe Convertisseur permet de customiser la maniére dont va se faire la convertion.
```C#
  var convertisseur = ConvertisseurNombreEnLettre.Parametrage
      .AppliquerUneUnite(Unite.EUR)
      .ValiderLeParametrage();

convertisseur.Convertir(42);
```

donne le résultat : "quarante-deux euros".
