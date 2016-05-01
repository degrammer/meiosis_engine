using System;

namespace Meiosis.Engine
{
    public class LoremIpsumEngine
    {

        private LoremIpsumTextDictionaryProvider _dictionaryProvider;
        public LoremIpsumEngine(LoremIpsumTextDictionaryProvider provider)
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