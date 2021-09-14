using Microsoft.EntityFrameworkCore.Migrations;

namespace TPN1.AccessData.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 1,
                columns: new[] { "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Leia es capturada por las tropas imperiales, antes de ser atrapada logra colocar el mensaje en R2D2. Al llegar a Tattooine junto con C3PO son capturados y vendidos al joven Luke Skywalker, quien descubrirá el mensaje oculto para salvar a Leia.", "Star Wars:Episodio IV Una nueva esperanza", "https://youtu.be/_sQSHZ65fPI" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 2,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTAFLmt-Hfy6valTAd6sdWx0GcUYd-qS_Bkd4-Tk7_pGOa7DLEd", "Aunque la Estrella de la Muerte ha sido destruida, las tropas imperiales han hecho salir a las fuerzas rebeldes de sus bases ocultas y los persiguen a través de la galaxia. Mientras, el grupo de rebeldes de Skywalker se esconde en un planeta helado.", "Star Wars:Episodio V El imperio contraataca", "https://youtu.be/Cgj0Pr6Ubqs" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 3,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXPU8__AsCs2FxSQ62Rn7I0OlCAFs_17nqY2sD_RGsMd2Y9uPF", "Luke Skywalker, ahora un experimentado caballero Jedi, intenta descubrir la identidad de Darth Vader.", "Star Wars:Episodio VI El retorno del Jedi", "https://youtu.be/Q4xMJxTaToQ" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 4,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRcSp3BcESE4TrXR3eaghjYYNfPWCVRtc-ATyQGZD-RHeDUd-zF", "Obi-Wan Kenobi es un joven aprendiz caballero Jedi bajo la tutela de Qui-Gon Jinn. Cuando la Federación de Comercio corta todas las rutas al planeta Naboo, Qui-Gon y Obi-Wan son asignados para solucionar el problema.", "Star Wars:Episodio I La amenaza fantasma", "https://youtu.be/L9ZgGEkH-yU" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 5,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQpbOR5bkTGz0c69DSqWJYmU_GSJS3uIS0FiUOJG8B7QPlQD0vZ", "En el Senado Galáctico reina la inquietud. Varios miles de sistemas solares han declarado su intención de abandonar la República. La reina Amidala regresa al Senado para conseguir un ejército que ayude a los caballeros jedi.", "Star Wars:Episodio II El ataque de los clones", "https://youtu.be/KYcb9jSjcDc" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR2S6Cnnf2IyMWxxboeFEpd4M8S-fXQZ-bPPfgnUFRDe7O53uIw", "Seducido por el lado oscuro, Anakin Skywalker se rebela contra su mentor, Obi-Wan Kenobi, y se convierte en Darth Vader.", "Star Wars:Episodio III La venganza de los sith", "https://youtu.be/d3XN49jmmGM" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 7,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://static.wikia.nocookie.net/esstarwars/images/2/2e/El_Despertar_de_la_Fuerza_Poster.jpg/revision/latest?cb=20180412014438", "El terrible y enigmático guerrero Kylo Ren ha reunido un nuevo ejército del Imperio, que se hace llamar la Primera Orden y ataca a la Alianza. La única esperanza para la galaxia es que Rey, Finn y BB-8 logren encontrar a tiempo a Luke Skywalker.", "Star Wars:Episodio VII El despertar de la fuerza", "https://youtu.be/EPkdiNHfF1U" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 8,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQCwbhD-mFerQzUo94bQvkzyS8yCyg7H4_Q8zxHInQGNN7JV92A", "La Primera Orden ha acorralado a los últimos miembros de la resistencia. Su última esperanza es que Finn se introduzca en la nave de Snoke y desactive el radar que les permite localizarlos. A su vez, Luke Skywalker se encuentra entrenando a Rey.", "Star Wars:Episodio VIII Los últimos Jedi", "https://youtu.be/EFNcvyWD4Ag" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 9,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT5T11lO5NUu09B5i37f3QC6VQVRMs2kkTrcwnYV9A3y--NUgI5", "Finn y Poe guían a la Resistencia para detener los planes de la Primera Orden para formar un nuevo imperio, mientras Rey anticipa un enfrentamiento inevitable con Kylo Ren.", "Star Wars:Episodio IX El ascenso de Skywalker", "https://youtu.be/o56ubcfwSzY" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                columns: new[] { "Poster", "Sinopsis", "Trailer" },
                values: new object[] { "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ81FkPnEGE1MrMa3gm9_s644scRNJEMpKRvMgvBivM8qj3fGZ4", "El Imperio va a construir una estación espacial capaz de destruir planetas, conocida como la Estrella de la Muerte. Los rebeldes, conocedores de esto, se embarcan en una misión extraordinaria: robar los planos y sabotear la estación.", "https://youtu.be/D47iksCvnRw" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 1,
                columns: new[] { "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Sinopsis 1", "Star Wars: episodio IV - una nueva esperanza", "Trailer 1" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 2,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 2", "Sinopsis 2", "El imperio contraataca", "Trailer 2" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 3,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 3", "Sinopsis 3", "Star Wars: episodio VI - el retorno del Jedi", "Trailer 3" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 4,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 4", "Sinopsis 4", "Star Wars: episodio I - la amenaza fantasma", "Trailer 4" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 5,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 5", "Sinopsis 5", "Star Wars: episodio II - el ataque de los clones", "Trailer 5" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 6,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 1", "Sinopsis 1", "Star wars: episodio III - la venganza de los sith", "Trailer 1" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 7,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 2", "Sinopsis 2", "Star Wars: el despertar de la fuerza", "Trailer 2" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 8,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 3", "Sinopsis 3", "Star Wars: Episodio VIII", "Trailer 3" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 9,
                columns: new[] { "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[] { "Poster 4", "Sinopsis 4", "Star Wars: Episodio IX", "Trailer 4" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "PeliculaId",
                keyValue: 10,
                columns: new[] { "Poster", "Sinopsis", "Trailer" },
                values: new object[] { "Poster 5", "Sinopsis 5", "Trailer 5" });
        }
    }
}
