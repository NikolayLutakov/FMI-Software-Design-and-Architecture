using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class MagicWordsEventArgs : EventArgs
    {
        public MagicWords Words { get; set; }
    }
}
