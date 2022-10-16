// 1 - დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
//კენტი რიცხვების ჯამი
//ლუწი რიცხვების ნამრავლი
//დაითვლის მასივში თითოეული ელემენტის რაოდენობას  (3)

int[] arr;
Console.WriteLine("Determine the size of an array with any number: ");
int size = int.Parse(Console.ReadLine());
arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Enter an integer number: ");
    arr[i] = int.Parse(Console.ReadLine());
}
foreach (int n in arr)
{
    Console.Write(n + " ");
}

int max = arr.Max();
int sum = 0;
int product = 1;

for (int j = 0; j <= max; j++)
{
    if (arr[j] % 2 == 0)
    {
        product *= j;

    }
    else
    {
        sum += j;
    }

}

Console.WriteLine();
Console.WriteLine($"Product={product} & Sum={sum}");
