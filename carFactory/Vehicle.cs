public class Vehicle
{
    public string brand { get; private set; }
    public string color { get; private set; }
    public Vehicle(string brand, string color)
    {
        this.brand = brand;
        this.color = color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public string GetColor()
    {
        return this.color;
    }
    public void SetBrand(string brand)
    {
        this.brand = brand;
    }
    public string GetBrand(){
        return this.brand;
    }
}