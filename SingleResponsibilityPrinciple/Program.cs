using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateReport generate = new GenerateReport("This Line Should Be Generated");
            FormatReport format = new FormatReport();
            SaveToFile save = new SaveToFile();
            LoadFromFile load = new LoadFromFile();

            string generatedReport = generate.Generate();
            string formatted = format.Format(generatedReport);
            save.Save("new_report.txt",formatted);
            string loadedTxt = load.Load("new_report.txt");
            Console.WriteLine(loadedTxt);
        }
    }
}
