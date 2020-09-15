using System;
using System.IO;
using System.Text;
namespace testProgramm
{
    class Program
    {   //Entry Point
        static void Main(string[] args)
        {
            //Background Color For Program Begining
            Console.BackgroundColor = ConsoleColor.White;
            //Text Color of Questions
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //my Program Variables
            int score = 0;
            string ansr1 = "";
            string ansr2 = "";
            string ansr3 = "";
            string ansr4 = "";
            string ansr5 = "";
            string ansr6 = "";
            string ansr7 = "";
            string ansr8 = "";
            string ansr9 = "";
            string ansr10 = "";
            //

            //Safe the score to a Textfile Method
            StreamWriter StrWrt = new StreamWriter("C:\\Test1.txt", true, Encoding.ASCII);
            Console.WriteLine("Wilkommen in Heute Quiz....Bite nur a oder b oder c als antwort eingeben!\nwelche Team nimmt an die Quiz Teil ?\n");
            string name = Console.ReadLine();
            Console.Clear();
            //
            //Reset the Console Color
            Console.ResetColor();
            Console.WriteLine("Okay " + name + " lets start!\n");
            //
            //Quiz Start SoundMark
            Console.Beep(500, 100);
            Console.Beep(500, 100);
            Console.Beep(500, 100);
            Console.Beep(660, 500);
            Console.Clear();
            //Question no.1
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 1\n Eine Text Such Maschine" + "?\na.Yahoo\nb.Google\nc.Radio\n");
            ansr1 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr1 == "a")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else if (ansr1 == "b")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(100, 100);

            //Question no.2
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 2\n Ein Social Media Service" + "?\na.Instagram\nb.RaspberryPi\nc.Motherboard\n");
            ansr2 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr2 == "a")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(200, 100);
            //Question no.3
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 3\n Wie Heisst die Platte wo die wichtigsten Rechner komponeneten drauf stehen" + "?\na.Tish\nb.Motherboard\nc.FragFinn.com\n");
            ansr3 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr3 == "b")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(300, 100);
            //Question no.4
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 4\n Was ist ein Blog" + "?\na.Arbeits markt\nb.Telefon Liste\nc.ein Personlische Webseite von Content\n");
            ansr4 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr4 == "c")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(400, 100);

            //Question no.5
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 5\n Was ist ein Forum" + "?\na.WetterApp\nb.Webseite wo menschen uber zb. Interessen und Hobbies Kommentieren und Kommunizieren\nc.Online Anwendung\n");
            ansr5 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr5 == "b")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(500, 100);

            //Question no.6
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 6\n Internet ist ein Zusammenschluss " + "?\na.Kabeln\nb.Vieler Computers\nc.Viele Strom Kabeln\n");
            ansr6 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr6 == "b")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(600, 100);

            //Question no.7
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 7\n Meine Webseit [Code] wird geschpeichert auf einem" + "?\na.Web Server\nb.Usb Stick\nc.Cd Raum\n");
            ansr7 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr7 == "a")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(700, 100);

            //Question no.8
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 8\n Was ist ein IP addresse" + "?\na.Eine IP-Adresse ist eine Reihe von Nummern, mit denen ein Computer / Gerät in einem Unternehmens Netzwerk oder im Local Netzwerken eindeutig identifiziert wird.\n\nb.Eine IP-Adresse ist eine Reihe von Aplhabetten und Symbolen, mit denen ein Computer / Gerät in einem Netzwerk oder im Internet eindeutig identifiziert wird\n\nc.Eine IP-Adresse ist eine Reihe von Nummern, mit denen ein Computer / Gerät in einem Netzwerk oder im Internet eindeutig identifiziert wird\n");
            ansr8 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr8 == "c")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(800, 100);

            //Question no.9
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 9\n Eine Richtige Ip addresse Ist :" + "?\na.127.0.0.1\nb.Abcdf1.2.3.4\nc.Https://127.0.0.1\n");
            ansr9 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if (ansr9 == "")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            Console.Beep(900, 100);

            //Question no.10
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Question 10\n Nach welchem Prinzip Funktioniert das Internet" + "?\na.Nutzer / Anbieter => Nutzer (ich) Frage nach Webseite Google.com → Webserver liefert Html,css in form ein Webseite\nb.Nutzer / Bot => Server Frage nach Webseite Google.com → Webserver liefert Html,css in form ein Webseite\nc.Server => Web Server\n");
            ansr10 = Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //
            //Logic 
            if ((ansr10 == "a") && (score == 10))
            {
                //bonus level
                Console.WriteLine("Herzliche Glückwünsche" + name + "Perfekte Score!!!!!!!!!!");
                Console.Beep(500, 100);
                Console.Beep(600, 100);
                Console.Beep(700, 100);
                Console.Beep(1000, 100);
                Console.Beep(1000, 500);
              
            }

            else if ((ansr10 == "a") && (score == 9))
            {
                Console.WriteLine("Herzliche Glückwünsche" + name + "Perfekte Score!!!!!!!!!!");
                Console.Beep(500, 100);
                Console.Beep(600, 100);
                Console.Beep(700, 100);
                Console.Beep(1000, 100);
                Console.Beep(1000, 500);
                //               
            }

            else if (ansr10 == "a")
            {
                score = score + 1;
                Console.WriteLine("Correct\n" + name + "'s score:" + score + "\n");
            }


            else
            {
                Console.WriteLine("Wrong\n" + name + "'s score:" + score + "\n");
            }
            StrWrt.Write(score);
            StrWrt.Close();
            Console.Beep(500, 100);

            Console.ReadKey();
        }
    }
}


