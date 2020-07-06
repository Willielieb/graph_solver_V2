using graph_solver.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace graph_solver.DAL
{
    internal class DataHandler
    {
        public LiniarModel ReadProblem()
        {
            LiniarModel newProblem = null;
            List<Constraints> newConstraints = new List<Constraints>();
            bool newProblemMax = true;
            int newXOneObjective = 0;
            int newXTwoObjective = 0;
            string newRestrictionOne = null;
            string newRestrictionTwo = null;
            string newSign = null;
            try
            {
                FileStream fs = new FileStream("C:\\Users\\User\\OneDrive\\Desktop\\Coding stuff\\Csharp\\graph_solver\\DAL\\Problem.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                string readLine = reader.ReadLine();
                string[] arrFile = new string[4];
                arrFile = readLine.Split(' ');
                if (arrFile[0] == "Min")
                {
                    newProblemMax = false;
                }

                newXOneObjective = int.Parse(arrFile[1]);
                newXTwoObjective = int.Parse(arrFile[2]);
                try
                {
                    while (readLine != null)
                    {
                        readLine = reader.ReadLine();
                        arrFile = readLine.Split(' ');
                        if (arrFile[0] == "+" || arrFile[0] == "-" || arrFile[0] == "urs")
                        {
                            newRestrictionOne = arrFile[0];
                            newRestrictionTwo = arrFile[1];
                            break;
                        }
                        if (arrFile[2] == "<=")
                        {
                            newSign = "Less";
                        }
                        else if (arrFile[2] == ">=")
                        {
                            newSign = "Greater";
                        }
                        else { newSign = "Equal"; }
                        newConstraints.Add(new Constraints(int.Parse(arrFile[0]), int.Parse(arrFile[1]), newSign, int.Parse(arrFile[3])));
                    }
                    newProblem = new LiniarModel(newProblemMax, newXOneObjective, newXTwoObjective, newConstraints, newRestrictionOne, newRestrictionTwo);
                    reader.Close();
                    fs.Close();
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("File Format Incorrect", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }

            return newProblem;
        }
    }
}