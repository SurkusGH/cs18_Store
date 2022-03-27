using System;

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

            StoreFrontMenu.Menu();
        }
    }
}

