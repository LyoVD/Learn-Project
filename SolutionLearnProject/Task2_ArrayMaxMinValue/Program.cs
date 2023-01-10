// See https://aka.ms/new-console-template for more information


/*float cFloat = 1 / 3f;
double dFloat = 1 / 3.0;


int mathScore = 10;
int biologyScore = 9;
int physicsScore = 10;

float averageScore = (float)(mathScore + biologyScore + physicsScore) / 3;
*/


/*int[] array = new int[5];

array[0] = 10;
array[1] = 9;
array[2] = 10;
array[3] = 10;
array[4] = 8;

for (int i = 0; i < 5; i = i + 1)
{
    array[i] = array[i] * 10;
}

Console.WriteLine();
*/


int[] array = new int[10];
array[0] = 8;
array[1] = 9;
array[2] = 10;
array[3] = 9;
array[4] = 8;
array[5] = 9;
array[6] = 10;
array[7] = 9;
array[8] = 10;
array[9] = 10;

float average = 0;
int sum = 0;
int Max = array[0];
int Min = array[0];

for (int i = 0; i < 10; i++)
{
    sum = sum + array[i];

    if (Max < array[i])
    {
        Max = array[i];
    }

    if (Min > array[i])
    {
        Min = array[i];
    }

}

average = sum / 10f;

Console.WriteLine("Average = " + average);
Console.WriteLine("Max = " + Max);
Console.WriteLine("Min = " + Min);
Console.ReadLine();