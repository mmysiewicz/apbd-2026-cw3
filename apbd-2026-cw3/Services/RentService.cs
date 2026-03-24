namespace apbd_2026_cw3.Services;

public class RentService
{
    public List<Rent> rents { get; set; } = new List<Rent>();

    public RentService() {}

    public void RentDevice(DateTime rentDate, int numberOfDays, double fee, Device rentedDevice, User user)
    {
        
        
        if (user.GetNumberOfPossibleRentDevices() > user.Devices.Count && rentedDevice.Status == AvailableStatus.Available)
        {
            Rent rent = new Rent(rentDate, numberOfDays, fee, rentedDevice, user);
            rentedDevice.Status = AvailableStatus.Borrowed;
            user.Devices.Add(rentedDevice);
            rents.Add(rent);
        }
        else
        {
            Console.WriteLine("Wybrany sprzęt jest niedostępny lub przekroczono limit wypożyczeń");
        }
    }

    public void ReturnDevice(Device device, DateTime returnDate)
    {
        double penalty = 0;
        foreach (var rent in rents)
        {
            if (rent.RentedDevice.Id == device.Id)
            {
                rent.RealReturnDate = returnDate;
                if ((rent.RealReturnDate.Date - rent.ReturnDate.Date).Days > 0)
                {
                    int numberOfDays = (rent.RealReturnDate.Date - rent.ReturnDate.Date).Days;
                    penalty = numberOfDays * rent.Fee;
                    rent.User.loan += penalty;
                    Console.WriteLine("Naliczono opłatę w wysokości: " + penalty);
                }

                rent.User.Devices.Remove(device);
                device.Status = AvailableStatus.Available;
                break;
            }
        }
    }

    public void DisplayListOfOverdueRents()
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