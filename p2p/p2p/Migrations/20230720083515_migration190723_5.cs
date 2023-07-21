using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace p2p.Migrations
{
    /// <inheritdoc />
    public partial class migration190723_5 : Migration
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
                name: "FK_Person_Role_roleId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "Person",
                newName: "roleid");

            migrationBuilder.RenameIndex(
                name: "IX_Person_roleId",
                table: "Person",
                newName: "IX_Person_roleid");

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
                name: "roleid",
                table: "Person",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
                name: "FK_Person_Role_roleid",
                table: "Person",
                column: "roleid",
                principalTable: "Role",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_Person_Role_roleid",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training");

            migrationBuilder.RenameColumn(
                name: "roleid",
                table: "Person",
                newName: "roleId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_roleid",
                table: "Person",
                newName: "IX_Person_roleId");

            migrationBuilder.AlterColumn<int>(
                name: "tagId",
                table: "Training",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "roleId",
                table: "Person",
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
                name: "FK_Person_Role_roleId",
                table: "Person",
                column: "roleId",
                principalTable: "Role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training",
                column: "tagId",
                principalTable: "Tag",
                principalColumn: "id");
        }
    }
}
