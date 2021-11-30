using System;
using System.Collections.Generic;
namespace Y2S1ObjectOrientedProgrammingOrchestra.model
{
    public class Orchestra
    {
        public static List<MusicalInstrument> ListOfInstruments = new List<MusicalInstrument>()
        {
            new MusicalInstrument("Piano","String"),
            new MusicalInstrument("Violin","String"),
            new MusicalInstrument("French Horn","Brass"),

            new MusicalInstrument("Share Drum","Percussion")
        };
    }
}
