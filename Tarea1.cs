using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_Desarrollo_de_APP_Escritorio
{
    public partial class Tarea1 : Form
    {
        public Tarea1()
        {
            InitializeComponent();
        }

        private void Pregunta1_Click(object sender, EventArgs e)
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Longitud: {numeros.Length}");
            Console.WriteLine("Valores:");

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");

            }
        }

        private void Pregunta2_Click(object sender, EventArgs e)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            numeros[2] = 100;

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");

            }
        }

        private void Pregunta3_Click(object sender, EventArgs e)
        {
            string[] nombres = { "Ana", "Luis", "Pedro", "Marta" };
            string buscaNombre = "Pedro";
            Console.WriteLine("Busca el nombre:");

            for (int i = 0; i < nombres.Length - 1; ++i)
            {
                if (nombres[i] == buscaNombre)
                {
                    Console.WriteLine(buscaNombre);
                    break;

                }
                
            }
        }

        private void Pregunta4_Click(object sender, EventArgs e)
        {
            int[] numeros = { 50, 40, 30, 20, 10 };
            Console.WriteLine("Orden ascendente:");

            Array.Sort(numeros); // ordena los numeros de forma ascendente

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");

            }

        }

        private void Pregunta5_Click(object sender, EventArgs e)
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Nuevo orden:");

            Array.Reverse(numeros); //ordena los numeros de reversa segun el orden

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");

            }

        }

        private void Pregunta6_Click(object sender, EventArgs e)
        {
            int[] numeros = { 10, 20, 30, 40, 50 };

            Array.Clear(numeros,0,2);

            for (int i = 0; i < 3; ++i)
            {
                numeros[i] = 0;

            }

            Console.WriteLine("Cambios de valores");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

        }

        private void Pregunta7_Click(object sender, EventArgs e)
        {
            int[] origen = { 1, 2, 3, 4, 5 };
            int[] destino = new int[origen.Length]; // copia la longitud de origen

            Array.Copy(origen, destino, origen.Length); // copia los datos de origen

            Console.WriteLine("Copiar datos de origen");
            foreach (int i in destino)
            {
                Console.WriteLine(i);
            }

        }

        private void Pregunta9_Click(object sender, EventArgs e)
        {
            int[] numeros = { 10, 20, 30, 40, 50 };

            int encuentraNumero = Array.Find(numeros, num => num > 20);
            Console.WriteLine($"El primer numero encontrado es {encuentraNumero}");

        }

        private void Pregunta10_Click(object sender, EventArgs e)
        {
            int[] numeros = { 2, 4, 6, 8, 10 };

            int encuentraNumero = Array.Find(numeros, num => num % 2 == 0);
            Console.WriteLine($"El primer numero par encontrado es {encuentraNumero}");

        }

        private void Pregunta11_Click(object sender, EventArgs e)
        {
            String[] frutas = { "manzana", "banana", "naranja", "kiwi" };

            int buscaIndice = Array.IndexOf(frutas, "kiwi");

            Console.WriteLine($"kiwi se encuentra en la posición: {buscaIndice}");
        }

        private void Pregunta12_Click(object sender, EventArgs e)
        {
            int[] numeros = { 15, 25, 35, 45, 55 };
            Array.Clear(numeros, 2, 3);

            Console.WriteLine("Cambios de valores a cero");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

        }

        private void Pregunta13_Click(object sender, EventArgs e)
        {
            int[] datos = { 5, 10, 15, 20, 25 };
            int[] subDatos = new int[3];
            Array.Copy(datos, subDatos, 3);

            Console.WriteLine("Copia de los primeros 3 datos");
            foreach (int i in subDatos)
            {
                Console.WriteLine(i);
            }


        }

        private void Pregunta14_Click(object sender, EventArgs e)
        {
            int[] valores = { 3, 6, 9, 12, 15 };

            Array.Reverse(valores);

            Console.WriteLine("Resultados en orden reversa");

            foreach (int i in valores)
            {
                Console.WriteLine(i);
            }
        }

        private void Pregunta15_Click(object sender, EventArgs e)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };

            bool existe = Array.Exists(numeros, x=> x == 10);

            if (existe)
            {
                Console.WriteLine("El numero si existe");
            }
            else
            {
                Console.WriteLine("El numero No existe");
            }
        }

        private void Pregunta16_Click(object sender, EventArgs e)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            int Minimo = numeros.Min();

            Console.WriteLine($"El numero minimo es: {Minimo}");
        }

        private void Pregunta17_Click(object sender, EventArgs e)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            int Maximo = numeros.Max();

            Console.WriteLine($"El numero maximo es: {Maximo}");

        }

        private void Pregunta18_Click(object sender, EventArgs e)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            int Suma = numeros.Sum();

            Console.WriteLine($"La suma de los numeros es: {Suma}");

        }
    }
}

