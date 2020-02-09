using Fiesta.FileFormats.Map.AreaInfoData.AreaData;
using System.ComponentModel;

namespace Fiesta.FileFormats.Map.AreaInfoData
{
	public class AreaInfoData : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _name;
		public string Name {
			get => _name;
			set
			{
				_name = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
			}
		}

		private AreaType _nAreaType;
		public AreaType nAreaType {
			get => _nAreaType;
			set
			{
				_nAreaType = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("nAreaType"));
			}
		}

		private IAreaData _data; 
		public IAreaData Data {
			get
			{
				if (nAreaType == AreaType.Circle)
				{
					return _circle;
				}
				else
				{
					return _square;
				}
			}
			set
			{
				_data = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Data"));
			}
		}

		private readonly AE_Circle _circle;
		private readonly AE_Square _square;

		public AreaInfoData(string name, AreaType nAreaType, AE_Square data)
		{
			Name = name;
			this.nAreaType = nAreaType;
			_circle = new AE_Circle(0, 0, 0);
			_square = data;
		}

		public AreaInfoData(string name, AreaType nAreaType, AE_Circle data)
		{
			Name = name;
			this.nAreaType = nAreaType;
			_circle = data;
			_square = new AE_Square(0, 0, 0, 0, 0);
		}
	}
}