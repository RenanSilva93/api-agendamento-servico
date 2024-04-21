using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_agendamento_servico.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoNovosCamposUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF_CNPJ",
                table: "Usuario",
                type: "NVARCHAR(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Usuario",
                type: "NVARCHAR(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            /*migrationBuilder.CreateIndex(
                name: "IX_User_Celular",
                table: "Usuario",
                column: "Celular",
                unique: true);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropIndex(
                name: "IX_User_Celular",
                table: "Usuario");*/

            migrationBuilder.DropColumn(
                name: "CPF_CNPJ",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Usuario");
        }
    }
}
