public class Truck:Vehicle{
    public string model{get; set;}
    private float capacity{get; set;}
    public Truck(string brand, string color,string model,float capacity): base(brand,color){
        this.model=model;
        this.capacity=capacity;
    }
}