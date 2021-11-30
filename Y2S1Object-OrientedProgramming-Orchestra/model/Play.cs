using System;
namespace Y2S1ObjectOrientedProgrammingOrchestra.model
{
    public class Play
    {

        public static void play()
        {
            foreach (MusicalInstrument instrument in Orchestra.ListOfInstruments)
            {
                Console.WriteLine($"{instrument.name} is playing from {instrument.type}");
            }
        }
    }
}
