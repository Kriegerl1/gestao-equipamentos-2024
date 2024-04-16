﻿namespace GestaoEquipamentos.ConsoleApp
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Gerenciamento de Equipamentos, Academia de Programação!\n");

            Estoque estoque = new Estoque();
            Menu menu = new Menu(estoque);
            menu.ExibirMenu();
        }

        #region Métodos da Main
        public static T ObterValor<T>(string texto)
        {
            Console.WriteLine(texto);

            string input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido!");
                return ObterValor<T>(texto);
            }
        }
        #endregion

    }

}
