using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace p2p.Migrations
{
    /// <inheritdoc />
    public partial class migration190723_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Person_PersonId",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterLesson_Chapter_Chaptersid",
                table: "ChapterLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterLesson_Lesson_Lessonsid",
                table: "ChapterLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTag_Chapter_Chaptersid",
                table: "ChapterTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTag_Tag_Tagsid",
                table: "ChapterTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTraining_Chapter_Chaptersid",
                table: "ChapterTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTraining_Training_Trainingsid",
                table: "ChapterTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Tag_TagId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Role_RoleId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Lesson_Lesson_LessonId",
                table: "Person_Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Lesson_Person_PersonId",
                table: "Person_Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Training_Person_PersonId",
                table: "Person_Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Training_Training_TrainingId",
                table: "Person_Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_TagId",
                table: "Training");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Training",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Training",
                newName: "tagId");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Training",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Training_TagId",
                table: "Training",
                newName: "IX_Training_tagId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tag",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Tag",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Role",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Role",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "TrainingId",
                table: "Person_Training",
                newName: "trainingId");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person_Training",
                newName: "personId");

            migrationBuilder.RenameColumn(
                name: "Is_author",
                table: "Person_Training",
                newName: "isAuthor");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Person_Training",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Training_TrainingId",
                table: "Person_Training",
                newName: "IX_Person_Training_trainingId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Training_PersonId",
                table: "Person_Training",
                newName: "IX_Person_Training_personId");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person_Lesson",
                newName: "personId");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "Person_Lesson",
                newName: "lessonId");

            migrationBuilder.RenameColumn(
                name: "Is_validate",
                table: "Person_Lesson",
                newName: "isValidate");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Person_Lesson",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Lesson_PersonId",
                table: "Person_Lesson",
                newName: "IX_Person_Lesson_personId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Lesson_LessonId",
                table: "Person_Lesson",
                newName: "IX_Person_Lesson_lessonId");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Person",
                newName: "roleId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Person",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Person",
                newName: "lastName");

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
                name: "Is_active",
                table: "Person",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Person_RoleId",
                table: "Person",
                newName: "IX_Person_roleId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Lesson",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Lesson",
                newName: "tagId");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Lesson",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Lesson",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_TagId",
                table: "Lesson",
                newName: "IX_Lesson_tagId");

            migrationBuilder.RenameColumn(
                name: "Trainingsid",
                table: "ChapterTraining",
                newName: "trainingsid");

            migrationBuilder.RenameColumn(
                name: "Chaptersid",
                table: "ChapterTraining",
                newName: "chaptersid");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterTraining_Trainingsid",
                table: "ChapterTraining",
                newName: "IX_ChapterTraining_trainingsid");

            migrationBuilder.RenameColumn(
                name: "Tagsid",
                table: "ChapterTag",
                newName: "tagsid");

            migrationBuilder.RenameColumn(
                name: "Chaptersid",
                table: "ChapterTag",
                newName: "chaptersid");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterTag_Tagsid",
                table: "ChapterTag",
                newName: "IX_ChapterTag_tagsid");

            migrationBuilder.RenameColumn(
                name: "Lessonsid",
                table: "ChapterLesson",
                newName: "lessonsid");

            migrationBuilder.RenameColumn(
                name: "Chaptersid",
                table: "ChapterLesson",
                newName: "chaptersid");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterLesson_Lessonsid",
                table: "ChapterLesson",
                newName: "IX_ChapterLesson_lessonsid");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Chapter",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Chapter",
                newName: "personId");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Chapter",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Chapter",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "Chapter",
                newName: "isActive");

            migrationBuilder.RenameIndex(
                name: "IX_Chapter_PersonId",
                table: "Chapter",
                newName: "IX_Chapter_personId");

            migrationBuilder.AlterColumn<string>(
                name: "content",
                table: "Lesson",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Chapter",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Person_personId",
                table: "Chapter",
                column: "personId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterLesson_Chapter_chaptersid",
                table: "ChapterLesson",
                column: "chaptersid",
                principalTable: "Chapter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterLesson_Lesson_lessonsid",
                table: "ChapterLesson",
                column: "lessonsid",
                principalTable: "Lesson",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTag_Chapter_chaptersid",
                table: "ChapterTag",
                column: "chaptersid",
                principalTable: "Chapter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTag_Tag_tagsid",
                table: "ChapterTag",
                column: "tagsid",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTraining_Chapter_chaptersid",
                table: "ChapterTraining",
                column: "chaptersid",
                principalTable: "Chapter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTraining_Training_trainingsid",
                table: "ChapterTraining",
                column: "trainingsid",
                principalTable: "Training",
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
                name: "FK_Person_Role_roleId",
                table: "Person",
                column: "roleId",
                principalTable: "Role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Lesson_Lesson_lessonId",
                table: "Person_Lesson",
                column: "lessonId",
                principalTable: "Lesson",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Lesson_Person_personId",
                table: "Person_Lesson",
                column: "personId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Training_Person_personId",
                table: "Person_Training",
                column: "personId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Training_Training_trainingId",
                table: "Person_Training",
                column: "trainingId",
                principalTable: "Training",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Person_personId",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterLesson_Chapter_chaptersid",
                table: "ChapterLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterLesson_Lesson_lessonsid",
                table: "ChapterLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTag_Chapter_chaptersid",
                table: "ChapterTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTag_Tag_tagsid",
                table: "ChapterTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTraining_Chapter_chaptersid",
                table: "ChapterTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterTraining_Training_trainingsid",
                table: "ChapterTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Tag_tagId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Role_roleId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Lesson_Lesson_lessonId",
                table: "Person_Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Lesson_Person_personId",
                table: "Person_Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Training_Person_personId",
                table: "Person_Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Training_Training_trainingId",
                table: "Person_Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Tag_tagId",
                table: "Training");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Training",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "tagId",
                table: "Training",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Training",
                newName: "Is_active");

            migrationBuilder.RenameIndex(
                name: "IX_Training_tagId",
                table: "Training",
                newName: "IX_Training_TagId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tag",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Tag",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Role",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Role",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "trainingId",
                table: "Person_Training",
                newName: "TrainingId");

            migrationBuilder.RenameColumn(
                name: "personId",
                table: "Person_Training",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "isAuthor",
                table: "Person_Training",
                newName: "Is_author");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Person_Training",
                newName: "Is_active");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Training_trainingId",
                table: "Person_Training",
                newName: "IX_Person_Training_TrainingId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Training_personId",
                table: "Person_Training",
                newName: "IX_Person_Training_PersonId");

            migrationBuilder.RenameColumn(
                name: "personId",
                table: "Person_Lesson",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "lessonId",
                table: "Person_Lesson",
                newName: "LessonId");

            migrationBuilder.RenameColumn(
                name: "isValidate",
                table: "Person_Lesson",
                newName: "Is_validate");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Person_Lesson",
                newName: "Is_active");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Lesson_personId",
                table: "Person_Lesson",
                newName: "IX_Person_Lesson_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_Lesson_lessonId",
                table: "Person_Lesson",
                newName: "IX_Person_Lesson_LessonId");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "Person",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Person",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Person",
                newName: "LastName");

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
                name: "isActive",
                table: "Person",
                newName: "Is_active");

            migrationBuilder.RenameIndex(
                name: "IX_Person_roleId",
                table: "Person",
                newName: "IX_Person_RoleId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Lesson",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "tagId",
                table: "Lesson",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Lesson",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Lesson",
                newName: "Is_active");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_tagId",
                table: "Lesson",
                newName: "IX_Lesson_TagId");

            migrationBuilder.RenameColumn(
                name: "trainingsid",
                table: "ChapterTraining",
                newName: "Trainingsid");

            migrationBuilder.RenameColumn(
                name: "chaptersid",
                table: "ChapterTraining",
                newName: "Chaptersid");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterTraining_trainingsid",
                table: "ChapterTraining",
                newName: "IX_ChapterTraining_Trainingsid");

            migrationBuilder.RenameColumn(
                name: "tagsid",
                table: "ChapterTag",
                newName: "Tagsid");

            migrationBuilder.RenameColumn(
                name: "chaptersid",
                table: "ChapterTag",
                newName: "Chaptersid");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterTag_tagsid",
                table: "ChapterTag",
                newName: "IX_ChapterTag_Tagsid");

            migrationBuilder.RenameColumn(
                name: "lessonsid",
                table: "ChapterLesson",
                newName: "Lessonsid");

            migrationBuilder.RenameColumn(
                name: "chaptersid",
                table: "ChapterLesson",
                newName: "Chaptersid");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterLesson_lessonsid",
                table: "ChapterLesson",
                newName: "IX_ChapterLesson_Lessonsid");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Chapter",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "personId",
                table: "Chapter",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Chapter",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Chapter",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Chapter",
                newName: "Is_active");

            migrationBuilder.RenameIndex(
                name: "IX_Chapter_personId",
                table: "Chapter",
                newName: "IX_Chapter_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Lesson",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Chapter",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Person_PersonId",
                table: "Chapter",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterLesson_Chapter_Chaptersid",
                table: "ChapterLesson",
                column: "Chaptersid",
                principalTable: "Chapter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterLesson_Lesson_Lessonsid",
                table: "ChapterLesson",
                column: "Lessonsid",
                principalTable: "Lesson",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTag_Chapter_Chaptersid",
                table: "ChapterTag",
                column: "Chaptersid",
                principalTable: "Chapter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTag_Tag_Tagsid",
                table: "ChapterTag",
                column: "Tagsid",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTraining_Chapter_Chaptersid",
                table: "ChapterTraining",
                column: "Chaptersid",
                principalTable: "Chapter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterTraining_Training_Trainingsid",
                table: "ChapterTraining",
                column: "Trainingsid",
                principalTable: "Training",
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
                name: "FK_Person_Lesson_Lesson_LessonId",
                table: "Person_Lesson",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Lesson_Person_PersonId",
                table: "Person_Lesson",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Training_Person_PersonId",
                table: "Person_Training",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Training_Training_TrainingId",
                table: "Person_Training",
                column: "TrainingId",
                principalTable: "Training",
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
    }
}
