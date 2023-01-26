using Bogus;

namespace TDDTestProject.Helper
{
    public static class TestFaker
    {
        public static Faker FakeGenerator { get; set; } =  new Faker();
        public static string Name()
        {
            return FakeGenerator.Name.FirstName();
        }
        public static string Family()
        {
            return FakeGenerator.Name.LastName();
        }
        public static int Age()
        {
            return FakeGenerator.Random.Int(18,80);
        }
        public static string Mobile()
        {
            return FakeGenerator.Phone.ToString();
        }
        public static string Email()
        {
            return FakeGenerator.Internet.Email();
        }
    }
}
