
// 1-ci misal
interface IAnimal
{
    void setName(string name);
    string getName();
    IAnimal Clone();
}


class Sheep : IAnimal
{
    private string name;
    public Sheep() { }

    private Sheep(Sheep donor) => this.name = donor.name;
    public void setName(string name) => this.name=name;
    public string getName() => this.name;
    
    public IAnimal Clone() => new Sheep(this);
}

internal class Program
{
    private static void Main(string[] args)
    {
        // 1
        // prototype egzemplyarini yaziriq
        IAnimal sheepDonor= new Sheep();
        sheepDonor.setName("BARAN");

        // clone methodunu cagiraraq onu clonlayiriq
        IAnimal sheepClone = sheepDonor.Clone();
        Console.WriteLine(sheepDonor.getName());
        sheepDonor.setName("ilkin");
        Console.WriteLine(sheepDonor.getName());
        Console.WriteLine(sheepClone.getName());
        

    }
}