namespace Zalik_v5_ZVP
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Circle(5);
            circle.GetSquare();
            circle.GetCircuit();

            Figure ellipse = new Ellipse(3, 5);
            ellipse.GetSquare();
            //ellipse.GetCircuit();
        }
    }
}
