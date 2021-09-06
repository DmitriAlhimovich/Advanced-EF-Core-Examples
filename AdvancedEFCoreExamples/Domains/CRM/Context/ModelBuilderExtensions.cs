using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace AdvancedEFCoreExamples.Domains.CRM.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var rng = new Random();

            var countries = new Country[]
            {
                new() {Code = "it", Name = "Italy", FullName = "Italy"},
                new() {Code = "fr", Name = "France", FullName = "France"},
                new() {Code = "sp", Name = "Spain", FullName = "Spain"},
            };
            modelBuilder.Entity<Country>().HasData(countries);

            var cities = new City[]
            {
                new() {CountryCode = "it", Name = "Rome"},
                new() {CountryCode = "it", Name = "Venice"},
                new() {CountryCode = "it", Name = "Milan"},

                new() {CountryCode = "fr", Name = "Paris"},
                new() {CountryCode = "fr", Name = "Nice"},
                new() {CountryCode = "fr", Name = "Leon"},

                new() {CountryCode = "sp", Name = "Madrid"},
                new() {CountryCode = "sp", Name = "Barcelona"},
                new() {CountryCode = "sp", Name = "Saratoga"},
            };

            modelBuilder.Entity<City>().HasData(cities);

            var employees = Enumerable.Range(1, 20).Select(index => new Employee()
            {
                Id = index,
                FirstName = "fName" + rng.Next(1, 50),
                LastName = "LName" + rng.Next(1, 50),
                HireDate = DateTime.Now.AddDays(-1 * rng.Next(500, 1000))
            }).ToArray();

            modelBuilder.Entity<Employee>().HasData(employees);

            var customers = new List<Customer>();

            Enumerable.Range(1, 50).ToList().ForEach(index =>
            {
                var cityIndex = rng.Next(cities.Length);
                var customer = new Customer()
                {
                    Id = index,
                    Name = $"fName{rng.Next(1, 100)} Lname{rng.Next(1, 150)}",
                    CityName = cities[cityIndex].Name,
                    CityCountryCode = cities[cityIndex].CountryCode,
                    NextCall = DateTime.Now.AddDays(rng.Next(2, 50))
                };
                customers.Add(customer);
            });

            modelBuilder.Entity<Customer>().HasData(customers);

            var calls = Enumerable.Range(1, 500).Select(index => new Call()
            {
                Id = index,
                CustomerId = customers[rng.Next(customers.Count)].Id,
                EmployeeId = employees[rng.Next(employees.Length)].Id,
                StartTime = DateTime.Now.AddMinutes(-1 * rng.Next(2000, 2050)),
                EndTime = DateTime.Now.AddMinutes(-1 * rng.Next(1950, 2000)),
            }).ToArray();

            modelBuilder.Entity<Call>().HasData(calls);

        }
    }
}
