// ArrayChallenges


string[] fraudulentCodes = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179", };

foreach (string code in fraudulentCodes)
{
    if (code.StartsWith('B'))
    {
        Console.WriteLine($"The code starts with B!!!");
    }

}


