using System;

namespace Labs2
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Это программа определяет правельность хода той или иной фигуры в настольной игре 'Шахматы' !");
            Console.WriteLine("Для начал выберете фигуру которую вы хотите 1-пешка, 2-ладья, 3-конь, 4-слон, 5-ферзь, 6-король "); //pawn, rook, knight, bishop, queen, king
            int figure = Convert.ToInt32(Console.ReadLine());
            if (figure > 0 & figure < 7)
            {
                if (figure == 1)                                                                                                          // figure фигура пешка
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Извените но такой фигуры нет ");
                return;
            }
        }
    }
}
