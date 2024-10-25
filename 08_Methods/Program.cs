using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //başına sonuna () alır.
            //sollarında Mor renk küp alılarlar
            //Geriye Değer Döndürmeyen Metotlar -> Void 
            //Customer --> Listele, ekle, sil, güncelle

            //void CustomerList()

            //{
            //    Console.WriteLine("Enes inan");
            //    Console.WriteLine("Hatice Toprak");
            //    Console.WriteLine("Lionel Messi");
            //    Console.WriteLine("Ayşe Fatma");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Enes İnan");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşrteri: " + name + " " + surName);
            //}
            //CustomerCard("Ekrem", "İnan");
            //CustomerCard("Zeynep", "Alkan");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //String CustomerName()
            //{
            //    return "Hakan Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Pehlivan";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));

            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 90));
            //Console.WriteLine(sum(45, 15));
            //Console.WriteLine(sum(23, 52));
            //Console.WriteLine(sum(27, 100));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. Tebrikler! " + "Ortalaması:" + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı maalesef geçemedi. " + "Ortalaması:" + result;
            //    }

            //}

            //Console.WriteLine(ExamResult("Ömer", 50, 66, 44));
            //Console.WriteLine(ExamResult("Ali", 70, 46, 80));
            //Console.WriteLine(ExamResult("Ayşe", 30, 40, 52));

            #endregion

            Console.Read();
        }
    }
}
