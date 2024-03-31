using TouchBehaviorExample.Model;

namespace TouchBehaviorExample.ViewModels;

public partial class MainViewModel : BaseViewModel {

    public ObservableCollection<Fruit> fruits { get; set; } = Services.Data.GetFruits();

    [RelayCommand]
    void Pressed(object o) {

        Debug.WriteLine("Hello");
    }
}
