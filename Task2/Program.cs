//Задача 2: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int [,] ArraySwitsh(int [,] array){
    int [] sw_array = array;
    int len0 = array.GetLength(0)-1;
    for (int i=0; i < array.GetLength(1); i++){
        sw_array[0,i] = array[len0,i];
        sw_array[len0,i] = array[0,i];
    }
    return sw_array;
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
Show2dArray(ArraySwitsh(created2dArray));
