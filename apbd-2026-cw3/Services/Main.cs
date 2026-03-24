namespace apbd_2026_cw3.Services;

public class MainClass
{

    public static void Main(string[] args)
    {
        DevicesService devicesService = new DevicesService(); 
        RentService rentService = new RentService();

        Laptop laptop = new Laptop("Lenovo X1", "Intel Core i9-14900K", 16, "Gigabyte RTX 3060");
        Camera camera = new Camera("Sony a7", "4K", "Pełna klatka", true, true);
        Projector projector = new Projector("SAMSUNG The Freestyle", "Full HD", "DLP", 230);
        devicesService.AddDevice(laptop);
        devicesService.AddDevice(camera);
        devicesService.AddDevice(projector);
    
        Employee employee1 = new Employee("Piotr", "Nowak");
        Employee employee2 = new Employee("Julia", "Malinowska");
        Student student1 = new Student("Paweł", "Kowalski");
        
        rentService.RentDevice(DateTime.Now, 2, 100, camera, employee1);
        
        devicesService.DeviceStatusChangeToUnavailable(projector);
        rentService.RentDevice(DateTime.Now, 3, 50, projector, employee2);
        
        rentService.ReturnDevice(camera, DateTime.Now.AddDays(4));
        
        
        
        
    }
}