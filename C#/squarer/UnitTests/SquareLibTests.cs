using SquarerLib;
using SquarerLib.Shapes;

namespace UnitTests;

[TestClass]
public class FoursquareTests
{
    [TestMethod]
    public void TestExisting()
    {
        Shape shape = new Foursquare(3, 7);
    }
    [TestMethod]
    public void TestValueErrorA()
    {
        Assert.ThrowsException<SquarerException>(() => new Foursquare(-8, 15));
    }
    [TestMethod]
    public void TestValueErrorB()
    {
        Assert.ThrowsException<SquarerException>(() => new Foursquare(8, -15));
    }
    [TestMethod]
    public void TestMath()
    {
        Shape shape = new Foursquare(1, 1);
        Assert.AreEqual(1, shape.Square, 0.001, "Wrong");
    }
}

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void TestExisting()
    {
        Shape shape = new Circle(3);
    }
    [TestMethod]
    public void TestValueErrorR()
    {
        Assert.ThrowsException<SquarerException>(() => new Circle(-1));
    }
    
    [TestMethod]
    public void TestMath()
    {
        Shape shape1 = new Circle(1);
        Shape shape2 = new Circle(16);
        Assert.AreEqual(3.14, shape1.Square, 0.01, "Wrong");
        Assert.AreEqual(804.24, shape2.Square, 0.01, "Wrong");
    }
}

[TestClass]
public class TriangleTests
{
    Shape TrueTriangle = new Triangle(8, 15, 17);
    Shape ExistingTriangle = new Triangle(3, 7, 9);

    double[] NotExistingTriangle = { 2, 3, 5 };

    [TestMethod]
    public void TestNotExisting()
    {
        Assert.ThrowsException<SquarerException>(() => new Triangle(NotExistingTriangle[0], NotExistingTriangle[1], NotExistingTriangle[2]));
    }
    [TestMethod]
    public void TestExisting()
    {
        Shape shape = new Triangle(3, 7, 9);
    }
    [TestMethod]
    public void TestMath()
    {
        Shape shape = new Triangle(3, 7, 9);
        Assert.AreEqual(8.79, shape.Square, 0.01, "Wrong");
    }
    [TestMethod]
    public void TestNotTrueTriangle()
    {
        Assert.IsFalse(((Triangle)ExistingTriangle).isRightTriangle);
    }
    [TestMethod]
    public void TestTrueTriangle()
    {
        Assert.IsTrue(((Triangle)TrueTriangle).isRightTriangle);
    }
    [TestMethod]
    public void TestValueErrorA()
    {
        Assert.ThrowsException<SquarerException>(() => new Triangle(-8, 15, 17));
    }
    [TestMethod]
    public void TestValueErrorB()
    {
        Assert.ThrowsException<SquarerException>(() => new Triangle(8, -15, 17));
    }
    [TestMethod]
    public void TestValueErrorC()
    {
        Assert.ThrowsException<SquarerException>(() => new Triangle(8, 15, -17));
    }
}