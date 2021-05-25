using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.CSharpAdv.Class10.Disposing
{
    public class OurReader : IDisposable
    {
        private string _path;

        private StreamReader _sr;

        private bool _disposing = false;

        public OurReader(string path)
        {
            _path = path;
            _sr = new StreamReader(path);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        private void Dispose(bool disposing)
        {
            if(!_disposing)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }

                _path = string.Empty;
                _disposing = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
