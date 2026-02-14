//int[] mss=new int[10];
//int[] mss1 = new int[10];

//Random rand = new Random();
//for (int i = 0; i < mss.Length; i++)
//{
//    mss[i] = rand.Next(1,10);
//    mss1[i] = mss[i];
//}


string[] englishWords =
{
    "apple", "book", "house", "water", "sun", "tree", "dog", "school", "friend", "food", "road", "music", "computer", "phone", "family", "work"
};

string[] ukrainianWords =
{
    "яблуко", "книга", "будинок", "вода", "сонце", "дерево", "собака", "школа", "друг", "їжа", "дорога", "музика", "комп'ютер", "телефон", "родина", "робота"
};
Console.OutputEncoding = System.Text.Encoding.UTF8;
Random random = new Random();
int pravilno = 0;
Console.Write("Введіть кількість слів яку хочите вивчити (правильніх відповідей треба буде дати): ");
int.TryParse(Console.ReadLine(), out int a);
for (int i = 0; pravilno<a; i++)
{
    int position = random.Next(0, englishWords.Length - 1);
    Console.WriteLine($"{englishWords[position]}");
    int prav=random.Next(0, 4), neprav1= random.Next(0, ukrainianWords.Length - 1), neprav2 = random.Next(0, ukrainianWords.Length - 1), neprav3 = random.Next(0, ukrainianWords.Length - 1);
    while (true)
    {
        if (neprav1 == position || neprav1 == neprav2 || neprav1 == neprav3)
        {
            neprav1 = random.Next(0, ukrainianWords.Length - 1);
        }
        else if (neprav2 == position || neprav2 == neprav3)
        {
            neprav2 = random.Next(0, ukrainianWords.Length - 1);
        }
        else if (neprav3 == position)
        {
            neprav3 = random.Next(0, ukrainianWords.Length - 1);
        }
        else
        {
            break;
        }
    }
    switch (prav)
    {
        case 0:
            Console.WriteLine($"1) {ukrainianWords[position]}");
            Console.WriteLine($"2) {ukrainianWords[neprav1]}");
            Console.WriteLine($"3) {ukrainianWords[neprav2]}");
            Console.WriteLine($"4) {ukrainianWords[neprav3]}");
            break;
        case 1:
            Console.WriteLine($"1) {ukrainianWords[neprav1]}");
            Console.WriteLine($"2) {ukrainianWords[position]}");
            Console.WriteLine($"3) {ukrainianWords[neprav2]}");
            Console.WriteLine($"4) {ukrainianWords[neprav3]}");
            break;
        case 2:
            Console.WriteLine($"1) {ukrainianWords[neprav1]}");
            Console.WriteLine($"2) {ukrainianWords[neprav2]}");
            Console.WriteLine($"3) {ukrainianWords[position]}");
            Console.WriteLine($"4) {ukrainianWords[neprav3]}");
            break;
        case 3:
            Console.WriteLine($"1) {ukrainianWords[neprav1]}");
            Console.WriteLine($"2) {ukrainianWords[neprav2]}");
            Console.WriteLine($"3) {ukrainianWords[neprav3]}");
            Console.WriteLine($"4) {ukrainianWords[position]}");
            break;
    }
    Console.Write("Ваша відповідь: ");
    int.TryParse(Console.ReadLine(), out int vod);
    if (vod - 1 == prav)
    {
        Console.WriteLine("Правильно!");
        pravilno++;
    }
    else
    {
        Console.WriteLine($"Неправильно! Правильна відповідь: {ukrainianWords[position]}");
    }
}