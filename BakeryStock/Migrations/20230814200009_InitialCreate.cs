using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BakeryStock.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Validade = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Fornecedor = table.Column<string>(type: "text", nullable: true),
                    Preço = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabelas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoTabela",
                columns: table => new
                {
                    ProdutosId = table.Column<int>(type: "integer", nullable: false),
                    TabelasId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTabela", x => new { x.ProdutosId, x.TabelasId });
                    table.ForeignKey(
                        name: "FK_ProdutoTabela_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoTabela_Tabelas_TabelasId",
                        column: x => x.TabelasId,
                        principalTable: "Tabelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoTabelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Produto_IDId = table.Column<int>(type: "integer", nullable: true),
                    Tabela_IDId = table.Column<int>(type: "integer", nullable: true),
                    Quantidade = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTabelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoTabelas_Produtos_Produto_IDId",
                        column: x => x.Produto_IDId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoTabelas_Tabelas_Tabela_IDId",
                        column: x => x.Tabela_IDId,
                        principalTable: "Tabelas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tabela_IDId = table.Column<int>(type: "integer", nullable: true),
                    Produto_IDId = table.Column<int>(type: "integer", nullable: true),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_Produtos_Produto_IDId",
                        column: x => x.Produto_IDId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registros_Tabelas_Tabela_IDId",
                        column: x => x.Tabela_IDId,
                        principalTable: "Tabelas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTabela_TabelasId",
                table: "ProdutoTabela",
                column: "TabelasId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTabelas_Produto_IDId",
                table: "ProdutoTabelas",
                column: "Produto_IDId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTabelas_Tabela_IDId",
                table: "ProdutoTabelas",
                column: "Tabela_IDId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_Produto_IDId",
                table: "Registros",
                column: "Produto_IDId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_Tabela_IDId",
                table: "Registros",
                column: "Tabela_IDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoTabela");

            migrationBuilder.DropTable(
                name: "ProdutoTabelas");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Tabelas");
        }
    }
}
