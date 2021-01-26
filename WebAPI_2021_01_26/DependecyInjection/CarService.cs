using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection
{
    #region BadCode

    public class BadCar
    {
        public string Hersteller { get; set; }
        public string AutoTyp { get; set; }
        public DateTime ConstructYear { get; set; }
    }

    public class BadCarService
    {
        public void RepairCar(BadCar car) // Das ist hart verdrahtet
        {
            //tuh irgend was.....
        }
    }
    #endregion


    #region CarService mit Dependecy Injection

    public interface ICar
    {
        string Hersteller { get; set; }
        string AutoTyp { get; set; }
        DateTime ConstructYear { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }



    public class Car : ICar
    {
        public string Hersteller { get; set; }
        public string AutoTyp 
        {
            get;
            set; 
        }
        public DateTime ConstructYear { get; set; }
    }

    public class MockCar : ICar
    {
        public string Hersteller { get; set; } = "BMW";
        public string AutoTyp { get; set; } = "Z8";
        public DateTime ConstructYear { get; set; } = DateTime.Now;
    }

    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            

        }
    }

    #endregion

}
