using System.Collections.ObjectModel;

namespace TodoApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // Gets a collection of < > which allow adding and removing items

    public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } =
        new ObservableCollection<ToDoItemViewModel>();
}
