using System.Collections.Generic;


namespace EnumerableDemo
{

    public class FirmInfoService : IFirmInfoService
    {

        private readonly IAttachedFirms _attachedFirms;

        public FirmInfoService(IAttachedFirms attachedFirms)
        {
            _attachedFirms = attachedFirms;
        }


        /// <summary>
        /// Vráti zoznam podrobných informácií o pripojených firmách.
        /// Pre vytiahnutie týchto info je potrebné firmu otvoriť, potom vyvolať Dispose.
        /// </summary>
        public IEnumerable<FirmInfo> GetFirmInfos()
        {
            foreach (var path in _attachedFirms.GetAttachedFirmPaths())
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
