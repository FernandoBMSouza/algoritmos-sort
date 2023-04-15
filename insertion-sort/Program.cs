int[] vector = new int[] { 4, 7, 2, 5, 4, 0 };
InsertionSort(vector);
for (int i = 0; i < vector.Length; i++)
{
    Console.Write(vector[i] + " ");
}

static void InsertionSort(int[] vector)
{
    for (int i = 1; i < vector.Length; i++)
    {
        int key = vector[i];
        int j = i - 1;
        while (j >= 0 && vector[j] > key)
        {
            vector[j + 1] = vector[j];
            j--;
        }
        vector[j + 1] = key;
    }
}