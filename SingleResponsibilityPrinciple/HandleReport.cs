using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class GenerateReport
    {
        public string Content { get; set; }
        public GenerateReport(string content)
        {
            Content = content;
        }
        public string Generate()
        {
            return Content;
        }
    }

    public class FormatReport
    {
        public string Format(string content)
        {
            return content = content.ToLower();
        }
    }
}
