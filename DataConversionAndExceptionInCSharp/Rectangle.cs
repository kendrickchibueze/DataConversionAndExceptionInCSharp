namespace DataConversionAndExceptionInCSharp
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        public Rectangle(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        }
        public double Length
        {
            get { return _length; }
            set { SetLength(value); }
        }
        public double Width
        {
            get { return _width; }
            set { SetWidth(value); }
        }
        private void SetLength(double value)
        {
            if (value >= 0)
                _length = value;
            else
                throw new ArgumentException("Length must be greater than or equal to 0");
        }
        private void SetWidth(double value)
        {
            if (value >= 0)
                _width = value;
            else
                throw new ArgumentException("Width must be greater than or equal to 0");
        }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }
    }
}
