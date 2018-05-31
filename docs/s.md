# Single Responsibility Principle

[Retour au sommaire](./../README.md#Sommaire)

## Définition

L'idée est simple : une classe ne doit avoir qu'une responsabilité, c'est-à-dire qu'elle ne doit servir qu'à une chose. Ne pas respecter ce principe couple fortement les responsabilités.

![army knife](./assets/army-knife.jpg)

Imaginez une cuisine avec pour seul ustensile un couteau suisse. Ça peut suffire. Cependant, le jour où vous voulez changer l'un des outils ou en rajouter un, il va falloir démonter et remonter l'intégralité du couteau suisse. Vous risquez alors de mal le remonter, et même si vous y arrivez, ça aura pris bien plus de temps que d'acheter un couteau supplémentaire.

En respectant ce principe, on obtient un code

* Plus lisible
  * Puisque chaque classe n'a qu'une responsabilité, il n'y a pas d'ambiguïté sur le code que l'on lit.
* Plus maintenable
  * Une classe avec une seule responsabilité étant plus lisible et plus petite, il est plus facile de voir où et comment faire une modification.
* Avec moins de risques de régression en cas d'évolution
  * Une évolution concerne généralement une seule responsabilité, donc une seule classe à modifier. On évite ainsi de toucher à d'autres responsabilités, diminuant ainsi le risque de nouveaux bugs.

## Mauvais code

```csharp
public class Car
{
    public void GoForward()
    {
    }

    public void GoBackward()
    {
    }

    public void TurnLeft()
    {
    }

    public void ChangeColor(byte r, byte g, byte b)
    {
    }
}
```

## Application du principe

Dans ce code, on distingue deux responsabilités :

1. Le fonctionnement de la voiture (`GoForward()`, `GoBackward()`, `TurnLeft()`)
1. L'apparence de la voiture (`ChangeColor(r,g,b)`)

Avoir ces deux responsabilités dans la même classe implique que cette classe doit être modifiée à la fois en cas de modification du fonctionnement de la voiture (par exemple, l'ajout d'une méthode `TurnRight()`),
mais aussi en cas de modification de l'apparence de la voiture (par exemple `AddStickers()`).

Pour corriger ce problème, il suffit de séparer la classe en deux classes distinctes, chacune ayant sa propre responsabilité.
On peut également créer une classe dont la seule responsabilité sera de regrouper les différents concepts.

## Code corrigé

```csharp
public class CarMovement
{
    public void GoForward()
    {
    }

    public void GoBackward()
    {
    }

    public void TurnLeft()
    {
    }
}

public class CarAppearance
{
    public void ChangeColor(byte r, byte g, byte b)
    {
    }
}

public class Car
{
    public CarMovement Movement { get; }
    public CarAppearance Appearance { get; }
}
```

## Exemples courants

Faites bien attention à mettre dans des classes distinctes

* La récupération de données depuis la base
* La sérialisation des données
* Les règles métier sur les données
* La gestion de l'affichage
