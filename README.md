# Gulbee

Gulbee to mini gierka, w której zgadujesz produkty na podstawie ich składu. Możesz również dodawać nowe produkty. Aplikacja jest zbudowana przy pomocy ASP.NET, Blazora, Bootstrapa oraz Entity Framework Core.

## Spis treści

- [Wymagania](#wymagania)
- [Instalacja](#instalacja)
- [Sposób uruchamiania](#sposób-uruchamiania)
- [Użycie](#użycie)
- [Autorzy](#autorzy)
- [Licencja](#licencja)

## Wymagania

- [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

## Instalacja

1. Sklonuj repozytorium:
    ```bash
    git clone https://github.com/TwojaNazwaUzytkownika/Gulbee.git
    cd Gulbee

2. Pobierz potrzebne paczki
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore --version 8.0.8
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.8
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.8

3. Uruchom Backend i Frontend i ciesz się aplikacją
    ```bash
    .\run_project.sh
