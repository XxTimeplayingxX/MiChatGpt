using MiChatGpt.Models;
using MiChatGpt.Services.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiChatGpt.ViewModels;

public class MainPageViewModel
{
    private readonly IMensajeria mensajeria;
    private Consulta miConsulta;

    public Consulta MiConsulta
    {
        get => miConsulta; set
        {
            miConsulta = value;
        }
    }
    //Crear un comando
    public Command EnviarCommand { get; set; }
    public MainPageViewModel(IMensajeria mensajeria)//<-Inyectar
    {
        MiConsulta = new Consulta();
        EnviarCommand = new Command(EnviarPregunta);
        this.mensajeria = mensajeria;
    }
    public void EnviarPregunta()
    {
        MiConsulta.Respuesta = mensajeria.Preguntame(MiConsulta.Pregunta);
    }
    
}
