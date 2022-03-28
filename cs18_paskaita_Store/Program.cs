using System;
using cs18_paskaita_Store.Goods;


namespace cs18_paskaita_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Store!");

            #region TEORIJA - Review
            // Kas yra stash changes?
            // Stash yra pakeitimų atsidėjimas į šalį

            // Remote branch'as yra "kitas žmogus"
            // Kiekvienas turi savo individualų branch'ą

            // SSH Raktai kuria saugumą (end-to-end encryption?)
            #endregion

            #region InheritanceParameters
            // Parduotuvės programa:

            // - Tėvinė klasė prekė (kaina, barkodas, svoris)

            // - Vaikinės prekės klasės:
            //			                - Saldainiai(cukrus)
            //			                - Mėsa(baltymai)
            //		                	- Daržovės(skaidulinės medžiagos)
            //		                	- Gėrimai(litrai)
            #endregion

            #region DataManagementNotions
            // (!) Skirtingų tipų prekės yra saugomomos skirtinguose .csv failuose
            //     (saldainiai viename, mėsa kitame ir t.t.) (csv example:
            //     https://e.nodegoat.net/CMS/upload/guide-import_person_csv_notepad.png)
            //
            // (!) Pradėjus programai, jūsų sukurtas FileReaderService turi perskaityti
            //     visus failus ir pavertus eilutes į objektus sudėti į atitinkamas repozitorijas.
            //
            // (!) Pvz.: Programai prasidėjus sukuriamos visos repozitorijos pradedant saldainių repozitorija,
            //     ji savyje išsikviečia failų skaitymo servisą, kuris perskaito atitinkamą failą(pvz.: candies.txt)
            //     ir repozitorijos klasė saldainius gautus iš failo susideda į savo sąrašą, kuris yra bendras tarp visų
            //     saldainių repozitorijos klasių.
            //     Tą patį padaro ir Mėsos, Daržovių ir Gėrimų repozitorijos.
            //
            // (!) Programos veikimo metu yra operuojama su sąrašais repozitorijose, ne sąrašais failuose.
            #endregion

            #region FunctionalityAndGeneralPrinciples
            // Veikimo principai:
            // (1) Įsijungus programą nurodote kiek turi pinigų.

            // (2) Jeigu pinigų yra daugiau nei 0 tada vartotojas gali pirkti prekes,
            //     jei pinigų neturi tada gali jas tik peržiūrėti.

            // (3) Programoje turi būti galima išspausdinti kiekvienos prekės repozitorijos
            //     sąrašą individualiai(pvz.: pamatyti visas mėsos prekes)

            // (4) Pasirenkant kokias prekes norit pirkti, jos įdedamos į pirkinių krepšelį.

            // (5) Pirkinių krepšelį taip pat turi būti galimybė peržiūrėti.(prekes su
            //     kainom ir galutinę viso krepšelio kainą)

            // (6) Apsisprendus pirkti turi būti patikrinama ar užtenka pinigų.

            // (7) Jeigu pinigų užtenka tada sudaromas kvitas, į kurį įeina krepšelio
            //     informacija, galutinė kaina ir laikas kada buvo nupirkta.

            // (8) Kvitas išsiunčiamas nurodytu el. paštu(Labiau advanced dalis, palieku ją patiems
            //     išsaiškinti kaip tai padaryti P.S.tai nėra taip baisu kaip gali pasirodyt)

            // (!) Jei labai nesigauna šita dalis, gal idėjų pasisemsite čia: https://ibb.co/hZRFgxM
            #endregion

            #region CodeAssessment
            // 1. Vertinsiu kodo tvarkingumą(kintamųjų/ metodų / klasių pavadinimai)
            // 2. Ar nesukištas kodas į vieną vietą
            // 3. Ar sutvarkytos validacijos.
            // 4. Ar stengiamasi pernaudot kodą(pvz.: jeigu dažnai naudojama "Įvestis"
            //    ir atliekama jos validacija, gal apsimoka ją kažkaip pernaudot ?)
            // 5. Nepaminėta, bet xUnit'ai.
            #endregion
            //Insert_DataIntoDB();
            //Remove_DataFromDB();
            StoreFrontMenu.Menu();
        }

        public static void Insert_DataIntoDB()
        {
            using var dbContext = new ItemContext();
            var vegetables0 = new Greens(0, 15, 3.99m, 30031, 500);
            var vegetables1 = new Greens(0, 5, 1.99m, 30032, 500);
            var vegetables2 = new Greens(0, 43, 2.99m, 30033, 500);
            var vegetables3 = new Greens(0, 30, 2.99m, 30034, 500);

            dbContext.Vegetables.Add(vegetables0);
            dbContext.SaveChanges();
            dbContext.Vegetables.Add(vegetables1);
            dbContext.SaveChanges();
            dbContext.Vegetables.Add(vegetables2);
            dbContext.SaveChanges();
            dbContext.Vegetables.Add(vegetables3);
            dbContext.SaveChanges();

            var meats0 = new Meats(0, 27, 5.99m, 10001, 500);
            var meats1 = new Meats(0, 26, 6.99m, 10002, 500);
            var meats2 = new Meats(0, 26, 8.99m, 10003, 500);
            var meats3 = new Meats(0, 19, 7.99m, 10004, 500);

            dbContext.Meats.Add(meats0);
            dbContext.SaveChanges();
            dbContext.Meats.Add(meats1);
            dbContext.SaveChanges();
            dbContext.Meats.Add(meats2);
            dbContext.SaveChanges();
            dbContext.Meats.Add(meats3);
            dbContext.SaveChanges();

            var sweets0 = new Sweets(0, 50, 6.99m, 20011, 100);
            var sweets1 = new Sweets(0, 51, 5.99m, 20022, 100);
            var sweets2 = new Sweets(0, 53, 4.99m, 20023, 100);
            var sweets3 = new Sweets(0, 58, 3.99m, 20024, 100);

            dbContext.Candies.Add(sweets0);
            dbContext.SaveChanges();
            dbContext.Candies.Add(sweets1);
            dbContext.SaveChanges();
            dbContext.Candies.Add(sweets2);
            dbContext.SaveChanges();
            dbContext.Candies.Add(sweets3);
            dbContext.SaveChanges();

            var drinkables0 = new Drinkables(0, 330, 0.99m, 40041, 500);
            var drinkables1 = new Drinkables(0, 500, 1.99m, 40042, 500);
            var drinkables2 = new Drinkables(0, 500, 2.99m, 40043, 500);
            var drinkables3 = new Drinkables(0, 1000, 0.99m, 40044, 1000);

            dbContext.Drinks.Add(drinkables0);
            dbContext.SaveChanges();
            dbContext.Drinks.Add(drinkables1);
            dbContext.SaveChanges();
            dbContext.Drinks.Add(drinkables2);
            dbContext.SaveChanges();
            dbContext.Drinks.Add(drinkables3);
            dbContext.SaveChanges();
        }

        public static void Remove_DataFromDB()
        {
            using var dbContext = new ItemContext();
            var vegetables0 = new Greens(3, 15, 3.99m, 30031, 500);
            var vegetables1 = new Greens(4, 5, 1.99m, 30032, 500);
            var vegetables2 = new Greens(5, 43, 2.99m, 30033, 500);
            var vegetables3 = new Greens(6, 30, 2.99m, 30034, 500);

            dbContext.Vegetables.Remove(vegetables0);
            dbContext.SaveChanges();
            dbContext.Vegetables.Remove(vegetables1);
            dbContext.SaveChanges();
            dbContext.Vegetables.Remove(vegetables2);
            dbContext.SaveChanges();
            dbContext.Vegetables.Remove(vegetables3);
            dbContext.SaveChanges();

        }
    }
}

