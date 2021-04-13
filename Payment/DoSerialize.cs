using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Payment
{
    static class DoSerialize
    {
        public static void Write(PaymentAccount acount, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PaymentAccount));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, acount);
            }
        }
        public static PaymentAccount Read(string path)
        {
            PaymentAccount acount = null;
            XmlSerializer serializer = new XmlSerializer(typeof(PaymentAccount));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                acount = (serializer.Deserialize(fs) as PaymentAccount);
            }
            if (PaymentAccount.IsCalculate)
                acount.Calculate();
            
            return acount;
        }
    }
}
