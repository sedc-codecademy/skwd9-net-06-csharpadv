namespace SEDC.CSharpAdv.Class01.ConsoleApp3
{
    public abstract class Player
    {
        protected internal string Name { get; set; }
        public int Score { get; set; }
        public UserChoice PlayerChoice { get; set; }
    }
}
