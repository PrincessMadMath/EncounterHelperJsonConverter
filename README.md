# EncounterHelperJsonConverter

For my [EncouterHelper project](https://github.com/PrincessMadMath/EncountersHelper). 
I need a specific format for monster and spell (to be able to show the more information possible),
and this project convert some data found on the internet (this project use very specific input 
format (for now at least)) into the format I want.


# How to install

1. Install [.net core](https://www.microsoft.com/net/core#windowsvs2015)
2. Install dependencies 
```
dotnet restore
```

# How to use

There is 2 command available:

To convert spell:
```
dotnet run spell -i "inputfile" -o "outputfile"
```

To convert monster:
```
dotnet run monster -i "inputfile" -o "outputfile"
```

# Road map

In no specific order

* Extract spell school
* Extract spell DC and dice
* Refactor the whole conversion things  
-- To support different input files
* Auto-generate conversion skeleton  
-- Avoid initial burden in input and output are similar (avoid copy paste)
* Add Json Schema to help support and detect different input format