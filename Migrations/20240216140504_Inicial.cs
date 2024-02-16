using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoBancoDados.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteCpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientePassaporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Destino",
                columns: table => new
                {
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destino", x => x.DestinoId);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    PacotesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacotesNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.PacotesId);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagamentoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.PagamentoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoHospedagem",
                columns: table => new
                {
                    TipoHospedagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoHospedagemNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoHospedagem", x => x.TipoHospedagemId);
                });

            migrationBuilder.CreateTable(
                name: "Transporte",
                columns: table => new
                {
                    TransporteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransporteNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransporteAno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransportePlaca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transporte", x => x.TransporteId);
                });

            migrationBuilder.CreateTable(
                name: "Hospedagem",
                columns: table => new
                {
                    HospedagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospedagemNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoHospedagemId = table.Column<int>(type: "int", nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: false),
                    HospedagemLocal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospedagem", x => x.HospedagemId);
                    table.ForeignKey(
                        name: "FK_Hospedagem_Destino_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destino",
                        principalColumn: "DestinoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospedagem_TipoHospedagem_TipoHospedagemId",
                        column: x => x.TipoHospedagemId,
                        principalTable: "TipoHospedagem",
                        principalColumn: "TipoHospedagemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    ViagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    PacotesId = table.Column<int>(type: "int", nullable: false),
                    HospedagemId = table.Column<int>(type: "int", nullable: false),
                    TransporteId = table.Column<int>(type: "int", nullable: false),
                    ViagemData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViagemValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.ViagemId);
                    table.ForeignKey(
                        name: "FK_Viagem_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Viagem_Hospedagem_HospedagemId",
                        column: x => x.HospedagemId,
                        principalTable: "Hospedagem",
                        principalColumn: "HospedagemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Viagem_Pacotes_PacotesId",
                        column: x => x.PacotesId,
                        principalTable: "Pacotes",
                        principalColumn: "PacotesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Viagem_Pagamento_PagamentoId",
                        column: x => x.PagamentoId,
                        principalTable: "Pagamento",
                        principalColumn: "PagamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Viagem_Transporte_TransporteId",
                        column: x => x.TransporteId,
                        principalTable: "Transporte",
                        principalColumn: "TransporteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hospedagem_DestinoId",
                table: "Hospedagem",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospedagem_TipoHospedagemId",
                table: "Hospedagem",
                column: "TipoHospedagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_ClienteId",
                table: "Viagem",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_HospedagemId",
                table: "Viagem",
                column: "HospedagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_PacotesId",
                table: "Viagem",
                column: "PacotesId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_PagamentoId",
                table: "Viagem",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_TransporteId",
                table: "Viagem",
                column: "TransporteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagem");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Hospedagem");

            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Transporte");

            migrationBuilder.DropTable(
                name: "Destino");

            migrationBuilder.DropTable(
                name: "TipoHospedagem");
        }
    }
}
