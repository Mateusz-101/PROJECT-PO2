# PROJECT-PO2

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

# 🗃️ Propozycja Bazy Danych (schemat)
Poniżej prezentuję uproszczony schemat relacyjnej bazy danych:

# 🔗 Tabele i relacje:

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
