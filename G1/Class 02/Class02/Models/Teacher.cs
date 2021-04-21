namespace Models
{
    public class Teacher : User
    {
        public Teacher(string firstName, string lastName, string userName, string password) :
            base(firstName, lastName, userName, password, RoleEnum.Teacher)
        {
            
        }
    }
}
