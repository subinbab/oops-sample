using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class FeaturePhone
    {
        private string _modelName;
        private long _phoneNumber;
        public FeaturePhone(string simName,long phoneNumber)
        {
            this._modelName = simName; ;
            this._phoneNumber = phoneNumber;
        }
        public void MakeACall(long toPhoneNumber)
        {
            Console.WriteLine("You are calling from" + _phoneNumber + "to" + toPhoneNumber);
            ImplementationMakeCall(toPhoneNumber , _modelName);
            
        }
        protected long GetPhone()
        {
            return this._phoneNumber;
        }
        protected string GetModel()
        {
            return this._modelName;
        }
        public void Information()
        {
            GetInformation();
        }
        protected abstract void GetInformation();
        protected abstract void ImplementationMakeCall(long phoneNumber, string simName);
    }
}
