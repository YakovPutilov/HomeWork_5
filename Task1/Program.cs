﻿//Задача 1: Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.

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

void ShowArraySell(int [,] array, int row, int col){
    if (array.GetLength(0) > row && array.GetLength(1) > col){
        Console.WriteLine(array[row,col]);
    }
    else{
        Console.WriteLine("Out of range");
    }
}


Console.WriteLine("Enter col size: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter row size: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter request row: ");
int req_row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter request col: ");
int req_col = Convert.ToInt32(Console.ReadLine());


int [,] created2dArray = Create2dArray(row, col, min, max);
Show2dArray(created2dArray);
Console.WriteLine();
ShowArraySell(created2dArray, req_row, req_col);