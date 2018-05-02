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



## Code corrigé