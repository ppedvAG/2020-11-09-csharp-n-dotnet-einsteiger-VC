# KURSABLAUF C SHARP, VADZIM

## M00 | WARMING UP

- [x] Folien: Greeter
- [x] Link: [VS homepage](https://visualstudio.microsoft.com/de/)
- [x] Folien: VS > Getting Started
- [x] Folien: VS > Projects & Solutions
- [x] Spicker: [vs-shortcuts](/spicker/shortcuts-vs.md)
- [x] [commit](https://github.com/ppedvAG/2020-11-09-csharp-n-dotnet-einsteiger-VC/commit/f5aa69f7e5a5519cf556db152b4d5d1e541bb765)
<!-- - [ ] Folien: Git > Getting Started -->

VS Settings: Tools > Options > General > Color Theme

VS Settings: VS Installer > installierte Version ändern > Sprachpakete

VS Settings: Tools > Options > Text Editor > All Languages > General > Line numbers

---

## M01 | GETTING STARTED

- [x] Folien: C# > Getting Started
- [x] Link: [csharp docs](https://docs.microsoft.com/de-de/dotnet/csharp/)
- [x] Link: [dotnet docs](https://docs.microsoft.com/de-de/dotnet/api/?view=netframework-4.8)
- [x] Spicker: [C# Syntax](/spicker/CSHARP-CHEATSHEET.md)
- [x] Spicker: [Snippets](/spicker/VS-CS-SNIPPETS.md)
- [x] [commit](https://github.com/ppedvAG/2020-11-09-csharp-n-dotnet-einsteiger-VC/commit/a931728cc62c613ef51f4660ed67949e3930142c)

VS Settings: Tools > Options > Debugging > Automatically close console when debugging stops

---

## M02 | CLASS CONSOLE

- [x] Demo: [Console](vadzims-solution/M01-Demo-Console/DConsole.cs)
- [x] Variables, Zuweisungsoperator
- [x] [commit]()

VS Settings: sln props > startup projects > current

---

## M03 | HANDLING TEXT

- [ ] Folien: C# > Handling Text
- [ ] Demo: [string](vadzims-solution/Demo-string/Dstring.cs)
- [ ] Demo: [char](vadzims-solution/Demo-char/Dchar.cs)
- [ ] [commit]()

<!--

---

## M04 | HANDLING NUMBERS

- [ ] Folien: C# > Handling Numbers
- [ ] Demo: [int](vadzims-solution/Demo-int/Dint.cs)
- [ ] Demo: [double](vadzims-solution/Demo-double/Ddouble.cs)
- [ ] Parsing & Casting
- [ ] Übung: [MiniRechner](vadzims-solution/Ü-M03-MiniRechner/Program.cs)
- [ ] [commit]()

---

## M05 | CONDITIONS

- [ ] Folien: C# > Conditions
- [ ] Demo: [Entscheidungen](vadzims-solution/Demo-Conditions/DConditions.cs)
- [ ] enum 
- [ ] Übung: [enum & switch](vadzims-solution/Ü-M04-Switch-N-Enum/ÜSwitch.cs)
- [ ] Demo: [bool](CS-GK-DUS-V/M02-Demo-bool/Dbool.cs)
- [ ] [enum](CS-GK-DUS-V/M02-Demo-enum/Denum.cs)

[commit]()

---

## M06 | LOOPS

- [ ] Folien: C# > Loops
- [ ] Übung: [for-loop](vadzims-solution/Ü-M05-For-Loop/ÜFor.cs)
- [ ] Klasse Random
- [ ] Übung: [Zahlenratespiel](vadzims-solution/Ü-M05-Zahlenratespiel/ÜZahlenratespiel.cs)
- [ ] [commit]()
  
---

## M07 | ARRAYS

- [ ] Folien: C# > Arrays
- [ ] Folien: C# > Linq Methods
- [ ] Demo: [Arrays](vadzims-solution/Demo-Arrays/DArrays.cs)
- [ ] iterator foreach
- [ ] Übung: [Lotto](vadzims-solution/Ü-M06-Lotto/ÜLotto.cs)
- [ ] [commit]()

---

## M08 | FUNCTIONS

- [ ] Folien: C# > Functions
- [ ] arguments
- [ ] parameters
- [ ] params
- [ ] return
- [ ] overloads
- [ ] out & ref parameters & args
- [ ] Demo: [Methods](vadzims-solution/D-M07-Functions/DFunctions.cs)
- [ ] [commit]()

---

## M09 | CLASSES (Fortsetzung)

- [ ] Folien: C# > Types & Variables
- [ ] Demo: [Types](vadzims-solution/D-M08-Classes/Types.cs)
- [ ] Folien: C# > Props & Instances
- [ ] Demo: [props, modifier, members, methods](vadzims-solution/D-M08-Classes/PersonOhneCtor.cs)
- [ ] Demo: [constructor, destructor](vadzims-solution/D-M08-Classes/PersonMitCtor.cs)
- [ ] Demo: [fields](vadzims-solution/D-M08-Classes/PersonMitFeldOhneProp.cs)
- [ ] Übung: [Transport](vadzims-solution/Ü-M08-Fuhrpark/Transportmittel.cs)
- [ ] Übung: [TransportConsumer](vadzims-solution/Ü-M08-Fuhrpark/ÜFuhrpark.cs)
- [ ] [commit]()

---

## M10 | FILE ACCESS & SERIALIZING​

- [ ] Folien: C# > File Access & Serializing
- [ ] Demo: [StreamReader & StreamWriter](vadzims-solution/D-M09-FileAccess/DFileAccess.cs)
- [ ] SaveFileDialog & OpenFileDialog
- [ ] Demo: [JSON, serialize](vadzims-solution/D-M09-FileAccess/DFileAccess.cs)

---

## M11 | HTTPCLIENT

- [ ] Demo: [HttpClient & deserialize](vadzims-solution/D-M10-HttpClient/DHttpClient.cs)
 
---

## M12 | INHERITENCE

- [ ] Folien: C# > Inheritence
- [ ] Demo: [virtual](vadzims-solution/D-M11-Inheritence/Superklasse.cs) & override methods
- [ ] Demo: [override](vadzims-solution/D-M11-Inheritence/Subklasse.cs)
- [ ] abstract methods
- [ ] Polymorphysm
- [ ] [commit]()

- [ ] Übung: [Flugzeug](vadzims-solution/Ü-M11-Inheritence/Flugzeug.cs)
- [ ] Übung: [PKW](vadzims-solution/Ü-M11-Inheritence/PKW.cs)
- [ ] Übung: [Schiff](vadzims-solution/Ü-M11-Inheritence/Schiff.cs)
- [ ] Übung: [static methods](vadzims-solution/Ü-M11-Inheritence/Schiff.cs#static)
- [ ] [commit]()

---

## M13 | Exception-Handling​

- [ ] Folien: C# > Exceptions Handling
- [ ] Link: [standard exception](https://docs.microsoft.com/de-de/dotnet/standard/design-guidelines/using-standard-exception-types)
- [ ] Exception & throw
- [ ] try catch finally
- [ ] Exception types
- [ ] Custom Exceptions
- [ ] Demo: [Exception](vadzims-solution/D-M12-Exceptions/DExceptions.cs)
- [ ] Demo: [customized exception](vadzims-solution/D-M12-Exceptions/TooShortException.cs)
- [ ] [commit]()

---

## M14 | INTERFACES

- [ ] Folien: C# > Interfaces
- [ ] Übung: [IKannAndereTransportieren](vadzims-solution/Ü-M13-Interfaces/IKannAndereTransportieren.cs)
- [ ] Übung: [Flugzeug: I](vadzims-solution/Ü-M13-Interfaces/Flugzeug.cs)
- [ ] [commit]()

<!-- Polymorphism in extra Modul, weil es sonst zu viel auf einmal ist.
Nicht zusammen mit Klassen, nicht zusammen mit Interfaces. Sondern danach -->

---

## M15 | GENERIC DATA STRUCTURES

- [ ] Folien: C# > Generic Data Structures
- [ ] Demo: [List`<T>`](vadzims-solution/D-M14-GenericStructures/Program.cs)
- [ ] [Stack`<T>`](/M8GenericDataStructures/MyStack.cs)
- [ ] [Queue`<T>`](/M8GenericDataStructures/MyQueue.cs)
- [ ] [KeyValuePair`<T1, T2>`](/M8GenericDataStructures/MyKeyValuePair.cs)
- [ ] [Dictionary`<T1, T2>`](/M8GenericDataStructures/MyDictionary.cs)
- [ ] [Ü Passagierliste](/M5Fuhrpark/FuhrparkApp.cs)
- [ ] [commit]()

---

## M16 | WINDOWS FORMS

- [ ] partial classes
- [ ] widgets / components
- [ ] component props
- [ ] Demo: [TicTacToe](vadzims-solution/D-M15-WinFormsFramework/Form1.cs)
- [ ] Übung: Das Spiel weiterentwickeln (neu start, gewinne zählen, abbrechen)
- [ ] [commit]()

---

## M17 | DELEGATES & EVENTS

- [ ] Folien: C# > Delegates
- [ ] custom delegates
- [ ] built-in delegates
- [ ] event handler
- [ ] Demo: [Delegates](vadzims-solution/D-M16-Delegates/Form1.cs)
- [ ] Demo: [anonumous functions](vadzims-solution/D-M16-Delegates/Program.cs)
- [ ] [commit]()

---

## M18 | Timing Klassen

- [ ] [Klasse Timing](CS-GK-DUS-V/M17-Demo-Timing/Form1.cs)
- [ ] [Klasse Stopwatch](M15Demo-Timing/Form1.cs#Stopwatch)
- [ ] [Ü kollidierende Buttons mit Timing]

[commit]()

Ü Einfacher Taschenrechner?

Ü Anmeldeformular? / Gästeliste?

## M19 | TAP (async/await)

- [ ] Task
- [ ] async/await
- [ ] Threads
- [ ] [Demo async await ](CS-GK-DUS-V/M13-Demo-Async-Await/M13DemoMain.cs)
- [ ] [Demo Task](CS-GK-DUS-V/M13-Demo-Async-Await/MyTask.cs)
- [ ] siehe Fuhrpark, zufälliges Erzeugen

[commit]()
      
## M20 | LINQ

- [ ] [LINQ Befehle](CS-GK-DUS-V/M15-Demo-LINQ/M15DemoMain.cs)
 
## M018 | Unit-Tests

- [ ] TestPackages & TestProject
- [ ] TestClasses, TestMethods, TestAnnotations
- [ ] Assert-Klasse
- [ ] [Demo-UnitTest](M16Demo-UnitTests/UnitTest1.cs)

[commit]()

## M21 | Entity Framework Core

- [ ] ORM
- [ ] DBContext
- [ ] DBSet & Entities
- [ ] [Demo ](CS-GK-DUS-V/M19-Demo-Entity-Framework/EFDbContext.cs)

[commit]()

## M22 | Dependency Injection

- [x] [DI](CS-GK-DUS-V/M16-Experiment-Dependency-Injection/M16Main.cs)

[commit]()

## M23 | Debugging & Publishing

- [ ] HasFlag
- [ ] Hachtable

[commit]()
-->
