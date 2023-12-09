using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _lenght;
    private double _width;
    private double _height;

    public double Lenght
    {
        get { return _lenght; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{this.Lenght} cannot be zero or negative.");
            }
            _lenght = value;
        }
    }
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{this.Width} cannot be zero or negative.");
            }
            _width = value;
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{this.Height} cannot be zero or negative.");
            }
            _height = value;
        }
    }

    public Box (double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea()
    {
        // 2*L*W + 2*L*H + 2*W*H
        return 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
    }

    public double Volume()
    {
        // L*W*H
        return this.Lenght * this.Width * this.Height;
    }

    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():F2}{Environment.NewLine}Volume – {this.Volume():F2}";
    }
}
