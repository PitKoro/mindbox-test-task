namespace MyLibrary.Figures
{
    public class Triangle : Figure
    {
        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

        public bool IsRightAngled { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("The side of a triangle cannot be negative.");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            IsRightAngled = CheckIsRightAngled();
        }
        private bool CheckIsRightAngled()
        {
            return (
                FirstSide == Math.Sqrt(Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
                || SecondSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2))
                || ThirdSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2))
            );
        }
        public override double CalculateArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(
                semiPerimeter
                * (semiPerimeter - FirstSide)
                * (semiPerimeter - SecondSide)
                * (semiPerimeter - ThirdSide)
            );
        }
    }
}
