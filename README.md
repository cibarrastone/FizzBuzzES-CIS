# FizzBuzzES-CIS
A quick take on approach for Headspring technical challenge <br />
The project structure consists of the following projects: <br />
--FizzBussLib.csproj (Contains the libraries FizzBuzz and SuperFizzBuzz related functions) <br />
  --Interface (Interface contracts for the challenge requierements) <br />
  --FizzBuzz.cs (FizzBuzz Base class implementation with basic functionality) <br />
  --SuperFizzBuzz.cs (Extension of FizzBuzz base class with enriched functionality) <br />
--FizzBuzzES-CIS.csproj (Contains only the console program for the challenge requirements, rely on the FizzBussLib project) <br />
--SuperFizzBuzzES-CIS.csproj (Contains only the console program for the challenge requirements, rely on the FizzBussLib project) <br />
--FizzBuzzTests.csproj (Nunit project for FizzBuzzLib coverage) <br />
