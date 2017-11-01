using System.Collections.Generic;


namespace EnumerableDemo
{

    /// <summary>
    /// Zoznam pripojených firiem
    /// </summary>
    public interface IAttachedFirms
    {

        /// <summary>
        /// Vráti zoznam ciest ku pripojeným firmám
        /// </summary>
        IEnumerable<string> GetAttachedFirmPaths();

    }
}
