using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                calculator.Divide(5, 0);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
            }
            catch(ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine("Sorry, an unexpected error occred!");
            }
            finally
            {

            }

            //Example2 
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                streamReader.ReadToEnd();
                throw new Exception("Opp");
            }
            catch (Exception e)
            {

                Console.WriteLine("Sorry, an unexpected error occred!");
            }

            finally
            {
                if(streamReader !=null)
                streamReader.Dispose();
            }

            //Example 3 - same as Example2 , but less code with using statement
            //in this case we don't need a finally block. CLR automatically create it.and call the dispose method
            try
            {
                using (var streamReader1 = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader1.ReadToEnd();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Sorry, an unexpected error occred!");
            }

            //Example 4
            try
            {
                var api = new YouTubeAPI();
                api.GetVideos("dul");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           

        }
    }
}
