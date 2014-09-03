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

**Utilisation via la classe Convertisseur**
L'utilisation via la classe Convertisseur permet de customiser la maniére dont va se faire la convertion.

```C#
  var convertisseur = ConvertisseurNombreEnLettre.Parametrage
      .AppliquerUneUnite(Unite.EUR)
      .ValiderLeParametrage();

convertisseur.Convertir(42);
```

donne le résultat : "quarante-deux euros".

**Les paramètres possibles**
Différents paramétres sont possibles :


Le paramétrage par défaut :
```C#
var convertisseur = ConvertisseurNombreEnLettre.Parametrage.ParDefaut();
convertisseur.Convertir(1234.4m);
```

**Règles belge et suisse**
```C#
var convertisseur = ConvertisseurNombreEnLettre.Parametrage
      .AppliquerLaRegleDeTraductionBelgeEtSuisse(true)
      .ValiderLeParametrage();

//septante
convertisseur.Convertir(70);

//nonante-trois
convertisseur.Convertir(93).Should();
```

**Modifier la virgule**
```C#
var convertisseur = ConvertisseurNombreEnLettre
    .Parametrage
    .ModifierLaVirgule(",")
    .ValiderLeParametrage();

// un, cinquante-quatre
convertisseur.Convertir(1.54m);
```

**Appliquer une unité**
Deux unités sont disponibles : EUR et Kilogramme. Vous avez ensuite la possibilité de créer de nouvelles unités.

Exemple avec Unite.EUR.
```C#
var convertisseur = ConvertisseurNombreEnLettre.Parametrage
    .AppliquerUneUnite(Unite.EUR)
    .ModifierLaVirgule("et")
    .ValiderLeParametrage();

//un euro et cinquante-quatre centimes
convertisseur.Convertir(1.54m);

//quarante-et-un euros et sept-cents centimes
convertisseur.Convertir(41.700m);
```

Exemple avec Unite.Kilogramme.
```C#
var convertisseur = ConvertisseurNombreEnLettre.Parametrage
    .AppliquerUneUnite(Unite.Kilogramme)
    .ModifierLaVirgule("et")
    .ValiderLeParametrage();

//un kilo
convertisseur.Convertir(1);

//quarante-deux kilos
convertisseur.Convertir(42);

//quarante-deux kilos et vingt-sept grammes
convertisseur.Convertir(42.27m);
```

Exemple avec une unité ...personnalisée.
```C#
var convertisseur = ConvertisseurNombreEnLettre.Parametrage
    .AppliquerUneUnite(Unite.Creer("pouet", "pouets", "minipouet", "minipouets"))
    .ModifierLaVirgule("et")
    .ValiderLeParametrage();

//un pouet
convertisseur.Convertir(1);

//quarante-deux pouets
convertisseur.Convertir(42);

//quarante-deux pouets et vingt-sept minipouets
convertisseur.Convertir(42.27m);
```
