// ---------- 1. Животные ----------
namespace T01
{
    class Animal { public virtual void MakeSound() => Console.WriteLine("Животное издаёт звук"); }
    class Dog : Animal { public override void MakeSound() => Console.WriteLine("Гав!"); }
    class Cat : Animal { public override void MakeSound() => Console.WriteLine("Мяу!"); }
    class Cow : Animal { public override void MakeSound() => Console.WriteLine("Му!"); }

    static class Demo
    {
        public static void Run()
        {
            Animal[] animals = { new Dog(), new Cat(), new Cow() };
            foreach (var a in animals) a.MakeSound();
        }
    }
}

// ---------- 2. Транспорт ----------
namespace T02
{
    class Vehicle { public virtual void Move() => Console.WriteLine("Транспорт движется"); }
    class Car : Vehicle { public override void Move() => Console.WriteLine("Машина едет по дороге"); }
    class Bike : Vehicle { public override void Move() => Console.WriteLine("Велосипед едет, крутя педали"); }
    class Bus : Vehicle { public override void Move() => Console.WriteLine("Автобус едет по маршруту"); }

    static class Demo
    {
        public static void Run()
        {
            Vehicle[] list = { new Car(), new Bike(), new Bus() };
            foreach (var v in list) v.Move();
        }
    }
}

// ---------- 3. Работники ----------
namespace T03
{
    class Employee { public virtual void Work() => Console.WriteLine("Сотрудник работает"); }
    class Programmer : Employee { public override void Work() => Console.WriteLine("Программист пишет код"); }
    class Teacher : Employee { public override void Work() => Console.WriteLine("Учитель ведёт урок"); }
    class Doctor : Employee { public override void Work() => Console.WriteLine("Врач лечит пациентов"); }

    static class Demo
    {
        public static void Run()
        {
            Employee[] list = { new Programmer(), new Teacher(), new Doctor() };
            foreach (var e in list) e.Work();
        }
    }
}

// ---------- 4. Фигуры ----------
namespace T04
{
    class Shape { public virtual double GetArea() => 0; }
    class Rectangle : Shape
    {
        double w, h;
        public Rectangle(double w, double h) { this.w = w; this.h = h; }
        public override double GetArea() => w * h;
    }
    class Circle : Shape
    {
        double r;
        public Circle(double r) { this.r = r; }
        public override double GetArea() => Math.PI * r * r;
    }
    class Triangle : Shape
    {
        double b, h;
        public Triangle(double b, double h) { this.b = b; this.h = h; }
        public override double GetArea() => 0.5 * b * h;
    }

    static class Demo
    {
        public static void Run()
        {
            Shape[] shapes = { new Rectangle(3, 4), new Circle(2), new Triangle(6, 5) };
            foreach (var s in shapes) Console.WriteLine($"{s.GetType().Name}: площадь = {s.GetArea():F2}");
        }
    }
}

// ---------- 5. Банковские счета ----------
namespace T05
{
    class BankAccount
    {
        public decimal Balance { get; }
        public BankAccount(decimal balance) { Balance = balance; }
        public virtual decimal CalculateInterest() => 0;
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal b) : base(b) { }
        public override decimal CalculateInterest() => Balance * 0.05m; // 5%
    }
    class BusinessAccount : BankAccount
    {
        public BusinessAccount(decimal b) : base(b) { }
        public override decimal CalculateInterest() => Balance * 0.02m; // 2%
    }

    static class Demo
    {
        public static void Run()
        {
            BankAccount[] accs = { new SavingsAccount(10000), new BusinessAccount(50000) };
            foreach (var a in accs) Console.WriteLine($"{a.GetType().Name}: баланс {a.Balance}, проценты {a.CalculateInterest()}");
        }
    }
}

// ---------- 6. Игроки ----------
namespace T06
{
    class Player { public virtual void Attack() => Console.WriteLine("Игрок атакует"); }
    class Warrior : Player { public override void Attack() => Console.WriteLine("Воин бьёт мечом"); }
    class Archer : Player { public override void Attack() => Console.WriteLine("Лучник стреляет из лука"); }
    class Mage : Player { public override void Attack() => Console.WriteLine("Маг бросает огненный шар"); }

    static class Demo
    {
        public static void Run()
        {
            Player[] team = { new Warrior(), new Archer(), new Mage() };
            foreach (var p in team) p.Attack();
        }
    }
}

// ---------- 7. Устройства ----------
namespace T07
{
    class Device { public virtual void TurnOn() => Console.WriteLine("Устройство включено"); }
    class Phone : Device { public override void TurnOn() => Console.WriteLine("Телефон включается, загрузка ОС..."); }
    class Computer : Device { public override void TurnOn() => Console.WriteLine("Компьютер включается, проверка BIOS..."); }
    class Television : Device { public override void TurnOn() => Console.WriteLine("Телевизор включается, показывает картинку"); }

    static class Demo
    {
        public static void Run()
        {
            Device[] devices = { new Phone(), new Computer(), new Television() };
            foreach (var d in devices) d.TurnOn();
        }
    }
}

// ---------- 8. Музыкальные инструменты ----------
namespace T08
{
    class Instrument { public virtual void Play() => Console.WriteLine("Инструмент играет"); }
    class Guitar : Instrument { public override void Play() => Console.WriteLine("Гитара: бренчит струнами"); }
    class Piano : Instrument { public override void Play() => Console.WriteLine("Пианино: звучат клавиши"); }
    class Drums : Instrument { public override void Play() => Console.WriteLine("Барабаны: бум-бум-бах!"); }

    static class Demo
    {
        public static void Run()
        {
            Instrument[] list = { new Guitar(), new Piano(), new Drums() };
            foreach (var i in list) i.Play();
        }
    }
}

// ---------- 9. Птицы ----------
namespace T09
{
    class Bird
    {
        public virtual void Fly() => Console.WriteLine("Птица летит");
    }
    class Eagle : Bird { public override void Fly() => Console.WriteLine("Орёл парит высоко в небе"); }
    class Sparrow : Bird { public override void Fly() => Console.WriteLine("Воробей быстро машет крыльями и летит"); }
    class Penguin : Bird { public override void Fly() => Console.WriteLine("Пингвин не умеет летать, он плавает"); }

    static class Demo
    {
        public static void Run()
        {
            Bird[] birds = { new Eagle(), new Penguin(), new Sparrow() };
            foreach (var b in birds) b.Fly();
        }
    }
}

// ---------- 10. Сотрудники и зарплата ----------
namespace T10
{
    class Employee
    {
        public string Name { get; }
        public Employee(string name) { Name = name; }
        public virtual decimal CalculateSalary() => 0;
    }
    class Manager : Employee
    {
        public Manager(string n) : base(n) { }
        public override decimal CalculateSalary() => 3000 + 500; // оклад + бонус
    }
    class Developer : Employee
    {
        public Developer(string n) : base(n) { }
        public override decimal CalculateSalary() => 4000;
    }
    class Intern : Employee
    {
        public Intern(string n) : base(n) { }
        public override decimal CalculateSalary() => 800;
    }

    static class Demo
    {
        public static void Run()
        {
            Employee[] list = { new Manager("Алия"), new Developer("Ерсултан"), new Intern("Дана") };
            foreach (var e in list) Console.WriteLine($"{e.Name} ({e.GetType().Name}): {e.CalculateSalary()}");
        }
    }
}
