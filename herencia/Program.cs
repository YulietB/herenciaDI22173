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
        protected            float         valor1;
        protected            float        valor2;
        protected            float         resultado;
        //ATRIBUTOS DE LA CLASE OPERACION ninguno
        //METODOS O FUNCIONES DE OPERACION
        /* LOS METODOS QUE SE PONEN A CONTINUACION
         * SON LAS FUNCIONES DE OBTENER EL VALOR DE LA CAJA DE TEXTO Y GUARDARLO EN LA MEMORIA DENTRO DE LA VARIABLE INDICADA*/
        //USAMOS UN CONSTRUCTOR POR CADA CAJA DE MEMORIA
        public float Valor1 //CAJA DE MEMORIA 1
        {
            get { return valor1; } //vamos por el valor de cada caja de texto lo guardamos en la memoria 
            set { valor1 = value; }
        }
        public float Valor2 //CAJA DE MEMORIA 1
        {
            get { return valor2; } //vamos por el valor de cada caja de texto lo guardamos en la memoria 
            set { valor2 = value; }
        }
        public float Resultado //CAJA DE MEMORIA 1
        {
            get { return resultado; } 
            set { resultado = value; }
        }
    }
      //creamos nuestra clase hijo que usara los metodos de crear dato
    class Sumar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodos puede tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase atributos de esta clase, metodos de clase
        public float operar (float v1, float v2)
        {
            valor1 = v1; // accemos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        
        public float operar(float v1, float v2)
        {
            valor1 = v1; 
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {

        public float operar(float v1, float v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class Dividir : operacion //los : nos dan permiso de usar lo que tiene operacion
    {

        public float operar(float v1, float v2)
        {
            valor1 = v1;
            valor2 = v2;
            if(valor1 == 0)
            {
                MessageBox.Show("no se puede dividir entre cero");
            }
            return resultado = valor1 / valor2;
        }
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
