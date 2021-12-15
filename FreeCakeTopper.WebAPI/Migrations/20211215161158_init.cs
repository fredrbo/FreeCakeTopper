using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeCakeTopper.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopperNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Font = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopperNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopperNames_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToppers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    TopperId = table.Column<int>(type: "INTEGER", nullable: false),
                    TopperNameId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToppers", x => new { x.UserId, x.TopperId });
                    table.ForeignKey(
                        name: "FK_UserToppers_TopperNames_TopperNameId",
                        column: x => x.TopperNameId,
                        principalTable: "TopperNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserToppers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 1, "jose@gmail.com", "José", "123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 2, "fred@gmail.com", "Fred", "fred13" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 3, "bia@gmail.com", "Bia", "suco13" });

            migrationBuilder.InsertData(
                table: "TopperNames",
                columns: new[] { "Id", "Color", "Font", "Name", "UserId" },
                values: new object[] { 1, "Blue", "Arial", "João", 1 });

            migrationBuilder.InsertData(
                table: "TopperNames",
                columns: new[] { "Id", "Color", "Font", "Name", "UserId" },
                values: new object[] { 2, "Orange", "Bonita", "Leo", 1 });

            migrationBuilder.InsertData(
                table: "TopperNames",
                columns: new[] { "Id", "Color", "Font", "Name", "UserId" },
                values: new object[] { 3, "Red", "Helvetica", "João", 2 });

            migrationBuilder.InsertData(
                table: "TopperNames",
                columns: new[] { "Id", "Color", "Font", "Name", "UserId" },
                values: new object[] { 4, "Blue", "Helvetica", "Bale", 2 });

            migrationBuilder.InsertData(
                table: "TopperNames",
                columns: new[] { "Id", "Color", "Font", "Name", "UserId" },
                values: new object[] { 5, "Black", "Arial", "Tarc", 3 });

            migrationBuilder.InsertData(
                table: "TopperNames",
                columns: new[] { "Id", "Color", "Font", "Name", "UserId" },
                values: new object[] { 6, "Gray", "Bonita", "Jaspin", 3 });

            migrationBuilder.InsertData(
                table: "UserToppers",
                columns: new[] { "TopperId", "UserId", "TopperNameId" },
                values: new object[] { 1, 1, null });

            migrationBuilder.InsertData(
                table: "UserToppers",
                columns: new[] { "TopperId", "UserId", "TopperNameId" },
                values: new object[] { 2, 1, null });

            migrationBuilder.InsertData(
                table: "UserToppers",
                columns: new[] { "TopperId", "UserId", "TopperNameId" },
                values: new object[] { 3, 2, null });

            migrationBuilder.InsertData(
                table: "UserToppers",
                columns: new[] { "TopperId", "UserId", "TopperNameId" },
                values: new object[] { 4, 2, null });

            migrationBuilder.InsertData(
                table: "UserToppers",
                columns: new[] { "TopperId", "UserId", "TopperNameId" },
                values: new object[] { 5, 3, null });

            migrationBuilder.InsertData(
                table: "UserToppers",
                columns: new[] { "TopperId", "UserId", "TopperNameId" },
                values: new object[] { 6, 3, null });

            migrationBuilder.CreateIndex(
                name: "IX_TopperNames_UserId",
                table: "TopperNames",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToppers_TopperNameId",
                table: "UserToppers",
                column: "TopperNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserToppers");

            migrationBuilder.DropTable(
                name: "TopperNames");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
