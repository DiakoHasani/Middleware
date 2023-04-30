using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.General
{
    public class MessageModel
    {
        public int Code { get; set; } = 0;
        public bool Result { get; set; } = false;
        public string Message { get; set; }
    }
}
