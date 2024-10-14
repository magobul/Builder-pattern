using Builder_pattern;

public class Program
{
    public static void Main(string[] args)
    {
        Processor cpu = new Processor { Model = "Intel Core i5 12400", Cores = 6 };
        Motherboard motherboard = new Motherboard { Model = "GIGABYTE B760M GAMING X DDR4" };
        RAM ram = new RAM { Size = "32GB" };
        Storage storage = new Storage { Type = "SSD", Size = "1TB" };
        Videocard videoCard = new Videocard { Model = "NVIDIA GeForce RTX 3080" };

        ComputerBuilder builder = new ComputerBuilder();
        Computer myComputer = builder.SetCPU(cpu)
                                      .SetMotherboard(motherboard)
                                      .SetRAM(ram)
                                      .SetStorage(storage)
                                      .SetVideoCard(videoCard)
                                      .Build();

        Console.WriteLine(myComputer);
    }
}