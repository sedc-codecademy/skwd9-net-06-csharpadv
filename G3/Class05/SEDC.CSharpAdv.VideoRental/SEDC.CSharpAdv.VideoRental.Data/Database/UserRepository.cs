using SEDC.CSharpAdv.VideoRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.Database
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository()
            : base(InMemoryDatabase.Users, InMemoryDatabase.userId)
        {
        }

        public User GetUserByIdCard(int idCard)
        {
            return InMemoryDatabase.Users.FirstOrDefault(u => u.CardNumber == idCard);
        } 

        public List<int> GetAllCardNumbers()
        {
            return InMemoryDatabase.Users.Select(u => u.CardNumber).ToList();
        }
    }
}
