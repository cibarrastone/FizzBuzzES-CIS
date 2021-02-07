# FizzBuzzES-CIS
A quick take on approach for Headspring technical challenge 
The project structure consists of the following projects:
--FizzBussLib.csproj (Contains the libraries FizzBuzz and SuperFizzBuzz related functions)
  --Interface (Interface contracts for the challenge requierements)
  --FizzBuzz.cs (FizzBuzz Base class implementation with basic functionality)
  --SuperFizzBuzz.cs (Extension of FizzBuzz base class with enriched functionality)
--FizzBuzzES-CIS.csproj (Contains only the console program for the challenge requirements, rely on the FizzBussLib project)
--SuperFizzBuzzES-CIS.csproj (Contains only the console program for the challenge requirements, rely on the FizzBussLib project)
--FizzBuzzTests.csproj (Nunit project for FizzBuzzLib coverage)
