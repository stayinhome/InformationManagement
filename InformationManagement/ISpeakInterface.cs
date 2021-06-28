
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InformationManagement
{
    public interface ISpeakInterface
    {

        string Speak(SpeakEnvironment environment ,SpeakContext speakContext);


    }
}