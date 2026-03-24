namespace apbd_2026_cw3.Services;

public class RentService
{
    public static List<Rent> rents { get; set; }

    public RentService()
    {
        rents = new List<Rent>();
    }

    public static void RentDevice(DateTime rentDate, int numberOfDays, double fee, Device rentedDevice, User user)
    {
        if (user.GetNumberOfPossibleRentDevices() > user.Devices.Count && rentedDevice.Status == AvailableStatus.Available)
        {
            rentedDevice.Status = AvailableStatus.Borrowed;
            user.Devices.Add(rentedDevice);
            Rent rent = new Rent(rentDate, numberOfDays, fee, rentedDevice, user);
            rents.Add(rent);
        }
        else
        {
            Console.WriteLine("Wybrany sprzęt jest niedostępny lub przekroczono limit wypożyczeń");
        }
    }

    public static void ReturnDevice(Device device)
    {
        double penalty = 0;
        foreach (var rent in rents)
        {
            if (rent.RentedDevice.Id == device.Id)
            {
                rent.RealReturnDate = DateTime.Now;
                if (rent.RealReturnDate.Date != rent.ReturnDate.Date)
                {
                    int numberOfDays = (rent.RealReturnDate.Date - rent.ReturnDate.Date).Days;
                    penalty = numberOfDays * rent.Fee;
                    rent.User.loan += penalty;
                }

                rent.User.Devices.Remove(device);
                device.Status = AvailableStatus.Available;
            }
        }
    }

    public static void DisplayListOfOverdueRents()
    {
        foreach (var rent in rents)
        {
            if ((DateTime.Now.Date - rent.ReturnDate.Date).Days > 0)
            {
                Console.WriteLine(rent.RentedDevice.Id + " " + rent.RentedDevice.Name + " " + rent.RentedDevice.Status);
            }
        }
    }
}