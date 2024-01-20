//Задайте двумерный массив из целых чисел.
//Сформируйте новый одномерный массив, состоящий из средних арифметических 
//значений по строкам двумерного массива.Сделать так чтобы вывод одномерного и двумерного массива 
//был в одной функции.
Console.WriteLine("Enter the count of rows");
string inputRow = Console.ReadLine();
Console.WriteLine("Enter the count of cells");
string inputCells = Console.ReadLine();


static bool IsImputINT(string input)

{
    int value = 0;
    bool isInt = int.TryParse(input, out value);
    return isInt;
}

while (IsImputINT(inputRow) == false)
{
    Console.WriteLine("Enter the row count it must be int");
    inputRow = Console.ReadLine();
}

int rowCount = Convert.ToInt32(inputRow);

while (IsImputINT(inputCells) == false)
{
    Console.WriteLine("Enter the count of cells it must be INT");
    inputCells = Console.ReadLine();
}
int cellCount = Convert.ToInt32(inputCells);


static int[,] FillTableRandomInt(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 33);
        }
    }
    return array;
}
int[,] myTable = new int[rowCount, cellCount];
myTable = FillTableRandomInt(myTable);
void PrintTableAndArray(int[,] table , double [] array)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        Console.WriteLine(array[i] + "\t||");

        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

 
double [] myArray = new double [myTable.GetLength(0)];

double [] AverageOfRows (int[,] table,double [] array) 
{
    int average = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        average = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            average += table[i, j];
            
        }
        array[i] =(double)average/table.GetLength(1);
    }
    return array;
}
myArray = AverageOfRows(myTable, myArray);
Console.WriteLine();

PrintTableAndArray(myTable, myArray);



Console.ReadLine();
