
public class Item
{
    string itemName;
    decimal price;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public Item (string itemName, decimal price) 
    {
        ItemName = itemName;
        Price = price;
    }
}

