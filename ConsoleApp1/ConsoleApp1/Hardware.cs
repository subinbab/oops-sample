using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hardware : ICall, IMessage
    {
        public bool IsMessageSend(string message)
        {
            throw new NotImplementedException();
        }

        public string RecieveMessage()
        {
            throw new NotImplementedException();
        }

        public string VoiceReceiver()
        {
            VoiceDecoder();
            VoiceStreamer();
            return "hello John";
        }

        public void VoiceSender(string voice)
        {
            VoiceRecorder(voice);
            VoiceEncoder();
        }
        private void VoiceRecorder(string voice)
        {
            Console.WriteLine(voice);
        }
        private void VoiceEncoder()
        {

        }
        private void VoiceDecoder()
        {

        }
        private void VoiceStreamer()
        {

        }
    }
}
