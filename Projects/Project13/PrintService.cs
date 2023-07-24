using System;
namespace Project13 {
    internal class PrintService<T> { //parametrizando a class

        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value) {

            if (_count == 10) {
                throw new InvalidOperationException($"PrintService is full");
            }

            _values[_count] = value;
            _count++;
        }

        public T First() {

            if (_count == 0) {
                throw new InvalidOperationException($"PrintService is empty");
            }

            return _values[0];
        }

        public void Print() {

            Console.Write($"[");
            for (int i = 0; i < _count - 1; i++) { // _count - 1 pra exibir até a penúltima posição do vetor.

                Console.Write(_values[i] + ", ");
            }
            if (_count > 0) {

                Console.Write(_values[_count - 1]); // _count - 1 pra exibir a última posição do vetor. 
            }
            Console.WriteLine($"]");
        }
    }
}
