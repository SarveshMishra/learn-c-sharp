namespace LearnClass
{
    public class Test
    {
        private string? greeting { get; set; }
        private string? name { get; set; }
        public Test(string name, string greeting)
        {
            this.name = name;
            this.greeting = greeting;
        }
        public override string ToString()
        {
            return greeting + " " + name;
        }
    }
}