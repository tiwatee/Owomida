namespace OwoMiDa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drivers amount = new Drivers();
            Console.WriteLine("The total toll for the five drivers is: "+amount.TotalAmount());
        }
    }
}