using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Src.Entities
{
    public class Calculator
    {

        private List<string> _logs;
        private string _data;

        public Calculator(string data)
        {
            this._data = data;
           _logs = new List<string>();

        }

        public int Sum(int value1, int value2)
        {
            int totalValue = (value1 + value2);
            _logs.Insert(0, "Sum: " + totalValue + "Data: " + _data);
            return totalValue;
        }

        public int Subtract(int value1, int value2)
        {
            int totalValue = (value1 - value2);
            _logs.Insert(0, "Subtract: " + totalValue + "Data: " + _data);
            return totalValue;
        }

        public int Multiply(int value1, int value2)
        {
            int totalValue = (value1 * value2);
            _logs.Insert(0, "Multiply: " + totalValue + "Data: " + _data);
            return totalValue;
        }

        public int ToDivide(int value1, int value2)
        {

            int totalValue = (value1 / value2);
            _logs.Insert(0, "To Divide: " + totalValue + "Data: " + _data);
            return totalValue;
        }

        public List<string> logCaculator()
        {
            _logs.RemoveRange(3, _logs.Count - 3);
            return _logs;
        }



    }
}
