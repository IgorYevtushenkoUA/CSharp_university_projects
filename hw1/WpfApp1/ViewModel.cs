using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1;

public class ViewModel : INotifyPropertyChanged
{
    private static DateTime CurrentDate;

    private readonly User user;
    private RelayCommand<object> submit;
    private Calculate calculate;

    public string Age
    {
        get { return user.Age; }
        set
        {
            user.Age = value;
            OnPropertyChanged();
        }
    }

    public DateTime Date
    {
        get { return user.Date; }
        set
        {
            user.Date = value;
            OnPropertyChanged();
        }
    }

    public string WesternZodiac
    {
        get { return user.WesternZodiac; }
        set
        {
            user.WesternZodiac = value;
            OnPropertyChanged();
        }
    }

    public string ChineseZodiac
    {
        get { return user.ChineseZodiac; }
        set
        {
            user.ChineseZodiac = value;
            OnPropertyChanged();
        }
    }

    public ViewModel()
    {
        CurrentDate = DateTime.Today;
        user = new User();
        Date = CurrentDate;
        calculate = new Calculate();
    }

    private async void SubmitUserForm(object data)
    {
        Age = "";
        WesternZodiac = "";
        ChineseZodiac = "";
        await Task.Run(Calculate);
    }

    public RelayCommand<object> Submit
    {
        get { return submit ?? (submit = new RelayCommand<object>(SubmitUserForm)); }
    }

    private void Calculate()
    {
        try
        {
            Age = calculate.CalculateAge(Date, CurrentDate);
            WesternZodiac = calculate.CalculateWesternZodiac(Date);
            ChineseZodiac = calculate.CalculateChineseZodiac(Date);
            calculate.CalculateBirthday(Date, CurrentDate);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}