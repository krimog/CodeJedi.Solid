# Open/Closed Principle

[Retour au sommaire](./../README.md#Sommaire)

## Définition

Le principe Ouvert/Fermé signifie que le code doit être ouvert à l'extension mais fermé à la modification.
Cela veut dire qu'une autre personne doit pouvoir ajouter des fonctionalités autour de notre code, sans devoir toucher au code de base.

Ce principe aide à

* La maintenabilité du code
* La réutilisabilité du code

## Mauvais code

```csharp
public abstract class Car
{
}

public class FuelCar : Car
{
    public void GoForwardWithFuelEngine()
    {
    }
}

public class DieselCar : Car
{
    public void GoForwardWithDieselEngine()
    {
    }
}

public class Driver
{
    private readonly Car _car;

    public Driver(Car car)
    {
        _car = car;
    }

    public void DriveForward()
    {
        switch(_car)
        {
            case DieselCar dc:
                dc.GoForwardWithDieselEngine();
                break;
            case FuelCar fc:
                fc.GoForwardWithFuelEngine();
                break;
            default:
                throw new NotSupportedException("This car type is not supported.");
        }
    }
}
```

## Application du principe

En quoi ce code est-il mauvais ? C'est très simple : on a de plus en plus de voitures électriques. On imagine qu'on pourrait facilement créer une classe `ElectricCar` héritant de `Car` avec une méthode `GoForwardWithElectricEngine()`. Mais si on passe une telle voiture au constructeur de `Driver` puis qu'on appelle la méthode `DriveForward()`, on a droit à une exception.

> De manière générale, faites attention lorsque vous avez des `switch` (ou des `if` en série).

Le fait est que pour ajouter une fonctionalité, on est obligé de modifier la classe `Driver`. Pour appliquer le principe ouvert/fermé, on va donc rendre le comportement de `DriveForward()` plus générique, en modifiant la classe `Car`.

## Code corrigé

```csharp
public abstract class Car
{
    public abstract void GoForward();
}

public class FuelCar : Car
{
    public override void GoForward()
    {
    }
}

public class DieselCar : Car
{
    public override void GoForward()
    {
    }
}

public class Driver
{
    private readonly Car _car;

    public Driver(Car car)
    {
        _car = car;
    }

    public void DriveForward()
    {
        _car.GoForward();
    }
}
```

Je peux désormais ajouter une classe `ElectricCar` qui hérite de `Car` et l'utiliser sans rien avoir à modifier dans la classe `Driver` (ou aucune autre). Cette classe est donc fermée à la modification mais ouverte à l'extension.