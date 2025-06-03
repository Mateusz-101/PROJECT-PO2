using Microsoft.EntityFrameworkCore;
using OSPManagementSystem.Models;
using System;

namespace OSPManagementSystem.Data.Seed
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firefighter>().HasData(
                new Firefighter { Id = 1, FirstName = "Jan", LastName = "Kowalski", BirthDate = new DateTime(1990, 5, 12, 14, 0, 0), Phone = "123456789", Email = "jan.kowalski@osp.pl", Rank = "Strażak", IsActive = true },
                new Firefighter { Id = 2, FirstName = "Anna", LastName = "Nowak", BirthDate = new DateTime(1992, 8, 20, 14, 0, 0), Phone = "234567890", Email = "anna.nowak@osp.pl", Rank = "Dowódca", IsActive = true },
                new Firefighter { Id = 3, FirstName = "Piotr", LastName = "Zieliński", BirthDate = new DateTime(1988, 3, 2, 14, 0, 0), Phone = "345678901", Email = "piotr.zielinski@osp.pl", Rank = "Strażak", IsActive = true },
                new Firefighter { Id = 4, FirstName = "Katarzyna", LastName = "Wiśniewska", BirthDate = new DateTime(1995, 11, 15, 14, 0, 0), Phone = "456789012", Email = "k.wisniewska@osp.pl", Rank = "Ratownik", IsActive = true },
                new Firefighter { Id = 5, FirstName = "Marek", LastName = "Wójcik", BirthDate = new DateTime(1987, 7, 8, 14, 0, 0), Phone = "567890123", Email = "marek.wojcik@osp.pl", Rank = "Strażak", IsActive = true },
                new Firefighter { Id = 6, FirstName = "Magdalena", LastName = "Kaczmarek", BirthDate = new DateTime(1993, 6, 18, 14, 0, 0), Phone = "678901234", Email = "magda.kaczmarek@osp.pl", Rank = "Ratownik", IsActive = true },
                new Firefighter { Id = 7, FirstName = "Tomasz", LastName = "Mazur", BirthDate = new DateTime(1989, 4, 5, 14, 0, 0), Phone = "789012345", Email = "t.mazur@osp.pl", Rank = "Strażak", IsActive = true },
                new Firefighter { Id = 8, FirstName = "Ewa", LastName = "Krawczyk", BirthDate = new DateTime(1994, 9, 25, 14, 0, 0), Phone = "890123456", Email = "ewa.krawczyk@osp.pl", Rank = "Dowódca", IsActive = true },
                new Firefighter { Id = 9, FirstName = "Paweł", LastName = "Piotrowski", BirthDate = new DateTime(1986, 2, 14, 14, 0, 0), Phone = "901234567", Email = "pawel.piotrowski@osp.pl", Rank = "Strażak", IsActive = true },
                new Firefighter { Id = 10, FirstName = "Agnieszka", LastName = "Dąbrowska", BirthDate = new DateTime(1991, 10, 30, 14, 0, 0), Phone = "012345678", Email = "a.dabrowska@osp.pl", Rank = "Ratownik", IsActive = true }
            );
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment { Id = 1, Name = "Sprzęt1", SerialNumber = "SN001", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 31, 14, 0, 0) },
                new Equipment { Id = 2, Name = "Sprzęt2", SerialNumber = "SN002", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 30, 14, 0, 0) },
                new Equipment { Id = 3, Name = "Sprzęt3", SerialNumber = "SN003", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 29, 14, 0, 0) },
                new Equipment { Id = 4, Name = "Sprzęt4", SerialNumber = "SN004", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 28, 14, 0, 0) },
                new Equipment { Id = 5, Name = "Sprzęt5", SerialNumber = "SN005", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 27, 14, 0, 0) },
                new Equipment { Id = 6, Name = "Sprzęt6", SerialNumber = "SN006", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 26, 14, 0, 0) },
                new Equipment { Id = 7, Name = "Sprzęt7", SerialNumber = "SN007", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 25, 14, 0, 0) },
                new Equipment { Id = 8, Name = "Sprzęt8", SerialNumber = "SN008", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 24, 14, 0, 0) },
                new Equipment { Id = 9, Name = "Sprzęt9", SerialNumber = "SN009", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 23, 14, 0, 0) },
                new Equipment { Id = 10, Name = "Sprzęt10", SerialNumber = "SN010", Status = "Sprawny", LastInspectionDate = new DateTime(2024, 5, 22, 14, 0, 0) }
            );
            modelBuilder.Entity<RescueAction>().HasData(
                new RescueAction { Id = 1, Date = new DateTime(2024, 5, 31, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 1", Description = "Opis akcji 1" },
                new RescueAction { Id = 2, Date = new DateTime(2024, 5, 30, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 2", Description = "Opis akcji 2" },
                new RescueAction { Id = 3, Date = new DateTime(2024, 5, 29, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 3", Description = "Opis akcji 3" },
                new RescueAction { Id = 4, Date = new DateTime(2024, 5, 28, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 4", Description = "Opis akcji 4" },
                new RescueAction { Id = 5, Date = new DateTime(2024, 5, 27, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 5", Description = "Opis akcji 5" },
                new RescueAction { Id = 6, Date = new DateTime(2024, 5, 26, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 6", Description = "Opis akcji 6" },
                new RescueAction { Id = 7, Date = new DateTime(2024, 5, 25, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 7", Description = "Opis akcji 7" },
                new RescueAction { Id = 8, Date = new DateTime(2024, 5, 24, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 8", Description = "Opis akcji 8" },
                new RescueAction { Id = 9, Date = new DateTime(2024, 5, 23, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 9", Description = "Opis akcji 9" },
                new RescueAction { Id = 10, Date = new DateTime(2024, 5, 22, 14, 0, 0), Type = "Pożar", Location = "Lokalizacja 10", Description = "Opis akcji 10" }
            );
            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1, Date = new DateTime(2024, 6, 1, 14, 0, 0), Type = "Dyżur", FirefighterId = 1 },
                new Schedule { Id = 2, Date = new DateTime(2024, 6, 2, 14, 0, 0), Type = "Dyżur", FirefighterId = 2 },
                new Schedule { Id = 3, Date = new DateTime(2024, 6, 3, 14, 0, 0), Type = "Dyżur", FirefighterId = 3 },
                new Schedule { Id = 4, Date = new DateTime(2024, 6, 4, 14, 0, 0), Type = "Dyżur", FirefighterId = 4 },
                new Schedule { Id = 5, Date = new DateTime(2024, 6, 5, 14, 0, 0), Type = "Dyżur", FirefighterId = 5 },
                new Schedule { Id = 6, Date = new DateTime(2024, 6, 6, 14, 0, 0), Type = "Dyżur", FirefighterId = 6 },
                new Schedule { Id = 7, Date = new DateTime(2024, 6, 7, 14, 0, 0), Type = "Dyżur", FirefighterId = 7 },
                new Schedule { Id = 8, Date = new DateTime(2024, 6, 8, 14, 0, 0), Type = "Dyżur", FirefighterId = 8 },
                new Schedule { Id = 9, Date = new DateTime(2024, 6, 9, 14, 0, 0), Type = "Dyżur", FirefighterId = 9 },
                new Schedule { Id = 10, Date = new DateTime(2024, 6, 10, 14, 0, 0), Type = "Dyżur", FirefighterId = 10 }
            );
            modelBuilder.Entity<Training>().HasData(
                new Training { Id = 1, Name = "Szkolenie 1", Date = new DateTime(2024, 5, 1, 14, 0, 0) },
                new Training { Id = 2, Name = "Szkolenie 2", Date = new DateTime(2024, 5, 2, 14, 0, 0) },
                new Training { Id = 3, Name = "Szkolenie 3", Date = new DateTime(2024, 5, 3, 14, 0, 0) },
                new Training { Id = 4, Name = "Szkolenie 4", Date = new DateTime(2024, 5, 4, 14, 0, 0) },
                new Training { Id = 5, Name = "Szkolenie 5", Date = new DateTime(2024, 5, 5, 14, 0, 0) },
                new Training { Id = 6, Name = "Szkolenie 6", Date = new DateTime(2024, 5, 6, 14, 0, 0) },
                new Training { Id = 7, Name = "Szkolenie 7", Date = new DateTime(2024, 5, 7, 14, 0, 0) },
                new Training { Id = 8, Name = "Szkolenie 8", Date = new DateTime(2024, 5, 8, 14, 0, 0) },
                new Training { Id = 9, Name = "Szkolenie 9", Date = new DateTime(2024, 5, 9, 14, 0, 0) },
                new Training { Id = 10, Name = "Szkolenie 10", Date = new DateTime(2024, 5, 10, 14, 0, 0) }
            );
            modelBuilder.Entity<ActionFirefighter>().HasData(
                new ActionFirefighter { ActionId = 1, FirefighterId = 1 },
                new ActionFirefighter { ActionId = 2, FirefighterId = 2 },
                new ActionFirefighter { ActionId = 3, FirefighterId = 3 },
                new ActionFirefighter { ActionId = 4, FirefighterId = 4 },
                new ActionFirefighter { ActionId = 5, FirefighterId = 5 },
                new ActionFirefighter { ActionId = 6, FirefighterId = 6 },
                new ActionFirefighter { ActionId = 7, FirefighterId = 7 },
                new ActionFirefighter { ActionId = 8, FirefighterId = 8 },
                new ActionFirefighter { ActionId = 9, FirefighterId = 9 },
                new ActionFirefighter { ActionId = 10, FirefighterId = 10 }
            );
            modelBuilder.Entity<ActionEquipment>().HasData(
                new ActionEquipment { ActionId = 1, EquipmentId = 1 },
                new ActionEquipment { ActionId = 2, EquipmentId = 2 },
                new ActionEquipment { ActionId = 3, EquipmentId = 3 },
                new ActionEquipment { ActionId = 4, EquipmentId = 4 },
                new ActionEquipment { ActionId = 5, EquipmentId = 5 },
                new ActionEquipment { ActionId = 6, EquipmentId = 6 },
                new ActionEquipment { ActionId = 7, EquipmentId = 7 },
                new ActionEquipment { ActionId = 8, EquipmentId = 8 },
                new ActionEquipment { ActionId = 9, EquipmentId = 9 },
                new ActionEquipment { ActionId = 10, EquipmentId = 10 }
            );
        }
    }
}