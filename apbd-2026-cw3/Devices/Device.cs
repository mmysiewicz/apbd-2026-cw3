namespace apbd_2026_cw3;

public abstract class Device
{
    public static int IdForNumeration = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public AvailableStatus Status { get; set; }
    
    public Device(string name)
    {
        IdForNumeration++;
        Id =  IdForNumeration;
        Name = name;
        Status = AvailableStatus.Available;
        
    }
}