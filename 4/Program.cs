// (ბონუსი) დაწერეთ პროგრამა რომელიც მასივში იპოვნის ყველაზე ხშირად გამეორებული ელემენტის რაოენობას და დაბეჭდავს ამ ელემენტს. 
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

int mx2 = newArr.Max();

Console.WriteLine($"Most Frequent Element Occures {mx2} Times");
