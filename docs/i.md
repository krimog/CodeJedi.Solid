# Interface Segregation Principle

[Retour au sommaire](./../README.md#Sommaire)

## Définition

Le principe de séparation des interfaces indique qu'il ne faut pas avoir d'interface qui ne corresponde pas exactement à la classe qui l'implémente. Cela implique donc d'avoir plusieurs petites interfaces plutôt qu'une grosse.

Dans un sens, cette méthode va de pair avec le principe de substitution de Liskov.

Respected la séparation des interfaces rendra votre code

* Plus extensible
* Plus maintenable

## Mauvais code

```csharp
public interface IVehicle
{
    void GoTo(string destination);

    void StartEngine();
}

public class Car : IVehicle
{
    public void GoTo(string destination)
    {
    }

    public void StartEngine()
    {
    }
}

public class Motorbike : IVehicle
{
    public void GoTo(string destination)
    {
    }

    public void StartEngine()
    {
    }
}

public class Bicycle
{
    public void GoTo(string destination)
    {
    }
}
```

## Application du principe

Que faire vis-à-vis de la classe `Bicycle` ? Il s'agit bien d'un véhicule, mais sans moteur, donc si je lui fait implémenter l'interface `IVehicle`, je ne respecterais pas le principe de substitution de Liskov.

> Si une interface vous paraît avoir beaucoup de membres, il est probable qu'elle ne respecte pas ce principe.

On va donc tout simplement diviser l'interface en plusieurs plus petites interfaces.

## Code corrigé

```csharp
public interface IVehicle
{
    void GoTo(string destination);
}

public interface IEngineObject
{
    void StartEngine();
}

public interface IEngineVehicle : IVehicle, IEngineObject
{
}

public class Car : IEngineVehicle
{
    public void GoTo(string destination)
    {
    }

    public void StartEngine()
    {
    }
}

public class Motorbike : IEngineVehicle
{
    public void GoTo(string destination)
    {
    }

    public void StartEngine()
    {
    }
}

public class Bicycle : IVehicle
{
    public void GoTo(string destination)
    {
    }
}
```

Ainsi, je n'ai aucun problème à me déplacer en appelant la méthode `GoTo(string destination)` avec n'importe quel `IVehicle`, sans que ce soit nécessaire qu'il ait un moteur.

## [Principe suivant](./d.md)
