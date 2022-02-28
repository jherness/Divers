namespace Ex_Divers_OPP_17_12_21
{
    class Country
    {
        protected string countryName;

        protected Regulations regulations;

        public Country(string name, Regulations regulations)
        {
            SetCountryName(name);
            this.regulations = regulations;
        }

        public Country()
        {

        }

        public void SetCountryName(string countryName) { this.countryName = countryName; }

        public string GetCountryName() { return countryName; }

        public override string ToString()
        {
            string regulationFile = $" Diving regualtions By {countryName}:\n {regulations}";
            return regulationFile;
        }

    }
}
