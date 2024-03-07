public  abstract class Furniture
{
    //! Step1 
    //? Fields To Describe our object
    protected string color;
    public string _color { get { return color; } }
    public double price;
    private string material;
    public string _material { get { return material; } }
    public bool outdoor;

    //! Step2 
    //? Constructor 
    public Furniture(string c, double p, string m, bool o)
    {
        color = c;
        price = p;
        material = m;
        outdoor = o;
    }
    public Furniture(string c, double p, string m)
    {
        color = c;
        price = p;
        material = m;
        outdoor = false;
    }
    public Furniture(string c, string m, bool o = false)
    {
        color = c;
        price = 12.00;
        material = m;
        outdoor = o;
    }

    //! Step 3
    //? Methods 

    public virtual void ChangeColor(string newColor)
    {
        Console.WriteLine($" changed our furniture from {color} to {newColor}");
        color = newColor;
    }



}