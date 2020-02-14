namespace TaxPayer.ITaPS.Mono.IDP
{
    public class IDPSettingsConfiguration
    {
        public static IDPSettingsConfiguration Current;

        public IDPSettingsConfiguration()
        {
            Current = this;
        }
        public string ApiName { get; set; }
        public string ApiId { get; set; }
        public string OMSAPI1 { get; set; }
        public string OMSAPI2 { get; set; }
        public string OMSAPI3 { get; set; }
    }
}

