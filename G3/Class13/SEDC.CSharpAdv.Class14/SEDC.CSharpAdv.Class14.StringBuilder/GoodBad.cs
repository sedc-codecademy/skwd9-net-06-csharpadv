using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class14.SB
{
    public class GoodBad
    {
        private string _path;
        static string path_;

        private readonly string _filePath;

        public GoodBad()
        {
            this._filePath = "../";
            _path = "";
        }

        private void DoSomething() { }

        public bool BadExample() { string a = "b"; if (string.IsNullOrWhiteSpace(a)) { return true; } else { return false; } }
        public bool GoodExample()
        {
            string a = "b";
            if (string.IsNullOrWhiteSpace(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
