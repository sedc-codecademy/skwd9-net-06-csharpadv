using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.ClassDispose.Disposing
{
    public class OurWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool disposedValue = false;

        public OurWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(_path, true);
        }


        public void Write(string text)
        {
            if (text.Contains("break"))
                throw new Exception("Somthing broke in our custom writer!");
            _sw.WriteLine(text);
        }


        // We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods wil not get called
        private void _dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
                _path = string.Empty;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }


    public class OurReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;

        private bool disposedValue = false;


        public OurReader(string filePath)
        {
            _path = filePath;
            _sr = new StreamReader(_path);
        }

        public string ReadAllFile()
        {
            return _sr.ReadToEnd();
        }

        // We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods wil not get called
        private void _dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }
                _path = string.Empty;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }
}
