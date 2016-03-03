<Query Kind="Program" />

void Main()
{
Giraffe Girry = new Giraffe("Girry","Massai Giraffe");
Cat  catty= new Cat("Cattye", "Feline Cat ");
Dog husky=  new Dog("Huskey" , "Siberian Dog");
Fox foxxy= new Fox("Foxy" , "Canine Fox");
Cattle cay= new Cattle("Cay" , "Taurine Cattle");
	
Console.WriteLine($"{Girry.Name} is a {Girry.Species} and it makes sound like {Girry.MakeNoise()}");
Console.WriteLine($"{catty.Name} is a {catty.Species} and it makes sound like {catty.MakeNoise()}");
Console.WriteLine($"{husky.Name} is a {husky.Species} and it makes sound like {husky.MakeNoise()}");
Console.WriteLine($"{foxxy.Name} is a {foxxy.Species} and it makes sound like {foxxy.MakeNoise()}");
Console.WriteLine($"{cay.Name} is a {cay.Species} and it makes sound like {cay.MakeNoise()}");


            List<Animal> animals = new List<Animal>();
            animals.Add(Girry as Animal);
            animals.Add(catty as Animal);
            animals.Add(husky as Animal);
			animals.Add(foxxy as Animal);
			animals.Add(cay as Animal);
			
}

// Define other methods and classes here


abstract class Animal
{

public int id;
static int sID =0;
public abstract string Name{get;set;}
public abstract string Species{get; set;}
public abstract string MakeNoise();

public Animal()
{ 
id= ++sID;
}
}
class Giraffe:Animal
{
	public override string Name{get;set;}
	public override string Species{get;set;}
	public Giraffe (string name, string species)
	{
		Name=name;
		Species=species;
	}
	public override string MakeNoise()
	{ 
	return ("GRGRGR");
	}
}
class Cat:Animal
{
	public override string Name{get; set;}
	public override string Species{get;set;}
	
	public Cat(string name, string species)
	{
	
	Name=name;
	Species=species;
	}
	
	public override string MakeNoise()
	{
	return ("Meow meoww meoowww!!");
	}
}
class Dog:Animal 
{
	public override string Name{get;set;}
	public override string Species{get;set;}
	public Dog (string name, string species)
	{
		Name=name;
		Species=species;
	}
	public override string MakeNoise()
	{ 
	return ("Woof");
	}
}

class Cattle:Animal
{
 public override string Name{get;set;}
	public override string Species{get;set;}
	public Cattle (string name, string species)
	{
		Name=name;
		Species=species;
	}
	public override string MakeNoise()
	{ 
	return ("Mooo MOO");
	}
}

class Fox :Animal 
{
public override string Name{get;set;}
	public override string Species{get;set;}
	public Fox (string name, string species)
	{
		Name=name;
		Species=species;
	}
	public override string MakeNoise()
	{ 
	return ("A-ooooooooo ");
	}
}