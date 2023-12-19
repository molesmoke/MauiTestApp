using System.Diagnostics;

namespace MauiTestApp
{
    public partial class MainPage : ContentPage
    {
        public List<string> Strings { get; } = ["1", "2", "3"];

        public MainPage()
        {
            InitializeComponent();

            collectionView.ItemsSource = Strings;
            collectionView.SelectedItem = Strings[1];

            listView.ItemsSource = Strings;
            collectionView.SelectedItem = Strings[1];
        }
    }

}
