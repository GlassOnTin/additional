using Additional.Commands;
using Additional.Engine;
using System.ComponentModel;

namespace Additional
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _input1 = string.Empty;
        private string _input2 = string.Empty;
        private string _result = string.Empty;
        private readonly Calculator _calculator = new Calculator();

        // Properties for user inputs and calculation result
        public string Input1
        {
            get => _input1;
            set
            {
                _input1 = value;
                OnPropertyChanged(nameof(Input1));
                OnPropertyChanged(nameof(CanCalculate));
                ClearResult(); // Clear the result when input1 changes
            }
        }

        public string Input2
        {
            get => _input2;
            set
            {
                _input2 = value;
                OnPropertyChanged(nameof(Input2));
                OnPropertyChanged(nameof(CanCalculate));
                ClearResult(); // Clear the result when input1 changes
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        // Clears the result
        private void ClearResult()
        {
            Result = string.Empty;
        }

        // Determines if the calculate command can execute
        public bool CanCalculate => !string.IsNullOrWhiteSpace(Input1) && !string.IsNullOrWhiteSpace(Input2) && double.TryParse(Input1, out _) && double.TryParse(Input2, out _);

        // Command to perform the calculation
        public RelayCommand CalculateCommand { get; }

        public MainViewModel()
        {
            CalculateCommand = new RelayCommand(PerformCalculation);
        }

        // Performs the calculation
        private void PerformCalculation()
        {
            if (double.TryParse(Input1, out double a) && double.TryParse(Input2, out double b))
            {
                Result = _calculator.Add(a, b).ToString();
            }
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}