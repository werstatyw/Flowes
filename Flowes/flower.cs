using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowes
{
    class flower
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private sunlight_tol tol;
        public sunlight_tol Tol
        {
            get { return tol; }
            set { tol = value; }
        }

        private int waterNeed;
        public int WaterNeed
        {
            get { return waterNeed; }
            set { waterNeed = value; }
        }

        private int monthLastWatering;

        public int MonthLastWatering
        {
            get { return monthLastWatering; }
            set { monthLastWatering = value; }
        }

        private int dayLastWatering;
        public int DayLastWatering
        {
            get { return dayLastWatering; }
            set { dayLastWatering = value; }
        }

        private bool stinging;

        public bool Stinging
        {
            get { return stinging; }
            set { stinging = value; }
        }
        //////////////////////////


        public flower(string type, int tolerance, int waterNeed, int monthLastWatering, int dayLastWatering, string sting)
        {
            this.type = type;
            switch (tolerance)
            {
                case 0:
                    tol = sunlight_tol.ligh_loving;
                    break;
                case 1:
                    tol = sunlight_tol.neutral;
                    break;
                case 2:
                    tol = sunlight_tol.shade_loving;
                    break;
                default:
                    break;
            }
            this.waterNeed = waterNeed;
            this.monthLastWatering = monthLastWatering;
            this.dayLastWatering = dayLastWatering;
            if (sting == "0")
            {
                stinging = false;
            }
            else
            {
                stinging = true;
            }

        }
        public string print()
        {
            return "Name of the flower : " + type + "\nSunlight tolerance : " + tol + "\nWater need : " + waterNeed + "\nMonth of last watering : " + monthLastWatering + "\nDay of last waterig : " + dayLastWatering + "\nDoes it sting ? " + stinging ;
        }// end print
    }
}
