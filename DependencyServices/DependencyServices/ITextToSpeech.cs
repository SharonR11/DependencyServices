using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyServices
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
