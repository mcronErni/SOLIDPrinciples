using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class SaveToFile
    {
        public void Save(string filename, string Content)
        {
            File.WriteAllText(filename, Content);
        }
    }

    public class LoadFromFile
    {
        public string Load(string filename)
        {
            var Content = File.ReadAllText(filename);
            return Content;
        }
    }

}
