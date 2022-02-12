using System;
using System.Collections.Generic;
using System.Text;

namespace MyStringBuilder
{
    public class MyStringBuilder
    {
        private char[] _chars = null;

        private int _counter = 0;

        public int Length
        {
            get => _counter;
        }

        public MyStringBuilder() { }

        public MyStringBuilder(string str)
        {
            AddToArray(str);
        }

        public void Append(string value)
        {
            AddToArray(value);
        }

        private void AddToArray(string str)
        {
            if (_chars == null)
            {
                _chars = new char[str.Length];

                for (int i = _counter; i < str.Length; i++)
                {
                    _chars[i] = str[i];
                }
            }
            else
            {
                int max = _chars.Length + str.Length;
                _counter = _chars.Length;

                char[] temp = new char[max];

                for (int i = 0; i < _counter; i++)
                {
                    temp[i] = _chars[i];
                }

                for (int i = _counter, j = 0; i < max; i++, j++)
                {
                    temp[i] = str[j];
                }

                _chars = temp;
            }
        }

        public void Remove(int startIndex, int length)
        {
            if (_chars == null)
                throw new NullReferenceException("String is null or empty.");
            if (_chars.Length < startIndex || _chars.Length < (startIndex + length))
                throw new IndexOutOfRangeException("The length of the string is less than the specified index.");

            char[] temp = new char[_chars.Length - length];
            int counter = 0;

            for (int i = 0; i < _chars.Length; i++)
            {
                if (i >= startIndex && i < (startIndex + length)) continue;
                temp[counter] = _chars[i];
                counter++;
            }

            _chars = temp;
        }

        public void Replace(char oldChar, char newChar)
        {
            for (int i = 0; i < _chars.Length; i++)
            {
                var key = _chars[i];

                if (key == oldChar)
                {
                    Swap(ref _chars[i], ref newChar);
                }
            }
        }

        private protected void Swap<T>(ref T oldElement, ref T newElement)
        {
            oldElement = newElement;
        }

        public override string ToString()
        {
            return new string(_chars);
        }
    }
}
