using System;
using System.Text;

namespace Fiesta
{
	public static class StringHelper
	{
		public static string GetStringFromBytes(byte[] bytes)
		{
			string text = Encoding.UTF8.GetString(bytes);

			if (text.IndexOf('\0') != -1)
			{
				text = text.Substring(0, text.IndexOf('\0'));
			}

			return text;
		}

		public static byte[] GetBytes(string text)
		{
			return Encoding.ASCII.GetBytes(text);
		}

		public static byte[] GetBytes(string text, int size)
		{
			if (size < text.Length)
			{
				throw new Exception("Size of string is bigger than the given size!");
			}

			var bytes = new byte[size];

			for (var i = 0; i < text.Length; i++)
			{
				bytes[i] = (byte)text[i];
			}

			return bytes;
		}

		public static string GetStringFromFloat(decimal f, int amountOfDigits = 6)
		{
			return f.ToString($"f{amountOfDigits}").Replace(',', '.');
		}
	}
}
