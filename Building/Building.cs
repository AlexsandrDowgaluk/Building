using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
  public  class Building
    {
        private int idBuilding;
        private double highBuilding;
        private int numberOfStoreys;
        private int numberOfApartments;
        private int numberOfPorch;
        // public static int Number = 100000;
        private static int Number = 0;
        public Building()
        {
            idBuilding = Number;
            Number++;
            highBuilding = 0.0;
            numberOfStoreys = 0;
            numberOfApartments = 0;
            numberOfPorch = 0;
        }
        
        public int IdBuilding
        {
            get
            {
                return idBuilding;
            }


        }
        public double HighBuilding
        {
            get
            {
                return highBuilding;
            }
            set
            {
                highBuilding = value;
            }

        }
        public int NumberOfStoreys
        {
            get
            {
                return numberOfStoreys;
            }
            set
            {
                numberOfStoreys = value;
            }

        }
        public int NumberOfApartments
        {
            get
            {
                return numberOfApartments;
            }
            set
            {
                numberOfApartments = value;
            }

        }
        public int NumberOfPorch
        {
            get
            {
                return numberOfPorch;
            }
            set
            {
                numberOfPorch = value;
            }

        }
        
            
      

       
public double HighStorey()
        {
            double highStorey;
            highStorey = highBuilding / numberOfStoreys;
            return highStorey;
        }
        public int NumberOfApartmentsInPorch()
        {
            int numberOfApartmentsInPorch;
            numberOfApartmentsInPorch = numberOfApartments / numberOfPorch;
            return numberOfApartmentsInPorch;
        }
        public int NumberOfApartmentsInStorey()
        {
            int NumberOfApartmentsInStorey;
            NumberOfApartmentsInStorey = NumberOfApartmentsInPorch() / numberOfStoreys;
            return NumberOfApartmentsInStorey;
        }

        //public void EnterValues()
        //{
        //    Console.WriteLine("Id your building = " + IdBuildingGeneric()
        //        + "\nThe height = " + HighBuilding
        //        + "\nNumber of storeys = " + NumberOfStoreys
        //        + "\nNumber of apartments = " + NumberOfApartments
        //        + "\nNumber of porches = " + NumberOfPorch);
        //}
    }
}
    

