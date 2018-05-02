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



## Code corrig�