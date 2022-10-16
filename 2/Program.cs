// დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის თუ არა მოცემული სტრინგი პალინდრომი
// (პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის)  

Console.WriteLine("Enter string: ");
string str = Console.ReadLine();
bool checkPalindrome = true;
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - 1 - i])
    {
        Console.WriteLine("String is not a Palindrome");
        checkPalindrome = false;
        break;
    }
    else
    {
        checkPalindrome = true;
    }
}

if (checkPalindrome)
{
    Console.WriteLine("String is a Palindrome");
}