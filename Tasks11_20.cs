// ---------- 11. Система оплаты ----------
namespace T11
{
    class Payment { public virtual void Pay(decimal amount) => Console.WriteLine($"Оплата {amount}"); }
    class CashPayment : Payment { public override void Pay(decimal a) => Console.WriteLine($"Оплачено наличными: {a}"); }
    class CardPayment : Payment { public override void Pay(decimal a) => Console.WriteLine($"Оплачено картой: {a} (комиссия 1%)"); }
    class CryptoPayment : Payment { public override void Pay(decimal a) => Console.WriteLine($"Оплачено криптовалютой: {a} (подтверждение блокчейна)"); }

    static class Demo
    {
        public static void Run()
        {
            Payment[] list = { new CashPayment(), new CardPayment(), new CryptoPayment() };
            foreach (var p in list) p.Pay(100);
        }
    }
}

// ---------- 12. Уведомления ----------
namespace T12
{
    class Notification { public virtual void Send(string text) => Console.WriteLine(text); }
    class EmailNotification : Notification { public override void Send(string t) => Console.WriteLine($"[Email] {t}"); }
    class SmsNotification : Notification { public override void Send(string t) => Console.WriteLine($"[SMS] {t}"); }
    class PushNotification : Notification { public override void Send(string t) => Console.WriteLine($"[Push] {t}"); }

    static class Demo
    {
        public static void Run()
        {
            Notification[] list = { new EmailNotification(), new SmsNotification(), new PushNotification() };
            foreach (var n in list) n.Send("Ваш заказ отправлен");
        }
    }
}

// ---------- 13. Доставка ----------
namespace T13
{
    class Delivery
    {
        public virtual decimal CalculatePrice(double weightKg) => 0;
    }
    class CourierDelivery : Delivery
    {
        public override decimal CalculatePrice(double w) => 500 + (decimal)w * 50;
    }
    class PostDelivery : Delivery
    {
        public override decimal CalculatePrice(double w) => 200 + (decimal)w * 20;
    }
    class ExpressDelivery : Delivery
    {
        public override decimal CalculatePrice(double w) => 1000 + (decimal)w * 100;
    }

    static class Demo
    {
        public static void Run()
        {
            Delivery[] list = { new CourierDelivery(), new PostDelivery(), new ExpressDelivery() };
            foreach (var d in list) Console.WriteLine($"{d.GetType().Name}: {d.CalculatePrice(3)} (3 кг)");
        }
    }
}

// ---------- 14. Система скидок ----------
namespace T14
{
    abstract class Discount { public abstract decimal CalculateDiscount(decimal price); }
    class StudentDiscount : Discount { public override decimal CalculateDiscount(decimal p) => p * 0.10m; }
    class VipDiscount : Discount { public override decimal CalculateDiscount(decimal p) => p * 0.20m; }
    class SeasonalDiscount : Discount { public override decimal CalculateDiscount(decimal p) => p * 0.15m; }

    static class Demo
    {
        public static void Run()
        {
            decimal price = 1000;
            Discount[] list = { new StudentDiscount(), new VipDiscount(), new SeasonalDiscount() };
            foreach (var d in list)
                Console.WriteLine($"{d.GetType().Name}: скидка {d.CalculateDiscount(price)}, итого {price - d.CalculateDiscount(price)}");
        }
    }
}

// ---------- 15. Роботы ----------
namespace T15
{
    class Robot { public virtual void PerformTask() => Console.WriteLine("Робот выполняет задачу"); }
    class CleaningRobot : Robot { public override void PerformTask() => Console.WriteLine("Робот-уборщик моет пол"); }
    class SecurityRobot : Robot { public override void PerformTask() => Console.WriteLine("Робот-охранник патрулирует территорию"); }
    class DeliveryRobot : Robot { public override void PerformTask() => Console.WriteLine("Робот-курьер везёт посылку"); }

    static class Demo
    {
        public static void Run()
        {
            Robot[] list = { new CleaningRobot(), new SecurityRobot(), new DeliveryRobot() };
            foreach (var r in list) r.PerformTask();
        }
    }
}

// ---------- 16. Геометрические фигуры ----------
namespace T16
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    class Circle : Shape
    {
        double r;
        public Circle(double r) { this.r = r; }
        public override double GetArea() => Math.PI * r * r;
        public override double GetPerimeter() => 2 * Math.PI * r;
    }
    class Rectangle : Shape
    {
        protected double w, h;
        public Rectangle(double w, double h) { this.w = w; this.h = h; }
        public override double GetArea() => w * h;
        public override double GetPerimeter() => 2 * (w + h);
    }
    class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }
    class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
        public override double GetPerimeter() => a + b + c;
        public override double GetArea()
        {
            double p = GetPerimeter() / 2; // формула Герона
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    static class Demo
    {
        public static void Run()
        {
            Shape[] shapes = { new Circle(2), new Rectangle(3, 4), new Square(5), new Triangle(3, 4, 5) };
            foreach (var s in shapes)
                Console.WriteLine($"{s.GetType().Name}: площадь = {s.GetArea():F2}, периметр = {s.GetPerimeter():F2}");
        }
    }
}

// ---------- 17. Система транспорта ----------
namespace T17
{
    abstract class Transport { public abstract double GetSpeed(); }
    class Car : Transport { public override double GetSpeed() => 90; }
    class Train : Transport { public override double GetSpeed() => 160; }
    class Airplane : Transport { public override double GetSpeed() => 850; }
    class Ship : Transport { public override double GetSpeed() => 40; }

    static class Demo
    {
        public static void Run()
        {
            List<Transport> list = new() { new Car(), new Train(), new Airplane(), new Ship() };
            foreach (var t in list) Console.WriteLine($"{t.GetType().Name}: {t.GetSpeed()} км/ч");
        }
    }
}

// ---------- 18. Зарплата сотрудников ----------
namespace T18
{
    abstract class Employee
    {
        public string Name { get; }
        protected Employee(string name) { Name = name; }
        public abstract decimal CalculateSalary();
    }
    class Manager : Employee
    {
        public Manager(string n) : base(n) { }
        public override decimal CalculateSalary() => 3500;
    }
    class Developer : Employee
    {
        public Developer(string n) : base(n) { }
        public override decimal CalculateSalary() => 4500;
    }
    class SalesManager : Employee
    {
        decimal sales;
        public SalesManager(string n, decimal sales) : base(n) { this.sales = sales; }
        public override decimal CalculateSalary() => 2000 + sales * 0.05m; // оклад + 5% с продаж
    }

    static class Demo
    {
        public static void Run()
        {
            List<Employee> list = new() { new Manager("Алия"), new Developer("Ерсултан"), new SalesManager("Бек", 20000) };
            foreach (var e in list) Console.WriteLine($"{e.Name} ({e.GetType().Name}): {e.CalculateSalary()}");
            Console.WriteLine($"Всего: {list.Sum(e => e.CalculateSalary())}");
        }
    }
}

// ---------- 19. Интернет-магазин ----------
namespace T19
{
    class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public Product(string name, decimal price) { Name = name; Price = price; }
        public virtual decimal GetFinalPrice() => Price;
    }
    class Electronics : Product
    {
        public Electronics(string n, decimal p) : base(n, p) { }
        public override decimal GetFinalPrice() => Price * 1.20m; // НДС 20%
    }
    class Food : Product
    {
        public Food(string n, decimal p) : base(n, p) { }
        public override decimal GetFinalPrice() => Price * 1.05m; // НДС 5%
    }
    class Clothing : Product
    {
        public Clothing(string n, decimal p) : base(n, p) { }
        public override decimal GetFinalPrice() => Price * 0.90m; // скидка 10%
    }

    static class Demo
    {
        public static void Run()
        {
            Product[] list = { new Electronics("Наушники", 100), new Food("Хлеб", 10), new Clothing("Футболка", 50) };
            foreach (var p in list) Console.WriteLine($"{p.Name}: {p.Price} -> {p.GetFinalPrice()}");
        }
    }
}

// ---------- 20. Система сообщений ----------
namespace T20
{
    interface IMessageSender { void SendMessage(string message); }
    class EmailSender : IMessageSender { public void SendMessage(string m) => Console.WriteLine($"Email: {m}"); }
    class SmsSender : IMessageSender { public void SendMessage(string m) => Console.WriteLine($"SMS: {m}"); }
    class TelegramSender : IMessageSender { public void SendMessage(string m) => Console.WriteLine($"Telegram: {m}"); }

    static class Demo
    {
        public static void Run()
        {
            List<IMessageSender> senders = new() { new EmailSender(), new SmsSender(), new TelegramSender() };
            foreach (var s in senders) s.SendMessage("Привет!");
        }
    }
}
