using System;
using System.Security.Cryptography.X509Certificates;

namespace Labs2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Это программа определяет правельность хода той или иной фигуры в настольной игре 'Шахматы' !"); //pawn, rook, knight, bishop, queen, king
            Console.WriteLine("Для начала введите кординаты местоположения фигуры");
            Console.WriteLine("Введите  кординаты фигуры по длине от A до H");
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
                    Console.WriteLine("Вы ввели некорректные кординаты");
                    return;

            }




            Console.WriteLine("Введите её кординаты фигуры по ширене от 1 до 8");
            int PlaceY = int.Parse(Console.ReadLine());
            if (PlaceY > 8 || PlaceY < 0)
            {
                Console.WriteLine("Вы ввели некорректные кординаты");
                return;
            }

            Console.WriteLine($"Отлично, кординаты вашей фигуры составляют {Place}{PlaceY}");

            Console.WriteLine("Выберете кординаты куда вы хотите сделать ход");
            Console.WriteLine("Введите  кординаты фигуры по длине от A до H");
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
                    Console.WriteLine("Вы ввели некорректные кординаты");
                    return;

            }



            Console.WriteLine("Введите её кординаты фигуры по ширене от 1 до 8");
            int MoveY = int.Parse(Console.ReadLine());
            if (MoveY > 8 || MoveY < 0)
            {
                Console.WriteLine("Вы ввели некорректные кординаты");
                return;
            }

            Console.WriteLine($"Кординаты вашего хода составляют {Move}{MoveY}");



            Console.WriteLine("Теперь выберете фигуру которую вы хотите 1-пешка, 2-ладья, 3-конь, 4-слон, 5-ферзь, 6-король "); //pawn, rook, knight, bishop, queen, king 
            int figure = Convert.ToInt32(Console.ReadLine());
            switch (figure)
            {
                case 1:
                    Console.WriteLine("Вы выбрали пешку");
                    if (PlaceX == MoveX && MoveY == PlaceY++)
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре неудалось совершить ход");
                    }
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали ладью");
                    if (PlaceX == MoveX & PlaceY != MoveY || PlaceX != MoveX & PlaceY == MoveY)
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре неудалось совершить ход");
                    }
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали коня");
                    if (MoveX == (PlaceX + 2 | -2) & MoveY == (PlaceY + 1 | -1) || MoveX == (PlaceX + 1 | -1) & MoveY == (PlaceY + 2 | -2) )   
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре неудалось совершить ход");
                    }
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали слона");
                    if (PlaceX == MoveX & PlaceY != MoveY || PlaceX != MoveX & PlaceY == MoveY)
                    {
                        Console.WriteLine("Фигура успешно совершила ход");
                    }
                    else
                    {
                        Console.WriteLine("Фигуре неудалось совершить ход");
                    }
                    break;
                    


                   
              
                default:

                    Console.WriteLine("Такой фигуры нет");
                    return;
            }
        }
    }
}
