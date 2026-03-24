# dotNetLab1

Rozwiazanie zawiera implementacje problemu plecakowego (zachlanna heurystyka po wspolczynniku `Value/Weight`) w aplikacji konsolowej oraz interfejs GUI w Windows Forms.

## Projekty w solution

- `Lab1` - logika domenowa (`Problem`, `Item`) + prosty runner konsolowy.
- `WinFormsApp1` - GUI do uruchamiania algorytmu na danych z formularza.
- `TestProject1` - testy jednostkowe (MSTest) dla `Lab1`.

## Wymagania

- .NET SDK 8.0
- Windows (dla `WinFormsApp1` - `net8.0-windows`)

## Jak uruchomic

### 1) Aplikacja konsolowa (`Lab1`)

Program:
- generuje liste elementow (`GenerateItems`),
- rozwiazuje problem plecakowy (`Solve`),
- wypisuje dane i wynik w konsoli.

### 2) GUI (`WinFormsApp1`)

W formularzu:
- wpisz `Number of items`, `Capacity`, `Seed`,
- kliknij `run`,
- pole `Data` pokazuje wygenerowane elementy,
- pole `Results` pokazuje wybrane elementy oraz sumy `Weight` i `Value`.

## Walidacja danych w GUI

Walidacja jest wykonywana przy kliknieciu `run`:
- `Number of items` musi byc `> 0`,
- `Capacity` musi byc `>= 0`,
- `Seed` musi byc liczba calkowita.

Przy bledzie:
- niepoprawne pola sa podswietlane,
- pojawia sie komunikat ostrzegawczy,
- obliczenia nie sa uruchamiane.

## Testy jednostkowe

Zakres testow obejmuje m.in.:
- przypadek, gdy przynajmniej jeden element miesci sie w plecaku,
- przypadek, gdy zaden element sie nie miesci,
- znana instancje z oczekiwanym wynikiem,
- format `Item.ToString()`,
- liczbe i identyfikatory elementow z `GenerateItems()`.

