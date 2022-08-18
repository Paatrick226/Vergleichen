using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Vergleichen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("1");
            list.Add("3");
            list.Add("5");
            list.Add("7");
            //list.Add("12345");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            List<string> list2 = new List<string>();

                        
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("other");
            dt.Rows.Add("1","2");
            dt.Rows.Add("3", "4");
            dt.Rows.Add("5", "6");
            dt.Rows.Add("7", "8");

            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine(r["name"].ToString() + " - " + r["other"].ToString());
            }


            List<string> s = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();

            foreach (string e in s)
                Console.WriteLine(e);
            
            Console.WriteLine("Vergleichen: ");
            List<string> firstNotSecond = list.Except(s).ToList();
            
            

            if(firstNotSecond.Count != 0)
            {
                Console.WriteLine("ungleich!!");
                Console.WriteLine("Daten in Liste 1 nicht in Liste 2:");
                foreach (string x in firstNotSecond)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("gleich");
            }

            Console.ReadLine();
        }
    }
}