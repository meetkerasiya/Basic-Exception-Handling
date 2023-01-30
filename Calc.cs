namespace Basic_Exception_Handling
{
    internal class Calc
    {
        public static void Division()
        {

            Console.WriteLine("Please enter two numbers to devide");
            int x = int.Parse(Console.ReadLine());
            int div = int.Parse(Console.ReadLine());
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
