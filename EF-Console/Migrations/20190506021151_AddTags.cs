using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Console.Migrations
{
    public partial class AddTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tag",
                schema: "learning",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "account_tag",
                schema: "learning",
                columns: table => new
                {
                    account_id = table.Column<string>(nullable: false),
                    tag_id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_account_tag", x => new { x.account_id, x.tag_id });
                    table.ForeignKey(
                        name: "fk_account_tag_account_account_id",
                        column: x => x.account_id,
                        principalSchema: "learning",
                        principalTable: "account",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_account_tag_tag_tag_id",
                        column: x => x.tag_id,
                        principalSchema: "learning",
                        principalTable: "tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_account_tag_tag_id",
                schema: "learning",
                table: "account_tag",
                column: "tag_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account_tag",
                schema: "learning");

            migrationBuilder.DropTable(
                name: "tag",
                schema: "learning");
        }
    }
}
