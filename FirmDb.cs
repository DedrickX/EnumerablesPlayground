
using System;
using static System.Console;


namespace EnumerableDemo
{

    /// <summary>
    /// Firma - veľký objekt ktorý treba disposovať
    /// </summary>
    public class FirmDb : IDisposable
    {

        private string _path = "<empty>";


        public void Open(string path)
        {
            WriteLine($"\n>> Opening {path}");

            if (path.ToLower().Contains("x"))
            {
                WriteLine($">> Error {path}");
                throw new Exception("Chyba pri otváraní databázy!");
            }

            _path = path;
        }


        public FirmInfo GetFirmInfo() =>
            new FirmInfo {
                Path = _path,
                IsDemoFirm = _path.ToLower().Contains("demo")
             };


        public void Dispose()
        {
            WriteLine($">> Disposing {_path}");
        }

    }
}
