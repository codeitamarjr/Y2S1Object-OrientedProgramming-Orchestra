using System;
using System.Text.RegularExpressions;
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

        static void ValidateCarRegistration()
        {
            // Valid Example : "18D 12345" "18CN 456"
            // { 1,2} = minimum of 1 and maximum of 2 elements
            // ^ = start at beginning
            // $ = right up to end
            // (...)+ any number of elements inside
            //[A..Z] = capital letters only
            string pattern = @"^(\d){1,2}([A-Z]) (\d+)$";

            Match result = Regex.Match("1D 12345 blah", pattern);
            if (result.Success)
            {
                Console.Write("CarRegistration is valid");
            }
            else
            {

                Console.Write("CarRegistration is Invalid");

            }

        }
    }
}
