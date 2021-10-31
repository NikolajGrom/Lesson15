using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson15
{

    class Program
    {
        public static User CreateUser()
        {
          User user = new User();
          Console.WriteLine("Ваше имя");
          string str1 = Console.ReadLine();
          user.Name = str1;
          Console.WriteLine("Ваша фамилия");          
          string str2 = Console.ReadLine();
          user.SName = str2;
          Console.WriteLine("Ваш возраст");
          int  str3 = int.Parse( Console.ReadLine() );
          user.Age = str3;
          return user;
        }
        /*
        public static string WritingUserFile()
        {
       
        }
        */




        static void Main(string[] args)
        {
            #region Fail
                /*
            Console.WriteLine(" Создать фаил \n");

            Console.WriteLine("Ваше имя");
            string str1 = Console.ReadLine();
            
            Console.WriteLine("Ваша фамилия");          
            string str2 = Console.ReadLine();

            Console.WriteLine("Ваш возраст");
            string str3 = Console.ReadLine();
            */
            //записать в файл
            /*
            File.WriteAllText("text.txt", "Hello my C#\n");
            File.AppendAllText("text.txt", (str1));
            File.AppendAllText("text.txt", "\n---------------\n");
            File.AppendAllText("text.txt", (str2));
            File.AppendAllText("text.txt", "\n---------------\n");
            File.AppendAllText("text.txt", (str3));
            File.AppendAllText("text.txt", "\n---------------\n");
            */
            // считать текст в строку
            // System.Console.WriteLine(File.ReadAllText("text.txt"));
            //  считать текст в массив строк
            // File.ReadAllLines("text.txt").ToList().ForEach(Console.WriteLine);

            // File.Delete("text.txt");
            #endregion
            Console.WriteLine(" Создать users \n");
            List<User> users = new List<User>();
            
            users.Add(CreateUser());
            users.Add(CreateUser());
            users.Add(CreateUser());
           
            SaveUsers(users);

            Console.ReadLine();
        }


        static void SaveUsers(List<User> users)
        {
            foreach(User user in users){
                File.AppendAllText("text.txt", user.ToString());
                File.AppendAllText("text.txt", new string('=', 12));
                File.AppendAllText("text.txt", "\n");

            }
        }
        static List<User>  ReadingFromFile(string path_to_file)
        {
            List<User> users = new List<User>();
            string [] data = File.ReadAllLines(path_to_file);

           for (int i = 0; i < data.Length; i+=4)
           {
               if( i % 4 == 0 && data[i][0] != '\n')
                {
                    users.Add(new User(data[i].Split(": ")[1], data[i + 1].Split(": ")[1], int.Parse(data[i + 2].Split(": ")[1]) ) );
                }
           }

            return users;
        }


    }
}
