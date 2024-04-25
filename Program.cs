using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /*programa de herencia es la caracteristica de pasar atributos y metodos de pasar otros objetos*/
    //clase mama
    class operacion
    {
        /*guarda los espacios de memoria de 3 valores*/
        //modificador tipo de dato nombre
        protected            int          valor1;
        protected            int          volor2;
        protected            int          resultado;
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
