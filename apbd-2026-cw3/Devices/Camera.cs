namespace apbd_2026_cw3;

public class Camera : Device
{
    public string RecordingResolution { get; set; }
    public string Matrix {get; set; }
    public bool WiFi { get; set; }
    public bool HdmiOutput { get; set; }

    public Camera(string name, string recordingResolution, string matrix, bool wiFi, bool hdmiOutput)
    {
        IdForNumeration++;
        Id =  IdForNumeration;
        Name = name;
        Status = AvailableStatus.Available;
        RecordingResolution = recordingResolution;
        Matrix = matrix;
        WiFi = wiFi;
        HdmiOutput = hdmiOutput;
    }
}