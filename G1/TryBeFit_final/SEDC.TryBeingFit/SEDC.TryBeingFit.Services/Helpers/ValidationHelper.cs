using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Helpers
{
	public static class ValidationHelper
	{
		public static int ValidateNumber(string number, int range)
		{
			int num = 0;
			bool isNumber = int.TryParse(number, out num);
			if (!isNumber) return -1;
			if (num <= 0 || num > range) return -1;
			return num;
		}
		public static string ValidateString(string str)
		{
			if (str.Length < 2) return null;
			int number;
			if (int.TryParse(str, out number)) return null;
			return str;
		}
		public static string ValidateUsername(string username)
		{
			if (username.Length < 6) return null;
			return username;

		}
		public static string ValidatePassword(string password)
		{
			if (password.Length < 6) return null;
			int num;
			bool isNum = false;
			foreach (char item in password)
			{
				isNum = int.TryParse(item.ToString(), out num);
			}
			if (!isNum) return null;
			return password;
		}
	}
}
