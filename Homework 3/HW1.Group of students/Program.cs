using System;
using Test_workspace;

namespace WorkBench
{
    /// <summary>
    /// Homework №3
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Group k26 = new Group("K-26");     
            Student Maevskiy = new GoodStudent("Lubomyr");
            Student Formakidova = new GoodStudent("Dina");
            Student Kasprukov = new BadStudent("Artem");
            k26.AddStudent(Maevskiy);
            k26.AddStudent(Formakidova);
            k26.AddStudent(Kasprukov);

            Maevskiy.Study();
            Kasprukov.Study();
            Formakidova.Study();

            Console.WriteLine("=======================================================");
            k26.GetInfo();
            Console.WriteLine("=======================================================");
            k26.GetFullInfo();
            Console.WriteLine("=======================================================");
            
            Group k35 = new Group("K-35");
            Student Koplenko = new GoodStudent("Sasha");
            Student Levadniy = new GoodStudent("Nikolay");
            Student Stutsyuk = new GoodStudent("Andrey");
            k35.AddStudent(Koplenko);
            k35.AddStudent(Levadniy);
            k35.AddStudent(Stutsyuk);

            Stutsyuk.Study();
            Levadniy.Study();
            Koplenko.Study();

            k35.GetInfo();
            Console.WriteLine("=======================================================");
            k35.GetFullInfo();
            Console.WriteLine("=======================================================");

            k26.AddGroupStudents(k35);

            k26.GetInfo();
            Console.WriteLine("=======================================================");
            k26.GetFullInfo();
            Console.WriteLine("=======================================================");
        }
    }
}
