liczbaocen = int(input("Podaj liczbe ocen: "))
suma = 0

for i in range(liczbaocen):
    ocena = float(input("Podaj ocenę: "))
    suma += ocena

srednia = suma / liczbaocen

if srednia>3.0:
    print(f"Średnia: {srednia}")
    print("Uczeń zdał.")

else:
    print(f"Średnia: {srednia}")
    print("Uczeń nie zdał.")