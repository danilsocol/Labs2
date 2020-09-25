using System;

namespace Labs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа определяет правильность хода той или иной фигуры в настольной игре 'Шахматы' !");
            Console.WriteLine("Сначала выберете фигуру которую вы хотите 1-пешка, 2-ладья, 3-конь, 4-слон, 5-ферзь, 6-король  "); // 1-пешка, 2-ладья, 3-конь, 4-слон, 5-ферзь, 6-король
            int figure = int.Parse(Console.ReadLine());
            if (figure > 6 || figure <= 0)
            {
                Console.WriteLine("Такой фигуры нет");
                return;
            }
            Console.WriteLine($"Номер вашей фигур {figure}");

            Console.WriteLine("Теперь введите координаты местоположения фигуры");

             Console.WriteLine("Введите  координаты фигуры по длине от A до H");
             string Place = Console.ReadLine();
             int PlaceX;
             switch (Place)
             {
                case "A":
                    PlaceX = 1;
                    break;
                case "B":
                    PlaceX = 2;
                    break;
                case "C":
                    PlaceX = 3;
                    break;
                case "D":
                    PlaceX = 4;
                    break;
                case "E":
                    PlaceX = 5;
                    break;
                case "F":
                    PlaceX = 6;
                    break;
                case "G":
                    PlaceX = 7;
                    break;
                case "H":
                    PlaceX = 8;
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректные координаты");
                    return;

            }

            Console.WriteLine("Введите её координаты фигуры по ширине от 1 до 8");
            int PlaceY = int.Parse(Console.ReadLine());
            if (PlaceY > 8 || PlaceY <= 0)
            {
                Console.WriteLine("Вы ввели некорректные координаты");
                return;
            }
            Console.WriteLine($"Отлично, координаты вашей фигуры составляют {Place}{PlaceY}");



            Console.WriteLine("Выберете координаты куда вы хотите сделать ход");
            Console.WriteLine("Введите  координаты фигуры по длине от A до H");
            string Move = Console.ReadLine();
            int MoveX;
            switch (Move)
            {
                case "A":
                    MoveX = 1;
                    break;
                case "B":
                    MoveX = 2;
                    break;
                case "C":
                    MoveX = 3;
                    break;
                case "D":
                    MoveX = 4;
                    break;
                case "E":
                    MoveX = 5;
                    break;
                case "F":
                    MoveX = 6;
                    break;
                case "G":
                    MoveX = 7;
                    break;
                case "H":
                    MoveX = 8;
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректные координаты");
                    return;

            }



            Console.WriteLine("Введите её координаты фигуры по ширине от 1 до 8");
            int MoveY = int.Parse(Console.ReadLine());
            if (MoveY > 8 || MoveY <= 0)
            {
                Console.WriteLine("Вы ввели некорректные координаты");
                return;
            }

            Console.WriteLine($"Координаты вашего хода составляют {Move}{MoveY}");

        


            switch (figure)
            {
                case 1:
                    {
                        if (PlaceX == MoveX && MoveY == PlaceY + 1)
                        {
                            Console.WriteLine("Фигура успешно совершила ход");
                        }
                        else
                        {
                            Console.WriteLine("Фигуре не удалось совершить ход");
                        }
                    }
                    break;
                case 2:
                    if (PlaceX == MoveX & PlaceY != MoveY || PlaceX != MoveX & PlaceY == MoveY)
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре не удалось совершить ход");
                    }
                    break;
                case 3:
                    if (2 == Math.Abs(PlaceX - MoveX) && 1 == Math.Abs(PlaceY - MoveY) || 1 == Math.Abs(PlaceX - MoveX) && 2 == Math.Abs(PlaceY - MoveY))
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре не удалось совершить ход");
                    }
                    break;
                case 4:
                    if (Math.Abs(PlaceX - MoveX) == Math.Abs(PlaceY - MoveY))
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре не удалось совершить ход");
                    }
                    break;
                case 5:
                    if (Math.Abs(PlaceX - MoveX) == Math.Abs(PlaceY - MoveY) || PlaceX == MoveX & PlaceY != MoveY || PlaceX != MoveX & PlaceY == MoveY)
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре не удалось совершить ход");
                    }
                    break;
                case 6:
                    if (1 == Math.Abs(PlaceX - MoveX) && 1 == Math.Abs(PlaceY - MoveY) || 0 == Math.Abs(PlaceX - MoveX) && 1 == Math.Abs(PlaceY - MoveY) || 1 == Math.Abs(PlaceX - MoveX) && 0 == Math.Abs(PlaceY - MoveY))
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре не удалось совершить ход");
                    }
                    break;
                 
            }
        }
    }
}
