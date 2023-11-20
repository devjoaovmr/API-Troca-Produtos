using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class Troca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Troca",
                columns: table => new
                {
                    TrocaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProdutoId1 = table.Column<int>(type: "int", nullable: false),
                    ProdutoId2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troca", x => x.TrocaId);
                    table.ForeignKey(
                        name: "FK_Troca_Produto_ProdutoId1",
                        column: x => x.ProdutoId1,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Troca_Produto_ProdutoId2",
                        column: x => x.ProdutoId2,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7465), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7473), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7475), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7476), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7478), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7479), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7481), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7483), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7484), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7486), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7488), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7529), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7531), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7533), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7534), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7536), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7540), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7541), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7543), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7545), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7548), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7549), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7551), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7552), new DateTime(2025, 5, 19, 7, 9, 5, 849, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId1",
                table: "Troca",
                column: "ProdutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId2",
                table: "Troca",
                column: "ProdutoId2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Troca");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1971), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1982), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1987), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1989), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1991), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1993), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1998), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2000), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2002), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2004), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2006), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2008), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2010), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2012), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2015), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2017), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2019), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2021), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2023), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2025), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2027), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2085), new DateTime(2025, 5, 18, 8, 10, 57, 816, DateTimeKind.Local).AddTicks(2085) });
        }
    }
}
