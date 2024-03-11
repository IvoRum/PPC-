namespace Zad2;

public class ShapeObjectFactory
{
    private Dictionary<string, Ishape> shapes = new Dictionary<string, Ishape>();
    public int TotalObjectsCreated=0;

    public Ishape GetShape(string ShapeName)
    {
        Ishape shape = null;
        if (shapes.ContainsKey(ShapeName))
        {
            shape = shapes[ShapeName];
        }
        else
        {
            switch (ShapeName)
            {
                case "Rectangle":
                    shape = new Rectangle();
                    shapes.Add("Rectangle", shape);
                    TotalObjectsCreated++;
                    break;
                case "Circle":
                    shape = new Circle();
                    shapes.Add("Circle", shape);
                    TotalObjectsCreated++;
                    break;
                default:
                    Console.WriteLine("Factory cannot create the object specified");
                    break;
            }
        }

        return shape;
    }

    public int TotalObjectsCreated1
    {
        get => TotalObjectsCreated;
        set => TotalObjectsCreated = value;
    }
}