using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificaciones
{
    internal class Notificador
    {
        private List<IObservador> observadores = new List<IObservador>();
        public void Suscribir(IObservador observador) => observadores.Add(observador);
        public void Desuscribir(IObservador observador) => observadores.Remove(observador);
        public void Notificar(string mensaje)
        {
            foreach (var observador in observadores)
                observador.Actualizar(mensaje);
        }
    }
}
