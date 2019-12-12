using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgurluPluginGL.BL.Common
{
    public class ProccessException : Exception
    {
        public ProccessException()
        {
        }

        public ProccessException(string message)
            : base(message)
        {
        }

        public ProccessException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public string GetMessage()
        {
            return !string.IsNullOrEmpty(Message) ? Message : "İşlem sırasında belirlenemeyen bir hata oluştu!"; //!!!
        }
    }
}
