

namespace Exercicio3FibonacciPilha
{

    internal class PilhaFibonacci
    {
        NumeroFibonacci headNumero;


        public PilhaFibonacci()
        {
            headNumero = null;
            Console.WriteLine("\nPilha Criada!\n");
        }
        bool Empty()
        {
            return headNumero == null;
        }

        public void push(NumeroFibonacci auxNumero)
        {
            if (Empty() == true)
            {
                headNumero = auxNumero;
            }
            else
            {
                auxNumero.setAnterior(headNumero);
                headNumero = auxNumero;
            }
            
        }

        public void imprimirPilha()
        {
            Console.WriteLine("\nValores na pilha\n");
            NumeroFibonacci numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getAnterior();
            }
        }



    }        

}
