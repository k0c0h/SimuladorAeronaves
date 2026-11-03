using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SimuladorAeronaves.Logica
{
    public class ValidadorDatos
    {
        public bool IntentarLeerNumero(string texto, out double valor)
        {
            valor = 0;

            if (string.IsNullOrWhiteSpace(texto))
                return false;

            texto = texto.Trim().Replace(',', '.');

            bool valido = double.TryParse(
                texto,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out valor);

            return valido &&
                   !double.IsNaN(valor) &&
                   !double.IsInfinity(valor);
        }

        public bool ValidarDesplazamiento(
            string textoX,
            string textoY,
            out double dx,
            out double dy,
            out string mensaje)
        {
            dx = 0;
            dy = 0;
            mensaje = "";

            if (!IntentarLeerNumero(textoX, out dx))
            {
                mensaje = "Ingrese un desplazamiento X válido.";
                return false;
            }

            if (!IntentarLeerNumero(textoY, out dy))
            {
                mensaje = "Ingrese un desplazamiento Y válido.";
                return false;
            }

            mensaje = "Desplazamiento válido.";
            return true;
        }

        public bool ValidarAngulo(
            string texto,
            out double angulo,
            out string mensaje)
        {
            angulo = 0;
            mensaje = "";

            if (!IntentarLeerNumero(texto, out angulo))
            {
                mensaje = "Ingrese un ángulo válido.";
                return false;
            }

            mensaje = "Ángulo válido.";
            return true;
        }

        public bool ValidarCoordenadas(
            string textoX,
            string textoY,
            out double x,
            out double y,
            out string mensaje)
        {
            x = 0;
            y = 0;
            mensaje = "";

            if (!IntentarLeerNumero(textoX, out x))
            {
                mensaje = "Ingrese una coordenada X válida.";
                return false;
            }

            if (!IntentarLeerNumero(textoY, out y))
            {
                mensaje = "Ingrese una coordenada Y válida.";
                return false;
            }

            mensaje = "Coordenadas válidas.";
            return true;
        }
    }
}