using System.Collections.ObjectModel;

namespace CollectionViewInContentPresenter;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Collection { get; } = new();

    public Command AddItemCommand { get; }

    public MainPage()
    {
        InitializeComponent();
        AddItemCommand = new(() => Collection.Add("Item"));
        BindingContext = this;
    }
}
