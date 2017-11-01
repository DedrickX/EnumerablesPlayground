using System.Collections.Generic;


namespace EnumerableDemo
{

    public class FirmInfoProvider
    {

        private readonly IAttachedFirms _attachedFirms;

        public FirmInfoProvider(IAttachedFirms attachedFirms)
        {
            _attachedFirms = attachedFirms;
        }


        /// <summary>
        /// Vráti zoznam podrobných informácií o pripojených firmách.
        /// Pre vytiahnutie týchto info je potrebné firmu otvoriť, potom vyvolať Dispose.
        /// </summary>
        public IEnumerable<FirmInfo> GetFirmInfos()
        {
            // foreach (var path in _paths)
            // {
            //     using (var firm = new FirmDb())
            //     {
            //         try
            //         {
            //             // pokus o otvorenie firmy
            //             firm.Open(path);
            //         }
            //         catch
            //         {
            //             // nepodarilo sa ju otvoriť, idem na ďalšiu pripojenú firmu
            //             continue;
            //         }
            //         // vrátim úspešne načítanú pripojenú firmu
            //         yield return firm.GetFirmInfo();
            //     }
            // };
            // už sme prešli všetky pripojené firmy, končíme enumerovanie
            yield break;
        }

    }
}
