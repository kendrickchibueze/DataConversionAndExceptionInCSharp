namespace DataConversionAndExceptionInCSharp
{
    internal class MyRectangle
    {
        private double _width;
        private double _length;

        public MyRectangle()
        {
            
        }
        public MyRectangle(double width, double length)
        {
            SetLength(length);
            SetWidth(width);
            
        }

        public double Length { 
            get 
            {
                return _length;
            } 
        }
        public double  Width { 
            get 
            {
                return _width;
            }
        }

        public void SetLength(double value)
        {
            if(value > 0)
            {
               _length = value;
            }
            else
            {
                throw new ArgumentException("The length must not be less than or equal to 0");
            }
           

        }

        public void SetWidth(double value)
        {
            if(value >0)
            {
                _width = value;
            }
            else
            {
                throw new ArgumentException("The width must not be less than or equal to 0");
            }
        }

      /*  public double Area {
            get
            {
                return Length * Width;
            }
        }*/

        public double Area()
        {
            return Length * Width;
        }


    }
}
