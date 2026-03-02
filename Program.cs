using System.Security.Cryptography.X509Certificates;

namespace Aluminewaya_Chashka
{
    public class Program
    {
        public static void Main()
        {
            Pribori Kolpachok = new Pribori(false, "Громко постукиванием", "Форсфор");
            Vilka Bilibaka = new Vilka(4, 6, true, "Молча", "Уран");
            Pribori Durshlak = new Vilka(10, 15, true, "Позвякивание", "Метало-заменитель");
            //Bilibaka.Print();
            //Kolpachok.Print();
            //Console.WriteLine(Bilibaka.Kakestttt);
            Bilibaka.Print();
            Kolpachok.Print();
            Console.WriteLine(Bilibaka.Kakestttt);
            Kolpachok.Vzaimodeystvie(Bilibaka);

            Durshlak.Print();
            Console.WriteLine(Durshlak.StudentkaMolodenkaya);
            Console.WriteLine(Durshlak.Kakestttt);
            Console.WriteLine(Durshlak.Mamamama);
            Console.WriteLine(Durshlak.ToString());
            Durshlak.Vzaimodeystvie(Durshlak);
            Pribori.ShowTotalExperiments();

            Console.WriteLine(Kolpachok.ToString());
            Console.WriteLine(Bilibaka.ToString());
            Kolpachok.ProverkaKachestva();
            Kolpachok.TestNaHrupkost();

            Pribori.ShowTotalExperiments();

            //Console.WriteLine(Bilibaka.ToString());
        }
    }

    public class Pribori
    {
        private bool IsExist;
        private string KakEst;
        private string Material;
        private static int totalExperiments = 0;
        public static int TotalExperiments => totalExperiments;

        public bool StudentkaMolodenkaya => IsExist;
        public string Kakestttt => KakEst;
        public string Mamamama => Material;

        public Pribori(bool existing, string kakest, string material)
        {
            IsExist = existing;
            KakEst = kakest;
            Material = material;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Студентка?Молоденькая? {StudentkaMolodenkaya}. Че как двигаешься по жизни {Kakestttt}. Твои родители случайно не {Mamamama}? Тогда почему ты такая яркая?");
        }

        public void ProverkaKachestva()
        {
            Console.WriteLine($"Проверяем качество материала {Material}... Результат: барахло ещё то!");
        }

        public void Vzaimodeystvie(Pribori drugoyPribor)
        {
            totalExperiments++;
            Console.WriteLine($"Прибор 1: материал {Material}, звук {KakEst}");
            Console.WriteLine($"Прибор 2: материал {drugoyPribor.Mamamama}, звук {drugoyPribor.Kakestttt}");

            if (this.IsExist && drugoyPribor.StudentkaMolodenkaya)
            {
                Console.WriteLine("Оба прибора существуют! Устраиваем джазовый концерт!");
                Console.WriteLine($"♫ {KakEst} + {drugoyPribor.Kakestttt} = КАКАФОНИЯ! ♫");
            }
            else
            {
                Console.WriteLine("Один из приборов не существует... Тишина...");
            }
        }
        public static void ShowTotalExperiments()
        {
            Console.WriteLine($"Всего проведено экспериментов: {totalExperiments}");
        }

        public override string ToString()
        {
            return $"Прибор из {Material}, который {KakEst}. Существует: {IsExist}";
        }


        protected virtual void AnalizProishozhdeniya()
        {
            Console.WriteLine($"Анализируем происхождение материала {Material}...");
            Console.WriteLine("Похоже, это месторождение где-то в караганде мира");
        }

        public void TestNaHrupkost()
        {
            if (IsExist)
            {
                Console.WriteLine("Тест на хрупкость пройден! Ещё послужит!");
            }
            else
            {
                Console.WriteLine("Тест провален! Рассыпалось в труху!");
            }
        }

        protected void Sertifikatsiya()
        {
            Console.WriteLine("Проводим сертификацию прибора...");
            Console.WriteLine("Сертификат соответствия выдан на 5 лет!");
        }
    }

    public class Vilka : Pribori
    {
        private int KolichestvoZupchikov;
        private int KolichestvoNamotannihMakaron;
        public int kokoko => KolichestvoZupchikov;
        public int Kolmamama => KolichestvoNamotannihMakaron;


        public Vilka(int kolzub, int kolmak, bool existing, string kakestbebebe, string material) : base(existing, kakestbebebe, material)
        {
            KolichestvoZupchikov = kolzub;
            KolichestvoNamotannihMakaron = kolmak;
        }

        public override void Print()
        {
            Console.WriteLine("Вы позвонили по телефону доверия. ♫♮♫b#♫ b♫‾b♫");
            Console.WriteLine($"Сколько можно ударить в глаз? {kokoko}. А если подумать? {Kolmamama}. Чё как кушается? {Kakestttt}. Твои родители случайно не {Mamamama}? Тогда почему ты такая взрывная?");
        }

        protected override void AnalizProishozhdeniya()
        {
            if (KolichestvoNamotannihMakaron > 5)
            {
                Console.WriteLine("Много макарон! Вилка счастлива!");
            }
            else
            {
                Console.WriteLine("Мало макарон... Вилка грустит...");
            }
        }

    }
}
