using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_20170501_2
{
	class Student : ISpeak
	{
		private int _no;
		private int[] _role;
		public Student(int no, int[] role)
		{
			this._no = no;
			this._role = role;
		}

		public string Speak()
		{
			if (_no.ToString().Contains(_role[0].ToString()))
			{
				return "Fizz";
			}
			else if (_no % _role[0] == 0 && _no % _role[1] == 0 && _no % _role[2] == 0)
			{
				return "FizzBuzzWhizz";
			}
			else if (_no % _role[0] == 0 && _no % _role[1] == 0)
			{
				return "FizzBuzz";
			}
			else if (_no % _role[0] == 0 && _no % _role[2] == 0)
			{
				return "FizzWhizz";
			}
			else if (_no % _role[0] == 1 && _no % _role[2] == 0)
			{
				return "BuzzWhizz";
			}
			else if (_no % _role[0] == 0)
			{
				return "Fizz";
			}
			else if (_no % _role[1] == 0)
			{
				return "Buzz";
			}
			else if (_no % _role[2] == 0)
			{
				return "Whizz";
			}
			else
			{
				return _no.ToString();
			}
		}
	}
}
