using UnityEditor;
	public class Score
	{
		private int _value = 0;

		public Score(int N)
		{
			_value = N;
		}

		public Score()
		{

		}

		public int Value
		{
			get { return _value; }
			set { _value = value; }
		}

		public static Score operator +(Score score, int plus)
		{
			Score result = score.Value + plus;

			return result.Value;

		}

		public static bool operator >(Score score1, Score score2)
		{
			return score1._value > score2._value;
		}
		public static bool operator <(Score score1, Score score2)
		{
			return score1._value < score2._value;
		}

		public static implicit operator Score(int x)
		{
			return new Score(x); // при попытке перевести (int) в Score 
		}

		public static implicit operator int(Score x)
		{
			return x._value;
		}

		public static explicit operator string(Score x)
		{
			return x._value.ToString();
		}

	}
