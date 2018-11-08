using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc.Calc
{
    public class StateFactory
    {
        public IState GetState(States state)
        {
            switch(state)
            {
                case States.Alabama:
                    return new Alabama();
                default:
                    return null;
            }
        }
    }
}
