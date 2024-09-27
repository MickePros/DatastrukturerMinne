# MemoryHandling
## Minneshantering
1. Stacken innehåller till exempel Value Types och fungerar som en kö där senaste tillägget måste exekveras innan tidigare anrop och metoder kan köras.
- Medans Heapen fungerar som en låda där till exempel Reference Types finns tillgängliga och dessa finns alltid tillgängliga att användas hela tiden tills Garbage collection tar bort dessa ur lådan.
2. Value Types är variabler och Reference types är typer som ärver av System.Object
3. Den första metoden tilldelar variabeln y värdet av x, då dessa är båda av typen int. Medans den andra metoden tilldelar variabeln y objektet x, när man sedan ändrar värde på y.MyValue så ändras även x.MyValue för dessa är samma objekt.

## Datastrukturer
### Övning 1: ExamineList()
1. Funktionen fungerar.
2. Listans kapacitet ökar när den behöver mer kapacitet.
3. Kapaciteten dubblar varje gång listan ökar kapaciteten.
4. Det är kostar prestanda att öka kapaciteten på listan.
5. Nej, listan behåller sin högsta kapacitet. Det går att minska kapaciteten med TrimExcess().
6. Om man vet hur många element man vill lagra kan man definiera kapacitet i listans construktor för att slippa prestandakostnaden för att öka senare. En array är fördelaktig om elementen är konstanta eller om man vill ha en multi-dimensionell array.

### Övning 2: ExamineQueue()
1. ICA kön om man använder Queue.
- " ".
- "Kalle".
- "Kalle, Greta".
- "Greta".
- "Greta, Stina".
- "Stina".
- "Stina, Olle".
- ...
2. Utfört i koden.

### Övning 3: ExamineStack()
1. ICA kön om man använder Stack
- " ".
- "Kalle".
- "Kalle, Greta".
- "Kalle".
- "Kalle, Stina".
- "Kalle".
- "Kalle, Olle".
- ...
Det är inte smart att använda en stack till ICA:s kösystem för Kalle blir trött i benen och kommer använda online handling nästa gång.
2. Utfört i koden.

### Övning 4: CheckParenthesis()
1.	Vi kan loopa varje bokstav i input strängen och hittar vi en typ av parentese så lägger vi den i en stack, sen matchar vi stängnings parenteser i strängen mot stacken för att se att det är korrekt mängd och ordning.
2. Utförd i koden.

### Övning 5: Rekursion
1. illustrera flödet för RecursiveOdd()
- Anropa RecursiveOdd(1)
- Return 1

- Anropa RecursiveOdd(3)
- Anropa RecursiveOdd(3-1)
- Anropa RecursiveOdd(2-1)
- Return 1+2+2 (5)

- Anropa RecursiveOdd(5)
- Anropa RecursiveOdd(5-1)
- Anropa RecursiveOdd(4-1)
- Anropa RecursiveOdd(3-1)
- Anropa RecursiveOdd(2-1)
- Return 1+2+2+2+2 (9)
2. Utförd i koden.
3. Utförd i koden.

### Övning 6: Iteration
1. illustrera flödet för IterativeOdd()
- Anropa IterativeOdd(1) -> 0 varv i loopen
- Return 1

- Anropa IterativeOdd(3) -> 2 varv i loopen
- Return 5

- Anropa IterativeOdd(5) -> 4 varv i loopen
- Return 9
2. Utförd i koden.
3. Utförd i koden.

### Fråga
Iteration ser ut att vara mindre krävande och snabbare att utföra.