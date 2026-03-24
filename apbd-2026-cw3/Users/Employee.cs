namespace apbd_2026_cw3;

public class Employee : User
{
    public Employee(string firstName, string surname) : base(firstName, surname)
    {
    }

    public override int GetNumberOfPossibleRentDevices()
    {
        return 5;
    }
}