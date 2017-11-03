namespace EnumerableDemo
{

    /// <summary>
    /// DTO - info o pripojenej firme
    /// </summary>
    public class FirmInfo
    {

        /// <summary>
        /// Cesta ku súboru firmy
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Príznak že sa jedná o ukážkovú "demo" firmu
        /// </summary>
        public bool IsSampleFirm { get; set; }


        public override string ToString() =>
            $">> FirmInfo: {Path}, {IsSampleFirm}";

    }
}
