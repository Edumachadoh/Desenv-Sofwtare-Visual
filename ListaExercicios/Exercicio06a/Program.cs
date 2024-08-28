/*Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
1. Desenvolver o algoritmo de ordenação (Bubble Sort);
2. Utilizar uma função em C# para ordenação;*/

// 1 - Criar vetor
// 2 - Percorrer vetor com laco de rapeticao 
// 3 - Descobrir como gerar valor aleatorio em C#
// 4 - Ordenar o vetor usando Bubble Sort 

int tamanho = 100;
int[] vetor = new int[tamanho]; 

Random random = new Random();
for (int i = 0; i < vetor.Length; i ++) {
    vetor[i] = random.Next(1000);
    
}

bool trocado;
do  { 
    trocado = false;
    for (int i = 0; i < vetor.Length - 1; i ++) {
        if (vetor[i] > vetor[i + 1]) {
            int aux = vetor[i];
            vetor[i] = vetor[i+1];
            vetor[i+1] = aux;

            trocado = true;
        }
    }

} while (trocado == true);

for (int i = 0; i < vetor.Length; i ++) {
    Console.Write(vetor[i] + " ");
}