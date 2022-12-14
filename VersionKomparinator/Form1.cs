using System.Text.RegularExpressions;

namespace VersionKomparinator
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, long> numberTable = new Dictionary<string, long>{
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},
        {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},
        {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},
        {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},
        {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
        {"hundred",100},{"thousand",1000},{"lakh",100000},{"million",1000000},
        {"billion",1000000000},{"trillion",1000000000000},{"quadrillion",1000000000000000},
        {"quintillion",1000000000000000000}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Compair(string v1, string v2)
        {
            int Var1 = int.Parse(KomPairinate(v1).ToString());
            int Var2 = int.Parse(KomPairinate(v2).ToString());
            //Var1 and Var2 are just more readable
            
            if (Var1 > Var2)
            {
                labelResults.Text = "Version " + v1.ToString() + " is newer than " + v2.ToString();
            }
            if (Var2 > Var1)
            {
                labelResults.Text = "Version " + v2.ToString() + " is newer than " + v1.ToString();
            }
            if (Var1 == Var2)
            {
                labelResults.Text = "Version " + v1.ToString() + " is the same as " + v2.ToString();
            }
        }

        private object KomPairinate(string inboundVersionString)
        {
            var DotifiedVersionString = inboundVersionString.ToLower(); //force entire input string to lower case
            DotifiedVersionString = DotifiedVersionString.Replace("point", "."); //replace all string 'point' with dots
            DotifiedVersionString = DotifiedVersionString.Replace(" ", ""); //remove all spaces

            //Find DotCount - important
            int DotCount = DotifiedVersionString.Count(f =>
            {
                return f == '.';
            });

            string[] strArr = new string[DotCount + 1]; //create array of string 1 larger than DotCount

            string tempVerStng = DotifiedVersionString; //set tempVerStng to DotifiedVersionString TO BE Manipulated
            for (int i = 0; i < DotCount; i++)
            {   //Wash, Rinse, Repeat
                strArr[i] = tempVerStng.Substring(0, tempVerStng.IndexOf(".")); //copy StringArray, substrstring from the start to the dot in the array
                tempVerStng = tempVerStng.Remove(0, tempVerStng.IndexOf(".") + 1); //remove the string before the dot from the tempVerStng
            }
            strArr[DotCount] = tempVerStng; //copy the last string to the array - like dangeling chads

            //Any of the array items contain alphas, force them into numbers
            Regex r = new Regex("^[a-zA-Z ]+$");
            int forceIndex = 0;
            foreach (string item in strArr)
            {
                if (r.IsMatch(item))
                {
                    strArr[forceIndex] = ConvertToNumbers(item).ToString();
                }
                forceIndex += 1;
            }

            //Lastly, convert this into an Int
            int returnInt = 0;
            int decimalPassCount = 1; //start decimal step 1
            {
                for (int X = DotCount; X >= 0; X += -1) //stepping backward through the versionstring 'slots'
                {
                    returnInt += ((int.Parse(strArr[X])) * decimalPassCount);
                    decimalPassCount *= 10;
                }
            }
            return returnInt;
        }

        public static long ConvertToNumbers(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]);
            long acc = 0, total = 0L;
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    total += acc * n;
                    acc = 0;
                }
                else if (n >= 100)
                {
                    acc *= n;
                }
                else acc += n;
            }
            return (total + acc) * (numberString.StartsWith("minus",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compair("2 point 3.14.Five", "1.2.3.4");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compair("5.2", "19 point seven point 2.53");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Compair("3.14", "Three Point Fourteen");
        }
    }
}