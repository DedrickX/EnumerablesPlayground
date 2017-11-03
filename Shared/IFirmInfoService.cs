using System.Collections.Generic;


namespace EnumerableDemo
{
    public interface IFirmInfoService
    {

        /// <summary>
        /// Vráti zoznam podrobných informácií o pripojených firmách.
        /// Pre vytiahnutie týchto info je potrebné firmu otvoriť, potom vyvolať Dispose.
        /// </summary>
        IEnumerable<FirmInfo> GetFirmInfos();

    }
}
