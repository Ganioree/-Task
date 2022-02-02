void printArray(int[][] array){
    for (int i = 0; i < array.Length; i++){
        for (int j = 0; j < array[i].Length; j++){
            Console.WriteLine(array[i][j] = + " ");
        }
        Console.WriteLine();
    }
}