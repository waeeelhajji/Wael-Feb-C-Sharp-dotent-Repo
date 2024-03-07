Chair newChair = new Chair("Red", 20.3, "Wood", false,56,true);



Console.WriteLine(newChair._material);

// Chair.color = "Blue";

Console.WriteLine(newChair._color);

newChair.ChangeColor("Black");

Chair stool = new Chair("white", 55.55, "Wood", false, 55, true);


Console.WriteLine("====>" + stool.numLegs);
Console.WriteLine("====>" + stool.hasArms);

stool.ChangeColor("aaaaaa");


//? Polymorphism

List<Furniture> AllFurniture = new List<Furniture>();

AllFurniture.Add(newChair);
AllFurniture.Add(stool);

//? Interface

Table newTable = new Table("Magenta",782.26,"Wood",false);
newTable.AddItem("Plate set");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");
newTable.AddItem("Tablecloth");


newTable.ShowItems();





