using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrototypeApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BendingMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    G_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Town = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    CostM = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Pkh = table.Column<int>(type: "int", nullable: false),
                    Ptc = table.Column<int>(type: "int", nullable: false),
                    Bmax = table.Column<int>(type: "int", nullable: false),
                    Lmax = table.Column<int>(type: "int", nullable: false),
                    Sod = table.Column<int>(type: "int", nullable: false),
                    Sdv = table.Column<int>(type: "int", nullable: false),
                    Massa = table.Column<int>(type: "int", nullable: false),
                    LBH = table.Column<int>(type: "int", nullable: false),
                    Energ = table.Column<int>(type: "int", nullable: false),
                    NUN = table.Column<int>(type: "int", nullable: false),
                    NGN = table.Column<int>(type: "int", nullable: false),
                    VI = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BendingMachines", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Com_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Region = table.Column<int>(type: "int", nullable: false),
                    Shift = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Vprog = table.Column<int>(type: "int", nullable: false),
                    Program = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AppProgram = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rm = table.Column<int>(type: "int", nullable: false),
                    CountM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CuttingMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    C_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Town = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    CostM = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    L = table.Column<int>(type: "int", nullable: false),
                    B = table.Column<int>(type: "int", nullable: false),
                    Vmax = table.Column<int>(type: "int", nullable: false),
                    Vtra = table.Column<int>(type: "int", nullable: false),
                    Abr = table.Column<int>(type: "int", nullable: false),
                    Vs = table.Column<int>(type: "int", nullable: false),
                    Massa = table.Column<int>(type: "int", nullable: false),
                    Energ = table.Column<int>(type: "int", nullable: false),
                    NUN = table.Column<int>(type: "int", nullable: false),
                    NGN = table.Column<int>(type: "int", nullable: false),
                    VI = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AbrM = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ppump = table.Column<int>(type: "int", nullable: false),
                    Pnom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuttingMachines", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrillingMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    D_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Town = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    CostM = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Massa = table.Column<double>(type: "double", nullable: false),
                    LBH = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Energ = table.Column<int>(type: "int", nullable: false),
                    SumN = table.Column<int>(type: "int", nullable: false),
                    NUN = table.Column<int>(type: "int", nullable: false),
                    NGN = table.Column<int>(type: "int", nullable: false),
                    VI = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dmax = table.Column<int>(type: "int", nullable: false),
                    E1 = table.Column<int>(type: "int", nullable: false),
                    E2 = table.Column<int>(type: "int", nullable: false),
                    Emax = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrillingMachines", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BendingMachinesAmount = table.Column<int>(type: "int", nullable: false),
                    DrillingMachinesAmount = table.Column<int>(type: "int", nullable: false),
                    CuttingMachinesAmount = table.Column<int>(type: "int", nullable: false),
                    WeldingMachinesAmount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DrillingMachineId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CuttingMachineId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    WeldingMachineId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BendingMachineId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CompanyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SelectedCompany = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Ks = table.Column<double>(type: "double", nullable: false),
                    F = table.Column<int>(type: "int", nullable: false),
                    G = table.Column<int>(type: "int", nullable: false),
                    Mb = table.Column<int>(type: "int", nullable: false),
                    Pb = table.Column<double>(type: "double", nullable: false),
                    Kzb = table.Column<double>(type: "double", nullable: false),
                    Kbpod = table.Column<double>(type: "double", nullable: false),
                    Pd = table.Column<double>(type: "double", nullable: false),
                    Kzd = table.Column<double>(type: "double", nullable: false),
                    Kdpod = table.Column<double>(type: "double", nullable: false),
                    Kzc = table.Column<double>(type: "double", nullable: false),
                    Kcpod = table.Column<double>(type: "double", nullable: false),
                    Isv = table.Column<int>(type: "int", nullable: false),
                    An = table.Column<double>(type: "double", nullable: false),
                    Kzw = table.Column<double>(type: "double", nullable: false),
                    Kn = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Ks);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WeldingMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    V_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Town = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    CostM = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Massa = table.Column<int>(type: "int", nullable: false),
                    LBH = table.Column<int>(type: "int", nullable: false),
                    Pmax = table.Column<int>(type: "int", nullable: false),
                    NUN = table.Column<int>(type: "int", nullable: false),
                    NGN = table.Column<int>(type: "int", nullable: false),
                    VI = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Arg = table.Column<int>(type: "int", nullable: false),
                    Parg = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeldingMachines", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BendingMachines");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CuttingMachines");

            migrationBuilder.DropTable(
                name: "DrillingMachines");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "WeldingMachines");
        }
    }
}
