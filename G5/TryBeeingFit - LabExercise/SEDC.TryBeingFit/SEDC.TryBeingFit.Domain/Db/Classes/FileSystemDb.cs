using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Db.Classes
{
    public class FileSystemDb<T> : IDb<T> where T : BaseEntity
    {
        private string _dbFolder;
        private string _dbPath;
        private string _idPath;

        public FileSystemDb()
        {
            _dbFolder = @"..\..\..\Databases";
            _dbPath = @$"{_dbFolder}\{typeof(T).Name}s.json";
            _idPath = $@"{_dbFolder}\id.txt";

            if (!Directory.Exists(_dbFolder)) 
            {
                Directory.CreateDirectory(_dbFolder);
            }

            if (!File.Exists(_dbPath))
            {
                File.Create(_dbPath).Close();
            }

            if (!File.Exists(_idPath))
            {
                File.Create(_idPath).Close();
            }

        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
