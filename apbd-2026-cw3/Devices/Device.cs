namespace apbd_2026_cw3;

public abstract class Device
{
    public static int IdForNumeration = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public bool AvailableStatus { get; set; }
}