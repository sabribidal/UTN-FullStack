﻿namespace WebApp.EjemploInterfaz
{
    public class Gato : IAnimal
    {
        public Gato(string nombre)
        {
            Name = nombre;
        }

        public string Name { get; }

        public string HacerSonido()
        {
            return "Miauuuu";
        }
    }
}