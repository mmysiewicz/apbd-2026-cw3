namespace apbd_2026_cw3.Services;

public class DevicesService
{
    public List<Device> devices { get; set; } = new List<Device>();

    public DevicesService() {}
    
    public void AddDevice(Device device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(Device device)
    {
        devices.Remove(device);
    }

    public void DisplayDevivesList()
    {
        foreach(Device device in devices)
        {Console.WriteLine(device.Id + " "+ device.Name + " " + device.Status);}
    }
    
    public void DisplayAvailableDevices()
    {
        AvailableStatus s = AvailableStatus.Available;
        foreach (Device device in devices)
        {
            if (device.Status == s)
            {
                Console.WriteLine(device.Id + " " + device.Name + " " + device.Status);
            }
        }
    }
    
    public void DeviceStatusChangeToUnavailable(Device device)
    {
        foreach (Device d in devices)
        {
            if (device.Id == d.Id)
            {
                d.Status = AvailableStatus.Unavailable;
            }
        }
    }
    public void GenerateShortReport()
    {
        int numberOfAvailable = 0;
        int numberOfBorrowed = 0;
        int numberOfUnavailable = 0;
        foreach (Device d in devices)
        {
            if (d.Status == AvailableStatus.Available)
            {
                numberOfAvailable++;
            }

            if (d.Status == AvailableStatus.Unavailable)
            {
                numberOfUnavailable++;
            }

            if (d.Status == AvailableStatus.Borrowed)
            {
                numberOfBorrowed++;
            }
        }
        Console.WriteLine("Liczba wypożyczonych urządzeń: " + numberOfBorrowed);
        Console.WriteLine("Liczba dostępnych urządzeń: " + numberOfAvailable);
        Console.WriteLine("Liczba niedostępnych urządzeń: " + numberOfUnavailable);
    }
}