using System;

namespace SantasWorkshop
{
    internal class Santa
    {
        public event EventHandler<MagicWordsEventArgs> MagicWordsSayed;

        public void SayMagicWords(string toy)
        {
            var words = new MagicWords(toy);

            OnMagicWordsSayed(words);
        }

        protected virtual void OnMagicWordsSayed(MagicWords words)
        {
            if(MagicWordsSayed != null)
            {
                MagicWordsSayed(this, new MagicWordsEventArgs() { Words = words});
            }
        }
    }
}
