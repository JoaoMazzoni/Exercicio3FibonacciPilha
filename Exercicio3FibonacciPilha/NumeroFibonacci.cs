
namespace Exercicio3FibonacciPilha
{
    internal class NumeroFibonacci
    {
        int numero;
        NumeroFibonacci anterior;

        public NumeroFibonacci(int numero)
        {
            this.numero = numero;
            anterior = null;
        }

        public void setAnterior(NumeroFibonacci numero)
        {
            anterior = numero;
        }

        public NumeroFibonacci getAnterior()
        {
            return anterior;
        }


        public int getValor() //Função para pegar o valor do numero.
        {
            return this.numero;
        }



    }
}
