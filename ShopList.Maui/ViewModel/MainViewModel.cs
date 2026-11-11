using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;
using ShopList.Maui.Views;
using System.Collections.ObjectModel;

namespace ShopList.Maui.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ShopListItem> _items;

        public MainViewModel()
        {
            Items = new ObservableCollection<ShopListItem>();
            LoadDta();
        }

        private void LoadDta()
        {
            Items.Add(new ShopListItem
            {
                Nombre = "Leche",
                Cantidad = 2,
                Compredo = false

            });

            Items.Add(new ShopListItem
            {
                Nombre = "Pan",
                Cantidad =1,
                Compredo = true
            });

            Items.Add(new ShopListItem
            {
                Nombre = "Mantequilla",
                Cantidad = 1,
                Compredo = false
            });
        }
        [RelayCommand]
        private async Task ShowNewFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditItemPage));
        }
    }
}
