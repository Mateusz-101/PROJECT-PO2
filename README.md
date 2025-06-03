
git clone https://github.com/Mateusz-101/PROJECT-PO2.git

cd PROJECT-PO2

dotnet --version

dotnet ef --version

dotnet ef migrations add UpdateModel

dotnet ef database drop -f

dotnet ef database update

dotnet run

## PROJECT-PO2
# 🔥 1. System Zarządzania Jednostką OSP
Aplikacja desktopowa lub webowa (np. z ASP.NET) do zarządzania jednostką OSP:

Funkcje:

Rejestracja i zarządzanie członkami (dane osobowe, uprawnienia, szkolenia)

Harmonogram dyżurów i ćwiczeń

Rejestracja wyjazdów i akcji (data, miejsce, jednostki, sprzęt)

Zarządzanie sprzętem (przeglądy techniczne, wypożyczenia)

Statystyki i raporty (np. liczba akcji w miesiącu)

# 🔥 System Zarządzania Jednostką OSP
# 1. Moduł: Członkowie OSP
Funkcje:

Dodawanie/edycja/usuwanie danych członków

Lista szkoleń, stopień, numer kontaktowy, status aktywności

Wyszukiwanie po imieniu, stopniu, szkoleniu

Pola przykładowe:

Imię, nazwisko

Data urodzenia

Telefon, e-mail

Stopień (np. strażak, naczelnik)

Lista ukończonych szkoleń

Aktywny / Zawieszony

# 2. Moduł: Harmonogram Dyżurów i Ćwiczeń
Funkcje:

Kalendarz miesięczny z dyżurami

Przypisanie strażaków do terminów

Oznaczenie ćwiczeń obowiązkowych/dobrowolnych

Powiadomienia

# 3. Moduł: Akcje Ratownicze i Wyjazdy
Funkcje:

Rejestracja nowej akcji: data, typ zdarzenia, lokalizacja

Przypisani strażacy i sprzęt

Czas trwania, uwagi

Podgląd historii działań

# 4. Moduł: Sprzęt
Funkcje:

Lista sprzętu z datą zakupu i przeglądami

Informacja o stanie technicznym

Historia użycia

Wypożyczenia

# 5. Moduł: Raporty i Statystyki
Funkcje:

Liczba akcji na miesiąc/rok

Raporty PDF/Excel (np. kto brał udział w ilu akcjach)

Liczba szkoleń, aktywność strażaków

🗃️ Propozycja Bazy Danych (schemat)
Poniżej prezentuję uproszczony schemat relacyjnej bazy danych:

🔗 Tabele i relacje:
Firefighter

├── Id (PK)

├── FirstName

├── LastName

├── BirthDate

├── Phone

├── Email

├── Rank

├── IsActive

└── Trainings (REL - M:N)

Training

├── Id (PK)

├── Name

├── Date

└── Firefighters (REL - M:N)

Schedule

├── Id (PK)

├── FirefighterId (FK)

├── Date

├── Type (Duty / Training)

Action

├── Id (PK)

├── Date

├── Location

├── Type (Fire, Flood, Rescue, etc.)

├── Description

└── ActionFirefighters (REL - M:N)

└── ActionEquipment (REL - M:N)

Equipment

├── Id (PK)

├── Name

├── SerialNumber

├── Status (Working/Under Repair)

├── LastInspectionDate

└── EquipmentUsages (REL - M:N with Action)

ActionFirefighter (junction table)

├── ActionId (FK)

├── FirefighterId (FK)

ActionEquipment (junction table)

├── ActionId (FK)

├── EquipmentId (FK)

EquipmentUsageHistory

├── Id (PK)

├── EquipmentId (FK)

├── ActionId (FK)

├── UsedDate

├── Notes

# WIDOKI

![PO-1](https://github.com/user-attachments/assets/d4892c0e-9d19-4b74-9b44-820e5ba00896)
![PO-2](https://github.com/user-attachments/assets/0082fa04-eba8-41d7-abe0-bf6245066fe3)
![PO-3](https://github.com/user-attachments/assets/eb28e28d-80f9-4cf7-ba15-b1877edf168b)
![PO-4](https://github.com/user-attachments/assets/917de4e0-bb0d-4c7f-a152-2c9958b58d0b)
![PO-5](https://github.com/user-attachments/assets/62e78bfd-2f95-46be-80d1-ba556f97a5ed)
![PO-6](https://github.com/user-attachments/assets/11d9f485-27fe-49b6-8b4b-06feb3c8de0d)
![PO-6](https://github.com/user-attachments/assets/05b4e0e4-c25b-485c-9bbe-6465fcb9c183)
![PO-7](https://github.com/user-attachments/assets/7f51645c-de5d-43fe-bc92-bc4c03bcdb23)
![PO-8](https://github.com/user-attachments/assets/539fa638-226f-4334-84ee-91c15eb1e4a5)
![PO-9](https://github.com/user-attachments/assets/6de8b03f-b081-4ad7-afbc-93cd683e9d4d)
