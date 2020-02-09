using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace NumberBox
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class NumberBox : TextBox
	{
		public NumberType NumberType { get; set; }

        public bool HasCustomDomain { get; set; }

        public double Min { get; set; }

        public double Max { get; set; }

        public NumberBox()
		{
			KeyPress += KeyPressed;
			LostFocus += OnLostFocus;
		}

		private bool IsOverFlow(string s)
		{
			switch (NumberType)
			{
				case NumberType.SBYTE:
					if (!sbyte.TryParse(s, out _))
						return true;
					break;

				case NumberType.BYTE:
					if (!byte.TryParse(s, out _))
						return true;
					break;

				case NumberType.SHORT:
					if (!short.TryParse(s, out _))
						return true;
					break;

				case NumberType.USHORT:
					if (!ushort.TryParse(s, out _))
						return true;
					break;

				case NumberType.INT:
					if (!int.TryParse(s, out _))
						return true;
					break;

				case NumberType.UINT:
					if (!uint.TryParse(s, out _))
						return true;
					break;

				case NumberType.LONG:
					if (!long.TryParse(s, out _))
						return true;
					break;

				case NumberType.ULONG:
					if (!ulong.TryParse(s, out _))
						return true;
					break;

				case NumberType.FLOAT:
					if (!float.TryParse(s, out _))
						return true;
					break;

				case NumberType.DECIMAL:
					if (!decimal.TryParse(s, out _))
						return true;
					break;

				case NumberType.DOUBLE:
					if (!double.TryParse(s, out _))
						return true;
					break;

				default:
					return true;
			}

			return false;
		}

		private void SetWithinBounds(string s)
		{
			if (s == "" || !HasCustomDomain) return;

			switch (NumberType)
			{
				case NumberType.SBYTE:
					if ((sbyte) Min > sbyte.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

                    else if ((sbyte) Max < sbyte.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.BYTE:
					if ((byte)Min > byte.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((byte)Max < byte.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.SHORT:
					if ((short)Min > short.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((short)Max < short.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.USHORT:
					if ((ushort)Min > ushort.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((ushort)Max < ushort.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.INT:
					if ((int)Min > int.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((int)Max < int.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.UINT:
					if ((uint)Min > uint.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((uint)Max < uint.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.LONG:
					if ((long)Min > long.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((long)Max < long.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.ULONG:
					if ((ulong)Min > ulong.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((ulong)Max < ulong.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.FLOAT:
					if ((float)Min > float.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((float)Max < float.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.DECIMAL:
					if ((decimal)Min > decimal.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((decimal)Max < decimal.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.DOUBLE:
					if ((double)Min > double.Parse(s))
						Text = Min.ToString(CultureInfo.InvariantCulture);

					else if ((double)Max < double.Parse(s))
						Text = Max.ToString(CultureInfo.InvariantCulture);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			if (!CanContainDecimal())
			{
				Text = Math.Round(double.Parse(Text)).ToString(CultureInfo.InvariantCulture);
			}
		}

		private void SetToMinMax(bool isNegative)
		{
			if (string.IsNullOrEmpty(Text))
				return;

			Text = isNegative ? "-" : "";

			switch (NumberType)
			{
				case NumberType.SBYTE:
					Text += sbyte.MaxValue.ToString();
					break;

				case NumberType.BYTE:
					Text += byte.MaxValue.ToString();
					break;

				case NumberType.SHORT:
					Text += short.MaxValue.ToString();
					break;

				case NumberType.USHORT:
					Text += ushort.MaxValue.ToString();
					break;

				case NumberType.INT:
					Text += int.MaxValue.ToString();
					break;

				case NumberType.UINT:
					Text += uint.MaxValue.ToString();
					break;

				case NumberType.LONG:
					Text += long.MaxValue.ToString();
					break;

				case NumberType.ULONG:
					Text += ulong.MaxValue.ToString();
					break;

				case NumberType.FLOAT:
					Text += float.MaxValue.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.DECIMAL:
					Text += decimal.MaxValue.ToString(CultureInfo.InvariantCulture);
					break;

				case NumberType.DOUBLE:
					Text += double.MaxValue.ToString(CultureInfo.InvariantCulture);
					break;

				default:
					Text = "";
					break;
			}
		}

		private bool CanContainDecimal()
		{
			return NumberType == NumberType.DECIMAL || NumberType == NumberType.FLOAT || NumberType == NumberType.DOUBLE;
		}

		private bool CanBeNegative()
		{
			switch (NumberType)
			{
				case NumberType.SBYTE:
					return true;

				case NumberType.BYTE:
					return false;

				case NumberType.SHORT:
					return true;

				case NumberType.USHORT:
					return false;

				case NumberType.INT:
					return true;

				case NumberType.UINT:
					return false;

				case NumberType.LONG:
					return true;

				case NumberType.ULONG:
					return false;

				case NumberType.FLOAT:
					return true;

				case NumberType.DECIMAL:
					return true;

				case NumberType.DOUBLE:
					return true;

				default:
					return false;
			}
		}

		public void KeyPressed(object sender, KeyPressEventArgs e)
		{
			var decimalPoint = e.KeyChar.ToString()
				.Equals(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

			if (char.IsControl(e.KeyChar) || SelectionLength > 0)
				return;

			// We ignore any input that is not a digit, decimal point or negative sign
			if (!char.IsDigit(e.KeyChar) && !decimalPoint && e.KeyChar != '-')
				e.Handled = true;

			if (decimalPoint)
			{
				// We ignore decimal points if the NumberType cannot contain a decimal
				if (!CanContainDecimal())
					e.Handled = true;
				// If the input is a decimal point and it has occurred before, we ignore it
				else
				{
					if (string.IsNullOrEmpty(Text) || ((NumberBox) sender).Text.IndexOf(
						    CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, StringComparison.Ordinal) > -1)
						e.Handled = true;
				}
			}
			else
			{
				// Check if the input is out of bounds
				if (char.IsDigit(e.KeyChar) && (IsOverFlow(Text + e.KeyChar)))
				{
					SetToMinMax(Text.Length > 0 && Text[0] == '-');

					// Set cursor to end of text
					SelectionStart = Text.Length;
					SelectionLength = 0;

					e.Handled = true;
				}
				
				// Check whether input zero whether it is permitted
				else if (e.KeyChar == '0')
				{
					// We ignore multiple zeroes
					if (!string.IsNullOrEmpty(Text) && SelectionStart == 0)
						e.Handled = true;
				}

				// If the leading character is a zero, we ignore it
				if (Text.Length == 1 && Text[0] == '0' && SelectionStart != 0)
					e.Handled = true;
		
				// If the number cannot be negative or the negative sign does not exist yet or is not in the first position, we ignore it
				else if (e.KeyChar == '-' && (!CanBeNegative() || SelectionStart > 0 || !string.IsNullOrEmpty(Text) &&
				    Text.IndexOf("-", StringComparison.Ordinal) > -1))
					e.Handled = true;
			}
		}

		public void OnLostFocus(object sender, EventArgs e)
        {
            if (Text == "") Text = "0";
			SetWithinBounds(Text);
		}

		public object GetValue(string s)
		{
			if (string.IsNullOrEmpty(s))
				s = "0";

			switch (NumberType)
			{
				case NumberType.SBYTE:
					return Convert.ToSByte(s);

				case NumberType.BYTE:
					return Convert.ToByte(s);

				case NumberType.SHORT:
					return Convert.ToInt16(s);

				case NumberType.USHORT:
					return Convert.ToUInt16(s);

				case NumberType.INT:
					return Convert.ToInt32(s);

				case NumberType.UINT:
					return Convert.ToUInt32(s);

				case NumberType.LONG:
					return Convert.ToInt64(s);

				case NumberType.ULONG:
					return Convert.ToUInt64(s);

				case NumberType.FLOAT:
					return float.Parse(s, CultureInfo.InvariantCulture.NumberFormat);

				case NumberType.DECIMAL:
					return Convert.ToDecimal(s);

				case NumberType.DOUBLE:
					return Convert.ToDouble(s);

				default:
					return null;
			}
		}

		public object GetValue()
		{
			return GetValue(Text);
		}
	}
}
