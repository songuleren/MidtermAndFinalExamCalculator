using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikMidtermFinalExamCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
            1- Kullanıcıdan Girilen Öğrencinin Adı, Soyadı, okuduğu bölüm, okul numarası Farklı değişkenlerde tutulacak.
            2- Kullanıcıdan girilen vize ve final ve ortalama notunu, Öğrencinin Adını, okuduğu bölümü, okul numarasını ekrana yazdıran program. 
            3- Yazılan projeyi, githuba Repository adını MidtermAndFinalExamCalculator şeklinde ayarlayıp githuba yüklemenizi istiyorum. 
             
            */
           /* string StudentName;
            string StudentSurname;
            string StudentDepartment;
            string StudentSchoolNumber;
            */

            string StudentName, StudentSurname, StudentDepartment, StudentSchoolNumber;

            double MidtermExam, FinalExam, Average = 0;

            Console.WriteLine("Öğrenci Adı:");
            StudentName = Console.ReadLine();
            Console.WriteLine("Öğrenci Soyadı:");
            StudentSurname = Console.ReadLine();
            Console.WriteLine("Öğrencinin Bölümü:");
            StudentDepartment=Console.ReadLine();
            Console.WriteLine("Öğrencinin Okul Numarası:");
            StudentSchoolNumber = Console.ReadLine();
            Console.WriteLine("Öğrencinin Vize Notunu Girin:");
            MidtermExam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Öğrencinin Final Notunu Girin:");
            FinalExam = Convert.ToDouble(Console.ReadLine());
            Average = MidtermExam * 0.4 + FinalExam * 0.6;
            Console.WriteLine("Ortalama: "+Average );

            Console.ReadKey();




                

        }
    }
}
