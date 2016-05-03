using System;

namespace Meiosis.Engine
{
    public class LoremIpsumEngine
    {

        private ILoremIpsumTextDictionary _dictionaryProvider;
        public LoremIpsumEngine(ILoremIpsumTextDictionary provider)
        {
            _dictionaryProvider = provider;
        }

      
        public LoremIpsumText Create(int expectedWords)
        {
            LoremIpsumText text = new LoremIpsumText();

            if (_dictionaryProvider != null)
            {
                text.Words = _dictionaryProvider.GetText(expectedWords);
            }

            return text;
        }
    }
}