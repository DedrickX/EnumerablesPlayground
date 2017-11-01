using System.Collections.Generic;


namespace EnumerableDemo
{
    public class FirmInfoRepository
    {

        /// <summary>
        /// Akože zoznam pripojených firiem - ciest ku nim
        /// </summary>
        private List<string> _paths = new List<string> {
            @"Firma1.kdb",
            @"Firma2-demo.kdb",
            @"Firma3.kdb",
            @"Firma4-x.kdb",
            @"Firma5-x.kdb",
            @"Firma6-x.kdb",
            @"Firma7.kdb",
            @"Firma8.kdb" };


        /// <summary>
        /// Vráti zoznam podrobných informácií o pripojených firmách.
        /// Pre vytiahnutie týchto info je potrebné firmu otvoriť, potom vyvolať Dispose.
        /// </summary>
        public IEnumerable<FirmInfo> GetFirmInfos()
        {
            foreach (var path in _paths)
            {
                using (var firm = new FirmDb())
                {
                    try
                    {
                        // pokus o otvorenie firmy
                        firm.Open(path);
                    }
                    catch
                    {
                        // nepodarilo sa ju otvoriť, idem na ďalšiu pripojenú firmu
                        continue;
                    }
                    // vrátim úspešne načítanú pripojenú firmu
                    yield return firm.GetFirmInfo();
                }
            };
            // už sme prešli všetky pripojené firmy, končíme enumerovanie
            yield break;
        }

    }
}
