using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DbConnectionExample;

namespace DbConnectionExample
{
    public class myConnectToMSSQLDB
    {
        public myConnectToMSSQLDB()
        {
            string conStr = @"Data Source=(localdb)\MSSQLLocalDB;" + /* Имя сервера */
                        "Initial Catalog=master;" + /* БД подключения*/
                        "Integrated Security=True;" + /* Использование уч.записи Windows */
                        "Connect Timeout=30;" + /* Таймаут в секундах*/
                        "Encrypt=False;" + /* Поддержка шифрования, работает в паре со сл.параметром */
                        "TrustServerCertificate=False;" + /* Только при подключении к экземпляру SQL Server с допустимым сертификатом. Если ключевому слову TrustServerCertificate присвоено значение true, то транспортный уровень будет использовать протокол SSL для шифрования канала и не пойдет по цепочке сертификатов для проверки доверия. */
                        "ApplicationIntent=ReadWrite;" + /* Режим подключения*/
                        "MultiSubnetFailover=False;"; /* true - поддержка уровня доступности: оптимизирует работу для пользователей одной подсети*/
            var myConn = new SqlConnection(conStr);
            try
            {
                myConn.Open();
                Console.WriteLine($"Установлено соединение с параметрами {conStr}");
            }
            catch
            {
                Console.WriteLine($"Не удалось установить соединение с параметрами {conStr}");
            }
            finally
            {
                
                    //myConn.Close();
                    Console.WriteLine($"Закрыто соединение с параметрами {conStr}");
                
            }

        }
       
    }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var connect = new myConnectToMSSQLDB();
        string _cmd = @"USE test;
        insert into [output](myText) values (N'Привет');";
            /*string conStr = @"Data Source=ATLAS_NOTE;" + *//* Имя сервера *//*
                        "Initial Catalog=master;" +  *//* БД подключения*//*
                        "User ID = sa;" + *//* Имя пользователя БД *//*
                        "Password = 1234;" + *//* Его пароль *//*
                        "Connect Timeout=30;" + *//* Таймаут в секундах*//*
                        "Encrypt=False;" + *//* Поддержка шифрования, работает в паре со сл.параметром *//*
                        "TrustServerCertificate=False;" + *//* Только при подключении к экземпляру SQL Server с допустимым сертификатом. Если ключевому слову TrustServerCertificate присвоено значение true, то транспортный уровень будет использовать протокол SSL для шифрования канала и не пойдет по цепочке сертификатов для проверки доверия. *//*
                        "ApplicationIntent=ReadWrite;" + *//* Режим подключения*//*
                        "MultiSubnetFailover=False;"; *//* true - поддержка уровня доступности: оптимизирует работу для пользователей одной подсети*/
            Console.ReadKey();
        }
    }

