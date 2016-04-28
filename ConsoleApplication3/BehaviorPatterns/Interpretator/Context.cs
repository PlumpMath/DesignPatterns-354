using System.Collections.Generic;

namespace DesignPatterns.BehaviorPatterns.Interpretator
{
    public class Context
    {
        private readonly Dictionary<string, int> _values;


        public Context()
        {
            _values = new Dictionary<string, int>();
        }


        public void SetValue(string str, int num)
        {
            if (_values.ContainsKey(str))
            {
                _values[str] = num;
            }
            else
            {
                _values.Add(str, num);
            }
        }

        public int GetValue(string str)
        {
            return _values[str];
        }
    }
}