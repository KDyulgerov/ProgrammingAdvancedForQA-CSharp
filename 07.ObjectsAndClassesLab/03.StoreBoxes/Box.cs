
public class Box
{
    int serialNumber;
    int itemQuantity;
    decimal priceForBox;

    public int SerialNumber
    {
        get { return serialNumber; }
        set { serialNumber = value; }
    }

    public Item Item { get; }

    public int ItemQuantity
    {
        get { return itemQuantity; }
        set { itemQuantity = value; }
    }
    
    public decimal PriceForBox
    {
        get { return priceForBox; }
        set { priceForBox = value; }
    }

    public Box(int serialNumber, Item item, int itemQuantity, decimal priceForBox)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        PriceForBox = priceForBox;
    }

}

