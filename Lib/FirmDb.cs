
using System;
using static System.Console;


namespace EnumerableDemo
{

    /// <summary>
    /// Firma - veľký objekt ktorý treba disposovať
    /// </summary>
    public class FirmDb : IDisposable
    {

        public string Path { get; set; }


        public bool IsDemoFirm
        {
            get { return Path.ToLower().Contains("demo"); }
        }


        public FirmDb(string path)
        {
            Open(path);
        }


        private void Open(string path)
        {
            WriteLine($"\n>> Opening {path}");

            if (path.ToLower().Contains("x"))
            {
                WriteLine($">> Error {path}");
                throw new Exception("Chyba pri otváraní databázy!");
            }

            Path = path;
        }

        public void Dispose()
        {
            WriteLine($">> Disposing {Path}");
        }

    }
}
