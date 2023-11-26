
public class Truck
{
    string brand;
    string model;
    int weight;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}

