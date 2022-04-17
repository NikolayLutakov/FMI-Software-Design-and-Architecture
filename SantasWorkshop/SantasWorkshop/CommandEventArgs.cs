using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class CommandEventArgs : EventArgs
    {
        public Command Command { get; set; }
    }
}
