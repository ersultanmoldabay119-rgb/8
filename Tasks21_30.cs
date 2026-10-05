// ---------- 21. Платёжная система ----------
namespace T21
{
    interface IPaymentMethod
    {
        void Pay(decimal amount);
        void Refund(decimal amount);
    }
    class BankCard : IPaymentMethod
    {
        public void Pay(decimal a) => Console.WriteLine($"Банковская карта: списано {a}");
        public void Refund(decimal a) => Console.WriteLine($"Банковская карта: возврат {a} (1-3 дня)");
    }
    class PayPal : IPaymentMethod
    {
        public void Pay(decimal a) => Console.WriteLine($"PayPal: оплачено {a}");
        public void Refund(decimal a) => Console.WriteLine($"PayPal: возврат {a} на аккаунт");
    }
    class CryptoWallet : IPaymentMethod
    {
        public void Pay(decimal a) => Console.WriteLine($"Криптокошелёк: переведено {a}");
        public void Refund(decimal a) => Console.WriteLine($"Криптокошелёк: обратный перевод {a}");
    }

    static class Demo
    {
        public static void Run()
        {
            IPaymentMethod[] methods = { new BankCard(), new PayPal(), new CryptoWallet() };
            foreach (var m in methods) { m.Pay(100); m.Refund(100); }
        }
    }
}

// ---------- 22. Система сотрудников компании ----------
namespace T22
{
    abstract class Employee
    {
        public string Name { get; }
        protected Employee(string name) { Name = name; }
        public abstract void Work();
        public abstract decimal CalculateSalary();
    }
    class Developer : Employee
    {
        public Developer(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} пишет код");
        public override decimal CalculateSalary() => 4500;
    }
    class Manager : Employee
    {
        public Manager(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} руководит командой");
        public override decimal CalculateSalary() => 4000;
    }
    class Designer : Employee
    {
        public Designer(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} рисует макеты");
        public override decimal CalculateSalary() => 3000;
    }
    class Tester : Employee
    {
        public Tester(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} ищет баги");
        public override decimal CalculateSalary() => 2800;
    }

    static class Demo
    {
        public static void Run()
        {
            List<Employee> staff = new() { new Developer("Ерсултан"), new Manager("Алия"), new Designer("Дана"), new Tester("Бек") };
            foreach (var e in staff) { e.Work(); Console.WriteLine($"  зарплата: {e.CalculateSalary()}"); }
        }
    }
}

// ---------- 23. Игра — персонажи ----------
namespace T23
{
    abstract class Character
    {
        public string Name { get; }
        protected Character(string name) { Name = name; }
        public abstract void Attack();
    }
    class Warrior : Character
    {
        public Warrior(string n) : base(n) { }
        public override void Attack() => Console.WriteLine($"{Name} (воин) рубит мечом: 30 урона");
    }
    class Mage : Character
    {
        public Mage(string n) : base(n) { }
        public override void Attack() => Console.WriteLine($"{Name} (маг) колдует молнию: 40 урона");
    }
    class Archer : Character
    {
        public Archer(string n) : base(n) { }
        public override void Attack() => Console.WriteLine($"{Name} (лучник) стреляет: 25 урона");
    }
    class Assassin : Character
    {
        public Assassin(string n) : base(n) { }
        public override void Attack() => Console.WriteLine($"{Name} (убийца) бьёт в спину: 50 урона");
    }

    static class Demo
    {
        public static void Run()
        {
            List<Character> team = new() { new Warrior("Артур"), new Mage("Мерлин"), new Archer("Робин"), new Assassin("Тень") };
            foreach (var c in team) c.Attack();
        }
    }
}

// ---------- 24. Больница ----------
namespace T24
{
    abstract class MedicalWorker { public abstract void TreatPatient(); }
    class Doctor : MedicalWorker { public override void TreatPatient() => Console.WriteLine("Врач ставит диагноз и назначает лечение"); }
    class Surgeon : MedicalWorker { public override void TreatPatient() => Console.WriteLine("Хирург проводит операцию"); }
    class Nurse : MedicalWorker { public override void TreatPatient() => Console.WriteLine("Медсестра делает укол и измеряет давление"); }
    class Dentist : MedicalWorker { public override void TreatPatient() => Console.WriteLine("Стоматолог лечит зубы"); }

    static class Demo
    {
        public static void Run()
        {
            List<MedicalWorker> staff = new() { new Doctor(), new Surgeon(), new Nurse(), new Dentist() };
            foreach (var w in staff) w.TreatPatient();
        }
    }
}

// ---------- 25. Файловая система ----------
namespace T25
{
    abstract class File
    {
        public string Name { get; }
        protected File(string name) { Name = name; }
        public abstract void Open();
    }
    class TextFile : File
    {
        public TextFile(string n) : base(n) { }
        public override void Open() => Console.WriteLine($"{Name}: открыт в текстовом редакторе");
    }
    class ImageFile : File
    {
        public ImageFile(string n) : base(n) { }
        public override void Open() => Console.WriteLine($"{Name}: открыт в просмотрщике изображений");
    }
    class VideoFile : File
    {
        public VideoFile(string n) : base(n) { }
        public override void Open() => Console.WriteLine($"{Name}: открыт в видеоплеере");
    }
    class AudioFile : File
    {
        public AudioFile(string n) : base(n) { }
        public override void Open() => Console.WriteLine($"{Name}: открыт в аудиоплеере");
    }

    static class Demo
    {
        public static void Run()
        {
            List<File> files = new() { new TextFile("notes.txt"), new ImageFile("photo.png"), new VideoFile("movie.mp4"), new AudioFile("song.mp3") };
            foreach (var f in files) f.Open();
        }
    }
}

// ---------- 26. Система отчетов ----------
namespace T26
{
    interface IReport { void Generate(); }
    class SalesReport : IReport { public void Generate() => Console.WriteLine("Отчёт по продажам: выручка за месяц сформирована"); }
    class FinancialReport : IReport { public void Generate() => Console.WriteLine("Финансовый отчёт: доходы и расходы сформированы"); }
    class EmployeeReport : IReport { public void Generate() => Console.WriteLine("Отчёт по сотрудникам: список и часы работы сформированы"); }

    static class Demo
    {
        public static void Run()
        {
            List<IReport> reports = new() { new SalesReport(), new FinancialReport(), new EmployeeReport() };
            foreach (var r in reports) r.Generate();
        }
    }
}

// ---------- 27. Умный дом ----------
namespace T27
{
    abstract class SmartDevice
    {
        public string Name { get; }
        public bool IsOn { get; protected set; }
        protected SmartDevice(string name) { Name = name; }
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
    class SmartLight : SmartDevice
    {
        public SmartLight() : base("Свет") { }
        public override void TurnOn() { IsOn = true; Console.WriteLine("Свет включён"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Свет выключен"); }
    }
    class SmartTV : SmartDevice
    {
        public SmartTV() : base("Телевизор") { }
        public override void TurnOn() { IsOn = true; Console.WriteLine("Телевизор включён"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Телевизор выключен"); }
    }
    class SmartThermostat : SmartDevice
    {
        public SmartThermostat() : base("Термостат") { }
        public override void TurnOn() { IsOn = true; Console.WriteLine("Термостат поддерживает 22°C"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Термостат отключён"); }
    }
    class SecurityCamera : SmartDevice
    {
        public SecurityCamera() : base("Камера") { }
        public override void TurnOn() { IsOn = true; Console.WriteLine("Камера начала запись"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Камера остановила запись"); }
    }

    // общий контроллер
    class HomeController
    {
        readonly List<SmartDevice> devices = new();
        public void Add(SmartDevice d) => devices.Add(d);
        public void TurnAllOn() { foreach (var d in devices) d.TurnOn(); }
        public void TurnAllOff() { foreach (var d in devices) d.TurnOff(); }
    }

    static class Demo
    {
        public static void Run()
        {
            var home = new HomeController();
            home.Add(new SmartLight());
            home.Add(new SmartTV());
            home.Add(new SmartThermostat());
            home.Add(new SecurityCamera());
            Console.WriteLine("-- включаем всё --");
            home.TurnAllOn();
            Console.WriteLine("-- выключаем всё --");
            home.TurnAllOff();
        }
    }
}

// ---------- 28. Система заказов ----------
namespace T28
{
    abstract class Order
    {
        protected decimal Amount { get; }
        protected Order(decimal amount) { Amount = amount; }
        public abstract decimal CalculateTotal();
    }
    class FoodOrder : Order
    {
        public FoodOrder(decimal a) : base(a) { }
        public override decimal CalculateTotal() => Amount + 300; // + доставка
    }
    class ClothingOrder : Order
    {
        public ClothingOrder(decimal a) : base(a) { }
        public override decimal CalculateTotal() => Amount * 0.9m; // скидка 10%
    }
    class ElectronicsOrder : Order
    {
        public ElectronicsOrder(decimal a) : base(a) { }
        public override decimal CalculateTotal() => Amount * 1.2m + 500; // НДС + страховка
    }

    static class Demo
    {
        public static void Run()
        {
            List<Order> orders = new() { new FoodOrder(2000), new ClothingOrder(10000), new ElectronicsOrder(50000) };
            foreach (var o in orders) Console.WriteLine($"{o.GetType().Name}: итого {o.CalculateTotal()}");
        }
    }
}

// ---------- 29. Такси-сервис ----------
namespace T29
{
    interface IRide
    {
        void StartRide();
        decimal CalculateCost(double km);
    }
    class EconomyRide : IRide
    {
        public void StartRide() => Console.WriteLine("Поездка Эконом началась");
        public decimal CalculateCost(double km) => 300 + (decimal)km * 80;
    }
    class ComfortRide : IRide
    {
        public void StartRide() => Console.WriteLine("Поездка Комфорт началась (кондиционер, вода)");
        public decimal CalculateCost(double km) => 500 + (decimal)km * 120;
    }
    class BusinessRide : IRide
    {
        public void StartRide() => Console.WriteLine("Поездка Бизнес началась (премиум-авто)");
        public decimal CalculateCost(double km) => 1000 + (decimal)km * 200;
    }

    static class Demo
    {
        public static void Run()
        {
            IRide[] rides = { new EconomyRide(), new ComfortRide(), new BusinessRide() };
            foreach (var r in rides)
            {
                r.StartRide();
                Console.WriteLine($"  стоимость за 10 км: {r.CalculateCost(10)}");
            }
        }
    }
}

// ---------- 30. Мини-система интернет-магазина ----------
namespace T30
{
    interface IDiscount { decimal Apply(decimal price); }
    class NoDiscount : IDiscount { public decimal Apply(decimal p) => p; }
    class PercentDiscount : IDiscount
    {
        readonly decimal percent;
        public PercentDiscount(decimal percent) { this.percent = percent; }
        public decimal Apply(decimal p) => p * (1 - percent / 100);
    }
    class FixedDiscount : IDiscount
    {
        readonly decimal amount;
        public FixedDiscount(decimal amount) { this.amount = amount; }
        public decimal Apply(decimal p) => Math.Max(0, p - amount);
    }

    abstract class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public IDiscount Discount { get; }
        protected Product(string name, decimal price, IDiscount? discount = null)
        {
            Name = name; Price = price; Discount = discount ?? new NoDiscount();
        }
        // налог/надбавка зависит от типа товара — определяется полиморфно, без if/switch
        protected abstract decimal ApplyTax(decimal price);
        public abstract string Category { get; }
        public decimal GetFinalPrice() => ApplyTax(Discount.Apply(Price));
        public override string ToString() => $"[{Category}] {Name}: цена {Price}, итого {GetFinalPrice():F2}";
    }
    class Electronics : Product
    {
        public Electronics(string n, decimal p, IDiscount? d = null) : base(n, p, d) { }
        public override string Category => "Электроника";
        protected override decimal ApplyTax(decimal p) => p * 1.20m;
    }
    class Food : Product
    {
        public Food(string n, decimal p, IDiscount? d = null) : base(n, p, d) { }
        public override string Category => "Еда";
        protected override decimal ApplyTax(decimal p) => p * 1.05m;
    }
    class Clothing : Product
    {
        public Clothing(string n, decimal p, IDiscount? d = null) : base(n, p, d) { }
        public override string Category => "Одежда";
        protected override decimal ApplyTax(decimal p) => p * 1.10m;
    }

    static class Demo
    {
        public static void Run()
        {
            List<Product> cart = new()
            {
                new Electronics("Смартфон", 300000, new PercentDiscount(10)),
                new Food("Молоко", 500),
                new Clothing("Куртка", 20000, new FixedDiscount(2000)),
            };
            foreach (var p in cart) Console.WriteLine(p);
            Console.WriteLine($"ИТОГО: {cart.Sum(p => p.GetFinalPrice()):F2}");
        }
    }
}
