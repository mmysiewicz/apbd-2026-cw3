namespace apbd_2026_cw3;

public class Projector : Device
{
    public string Resolution { get; set; }
    public string Matrix { get; set; }
    public int Brightness { get; set; }

    public Projector(string name, string resolution, string matrix, int brightness) : base(name)
    {
        Resolution = resolution;
        Matrix = matrix;
        Brightness = brightness;
    }
}