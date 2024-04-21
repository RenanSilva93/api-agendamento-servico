using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_agendamento_servico.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoNovosCamposUsuarios2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropIndex(
                name: "IX_User_Celular",
                table: "Usuario");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateIndex(
                name: "IX_User_Celular",
                table: "Usuario",
                column: "Celular",
                unique: true);*/
        }
    }
}
