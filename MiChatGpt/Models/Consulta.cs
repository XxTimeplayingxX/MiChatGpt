using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiChatGpt.Models;

public class Consulta : INotifyPropertyChanged
{
    private string respuesta;

    public string Pregunta { get; set; }
    public string Respuesta
    {
        get => respuesta; set
        {
            respuesta = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
