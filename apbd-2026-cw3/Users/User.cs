namespace apbd_2026_cw3;

public abstract class User
{
    public static int IdForNumeration = 0;
    public List<Device> Devices { get; set; }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public double loan { get; set; }

    public abstract int GetNumberOfPossibleRentDevices();

    public void DisplayListOfRentedDevices()
    {
        foreach (Device device in Devices)
        {
            Console.WriteLine(device.Id + " " + device.Name + " " + device.Status);
        }
    }
}