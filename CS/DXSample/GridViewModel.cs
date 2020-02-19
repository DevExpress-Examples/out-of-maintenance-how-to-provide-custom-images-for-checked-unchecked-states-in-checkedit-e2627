using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace DXSample {
    public class GridViewModel : ViewModelBase {
        public ObservableCollection<ItemViewModel> Items {
            get { return GetValue<ObservableCollection<ItemViewModel>>(); }
            set { SetValue(value); }
        }
        public GridViewModel() {
            Items = new ObservableCollection<ItemViewModel>();
            for (int i = 0; i < 10; i++) {
                Items.Add(new ItemViewModel() { Subject = $"Mail{i}", IsRead = i % 3 == 0 });
            }
        }
    }

    public class ItemViewModel : ViewModelBase {
        public string Subject {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public bool IsRead {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }
    }
}
