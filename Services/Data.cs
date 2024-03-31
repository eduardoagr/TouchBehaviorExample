using TouchBehaviorExample.Model;

namespace TouchBehaviorExample.Services;
public static class Data {

    public static ObservableCollection<Fruit> GetFruits() {

        return [

            new() { Nmae = "Apple", Image = "apple.png"},
            new() { Nmae = "Banana", Image = "banana.png"}
        ];
    }
}
