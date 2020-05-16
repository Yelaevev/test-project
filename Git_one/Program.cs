using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_one
{
    class Program
    {
        class learning_room// личный кабинет учащегося
        {
            protected string person_name;// ФИО ученика
            private string course_name;// название курса
            private int theme_number;//количество тем, рассматриваемыхна курсе курса
            private int study_progress;// процент выполнения заданий
            private double time_of_task;// время затраченное на выполнения задания
            private double pay_level;// чисдл , показывающее долг по оплате
            private string i_theme_name;//название i-той темы курса, сколько тем, столько и переменных
            private bool i_theme_acces;//доступ к изучению i-той темы курса
                                       /// <summary>
                                       /// 


            // Сергей Игоревич, вот смотрите метод, задал как обычный метод класса "public void getTheme_name ()" но только без скобок(), на них ругается

            public string getTheme_name()
            {
                return i_theme_name;   //    но как сделать так, чтобы get обработал как надо, в рамках информации с заняти  и выдал значение  значение атрибута, я не понимаю 

            }

            // тоже задал как обычный метод класса
            public void setTheme_name(string name)
            {
                i_theme_name = name;
            }

            public string Person_name
            {
                get { return person_name; }
                set { this.person_name = value; }
            }
            // Может мне не хвататет опыта, чтобы правильно понять  ваше ц.у. "для изменения значений обычно делают явные отдельные методы, так называемые геттеры-сеттеры
            //(get — выдаёт значение атрибута, set - задаёт новое значение атрибуту). 
            // Например, getName(), setName(string name)."
            // Чувствую себя дураком каким-то, но как реализовать метод геттер-сеттер, используя парадигму обычных методов класса не могу понять,
            // все варианты испробовал



            //public string getName
            //{
            //    get { return person_name; }
            //    set { person_name = value; }
            //}
            public string getCourse_name
            {
                get { return course_name; }
                set { course_name = value; }
            }
            public bool getI_theme_acces
            {
                get { return i_theme_acces; }
                set { i_theme_acces = value; }
            }
            public learning_room()   //(string i, bool a, int s, double tt, double pl)
            {
                person_name = " knyaz Bolkonskiy";
                course_name = "war&peace";
                theme_number = 5;
                study_progress = 13;
                time_of_task = 15;
                pay_level = 1300;
                i_theme_name = "borodino";
                i_theme_acces = false;
            }

            public void dolg()
            {
                if (pay_level > 0)
                {
                    Console.WriteLine($"pogasite dolg v razmere {pay_level}");
                }
                else { Console.WriteLine($"dolga net"); }
            }
            public void efficiency(double task_time)
            {
                time_of_task = task_time;

            }
            public void deduction()
            {
                course_name = "none";
                person_name = "nobody";
                Console.WriteLine(" student otchislen");
            }
            public void progress(int progress)
            {
                study_progress = study_progress + progress;

            }
            public void acces(string i_theme_name)
            {
                i_theme_acces = true;
                Console.WriteLine($"dostup k teme {i_theme_name} otkriyt");
            }
            public void info_course_test()
            { Console.WriteLine($"pogasite dolg v razmere {course_name}"); }

        }

        class learning_room_info : learning_room // вывод приватных полей класса learning_room
        {

            public learning_room vyvod;

            public void info_pearson()
            {
                Console.WriteLine($"imya studenta {vyvod.Person_name}");
            }

            public void info_course()
            { Console.WriteLine($"nazvanie temy {vyvod.getTheme_name()}"); }

            //public void info_acces()
            //{ Console.WriteLine($"dostup k teme kursa otkryt {vyvod.getI_theme_acces}"); }



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            learning_room botan = new learning_room();
            learning_room_info botan_info = new learning_room_info();
            botan_info.vyvod = botan;
            botan_info.info_pearson();

            botan_info.info_course();

            botan.setTheme_name("korona");
            botan.Person_name = "Alex the 1";
            botan_info.vyvod = botan;

            botan_info.info_course();
            botan_info.info_pearson();
        }
    }
}
