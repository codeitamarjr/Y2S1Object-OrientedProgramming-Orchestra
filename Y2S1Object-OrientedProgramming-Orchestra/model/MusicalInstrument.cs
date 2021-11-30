using System;
namespace Y2S1ObjectOrientedProgrammingOrchestra.model
{
    public class MusicalInstrument
    {
        public string name { get; set; }
        public string type { get; set; }

        public MusicalInstrument(string _name, string _type)
        {
            this.name = _name;
            this.type = _type;
        }

        public MusicalInstrument(string _type)
        {
            type = _type;
        }

        public class WoodWindInstrument : MusicalInstrument
        {
            private static string _type = "WoodWind";
            public WoodWindInstrument(string _name) : base(_type)
            {
                name = _name;
            }
        }
        

    }
}
