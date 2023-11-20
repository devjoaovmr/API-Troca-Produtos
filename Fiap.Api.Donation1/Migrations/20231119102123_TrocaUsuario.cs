using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class TrocaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Troca",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6709), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6724), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6726), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6727), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6729), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6733), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6734), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6736), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6740), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6742), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6744), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6746), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6747), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6749), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6751), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6752), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6754), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6756), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6758), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6759), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6761), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6763), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6765), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6766), new DateTime(2025, 5, 19, 7, 21, 23, 389, DateTimeKind.Local).AddTicks(6767) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Troca");

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
        }
    }
}
