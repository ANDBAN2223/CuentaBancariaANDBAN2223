using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancariaANDBAN2223
{
    /// <summary>
    /// <para>Clase que representa una cuenta corriente.</para>
    /// <para>Tiene el campo saldo que representa el saldo de la cuenta, en euros.</para>
    /// <para>Existen dos constructores:
    /// <list type="number">
    ///     <item>
    ///         <description>Vacía</description>
    ///     </item>
    ///     <item>
    ///         <description>Saldo inicial</description>
    ///     </item>
    /// </list>
    /// </para>
    /// </summary>
    public class Cuenta
    {
        private double saldo;
        /// <summary>
        /// Error de la cantidad no valida.
        /// </summary>
        public const String ERR_CANTIDAD_NO_VALIDA = "La cantidad indicada no es válida.";
        /// <summary>
        /// Error del saldo insuficiente.
        /// </summary>
        public const String ERR_SALDO_INSUFICIENTE = "Saldo insuficiente.";

        /// <summary>
        /// Constructor con saldo vacío.
        /// </summary>
        public Cuenta()
        {
            this.saldo = 0;
        }
        /// <summary>
        /// Constructor con saldo inicial.
        /// </summary>
        /// <param name="saldo">Saldo inicial con dinero.</param>
        public Cuenta(double saldo)
        {
            IngresarANDBAN2223(saldo);
        }
        /// <summary>
        /// Obtiene y devuelve el saldo.
        /// </summary>
        /// <value>Saldo en la cuenta.</value>
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        /// <summary>
        /// Ingresa dinero indicado a la cuenta.
        /// </summary>
        /// <remarks>Este método usa sobrecarga.</remarks>
        /// <param name="cantidad">Dinero ingresado.</param>
        /// <exception cref="ArgumentOutOfRangeException">Este método no ingresa si cantidad es - 0.</exception>
        public void IngresarANDBAN2223(double cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
            Saldo += cantidad;
        }
        /// <summary>
        /// Retira dinero indicado de la cuenta.
        /// </summary>
        /// <remarks>Este método usa sobrecarga.</remarks>
        /// <param name="cantidad">Dinero reintegro.</param>
        /// <exception cref="ArgumentOutOfRangeException">Este método no reintegra dinero si la cantidad es 0 o - 0, tambien si cantidad es mayor que sueldo en la cuenta.</exception>
        public void RetirarANDBAN2223(double cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
            if (cantidad > Saldo)
                throw new ArgumentOutOfRangeException(ERR_SALDO_INSUFICIENTE);
            Saldo -= cantidad;
        }
    }
}
