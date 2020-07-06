using graph_solver.Classes;
using graph_solver.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace graph_solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            chart_display.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            lister();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
        }

        #region Variables

        private DataHandler dh = new DataHandler();
        private List<Constraints> constraints = new List<Constraints>();
        private List<Line> lines = null;
        private LiniarModel lm = null;
        private List<double> listofxs = new List<double>();
        private List<double> listofys = new List<double>();

        #endregion Variables

        #region FormMethods

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_x1.Text != "")
            {
                ChangingConstraints();
            }
        }

        private void constraint_listox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_x1.Clear();
            txt_x2.Clear();
            cmb_sign.Items.Clear();
            txt_rhs.Clear();
            //listBox3.Items.Clear();

            foreach (Constraints item in constraints)
            {
                string sign;
                if (item.Sign.Equals("Less"))
                {
                    sign = "<=";
                }
                else if (item.Sign.Equals("Greater"))
                {
                    sign = ">=";
                }
                else
                {
                    sign = "=";
                }
                string temp = item.XOneCoeff + "X1 + " + item.XTwoCoeff + "X2 " + sign + " " + item.RHS;
                if (temp.Equals(constraints_listbox.SelectedItem))
                {
                    txt_x1.Text = item.XOneCoeff.ToString();
                    txt_x2.Text = item.XTwoCoeff.ToString();
                    cmb_sign.Items.Add(item.Sign);
                    txt_rhs.Text = item.RHS.ToString();
                }
            }
        }

        #endregion FormMethods

        #region Methods

        /// <summary>
        /// Runs the adding of charts
        /// </summary>
        public void Charter()
        {
            CreateObjectiveFunc();

            List<double> listofrangepoints = new List<double>();
            int i = 2;
            int j = 2;
            var chart = chart_display.ChartAreas[0];
            chart.AxisX.Interval = 5;
            chart.AxisX.Minimum = 0;
            chart.AxisY.Interval = 5;
            chart.AxisY.Minimum = 0;

            foreach (Constraints item in constraints)
            {
                chart_display.Series.Add("Constraint " + i.ToString());

                chart_display.Series["Constraint " + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                if (item.Sign == "Less")
                {
                    chart_display.Series[i].Color = Color.DarkGoldenrod;
                }
                else if (item.Sign == "Greater")
                {
                    chart_display.Series[i].Color = Color.Red;
                }
                else
                {
                    chart_display.Series[i].Color = Color.Green;
                }
                string sign;
                if (item.Sign.Equals("Less"))
                {
                    sign = "<=";
                }
                else if (item.Sign.Equals("Greater"))
                {
                    sign = ">=";
                }
                else
                {
                    sign = "=";
                }
                solution_listbox.Items.Add(item.XOneCoeff + "X1 + " + item.XTwoCoeff + "X2 " + sign + " " + item.RHS);

                listofxs.Add(item.XOneCoeff);
                listofys.Add(item.XTwoCoeff);

                i++;
            }
            constraints_listbox.Items.Add("X1,X2>=0");
            List<Line> points = CalculatePoints(constraints);
            List<double> feasx = new List<double>();
            List<double> feasy = new List<double>();
            foreach (Line item in points)
            {
                //add line points
                chart_display.Series["Constraint " + j].Points.AddXY(item.PointOne, 0);
                chart_display.Series["Constraint " + j].Points.AddXY(0, item.PointTwo);
                coords_listbox.Items.Add(item.PointOne + ",0 0," + item.PointTwo);
                feasx.Add(item.PointOne);
                feasy.Add(item.PointTwo);
                j++;
            }
            // feasible region add of points
            MessageBox.Show(listofxs.Min().ToString());
            MessageBox.Show(listofys.Min().ToString());
            chart_display.Series[0].Points.AddXY(feasx.Min(), 0);
            chart_display.Series[0].Points.AddXY(0, feasy.Min());

            double optx = feasx.Min();
            double opty = feasy.Min();

            List<double> optimal = new List<double>();

            foreach (var item in points)
            {
            }
        }

        /// <summary>
        /// Calculates the points
        /// </summary>
        public List<Line> CalculatePoints(List<Constraints> constraintList)
        {
            lines = new List<Line>();
            foreach (Constraints item in constraintList)
            {
                lines.Add(new Line(item.RHS / item.XOneCoeff, item.RHS / item.XTwoCoeff));
            }
            return lines;
        }

        /// <summary>
        /// Creates a list of points
        /// </summary>
        public void lister()
        {
            try
            {
                lm = dh.ReadProblem();

                constraints_listbox.Items.Add(lm.ProblemMax);
                constraints_listbox.Items.Add(lm.XOneObjective);
                constraints_listbox.Items.Add(lm.XTwoObjective);

                foreach (Constraints item in lm.Constraints)
                {
                    string sign;
                    if (item.Sign.Equals("Less"))
                    {
                        sign = "<=";
                    }
                    else if (item.Sign.Equals("Greater"))
                    {
                        sign = ">=";
                    }
                    else
                    {
                        sign = "=";
                    }
                    constraints_listbox.Items.Add(item.XOneCoeff + "x1 " + item.XTwoCoeff + "x2 " + sign + " " + item.RHS);
                    constraints.Add(item);
                }
                Charter();

                constraints_listbox.Items.Add(lm.RestrictionOne);
                constraints_listbox.Items.Add(lm.RestrictionTwo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Creates objective function line
        /// </summary>
        public void CreateObjectiveFunc()
        {
            chart_display.Series.Add("OBJ FUNC");
            chart_display.Series["OBJ FUNC"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_display.Series["OBJ FUNC"].Color = Color.Purple;
            Line ObjFuc = new Line(lm.XTwoObjective, lm.XOneObjective);
            chart_display.Series["OBJ FUNC"].Points.AddXY(ObjFuc.PointOne, 0);
            chart_display.Series["OBJ FUNC"].Points.AddXY(0, ObjFuc.PointTwo);
        }

        public void ChangingConstraints()
        {
            //for (int i = 2; i < constraints.Count+2; i++)
            //{
            //    foreach (Constraint item in constraints)
            //    {
            //        string temp = item.XOneCoeff + " " + item.XTwoCoeff + " " + item.Sign + " " + item.RHS;
            //        if (temp.Equals(listBox2.SelectedItem))
            //        {
            //            item.XOneCoeff = int.Parse(textBox1.Text);
            //            lines = CalculatePoints(constraints);
            //            chart1.Series[i].Points.RemoveAt(0);
            //            foreach (Line item1 in lines)
            //            {
            //                chart1.Series[i].Points.AddXY(item1.PointOne, 0);
            //            }

            //        }

            //    }
            //}
        }

        #endregion Methods
    }
}