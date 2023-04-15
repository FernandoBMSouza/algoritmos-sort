int[] vector = new int[] { 4, 7, 2, 5, 4, 0 };
BubbleSort(vector);
for (int i = 0; i < vector.Length; i++)
{
    Console.Write(vector[i] + " ");
}

void BubbleSort(int[] vector)
{
    for (int i = 0; i < vector.Length; i++)
        for (int j = i + 1; j < vector.Length; j++)
            if(vector[j] < vector[i])
            {
                int aux = vector[i];
                vector[i] = vector[j];
                vector[j] = aux;
            }
}