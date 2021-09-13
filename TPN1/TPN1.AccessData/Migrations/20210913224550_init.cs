using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPN1.AccessData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(type: "int", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeliculaId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    SalaId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false),
                    PeliculasNavigatorPeliculaId = table.Column<int>(type: "int", nullable: true),
                    SalasNavigatorSalaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.FuncionId);
                    table.ForeignKey(
                        name: "FK_Funciones_Peliculas_PeliculasNavigatorPeliculaId",
                        column: x => x.PeliculasNavigatorPeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funciones_Salas_SalasNavigatorSalaId",
                        column: x => x.SalasNavigatorSalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.TicketId, x.FuncionId });
                    table.ForeignKey(
                        name: "FK_Tickets_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "FuncionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, "https://es.web.img3.acsta.net/c_310_420/medias/nmedia/18/71/18/12/20061511.jpg", "Sinopsis 1", "Star Wars: episodio IV - una nueva esperanza", "Trailer 1" },
                    { 2, "Poster 2", "Sinopsis 2", "El imperio contraataca", "Trailer 2" },
                    { 3, "Poster 3", "Sinopsis 3", "Star Wars: episodio VI - el retorno del Jedi", "Trailer 3" },
                    { 4, "Poster 4", "Sinopsis 4", "Star Wars: episodio I - la amenaza fantasma", "Trailer 4" },
                    { 5, "Poster 5", "Sinopsis 5", "Star Wars: episodio II - el ataque de los clones", "Trailer 5" },
                    { 6, "Poster 1", "Sinopsis 1", "Star wars: episodio III - la venganza de los sith", "Trailer 1" },
                    { 7, "Poster 2", "Sinopsis 2", "Star Wars: el despertar de la fuerza", "Trailer 2" },
                    { 8, "Poster 3", "Sinopsis 3", "Star Wars: Episodio VIII", "Trailer 3" },
                    { 9, "Poster 4", "Sinopsis 4", "Star Wars: Episodio IX", "Trailer 4" },
                    { 10, "Poster 5", "Sinopsis 5", "Rogue One: una historia de Star Wars", "Trailer 5" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Capacidad" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 15 },
                    { 3, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculasNavigatorPeliculaId",
                table: "Funciones",
                column: "PeliculasNavigatorPeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_SalasNavigatorSalaId",
                table: "Funciones",
                column: "SalasNavigatorSalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionId",
                table: "Tickets",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
