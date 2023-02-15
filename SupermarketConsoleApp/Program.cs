

using SupermarketConsoleApp;
using System.Drawing;
using System.Xml;
DB db = new DB();
mainPage: Console.Clear();

while (true)
{
    Console.WriteLine("SUPERMARKET APP\n\n");
    Console.WriteLine("   1 -  ADMINISTRATORs ");
    Console.WriteLine("   2 -  PROADMINSTRATOR");
    Console.WriteLine("   3 -  CLIENTs ");
    int answer1 = int.Parse(Console.ReadLine());
    if (answer1 == 1)

    {
    AdminPage:
        Console.Clear();
        Console.WriteLine("1 - SIGN IN ");
        Console.WriteLine("0 - GO BACK");
        int answer2 = int.Parse(Console.ReadLine());
        if (answer2 == 0) goto mainPage;
        if (answer2 == 1)
        {
        retypeLog:
            Console.Write("LOGIN : ");
            string foreignLog = Console.ReadLine();
            Console.WriteLine("Loading...");
            var obj1 = db.Ishchilar.FirstOrDefault(p => p.login == foreignLog);
            if (obj1 != null)
            {
            RetypePass:
                Console.Write("Password : ");
                string foreignPass = Console.ReadLine();
                Console.WriteLine("Loading...");
                var obj2 = db.Ishchilar.FirstOrDefault(p => p.password == foreignPass);
                if (obj2 == null)
                {
                    Console.WriteLine("ERROR PASSWORD (1 - Retype / 0 - Go Back");
                    int answer5 = int.Parse(Console.ReadLine());
                    if (answer5 == 1) goto RetypePass;
                    if (answer5 == 0) goto AdminPage;
                }
                if (obj2 != null)
                {
                WellcomeAdmin:
                    Console.Clear();

                    Colorful.Console.WriteAscii("       Welcome", Color.FromArgb(20, 100, 200));
                    Colorful.Console.WriteAscii($" {obj1.UserFirstName}  {obj1.UserLastName}", Color.FromArgb(20, 100, 200));
                    Console.WriteLine("1. MAHSULOTLARNI KO'RISH ");
                    Console.WriteLine("2. MAHSULOT QO'SHISH");
                    Console.WriteLine("3. MAHSULOT O'CHIRISH");
                    Console.WriteLine("0. PROFILDAN CHIQISH");


                    int answer6 = int.Parse(Console.ReadLine());
                    switch (answer6)
                    {
                        case 1:  //////  MAHSULOTLARNI KO'RISH  ////////
                            {
                                foreach (var t in db.Mahsulotlar)
                                {
                                    Console.WriteLine($"ID : {t.id}  NOMI : {t.nomi}  NARXI : {t.narxi}");
                                }

                                Console.WriteLine();
                                Console.WriteLine("0 - GO Back");
                                int answer9 = int.Parse(Console.ReadLine());
                                if (answer9 == 0) goto WellcomeAdmin;
                                break;
                            }

                        case 2:  ////// TAOM QO'SHISH  ////////
                            {
                                Mahsulotlar mahsulot = new Mahsulotlar();
                                Console.WriteLine("MAHSULOT NOMI : ");
                                mahsulot.nomi = Console.ReadLine();
                                Console.WriteLine("MAHSULOT NARXI : ");
                                mahsulot.narxi = int.Parse(Console.ReadLine());
                                db.Mahsulotlar.Add(mahsulot);
                                db.SaveChanges();
                                Console.WriteLine("Mahsulot muvafaqqiyatli qo'shildi. ");
                                Console.WriteLine("Type 0 to Go Back");
                                int answer10 = int.Parse(Console.ReadLine());
                                if (answer10 == 0) goto WellcomeAdmin;
                                break;
                            }
                        case 3: /////// MAHSULOT O'CHIRISH ////////
                            {
                                foreach (var t in db.Mahsulotlar)
                                {
                                    Console.WriteLine($"ID : {t.id}  NOMI : {t.nomi}  NARXI : {t.narxi}");
                                }
                                Console.WriteLine("Ochirish uchun mahsulot ID sini tanlang");
                                int answer8 = int.Parse(Console.ReadLine());
                                var item1 = db.Mahsulotlar.FirstOrDefault(p => p.id == answer8);
                                db.Mahsulotlar.Remove(item1);
                                db.SaveChanges();

                                Console.WriteLine("Taom muvafaqqiyatli o'chirildi. ");
                                Console.WriteLine("Type 0 to Go Back");
                                int answer11 = int.Parse(Console.ReadLine());
                                if (answer11 == 0) goto WellcomeAdmin;


                                break;
                            }
                        case 0:  /////// PROFILDAN CHIQISH ////////
                            {
                                goto AdminPage;
                            }
                    }


                }


            }
            if (obj1 == null)
            {
                Console.WriteLine("There is no user like this\n Insert 5 to retype");
                int answer4 = int.Parse(Console.ReadLine());
                if (answer4 == 5) goto retypeLog;


            }
        }
    }
    if (answer1 == 2)
    {
        Console.WriteLine("Pro Administrator parolini kiriting: ");
        int answer16 = int.Parse(Console.ReadLine());
        if (answer16 == 0)
        {
            Console.WriteLine("Pro Admin Profili\n\n ");
            Console.WriteLine("1 - Adminstrator qo'shish");
            Console.WriteLine("2 - Administrator o'chirish");
            int answer17 = int.Parse(Console.ReadLine());
            switch (answer17)
            {
                case 1:  //////  ISHCHI QO'SHISH  ////////
                    {
                        Ishchilar ishchi = new Ishchilar();
                        Console.WriteLine("Iishchi ismi : ");
                        ishchi.UserFirstName = Console.ReadLine();
                        Console.WriteLine("Ishchi familiyasi");
                        ishchi.UserLastName = Console.ReadLine();
                        Console.WriteLine("Ishchi Logini");
                        ishchi.login = Console.ReadLine();
                        Console.WriteLine("Ishchi Passwordi");
                        ishchi.password = Console.ReadLine();

                        db.Ishchilar.Add(ishchi);
                        db.SaveChanges();
                        Console.WriteLine("Ishchi muvafaqqiyatli qo'shildu");
                        break;
                    }

            }
        }
    }
}