using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TodoApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // Gets a collection of < > which allow adding and removing items

    public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } =
        new ObservableCollection<ToDoItemViewModel>();

    // gets or set the content for new Items to add. If this is string not empty, the AddItemCmd will be enabled automatically
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
    private string? _newItemContent;

    //Returns if a new ITem can be added
    private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent);

    [RelayCommand(CanExecute = nameof(CanAddItem))]
    private void AddItem()
    {
        ToDoItems.Add(new ToDoItemViewModel() { Content = NewItemContent });

        NewItemContent = null;
    }

    [RelayCommand]
    private void RemoveItem(ToDoItemViewModel item)
    {
        // Remove the given item from the list
        ToDoItems.Remove(item);
    }
}
