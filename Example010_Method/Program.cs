int[] array = { 12, 22, 33, 44, 55, 66, 44, 77, 98 };

int n = array.Length;
int find = 44;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}