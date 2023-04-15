int[] vector = new int[] { 7, 5, 1, 8, 3 };
SelectionSort(vector);
for (int i = 0; i < vector.Length; i++)
{
    Console.Write(vector[i] + " ");
}


void SelectionSort(int[] vector)
{
    for (int i = 0; i < vector.Length - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < vector.Length; j++)
            if(vector[j] < vector[minIndex])
                minIndex = j;
            
        if(vector[i] > vector[minIndex])
        {
            int aux = vector[i];
            vector[i] = vector[minIndex];
            vector[minIndex] = aux;
        }
    }
}