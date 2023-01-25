public class Program
    {
    static void Main(string[] args)
        {
            List<Vehicle> vehicles=new List<Vehicle>();
            Console.Write("Howmany Vehicles do you want to add?: ");
            int numVehicles= Convert.ToInt16(Console.ReadLine());
            for(int i=0;i<numVehicles;i++){
                Console.Write("Enter The brand: ");
                string brand=Console.ReadLine();
                Console.Write("Enter the color: ");
                string color=Console.ReadLine();
                Vehicle vehicle=new Vehicle(brand, color);
                Console.WriteLine("Do you want to add a car for 1 or a truck for 2?: ");
                int VehicleChoice=Convert.ToInt16(Console.ReadLine());
                if(VehicleChoice==1){
                    Console.Write("Enter the model of the car: ");
                    string model=Console.ReadLine();
                    Car car=new Car(brand ,color ,model);
                    vehicles.Add(car);
                }else if(VehicleChoice==2){
                    Console.Write("Enter the model: ");
                    string model=Console.ReadLine();
                    Console.Write("Enter the capacity: ");
                    float capacity=float.Parse(Console.ReadLine());
                    Truck truck=new Truck(brand, color, model, capacity);
                    vehicles.Add(truck);
                }else{
                    Console.WriteLine("Input only 1 and 2");
                }
                Console.WriteLine("==========");
            }
            Console.WriteLine("You have added the Following Vehicles: ");
            foreach(Vehicle v in vehicles){
                Console.WriteLine("A of brand " +v.brand+ " with a color of " +v.color);
            }
        }
} 
