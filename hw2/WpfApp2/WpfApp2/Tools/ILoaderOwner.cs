using System.ComponentModel;
using System.Windows;

public interface ILoaderOwner : INotifyPropertyChanged
{
    Visibility LoaderVisibility { get; set; }
    bool IsControlEnabled { get; set; }
}