using System;
using System.IO;

namespace Disposing.InputOutputHelpers
{
    public class OurWriter : IDisposable
    {
        private string _path;
        private StreamWriter _streamWriter;
        private bool _disposedValue;

        public OurWriter(string path)
        {
            _path = path;
            _streamWriter = new StreamWriter(_path, true);
            _disposedValue = false;
        }

        public void Write(string text)
        {
            if(text == "break")
            {
                throw new Exception("We cannot write this text. Something broke..");
            }
            _streamWriter.WriteLine(text);
        }

        private void _dispose()
        {
            if (!_disposedValue)
            {
                _streamWriter?.Dispose();
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            _dispose();
        }
    }
}
