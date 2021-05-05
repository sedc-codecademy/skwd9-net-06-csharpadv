using SEDC.CSharpAdv.VideoRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.Database
{
    public class UserRepository
    {
        public User GetUserByIdCard(int idCard)
        {
            return InMemoryDatabase.Users.FirstOrDefault(u => u.CardNumber == idCard);
        } 

        public bool Insert(User user)
        {
            int beforeInsert = InMemoryDatabase.Users.Count;

            user.Id = ++InMemoryDatabase.userId;
            InMemoryDatabase.Users.Add(user);

            return InMemoryDatabase.Users.Count != beforeInsert;
        }

        public List<int> GetAllCardNumbers()
        {
            return InMemoryDatabase.Users.Select(u => u.CardNumber).ToList();
        }
    }
}
