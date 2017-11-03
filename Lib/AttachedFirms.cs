using System.Collections.Generic;


namespace EnumerableDemo
{

    public class AttachedFirms : IAttachedFirms
    {

        /// <summary>
        /// Akože zoznam pripojených firiem - ciest ku nim
        /// </summary>
        private List<string> _paths = new List<string> {
            "Firma1.kdb",
            "Firma2-sample-2017.kdb",
            "Firma3.kdb",
            "Firma4-x.kdb",
            "Firma5-x.kdb",
            "Firma6-x.kdb",
            "Firma7.kdb",
            "Firma8.kdb" };

        /// <summary>
        /// Vráti cesty ku pripojeným firmám
        /// </summary>
        public IEnumerable<string> GetAttachedFirmPaths() =>
            _paths;

    }
}
