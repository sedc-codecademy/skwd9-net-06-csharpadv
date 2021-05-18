using Logger.Exceptions;
namespace Logger.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 0)
                {
                    throw new InvalidPropertyException("age", Username);
                }
                _age = value;
            }
        
        }
    }
}
