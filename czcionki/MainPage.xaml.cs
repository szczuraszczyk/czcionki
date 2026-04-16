using System;
using System.Collections.Generic;

namespace czcionki
{
    public partial class MainPage : ContentPage
    {
        int i = 0;

        public MainPage()
        {
            InitializeComponent(); // sprawia, że nie wyskakuje null i aplikacja działa

            var rozmiar = (int)Math.Round(slider.Value); // roundujemy do calkowitej liczby ze slidera i przypisujesz rozmiar
            rozmiarNapis.Text = $"Rozmiar: {rozmiar}";
            cytatNapis.FontSize = Math.Max(1, rozmiar);
            cytatNapis.Text = (Items.Count == 0) ? "" : Items[0]; // jesli tablica jest pusta, wklej "" jako napis
        }

        public List<string> Items { get; set; } = new() { "Dzień dobry", "Good morning", "Buenos Dias" }; //  idk lista wzięta z neta

        private void Slider_Zmieniony(object sender, ValueChangedEventArgs x) // ValueChangedEventArgs jest doublem
        {
            var size = (int)Math.Round(x.NewValue);
            rozmiarNapis.Text = $"Rozmiar: {size}";
            cytatNapis.FontSize = Math.Max(1, size);
        }

        private void OnClick(object? sender, EventArgs e)
        {
            if (Items == null || Items.Count == 0) // sprawdza czy jest null, returm gdy tak
                return;

            i = (i + 1) % Items.Count; // aka petla?? wraca na początek tablicy "gdy indeks osiągnie długość tablicy (np. 3), dzieli się ona przez 3 i wraca do 0"
            cytatNapis.Text = Items[i];
        }
    }
}