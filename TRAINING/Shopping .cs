using System;
public struct Customer
{

}

public enum ItemCategory
{
    women=101,
    Men,
    Girls,
    Boys,
    Babies
}
public enum City
{
    Delhi,
    Mumbai,
    Kolkata,
    Bangalore,
    Hyderabad,
    Pune,
    Chennai
}
class ShoppingItems
{
    string Name;
    int Size;
    decimal Unitprice;
    ItemCategory Category;
    City ShoppingCity;

    public static ShoppingItems Read()
    {
        string category;
        ShoppingItems shop = new ShoppingItems();

        Console.WriteLine("Categories");
        Console.WriteLine("\t1.women");
        Console.WriteLine("\t2.Men");
        Console.WriteLine("\t3.Girls");
        Console.WriteLine("\t4.Boys");
        Console.WriteLine("\t5.Babies");
        Console.WriteLine("enter the category Number(1-5):");
        category = Console.ReadLine();
        if (category == "1")
            shop.Category = ItemCategory.women;
        else if (category == "2")
            shop.Category = ItemCategory.Men;
        else if (category == "3")
            shop.Category = ItemCategory.Girls;
        else if (category == "4")
            shop.Category = ItemCategory.Boys;
        else if (category == "5")
            shop.Category = ItemCategory.Babies;
        else
        {
            Console.WriteLine("invalid item category");
            System.Environment.Exit(0);
            Console.ReadLine();

        }
        Console.Write("Item Name: ");
        shop.Name = Console.ReadLine();
        Console.Write("Number of units:");
        shop.Size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Unit price:");
        shop.Unitprice = decimal.Parse(Console.ReadLine());


        Console.WriteLine("Enter your city:");
        string str1 = Console.ReadLine();
        shop.ShoppingCity = (City)Enum.Parse(typeof(City), str1);
        return shop;
    }


    public static void Write(ShoppingItems item)
    {
        Console.WriteLine("{0;d}", DateTime.Now);
        Console.WriteLine("Category: {0}", ItemCategory Category);
        Console.WriteLine("Description:");
    }







}
