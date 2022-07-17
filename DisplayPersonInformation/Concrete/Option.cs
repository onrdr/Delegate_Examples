 
namespace DisplayPersonInformation.Concrete
{
    public class Option
    {
        public static int GetValidOption()
        {
            int option;
            while (true)
            {
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (!(option < 5 && option > 0))
                        Console.WriteLine("Input is not in valid range. Try again \n");
                    else break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a Valid Input. Try again \n"); ;
                }
            }
            return option;
        }
    }
}
