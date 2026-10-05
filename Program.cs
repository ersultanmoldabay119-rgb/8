Console.OutputEncoding = System.Text.Encoding.UTF8;

var tasks = new (string Title, Action Run)[]
{
    ("Животные", T01.Demo.Run), ("Транспорт", T02.Demo.Run), ("Работники", T03.Demo.Run),
    ("Фигуры", T04.Demo.Run), ("Банковские счета", T05.Demo.Run), ("Игроки", T06.Demo.Run),
    ("Устройства", T07.Demo.Run), ("Музыкальные инструменты", T08.Demo.Run), ("Птицы", T09.Demo.Run),
    ("Сотрудники и зарплата", T10.Demo.Run), ("Система оплаты", T11.Demo.Run), ("Уведомления", T12.Demo.Run),
    ("Доставка", T13.Demo.Run), ("Система скидок", T14.Demo.Run), ("Роботы", T15.Demo.Run),
    ("Геометрические фигуры", T16.Demo.Run), ("Система транспорта", T17.Demo.Run), ("Зарплата сотрудников", T18.Demo.Run),
    ("Интернет-магазин", T19.Demo.Run), ("Система сообщений", T20.Demo.Run), ("Платёжная система", T21.Demo.Run),
    ("Сотрудники компании", T22.Demo.Run), ("Игра — персонажи", T23.Demo.Run), ("Больница", T24.Demo.Run),
    ("Файловая система", T25.Demo.Run), ("Система отчетов", T26.Demo.Run), ("Умный дом", T27.Demo.Run),
    ("Система заказов", T28.Demo.Run), ("Такси-сервис", T29.Demo.Run), ("Мини-магазин", T30.Demo.Run),
};

// dotnet run        -> все задания
// dotnet run -- 7   -> только задание №7
if (args.Length > 0 && int.TryParse(args[0], out int n) && n >= 1 && n <= tasks.Length)
{
    Print(n);
}
else
{
    for (int i = 1; i <= tasks.Length; i++) Print(i);
}

void Print(int i)
{
    Console.WriteLine($"\n===== {i}. {tasks[i - 1].Title} =====");
    tasks[i - 1].Run();
}
