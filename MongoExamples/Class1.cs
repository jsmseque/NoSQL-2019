using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoExamples
{
    public class Class1
    {
        private int miAtributo;

        public int MyProperty
        {
            get { return miAtributo; }
            set { miAtributo = HacerElCalculo(value); }
        }

        private int HacerElCalculo(int value)
        {
            throw new NotImplementedException();
        }
    }
}
