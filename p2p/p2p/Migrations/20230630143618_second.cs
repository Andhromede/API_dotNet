using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace p2p.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralItem",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "Lesson_title",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "Training_title",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "adress",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "content",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "description",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "duration",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "email",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "name",
                table: "GeneralItem");

            migrationBuilder.DropColumn(
                name: "password",
                table: "GeneralItem");

            migrationBuilder.RenameTable(
                name: "GeneralItem",
                newName: "Training");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Training",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Training",
                table: "Training",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    duration = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    firstName = table.Column<string>(type: "text", nullable: true),
                    lastName = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    adress = table.Column<string>(type: "text", nullable: true),
                    birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Training",
                table: "Training");

            migrationBuilder.RenameTable(
                name: "Training",
                newName: "GeneralItem");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "GeneralItem",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "GeneralItem",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lesson_title",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Training_title",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "GeneralItem",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "content",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "duration",
                table: "GeneralItem",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "GeneralItem",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralItem",
                table: "GeneralItem",
                column: "id");
        }
    }
}
