using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgurluPluginGL.BL.Common
{
    public class ResultModel<T>
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        public T Value { get; set; }
    }
}
