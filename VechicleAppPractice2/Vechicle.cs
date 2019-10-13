using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public class Vechicle
    {
        public List<double> speed = new List <double>();
        public string name, regNo;
        

        public Vechicle( string name ,string regNo)
        {
            this.name = name;
            this.regNo = regNo;
        }
        public double Min()
        {
            
            return speed.Min();
        }
        public double Avg()
        {
            
            return speed.Average();
        }
        public double Max()
        {

            return speed.Max();
        }
        public void SetSpeed(double speed)
        {
            this.speed.Add(speed);
            
        }



    }
}
