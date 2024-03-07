class Chair : Furniture
{
    public int numLegs;
    public bool hasArms;


    // Constructor 
    public Chair(string c, double p, string m, bool o, int nl, bool ha) : base(c, p, m, o)
    {
        numLegs = nl;
        hasArms = ha;
    }

    public override void ChangeColor(string newColor)
    {
        Console.WriteLine($" changed our Chair from {color} to {newColor}");
        color = newColor;
    }




}