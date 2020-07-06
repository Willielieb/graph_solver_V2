namespace graph_solver.Classes
{
    public class Constraints
    {
        private int xOneCoeff;
        private int xTwoCoeff;
        private string sign;
        private int rHS;

        public Constraints(int xOneCoeff, int xTwoCoeff, string sign, int rHS)
        {
            XOneCoeff = xOneCoeff;
            XTwoCoeff = xTwoCoeff;
            Sign = sign;
            RHS = rHS;
        }

        public int XOneCoeff
        {
            get
            {
                return xOneCoeff;
            }

            set
            {
                xOneCoeff = value;
            }
        }

        public int XTwoCoeff
        {
            get
            {
                return xTwoCoeff;
            }

            set
            {
                xTwoCoeff = value;
            }
        }

        public int RHS
        {
            get
            {
                return rHS;
            }

            set
            {
                rHS = value;
            }
        }

        public string Sign
        {
            get
            {
                return sign;
            }

            set
            {
                sign = value;
            }
        }
    }
}