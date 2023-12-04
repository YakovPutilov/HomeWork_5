//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

int [] Array2dToLinear(int [,] array){
    int[] sumline = new int [array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(0); j++){
            sumline[i]+= array[i,j];
        }
    }
    return sumline;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void FindMinIndex(int [] line){
    int min_ind = 0;
    for (int i = 1; i<line.Length; i++ ){
        if (line[i]<line[min_ind]){
            min_ind = i;
        }
    }
    Console.WriteLine($"{min_ind} line have min summ");
}

Console.WriteLine("Enter col size: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter row size: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row, col, min, max);
Show2dArray(created2dArray);
Console.WriteLine();
FindMinIndex(Array2dToLinear(created2dArray));