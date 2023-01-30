namespace Basic_Exception_Handling
{
    internal class Calc
    {
        public static void Division()
        {
            int x=5;
            int div=0;
            Console.WriteLine("Please enter two numbers to devide");
            try
            {
                x= int.Parse(Console.ReadLine());
                div=int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
               // Console.WriteLine("Numbers not entered correctly");
                Environment.FailFast("Numbers were not entered correctly");
            }
            try
            {
                div = x / div;
               
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div}");
        }
    }
}
