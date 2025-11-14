# Pokemon Simulator

## En exploration av C# OOP Koncepter

Jag använder `inheritance`, `interface`, `abstract` och `sealed` klasserna.

Koden vissas att barn klasserna skulle kunna hantera som bas:


```mermaid
---
title: Pokemoner bygger som ...
---
classDiagram
    note "From Duck till Zebra"
    Pokemon --|> ElectricPokemon 
    ElectricPokemon --|> Pikachu
    IEvolve --|> Pikachu
    ElectricPokemon --|> Raichu
    note for Pokemon "Abstract<br>Kan Attack, Speak, RaiseLevel, inte alla kan Evolve<br>Evolve() här skull returnera this "
    note for ElectricPokemon "Abstract"
    note for Pikachu "Implementerar IEvolve"
    note for Raichu "Kan inte Evolve() "
    class Pokemon{
        string Name
        int Level
        virtual int Health
        ElementType Type
        RandomAttack() 
        Attack() 
        ChangeHealth() 
        virtual RaiseLevel() 
        virtual Speak() 
       internal Pokemon Evolve()
    }
    class ElectricPokemon{
        Bygger en Pokemon med Type = ElementType.Electric
    }
    class IEvolve{
        int _evolvesAtLevel
        Pokemon Evolve() 
    }
    class Pikachu{
        int _evolvesAtLevel = 35
        int Level = 1
        int Health = 10
        ElementType Type = ElementType.Electric
        RandomAttack() 
        Attack() 
        ChangeHealth()  
        public override void Speak()
        public override Pokemon RaiseLevel()
        public new Pokemon Evolve()
    }
    class Raichu{
        int Level = 1
        int Health = 20 <-- (default) 
        ElementType Type = ElementType.Electric
        RandomAttack() 
        Attack() 
        ChangeHealth() 
        public override void Speak()
        public override Pokemon RaiseLevel()
    }

```


Och vi kan hanteras all Pokemon, de som implementerar IEvolve och de som gör det inte, som Pokemon bas klass:

```C#
List<Pokemon> Belt = new() 
{
        new Pikachu(34), 
        new Squirtle(9), 
        new Bulbasaur(14),
        new Charmander(19),
        new Raichu(60)
};
```

> [!IMPORTANT]  
> Man ska vanligt bygga pokemon med:
> ```c# Pokemon myPokemon = Pikachu(12); ```
> Pokemon som byggs skulle ha bara attacker som passeras vid sin egen subtypes.
>
> Man kan också bygga pokemon med egen attacks som:
> ```c# Pokemon myPokemon = Pikachu(12, attacks); ```
> `attacks` måste vara `List<Attack>`
> Om man passerar attacks till konstrktor då, det finns inget check att attacks passerar till pokemon som byggs!




