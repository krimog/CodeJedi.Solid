# Single Responsibility Principle

[Retour au sommaire](./../README.md#Sommaire)

## Définition

L'idée est simple : une classe ne doit avoir qu'une responsabilité, c'est-à-dire qu'elle ne doit servir qu'à une chose.

En respectant ce principe, on obtient un code
* Plus lisible
* Plus maintenable
* Avec moins de risques de régression en cas d'évolution

## Mauvais code

```csharp
public class Car_bad
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
public class CarMovement_good
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

public class CarAppearance_good
{
    public void ChangeColor(byte r, byte g, byte b)
    {
    }
}

public class Car_good
{
	public CarMovement_good Movement { get; }
	public CarAppearance_good Appearance { get; }
}
```