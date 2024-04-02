using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Models.DTO
{
    public class ResponseDTO
    {
        public object? Result { get; set; }
        public bool? Success { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
