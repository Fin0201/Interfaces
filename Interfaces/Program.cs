using Interfaces;

Square sq = new Square(25, 25);
sq.Colour = Colours.BLACK;
Console.WriteLine(sq.Area());

List<IShape> shapes = new List<IShape>();
shapes.Add(sq);