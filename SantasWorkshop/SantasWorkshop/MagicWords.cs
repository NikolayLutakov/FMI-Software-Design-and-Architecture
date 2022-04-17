using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class MagicWords
    {
        public MagicWords(string toy)
        {
            this.Content = $"I need {toy}";
        }

        public string Content { get; set; }
    }
}
