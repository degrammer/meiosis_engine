using System;

namespace Meiosis.Engine
{
    public class LoremIpsumProvider
    {

        private LoremIpsumTextDictionaryProvider _dictionaryProvider;
        public LoremIpsumProvider(LoremIpsumTextDictionaryProvider provider)
        {
            _dictionaryProvider = provider;
        }

      
        public LoremIpsumText Create(int expectedWords)
        {
            LoremIpsumText text = new LoremIpsumText();

            if (_dictionaryProvider != null)
            {
                text.Words = _dictionaryProvider.GetWords(expectedWords);
            }

            return text;
        }
    }
}