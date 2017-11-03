using static System.Console;
using System.Linq;


namespace EnumerableDemo
{
    public class Program
    {

        #region DI Container

        public static SimpleInjector.Container Container { get; private set; }

        private static void InitContainer()
        {
            Container = new SimpleInjector.Container();

            Container.Register<IFirmInfoService, FirmInfoService>();
            Container.Register<IAttachedFirms, AttachedFirms>();
        }

        #endregion


        static void Main(string[] args)
        {
            // inicializacia kontajnera
            InitContainer();

            HasMoreThanXNonSampleFirms();
        }


        static void HasMoreThanXNonSampleFirms()
        {
            var svc = Container.GetInstance<IFirmInfoService>();

            var result = svc.GetFirmInfos()
                .Where(x => !x.IsSampleFirm)
                .HasMoreThan(2);

            WriteLine($"\n>> Has more than 2 nonSample firms = {result}");
        }

    }
}
