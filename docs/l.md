# Liskov Substitution Principle

[Retour au sommaire](./../README.md#Sommaire)

## Définition

Le principe de substitution de Liskov implique qu'on doit pouvoir remplacer une instance d'une classe par une instance d'une sous-classe tout en gardant le même comportement.

![substitution](./assets/substitution.png)

Une sous-classe doit donc être capable au minimum de faire tout ce que fait sa classe parente.

Ceci aide à :

* Respecter le principe d'encapsulation
* Diminuer le couplage
* Maintenabilité du code

## Mauvais code

```csharp
public class Car
{
    public virtual void GoForward()
    {
        Console.WriteLine("Going forward");
    }

    public virtual void GoBackward()
    {
        Console.WriteLine("Going backward");
    }
}

public class Dragster : Car
{
    public override void GoForward()
    {
        Console.WriteLine("Going forward with dragster");
    }

    public override void GoBackward()
    {
        throw new NotSupportedException("Dragsters can't go backward");
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

    public void DriveBackward()
    {
        _car.GoBackward();
    }
}
```

## Application du principe

Dans cet exemple, si la voiture du conducteur est une instance de `Car`, il n'y a pas de problème. Cependant, si c'est une instance de `Dragster`, le programme lèvera une exception à l'appel de la méthode `DriveBackward()`.

> Une méthode qui ne fait que lever une exception (`NotSupportedException`, `NotImplementedException`...) est souvent un indicateur d'une violation du principe de substitution de Liskov.

L'idée est donc de dire que si un véhicule hérite de la classe `Car`, le véhicule doit pouvoir avancer et reculer. Selon cette règle, un `Dragster` ne doit pas hériter de `Car`.

## Code corrigé

```csharp
public class Car
{
    public virtual void GoForward()
    {
        Console.WriteLine("Going forward");
    }

    public virtual void GoBackward()
    {
        Console.WriteLine("Going backward");
    }
}

public class Dragster
{
    public virtual void GoForward()
    {
        Console.WriteLine("Going forward with dragster");
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

    public void DriveBackward()
    {
        _car.GoBackward();
    }
}
```

Ainsi, l'objet passé au constructeur de `Driver` ne peut plus être un `Dragster`, ce qui fait que la méthode `DriveBackward()` ne risque pas de lever une exception.

## [Principe suivant](./i.md)
