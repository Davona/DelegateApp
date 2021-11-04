using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class CoffeeMaker
    {

        public delegate void CoffeeMakerStateHandler(string message);
        CoffeeMakerStateHandler _del;

        public void RegisterHandler(CoffeeMakerStateHandler del)
        {
            _del = del;
        }
        int _count;

        public CoffeeMaker(int count)
        {
            _count = count;
        }

        public int CurrentCount
        {
            get { return _count; }
        }

        public void Add(int count)
        {
            _count += count;
        }

        public void Prepare(int count)
        {
            if (count <= _count)
            {
                _count -= count;

                if (_del != null)
                    _del("In Preparation..." + " " +
                        "Take your coffee");
            }
            else
            {
                if (_del != null)
                    _del("Coffee beans empty");
            }
        }
    }
}

