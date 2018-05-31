# Dependency Inversion Principle

[Retour au sommaire](./../README.md#Sommaire)

## Définition

Le principe d'inversion de dépendances explique qu'on doit dépendre d'abstractions, pas d'implémentations. Si une classe `A` dépend d'une interface `I` plutôt que d'une classe `B`, on pourra fournir n'importe quelle classe implémentant l'interface `I`.

C'est sur ce principe que se basent les différents systèmes d'**injection de dépendances** ou de **composition**.

Grâce à l'inversion de dépendances

* On réduit fortement le couplage entre les classes
* On réduit le risque de dépendances cycliques (A qui dépend de B qui lui-même dépend de A)
* On rend le code plus maintenable
* On rend le code plus évolutif
* On rend le code beaucoup plus testable

## Mauvais code

```csharp
public class Car
{
    public void GoTo(string destination)
    {
        Console.WriteLine($"Going to {destination}.");
    }
}

public class Driver
{
    private readonly Car _car;

    public Driver(Car car)
    {
        _car = car;
    }

    public void GoBackHome()
    {
        _car.GoTo("Home");
    }
}
```

## Application du principe

Ça fonctionne. Mais que se passe-t-il le jour où l'on a un autre véhicule ? On est obligés de toucher à la classe `Driver` pour gérer cet autre véhicule, alors ça ne devrait rien changer, puisque le déplacement lui-même n'est pas sa responsabilité.

> De manière générale, les dépendances doivent être des interfaces.

Dans notre cas, on ne donnera pas au conducteur une instance de `Car` mais une instance implémentant une interface, qui contient tout ce dont `Driver` a besoin, c'est-à-dire `GoTo(string destination)`.

## Code corrigé

```csharp
public interface IVehicle
{
    void GoTo(string destination);
}

public class Car : IVehicle
{
    public void GoTo(string destination)
    {
        Console.WriteLine($"Going to {destination}.");
    }
}

public class Driver
{
    private readonly IVehicle _vehicle;

    public Driver(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public void GoBackHome()
    {
        _vehicle.GoTo("Home");
    }
}
```

On peut maintenant fournir au constructeur de `Driver` n'importe quel véhicule. Il peut même s'agir d'un faux véhicule (un `mock`) créé exclusivement pour des tests unitaires.

## [Conclusion](./conclusion.md)