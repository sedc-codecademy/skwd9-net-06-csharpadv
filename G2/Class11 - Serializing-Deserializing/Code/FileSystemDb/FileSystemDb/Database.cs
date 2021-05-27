using FileSystemDb.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystemDb
{
    public class Database<T> where T : BaseEntity
    {
        private string _dbFolderPath;
        private string _dbFilePath;
        private int _id;

        public Database()
        {
            _id = 0;
            _dbFolderPath = @"..\..\..\Db";
            _dbFilePath = _dbFolderPath + $"\\{typeof(T).Name}s.json";
            if (!Directory.Exists(_dbFolderPath))
            {
                Directory.CreateDirectory(_dbFolderPath);
            }
            if (!File.Exists(_dbFilePath))
            {
                File.Create(_dbFilePath).Close();
            }
            List<T> data = Read();
            if(data == null)
            {
                Write(new List<T>());
            }
            else if(data.Count > 0)
            {
                _id = data[data.Count - 1].Id;
            }
        }

        public List<T> GetAll()
        {
            return Read();
        }

        public T GetById(int id)
        {
            return Read().SingleOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            List<T> data = Read();
            _id++;
            entity.Id = _id;
            data.Add(entity);
            Write(data);
            return entity.Id;
        }

        private void ClearDb()
        {
            Write(new List<T>());
        }
        private List<T> Read()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(_dbFilePath))
                {
                    string content = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(content);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void Write(List<T> entities)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(_dbFilePath))
                {
                    string jsonString = JsonConvert.SerializeObject(entities);
                    streamWriter.WriteLine(jsonString);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

    }
}
