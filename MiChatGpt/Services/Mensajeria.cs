using MiChatGpt.Services.Interfaces;

namespace MiChatGpt.Services
{
    //Implementar la interfaz

    public class Mensajeria : IMensajeria
    {
        public string Preguntame(string pregunta)
        {
            if (string.IsNullOrEmpty(pregunta))
            {
                return "Error en la pregunta";
            }
            //Aquí el código
            var respuesta = "Yo soy Groot";
            return respuesta;
        }
    }
}
