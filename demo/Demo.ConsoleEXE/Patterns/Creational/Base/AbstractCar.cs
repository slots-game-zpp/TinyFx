using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Demos.Patterns.Creational.Base
{
    internal abstract class AbstractCar
    {
        protected abstract void Do();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }
    internal class CarA : AbstractCar
    {

        protected override void Do()
        {

            throw new System.NotImplementedException();
        }
    }

    internal class CarB : AbstractCar
    {
        protected override void Do()
        {
            throw new System.NotImplementedException();
        }
    }
}
