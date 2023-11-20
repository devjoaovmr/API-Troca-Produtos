using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class AddProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ProdutoId", "DataCadastro", "DataExpiracao", "Descricao", "Disponivel", "Nome", "SugestaoTroca", "TipoProdutoId", "UsuarioId", "Valor" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1971), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1971), "Descrição", true, "Produto 6", "Sugestão de troca", 1, 1, 1.0 },
                    { 7, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1980), "Descrição", true, "Produto 7", "Sugestão de troca", 1, 1, 1.0 },
                    { 8, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1982), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1982), "Descrição", true, "Produto 8", "Sugestão de troca", 1, 1, 1.0 },
                    { 9, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1985), "Descrição", true, "Produto 9", "Sugestão de troca", 1, 1, 1.0 },
                    { 10, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1987), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1987), "Descrição", true, "Produto 10", "Sugestão de troca", 1, 1, 1.0 },
                    { 11, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1989), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1989), "Descrição", true, "Produto 11", "Sugestão de troca", 1, 1, 1.0 },
                    { 12, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1991), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1992), "Descrição", true, "Produto 12", "Sugestão de troca", 1, 1, 1.0 },
                    { 13, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1993), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1994), "Descrição", true, "Produto 13", "Sugestão de troca", 1, 1, 1.0 },
                    { 14, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1996), "Descrição", true, "Produto 14", "Sugestão de troca", 1, 1, 1.0 },
                    { 15, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1998), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1998), "Descrição", true, "Produto 15", "Sugestão de troca", 1, 1, 1.0 },
                    { 16, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2000), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2000), "Descrição", true, "Produto 16", "Sugestão de troca", 1, 1, 1.0 },
                    { 17, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2002), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2002), "Descrição", true, "Produto 17", "Sugestão de troca", 1, 1, 1.0 },
                    { 18, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2004), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2004), "Descrição", true, "Produto 18", "Sugestão de troca", 1, 1, 1.0 },
                    { 19, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2006), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2007), "Descrição", true, "Produto 19", "Sugestão de troca", 1, 1, 1.0 },
                    { 20, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2008), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2009), "Descrição", true, "Produto 20", "Sugestão de troca", 1, 1, 1.0 },
                    { 21, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2010), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2011), "Descrição", true, "Produto 21", "Sugestão de troca", 1, 1, 1.0 },
                    { 22, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2012), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2013), "Descrição", true, "Produto 22", "Sugestão de troca", 1, 1, 1.0 },
                    { 23, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2015), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2015), "Descrição", true, "Produto 23", "Sugestão de troca", 1, 1, 1.0 },
                    { 24, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2017), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2017), "Descrição", true, "Produto 24", "Sugestão de troca", 1, 1, 1.0 },
                    { 25, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2019), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2019), "Descrição", true, "Produto 25", "Sugestão de troca", 1, 1, 1.0 },
                    { 26, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2021), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2022), "Descrição", true, "Produto 26", "Sugestão de troca", 1, 1, 1.0 },
                    { 27, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2023), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2024), "Descrição", true, "Produto 27", "Sugestão de troca", 1, 1, 1.0 },
                    { 28, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2025), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2026), "Descrição", true, "Produto 28", "Sugestão de troca", 1, 1, 1.0 },
                    { 29, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2027), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2028), "Descrição", true, "Produto 29", "Sugestão de troca", 1, 1, 1.0 },
                    { 30, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2083), "Descrição", true, "Produto 30", "Sugestão de troca", 1, 1, 1.0 },
                    { 31, new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2085), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2085), "Descrição", true, "Produto 31", "Sugestão de troca", 1, 1, 1.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_DataCadastro",
                table: "Produto",
                column: "DataCadastro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Produto_DataCadastro",
                table: "Produto");

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31);
        }
    }
}
