using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Fila f = new Fila();
            f.Enfileira(1);
            f.Enfileira(2);
            f.Enfileira(3);
            f.Enfileira(4);
            f.Enfileira(5);
            f.Enfileira(6);
            Console.WriteLine(f.Desenfileira());
            Console.WriteLine(f.Desenfileira());
            Console.WriteLine(f.Desenfileira());
            Console.WriteLine(f.Desenfileira());
            Console.WriteLine(f.Desenfileira());
            Console.WriteLine(f.Desenfileira());*/

 /*           Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());
*/
            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
        }
    }
}
