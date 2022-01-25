using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal  class MakeCall
    {
        private static bool _IsCallTaken=true;
        private static bool _status = false;
        private static bool IsConnectedToBS()
        {
            return true;
        }
        private static bool IsConnectedToMSC()
        {
            if (IsConnectedToBS())
            {
                return true; 
            }
            return false;
        }
        private static bool IsConnectionEstablished()
        {
            if (IsConnectedToMSC())
            {
                return true;
            }
            return false;
        }
        public static bool GetStatus()
        {
            if (IsConnectionEstablished())
            {
                _status = true;
            }
            else
            {
                _status = false;
            }
            return _status;
        }
        public static bool IsTakenCall()
        {
            if (_IsCallTaken)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
