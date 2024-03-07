
class Table : Furniture, IDecorate
{
    public int numberOfItems{get;set;}

    public List<string> AllItems {get;set;}


    public Table(string c, double p, string m, bool o): base(c, p, m, o)
    {
        numberOfItems = 0;

        AllItems = new List<string>();

    }

    //? IDecorate Method
    public void AddItem(string Item)
    {
        numberOfItems++;
        AllItems.Add(Item);

    }

    public void ShowItems()
    {
        foreach(string item in AllItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(numberOfItems);
    }


}