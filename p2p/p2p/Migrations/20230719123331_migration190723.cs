using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace p2p.Migrations
{
    /// <inheritdoc />
    public partial class migration190723 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Training",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Training",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tag",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Tag",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Role",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Role",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Person",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Person",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Person",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Person",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Person",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "birthday",
                table: "Person",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "adress",
                table: "Person",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Lesson",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Lesson",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Lesson",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Chapter",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Chapter",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Chapter",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Chapter",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Training",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Person",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Lesson",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Chapter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ChapterLesson",
                columns: table => new
                {
                    Chaptersid = table.Column<int>(type: "integer", nullable: false),
                    Lessonsid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterLesson", x => new { x.Chaptersid, x.Lessonsid });
                    table.ForeignKey(
                        name: "FK_ChapterLesson_Chapter_Chaptersid",
                        column: x => x.Chaptersid,
                        principalTable: "Chapter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChapterLesson_Lesson_Lessonsid",
                        column: x => x.Lessonsid,
                        principalTable: "Lesson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChapterTag",
                columns: table => new
                {
                    Chaptersid = table.Column<int>(type: "integer", nullable: false),
                    Tagsid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterTag", x => new { x.Chaptersid, x.Tagsid });
                    table.ForeignKey(
                        name: "FK_ChapterTag_Chapter_Chaptersid",
                        column: x => x.Chaptersid,
                        principalTable: "Chapter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChapterTag_Tag_Tagsid",
                        column: x => x.Tagsid,
                        principalTable: "Tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChapterTraining",
                columns: table => new
                {
                    Chaptersid = table.Column<int>(type: "integer", nullable: false),
                    Trainingsid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterTraining", x => new { x.Chaptersid, x.Trainingsid });
                    table.ForeignKey(
                        name: "FK_ChapterTraining_Chapter_Chaptersid",
                        column: x => x.Chaptersid,
                        principalTable: "Chapter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChapterTraining_Training_Trainingsid",
                        column: x => x.Trainingsid,
                        principalTable: "Training",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person_Lesson",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Is_active = table.Column<bool>(type: "boolean", nullable: false),
                    Is_validate = table.Column<bool>(type: "boolean", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    LessonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_Lesson", x => x.id);
                    table.ForeignKey(
                        name: "FK_Person_Lesson_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Lesson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person_Training",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Is_active = table.Column<bool>(type: "boolean", nullable: false),
                    Is_author = table.Column<bool>(type: "boolean", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    TrainingId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person_Training", x => x.id);
                    table.ForeignKey(
                        name: "FK_Person_Training_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Training_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Training_TagId",
                table: "Training",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RoleId",
                table: "Person",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_TagId",
                table: "Lesson",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_PersonId",
                table: "Chapter",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterLesson_Lessonsid",
                table: "ChapterLesson",
                column: "Lessonsid");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterTag_Tagsid",
                table: "ChapterTag",
                column: "Tagsid");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterTraining_Trainingsid",
                table: "ChapterTraining",
                column: "Trainingsid");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Lesson_LessonId",
                table: "Person_Lesson",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Lesson_PersonId",
                table: "Person_Lesson",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Training_PersonId",
                table: "Person_Training",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Training_TrainingId",
                table: "Person_Training",
                column: "TrainingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Person_PersonId",
                table: "Chapter",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Tag_TagId",
                table: "Lesson",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Role_RoleId",
                table: "Person",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Tag_TagId",
                table: "Training",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Person_PersonId",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Tag_TagId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Role_RoleId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_TagId",
                table: "Training");

            migrationBuilder.DropTable(
                name: "ChapterLesson");

            migrationBuilder.DropTable(
                name: "ChapterTag");

            migrationBuilder.DropTable(
                name: "ChapterTraining");

            migrationBuilder.DropTable(
                name: "Person_Lesson");

            migrationBuilder.DropTable(
                name: "Person_Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_TagId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Person_RoleId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_TagId",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Chapter_PersonId",
                table: "Chapter");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Chapter");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Training",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Training",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tag",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Tag",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Role",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Role",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Person",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Person",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Person",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Person",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Person",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Person",
                newName: "birthday");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Person",
                newName: "adress");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Lesson",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Lesson",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Lesson",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Chapter",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Chapter",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Chapter",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Chapter",
                newName: "description");
        }
    }
}
