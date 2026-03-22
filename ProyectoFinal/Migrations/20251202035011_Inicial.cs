using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respuesta1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puntos1 = table.Column<int>(type: "int", nullable: false),
                    Respuesta2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puntos2 = table.Column<int>(type: "int", nullable: false),
                    Respuesta3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puntos3 = table.Column<int>(type: "int", nullable: false),
                    Respuesta4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puntos4 = table.Column<int>(type: "int", nullable: false),
                    Respuesta5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puntos5 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preguntas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preguntas");
        }
    }
}
