using System;
using System.Windows;

public class LoaderManager
{
    private static readonly object Locker = new object();
    private static LoaderManager _instance;


    public static LoaderManager Instance
    {
        get
        {
            if (_instance != null)
                return _instance;
            lock (Locker)
            {
                return _instance ??= new LoaderManager();
            }
        }
    }

    private ILoaderOwner _loaderOwner;

    private LoaderManager()
    {
    }

    public void Initialize(ILoaderOwner loaderOwner)
    {
        _loaderOwner = loaderOwner;
    }

    public void ShowLoader()
    {
        _loaderOwner.IsControlEnabled = false;
        _loaderOwner.LoaderVisibility = Visibility.Visible;
    }

    public void HideLoader()
    {
        _loaderOwner.IsControlEnabled = true;
        _loaderOwner.LoaderVisibility = Visibility.Collapsed;
    }
}