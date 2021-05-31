using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_Project
{ 
    class FunctionPoint
    {
        public static int [,] Complexity_table;
        public static List<KeyValuePair<string, int>> GSC;
        public FunctionPoint()
        {
            Complexity_table = new int[5, 3];
            GSC = new List<KeyValuePair<string, int>>();

            //External input 
            /*Simple*/
            Complexity_table[0, 0] = 3;
            /*Averge*/
            Complexity_table[0, 1] = 4;
            /*Complex*/
            Complexity_table[0, 2] = 6;


            //External output
            /*Simple*/
            Complexity_table[1, 0] = 4;
            /*Averge*/
            Complexity_table[1, 1] = 5;
            /*Complex*/
            Complexity_table[1, 2] = 7;


            //External inquiry 
            /*Simple*/
            Complexity_table[2, 0] = 3;
            /*Averge*/
            Complexity_table[2, 1] = 4;
            /*Complex*/
            Complexity_table[2, 2] = 6;


            //Internal Logical Files
            /*Simple*/
            Complexity_table[3, 0] = 7;
            /*Averge*/
            Complexity_table[3, 1] = 10;
            /*Complex*/
            Complexity_table[3, 2] = 15;


            //External Interface Files
            /*Simple*/
            Complexity_table[4, 0] = 5;
            /*Averge*/
            Complexity_table[4, 1] = 7;
            /*Complex*/
            Complexity_table[4, 2] = 10;


            //GSC

            // No Influence
            GSC.Add(new KeyValuePair<string, int>("No Influence", 0));

            // Incidental
            GSC.Add(new KeyValuePair<string, int>("Incidental", 1));

            // Moderate
            GSC.Add(new KeyValuePair<string, int>("Moderate", 2));

            // Averge
            GSC.Add(new KeyValuePair<string, int>("Averge", 3));

            //Significant
            GSC.Add(new KeyValuePair<string, int>("Significant", 4));

            //Essential
            GSC.Add(new KeyValuePair<string, int>("Essential", 5));
        }

        public int calculate_UFP(int EI,string EI_comp,int EO, string Eo_comp, int Q, string Q_comp, int ILF, string ILF_comp, int EIF, string EIF_comp)
        {
            int input=0, output=0, qury=0, file=0, interface_=0;


            //input_complexity
            if(EI_comp=="Simple")
            {
                input = Complexity_table[0, 0];
            }
            else if(EI_comp == "Averge")
            {
                input = Complexity_table[0, 1];
            }
            else if(EI_comp == "Complex")
            {
                input = Complexity_table[0, 2];
            }

            //output_complexity
            if (Eo_comp == "Simple")
            {
                output = Complexity_table[1, 0];
            }
            else if (Eo_comp == "Averge")
            {
                output = Complexity_table[1, 1];
            }
            else if (Eo_comp == "Complex")
            {
                output = Complexity_table[1, 2];
            }

            //Query_complexity
            if (Q_comp == "Simple")
            {
                qury = Complexity_table[2, 0];
            }
            else if (Q_comp == "Averge")
            {
                qury = Complexity_table[2, 1];
            }
            else if (Q_comp == "Complex")
            {
                qury = Complexity_table[2, 2];
            }

            //ILF_complexity
            if (ILF_comp == "Simple")
            {
                file = Complexity_table[3, 0];
            }
            else if (ILF_comp == "Averge")
            {
                file = Complexity_table[3, 1];
            }
            else if (ILF_comp == "Complex")
            {
                file= Complexity_table[3, 2];
            }

            //EIF_complexity
            if (EIF_comp == "Simple")
            {
                interface_ = Complexity_table[4, 0];
            }
            else if (EIF_comp == "Averge")
            {
                interface_ = Complexity_table[4, 1];
            }
            else if (EIF_comp == "Complex")
            {
                interface_ = Complexity_table[4, 2];
            }
            int result = (input * EI) + (output * EO) + (qury * Q) + (file * ILF) + (interface_ * EIF);
            return result;
        }
    }
}
