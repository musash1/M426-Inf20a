namespace Refactoring.Animals;

public class Horse : Animal
{
    public Horse(string name) : base(name) { }

    public override string MakeNoise() {
        return this.Name + " says 'neigh'";
    }
}