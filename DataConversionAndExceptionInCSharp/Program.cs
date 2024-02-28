namespace DataConversionAndExceptionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Conversion and Exception in C#...");

            try
            {
                Rectangle rc = new Rectangle(8.9, 7.9);
                Console.WriteLine("The Area before boxing is : {0}", rc.Area); 
                int newArea = (int)rc.Area;
                Console.WriteLine("The type conversion from double to int is : {0}", newArea);
                object o = rc;
                Console.WriteLine("We have boxed the area: {0}", o.GetType());     
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : " +  ex.Message);   
            }      
        }
    }
}