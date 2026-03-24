namespace apbd_2026_cw3;

public class Laptop : Device
{
    public string Processor { get; set; }
    public int RamMemory { get; set; }
    public string GraphicsCard { get; set; }

    public Laptop(string name, string processor, int ramMemory, string graphicsCard) : base(name)
    {
        Processor = processor;
        RamMemory = ramMemory;
        GraphicsCard = graphicsCard;
    }
}