using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedEFCoreExamples.Migrations
{
    public partial class CrmSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Customers_CustomerId",
                table: "Calls");

            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Employees_EmployeeId",
                table: "Calls");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Calls",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Calls",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Code", "FullName", "Name" },
                values: new object[,]
                {
                    { "it", "Italy", "Italy" },
                    { "fr", "France", "France" },
                    { "sp", "Spain", "Spain" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 18, "fName39", new DateTime(2019, 4, 13, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(746), "LName32" },
                    { 17, "fName23", new DateTime(2019, 4, 18, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(744), "LName38" },
                    { 16, "fName47", new DateTime(2019, 10, 2, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(742), "LName32" },
                    { 15, "fName20", new DateTime(2020, 1, 4, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(740), "LName24" },
                    { 14, "fName24", new DateTime(2019, 1, 23, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(738), "LName28" },
                    { 13, "fName29", new DateTime(2018, 12, 25, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(735), "LName38" },
                    { 12, "fName4", new DateTime(2019, 12, 18, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(733), "LName28" },
                    { 11, "fName12", new DateTime(2020, 2, 15, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(731), "LName7" },
                    { 10, "fName45", new DateTime(2019, 3, 1, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(729), "LName30" },
                    { 9, "fName33", new DateTime(2019, 6, 21, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(726), "LName9" },
                    { 8, "fName48", new DateTime(2019, 7, 17, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(724), "LName9" },
                    { 7, "fName41", new DateTime(2020, 3, 1, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(722), "LName35" },
                    { 6, "fName23", new DateTime(2019, 7, 4, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(720), "LName39" },
                    { 5, "fName49", new DateTime(2019, 6, 21, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(718), "LName34" },
                    { 4, "fName40", new DateTime(2019, 6, 6, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(715), "LName8" },
                    { 3, "fName2", new DateTime(2019, 1, 14, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(712), "LName21" },
                    { 2, "fName6", new DateTime(2018, 12, 25, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(696), "LName27" },
                    { 1, "fName38", new DateTime(2019, 5, 31, 11, 54, 13, 896, DateTimeKind.Local).AddTicks(1782), "LName34" },
                    { 19, "fName37", new DateTime(2019, 8, 12, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(748), "LName40" },
                    { 20, "fName5", new DateTime(2019, 10, 29, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(751), "LName22" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CountryCode", "Name", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { "it", "Rome", null, null },
                    { "it", "Venice", null, null },
                    { "it", "Milan", null, null },
                    { "fr", "Paris", null, null },
                    { "fr", "Nice", null, null },
                    { "fr", "Leon", null, null },
                    { "sp", "Madrid", null, null },
                    { "sp", "Barcelona", null, null },
                    { "sp", "Saratoga", null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CityCountryCode", "CityName", "Name", "NextCall" },
                values: new object[,]
                {
                    { 7, null, "it", "Rome", "fName46 Lname72", new DateTime(2021, 9, 26, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6851) },
                    { 44, null, "fr", "Nice", "fName28 Lname113", new DateTime(2021, 10, 1, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6980) },
                    { 48, null, "fr", "Nice", "fName42 Lname29", new DateTime(2021, 9, 20, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(7019) },
                    { 2, null, "fr", "Leon", "fName3 Lname76", new DateTime(2021, 10, 21, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6778) },
                    { 4, null, "fr", "Leon", "fName34 Lname21", new DateTime(2021, 9, 17, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6787) },
                    { 5, null, "fr", "Leon", "fName70 Lname51", new DateTime(2021, 10, 12, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6791) },
                    { 13, null, "fr", "Leon", "fName56 Lname35", new DateTime(2021, 10, 16, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6873) },
                    { 17, null, "fr", "Leon", "fName37 Lname104", new DateTime(2021, 9, 8, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6887) },
                    { 31, null, "fr", "Leon", "fName10 Lname32", new DateTime(2021, 9, 19, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6935) },
                    { 14, null, "sp", "Madrid", "fName72 Lname124", new DateTime(2021, 9, 15, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6877) },
                    { 15, null, "sp", "Madrid", "fName97 Lname149", new DateTime(2021, 9, 12, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6880) },
                    { 37, null, "sp", "Madrid", "fName43 Lname12", new DateTime(2021, 10, 10, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6956) },
                    { 19, null, "sp", "Barcelona", "fName15 Lname44", new DateTime(2021, 10, 15, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6894) },
                    { 23, null, "sp", "Barcelona", "fName97 Lname114", new DateTime(2021, 9, 14, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6908) },
                    { 34, null, "sp", "Barcelona", "fName39 Lname53", new DateTime(2021, 9, 14, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6946) },
                    { 46, null, "sp", "Barcelona", "fName31 Lname146", new DateTime(2021, 9, 18, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6986) },
                    { 49, null, "sp", "Barcelona", "fName80 Lname91", new DateTime(2021, 10, 21, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(7023) },
                    { 12, null, "sp", "Saratoga", "fName72 Lname24", new DateTime(2021, 9, 22, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6870) },
                    { 20, null, "sp", "Saratoga", "fName34 Lname139", new DateTime(2021, 9, 25, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6898) },
                    { 32, null, "sp", "Saratoga", "fName96 Lname147", new DateTime(2021, 10, 25, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6938) },
                    { 36, null, "sp", "Saratoga", "fName14 Lname26", new DateTime(2021, 10, 14, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6953) },
                    { 40, null, "sp", "Saratoga", "fName84 Lname147", new DateTime(2021, 10, 2, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6967) },
                    { 33, null, "fr", "Nice", "fName98 Lname94", new DateTime(2021, 9, 8, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6942) },
                    { 27, null, "fr", "Nice", "fName95 Lname2", new DateTime(2021, 10, 7, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6921) },
                    { 22, null, "fr", "Nice", "fName93 Lname111", new DateTime(2021, 10, 6, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6904) },
                    { 16, null, "fr", "Nice", "fName13 Lname87", new DateTime(2021, 9, 26, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6884) },
                    { 10, null, "it", "Rome", "fName30 Lname136", new DateTime(2021, 9, 17, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6863) },
                    { 26, null, "it", "Rome", "fName16 Lname13", new DateTime(2021, 10, 22, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6918) },
                    { 29, null, "it", "Rome", "fName62 Lname120", new DateTime(2021, 9, 25, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6928) },
                    { 35, null, "it", "Rome", "fName84 Lname47", new DateTime(2021, 10, 5, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6950) },
                    { 38, null, "it", "Rome", "fName29 Lname143", new DateTime(2021, 9, 25, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6960) },
                    { 39, null, "it", "Rome", "fName81 Lname136", new DateTime(2021, 10, 22, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6963) },
                    { 47, null, "it", "Rome", "fName27 Lname144", new DateTime(2021, 9, 10, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6990) },
                    { 50, null, "it", "Rome", "fName71 Lname52", new DateTime(2021, 10, 3, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(7026) },
                    { 3, null, "it", "Venice", "fName36 Lname129", new DateTime(2021, 9, 9, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6783) },
                    { 18, null, "it", "Venice", "fName70 Lname14", new DateTime(2021, 9, 21, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6891) },
                    { 41, null, "sp", "Saratoga", "fName3 Lname17", new DateTime(2021, 9, 29, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6970) },
                    { 25, null, "it", "Venice", "fName90 Lname73", new DateTime(2021, 10, 3, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6915) },
                    { 9, null, "it", "Milan", "fName62 Lname19", new DateTime(2021, 9, 29, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6858) },
                    { 21, null, "it", "Milan", "fName18 Lname115", new DateTime(2021, 10, 15, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6901) },
                    { 24, null, "it", "Milan", "fName81 Lname97", new DateTime(2021, 9, 22, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6911) },
                    { 43, null, "it", "Milan", "fName66 Lname41", new DateTime(2021, 10, 2, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6976) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CityCountryCode", "CityName", "Name", "NextCall" },
                values: new object[,]
                {
                    { 1, null, "fr", "Paris", "fName13 Lname121", new DateTime(2021, 9, 12, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6553) },
                    { 11, null, "fr", "Paris", "fName74 Lname43", new DateTime(2021, 9, 13, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6866) },
                    { 28, null, "fr", "Paris", "fName4 Lname34", new DateTime(2021, 9, 24, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6925) },
                    { 30, null, "fr", "Paris", "fName80 Lname128", new DateTime(2021, 10, 10, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6932) },
                    { 42, null, "fr", "Paris", "fName21 Lname73", new DateTime(2021, 10, 9, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6973) },
                    { 6, null, "fr", "Nice", "fName21 Lname67", new DateTime(2021, 10, 18, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6798) },
                    { 8, null, "it", "Milan", "fName75 Lname111", new DateTime(2021, 10, 1, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6855) },
                    { 45, null, "sp", "Saratoga", "fName46 Lname74", new DateTime(2021, 10, 2, 11, 54, 13, 897, DateTimeKind.Local).AddTicks(6983) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 59, 7, 3, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1511), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1510) },
                    { 354, 31, 19, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2422), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(2421) },
                    { 337, 31, 14, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(2375), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2374) },
                    { 305, 31, 19, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(2288), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(2286) },
                    { 259, 31, 16, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(2160), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2159) },
                    { 190, 31, 2, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(1922), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1921) },
                    { 153, 31, 10, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1821), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(1820) },
                    { 128, 31, 20, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(1700), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(1699) },
                    { 121, 31, 7, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(1681), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1680) },
                    { 87, 31, 6, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(1588), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(1587) },
                    { 479, 17, 18, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2864), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2863) },
                    { 468, 17, 16, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(2833), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(2832) },
                    { 400, 17, 12, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2647), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(2646) },
                    { 345, 17, 13, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(2397), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2396) },
                    { 292, 17, 17, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2252), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(2251) },
                    { 283, 17, 9, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2227), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(2226) },
                    { 208, 17, 19, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(1972), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(1971) },
                    { 194, 17, 16, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(1933), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(1932) },
                    { 26, 17, 11, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1376), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(1375) },
                    { 474, 13, 7, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2850), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2849) },
                    { 395, 13, 2, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2633), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2632) },
                    { 377, 13, 18, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2583), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(2582) },
                    { 376, 13, 5, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(2580), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2579) },
                    { 341, 13, 7, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(2386), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(2385) },
                    { 249, 13, 2, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2085), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(2084) },
                    { 6, 13, 9, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(1319), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1317) },
                    { 456, 5, 18, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(2800), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2799) },
                    { 452, 5, 15, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(2789), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(2788) },
                    { 385, 31, 7, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2605), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2604) },
                    { 447, 5, 4, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2776), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2775) },
                    { 446, 31, 17, new DateTime(2021, 9, 5, 3, 8, 13, 898, DateTimeKind.Local).AddTicks(2773), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(2772) },
                    { 42, 14, 8, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(1464), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(1463) },
                    { 311, 37, 3, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2304), new DateTime(2021, 9, 5, 1, 49, 13, 898, DateTimeKind.Local).AddTicks(2303) },
                    { 258, 37, 7, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2157), new DateTime(2021, 9, 5, 2, 4, 13, 898, DateTimeKind.Local).AddTicks(2156) },
                    { 122, 37, 2, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1684), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(1683) },
                    { 102, 37, 15, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(1629), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1628) },
                    { 73, 37, 7, new DateTime(2021, 9, 5, 3, 16, 13, 898, DateTimeKind.Local).AddTicks(1549), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1548) },
                    { 241, 15, 6, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(2063), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2062) },
                    { 191, 15, 15, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(1925), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(1924) },
                    { 177, 15, 10, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(1887), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(1886) },
                    { 147, 15, 19, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1804), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(1803) },
                    { 132, 15, 15, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1710), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(1709) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 117, 15, 2, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(1670), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(1669) },
                    { 110, 15, 5, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1651), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(1650) },
                    { 14, 15, 5, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1342), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(1340) },
                    { 466, 14, 3, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2828), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(2827) },
                    { 440, 14, 5, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(2757), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2755) },
                    { 415, 14, 16, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2687), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(2686) },
                    { 342, 14, 20, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2389), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2388) },
                    { 330, 14, 9, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2356), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2355) },
                    { 323, 14, 3, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(2337), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2336) },
                    { 252, 14, 9, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2093), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(2092) },
                    { 235, 14, 8, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2046), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(2045) },
                    { 228, 14, 5, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2027), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2025) },
                    { 224, 14, 2, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2015), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(2014) },
                    { 183, 14, 16, new DateTime(2021, 9, 5, 3, 8, 13, 898, DateTimeKind.Local).AddTicks(1903), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1902) },
                    { 155, 14, 2, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(1827), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1826) },
                    { 114, 14, 14, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(1662), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1661) },
                    { 56, 14, 11, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1502), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(1501) },
                    { 460, 31, 4, new DateTime(2021, 9, 5, 3, 8, 13, 898, DateTimeKind.Local).AddTicks(2811), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(2810) },
                    { 371, 5, 18, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(2566), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(2565) },
                    { 247, 5, 5, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2079), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(2078) },
                    { 158, 5, 17, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(1835), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(1834) },
                    { 487, 44, 19, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2930), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(2929) },
                    { 464, 44, 13, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2822), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(2821) },
                    { 433, 44, 10, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(2737), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(2736) },
                    { 416, 44, 2, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(2690), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2689) },
                    { 393, 44, 16, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(2627), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2626) },
                    { 370, 44, 9, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2563), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(2562) },
                    { 359, 44, 17, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2436), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2435) },
                    { 329, 44, 10, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2353), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(2352) },
                    { 279, 44, 5, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2215), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(2214) },
                    { 209, 44, 4, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(1975), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(1973) },
                    { 200, 44, 7, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(1950), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1949) },
                    { 152, 44, 8, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(1818), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(1817) },
                    { 96, 44, 1, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(1613), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(1612) },
                    { 31, 44, 10, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(1433), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(1432) },
                    { 388, 33, 10, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2613), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2612) },
                    { 239, 33, 10, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2057), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(2056) },
                    { 139, 33, 8, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1730), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(1729) },
                    { 499, 27, 6, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2962), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(2961) },
                    { 497, 27, 17, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(2957), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(2956) },
                    { 496, 27, 6, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(2954), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(2953) },
                    { 471, 27, 20, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2842), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(2841) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 351, 27, 9, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2414), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2413) },
                    { 343, 27, 19, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(2392), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(2391) },
                    { 320, 27, 11, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2329), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2328) },
                    { 315, 27, 1, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2315), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(2314) },
                    { 206, 27, 13, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1966), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(1965) },
                    { 176, 27, 19, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(1884), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(1883) },
                    { 1, 48, 9, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(1142), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(945) },
                    { 17, 48, 16, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(1351), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(1350) },
                    { 47, 48, 5, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(1477), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(1476) },
                    { 187, 48, 14, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(1914), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1913) },
                    { 157, 5, 9, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(1832), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(1831) },
                    { 50, 5, 10, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(1486), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(1484) },
                    { 25, 5, 16, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(1373), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(1372) },
                    { 480, 4, 17, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(2867), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(2865) },
                    { 455, 4, 8, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2798), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(2797) },
                    { 401, 4, 16, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2650), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(2648) },
                    { 375, 4, 3, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(2577), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(2576) },
                    { 347, 4, 8, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(2403), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(2402) },
                    { 288, 4, 20, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(2241), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2240) },
                    { 245, 4, 10, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2074), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2073) },
                    { 240, 4, 7, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(2060), new DateTime(2021, 9, 5, 2, 28, 13, 898, DateTimeKind.Local).AddTicks(2059) },
                    { 151, 4, 17, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1816), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1815) },
                    { 104, 4, 6, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1635), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(1634) },
                    { 335, 37, 12, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(2370), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(2369) },
                    { 88, 4, 18, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1591), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(1590) },
                    { 281, 2, 16, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2221), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(2220) },
                    { 234, 2, 10, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2044), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2042) },
                    { 203, 2, 6, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1958), new DateTime(2021, 9, 5, 2, 28, 13, 898, DateTimeKind.Local).AddTicks(1957) },
                    { 101, 2, 7, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(1626), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1625) },
                    { 51, 2, 20, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1488), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(1487) },
                    { 45, 2, 6, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(1472), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1471) },
                    { 37, 2, 3, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(1450), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(1449) },
                    { 34, 2, 17, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(1442), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1440) },
                    { 353, 48, 8, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2420), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2418) },
                    { 303, 48, 20, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2282), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2281) },
                    { 244, 48, 15, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2071), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2070) },
                    { 238, 48, 6, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2055), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2053) },
                    { 220, 48, 12, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2004), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(2003) },
                    { 431, 2, 12, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2732), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(2731) },
                    { 86, 27, 1, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(1585), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(1584) },
                    { 361, 37, 7, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2442), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2441) },
                    { 438, 37, 11, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(2751), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2750) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 348, 36, 6, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2406), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(2404) },
                    { 346, 36, 11, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2400), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2399) },
                    { 293, 36, 6, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2255), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(2254) },
                    { 257, 36, 1, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(2153) },
                    { 256, 36, 20, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(2151), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2150) },
                    { 188, 36, 17, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(1917), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1916) },
                    { 138, 36, 7, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(1727), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(1726) },
                    { 115, 36, 17, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(1664), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(1663) },
                    { 97, 36, 20, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1616), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(1615) },
                    { 65, 36, 17, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(1527), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(1526) },
                    { 62, 36, 7, new DateTime(2021, 9, 5, 3, 17, 13, 898, DateTimeKind.Local).AddTicks(1519), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(1518) },
                    { 498, 32, 3, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2958) },
                    { 432, 32, 10, new DateTime(2021, 9, 5, 3, 17, 13, 898, DateTimeKind.Local).AddTicks(2734), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(2733) },
                    { 424, 32, 14, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2712), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(2711) },
                    { 392, 32, 8, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(2624), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2623) },
                    { 387, 32, 7, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2610), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2609) },
                    { 326, 32, 12, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2345), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(2344) },
                    { 246, 32, 9, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2076), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2075) },
                    { 242, 32, 9, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2065), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(2064) },
                    { 129, 32, 19, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(1702), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(1701) },
                    { 66, 32, 14, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(1530), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(1529) },
                    { 418, 20, 15, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(2696), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(2695) },
                    { 366, 20, 15, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(2455), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(2454) },
                    { 267, 20, 15, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(2182), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(2181) },
                    { 253, 20, 1, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(2096), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2095) },
                    { 232, 20, 3, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2038), new DateTime(2021, 9, 5, 2, 4, 13, 898, DateTimeKind.Local).AddTicks(2037) },
                    { 118, 20, 3, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(1673), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1672) },
                    { 364, 36, 19, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(2450), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2449) },
                    { 107, 20, 17, new DateTime(2021, 9, 5, 3, 16, 13, 898, DateTimeKind.Local).AddTicks(1642), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(1641) },
                    { 403, 36, 6, new DateTime(2021, 9, 5, 3, 17, 13, 898, DateTimeKind.Local).AddTicks(2655), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2654) },
                    { 41, 40, 19, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1461), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(1460) },
                    { 434, 45, 20, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2740), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2739) },
                    { 429, 45, 1, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2726), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2725) },
                    { 414, 45, 19, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2685), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2684) },
                    { 233, 45, 8, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2041), new DateTime(2021, 9, 5, 2, 4, 13, 898, DateTimeKind.Local).AddTicks(2040) },
                    { 229, 45, 2, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2030), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(2028) },
                    { 189, 45, 20, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1919), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(1918) },
                    { 85, 45, 19, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1583), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1581) },
                    { 58, 45, 16, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(1508), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(1507) },
                    { 36, 45, 10, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(1447), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1446) },
                    { 485, 41, 3, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(2925), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2924) },
                    { 441, 41, 10, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(2759), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(2758) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 420, 41, 7, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(2701), new DateTime(2021, 9, 5, 1, 51, 13, 898, DateTimeKind.Local).AddTicks(2700) },
                    { 419, 41, 7, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2699), new DateTime(2021, 9, 5, 1, 49, 13, 898, DateTimeKind.Local).AddTicks(2697) },
                    { 350, 41, 3, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2411), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2410) },
                    { 237, 41, 19, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2052), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(2051) },
                    { 95, 41, 12, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(1610), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1609) },
                    { 476, 40, 3, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2855), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2854) },
                    { 445, 40, 8, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2770), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2769) },
                    { 317, 40, 11, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2320), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(2319) },
                    { 309, 40, 10, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2298), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2297) },
                    { 300, 40, 1, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(2274), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2273) },
                    { 278, 40, 15, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2213), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(2212) },
                    { 221, 40, 11, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(2007), new DateTime(2021, 9, 5, 1, 49, 13, 898, DateTimeKind.Local).AddTicks(2006) },
                    { 164, 40, 7, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1851), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1850) },
                    { 142, 40, 8, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1790), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1789) },
                    { 127, 40, 6, new DateTime(2021, 9, 5, 3, 2, 13, 898, DateTimeKind.Local).AddTicks(1697), new DateTime(2021, 9, 5, 2, 4, 13, 898, DateTimeKind.Local).AddTicks(1696) },
                    { 126, 40, 17, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(1694), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1693) },
                    { 16, 40, 4, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1347), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(1346) },
                    { 394, 12, 20, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(2630), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(2629) },
                    { 390, 12, 18, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2619), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(2618) },
                    { 372, 12, 17, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2569), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2568) },
                    { 23, 34, 2, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(1368), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(1366) },
                    { 8, 34, 18, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1324), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(1323) },
                    { 489, 23, 6, new DateTime(2021, 9, 5, 3, 17, 13, 898, DateTimeKind.Local).AddTicks(2935), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2934) },
                    { 333, 23, 10, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(2364), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(2363) },
                    { 298, 23, 5, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(2268), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2267) },
                    { 274, 23, 3, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2202), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2201) },
                    { 192, 23, 20, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(1928), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(1927) },
                    { 150, 23, 17, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(1813), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(1812) },
                    { 68, 23, 12, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(1535), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1534) },
                    { 57, 23, 13, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(1505), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1504) },
                    { 20, 23, 3, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(1359), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1358) },
                    { 458, 19, 9, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2806), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2805) },
                    { 453, 19, 2, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(2792), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2791) },
                    { 443, 19, 10, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2765), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(2764) },
                    { 408, 19, 19, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(2668), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2667) },
                    { 386, 19, 18, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2608), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2606) },
                    { 349, 19, 19, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2408), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(2407) },
                    { 304, 19, 8, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2285), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(2284) },
                    { 277, 19, 6, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(2210), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2209) },
                    { 255, 19, 11, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2149), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2147) },
                    { 251, 19, 1, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2091), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2089) },
                    { 250, 19, 12, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2088), new DateTime(2021, 9, 5, 1, 51, 13, 898, DateTimeKind.Local).AddTicks(2087) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 195, 19, 8, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(1936), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(1935) },
                    { 165, 19, 8, new DateTime(2021, 9, 5, 3, 2, 13, 898, DateTimeKind.Local).AddTicks(1854), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(1853) },
                    { 93, 19, 13, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1604), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(1603) },
                    { 71, 19, 12, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(1544), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(1542) },
                    { 61, 19, 4, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(1516), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1515) },
                    { 30, 34, 8, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(1430), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1429) },
                    { 112, 34, 6, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(1656), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(1655) },
                    { 199, 34, 20, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1947), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(1946) },
                    { 365, 34, 19, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2453), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(2451) },
                    { 327, 12, 10, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(2348), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(2347) },
                    { 318, 12, 13, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2323), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(2322) },
                    { 210, 12, 7, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(1977), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(1976) },
                    { 205, 12, 18, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(1964), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1963) },
                    { 135, 12, 6, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(1719), new DateTime(2021, 9, 5, 2, 28, 13, 898, DateTimeKind.Local).AddTicks(1718) },
                    { 81, 12, 8, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1571), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(1570) },
                    { 69, 12, 9, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1538), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(1537) },
                    { 15, 12, 11, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(1344), new DateTime(2021, 9, 5, 1, 51, 13, 898, DateTimeKind.Local).AddTicks(1343) },
                    { 397, 49, 5, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 9, 5, 1, 49, 13, 898, DateTimeKind.Local).AddTicks(2637) },
                    { 384, 49, 12, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(2602), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2601) },
                    { 382, 49, 20, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(2597), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2595) },
                    { 332, 49, 14, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(2361), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(2360) },
                    { 272, 49, 16, new DateTime(2021, 9, 5, 3, 16, 13, 898, DateTimeKind.Local).AddTicks(2196), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(2195) },
                    { 412, 37, 10, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2679), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2678) },
                    { 116, 49, 10, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1667), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(1666) },
                    { 367, 46, 4, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(2458), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2457) },
                    { 362, 46, 14, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2445), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(2443) },
                    { 344, 46, 4, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(2394), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(2393) },
                    { 340, 46, 3, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2384), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(2382) },
                    { 219, 46, 9, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2002), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(2001) },
                    { 204, 46, 18, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(1961), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(1960) },
                    { 146, 46, 6, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(1802), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(1801) },
                    { 120, 46, 15, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1678), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1677) },
                    { 108, 46, 16, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(1645), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(1644) },
                    { 18, 46, 4, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(1354), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1353) },
                    { 10, 46, 13, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(1330), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1329) },
                    { 478, 34, 6, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2861), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(2860) },
                    { 381, 34, 10, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2594), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(2593) },
                    { 439, 46, 15, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(2754), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(2753) },
                    { 459, 22, 20, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2808), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2807) },
                    { 321, 22, 20, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2331), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(2330) },
                    { 316, 22, 2, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2318), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2317) },
                    { 3, 3, 9, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1310), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(1309) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 488, 50, 17, new DateTime(2021, 9, 5, 3, 8, 13, 898, DateTimeKind.Local).AddTicks(2933), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2932) },
                    { 430, 50, 19, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2729), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2728) },
                    { 357, 50, 3, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2431), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(2430) },
                    { 328, 50, 5, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(2351), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(2350) },
                    { 325, 50, 20, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(2342), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(2341) },
                    { 289, 50, 10, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2244), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2243) },
                    { 174, 50, 5, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(1879), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(1878) },
                    { 166, 50, 6, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(1857), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1856) },
                    { 76, 50, 12, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(1558), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1557) },
                    { 22, 50, 7, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(1365), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(1364) },
                    { 490, 47, 19, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2938), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(2937) },
                    { 243, 47, 8, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2068), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(2067) },
                    { 171, 47, 19, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(1870), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(1869) },
                    { 163, 47, 5, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(1849), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(1848) },
                    { 105, 47, 18, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(1637), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1636) },
                    { 84, 47, 1, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1580), new DateTime(2021, 9, 5, 2, 28, 13, 898, DateTimeKind.Local).AddTicks(1579) },
                    { 63, 47, 20, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1522), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1521) },
                    { 32, 47, 8, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1436), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1435) },
                    { 423, 39, 4, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(2710), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(2708) },
                    { 417, 39, 17, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2693), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2692) },
                    { 399, 39, 13, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(2644), new DateTime(2021, 9, 5, 2, 4, 13, 898, DateTimeKind.Local).AddTicks(2643) },
                    { 373, 39, 16, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2572), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(2571) },
                    { 358, 39, 9, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2433), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(2432) },
                    { 264, 39, 9, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2174), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2173) },
                    { 261, 39, 16, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2166), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2164) },
                    { 185, 39, 4, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(1908), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(1907) },
                    { 5, 3, 18, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1316), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1315) },
                    { 170, 39, 8, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1868), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1867) },
                    { 33, 3, 11, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(1439), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(1437) },
                    { 67, 3, 7, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1533), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(1532) },
                    { 222, 8, 3, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(2010), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(2009) },
                    { 178, 8, 6, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1889), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(1888) },
                    { 495, 25, 2, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2951), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(2950) },
                    { 462, 25, 6, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2817), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(2815) },
                    { 442, 25, 18, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(2762), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(2761) },
                    { 427, 25, 6, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(2721), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(2720) },
                    { 398, 25, 6, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(2641), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2640) },
                    { 301, 25, 12, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(2276), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2275) },
                    { 263, 25, 2, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(2171), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2170) },
                    { 248, 25, 18, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2082), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2081) },
                    { 214, 25, 3, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(1988), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1987) },
                    { 202, 25, 4, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1955), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(1954) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 482, 18, 16, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(2917), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(2916) },
                    { 461, 18, 16, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(2814), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2813) },
                    { 360, 18, 8, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2439), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(2438) },
                    { 297, 18, 9, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2266), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(2265) },
                    { 284, 18, 8, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(2230), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2228) },
                    { 201, 18, 8, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(1953), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(1952) },
                    { 182, 18, 14, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1900), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1899) },
                    { 168, 18, 2, new DateTime(2021, 9, 5, 3, 16, 13, 898, DateTimeKind.Local).AddTicks(1862), new DateTime(2021, 9, 5, 1, 49, 13, 898, DateTimeKind.Local).AddTicks(1861) },
                    { 94, 18, 9, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(1607), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1606) },
                    { 92, 18, 16, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(1602), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(1601) },
                    { 4, 18, 10, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(1313), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(1311) },
                    { 470, 3, 15, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(2839), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(2838) },
                    { 426, 3, 2, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(2718), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(2717) },
                    { 196, 3, 12, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(1939), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1938) },
                    { 144, 3, 16, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(1796), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1795) },
                    { 48, 3, 12, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1480), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(1479) },
                    { 55, 39, 12, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1500), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(1498) },
                    { 40, 39, 13, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(1458), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1457) },
                    { 35, 39, 10, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(1444), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1443) },
                    { 143, 29, 10, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(1793), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1792) },
                    { 131, 29, 14, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(1708), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(1707) },
                    { 90, 29, 12, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(1596), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(1595) },
                    { 72, 29, 17, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1547), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1545) },
                    { 39, 29, 10, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(1455), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1454) },
                    { 421, 26, 19, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(2704), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(2703) },
                    { 413, 26, 16, new DateTime(2021, 9, 5, 3, 2, 13, 898, DateTimeKind.Local).AddTicks(2682), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2681) },
                    { 411, 26, 2, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(2677), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2676) },
                    { 231, 26, 12, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2035), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(2034) },
                    { 154, 26, 14, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(1824), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(1823) },
                    { 113, 26, 20, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(1659), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(1658) },
                    { 109, 26, 14, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(1648), new DateTime(2021, 9, 5, 1, 51, 13, 898, DateTimeKind.Local).AddTicks(1647) },
                    { 100, 26, 2, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(1624), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1623) },
                    { 91, 26, 12, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1599), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(1598) },
                    { 83, 26, 20, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1577), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(1576) },
                    { 339, 10, 5, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2381), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(2380) },
                    { 336, 10, 18, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(2373), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2371) },
                    { 494, 7, 16, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(2949), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(2948) },
                    { 469, 7, 2, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2836), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(2835) },
                    { 448, 7, 4, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2779), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2777) },
                    { 322, 7, 7, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(2334), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(2333) },
                    { 287, 7, 17, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(2238), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(2237) },
                    { 280, 7, 12, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2217) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 215, 7, 18, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(1991), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(1990) },
                    { 207, 7, 12, new DateTime(2021, 9, 5, 3, 8, 13, 898, DateTimeKind.Local).AddTicks(1969), new DateTime(2021, 9, 5, 2, 16, 13, 898, DateTimeKind.Local).AddTicks(1968) },
                    { 137, 7, 18, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(1724), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(1723) },
                    { 75, 7, 17, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(1555), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1554) },
                    { 148, 29, 5, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1807), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(1806) },
                    { 160, 29, 3, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(1840), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1839) },
                    { 268, 29, 20, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(2185), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(2184) },
                    { 402, 29, 13, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(2652), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(2651) },
                    { 24, 39, 5, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(1370), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1369) },
                    { 409, 38, 11, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(2671), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(2670) },
                    { 391, 38, 13, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2622), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2620) },
                    { 378, 38, 17, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2586), new DateTime(2021, 9, 5, 2, 28, 13, 898, DateTimeKind.Local).AddTicks(2585) },
                    { 319, 38, 11, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2326), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2325) },
                    { 307, 38, 19, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2293), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2292) },
                    { 296, 38, 8, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2263), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(2262) },
                    { 223, 38, 12, new DateTime(2021, 9, 5, 3, 6, 13, 898, DateTimeKind.Local).AddTicks(2013), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(2012) },
                    { 186, 38, 5, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1911), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(1910) },
                    { 141, 38, 12, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(1735), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(1734) },
                    { 99, 38, 4, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1621), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(1620) },
                    { 70, 38, 12, new DateTime(2021, 9, 5, 3, 19, 13, 898, DateTimeKind.Local).AddTicks(1541), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(1540) },
                    { 53, 38, 8, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1494), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(1493) },
                    { 254, 8, 14, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2099), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(2098) },
                    { 463, 35, 11, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(2819), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(2818) },
                    { 291, 35, 13, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(2249), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(2248) },
                    { 262, 35, 2, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2168), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(2167) },
                    { 184, 35, 6, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(1906), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1905) },
                    { 175, 35, 9, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(1880) },
                    { 161, 35, 10, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1843), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1842) },
                    { 103, 35, 20, new DateTime(2021, 9, 5, 2, 35, 13, 898, DateTimeKind.Local).AddTicks(1632), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(1631) },
                    { 43, 35, 6, new DateTime(2021, 9, 5, 3, 16, 13, 898, DateTimeKind.Local).AddTicks(1466), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(1465) },
                    { 19, 35, 17, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(1357), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(1356) },
                    { 472, 29, 20, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(2844), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2843) },
                    { 454, 29, 14, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2795), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(2794) },
                    { 450, 29, 6, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2784), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2783) },
                    { 437, 29, 4, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(2749), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2747) },
                    { 425, 29, 3, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(2715), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(2714) },
                    { 355, 35, 4, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(2424) },
                    { 260, 8, 7, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2163), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2162) },
                    { 331, 8, 19, new DateTime(2021, 9, 5, 3, 19, 13, 898, DateTimeKind.Local).AddTicks(2359), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2358) },
                    { 369, 8, 2, new DateTime(2021, 9, 5, 3, 11, 13, 898, DateTimeKind.Local).AddTicks(2561), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2559) },
                    { 216, 42, 3, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1994), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(1992) },
                    { 98, 42, 10, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(1618), new DateTime(2021, 9, 5, 2, 22, 13, 898, DateTimeKind.Local).AddTicks(1617) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 493, 30, 19, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2946), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(2945) },
                    { 422, 30, 1, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2707), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2706) },
                    { 379, 30, 19, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(2588), new DateTime(2021, 9, 5, 2, 3, 13, 898, DateTimeKind.Local).AddTicks(2587) },
                    { 356, 30, 11, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2428), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2427) },
                    { 225, 30, 12, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2018), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2017) },
                    { 211, 30, 7, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1980), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(1979) },
                    { 484, 28, 8, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2922), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2921) },
                    { 481, 28, 13, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2869), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2868) },
                    { 410, 28, 7, new DateTime(2021, 9, 5, 3, 8, 13, 898, DateTimeKind.Local).AddTicks(2674), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2673) },
                    { 275, 28, 2, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2205), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2203) },
                    { 218, 28, 19, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(1999), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(1998) },
                    { 212, 28, 4, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1983), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1982) },
                    { 197, 28, 1, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1942), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(1941) },
                    { 179, 28, 8, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1892), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1891) },
                    { 162, 28, 8, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(1846), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(1845) },
                    { 74, 28, 11, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(1552), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(1551) },
                    { 465, 11, 1, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(2825), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2824) },
                    { 290, 11, 3, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(2247), new DateTime(2021, 9, 5, 2, 32, 13, 898, DateTimeKind.Local).AddTicks(2246) },
                    { 271, 11, 1, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(2193), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2192) },
                    { 230, 11, 5, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(2032), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(2031) },
                    { 193, 11, 11, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1931), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(1930) },
                    { 181, 11, 1, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1898), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(1896) },
                    { 180, 11, 19, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1895), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(1894) },
                    { 173, 11, 6, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1876), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1875) },
                    { 172, 11, 15, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1873), new DateTime(2021, 9, 5, 1, 53, 13, 898, DateTimeKind.Local).AddTicks(1872) },
                    { 226, 42, 2, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(2021), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2020) },
                    { 270, 42, 9, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2191), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(2190) },
                    { 334, 42, 8, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(2367), new DateTime(2021, 9, 5, 1, 47, 13, 898, DateTimeKind.Local).AddTicks(2366) },
                    { 389, 42, 8, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(2616), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2615) },
                    { 308, 22, 1, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2296), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2295) },
                    { 213, 22, 16, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(1985), new DateTime(2021, 9, 5, 1, 55, 13, 898, DateTimeKind.Local).AddTicks(1984) },
                    { 169, 22, 4, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(1865), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1864) },
                    { 80, 22, 3, new DateTime(2021, 9, 5, 3, 13, 13, 898, DateTimeKind.Local).AddTicks(1569), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(1567) },
                    { 79, 22, 10, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1566), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(1565) },
                    { 491, 16, 7, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2941), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2940) },
                    { 457, 16, 5, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2803), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2802) },
                    { 312, 16, 4, new DateTime(2021, 9, 5, 3, 2, 13, 898, DateTimeKind.Local).AddTicks(2307), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(2306) },
                    { 294, 16, 9, new DateTime(2021, 9, 5, 2, 36, 13, 898, DateTimeKind.Local).AddTicks(2258), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2256) },
                    { 227, 16, 18, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(2024), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(2023) },
                    { 111, 16, 12, new DateTime(2021, 9, 5, 2, 42, 13, 898, DateTimeKind.Local).AddTicks(1653), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(1652) },
                    { 38, 16, 5, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(1452), new DateTime(2021, 9, 5, 2, 7, 13, 898, DateTimeKind.Local).AddTicks(1451) },
                    { 500, 6, 4, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2965), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(2964) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 106, 11, 15, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(1640), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(1639) },
                    { 492, 6, 1, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2943), new DateTime(2021, 9, 5, 1, 48, 13, 898, DateTimeKind.Local).AddTicks(2942) },
                    { 404, 6, 19, new DateTime(2021, 9, 5, 2, 43, 13, 898, DateTimeKind.Local).AddTicks(2657), new DateTime(2021, 9, 5, 2, 29, 13, 898, DateTimeKind.Local).AddTicks(2656) },
                    { 383, 6, 3, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(2599), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2598) },
                    { 363, 6, 13, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2447), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2446) },
                    { 306, 6, 10, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2290), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(2289) },
                    { 286, 6, 2, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(2235), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(2234) },
                    { 276, 6, 10, new DateTime(2021, 9, 5, 2, 58, 13, 898, DateTimeKind.Local).AddTicks(2207), new DateTime(2021, 9, 5, 2, 34, 13, 898, DateTimeKind.Local).AddTicks(2206) },
                    { 273, 6, 14, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2199), new DateTime(2021, 9, 5, 2, 10, 13, 898, DateTimeKind.Local).AddTicks(2198) },
                    { 265, 6, 5, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2177), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(2175) },
                    { 46, 6, 20, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1475), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(1474) },
                    { 29, 6, 3, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(1428), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(1427) },
                    { 21, 6, 6, new DateTime(2021, 9, 5, 2, 48, 13, 898, DateTimeKind.Local).AddTicks(1362), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(1361) },
                    { 9, 6, 20, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(1327), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(1326) },
                    { 444, 42, 18, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(2767), new DateTime(2021, 9, 5, 2, 18, 13, 898, DateTimeKind.Local).AddTicks(2766) },
                    { 451, 6, 20, new DateTime(2021, 9, 5, 3, 12, 13, 898, DateTimeKind.Local).AddTicks(2787), new DateTime(2021, 9, 5, 2, 23, 13, 898, DateTimeKind.Local).AddTicks(2786) },
                    { 467, 45, 4, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2831), new DateTime(2021, 9, 5, 2, 11, 13, 898, DateTimeKind.Local).AddTicks(2830) },
                    { 27, 11, 9, new DateTime(2021, 9, 5, 3, 2, 13, 898, DateTimeKind.Local).AddTicks(1379), new DateTime(2021, 9, 5, 2, 13, 13, 898, DateTimeKind.Local).AddTicks(1378) },
                    { 428, 1, 7, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(2723), new DateTime(2021, 9, 5, 2, 5, 13, 898, DateTimeKind.Local).AddTicks(2722) },
                    { 405, 21, 18, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(2660), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2659) },
                    { 295, 21, 18, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(2260), new DateTime(2021, 9, 5, 1, 57, 13, 898, DateTimeKind.Local).AddTicks(2259) },
                    { 167, 21, 1, new DateTime(2021, 9, 5, 2, 57, 13, 898, DateTimeKind.Local).AddTicks(1860), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(1858) },
                    { 140, 21, 5, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(1732), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(1731) },
                    { 89, 21, 9, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(1593), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(1592) },
                    { 49, 21, 14, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(1483), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(1482) },
                    { 12, 21, 15, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(1336), new DateTime(2021, 9, 5, 1, 49, 13, 898, DateTimeKind.Local).AddTicks(1335) },
                    { 11, 21, 4, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(1333), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(1332) },
                    { 477, 9, 20, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(2858), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2857) },
                    { 449, 9, 2, new DateTime(2021, 9, 5, 2, 39, 13, 898, DateTimeKind.Local).AddTicks(2781), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(2780) },
                    { 407, 9, 3, new DateTime(2021, 9, 5, 2, 53, 13, 898, DateTimeKind.Local).AddTicks(2666), new DateTime(2021, 9, 5, 1, 56, 13, 898, DateTimeKind.Local).AddTicks(2665) },
                    { 396, 9, 19, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(2636), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(2634) },
                    { 368, 9, 12, new DateTime(2021, 9, 5, 3, 10, 13, 898, DateTimeKind.Local).AddTicks(2558), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(2556) },
                    { 338, 9, 12, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2378), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2377) },
                    { 324, 9, 20, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(2340), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(2339) },
                    { 302, 9, 17, new DateTime(2021, 9, 5, 2, 55, 13, 898, DateTimeKind.Local).AddTicks(2279), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2278) },
                    { 269, 9, 4, new DateTime(2021, 9, 5, 2, 37, 13, 898, DateTimeKind.Local).AddTicks(2188), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(2187) },
                    { 217, 9, 2, new DateTime(2021, 9, 5, 2, 47, 13, 898, DateTimeKind.Local).AddTicks(1996), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(1995) },
                    { 159, 9, 20, new DateTime(2021, 9, 5, 3, 20, 13, 898, DateTimeKind.Local).AddTicks(1838), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(1836) },
                    { 149, 9, 2, new DateTime(2021, 9, 5, 2, 40, 13, 898, DateTimeKind.Local).AddTicks(1810), new DateTime(2021, 9, 5, 2, 0, 13, 898, DateTimeKind.Local).AddTicks(1809) },
                    { 134, 9, 13, new DateTime(2021, 9, 5, 2, 45, 13, 898, DateTimeKind.Local).AddTicks(1716), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(1715) },
                    { 124, 9, 20, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1689), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(1688) },
                    { 82, 9, 13, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1574), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1573) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 77, 9, 12, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1560), new DateTime(2021, 9, 5, 2, 20, 13, 898, DateTimeKind.Local).AddTicks(1559) },
                    { 13, 9, 20, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(1339), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(1337) },
                    { 475, 8, 17, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2853), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2851) },
                    { 374, 8, 6, new DateTime(2021, 9, 5, 3, 24, 13, 898, DateTimeKind.Local).AddTicks(2575), new DateTime(2021, 9, 5, 1, 46, 13, 898, DateTimeKind.Local).AddTicks(2573) },
                    { 436, 21, 6, new DateTime(2021, 9, 5, 3, 3, 13, 898, DateTimeKind.Local).AddTicks(2746), new DateTime(2021, 9, 5, 1, 54, 13, 898, DateTimeKind.Local).AddTicks(2744) },
                    { 473, 21, 2, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(2847), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(2846) },
                    { 7, 24, 1, new DateTime(2021, 9, 5, 2, 50, 13, 898, DateTimeKind.Local).AddTicks(1321), new DateTime(2021, 9, 5, 2, 2, 13, 898, DateTimeKind.Local).AddTicks(1320) },
                    { 28, 24, 5, new DateTime(2021, 9, 5, 3, 19, 13, 898, DateTimeKind.Local).AddTicks(1424), new DateTime(2021, 9, 5, 2, 33, 13, 898, DateTimeKind.Local).AddTicks(1423) },
                    { 314, 1, 4, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(2312), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2311) },
                    { 285, 1, 18, new DateTime(2021, 9, 5, 2, 51, 13, 898, DateTimeKind.Local).AddTicks(2232), new DateTime(2021, 9, 5, 2, 21, 13, 898, DateTimeKind.Local).AddTicks(2231) },
                    { 236, 1, 11, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(2049), new DateTime(2021, 9, 5, 2, 9, 13, 898, DateTimeKind.Local).AddTicks(2048) },
                    { 198, 1, 14, new DateTime(2021, 9, 5, 2, 49, 13, 898, DateTimeKind.Local).AddTicks(1945), new DateTime(2021, 9, 5, 2, 15, 13, 898, DateTimeKind.Local).AddTicks(1943) },
                    { 156, 1, 20, new DateTime(2021, 9, 5, 3, 7, 13, 898, DateTimeKind.Local).AddTicks(1830), new DateTime(2021, 9, 5, 2, 12, 13, 898, DateTimeKind.Local).AddTicks(1828) },
                    { 123, 1, 11, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(1686), new DateTime(2021, 9, 5, 1, 52, 13, 898, DateTimeKind.Local).AddTicks(1685) },
                    { 119, 1, 17, new DateTime(2021, 9, 5, 2, 52, 13, 898, DateTimeKind.Local).AddTicks(1675), new DateTime(2021, 9, 5, 2, 31, 13, 898, DateTimeKind.Local).AddTicks(1674) },
                    { 60, 1, 3, new DateTime(2021, 9, 5, 2, 56, 13, 898, DateTimeKind.Local).AddTicks(1513), new DateTime(2021, 9, 5, 2, 17, 13, 898, DateTimeKind.Local).AddTicks(1512) },
                    { 2, 1, 9, new DateTime(2021, 9, 5, 2, 46, 13, 898, DateTimeKind.Local).AddTicks(1307), new DateTime(2021, 9, 5, 1, 51, 13, 898, DateTimeKind.Local).AddTicks(1305) },
                    { 380, 43, 3, new DateTime(2021, 9, 5, 3, 22, 13, 898, DateTimeKind.Local).AddTicks(2591), new DateTime(2021, 9, 5, 2, 19, 13, 898, DateTimeKind.Local).AddTicks(2590) },
                    { 352, 43, 15, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(2417), new DateTime(2021, 9, 5, 2, 1, 13, 898, DateTimeKind.Local).AddTicks(2416) },
                    { 313, 43, 14, new DateTime(2021, 9, 5, 2, 41, 13, 898, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 9, 5, 1, 50, 13, 898, DateTimeKind.Local).AddTicks(2308) },
                    { 310, 43, 5, new DateTime(2021, 9, 5, 3, 0, 13, 898, DateTimeKind.Local).AddTicks(2301), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(2300) },
                    { 483, 1, 15, new DateTime(2021, 9, 5, 3, 15, 13, 898, DateTimeKind.Local).AddTicks(2919), new DateTime(2021, 9, 5, 2, 26, 13, 898, DateTimeKind.Local).AddTicks(2918) },
                    { 299, 43, 14, new DateTime(2021, 9, 5, 2, 59, 13, 898, DateTimeKind.Local).AddTicks(2271), new DateTime(2021, 9, 5, 1, 45, 13, 898, DateTimeKind.Local).AddTicks(2270) },
                    { 133, 43, 6, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1713), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1712) },
                    { 130, 43, 4, new DateTime(2021, 9, 5, 3, 14, 13, 898, DateTimeKind.Local).AddTicks(1705), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(1704) },
                    { 54, 43, 6, new DateTime(2021, 9, 5, 2, 44, 13, 898, DateTimeKind.Local).AddTicks(1497), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(1495) },
                    { 44, 43, 13, new DateTime(2021, 9, 5, 3, 5, 13, 898, DateTimeKind.Local).AddTicks(1469), new DateTime(2021, 9, 5, 1, 58, 13, 898, DateTimeKind.Local).AddTicks(1468) },
                    { 435, 24, 7, new DateTime(2021, 9, 5, 3, 9, 13, 898, DateTimeKind.Local).AddTicks(2743), new DateTime(2021, 9, 5, 2, 30, 13, 898, DateTimeKind.Local).AddTicks(2742) },
                    { 406, 24, 14, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(2663), new DateTime(2021, 9, 5, 2, 8, 13, 898, DateTimeKind.Local).AddTicks(2662) },
                    { 282, 24, 16, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(2224), new DateTime(2021, 9, 5, 2, 4, 13, 898, DateTimeKind.Local).AddTicks(2223) },
                    { 145, 24, 8, new DateTime(2021, 9, 5, 3, 4, 13, 898, DateTimeKind.Local).AddTicks(1799), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1798) },
                    { 136, 24, 1, new DateTime(2021, 9, 5, 3, 23, 13, 898, DateTimeKind.Local).AddTicks(1721), new DateTime(2021, 9, 5, 2, 25, 13, 898, DateTimeKind.Local).AddTicks(1720) },
                    { 125, 24, 18, new DateTime(2021, 9, 5, 2, 54, 13, 898, DateTimeKind.Local).AddTicks(1692), new DateTime(2021, 9, 5, 2, 6, 13, 898, DateTimeKind.Local).AddTicks(1691) },
                    { 78, 24, 7, new DateTime(2021, 9, 5, 3, 17, 13, 898, DateTimeKind.Local).AddTicks(1563), new DateTime(2021, 9, 5, 1, 59, 13, 898, DateTimeKind.Local).AddTicks(1562) },
                    { 64, 24, 3, new DateTime(2021, 9, 5, 3, 1, 13, 898, DateTimeKind.Local).AddTicks(1524), new DateTime(2021, 9, 5, 2, 14, 13, 898, DateTimeKind.Local).AddTicks(1523) },
                    { 52, 24, 8, new DateTime(2021, 9, 5, 2, 38, 13, 898, DateTimeKind.Local).AddTicks(1491), new DateTime(2021, 9, 5, 1, 51, 13, 898, DateTimeKind.Local).AddTicks(1490) },
                    { 266, 43, 11, new DateTime(2021, 9, 5, 3, 21, 13, 898, DateTimeKind.Local).AddTicks(2179), new DateTime(2021, 9, 5, 2, 24, 13, 898, DateTimeKind.Local).AddTicks(2178) },
                    { 486, 45, 18, new DateTime(2021, 9, 5, 3, 18, 13, 898, DateTimeKind.Local).AddTicks(2927), new DateTime(2021, 9, 5, 2, 27, 13, 898, DateTimeKind.Local).AddTicks(2926) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Customers_CustomerId",
                table: "Calls",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Employees_EmployeeId",
                table: "Calls",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Customers_CustomerId",
                table: "Calls");

            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Employees_EmployeeId",
                table: "Calls");

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "sp", "Barcelona" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "fr", "Leon" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "sp", "Madrid" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "it", "Milan" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "fr", "Nice" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "fr", "Paris" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "it", "Rome" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "sp", "Saratoga" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumns: new[] { "CountryCode", "Name" },
                keyValues: new object[] { "it", "Venice" });

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "fr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "it");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "sp");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Calls",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Calls",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Customers_CustomerId",
                table: "Calls",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Employees_EmployeeId",
                table: "Calls",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
