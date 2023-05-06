namespace DotNetCoreJquery.Models
{
    public class CitiesInfo
    {
        private List<CountryInfo> countryInfos = new();
        public List<CountryInfo> CountryInfosList
        { 
            get
            {
                return countryInfos;
            } 
        set { countryInfos = value; }
        }

        private List<StateInfo> stateInfos = new();
        public List<StateInfo> stateInfosList
        {
            get
            {
                return stateInfos;
            }
            set { stateInfos = value; }
        }

        /*private List<CityInfo> cityInfos = new();
        public List<CityInfo> cityInfosList
        {
            get{return cityInfos;}
            set { cityInfos = value; }
        }*/
        public List<CityInfo> CityInfosList { get; set; }
    }
    
    public class CountryInfo
    {
        public int CId { get; set; }
        public string CName { get; set; }
    }
    public class StateInfo
    {
        public int SId { get; set; }
        public int CId { get; set; }
        public string SName { get; set; }
    }

    public class CityInfo
    {
        public int CityId { get; set; }
        public int SId { get; set; }
        public string CityName { get; set; }
    }
}
