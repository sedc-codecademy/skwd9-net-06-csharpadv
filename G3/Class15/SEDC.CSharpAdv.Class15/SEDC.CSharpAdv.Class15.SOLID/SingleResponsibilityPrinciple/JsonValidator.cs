using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class15.SOLID.SingleResponsibilityPrinciple
{
    public class JsonValidator
    {
        public bool ValidateJson(string jsonString)
        {
            return true;
        }
    }

    public class JsonUpdate
    {
        public void UpdateJson(string json)
        {
            // update json
        }
    }

    public class JsonInsert
    {
        public void Insert(string json)
        {
            // insert json
        }
    }
}
