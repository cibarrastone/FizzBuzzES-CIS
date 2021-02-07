# FizzBuzzES-CIS
A quick take on approach for Headspring technical challenge <br /> 
The IDE used to create the base .net core solutions was Visual Studio 2019 <br /> 
The project structure consists of the following projects: <br />
-FizzBussLib.csproj (Contains the libraries FizzBuzz and SuperFizzBuzz related functions) <br />
  &ensp;&ensp;--Interface (Interface contracts for the challenge requierements) <br />
  &ensp;&ensp;--FizzBuzz.cs (FizzBuzz Base class implementation with basic functionality) <br />
  &ensp;&ensp;--SuperFizzBuzz.cs (Extension of FizzBuzz base class with enriched functionality) <br />
-FizzBuzzES-CIS.csproj (Contains only the console program for the challenge requirements, rely on the FizzBussLib project) <br />
-SuperFizzBuzzES-CIS.csproj (Contains only the console program for the challenge requirements, rely on the FizzBussLib project) <br />
-FizzBuzzTests.csproj (Nunit project for FizzBuzzLib coverage, to test this project i use ReSharper tools, if is not available then NUnit Test Runner NuGet package might be needed to execute the coverage tests) <br />
