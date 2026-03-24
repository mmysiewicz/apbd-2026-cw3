namespace apbd_2026_cw3;

public class Student : User
{
    public Student(string firstName, string surname) : base(firstName, surname)
    {
    }

    public override int GetNumberOfPossibleRentDevices()
    {
        return 2;
    }
}