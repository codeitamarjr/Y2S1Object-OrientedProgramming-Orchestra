using System;
using Y2S1ObjectOrientedProgrammingOrchestra.model;
namespace Y2S1ObjectOrientedProgrammingOrchestra
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Orchestra.ListOfInstruments.Add(new MusicalInstrument("test", "test"));
            Orchestra.ListOfInstruments.Add(new MusicalInstrument.WoodWindInstrument("Clarinet"));
            Play.play();
        }
    }
}
