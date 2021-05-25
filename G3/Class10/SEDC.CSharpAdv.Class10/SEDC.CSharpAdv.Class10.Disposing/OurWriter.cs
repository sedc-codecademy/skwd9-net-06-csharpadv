using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.CSharpAdv.Class10.Disposing
{
    public class OurWriter : IDisposable
    {
        private string _path;

        private StreamWriter _sw;

        private bool disposedValue = false;

        public OurWriter(string path)
        {
            _path = path;
            _sw = new StreamWriter(path, true);
        }

        public void Write(string text)
        {
            if(text == "break")
            {
                throw new Exception("Something broke...");
            }
            _sw.WriteLine(text);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    _sw.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _path = string.Empty;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
