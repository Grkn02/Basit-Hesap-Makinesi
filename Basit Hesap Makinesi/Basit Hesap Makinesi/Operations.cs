using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Basit_Hesap_Makinesi
{
    internal class Operations
    {

        static List<string> memory = new List<string>(){ "0" };
        public static string  view = "0";


        public static void Add(string input)
        {

            if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                if (memory.Last() == "+" || memory.Last() == "-" || memory.Last() == "/" || memory.Last() == "*")
                {
                    memory[memory.Count - 1] = input;

                }

                else if (!(memory.Last()[memory.Last().Length - 1] == '.') && double.TryParse(memory.Last(), out double _))
                {
                    memory.Add(input);

                }

            }

            else if (int.TryParse(input, out _))   // input if it is number
            {
                if (memory.Last() == "+" || memory.Last() == "-" || memory.Last() == "/" || memory.Last() == "*")
                {
                    memory.Add(input);

                }

                else if (memory.Last().Contains(".") || int.TryParse(memory.Last(), out int _))
                {
                    if (memory.Count == 1 && memory[0] == "0") memory[0] = input;

                    else memory[memory.Count - 1] = memory.Last() + input;

                }
          
            
            }

            else if (input == "." && !memory.Last().Contains(".") && int.TryParse(memory.Last(), out int _))  // input  if it is "."
            {
                memory[memory.Count - 1] = memory.Last() + input;

            }

            else if (input == "C")
            {
                memory.Clear();
                memory.Add("0");

            }
            else if (input == "del")
            {
                if (memory.Last() == "+" || memory.Last() == "-" || memory.Last() == "/" || memory.Last() == "*")
                {
                    memory.RemoveAt(memory.Count - 1);

                }


                else if (!(memory.Count == 1 && memory[0].Length == 1)) //Delete last digit
                {
                    if (memory.Last().Length > 1)
                    {
                        memory[memory.Count - 1] = memory.Last().Substring(0, memory.Last().Length - 1);
                    }

                    else
                    {
                        memory.RemoveAt(memory.Count - 1);

                    }


                }

                else 
                {
                    memory.Clear();
                    memory.Add("0");
                } 


            }

            view = "";
            foreach (string item in memory)
            {
                view += item;

            }

        }

        public static void Process() // when sb press "="
        {
            if (!double.TryParse(memory.Last(), out double _))
            {
                memory.RemoveAt(memory.Count - 1);
                view = "";
                foreach (string item in memory)
                {
                    view += item;

                }
            }

            double result = Convert.ToDouble(new DataTable().Compute(view, null)); // arithmetic operations
            view = result.ToString(CultureInfo.CreateSpecificCulture("en-GB")); // preventing differences between 12.3 and 12,3 (dot and comma diffrences)
            memory.Clear();
            memory.Add(view);
        }



       
    }
}
