using System;
using System.Collections.Generic;

namespace Project14.Services {
    internal class CalculationService {

        public T Max<T>(List<T> list) where T : IComparable { // método que recebe uma lista de inteiros e retorna o maior elemento da lista. 

            if (list.Count == 0) { //Programação defensiva para verificar se a lista está vazia.
                throw new ArgumentException($"The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++) { // Varrendo o vetor ignorando a posição 0.
                if (list[i].CompareTo(max) > 0) { // Verificando qual o maior elemento dentro da coleção.
                    max = list[i];
                }
            }

            return max;
        }

         
    }
}
