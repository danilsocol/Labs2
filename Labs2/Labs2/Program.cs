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
            if (figure > 0 & figure<7) 
            { 
                if (figure==1)                                                                                                          // figure фигура пешка
                {                                                             
                    Console.WriteLine("Вы выбрали пешку!");                                                         // y ширина x длина
                    Console.WriteLine("Введите её кординаты фигуры по длине от A до H");
                    dynamic str = Console.ReadLine();
                        if (str == "A" )
                        {
                            str = "1";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "B")
                        {
                            str = "2";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "C")
                        {
                            str = "3";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "D")
                        {
                            str = "4";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "E")
                        {
                            str = "5";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "F")
                        {
                            str = "6";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "G")
                        {
                            str = "7";
                            int x = Convert.ToInt32(str);
                        }
                        if (str == "H")
                        {
                            str = "8";
                            int x = Convert.ToInt32(str);
                        }
                    
                  
                    Console.WriteLine("Введите её кординаты фигуры по ширене от 1 до 8");
                    string y = Console.ReadLine();   

                  
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
