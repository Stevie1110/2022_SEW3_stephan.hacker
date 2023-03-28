using _1._2Test_Vollmond;

DateTime today = new DateTime(2022, 12, 1, 0, 0, 0);



MoonPhases todaysMoon = new MoonPhases();



Moon.GetMoonPhase(today, ref todaysMoon);



while (todaysMoon != MoonPhases.Fullmoon)
{

    today = today.AddDays(1);

    Moon.GetMoonPhase(today, ref todaysMoon);

}



today = today.AddDays(1);



Console.WriteLine("Der nächste Vollmond ist am: " + today.Day + "." + today.Month + "." + today.Year);