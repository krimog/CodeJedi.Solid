# Single Responsibility Principle

[Retour au sommaire](./../README.md#Sommaire)

## D�finition

L'id�e est simple : une classe ne doit avoir qu'une responsabilit�, c'est-�-dire qu'elle ne doit servir qu'� une chose.

En respectant ce principe, on obtient un code
* Plus lisible
* Plus maintenable
* Avec moins de risques de r�gression en cas d'�volution

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

Dans ce code, on distingue deux responsabilit�s : 
1. Le fonctionnement de la voiture (`GoForward()`, `GoBackward()`, `TurnLeft()`)
1. L'apparence de la voiture (`ChangeColor(r,g,b)`)

Avoir ces deux responsabilit�s dans la m�me classe implique que cette classe doit �tre modifi�e � la fois en cas de modification du fonctionnement de la voiture (par exemple, l'ajout d'une m�thode `TurnRight()`),
mais aussi en cas de modification de l'apparence de la voiture (par exemple `AddStickers()`).

Pour corriger ce probl�me, il suffit de s�parer la classe en deux classes distinctes, chacune ayant sa propre responsabilit�.
On peut �galement cr�er une classe dont la seule responsabilit� sera de regrouper les diff�rents concepts.

## Code corrig�

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