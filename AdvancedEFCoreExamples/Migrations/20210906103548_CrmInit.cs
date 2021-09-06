using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedEFCoreExamples.Migrations
{
    public partial class CrmInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outcomes",
                columns: table => new
                {
                    CallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outcomes", x => x.CallId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Latitude = table.Column<long>(type: "bigint", nullable: true),
                    Longitude = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => new { x.Name, x.CountryCode });
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CityCountryCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextCall = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityName_CityCountryCode",
                        columns: x => new { x.CityName, x.CityCountryCode },
                        principalTable: "Cities",
                        principalColumns: new[] { "Name", "CountryCode" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutcomeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calls_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calls_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calls_Outcomes_OutcomeId",
                        column: x => x.OutcomeId,
                        principalTable: "Outcomes",
                        principalColumn: "CallId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 20, "fName25", new DateTime(2019, 3, 14, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1193), "LName31" },
                    { 1, "fName39", new DateTime(2019, 7, 27, 13, 35, 48, 556, DateTimeKind.Local).AddTicks(2375), "LName15" },
                    { 2, "fName31", new DateTime(2020, 3, 30, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1053), "LName25" },
                    { 3, "fName45", new DateTime(2019, 3, 31, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1078), "LName29" },
                    { 4, "fName13", new DateTime(2020, 1, 18, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1082), "LName36" },
                    { 5, "fName23", new DateTime(2019, 3, 23, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1084), "LName38" },
                    { 6, "fName16", new DateTime(2019, 1, 9, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1086), "LName45" },
                    { 7, "fName29", new DateTime(2019, 6, 4, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1088), "LName14" },
                    { 19, "fName35", new DateTime(2019, 12, 16, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1190), "LName15" },
                    { 9, "fName1", new DateTime(2019, 9, 22, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1166), "LName34" },
                    { 10, "fName35", new DateTime(2019, 10, 2, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1168), "LName31" },
                    { 11, "fName37", new DateTime(2019, 11, 3, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1171), "LName36" },
                    { 12, "fName15", new DateTime(2019, 8, 11, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1173), "LName16" },
                    { 13, "fName46", new DateTime(2019, 11, 22, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1175), "LName14" },
                    { 14, "fName6", new DateTime(2019, 10, 3, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1179), "LName48" },
                    { 15, "fName33", new DateTime(2019, 11, 21, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1181), "LName28" },
                    { 16, "fName49", new DateTime(2019, 3, 15, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1184), "LName36" },
                    { 17, "fName45", new DateTime(2019, 8, 12, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1186), "LName25" },
                    { 18, "fName42", new DateTime(2020, 4, 2, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1188), "LName37" },
                    { 8, "fName25", new DateTime(2020, 4, 2, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(1162), "LName3" }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 340, null, 2 },
                    { 341, null, 2 },
                    { 342, null, 2 },
                    { 343, null, 2 },
                    { 344, null, 1 },
                    { 348, null, 2 },
                    { 346, null, 0 },
                    { 347, null, 0 },
                    { 339, null, 1 },
                    { 349, null, 1 },
                    { 345, null, 2 },
                    { 338, null, 2 },
                    { 332, null, 0 },
                    { 336, null, 2 },
                    { 335, null, 0 },
                    { 334, null, 0 },
                    { 333, null, 1 },
                    { 350, null, 0 },
                    { 331, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 330, null, 0 },
                    { 329, null, 2 },
                    { 328, null, 1 },
                    { 327, null, 1 },
                    { 326, null, 0 },
                    { 325, null, 0 },
                    { 337, null, 0 },
                    { 351, null, 2 },
                    { 357, null, 1 },
                    { 353, null, 2 },
                    { 379, null, 2 },
                    { 378, null, 1 },
                    { 377, null, 1 },
                    { 376, null, 1 },
                    { 375, null, 1 },
                    { 374, null, 2 },
                    { 373, null, 0 },
                    { 372, null, 1 },
                    { 371, null, 0 },
                    { 370, null, 2 },
                    { 369, null, 2 },
                    { 368, null, 2 },
                    { 352, null, 2 },
                    { 367, null, 1 },
                    { 365, null, 0 },
                    { 364, null, 1 },
                    { 363, null, 1 },
                    { 362, null, 2 },
                    { 361, null, 1 },
                    { 360, null, 0 },
                    { 359, null, 0 },
                    { 358, null, 2 },
                    { 324, null, 1 },
                    { 356, null, 0 },
                    { 355, null, 2 },
                    { 354, null, 2 },
                    { 366, null, 1 },
                    { 323, null, 0 },
                    { 318, null, 1 },
                    { 321, null, 0 },
                    { 289, null, 1 },
                    { 288, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 287, null, 2 },
                    { 286, null, 0 },
                    { 285, null, 2 },
                    { 284, null, 2 },
                    { 283, null, 0 },
                    { 282, null, 2 },
                    { 281, null, 2 },
                    { 280, null, 1 },
                    { 279, null, 0 },
                    { 278, null, 2 },
                    { 290, null, 2 },
                    { 277, null, 1 },
                    { 275, null, 1 },
                    { 274, null, 0 },
                    { 273, null, 2 },
                    { 272, null, 0 },
                    { 271, null, 1 },
                    { 270, null, 1 },
                    { 269, null, 1 },
                    { 268, null, 2 },
                    { 267, null, 0 },
                    { 266, null, 0 },
                    { 265, null, 0 },
                    { 264, null, 1 },
                    { 276, null, 1 },
                    { 291, null, 0 },
                    { 292, null, 1 },
                    { 293, null, 2 },
                    { 320, null, 0 },
                    { 319, null, 2 },
                    { 380, null, 2 },
                    { 317, null, 0 },
                    { 316, null, 0 },
                    { 315, null, 2 },
                    { 314, null, 2 },
                    { 313, null, 0 },
                    { 312, null, 0 },
                    { 311, null, 2 },
                    { 310, null, 0 },
                    { 309, null, 1 },
                    { 308, null, 0 },
                    { 307, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 306, null, 2 },
                    { 305, null, 1 },
                    { 304, null, 0 },
                    { 303, null, 1 },
                    { 302, null, 2 },
                    { 301, null, 0 },
                    { 300, null, 2 },
                    { 299, null, 0 },
                    { 298, null, 1 },
                    { 297, null, 1 },
                    { 296, null, 0 },
                    { 295, null, 1 },
                    { 294, null, 1 },
                    { 322, null, 0 },
                    { 381, null, 2 },
                    { 386, null, 0 },
                    { 383, null, 0 },
                    { 470, null, 2 },
                    { 469, null, 0 },
                    { 468, null, 2 },
                    { 467, null, 0 },
                    { 466, null, 2 },
                    { 465, null, 2 },
                    { 464, null, 1 },
                    { 463, null, 1 },
                    { 462, null, 0 },
                    { 461, null, 2 },
                    { 460, null, 0 },
                    { 459, null, 2 },
                    { 471, null, 0 },
                    { 458, null, 0 },
                    { 456, null, 0 },
                    { 455, null, 0 },
                    { 454, null, 1 },
                    { 453, null, 0 },
                    { 452, null, 1 },
                    { 451, null, 1 },
                    { 450, null, 2 },
                    { 449, null, 2 },
                    { 448, null, 2 },
                    { 447, null, 0 },
                    { 446, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 445, null, 0 },
                    { 457, null, 0 },
                    { 444, null, 1 },
                    { 472, null, 0 },
                    { 474, null, 1 },
                    { 500, null, 1 },
                    { 499, null, 1 },
                    { 498, null, 2 },
                    { 497, null, 2 },
                    { 496, null, 2 },
                    { 495, null, 2 },
                    { 494, null, 2 },
                    { 493, null, 2 },
                    { 492, null, 1 },
                    { 491, null, 0 },
                    { 490, null, 2 },
                    { 489, null, 0 },
                    { 473, null, 2 },
                    { 488, null, 1 },
                    { 486, null, 2 },
                    { 485, null, 2 },
                    { 484, null, 1 },
                    { 483, null, 2 },
                    { 482, null, 2 },
                    { 481, null, 2 },
                    { 480, null, 0 },
                    { 479, null, 2 },
                    { 478, null, 2 },
                    { 477, null, 1 },
                    { 476, null, 1 },
                    { 475, null, 2 },
                    { 487, null, 2 },
                    { 382, null, 1 },
                    { 443, null, 0 },
                    { 441, null, 0 },
                    { 410, null, 0 },
                    { 409, null, 1 },
                    { 408, null, 2 },
                    { 407, null, 2 },
                    { 406, null, 1 },
                    { 405, null, 2 },
                    { 404, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 403, null, 0 },
                    { 402, null, 1 },
                    { 401, null, 2 },
                    { 400, null, 0 },
                    { 399, null, 1 },
                    { 411, null, 2 },
                    { 398, null, 1 },
                    { 396, null, 0 },
                    { 395, null, 1 },
                    { 394, null, 0 },
                    { 393, null, 2 },
                    { 263, null, 0 },
                    { 391, null, 1 },
                    { 390, null, 2 },
                    { 389, null, 1 },
                    { 388, null, 2 },
                    { 387, null, 1 },
                    { 385, null, 0 },
                    { 384, null, 2 },
                    { 397, null, 0 },
                    { 442, null, 1 },
                    { 412, null, 0 },
                    { 414, null, 0 },
                    { 440, null, 2 },
                    { 439, null, 2 },
                    { 438, null, 1 },
                    { 437, null, 1 },
                    { 436, null, 1 },
                    { 435, null, 2 },
                    { 434, null, 1 },
                    { 433, null, 2 },
                    { 432, null, 0 },
                    { 431, null, 0 },
                    { 430, null, 0 },
                    { 429, null, 0 },
                    { 413, null, 0 },
                    { 428, null, 2 },
                    { 426, null, 2 },
                    { 425, null, 1 },
                    { 424, null, 2 },
                    { 423, null, 0 },
                    { 422, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 421, null, 0 },
                    { 420, null, 2 },
                    { 419, null, 0 },
                    { 418, null, 2 },
                    { 417, null, 1 },
                    { 416, null, 2 },
                    { 415, null, 0 },
                    { 427, null, 1 },
                    { 392, null, 0 },
                    { 262, null, 1 },
                    { 260, null, 1 },
                    { 95, null, 2 },
                    { 94, null, 2 },
                    { 93, null, 1 },
                    { 92, null, 0 },
                    { 91, null, 0 },
                    { 90, null, 0 },
                    { 89, null, 0 },
                    { 88, null, 1 },
                    { 87, null, 2 },
                    { 86, null, 1 },
                    { 85, null, 2 },
                    { 84, null, 1 },
                    { 83, null, 0 },
                    { 96, null, 1 },
                    { 82, null, 0 },
                    { 80, null, 1 },
                    { 79, null, 0 },
                    { 78, null, 0 },
                    { 77, null, 0 },
                    { 76, null, 1 },
                    { 75, null, 0 },
                    { 74, null, 0 },
                    { 73, null, 2 },
                    { 72, null, 1 },
                    { 71, null, 2 },
                    { 70, null, 1 },
                    { 69, null, 1 },
                    { 68, null, 1 },
                    { 81, null, 0 },
                    { 97, null, 1 },
                    { 98, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 99, null, 1 },
                    { 128, null, 0 },
                    { 127, null, 0 },
                    { 126, null, 1 },
                    { 125, null, 1 },
                    { 124, null, 0 },
                    { 123, null, 0 },
                    { 122, null, 1 },
                    { 121, null, 2 },
                    { 120, null, 2 },
                    { 119, null, 0 },
                    { 118, null, 1 },
                    { 117, null, 1 },
                    { 116, null, 2 },
                    { 115, null, 2 },
                    { 114, null, 1 },
                    { 113, null, 2 },
                    { 112, null, 0 },
                    { 111, null, 2 },
                    { 110, null, 2 },
                    { 109, null, 1 },
                    { 108, null, 2 },
                    { 107, null, 0 },
                    { 106, null, 1 },
                    { 105, null, 2 },
                    { 104, null, 1 },
                    { 103, null, 2 },
                    { 102, null, 0 },
                    { 101, null, 2 },
                    { 100, null, 0 },
                    { 67, null, 0 },
                    { 66, null, 1 },
                    { 65, null, 0 },
                    { 64, null, 2 },
                    { 30, null, 1 },
                    { 29, null, 2 },
                    { 28, null, 2 },
                    { 27, null, 0 },
                    { 26, null, 0 },
                    { 25, null, 0 },
                    { 24, null, 0 },
                    { 23, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 22, null, 0 },
                    { 21, null, 0 },
                    { 20, null, 0 },
                    { 19, null, 2 },
                    { 18, null, 2 },
                    { 17, null, 2 },
                    { 16, null, 2 },
                    { 15, null, 0 },
                    { 14, null, 0 },
                    { 13, null, 2 },
                    { 12, null, 0 },
                    { 11, null, 1 },
                    { 10, null, 0 },
                    { 9, null, 1 },
                    { 8, null, 2 },
                    { 7, null, 1 },
                    { 6, null, 2 },
                    { 5, null, 0 },
                    { 4, null, 0 },
                    { 3, null, 0 },
                    { 2, null, 2 },
                    { 31, null, 2 },
                    { 129, null, 0 },
                    { 32, null, 2 },
                    { 34, null, 1 },
                    { 63, null, 2 },
                    { 62, null, 2 },
                    { 61, null, 2 },
                    { 60, null, 0 },
                    { 59, null, 2 },
                    { 58, null, 2 },
                    { 57, null, 1 },
                    { 56, null, 0 },
                    { 55, null, 0 },
                    { 54, null, 2 },
                    { 53, null, 0 },
                    { 52, null, 0 },
                    { 51, null, 2 },
                    { 50, null, 1 },
                    { 49, null, 2 },
                    { 48, null, 0 },
                    { 47, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 46, null, 2 },
                    { 45, null, 2 },
                    { 44, null, 2 },
                    { 43, null, 2 },
                    { 42, null, 1 },
                    { 41, null, 0 },
                    { 40, null, 2 },
                    { 39, null, 0 },
                    { 38, null, 0 },
                    { 37, null, 0 },
                    { 36, null, 1 },
                    { 35, null, 1 },
                    { 33, null, 0 },
                    { 261, null, 0 },
                    { 130, null, 2 },
                    { 132, null, 0 },
                    { 226, null, 0 },
                    { 225, null, 2 },
                    { 224, null, 0 },
                    { 223, null, 0 },
                    { 222, null, 2 },
                    { 221, null, 0 },
                    { 220, null, 2 },
                    { 219, null, 1 },
                    { 218, null, 2 },
                    { 217, null, 0 },
                    { 216, null, 0 },
                    { 215, null, 1 },
                    { 214, null, 1 },
                    { 227, null, 1 },
                    { 213, null, 2 },
                    { 211, null, 1 },
                    { 210, null, 0 },
                    { 209, null, 1 },
                    { 208, null, 2 },
                    { 207, null, 0 },
                    { 206, null, 1 },
                    { 205, null, 2 },
                    { 204, null, 0 },
                    { 203, null, 1 },
                    { 202, null, 2 },
                    { 201, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 200, null, 1 },
                    { 199, null, 2 },
                    { 212, null, 0 },
                    { 228, null, 2 },
                    { 229, null, 2 },
                    { 230, null, 0 },
                    { 259, null, 0 },
                    { 258, null, 0 },
                    { 257, null, 2 },
                    { 256, null, 1 },
                    { 255, null, 1 },
                    { 254, null, 2 },
                    { 253, null, 1 },
                    { 252, null, 0 },
                    { 251, null, 0 },
                    { 250, null, 2 },
                    { 249, null, 2 },
                    { 248, null, 2 },
                    { 247, null, 1 },
                    { 246, null, 1 },
                    { 245, null, 2 },
                    { 244, null, 0 },
                    { 243, null, 0 },
                    { 242, null, 1 },
                    { 241, null, 1 },
                    { 240, null, 1 },
                    { 239, null, 0 },
                    { 238, null, 2 },
                    { 237, null, 1 },
                    { 236, null, 0 },
                    { 235, null, 0 },
                    { 234, null, 0 },
                    { 233, null, 2 },
                    { 232, null, 1 },
                    { 231, null, 0 },
                    { 198, null, 0 },
                    { 197, null, 0 },
                    { 196, null, 0 },
                    { 195, null, 0 },
                    { 161, null, 0 },
                    { 160, null, 1 },
                    { 159, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 158, null, 2 },
                    { 157, null, 0 },
                    { 156, null, 0 },
                    { 155, null, 1 },
                    { 154, null, 2 },
                    { 153, null, 2 },
                    { 152, null, 0 },
                    { 151, null, 2 },
                    { 150, null, 0 },
                    { 149, null, 0 },
                    { 148, null, 0 },
                    { 147, null, 1 },
                    { 146, null, 2 },
                    { 145, null, 0 },
                    { 144, null, 1 },
                    { 143, null, 2 },
                    { 142, null, 2 },
                    { 141, null, 1 },
                    { 140, null, 1 },
                    { 139, null, 1 },
                    { 138, null, 1 },
                    { 137, null, 0 },
                    { 136, null, 2 },
                    { 135, null, 2 },
                    { 134, null, 0 },
                    { 133, null, 2 },
                    { 162, null, 0 },
                    { 131, null, 2 },
                    { 163, null, 2 },
                    { 165, null, 2 },
                    { 194, null, 0 },
                    { 193, null, 1 },
                    { 192, null, 1 },
                    { 191, null, 2 },
                    { 190, null, 1 },
                    { 189, null, 1 },
                    { 188, null, 2 },
                    { 187, null, 1 },
                    { 186, null, 2 },
                    { 185, null, 0 },
                    { 184, null, 2 },
                    { 183, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Outcomes",
                columns: new[] { "CallId", "Comments", "Type" },
                values: new object[,]
                {
                    { 182, null, 0 },
                    { 181, null, 2 },
                    { 180, null, 1 },
                    { 179, null, 2 },
                    { 178, null, 2 },
                    { 177, null, 1 },
                    { 176, null, 0 },
                    { 175, null, 0 },
                    { 174, null, 2 },
                    { 173, null, 2 },
                    { 172, null, 0 },
                    { 171, null, 1 },
                    { 170, null, 2 },
                    { 169, null, 1 },
                    { 168, null, 2 },
                    { 167, null, 1 },
                    { 166, null, 2 },
                    { 164, null, 2 },
                    { 1, null, 1 }
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
                    { 16, null, "it", "Rome", "fName55 Lname84", new DateTime(2021, 9, 29, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7153) },
                    { 4, null, "fr", "Leon", "fName49 Lname46", new DateTime(2021, 9, 19, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7107) },
                    { 8, null, "fr", "Leon", "fName2 Lname38", new DateTime(2021, 9, 28, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7124) },
                    { 9, null, "fr", "Leon", "fName50 Lname73", new DateTime(2021, 10, 15, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7127) },
                    { 23, null, "fr", "Leon", "fName48 Lname56", new DateTime(2021, 10, 7, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7282) },
                    { 27, null, "fr", "Leon", "fName93 Lname53", new DateTime(2021, 9, 23, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7296) },
                    { 34, null, "fr", "Leon", "fName80 Lname22", new DateTime(2021, 10, 7, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7321) },
                    { 40, null, "fr", "Leon", "fName73 Lname7", new DateTime(2021, 10, 1, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7341) },
                    { 45, null, "fr", "Leon", "fName32 Lname117", new DateTime(2021, 9, 9, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7358) },
                    { 47, null, "fr", "Leon", "fName77 Lname46", new DateTime(2021, 10, 2, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7365) },
                    { 13, null, "sp", "Madrid", "fName46 Lname69", new DateTime(2021, 10, 15, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7142) },
                    { 14, null, "sp", "Madrid", "fName60 Lname128", new DateTime(2021, 9, 8, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7146) },
                    { 21, null, "sp", "Madrid", "fName73 Lname85", new DateTime(2021, 9, 14, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7171) },
                    { 28, null, "sp", "Madrid", "fName47 Lname111", new DateTime(2021, 9, 19, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7299) },
                    { 37, null, "sp", "Madrid", "fName13 Lname116", new DateTime(2021, 9, 26, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7331) },
                    { 5, null, "sp", "Barcelona", "fName48 Lname110", new DateTime(2021, 9, 8, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7110) },
                    { 24, null, "sp", "Barcelona", "fName43 Lname41", new DateTime(2021, 10, 6, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7286) },
                    { 26, null, "sp", "Barcelona", "fName8 Lname38", new DateTime(2021, 9, 17, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7293) },
                    { 29, null, "sp", "Barcelona", "fName44 Lname140", new DateTime(2021, 9, 22, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7303) },
                    { 48, null, "sp", "Barcelona", "fName19 Lname6", new DateTime(2021, 10, 14, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7368) },
                    { 6, null, "sp", "Saratoga", "fName62 Lname118", new DateTime(2021, 9, 14, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7117) },
                    { 7, null, "sp", "Saratoga", "fName89 Lname147", new DateTime(2021, 9, 22, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7120) },
                    { 1, null, "fr", "Leon", "fName20 Lname144", new DateTime(2021, 9, 25, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(6872) },
                    { 38, null, "fr", "Nice", "fName97 Lname92", new DateTime(2021, 10, 6, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7334) },
                    { 35, null, "fr", "Nice", "fName36 Lname72", new DateTime(2021, 10, 7, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7324) },
                    { 22, null, "fr", "Nice", "fName47 Lname101", new DateTime(2021, 9, 10, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7174) },
                    { 17, null, "it", "Rome", "fName93 Lname147", new DateTime(2021, 9, 14, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7156) },
                    { 18, null, "it", "Rome", "fName53 Lname118", new DateTime(2021, 10, 3, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7160) },
                    { 25, null, "it", "Rome", "fName91 Lname90", new DateTime(2021, 9, 17, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7289) },
                    { 39, null, "it", "Rome", "fName5 Lname139", new DateTime(2021, 10, 23, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7338) },
                    { 42, null, "it", "Rome", "fName41 Lname103", new DateTime(2021, 9, 9, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7348) },
                    { 11, null, "it", "Venice", "fName57 Lname54", new DateTime(2021, 10, 8, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7135) },
                    { 12, null, "it", "Venice", "fName87 Lname32", new DateTime(2021, 9, 20, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7139) },
                    { 32, null, "it", "Venice", "fName18 Lname105", new DateTime(2021, 10, 25, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7313) },
                    { 33, null, "it", "Venice", "fName28 Lname56", new DateTime(2021, 9, 24, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7316) },
                    { 36, null, "it", "Venice", "fName34 Lname48", new DateTime(2021, 9, 16, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7328) },
                    { 30, null, "sp", "Saratoga", "fName42 Lname133", new DateTime(2021, 10, 4, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7306) },
                    { 50, null, "it", "Venice", "fName85 Lname13", new DateTime(2021, 9, 23, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7375) },
                    { 31, null, "it", "Milan", "fName93 Lname75", new DateTime(2021, 10, 2, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7310) },
                    { 41, null, "it", "Milan", "fName36 Lname26", new DateTime(2021, 9, 30, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7345) },
                    { 43, null, "it", "Milan", "fName32 Lname122", new DateTime(2021, 10, 7, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7351) },
                    { 49, null, "it", "Milan", "fName98 Lname60", new DateTime(2021, 10, 14, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7372) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CityCountryCode", "CityName", "Name", "NextCall" },
                values: new object[,]
                {
                    { 15, null, "fr", "Paris", "fName83 Lname71", new DateTime(2021, 10, 7, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7149) },
                    { 19, null, "fr", "Paris", "fName43 Lname130", new DateTime(2021, 9, 26, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7164) },
                    { 46, null, "fr", "Paris", "fName32 Lname74", new DateTime(2021, 9, 16, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7361) },
                    { 2, null, "fr", "Nice", "fName1 Lname127", new DateTime(2021, 9, 15, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7097) },
                    { 3, null, "fr", "Nice", "fName29 Lname56", new DateTime(2021, 10, 8, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7103) },
                    { 10, null, "fr", "Nice", "fName30 Lname8", new DateTime(2021, 9, 22, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7132) },
                    { 20, null, "it", "Milan", "fName16 Lname149", new DateTime(2021, 9, 9, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7167) },
                    { 44, null, "sp", "Saratoga", "fName27 Lname65", new DateTime(2021, 10, 22, 13, 35, 48, 557, DateTimeKind.Local).AddTicks(7355) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 30, 16, 11, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(654), 30, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(652) },
                    { 448, 40, 14, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(1944), 448, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1942) },
                    { 431, 40, 2, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1873), 431, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1872) },
                    { 430, 40, 12, new DateTime(2021, 9, 5, 4, 43, 48, 559, DateTimeKind.Local).AddTicks(1871), 430, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1870) },
                    { 372, 40, 16, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1711), 372, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1709) },
                    { 332, 40, 11, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(1598), 332, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(1597) },
                    { 252, 40, 18, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1355), 252, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1354) },
                    { 246, 40, 16, new DateTime(2021, 9, 5, 5, 0, 48, 559, DateTimeKind.Local).AddTicks(1338), 246, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1337) },
                    { 169, 40, 20, new DateTime(2021, 9, 5, 4, 39, 48, 559, DateTimeKind.Local).AddTicks(1098), 169, new DateTime(2021, 9, 5, 3, 59, 48, 559, DateTimeKind.Local).AddTicks(1096) },
                    { 161, 40, 4, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1075), 161, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(1074) },
                    { 83, 40, 7, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(804), 83, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(803) },
                    { 75, 40, 5, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(782), 75, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(781) },
                    { 67, 40, 16, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(759), 67, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(758) },
                    { 434, 34, 4, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1882), 434, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(1881) },
                    { 297, 34, 11, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(1478), 297, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1477) },
                    { 244, 34, 5, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(1332), 244, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1331) },
                    { 243, 34, 11, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1329), 243, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1328) },
                    { 215, 34, 7, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1251), 215, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(1250) },
                    { 109, 34, 2, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(928), 109, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(927) },
                    { 53, 34, 2, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(720), 53, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(719) },
                    { 41, 34, 9, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(686), 41, new DateTime(2021, 9, 5, 4, 13, 48, 559, DateTimeKind.Local).AddTicks(684) },
                    { 36, 34, 7, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(670), 36, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(669) },
                    { 17, 34, 15, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(616), 17, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(615) },
                    { 455, 27, 5, new DateTime(2021, 9, 5, 4, 22, 48, 559, DateTimeKind.Local).AddTicks(1963), 455, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1962) },
                    { 421, 27, 2, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1845), 421, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1844) },
                    { 321, 27, 19, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1544), 321, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1543) },
                    { 306, 27, 6, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1503), 306, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(1502) },
                    { 247, 27, 1, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1340), 247, new DateTime(2021, 9, 5, 4, 13, 48, 559, DateTimeKind.Local).AddTicks(1339) },
                    { 452, 40, 13, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1954), 452, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1953) },
                    { 103, 27, 5, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(912), 103, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(899) },
                    { 98, 45, 2, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(847), 98, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(846) },
                    { 179, 45, 17, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1125), 179, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1124) },
                    { 19, 14, 10, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(622), 19, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(621) },
                    { 495, 13, 1, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(2073), 495, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(2072) },
                    { 453, 13, 4, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(1957), 453, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(1956) },
                    { 392, 13, 13, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1766), 392, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1765) },
                    { 248, 13, 19, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1343), 248, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1342) },
                    { 205, 13, 1, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1198), 205, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1197) },
                    { 199, 13, 11, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(1181), 199, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1180) },
                    { 163, 13, 19, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1081), 163, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(1080) },
                    { 117, 13, 12, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(951), 117, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(949) },
                    { 76, 13, 15, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(785), 76, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(784) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 16, 13, 13, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(613), 16, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(612) },
                    { 487, 47, 19, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(2051), 487, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(2050) },
                    { 477, 47, 16, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(2023), 477, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(2022) },
                    { 442, 47, 16, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1927), 442, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1925) },
                    { 398, 47, 6, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1782), 398, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1781) },
                    { 365, 47, 19, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1691), 365, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1690) },
                    { 338, 47, 11, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1615), 338, new DateTime(2021, 9, 5, 3, 53, 48, 559, DateTimeKind.Local).AddTicks(1614) },
                    { 324, 47, 1, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1552), 324, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1551) },
                    { 323, 47, 14, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1550), 323, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1549) },
                    { 245, 47, 13, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1335), 245, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(1334) },
                    { 238, 47, 2, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1315), 238, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1314) },
                    { 97, 47, 3, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(844), 97, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(843) },
                    { 483, 45, 10, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(2040), 483, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(2039) },
                    { 423, 45, 10, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1851), 423, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1850) },
                    { 397, 45, 18, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1780), 397, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(1779) },
                    { 228, 45, 4, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1288), 228, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1286) },
                    { 180, 45, 20, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1128), 180, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1127) },
                    { 175, 45, 19, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(1114), 175, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(1113) },
                    { 26, 27, 6, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(642), 26, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(641) },
                    { 2, 27, 10, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(569), 2, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(566) },
                    { 498, 23, 20, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(2082), 498, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(2081) },
                    { 278, 1, 9, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1426), 278, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1425) },
                    { 236, 1, 18, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1310), 236, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1309) },
                    { 129, 1, 20, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(984), 129, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(983) },
                    { 127, 1, 20, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(979), 127, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(978) },
                    { 69, 1, 14, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(765), 69, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(764) },
                    { 49, 1, 15, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(708), 49, new DateTime(2021, 9, 5, 3, 59, 48, 559, DateTimeKind.Local).AddTicks(707) },
                    { 458, 38, 2, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1971), 458, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(1970) },
                    { 418, 38, 13, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1837), 418, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(1836) },
                    { 358, 38, 13, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(1671), 358, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(1670) },
                    { 343, 38, 18, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(1629), 343, new DateTime(2021, 9, 5, 3, 59, 48, 559, DateTimeKind.Local).AddTicks(1628) },
                    { 339, 38, 10, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1618), 339, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1617) },
                    { 325, 38, 16, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1555), 325, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1554) },
                    { 269, 38, 13, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1401), 269, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1400) },
                    { 194, 38, 3, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(1167), 194, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1166) },
                    { 159, 38, 11, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1070), 159, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(1068) },
                    { 136, 38, 14, new DateTime(2021, 9, 5, 4, 26, 48, 559, DateTimeKind.Local).AddTicks(1005), 136, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1004) },
                    { 104, 38, 8, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(914), 104, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(913) },
                    { 88, 38, 8, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(818), 88, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(817) },
                    { 493, 35, 7, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(2068), 493, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(2067) },
                    { 468, 35, 20, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1999), 468, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1998) },
                    { 415, 35, 13, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(1829), 415, new DateTime(2021, 9, 5, 3, 39, 48, 559, DateTimeKind.Local).AddTicks(1828) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 403, 35, 1, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1796), 403, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1795) },
                    { 394, 35, 6, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(1771), 394, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(1770) },
                    { 346, 35, 4, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(1638), 346, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(1637) },
                    { 303, 35, 17, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1495), 303, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1494) },
                    { 249, 35, 8, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1346), 249, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1345) },
                    { 235, 35, 10, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1307), 235, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1306) },
                    { 357, 1, 10, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1668), 357, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1667) },
                    { 439, 1, 13, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1896), 439, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1895) },
                    { 449, 1, 7, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1946), 449, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(1945) },
                    { 20, 4, 13, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(625), 20, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(624) },
                    { 377, 23, 9, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1724), 377, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(1723) },
                    { 364, 23, 1, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(1688), 364, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1687) },
                    { 362, 23, 8, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1682), 362, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1681) },
                    { 328, 23, 18, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1587), 328, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1586) },
                    { 133, 23, 2, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(996), 133, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(994) },
                    { 74, 23, 2, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(779), 74, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(778) },
                    { 40, 23, 2, new DateTime(2021, 9, 5, 4, 43, 48, 559, DateTimeKind.Local).AddTicks(683), 40, new DateTime(2021, 9, 5, 4, 15, 48, 559, DateTimeKind.Local).AddTicks(682) },
                    { 39, 23, 13, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(680), 39, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(679) },
                    { 492, 9, 7, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(2065), 492, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(2064) },
                    { 427, 9, 12, new DateTime(2021, 9, 5, 4, 26, 48, 559, DateTimeKind.Local).AddTicks(1862), 427, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1861) },
                    { 376, 9, 10, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1722), 376, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1721) },
                    { 233, 9, 2, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(1301), 233, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1300) },
                    { 231, 9, 16, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(1296), 231, new DateTime(2021, 9, 5, 3, 37, 48, 559, DateTimeKind.Local).AddTicks(1295) },
                    { 50, 14, 8, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(711), 50, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(710) },
                    { 200, 9, 12, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1184), 200, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1183) },
                    { 64, 9, 11, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(751), 64, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(750) },
                    { 28, 9, 17, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(648), 28, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(647) },
                    { 313, 8, 20, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(1522), 313, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1521) },
                    { 92, 8, 17, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(830), 92, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(829) },
                    { 90, 8, 12, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(824), 90, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(823) },
                    { 491, 4, 20, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(2062), 491, new DateTime(2021, 9, 5, 3, 53, 48, 559, DateTimeKind.Local).AddTicks(2061) },
                    { 361, 4, 7, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1680), 361, new DateTime(2021, 9, 5, 3, 59, 48, 559, DateTimeKind.Local).AddTicks(1678) },
                    { 329, 4, 20, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(1590), 329, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1589) },
                    { 316, 4, 7, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1530), 316, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1529) },
                    { 292, 4, 18, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(1464), 292, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(1463) },
                    { 219, 4, 4, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1262), 219, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1261) },
                    { 152, 4, 16, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(1050), 152, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1049) },
                    { 55, 4, 10, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(725), 55, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(724) },
                    { 125, 9, 9, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(973), 125, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(972) },
                    { 212, 35, 16, new DateTime(2021, 9, 5, 5, 1, 48, 559, DateTimeKind.Local).AddTicks(1217), 212, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1216) },
                    { 78, 14, 7, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(790), 78, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(789) },
                    { 137, 14, 2, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1008), 137, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(1007) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 85, 6, 19, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(810), 85, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(809) },
                    { 58, 6, 15, new DateTime(2021, 9, 5, 4, 32, 48, 559, DateTimeKind.Local).AddTicks(734), 58, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(733) },
                    { 52, 6, 18, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(717), 52, new DateTime(2021, 9, 5, 4, 13, 48, 559, DateTimeKind.Local).AddTicks(716) },
                    { 465, 48, 10, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(1990), 465, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(1989) },
                    { 461, 48, 15, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(1979), 461, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(1978) },
                    { 234, 48, 7, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1304), 234, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1303) },
                    { 23, 48, 1, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(634), 23, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(633) },
                    { 432, 29, 17, new DateTime(2021, 9, 5, 4, 39, 48, 559, DateTimeKind.Local).AddTicks(1876), 432, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1875) },
                    { 408, 29, 1, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1809), 408, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1808) },
                    { 378, 29, 5, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(1727), 378, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1726) },
                    { 374, 29, 19, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(1716), 374, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1715) },
                    { 351, 29, 8, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(1651), 351, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(1650) },
                    { 344, 29, 6, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1632), 344, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1631) },
                    { 327, 29, 8, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1561), 327, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1560) },
                    { 276, 29, 8, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1421), 276, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1420) },
                    { 225, 29, 14, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1279), 225, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1278) },
                    { 214, 29, 12, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(1223), 214, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1222) },
                    { 197, 29, 15, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(1176), 197, new DateTime(2021, 9, 5, 3, 53, 48, 559, DateTimeKind.Local).AddTicks(1175) },
                    { 174, 29, 2, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(1111), 174, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(1110) },
                    { 168, 29, 17, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1095), 168, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1094) },
                    { 123, 29, 12, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(968), 123, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(967) },
                    { 72, 29, 10, new DateTime(2021, 9, 5, 5, 1, 48, 559, DateTimeKind.Local).AddTicks(773), 72, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(772) },
                    { 38, 29, 19, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(677), 38, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(676) },
                    { 443, 26, 10, new DateTime(2021, 9, 5, 4, 19, 48, 559, DateTimeKind.Local).AddTicks(1929), 443, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(1928) },
                    { 380, 26, 10, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1733), 380, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(1731) },
                    { 239, 26, 3, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(1318), 239, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(1317) },
                    { 172, 26, 1, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1106), 172, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1105) },
                    { 144, 6, 14, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1028), 144, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(1026) },
                    { 134, 26, 17, new DateTime(2021, 9, 5, 4, 19, 48, 559, DateTimeKind.Local).AddTicks(1000), 134, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(998) },
                    { 178, 6, 12, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1122), 178, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1121) },
                    { 322, 6, 13, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(1547), 322, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1546) },
                    { 154, 44, 20, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1055), 154, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1054) },
                    { 119, 44, 19, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(956), 119, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(955) },
                    { 79, 44, 19, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(793), 79, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(792) },
                    { 21, 44, 5, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(628), 21, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(627) },
                    { 471, 30, 6, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(2007), 471, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(2006) },
                    { 425, 30, 19, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1857), 425, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(1856) },
                    { 375, 30, 19, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1719), 375, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(1718) },
                    { 319, 30, 3, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(1539), 319, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(1538) },
                    { 115, 30, 8, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(945), 115, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(944) },
                    { 87, 30, 5, new DateTime(2021, 9, 5, 4, 39, 48, 559, DateTimeKind.Local).AddTicks(816), 87, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(815) },
                    { 70, 30, 7, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(768), 70, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(767) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 60, 30, 19, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(740), 60, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(738) },
                    { 59, 30, 13, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(737), 59, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(736) },
                    { 8, 30, 20, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(588), 8, new DateTime(2021, 9, 5, 3, 37, 48, 559, DateTimeKind.Local).AddTicks(587) },
                    { 490, 7, 7, new DateTime(2021, 9, 5, 5, 0, 48, 559, DateTimeKind.Local).AddTicks(2059), 490, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(2058) },
                    { 459, 7, 10, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(1974), 459, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1973) },
                    { 285, 7, 5, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1446), 285, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1444) },
                    { 280, 7, 14, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1432), 280, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(1431) },
                    { 112, 7, 13, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(937), 112, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(935) },
                    { 77, 7, 1, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(787), 77, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(786) },
                    { 12, 7, 14, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(601), 12, new DateTime(2021, 9, 5, 4, 13, 48, 559, DateTimeKind.Local).AddTicks(600) },
                    { 11, 7, 2, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(598), 11, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(597) },
                    { 488, 6, 4, new DateTime(2021, 9, 5, 4, 22, 48, 559, DateTimeKind.Local).AddTicks(2054), 488, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(2053) },
                    { 450, 6, 16, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(1949), 450, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1948) },
                    { 435, 6, 18, new DateTime(2021, 9, 5, 5, 0, 48, 559, DateTimeKind.Local).AddTicks(1885), 435, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1883) },
                    { 379, 6, 8, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1730), 379, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1729) },
                    { 367, 6, 3, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1696), 367, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(1695) },
                    { 206, 6, 11, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1200), 206, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(1199) },
                    { 96, 26, 3, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(841), 96, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(840) },
                    { 80, 26, 16, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(796), 80, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(795) },
                    { 54, 26, 17, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(723), 54, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(721) },
                    { 479, 28, 3, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(2029), 479, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(2028) },
                    { 476, 28, 10, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(2020), 476, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(2019) },
                    { 383, 28, 9, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(1741), 383, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1740) },
                    { 311, 28, 8, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1517), 311, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1516) },
                    { 291, 28, 7, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(1462), 291, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1461) },
                    { 284, 28, 16, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1443), 284, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1442) },
                    { 237, 28, 14, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1313), 237, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(1312) },
                    { 211, 28, 5, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1214), 211, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1213) },
                    { 171, 28, 11, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1103), 171, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1102) },
                    { 164, 28, 9, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1083), 164, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(1082) },
                    { 143, 28, 4, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1025), 143, new DateTime(2021, 9, 5, 4, 15, 48, 559, DateTimeKind.Local).AddTicks(1024) },
                    { 122, 28, 19, new DateTime(2021, 9, 5, 4, 26, 48, 559, DateTimeKind.Local).AddTicks(965), 122, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(964) },
                    { 62, 28, 9, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(745), 62, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(744) },
                    { 51, 28, 17, new DateTime(2021, 9, 5, 4, 43, 48, 559, DateTimeKind.Local).AddTicks(714), 51, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(713) },
                    { 470, 21, 15, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(2004), 470, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(2003) },
                    { 428, 21, 20, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1865), 428, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1864) },
                    { 309, 21, 19, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(1512), 309, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1510) },
                    { 289, 21, 19, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1456), 289, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1455) },
                    { 213, 21, 4, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1220), 213, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(1219) },
                    { 472, 14, 4, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(2010), 472, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(2008) },
                    { 438, 14, 20, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(1893), 438, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(1892) },
                    { 433, 14, 12, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1879), 433, new DateTime(2021, 9, 5, 4, 13, 48, 559, DateTimeKind.Local).AddTicks(1878) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 368, 14, 1, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(1699), 368, new DateTime(2021, 9, 5, 4, 13, 48, 559, DateTimeKind.Local).AddTicks(1698) },
                    { 305, 14, 5, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(1500), 305, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1499) },
                    { 226, 14, 8, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1282), 226, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1281) },
                    { 224, 14, 7, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1276), 224, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1275) },
                    { 183, 14, 11, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1137), 183, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(1136) },
                    { 3, 37, 9, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(573), 3, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(572) },
                    { 29, 37, 5, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(651), 29, new DateTime(2021, 9, 5, 3, 39, 48, 559, DateTimeKind.Local).AddTicks(650) },
                    { 94, 37, 17, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(835), 94, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(834) },
                    { 107, 37, 17, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(923), 107, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(922) },
                    { 33, 26, 12, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(662), 33, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(661) },
                    { 460, 24, 10, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1977), 460, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(1976) },
                    { 445, 24, 3, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(1935), 445, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(1934) },
                    { 419, 24, 12, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1840), 419, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(1839) },
                    { 411, 24, 20, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1818), 411, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(1817) },
                    { 390, 24, 3, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1760), 390, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(1759) },
                    { 317, 24, 19, new DateTime(2021, 9, 5, 4, 22, 48, 559, DateTimeKind.Local).AddTicks(1533), 317, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1532) },
                    { 314, 24, 9, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1525), 314, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1524) },
                    { 281, 24, 18, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(1435), 281, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1434) },
                    { 275, 24, 12, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1418), 275, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(1417) },
                    { 271, 24, 3, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1407), 271, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1406) },
                    { 255, 24, 2, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1363), 255, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1362) },
                    { 254, 24, 17, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(1360), 254, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(1359) },
                    { 106, 14, 10, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(920), 106, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(919) },
                    { 27, 24, 7, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(645), 27, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(644) },
                    { 467, 5, 2, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1996), 467, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1995) },
                    { 436, 5, 13, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1887), 436, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1886) },
                    { 396, 5, 13, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(1777), 396, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1776) },
                    { 312, 5, 7, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1520), 312, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1519) },
                    { 230, 5, 5, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(1293), 230, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(1292) },
                    { 141, 5, 12, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1019), 141, new DateTime(2021, 9, 5, 3, 53, 48, 559, DateTimeKind.Local).AddTicks(1018) },
                    { 71, 5, 2, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(771), 71, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(769) },
                    { 466, 37, 10, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(1993), 466, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1992) },
                    { 405, 37, 13, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1801), 405, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(1800) },
                    { 345, 37, 18, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1635), 345, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(1634) },
                    { 310, 37, 4, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1514), 310, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(1513) },
                    { 147, 37, 3, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1036), 147, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(1035) },
                    { 113, 37, 20, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(939), 113, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(938) },
                    { 10, 24, 19, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(594), 10, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(593) },
                    { 128, 35, 16, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(982), 128, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(980) },
                    { 126, 35, 3, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(976), 126, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(975) },
                    { 86, 35, 1, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(813), 86, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(812) },
                    { 108, 32, 16, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(925), 108, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(924) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 105, 32, 6, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(917), 105, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(916) },
                    { 63, 32, 19, new DateTime(2021, 9, 5, 4, 26, 48, 559, DateTimeKind.Local).AddTicks(748), 63, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(747) },
                    { 24, 32, 7, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(636), 24, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(635) },
                    { 15, 32, 1, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(609), 15, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(608) },
                    { 484, 12, 2, new DateTime(2021, 9, 5, 5, 1, 48, 559, DateTimeKind.Local).AddTicks(2043), 484, new DateTime(2021, 9, 5, 3, 53, 48, 559, DateTimeKind.Local).AddTicks(2042) },
                    { 481, 12, 2, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(2034), 481, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(2033) },
                    { 424, 12, 19, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1854), 424, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1853) },
                    { 267, 12, 14, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1396), 267, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1395) },
                    { 253, 12, 16, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(1357), 253, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(1356) },
                    { 221, 12, 18, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(1268), 221, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1267) },
                    { 220, 12, 19, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1265), 220, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1264) },
                    { 166, 12, 20, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1089), 166, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1088) },
                    { 157, 12, 17, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1064), 157, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1063) },
                    { 150, 12, 10, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1044), 150, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(1043) },
                    { 142, 12, 9, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1022), 142, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(1021) },
                    { 110, 12, 9, new DateTime(2021, 9, 5, 5, 1, 48, 559, DateTimeKind.Local).AddTicks(931), 110, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(930) },
                    { 95, 12, 11, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(838), 95, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(837) },
                    { 5, 12, 4, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(579), 5, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(578) },
                    { 480, 11, 9, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(2032), 480, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(2030) },
                    { 386, 11, 3, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1749), 386, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1748) },
                    { 354, 11, 1, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1660), 354, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1659) },
                    { 352, 11, 1, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(1654), 352, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1653) },
                    { 341, 11, 13, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1624), 341, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1623) },
                    { 265, 11, 15, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1391), 265, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(1390) },
                    { 158, 11, 10, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1067), 158, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(1066) },
                    { 68, 11, 13, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(762), 68, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(761) },
                    { 331, 32, 6, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1596), 331, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(1594) },
                    { 387, 42, 14, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1752), 387, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1751) },
                    { 406, 32, 9, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1804), 406, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1803) },
                    { 186, 33, 10, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(1145), 186, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(1144) },
                    { 447, 50, 1, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1941), 447, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(1940) },
                    { 402, 50, 5, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(1793), 402, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1792) },
                    { 350, 50, 18, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1649), 350, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(1648) },
                    { 349, 50, 15, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(1646), 349, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(1645) },
                    { 258, 50, 4, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1371), 258, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(1370) },
                    { 210, 50, 2, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1212), 210, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(1210) },
                    { 201, 50, 12, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1187), 201, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1186) },
                    { 190, 50, 2, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(1156), 190, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1155) },
                    { 167, 50, 19, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1092), 167, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1091) },
                    { 149, 50, 16, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1041), 149, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1040) },
                    { 140, 50, 5, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1016), 140, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1015) },
                    { 102, 50, 17, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(898), 102, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(896) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 18, 50, 8, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(620), 18, new DateTime(2021, 9, 5, 3, 53, 48, 559, DateTimeKind.Local).AddTicks(619) },
                    { 469, 36, 11, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(2001), 469, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(2000) },
                    { 422, 36, 8, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(1848), 422, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(1847) },
                    { 407, 36, 16, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1807), 407, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1806) },
                    { 381, 36, 20, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(1735), 381, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1734) },
                    { 264, 36, 10, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1388), 264, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1387) },
                    { 250, 36, 1, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(1349), 250, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1348) },
                    { 160, 36, 8, new DateTime(2021, 9, 5, 4, 19, 48, 559, DateTimeKind.Local).AddTicks(1072), 160, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1071) },
                    { 156, 36, 15, new DateTime(2021, 9, 5, 4, 32, 48, 559, DateTimeKind.Local).AddTicks(1061), 156, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1060) },
                    { 43, 36, 3, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(691), 43, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(690) },
                    { 7, 36, 19, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(585), 7, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(584) },
                    { 489, 33, 13, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(2057), 489, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(2056) },
                    { 366, 33, 1, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(1693), 366, new DateTime(2021, 9, 5, 3, 39, 48, 559, DateTimeKind.Local).AddTicks(1692) },
                    { 241, 33, 7, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1324), 241, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(1323) },
                    { 196, 33, 11, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(1173), 196, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1172) },
                    { 457, 32, 16, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1968), 457, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(1967) },
                    { 334, 42, 12, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(1604), 334, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(1603) },
                    { 318, 42, 20, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1536), 318, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1535) },
                    { 282, 42, 1, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1437), 282, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1436) },
                    { 261, 18, 16, new DateTime(2021, 9, 5, 4, 43, 48, 559, DateTimeKind.Local).AddTicks(1380), 261, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1378) },
                    { 99, 18, 3, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(849), 99, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(848) },
                    { 91, 18, 17, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(827), 91, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(826) },
                    { 440, 17, 15, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1898), 440, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1897) },
                    { 426, 17, 7, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1859), 426, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1858) },
                    { 414, 17, 7, new DateTime(2021, 9, 5, 4, 39, 48, 559, DateTimeKind.Local).AddTicks(1826), 414, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1825) },
                    { 320, 17, 3, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1541), 320, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(1540) },
                    { 270, 17, 16, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1404), 270, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1403) },
                    { 262, 17, 6, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1382), 262, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1381) },
                    { 223, 17, 16, new DateTime(2021, 9, 5, 4, 32, 48, 559, DateTimeKind.Local).AddTicks(1273), 223, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1272) },
                    { 209, 17, 9, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1209), 209, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1208) },
                    { 202, 17, 15, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1190), 202, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1189) },
                    { 148, 17, 18, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1038), 148, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1037) },
                    { 146, 17, 11, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1033), 146, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(1032) },
                    { 124, 17, 6, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(970), 124, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(969) },
                    { 73, 17, 17, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(776), 73, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(775) },
                    { 46, 17, 6, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(700), 46, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(699) },
                    { 44, 17, 9, new DateTime(2021, 9, 5, 4, 39, 48, 559, DateTimeKind.Local).AddTicks(694), 44, new DateTime(2021, 9, 5, 3, 28, 48, 559, DateTimeKind.Local).AddTicks(693) },
                    { 22, 17, 2, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(631), 22, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(630) },
                    { 463, 16, 16, new DateTime(2021, 9, 5, 4, 21, 48, 559, DateTimeKind.Local).AddTicks(1985), 463, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(1984) },
                    { 429, 16, 10, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1868), 429, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1867) },
                    { 308, 16, 11, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(1509), 308, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(1508) },
                    { 302, 16, 19, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1492), 302, new DateTime(2021, 9, 5, 4, 15, 48, 559, DateTimeKind.Local).AddTicks(1491) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 259, 16, 14, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1374), 259, new DateTime(2021, 9, 5, 4, 15, 48, 559, DateTimeKind.Local).AddTicks(1373) },
                    { 176, 16, 19, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(1117), 176, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1116) },
                    { 100, 16, 18, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(852), 100, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(851) },
                    { 48, 16, 1, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(706), 48, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(705) },
                    { 274, 18, 4, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1415), 274, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(1414) },
                    { 340, 18, 19, new DateTime(2021, 9, 5, 5, 3, 48, 559, DateTimeKind.Local).AddTicks(1621), 340, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(1620) },
                    { 363, 18, 11, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1685), 363, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1684) },
                    { 409, 18, 10, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1812), 409, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(1811) },
                    { 242, 42, 14, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(1326), 242, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(1325) },
                    { 114, 42, 18, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(942), 114, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(941) },
                    { 111, 42, 12, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(934), 111, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(933) },
                    { 89, 42, 3, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(821), 89, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(820) },
                    { 6, 42, 14, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(582), 6, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(581) },
                    { 437, 39, 2, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1890), 437, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1889) },
                    { 385, 39, 4, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1746), 385, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(1745) },
                    { 330, 39, 7, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1593), 330, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1592) },
                    { 304, 39, 2, new DateTime(2021, 9, 5, 4, 58, 48, 559, DateTimeKind.Local).AddTicks(1498), 304, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(1496) },
                    { 296, 39, 9, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1476), 296, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(1475) },
                    { 277, 39, 5, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1423), 277, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(1422) },
                    { 229, 39, 3, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1290), 229, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(1289) },
                    { 187, 39, 15, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1148), 187, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1147) },
                    { 1, 20, 4, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(260), 1, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(58) },
                    { 170, 39, 13, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1100), 170, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1099) },
                    { 342, 25, 14, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(1627), 342, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(1626) },
                    { 288, 25, 20, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(1454), 288, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1453) },
                    { 222, 25, 2, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1271), 222, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1269) },
                    { 207, 25, 15, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1203), 207, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1202) },
                    { 204, 25, 4, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1195), 204, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(1194) },
                    { 153, 25, 3, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1052), 153, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(1051) },
                    { 496, 18, 10, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(2076), 496, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(2075) },
                    { 494, 18, 9, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(2071), 494, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(2069) },
                    { 485, 18, 19, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(2046), 485, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(2044) },
                    { 474, 18, 11, new DateTime(2021, 9, 5, 4, 42, 48, 559, DateTimeKind.Local).AddTicks(2015), 474, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(2014) },
                    { 473, 18, 2, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(2012), 473, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(2011) },
                    { 446, 18, 15, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1938), 446, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1937) },
                    { 412, 18, 9, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1820), 412, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1819) },
                    { 399, 25, 8, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1785), 399, new DateTime(2021, 9, 5, 3, 40, 48, 559, DateTimeKind.Local).AddTicks(1784) },
                    { 37, 20, 3, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(674), 37, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(673) },
                    { 47, 20, 9, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(703), 47, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(702) },
                    { 135, 20, 6, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1002), 135, new DateTime(2021, 9, 5, 3, 44, 48, 559, DateTimeKind.Local).AddTicks(1001) },
                    { 145, 3, 7, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1030), 145, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1029) },
                    { 121, 3, 5, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(962), 121, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(961) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 101, 3, 5, new DateTime(2021, 9, 5, 4, 26, 48, 559, DateTimeKind.Local).AddTicks(894), 101, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(893) },
                    { 45, 3, 15, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(697), 45, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(696) },
                    { 500, 2, 2, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(2087), 500, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(2086) },
                    { 486, 2, 10, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(2048), 486, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(2047) },
                    { 413, 2, 15, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1823), 413, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1822) },
                    { 388, 2, 9, new DateTime(2021, 9, 5, 5, 0, 48, 559, DateTimeKind.Local).AddTicks(1755), 388, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1754) },
                    { 353, 2, 17, new DateTime(2021, 9, 5, 4, 41, 48, 559, DateTimeKind.Local).AddTicks(1657), 353, new DateTime(2021, 9, 5, 4, 14, 48, 559, DateTimeKind.Local).AddTicks(1656) },
                    { 299, 2, 3, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(1484), 299, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(1483) },
                    { 263, 2, 8, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1385), 263, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1384) },
                    { 131, 2, 3, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(990), 131, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(989) },
                    { 42, 2, 9, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(688), 42, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(687) },
                    { 14, 2, 5, new DateTime(2021, 9, 5, 4, 30, 48, 559, DateTimeKind.Local).AddTicks(606), 14, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(605) },
                    { 462, 46, 13, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1982), 462, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(1981) },
                    { 444, 46, 17, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1932), 444, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1931) },
                    { 393, 46, 12, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1769), 393, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(1768) },
                    { 356, 46, 11, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(1666), 356, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1665) },
                    { 283, 46, 11, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1440), 283, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(1439) },
                    { 272, 46, 19, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1410), 272, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(1408) },
                    { 266, 46, 8, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1393), 266, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1392) },
                    { 251, 46, 9, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(1352), 251, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(1351) },
                    { 218, 46, 1, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1260), 218, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1258) },
                    { 203, 46, 5, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1192), 203, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1191) },
                    { 151, 46, 13, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1047), 151, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1046) },
                    { 25, 46, 18, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(639), 25, new DateTime(2021, 9, 5, 4, 5, 48, 559, DateTimeKind.Local).AddTicks(638) },
                    { 369, 19, 4, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1702), 369, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(1701) },
                    { 177, 3, 3, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(1120), 177, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1119) },
                    { 185, 3, 14, new DateTime(2021, 9, 5, 4, 46, 48, 559, DateTimeKind.Local).AddTicks(1142), 185, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1141) },
                    { 286, 3, 3, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(1448), 286, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(1447) },
                    { 290, 3, 4, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1459), 290, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(1458) },
                    { 56, 35, 15, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(728), 56, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(727) },
                    { 13, 35, 19, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(604), 13, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(603) },
                    { 499, 22, 20, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(2085), 499, new DateTime(2021, 9, 5, 3, 54, 48, 559, DateTimeKind.Local).AddTicks(2084) },
                    { 337, 22, 10, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1612), 337, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1611) },
                    { 336, 22, 19, new DateTime(2021, 9, 5, 5, 2, 48, 559, DateTimeKind.Local).AddTicks(1610), 336, new DateTime(2021, 9, 5, 3, 48, 48, 559, DateTimeKind.Local).AddTicks(1609) },
                    { 333, 22, 15, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1601), 333, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(1600) },
                    { 273, 22, 1, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(1412), 273, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(1411) },
                    { 195, 22, 4, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1170), 195, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1169) },
                    { 184, 22, 16, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1139), 184, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1138) },
                    { 82, 22, 5, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(802), 82, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(800) },
                    { 34, 22, 18, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(665), 34, new DateTime(2021, 9, 5, 3, 49, 48, 559, DateTimeKind.Local).AddTicks(664) },
                    { 497, 10, 20, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(2079), 497, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(2078) },
                    { 478, 10, 1, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(2026), 478, new DateTime(2021, 9, 5, 4, 7, 48, 559, DateTimeKind.Local).AddTicks(2025) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 188, 19, 20, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1151), 188, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1150) },
                    { 454, 10, 8, new DateTime(2021, 9, 5, 4, 50, 48, 559, DateTimeKind.Local).AddTicks(1960), 454, new DateTime(2021, 9, 5, 4, 15, 48, 559, DateTimeKind.Local).AddTicks(1959) },
                    { 370, 10, 4, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1705), 370, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1704) },
                    { 198, 10, 20, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1179), 198, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1178) },
                    { 193, 10, 2, new DateTime(2021, 9, 5, 4, 56, 48, 559, DateTimeKind.Local).AddTicks(1164), 193, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1163) },
                    { 155, 10, 2, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(1058), 155, new DateTime(2021, 9, 5, 3, 30, 48, 559, DateTimeKind.Local).AddTicks(1057) },
                    { 139, 10, 2, new DateTime(2021, 9, 5, 4, 39, 48, 559, DateTimeKind.Local).AddTicks(1014), 139, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(1012) },
                    { 138, 10, 2, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1011), 138, new DateTime(2021, 9, 5, 3, 59, 48, 559, DateTimeKind.Local).AddTicks(1010) },
                    { 118, 10, 2, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(954), 118, new DateTime(2021, 9, 5, 3, 26, 48, 559, DateTimeKind.Local).AddTicks(952) },
                    { 35, 10, 1, new DateTime(2021, 9, 5, 4, 16, 48, 559, DateTimeKind.Local).AddTicks(668), 35, new DateTime(2021, 9, 5, 4, 6, 48, 559, DateTimeKind.Local).AddTicks(666) },
                    { 441, 3, 16, new DateTime(2021, 9, 5, 4, 23, 48, 559, DateTimeKind.Local).AddTicks(1924), 441, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(1922) },
                    { 384, 3, 11, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1744), 384, new DateTime(2021, 9, 5, 3, 52, 48, 559, DateTimeKind.Local).AddTicks(1743) },
                    { 348, 3, 10, new DateTime(2021, 9, 5, 4, 22, 48, 559, DateTimeKind.Local).AddTicks(1643), 348, new DateTime(2021, 9, 5, 3, 33, 48, 559, DateTimeKind.Local).AddTicks(1642) },
                    { 326, 3, 7, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1558), 326, new DateTime(2021, 9, 5, 4, 10, 48, 559, DateTimeKind.Local).AddTicks(1557) },
                    { 295, 3, 8, new DateTime(2021, 9, 5, 5, 0, 48, 559, DateTimeKind.Local).AddTicks(1473), 295, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1472) },
                    { 373, 10, 15, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1713), 373, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1712) },
                    { 181, 44, 13, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1131), 181, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(1130) },
                    { 132, 19, 4, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(993), 132, new DateTime(2021, 9, 5, 3, 31, 48, 559, DateTimeKind.Local).AddTicks(992) },
                    { 9, 19, 11, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(591), 9, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(590) },
                    { 451, 41, 7, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1952), 451, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1951) },
                    { 371, 41, 9, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1708), 371, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(1706) },
                    { 335, 41, 8, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(1607), 335, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(1606) },
                    { 294, 41, 10, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(1470), 294, new DateTime(2021, 9, 5, 4, 3, 48, 559, DateTimeKind.Local).AddTicks(1469) },
                    { 216, 41, 19, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1254), 216, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1253) },
                    { 165, 41, 4, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1086), 165, new DateTime(2021, 9, 5, 3, 35, 48, 559, DateTimeKind.Local).AddTicks(1085) },
                    { 130, 41, 15, new DateTime(2021, 9, 5, 4, 48, 48, 559, DateTimeKind.Local).AddTicks(987), 130, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(986) },
                    { 391, 31, 3, new DateTime(2021, 9, 5, 4, 59, 48, 559, DateTimeKind.Local).AddTicks(1763), 391, new DateTime(2021, 9, 5, 3, 38, 48, 559, DateTimeKind.Local).AddTicks(1762) },
                    { 382, 31, 1, new DateTime(2021, 9, 5, 4, 44, 48, 559, DateTimeKind.Local).AddTicks(1738), 382, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(1737) },
                    { 307, 31, 14, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1506), 307, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1505) },
                    { 298, 31, 16, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(1481), 298, new DateTime(2021, 9, 5, 4, 15, 48, 559, DateTimeKind.Local).AddTicks(1480) },
                    { 293, 31, 13, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1467), 293, new DateTime(2021, 9, 5, 3, 43, 48, 559, DateTimeKind.Local).AddTicks(1466) },
                    { 256, 31, 19, new DateTime(2021, 9, 5, 4, 28, 48, 559, DateTimeKind.Local).AddTicks(1366), 256, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(1365) },
                    { 240, 31, 1, new DateTime(2021, 9, 5, 4, 57, 48, 559, DateTimeKind.Local).AddTicks(1321), 240, new DateTime(2021, 9, 5, 3, 37, 48, 559, DateTimeKind.Local).AddTicks(1320) },
                    { 232, 31, 14, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(1299), 232, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1297) },
                    { 208, 31, 6, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(1206), 208, new DateTime(2021, 9, 5, 4, 4, 48, 559, DateTimeKind.Local).AddTicks(1205) },
                    { 116, 31, 14, new DateTime(2021, 9, 5, 4, 27, 48, 559, DateTimeKind.Local).AddTicks(948), 116, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(947) },
                    { 93, 31, 19, new DateTime(2021, 9, 5, 4, 37, 48, 559, DateTimeKind.Local).AddTicks(832), 93, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(831) },
                    { 66, 31, 10, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(757), 66, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(755) },
                    { 416, 20, 2, new DateTime(2021, 9, 5, 4, 34, 48, 559, DateTimeKind.Local).AddTicks(1831), 416, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1830) },
                    { 410, 20, 20, new DateTime(2021, 9, 5, 4, 32, 48, 559, DateTimeKind.Local).AddTicks(1815), 410, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(1814) },
                    { 404, 20, 15, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1799), 404, new DateTime(2021, 9, 5, 3, 58, 48, 559, DateTimeKind.Local).AddTicks(1797) },
                    { 400, 20, 12, new DateTime(2021, 9, 5, 4, 54, 48, 559, DateTimeKind.Local).AddTicks(1788), 400, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1787) }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "OutcomeId", "StartTime" },
                values: new object[,]
                {
                    { 287, 20, 15, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(1451), 287, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1450) },
                    { 189, 20, 5, new DateTime(2021, 9, 5, 4, 31, 48, 559, DateTimeKind.Local).AddTicks(1153), 189, new DateTime(2021, 9, 5, 3, 45, 48, 559, DateTimeKind.Local).AddTicks(1152) },
                    { 173, 20, 4, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1109), 173, new DateTime(2021, 9, 5, 3, 32, 48, 559, DateTimeKind.Local).AddTicks(1108) },
                    { 162, 20, 6, new DateTime(2021, 9, 5, 5, 4, 48, 559, DateTimeKind.Local).AddTicks(1078), 162, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1077) },
                    { 31, 43, 1, new DateTime(2021, 9, 5, 4, 18, 48, 559, DateTimeKind.Local).AddTicks(656), 31, new DateTime(2021, 9, 5, 3, 34, 48, 559, DateTimeKind.Local).AddTicks(655) },
                    { 84, 43, 8, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(807), 84, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(806) },
                    { 191, 43, 13, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(1159), 191, new DateTime(2021, 9, 5, 4, 1, 48, 559, DateTimeKind.Local).AddTicks(1158) },
                    { 227, 43, 12, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1285), 227, new DateTime(2021, 9, 5, 4, 12, 48, 559, DateTimeKind.Local).AddTicks(1284) },
                    { 475, 15, 12, new DateTime(2021, 9, 5, 4, 24, 48, 559, DateTimeKind.Local).AddTicks(2018), 475, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(2017) },
                    { 395, 15, 1, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(1774), 395, new DateTime(2021, 9, 5, 3, 39, 48, 559, DateTimeKind.Local).AddTicks(1773) },
                    { 389, 15, 16, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(1758), 389, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(1756) },
                    { 359, 15, 1, new DateTime(2021, 9, 5, 4, 49, 48, 559, DateTimeKind.Local).AddTicks(1674), 359, new DateTime(2021, 9, 5, 3, 37, 48, 559, DateTimeKind.Local).AddTicks(1673) },
                    { 347, 15, 19, new DateTime(2021, 9, 5, 4, 47, 48, 559, DateTimeKind.Local).AddTicks(1640), 347, new DateTime(2021, 9, 5, 3, 36, 48, 559, DateTimeKind.Local).AddTicks(1639) },
                    { 279, 15, 2, new DateTime(2021, 9, 5, 4, 26, 48, 559, DateTimeKind.Local).AddTicks(1429), 279, new DateTime(2021, 9, 5, 3, 41, 48, 559, DateTimeKind.Local).AddTicks(1428) },
                    { 260, 15, 9, new DateTime(2021, 9, 5, 4, 33, 48, 559, DateTimeKind.Local).AddTicks(1377), 260, new DateTime(2021, 9, 5, 3, 59, 48, 559, DateTimeKind.Local).AddTicks(1376) },
                    { 257, 15, 13, new DateTime(2021, 9, 5, 4, 52, 48, 559, DateTimeKind.Local).AddTicks(1368), 257, new DateTime(2021, 9, 5, 3, 27, 48, 559, DateTimeKind.Local).AddTicks(1367) },
                    { 120, 15, 19, new DateTime(2021, 9, 5, 5, 0, 48, 559, DateTimeKind.Local).AddTicks(959), 120, new DateTime(2021, 9, 5, 3, 56, 48, 559, DateTimeKind.Local).AddTicks(958) },
                    { 81, 15, 2, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(799), 81, new DateTime(2021, 9, 5, 3, 47, 48, 559, DateTimeKind.Local).AddTicks(798) },
                    { 65, 15, 1, new DateTime(2021, 9, 5, 4, 45, 48, 559, DateTimeKind.Local).AddTicks(754), 65, new DateTime(2021, 9, 5, 3, 51, 48, 559, DateTimeKind.Local).AddTicks(753) },
                    { 32, 15, 1, new DateTime(2021, 9, 5, 4, 17, 48, 559, DateTimeKind.Local).AddTicks(659), 32, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(658) },
                    { 4, 15, 15, new DateTime(2021, 9, 5, 4, 19, 48, 559, DateTimeKind.Local).AddTicks(577), 4, new DateTime(2021, 9, 5, 4, 9, 48, 559, DateTimeKind.Local).AddTicks(576) },
                    { 61, 19, 15, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(742), 61, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(741) },
                    { 401, 49, 7, new DateTime(2021, 9, 5, 4, 43, 48, 559, DateTimeKind.Local).AddTicks(1790), 401, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1789) },
                    { 355, 49, 2, new DateTime(2021, 9, 5, 4, 38, 48, 559, DateTimeKind.Local).AddTicks(1663), 355, new DateTime(2021, 9, 5, 3, 55, 48, 559, DateTimeKind.Local).AddTicks(1662) },
                    { 300, 49, 7, new DateTime(2021, 9, 5, 4, 40, 48, 559, DateTimeKind.Local).AddTicks(1487), 300, new DateTime(2021, 9, 5, 3, 29, 48, 559, DateTimeKind.Local).AddTicks(1485) },
                    { 217, 49, 9, new DateTime(2021, 9, 5, 5, 1, 48, 559, DateTimeKind.Local).AddTicks(1257), 217, new DateTime(2021, 9, 5, 3, 50, 48, 559, DateTimeKind.Local).AddTicks(1256) },
                    { 192, 49, 12, new DateTime(2021, 9, 5, 5, 1, 48, 559, DateTimeKind.Local).AddTicks(1161), 192, new DateTime(2021, 9, 5, 3, 39, 48, 559, DateTimeKind.Local).AddTicks(1160) },
                    { 182, 49, 7, new DateTime(2021, 9, 5, 4, 29, 48, 559, DateTimeKind.Local).AddTicks(1134), 182, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1133) },
                    { 57, 49, 15, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(731), 57, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(730) },
                    { 482, 43, 17, new DateTime(2021, 9, 5, 4, 55, 48, 559, DateTimeKind.Local).AddTicks(2037), 482, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(2036) },
                    { 456, 43, 5, new DateTime(2021, 9, 5, 4, 25, 48, 559, DateTimeKind.Local).AddTicks(1965), 456, new DateTime(2021, 9, 5, 3, 57, 48, 559, DateTimeKind.Local).AddTicks(1964) },
                    { 420, 43, 15, new DateTime(2021, 9, 5, 4, 51, 48, 559, DateTimeKind.Local).AddTicks(1843), 420, new DateTime(2021, 9, 5, 4, 0, 48, 559, DateTimeKind.Local).AddTicks(1841) },
                    { 417, 43, 4, new DateTime(2021, 9, 5, 4, 20, 48, 559, DateTimeKind.Local).AddTicks(1834), 417, new DateTime(2021, 9, 5, 4, 11, 48, 559, DateTimeKind.Local).AddTicks(1833) },
                    { 315, 43, 17, new DateTime(2021, 9, 5, 4, 35, 48, 559, DateTimeKind.Local).AddTicks(1528), 315, new DateTime(2021, 9, 5, 4, 2, 48, 559, DateTimeKind.Local).AddTicks(1527) },
                    { 301, 43, 16, new DateTime(2021, 9, 5, 4, 22, 48, 559, DateTimeKind.Local).AddTicks(1489), 301, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1488) },
                    { 268, 43, 20, new DateTime(2021, 9, 5, 5, 5, 48, 559, DateTimeKind.Local).AddTicks(1399), 268, new DateTime(2021, 9, 5, 3, 46, 48, 559, DateTimeKind.Local).AddTicks(1398) },
                    { 360, 49, 12, new DateTime(2021, 9, 5, 4, 53, 48, 559, DateTimeKind.Local).AddTicks(1677), 360, new DateTime(2021, 9, 5, 3, 42, 48, 559, DateTimeKind.Local).AddTicks(1676) },
                    { 464, 44, 3, new DateTime(2021, 9, 5, 4, 36, 48, 559, DateTimeKind.Local).AddTicks(1988), 464, new DateTime(2021, 9, 5, 4, 8, 48, 559, DateTimeKind.Local).AddTicks(1986) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calls_CustomerId",
                table: "Calls",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_EmployeeId",
                table: "Calls",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_OutcomeId",
                table: "Calls",
                column: "OutcomeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryCode",
                table: "Cities",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityName_CityCountryCode",
                table: "Customers",
                columns: new[] { "CityName", "CityCountryCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Outcomes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
