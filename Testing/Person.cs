using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class Person
    {
		private string _name;

		public string name
		{
			get { return _name; }
			set
			{
				if (value == null)
				{
					_name = "null";
				}
				else
				{
					_name = value;
				}
			}
		}

		private int _height;

		public int height
		{
			get { return _height; }
			set
			{
				if (height < 0)
				{
					_height = 0;
				}
				else
				{
					_height = value;
				}
			}
		}

		private int _weight;

		public int weight
		{
			get { return _weight; }
			set 
			{
				if (weight < 0)
				{
					_weight = 0;
				}
				else
				{
					_weight = value;
				}
			}
		}
		public int BMI { get; set; }

		public Person(string name, int height, int weight)
		{
			this.name = name;
			this.height = height;
			this.weight = weight;
		}

		public double GetBodyMassIndex(Person person)
		{
			return person.weight / Math.Pow(person.height/ 100.0, 2);
		}

		public string bmiClassification { get; set; }
		void GetClassification(int bmi)
		{
			if (bmi < 18.5)
			{
				bmiClassification = "Underweight";
			}
			else if (bmi >= 18.5 && bmi < 25)
			{
				bmiClassification = "Normal Weight";
			}
			else if (bmi >= 25 && bmi < 30)
			{
				bmiClassification = "Overweight";
			}
			else if (bmi >= 30 && bmi < 35)
			{
				bmiClassification = "Class I Obesity";
			}
			else if (bmi >= 35 && bmi < 40)
			{
				bmiClassification = "Class II Obesity";
			}
			else if (bmi >= 40)
			{
				bmiClassification = "Class III Obesity";
			}
			else
			{
				bmiClassification = "Not valid";
			}
		}


	}
}
