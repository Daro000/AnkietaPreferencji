using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AnkietaPreferencji;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SubmitButton.Click += Submit_button_Click;
    }

    private void Submit_button_Click(object sender, RoutedEventArgs e)
    {
        var valueimie = Imie.Text;
        var valueprzedmiot = (Przedmiot.SelectedItem as ComboBoxItem) ?.Content?.ToString() ?? "Nie wybrane";
        var selectedCheckbox = new[] {Tak1,Tak2,Tak3,Tak4,Tak5};
        var count = selectedCheckbox.Count(p => p.IsChecked == true);
        
        Info.Text = $"Twoje imie: {valueimie}, Przedmiot : {valueprzedmiot}, Odpowiedziales na tak {count} razy";
        
        
    }
}