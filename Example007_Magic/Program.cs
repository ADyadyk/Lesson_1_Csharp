Console.Clear();
//Console.SetCursorPosition(5;5);

/*Определим координаты точек, с которыми будет работать приложение*/

int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;

/*Выведем в терминал наши точки по их координатам*/

Console.SetCursorPosition(xa,ya);
Console.WriteLine("#");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("#");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("#");

/*Определим некоторую начальную точку x*/

int x = xa, y = ya;

/*Определим счётчик*/

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); //Рандомно определим одну из точек 0, 1, 2
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
     if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
     if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    //Выведем найденную точку на экран
    Console.SetCursorPosition(x, y);
    Console.WriteLine("=");

    //Увеличим счётчик на 1
    count = count +1;
}