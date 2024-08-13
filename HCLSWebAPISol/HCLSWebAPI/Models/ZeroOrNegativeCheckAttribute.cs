using System;

namespace HCLSWebAPI.Models
{
    internal class ZeroOrNegativeCheckAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}