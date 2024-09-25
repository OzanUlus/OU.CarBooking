using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBooking.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Title1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Title3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
