using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace p2p.Migrations
{
    /// <inheritdoc />
    public partial class migration190723_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Person_personId",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Tag_tagId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training");

            migrationBuilder.AlterColumn<int>(
                name: "tagId",
                table: "Training",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "tagId",
                table: "Lesson",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "personId",
                table: "Chapter",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Person_personId",
                table: "Chapter",
                column: "personId",
                principalTable: "Person",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Tag_tagId",
                table: "Lesson",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Person_personId",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Tag_tagId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training");

            migrationBuilder.AlterColumn<int>(
                name: "tagId",
                table: "Training",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "tagId",
                table: "Lesson",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "personId",
                table: "Chapter",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Person_personId",
                table: "Chapter",
                column: "personId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Tag_tagId",
                table: "Lesson",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
