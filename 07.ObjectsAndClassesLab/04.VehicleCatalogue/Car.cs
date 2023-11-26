
public class Car
{
    string brand;
    string model;
    int horesePower;

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

    public int HorsePower
    {
        get { return horesePower; }
        set { horesePower = value; }
    }

    public Car (string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
}

