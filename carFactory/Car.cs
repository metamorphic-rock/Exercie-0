public class Car:Vehicle{
    public string model{get; set;}
    public Car(string brand,string color,string model): base (brand , color)
    {
        this.model=model;
    }
}