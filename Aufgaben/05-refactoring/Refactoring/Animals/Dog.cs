namespace Refactoring.Animals;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override string MakeNoise() {
        return this.Name + " says 'woof'";
    }
}