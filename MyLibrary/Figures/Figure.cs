namespace MyLibrary.Figures
{
    public abstract class Figure
    {
        private Lazy<double> _area;
        public double Area { get { return _area.Value; } }
        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }
        public abstract double CalculateArea();
    }
}