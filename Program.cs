// Define the abstract superhero class

public abstract class SuperHero
{
    public string Name { get; set; }
    public int Power { get; set; }
    public int Health { get; set; }
    public int Defense { get; set; }

    public abstract void UseSuperPower();
    public virtual void GetInfo(){
        Console.WriteLine($"Name: {Name} \nPower: {Power} \nHealth: {Health} \nDefense: {Defense}");
    }
}

public class FlyingSuperHero : SuperHero
{
    public int Speed { get; set; }
    public int Agility { get; set; }
    public FlyingSuperHero(string name, int power, int health, int defense, int speed, int agility)
    {
        Name = name;
        Power = power;
        Health = health;
        Defense = defense;
        Speed = speed;
        Agility = agility;
    }
    public override void UseSuperPower()
    {
        Console.WriteLine($"{Name} is flying!");
    }
    
    public override void GetInfo(){
        base.GetInfo();
        Console.WriteLine($"Speed: {Speed} \nAgility: {Agility}");
    }
}

public class SuperStrengthHero : SuperHero
{
    public int Strength { get; set; }
    public SuperStrengthHero(string name, int power, int health, int defense, int strength)
    {
        Name = name;
        Power = power;
        Health = health;
        Defense = defense;
        Strength = strength;
    }
    public override void UseSuperPower()
    {
        Console.WriteLine($"{Name} is strong!");
    }

    public override void GetInfo(){
        base.GetInfo();
        Console.WriteLine($"Strength: {Strength}");
    }
}

public class App{
    static void Main(string[] args){
        FlyingSuperHero superHero = new FlyingSuperHero("Superman", 100, 100, 100, 100, 100);
        superHero.UseSuperPower();
        SuperStrengthHero superStrengthHero = new SuperStrengthHero("Batman", 100, 100, 100, 100);
        superStrengthHero.UseSuperPower();
        superHero.GetInfo();
        superStrengthHero.GetInfo();
    }
}