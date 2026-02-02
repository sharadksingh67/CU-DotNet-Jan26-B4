namespace OOPSLearning
{

    class SalaryOutOfRangeException : Exception
    {
        public SalaryOutOfRangeException(string message):base(message)
        {
            
        }
    }
    internal class Demo15Exceptions
    {
        static void CheckException()
        {
            try
            {
                Console.WriteLine("Trying to use finally");
                throw new DivideByZeroException("You tried to divide by zero");
                // return;

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Handle most generic exception");
            }
            catch
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Inside CheckException Finally");
            }
            Console.WriteLine("After Finally in CheckException");
        }
        static int GetDiv(int x, int y)
        {            
            int[] arr = {2,3,4 };
            try
            {
                return arr[5]; // x/y;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("DivideByZeroException");
            }
            finally
            {
                Console.WriteLine("finally of Method");
            }
            
            return x/y;            
        }
        static void Main(string[] args)
        {
            try
            {
                //int salary = 123456;

                //if(salary > 100000)
                //{
                //    throw new SalaryOutOfRangeException(
                //        "Salary is too high...");
                //}

                CheckException();
                //int result = GetDiv(15, 0);
                //int[] arr = { 1, 2, 3 };
                //return;
                //Console.WriteLine(arr[5]);
            }            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException - "
                        + ex.Message);
            }
            catch(SalaryOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " - " 
                    + ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Handling Generic Exception in Main - "
                            + ex.Message + " - "
                    + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Inside Finally");
            }
            Console.WriteLine("Done");
        }
    }
}
