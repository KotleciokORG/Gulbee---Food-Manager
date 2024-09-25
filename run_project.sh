#!/bin/bash

# Funkcja do zatrzymywania procesów
stop_processes() {
    echo "Zatrzymywanie procesów..."
    # Zatrzymaj procesy w tle
    kill $pid1 $pid2
    echo "Procesy zatrzymane."
}

# Trap do łapania sygnałów, aby zatrzymać procesy przy zakończeniu
trap stop_processes SIGINT SIGTERM

# Przejdź do pierwszego folderu
cd Gulbee.Api || { echo "Nie można przejść do Gulbee.Api"; exit 1; }
echo "Uruchamianie dotnet run w Gulbee.Api..."
nohup dotnet run > output_folder1.log 2>&1 &  # Uruchomienie w tle
pid1=$!  # Zapisz PID procesu
echo "Uruchomiono dotnet run w Gulbee.Api z PID: $pid1."

# Powrót do katalogu nadrzędnego
cd ..

# Przejdź do drugiego folderu
cd Gulbee.Frontend || { echo "Nie można przejść do Gulbee.Frontend"; exit 1; }
echo "Uruchamianie dotnet watch w Gulbee.Frontend..."
nohup dotnet watch > output_folder2.log 2>&1 &  # Uruchomienie w tle
pid2=$!  # Zapisz PID procesu
echo "Uruchomiono dotnet watch w Gulbee.Frontend z PID: $pid2."

# Informacja dla użytkownika o zakończeniu
echo "Procesy uruchomione. Naciśnij Ctrl+C, aby zatrzymać procesy."

# Czekaj na zakończenie procesów
wait $pid1
wait $pid2

# Utrzymaj konsolę otwartą po zakończeniu
echo "Naciśnij dowolny klawisz, aby zakończyć..."
read -n 1
