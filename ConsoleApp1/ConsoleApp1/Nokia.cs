using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nokia : FeaturePhone
    {
        public Nokia(long phoneNumber,string simName) : base(simName,phoneNumber)
        {

        }

        protected override void GetInformation()
        {
                Console.WriteLine("Phone Number :" + GetPhone());
                Console.WriteLine("Model Number :" + GetModel());
            
        }

        protected override void ImplementationMakeCall(long phoneNumber, string simName)
        {
            Console.WriteLine("....connecting......");
            if (MakeCall.GetStatus())
            {
                Console.Write("connection established ....ringing ....");
                if (MakeCall.IsTakenCall())
                {
                    Hardware hd = new Hardware();
                    hd.VoiceSender("Helo John");
                    Console.WriteLine(hd.VoiceReceiver());
                }
                else
                {
                    Console.WriteLine("The person you are calling is busy now");
                }
            }
        }
    }
}
