using static System.Console;
using System.Linq;


namespace EnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new FirmInfoRepository();

            var result = repo.GetFirmInfos()
                .Where(x => !x.IsDemoFirm)
                .HasMoreThan(2);

            WriteLine($"\n>>>> Result = {result}");
        }
    }
}
