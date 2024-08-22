using Assignment3EntityFrameworkCore.Contexts;

namespace Assignment3EntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
        }
    }
}
