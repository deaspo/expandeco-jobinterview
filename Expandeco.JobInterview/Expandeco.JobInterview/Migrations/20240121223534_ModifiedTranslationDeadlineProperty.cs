using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Expandeco.JobInterview.Migrations
{
    public partial class ModifiedTranslationDeadlineProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "Translations",
                newName: "DeadlineString");

            migrationBuilder.AddColumn<int>(
                name: "DeadlineId",
                table: "Translations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Deadline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeadlineDateTimeString = table.Column<string>(type: "TEXT", nullable: true),
                    DeadlineDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deadline", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 6, 10, 1, "Saepe omnis rerum quia quam quo consequatur unde aperiam voluptatem.", "aliquid et dolorem" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 5, 9, 1, 4, "Qui eveniet saepe provident rem et velit. Nesciunt omnis quasi voluptatem. Quam quia et voluptas id. Quia labore dolorem nostrum quo a quis in aut. Velit eligendi natus minus occaecati tempore vitae.", "ad tenetur rem" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 10, 2, 4, "Sit sunt ipsa nemo velit nesciunt et culpa.", "quam quo perspiciatis" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SourceLanguageId", "Text", "Title" },
                values: new object[] { 1, "Est et perspiciatis. Ex dolores a temporibus. Praesentium explicabo ea porro rerum a sit voluptatibus ipsum. Aliquid distinctio vel voluptatibus ea.", "distinctio et dolores" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedById", "Text", "Title" },
                values: new object[] { 10, "Vitae fugiat modi. Magnam velit aperiam dicta est eum accusamus officiis illum. Perspiciatis veniam placeat omnis unde omnis rerum est impedit dolorem. Molestiae repudiandae libero. Ut doloribus aliquid soluta placeat. Impedit et libero dolorem in aut beatae labore.", "sunt eum modi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedToId", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 5, 2, 3, "Distinctio quam repudiandae et blanditiis rerum et. Sit aut voluptatem. Consectetur eius illo sed delectus. Ut aut et maiores quisquam nam ut fuga dolore.", "autem eum aut" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { null, 10, "maxime", "in et quibusdam" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 2, 8, "Veniam et cupiditate sint quidem aspernatur accusamus laborum.", "sint aliquam ipsum" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 1, 4, "Laudantium consectetur expedita earum mollitia neque exercitationem est quos. Libero cumque iure esse quibusdam aliquid. Rerum sed qui repellat magni provident distinctio. Ut exercitationem enim et non illum nesciunt. Autem voluptates vitae aut recusandae quia sequi ullam.", "vitae recusandae aut" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { null, 10, "Et ex sed saepe dolorem odit ipsum. Quidem sed inventore aut reprehenderit. Voluptatem nobis accusantium incidunt quasi dolorum. Omnis aut hic ab fuga quae necessitatibus asperiores veniam. Nostrum natus placeat odit.", "quaerat optio iusto" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Matej Chudík");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Irma Hlaváčeková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Zuzana Straková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Valéria Trubenová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Václav Debnár");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Izabela Šoltésová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Klaudia Bukovská");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Kornélia Malíšeková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Valér Lepšík");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Monika Kolniková");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_DeadlineId",
                table: "Translations",
                column: "DeadlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Deadline_DeadlineId",
                table: "Translations",
                column: "DeadlineId",
                principalTable: "Deadline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Deadline_DeadlineId",
                table: "Translations");

            migrationBuilder.DropTable(
                name: "Deadline");

            migrationBuilder.DropIndex(
                name: "IX_Translations_DeadlineId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "DeadlineId",
                table: "Translations");

            migrationBuilder.RenameColumn(
                name: "DeadlineString",
                table: "Translations",
                newName: "Deadline");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { null, 8, 2, "Nulla minus quis quia.", "nobis voluptates architecto" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 7, 10, 2, 3, "odit", "sunt fugit atque" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 9, 1, 3, "quod", "modi sed qui" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SourceLanguageId", "Text", "Title" },
                values: new object[] { 2, "Doloremque ipsum enim in. Deserunt sunt quia fugit et error ducimus dolor quidem. Accusamus omnis esse delectus alias laborum quis ut ducimus explicabo.", "illo omnis laudantium" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedById", "Text", "Title" },
                values: new object[] { 9, "Quae dignissimos harum nostrum.\nNam ipsa nobis eum impedit tempora nesciunt nulla inventore.\nUt maiores nobis hic voluptatem quasi ut minus.\nNobis animi doloremque.", "ipsum quia est" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedToId", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 1, 4, "iste", "dolor fugit illo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 4, 8, "Omnis eveniet temporibus maiores consequuntur ut alias. Voluptas quis beatae ut officiis iure et harum in. Voluptatibus illum nihil pariatur quos quia rerum autem. Maiores praesentium maiores placeat. Cumque voluptatem ea quas.", "culpa numquam explicabo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { null, 10, "Aliquid pariatur ab perferendis fugiat non dolor quae soluta distinctio.", "et dolores eligendi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 2, 3, "Laborum itaque iusto.\nEt atque dicta temporibus maiores.\nSit aut mollitia veniam cumque ipsam voluptatem.\nIllum quo placeat.\nQuaerat quia suscipit.\nPorro repudiandae sed qui.", "voluptas vel nemo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 4, 8, "Repudiandae nam molestiae consequatur.", "quaerat libero voluptatem" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vít Krajíček");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Libuša Šoltésová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Igor Dávid");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Milota Dočolomanská");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Rastislav Cíger");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Sidónia Kaliská");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Drahomíra Masaryková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Jakub Slota");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Dezider Jendek");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Dezider Šulc");
        }
    }
}
