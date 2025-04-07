print("Wybierz konwersje: ")
print("C - Celcjusz na Fahrenheit: ")
konwersja = (input("F - Fahrenheit na Celcjusz"))
wartosc = float(input("Podaj wartość: "))


if konwersja=="F":
    FahrenheitNaCelcjusz = (wartosc - 32) / 1.8
    print(f"{wartosc}°F =  {FahrenheitNaCelcjusz}°C")

elif konwersja=="C":
    CelcjuszNaFahrenheit = wartosc * 1.8 + 32
    print(f"{wartosc}°C =  {CelcjuszNaFahrenheit}°F")

else:
    print("Nieprawidłowy wybór.")