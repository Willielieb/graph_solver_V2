namespace graph_solver.Classes
{
    public class Line
    {
        private int pointOne;
        private int pointTwo;

        public Line(int pointOne, int pointTwo)
        {
            PointOne = pointOne;
            PointTwo = pointTwo;
        }

        public int PointOne
        {
            get
            {
                return pointOne;
            }

            set
            {
                pointOne = value;
            }
        }

        public int PointTwo
        {
            get
            {
                return pointTwo;
            }

            set
            {
                pointTwo = value;
            }
        }
    }
}