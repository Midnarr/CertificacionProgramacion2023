using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cuentaBancaria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroCuenta = table.Column<int>(type: "int", nullable: false),
                    saldo = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clienteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cuentaBancaria", x => x.id);
                    table.ForeignKey(
                        name: "FK_cuentaBancaria_Cliente_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tarjetaCredito",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numTarjeta = table.Column<int>(type: "int", nullable: false),
                    limiteCredito = table.Column<int>(type: "int", nullable: false),
                    saldoDisponible = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clienteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarjetaCredito", x => x.id);
                    table.ForeignKey(
                        name: "FK_tarjetaCredito_Cliente_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cuentaBancaria_clienteid",
                table: "cuentaBancaria",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_tarjetaCredito_clienteid",
                table: "tarjetaCredito",
                column: "clienteid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cuentaBancaria");

            migrationBuilder.DropTable(
                name: "tarjetaCredito");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
