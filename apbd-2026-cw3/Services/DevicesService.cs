using System.Linq.Expressions;

namespace apbd_2026_cw3.Services;

public class DevicesService
{
    public static List<Device> devices { get; set; }

    public DevicesService()
    {
        devices = new List<Device>();
    }
    
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
                device.Status = AvailableStatus.Unavailable;
            }
        }
    }
}