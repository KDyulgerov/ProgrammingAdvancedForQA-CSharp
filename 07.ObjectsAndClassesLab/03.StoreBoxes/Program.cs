
string input = Console.ReadLine();

List<Box> boxes = new List<Box>();

while (input != "end")
{
    string[] currentInput = input.Split().ToArray();
    int serialNumber = int.Parse(currentInput[0]);
    string itemName = currentInput[1];
    int itemQuantity = int.Parse(currentInput[2]);
    decimal itemPrice = decimal.Parse(currentInput[3]);

    Item item = new Item(itemName, itemPrice);

    decimal priceForBox = itemQuantity * itemPrice;
    Box box = new Box(serialNumber, item, itemQuantity, priceForBox);
    boxes.Add(box);

    input = Console.ReadLine();
}

foreach (Box box in boxes.OrderByDescending(b => b.PriceForBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForBox:F2}");
}