namespace Week2.app2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heftenin gununu girin");
            int dayNumber = int.Parse(Console.ReadLine());
            if (dayNumber == 1)
            {
                Console.WriteLine("univeristet");
            }
            else if(dayNumber ==2)
            {
                Console.WriteLine("universitet + code academy task");
            }
            else if (dayNumber == 3)
            {
                Console.WriteLine("universitet + footbal");
            }
            else if (dayNumber == 4)
            {
                Console.WriteLine("universitet + film");
            }
            else if (dayNumber == 5)
            {
                Console.WriteLine("universitet + ingilis dili ");
            }
            else if (dayNumber == 6)
            {
                Console.WriteLine("universitet + codeacademy");
            }
            else if (dayNumber == 7)
            {
                Console.WriteLine("universitet + codeacademy");
            }
            else
            {
                Console.WriteLine("not correct day");
            }
        }
    }
}