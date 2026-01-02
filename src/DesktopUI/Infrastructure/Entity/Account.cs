using System.ComponentModel;

namespace DesktopUI.Infrastructure.Entity;

public class Account : INotifyPropertyChanged
{
     bool _isauto;
     string _username;
     string _password;
     string _server;
     string _status;

    public bool IsAuto
    {
        get => _isauto;
        set { _isauto = value; OnPropertyChanged(nameof(IsAuto)); }
    }

    public string Username
    {
        get => _username;
        set { _username = value; OnPropertyChanged(nameof(Username)); }
    }

    public string Password
    {
        get => _password;
        set { _password = value; OnPropertyChanged(nameof(Password)); }
    }

    public string Server
    {
        get => _server;
        set { _server = value; OnPropertyChanged(nameof(Server)); }
    }

    public string Status
    {
        get => _status;
        set { _status = value; OnPropertyChanged(nameof(Status)); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
