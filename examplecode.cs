public class Delivery
    {
        public string Destination;
        public int MoneyMade;

        public string WhoIsThePilot()
        {
            string pilot = "";

            if (this.Destination == "Earth")
            {
                pilot = "Fry";
            }
            else if (this.Destination == "Mars")
            {
                pilot = "Amy";
            }
            else if (this.Destination == "Uranus")
            {
                pilot = "Bender";
            }
            else
            {
                pilot = "Leela";
            }

            return pilot;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //LOAD THE FILE
            var fileContents = File.ReadAllLines(@"c:\projects\planet_express_logs.csv");
            var numOfLines = fileContents.Count();

            //CREATE AN ARRAY OF DELIVERIES TO PUSH THAT STUFF INTO
            Delivery[] deliveries = new Delivery[numOfLines - 1];


            //loop through each line in the file
            //creating a delivery as I do.
            for (int i = 0; i < numOfLines - 1; i++)
            {
                var line = fileContents[i + 1];
                var columns = line.Split(new[] { ',' });

                deliveries[i] = new Delivery();

                deliveries[i].Destination = columns[0];
                deliveries[i].MoneyMade = int.Parse(columns[3]);
            }


            foreach (var d in deliveries)
            {
                Console.WriteLine($"Dest: {d.Destination}. Amount = {d.MoneyMade}");
            }


            //how much money total did we make?
            int totalMoneyMade = 0;

            //One possible way
            //for (int i = 0; i < deliveries.Length; i++)
            //{
            //    totalMoneyMade = totalMoneyMade + deliveries[i].MoneyMade;
            //}

            //second possible way
            foreach (Delivery d in deliveries)
            {
                totalMoneyMade += d.MoneyMade;
            }

            Console.WriteLine($"We made {totalMoneyMade} last week.");


            //who piloted each delivery?
            foreach (Delivery d in deliveries)
            {
                string pilot = d.WhoIsThePilot();
                Console.WriteLine($"This was delivered by {pilot} to Planet {d.Destination}");
            }


            //figure out each pilot's bonus
            double FrysBonus = 0;
            double AmysBonus = 0;
            double BendersBonus = 0;
            foreach (var d in deliveries)
            {
                var bonus = (d.MoneyMade * .10);

                switch (d.WhoIsThePilot())
                {
                    case "Fry":
                        FrysBonus += bonus;
                        break;
                    case "Amy":
                        AmysBonus += bonus;
                        break;
                    case "Bender":
                        BendersBonus += bonus;
                        break;
                }
              
            }

            Console.WriteLine($"Fry's Bonus is {FrysBonus}");
            Console.WriteLine($"Amy's Bonus is {AmysBonus}");
            Console.WriteLine($"Bender's Bonus is {BendersBonus}");

            Console.ReadLine();
        }

    }
