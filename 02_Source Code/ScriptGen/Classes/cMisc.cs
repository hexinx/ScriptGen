using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptGen.Classes
{
    class cMisc
    {
        public List<int> years = new List<int>();
        public List<int> yearPairs = new List<int>();
        public List<int> locations = new List<int>();
        public List<string> columnLocation = new List<string>();

        public Dictionary<string,string> shortType = new Dictionary<string, string>();
        public Dictionary<string, string> shortLocation = new Dictionary<string, string>();
        public Dictionary<string, string> actualLocation = new Dictionary<string, string>();

        public Dictionary<string, List<string>> ColumnsInType = new Dictionary<string, List<string>>();

        public cMisc()
        {
            List<string> tColumnsInType_Entry = new List<string>();

            //For actualLocation
            actualLocation.Add("On Campus", "On-campus");
            actualLocation.Add("Non Campus", "Non-campus");
            actualLocation.Add("Public Property Arrests", "Public Property");
            actualLocation.Add("Reported by Police", "Reported by Local Police");
            actualLocation.Add("Residence Hall", "Residence Hall");

            //For arrests
            tColumnsInType_Entry.Add("Drug");
            tColumnsInType_Entry.Add("Weapon");
            tColumnsInType_Entry.Add("Liquor");
            ColumnsInType.Add("Arrests", new List<string> (tColumnsInType_Entry));
            tColumnsInType_Entry.Clear();

            //For Criminal Offences
            tColumnsInType_Entry.Add("Burgla");
            tColumnsInType_Entry.Add("Murd");
            tColumnsInType_Entry.Add("Vehic");
            tColumnsInType_Entry.Add("NEG_M");
            tColumnsInType_Entry.Add("ROBBE");
            tColumnsInType_Entry.Add("Forcib");
            tColumnsInType_Entry.Add("Nonfor");
            tColumnsInType_Entry.Add("AGG_A");
            tColumnsInType_Entry.Add("Arson");
            ColumnsInType.Add("Criminal Offense", new List<string>(tColumnsInType_Entry));
            tColumnsInType_Entry.Clear();

            //For Discipline
            tColumnsInType_Entry.Add("Drug");
            tColumnsInType_Entry.Add("Weapon");
            tColumnsInType_Entry.Add("Liquor");
            ColumnsInType.Add("Discipline", new List<string>(tColumnsInType_Entry));
            tColumnsInType_Entry.Clear();

            //For Hate Crime
            tColumnsInType_Entry.Add("Religion");
            tColumnsInType_Entry.Add("Gender");
            tColumnsInType_Entry.Add("Race");
            tColumnsInType_Entry.Add("Disability");
            ColumnsInType.Add("Hate Crime", new List<string>(tColumnsInType_Entry));
            tColumnsInType_Entry.Clear();

            //For Vawa
            tColumnsInType_Entry.Add("Stalk");
            tColumnsInType_Entry.Add("Dating");
            tColumnsInType_Entry.Add("Domest");
            ColumnsInType.Add("Vawa", new List<string>(tColumnsInType_Entry));
            tColumnsInType_Entry.Clear();


            years.Add(2011);
            years.Add(2012);
            years.Add(2013);
            years.Add(2014);
            years.Add(2015);

            yearPairs.Add(121314);
            yearPairs.Add(131415);

            shortType.Add("Arrests","ar");
            shortType.Add("Criminal Offense", "co");
            shortType.Add("Discipline", "di");
            shortType.Add("Hate Crime", "hc");
            shortType.Add("Vawa", "va");

            shortLocation.Add("On Campus", "oc");
            shortLocation.Add("Non Campus", "nc");
            shortLocation.Add("Public Property Arrests", "pp");
            shortLocation.Add("Residence Hall", "rh");
            shortLocation.Add("Reported by Police", "rep");

            columnLocation.Add("On-campus");
            columnLocation.Add("Non-campus");
            columnLocation.Add("Residence Hall");
            columnLocation.Add("Reported by Local Police");
            columnLocation.Add("Public Property");


        }
    }
}
