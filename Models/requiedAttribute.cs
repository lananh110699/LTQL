using System;

namespace LTQL.Models
{
    internal class requiedAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}