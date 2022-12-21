int input = 0;
int dice_1 = 0;
int dice_2 = 0;
int dice_3 = 0;
int dice_4 = 0;
int dice_5 = 0;
bool fixed_1 = false;
bool fixed_2 = false;
bool fixed_3 = false;
bool fixed_4 = false;
bool fixed_5 = false;


void RollDice()
{
    if (!fixed_1) { dice_1 = Random.Shared.Next(1, 7); }
    if (!fixed_2) { dice_2 = Random.Shared.Next(1, 7); }
    if (!fixed_3) { dice_3 = Random.Shared.Next(1, 7); }
    if (!fixed_4) { dice_4 = Random.Shared.Next(1, 7); }
    if (!fixed_5) { dice_5 = Random.Shared.Next(1, 7); }
}
void PrintDice()
{
    System.Console.WriteLine($" {dice_1},  {dice_2},  {dice_3},  {dice_4},  {dice_5}");
}
void FixDice()
{
    fixed_1 = fixed_2 = fixed_3 = fixed_4 = fixed_5 = false;
    do
    {
        System.Console.WriteLine("Which dice do you want to fix/unfix?(1-5) or 6 for roll the dice");
        input = int.Parse(Console.ReadLine()!);
        switch (input)
        {
            case 1:
                fixed_1 = !fixed_1;
                break;
            case 2:
                fixed_2 = !fixed_2;
                break;
            case 3:
                fixed_3 = !fixed_3;
                break;
            case 4:
                fixed_4 = !fixed_4;
                break;
            case 5:
                fixed_5 = !fixed_5;
                break;
        }
        Console.Write("Fixed: ");
        if (fixed_1) { Console.Write("1 "); }
        if (fixed_2) { Console.Write("2 "); }
        if (fixed_3) { Console.Write("3 "); }
        if (fixed_4) { Console.Write("4 "); }
        if (fixed_5) { Console.Write("5 "); }
        Console.WriteLine();
    }
    while (input != 6);
};
void SortDice()
{
    int num1 = dice_1;
    int num2 = dice_2;
    int num3 = dice_3;
    int num4 = dice_4;
    int num5 = dice_5;
    bool isSorted = false;
    while (!isSorted)
    {
        isSorted = true;

        if (num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            isSorted = false;
        }
        if (num2 > num3)
        {
            int temp = num2;
            num2 = num3;
            num3 = temp;
            isSorted = false;
        }
        if (num3 > num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
            isSorted = false;
        }
        if (num4 > num5)
        {
            int temp = num4;
            num4 = num5;
            num5 = temp;
            isSorted = false;
        }
    }

    Console.WriteLine($"Sorted: {num1}, {num2}, {num3}, {num4}, {num5}");
}

RollDice();
SortDice();
PrintDice();
FixDice();

RollDice();
SortDice();
PrintDice();
FixDice();

RollDice();
SortDice();
PrintDice();




