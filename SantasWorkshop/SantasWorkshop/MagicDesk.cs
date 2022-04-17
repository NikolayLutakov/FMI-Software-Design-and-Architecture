using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class MagicDesk
    {
        public event EventHandler<CommandEventArgs> CommandWritten;
        public void OnMagicWordsSayed(object source, MagicWordsEventArgs args)
        {
            WriteCommand(args.Words);
        }

        public void WriteCommand(MagicWords words)
        {
            Command command = new Command();
            switch (words.Content)
            {
                case "I need bicycle":
                    command.Content = "bicycle";
                    break;
                case "I need doll":
                    command.Content = "doll";
                    break;
                default:
                    throw new NotImplementedException();
            }

            OnCommandWritten(command);

        }
        protected virtual void OnCommandWritten(Command command)
        {
            if (CommandWritten != null)
            {
                CommandWritten(this, new CommandEventArgs() { Command = command });
            }
        }
    }
}
