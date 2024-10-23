namespace ClassObj231024
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1=new Circle();
            Console.WriteLine("Enter radius of Circle");
            float r1=float.Parse(Console.ReadLine());   
            c1.SetRadius(r1);
            c1.ShowArea();
        }
    }
}
