using System;
namespace Farm
{
    internal class Animal
    {
		string species, noise, relat, plan, name;
		public Animal(string name, string species)
		{
			this.species = species;
			this.name = name;
			setTraits();
		}

		private void setTraits()
		{
			if (species == "cow")
			{
				this.noise = "Moo";
				this.relat = " not like the";
				this.plan = "I will charge the farmer the next time he comes";
			}
			else if (species == "horse")
			{
				this.noise = "Nay";
				this.relat = " like the";
				this.plan = "I will run with the farmer forever";
			}
			else if (species == "chicken")
			{
				this.noise = "bock";
				this.relat = " not like the";
				this.plan = "I will...";
			}
			else
			{
				this.species = "human";
				this.noise = "whats going on?";
				this.relat = " want you to tell me what this is about";
				this.plan = "I am gonna figure out what I am doing in this barn";
			}
		}

		public void speak()
		{
			Console.WriteLine($"Hello, my name is {name}");
			Console.WriteLine($"I am a {species}. {noise}.");
			Console.WriteLine($"I do{relat} farmer.");
			Console.WriteLine(plan);
		}
	}
}