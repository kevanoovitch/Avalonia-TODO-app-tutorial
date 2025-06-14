using CommunityToolkit.Mvvm.ComponentModel;

namespace TodoApp.ViewModels;

// This is a ViewModels which represents a <see cref=Model

public partial class ToDoItemViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isChecked;

    //Gets or sets the content of the to-do item
    [ObservableProperty]
    private string? _content;

    /// Creates a new blank ToDoItemViewModel
    public ToDoItemViewModel()
    {
        //Empty constructor
    }

    public ToDoItemViewModel(ToDoItem item)
    {
        //Constructor with toDoItem
        IsChecked = item.isChecked;
        Content = item.Content;
    }

    //Gets a toDoItem of this ViewModel
    public ToDoItem GetToDoItem()
    {
        return new ToDoItem() { isChecked = this.IsChecked, Content = this.Content };
    }
}
