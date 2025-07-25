using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Book
    {
        public string Classification { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public bool IsReference { get; set; }
        public int Copies { get; set; }

        public List<string> GenerateBookNumbers()
        {
            List<string> numbers = new List<string>();
            string baseNumber = $"{Classification}{Number.ToString("D4")}";
            for (int i = 1; i <= Copies; i++)
            {
                numbers.Add($"{baseNumber}{i}");
            }
            return numbers;
        }
    }
}

