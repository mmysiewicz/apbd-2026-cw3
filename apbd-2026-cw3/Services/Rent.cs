namespace apbd_2026_cw3.Services;

public class Rent
{
    public DateTime RentDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public DateTime RealReturnDate { get; set; }
    public double Fee { get; set; }
    public Device RentedDevice { get; set; }
    public User User { get; set; }

    public Rent(DateTime rentDate, int numberOfDays, double fee, Device rentedDevice, User user)
    {
        RentDate = rentDate;
        ReturnDate = RentDate.AddDays(numberOfDays);
        Fee = fee;
        RentedDevice = rentedDevice;
        User = user;
    }
}