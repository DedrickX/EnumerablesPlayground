
using System;
using static System.Console;


namespace EnumerableDemo
{

    /// <summary>
    /// Firma - monolytický mega objekt vyžadujúci si imperatívny prístup a ktorý treba po ukončení práce disposovať
    /// </summary>
    public class FirmDb : IDisposable
    {

        /// <summary>
        /// Cesta ku firme
        /// </summary>
        public string Path { get; private set; }


        /// <summary>
        /// Príznak že sa jedná o ukážkovú firmu
        /// </summary>
        public bool IsSampleFirm
        {
            get { return Path.ToLower().Contains("sample"); }
        }


        /// <summary>
        /// Aktuálna inštancia firmy otvorí databázu na danom umiestnení
        /// </summary>
        public void Open(string path)
        {
            WriteLine($"\n>> Opening {path}");

            if (path.ToLower().Contains("x"))
            {
                WriteLine($">> Error {path}");
                throw new Exception("Chyba pri otváraní databázy!");
            }

            Path = path;
        }


        /// <summary>
        /// Funkcia vráti DTO FirmInfo
        /// </summary>
        public FirmInfo GetFirmInfo() =>
            new FirmInfo {
                Path = Path,
                IsSampleFirm = IsSampleFirm
            };


        /// <summary>
        /// Dispose inštancie
        /// </summary>
        public void Dispose()
        {
            WriteLine($">> Disposing {Path}");
        }

    }
}
