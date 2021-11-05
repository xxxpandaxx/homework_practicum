
void PrintArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        Console.WriteLine(array[i]);
    }
}
void FillArray(int[] array)
{
    for(int i = 0;i<array.Length; i++)
    {
        array[i]=new Random().Next(10,40);
    }
}
int averageArray(int[] array)
{
     int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        result = array[i] + result;
    
    }
    
    result = result/array.Length;
    return result;
}


/*Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел*/
int[] arrA = new int[12];

FillArray(arrA);
//Создать на его основе масив B
int[] arrB = arrA;

arrA[11]=10;
arrA[10]=10;
arrA[9]=10;
arrA[8]=10;

Console.WriteLine();
PrintArray(arrB);
Console.WriteLine();



//отбрасывая те, которые
//*нарушают порядок возрастания(должны остаться числа в порядке возрастания)   
//*больше среднего арифметического элементов A(оставляем те что меньше)
//чётные* (оставляем те что нечётные)
int i = 0;


int currentElement = arrB[0];
Console.WriteLine(currentElement);
while ( i < arrB.Length)
{
    if(arrB[i]>currentElement && arrB[i] > averageArray(arrA)  &&  arrB[i]/2 !=0 )
    {
        Console.WriteLine(arrB[i]);
        currentElement = arrB[i];
    }
    i++;
}

