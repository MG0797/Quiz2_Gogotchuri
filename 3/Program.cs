// დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს.
// Მაგ 1 1 2 2 2 3 4 2 2  - უნდა დაბეჭდოს 3  და 2.


int[] arr;

Console.WriteLine("Determine the size of an array with any number: ");
int size = int.Parse(Console.ReadLine());
arr = new int[size];

Console.WriteLine($"Enter {size} number:");
for (int i = 0; i < size; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}


int mx = arr.Max();

int[] newArr = new int[mx + 1];

for (int i = 0; i < arr.Length; i++)
{
    newArr[arr[i]]++;
}

for (int i = 0; i < newArr.Length; i++)
{
    if (newArr[i] > 1)
    {
        Console.Write($"{i} ");
    }
}
