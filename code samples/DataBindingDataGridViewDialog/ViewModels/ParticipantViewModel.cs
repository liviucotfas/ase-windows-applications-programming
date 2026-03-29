using System;
using System.ComponentModel;

namespace DataBindingDataGridViewDialog.ViewModels
{
	public class ParticipantViewModel : INotifyPropertyChanged
	{
		private string _lastName;
		private string _firstName;
		private DateTime _birthDate;

		public string LastName
		{
			get { return _lastName; }
			set
			{
				if (_lastName != value)
				{
					_lastName = value;
					OnPropertyChanged(nameof(LastName));
				}
			}
		}

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				if (_firstName != value)
				{
					_firstName = value;
					OnPropertyChanged(nameof(FirstName));
				}
			}
		}

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set
			{
				if (_birthDate != value)
				{
					_birthDate = value;
					OnPropertyChanged(nameof(BirthDate));
				}
			}
		}

		public ParticipantViewModel(string lastName, string firstName, DateTime birthDate)
		{
			_lastName = lastName;
			_firstName = firstName;
			_birthDate = birthDate;
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
