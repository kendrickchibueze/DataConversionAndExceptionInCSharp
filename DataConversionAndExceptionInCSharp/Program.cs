namespace DataConversionAndExceptionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Conversion and Exception in C#...");
            Console.WriteLine();

            try
            {
                MyRectangle myrec = new MyRectangle();
                Console.WriteLine("Enter the Length : ");
                myrec.SetLength(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine();
                Console.WriteLine("Enter the width : ");
                myrec.SetWidth(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("The Area of the rectangle without conversion is : {0}", myrec.Area());

                int MyArea = (int)myrec.Area(); // converted from double to an int
                Console.WriteLine("The Area after converting to Int is : {0}", MyArea);
                Console.WriteLine("Boxing output");
                object boxedOutput = MyArea;
                Console.WriteLine("The is boxing return : {0}", boxedOutput);
                int unboxedOutput = (int)boxedOutput;
                Console.WriteLine("The unboxed value is : {0}", unboxedOutput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }

           /* try
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
            } */     
        }
    }
}