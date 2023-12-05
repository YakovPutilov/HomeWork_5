//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении 
//которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца

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

int [,] ArrWthotMinline(int [,] array){
    int [,] newarray = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    int min_i = 0;
    int min_j = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if (array[i,j]<array[min_i,min_j]){
                min_i = i;
                min_j = j;
            }
        }    
    }
    Console.WriteLine(min_i);
    Console.WriteLine(min_j);
    //int n = 0;
    //int m = 0;
    for(int i = 0; i<newarray.GetLength(0); i++){
        if(i < min_i){  
           for(int j = 0; j<newarray.GetLength(1); j++){
                if (j < min_j){                    
                   newarray[i,j] = array[i,j];
                                                             
                }
                else{
                newarray[i,j] = array[i,j+1];
                }
                //m++;                       
            } 
        }
        else{
            for(int j = 0; j<newarray.GetLength(1); j++){
                if (j < min_j){                    
                   newarray[i,j] = array[i+1,j];
                                                             
                }
                else{
                newarray[i,j] = array[i+1,j+1];
                }
                //m++;                       
            } 
        }
            
        //n++;
    }      
    return newarray;
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
Show2dArray(ArrWthotMinline(created2dArray));