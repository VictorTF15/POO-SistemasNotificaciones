using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificaciones
{
    interface IObservador
    {
        string Actualizar(string mensaje);
    }
    internal class Usuario : IObservador
    {
        public string Nombre { get; }
        public Usuario(string nombre) => Nombre = nombre;

        public string Actualizar(string mensaje)
        {
            return $"{Nombre} recibió la notificación: {mensaje}";
        }

    }
}
