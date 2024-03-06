using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiExample.ViewModels;

public class DragAndDropViewModel(int counter) : INotifyPropertyChanged
{
    private int _counter = counter;

    public event PropertyChangedEventHandler? PropertyChanged;

    public int Counter
    {
        get => _counter;
        set
        {
            if (_counter != value)
            {
                _counter = value;
                OnPropertyChanged();
            }
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
