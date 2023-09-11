using System;

namespace Ucu.Poo.TestDateFormat
{
    // Excepción personalizada para manejar fechas con formato inválido.
    public class InvalidDateFormatException : Exception
    {
        public InvalidDateFormatException(string date) : base($"El formato de la fecha '{date}' no es válido. Debe estar en formato 'dd/mm/yyyy'.") { }
    }

    /// <summary>
    /// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
    /// </summary>
    public class DateFormatter
    {
        /// <summary>
        /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
        /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
        /// asumido.
        /// </summary>
        /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
        /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
        public static string ChangeFormat(string date)
{
    if (string.IsNullOrWhiteSpace(date))
    {
        return string.Empty; // Retorna una cadena vacía para fechas en blanco.
    }

    if (date.Length != 10 || date[2] != '/' || date[5] != '/')
    {
        throw new InvalidDateFormatException(date);
    }

    return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
}

    }
}

