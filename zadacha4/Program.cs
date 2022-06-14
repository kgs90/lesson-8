int[,,] array = new int[4,4,5];
int[] check = new int[100];
int i = 0, j = 0, k = 0, o = 0;
Random rand = new Random();

for (i = 0; i < 4; i++)
    for (j = 0; j < 4; j++)
        for (k = 0; k < 5; k++) 
        {
            array[i,j,k] = rand.Next(10, 99);
            for (o = 0; o < i*j*k; o++)
                while (check[o] == array[i,j,k]) 
                {
                    array[i,j,k] = rand.Next(10, 99);
                    Console.WriteLine("повторение");
                }
                    
        }

Console.WriteLine("Сгенерированный массив 4x4x5: ");

for (i = 0; i < 4; i++)
    for (j = 0; j < 4; j++)
        for (k = 0; k < 5; k++) 
        {
            Console.WriteLine("array[" + i + "," + j + ","  + k + "] = " + array[i,j,k]);
        }