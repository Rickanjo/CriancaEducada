// palavra Censuradas
	
	string PalavraCensurada = "#@$%*!&";
	string FraseDigitada;
	string FraseCensurada;
	
	Console.Write("digite o que você pensa sobre a sua EX:");
	FraseDigitada = Console.ReadLine()!;
	FraseCensurada = FraseDigitada;
	
	Console.WriteLine(FraseCensurada);
	
	FraseCensurada = FraseDigitada
    .Replace("chato", PalavraCensurada)
	    .Replace("chata", PalavraCensurada)
	    .Replace("bobo", PalavraCensurada)
	    .Replace("boba", PalavraCensurada)
	    .Replace("feio", PalavraCensurada)
	    .Replace("feia", PalavraCensurada)
	    .Replace("boboca", PalavraCensurada)
	    .Replace("bocó", PalavraCensurada)
	    .Replace("tonto", PalavraCensurada)
	    .Replace("tonta", PalavraCensurada)
	    .Replace("palerma", PalavraCensurada)
	    .Replace("paspalho", PalavraCensurada)
	    .Replace("paspalha", PalavraCensurada)
	    .Replace("tantã", PalavraCensurada)
	    .Replace("panaca", PalavraCensurada)
	    .Replace("pentelho", PalavraCensurada)
	    .Replace("pentelha", PalavraCensurada)
	    .Replace("burro", PalavraCensurada)
	    .Replace("burra", PalavraCensurada)
	    .Replace("besta", PalavraCensurada)
	    .Replace("CHATO", PalavraCensurada)
	    .Replace("CHATA", PalavraCensurada)
	    .Replace("BOBO", PalavraCensurada)
	    .Replace("BOBA", PalavraCensurada)
	    .Replace("FEIO", PalavraCensurada)
	    .Replace("FEIA", PalavraCensurada)
	    .Replace("BOBOCA", PalavraCensurada)
	    .Replace("BOCÓ", PalavraCensurada)
	    .Replace("TONTO", PalavraCensurada)
	    .Replace("TONTA", PalavraCensurada)
	    .Replace("PALERMA", PalavraCensurada)
	    .Replace("PASPALHO", PalavraCensurada)
	    .Replace("PASPALHA", PalavraCensurada)
	    .Replace("TANTÃ", PalavraCensurada)
	    .Replace("PANACA", PalavraCensurada)
	    .Replace("PENTELHO", PalavraCensurada)
	    .Replace("PENTELHA", PalavraCensurada)
	    .Replace("BURRO", PalavraCensurada)
	    .Replace("BURRA", PalavraCensurada)
	    .Replace("BESTA", PalavraCensurada);
	

	Console.WriteLine(FraseCensurada);







