a = float(input("Podaj pierwszą liczbę: "))
b = float(input("Podaj drugą liczbę: "))
znak = input("Wybierz operacje: +, -, * lub / ")

if znak=="+":
    wynik = a + b
    print(wynik)

elif znak=="-":
    wynik = a - b
    print(wynik)

elif znak=="*":
    wynik = a * b
    print(wynik)

elif znak=="/":
    wynik = a / b
    print(wynik)