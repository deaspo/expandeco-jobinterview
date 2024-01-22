using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Expandeco.JobInterview.Migrations
{
    public partial class AddDeadlineToTranslations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "Translations",
                type: "TEXT",
                nullable: true);

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
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { 7, "odit", "sunt fugit atque" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { null, "quod", "modi sed qui" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { null, 9, 2, "Doloremque ipsum enim in. Deserunt sunt quia fugit et error ducimus dolor quidem. Accusamus omnis esse delectus alias laborum quis ut ducimus explicabo.", "illo omnis laudantium" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 9, 4, "Quae dignissimos harum nostrum.\nNam ipsa nobis eum impedit tempora nesciunt nulla inventore.\nUt maiores nobis hic voluptatem quasi ut minus.\nNobis animi doloremque.", "ipsum quia est" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TargetLanguageId", "Text", "Title" },
                values: new object[] { 4, "iste", "dolor fugit illo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 4, 8, 2, 4, "Omnis eveniet temporibus maiores consequuntur ut alias. Voluptas quis beatae ut officiis iure et harum in. Voluptatibus illum nihil pariatur quos quia rerum autem. Maiores praesentium maiores placeat. Cumque voluptatem ea quas.", "culpa numquam explicabo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 10, 4, "Aliquid pariatur ab perferendis fugiat non dolor quae soluta distinctio.", "et dolores eligendi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 10, 3, "Laborum itaque iusto.\nEt atque dicta temporibus maiores.\nSit aut mollitia veniam cumque ipsam voluptatem.\nIllum quo placeat.\nQuaerat quia suscipit.\nPorro repudiandae sed qui.", "voluptas vel nemo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 4, 8, 4, "Repudiandae nam molestiae consequatur.", "quaerat libero voluptatem" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_TypeId",
                table: "Users",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_TypeId",
                table: "Users",
                column: "TypeId",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_TypeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TypeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "Translations");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 3, 10, 1, "Magnam autem quaerat voluptas est.\nEa molestiae quia illo qui.\nVoluptas consequuntur repudiandae soluta modi.\nPerferendis consectetur tempore.\nNobis itaque tempore voluptatum voluptatem quae ratione.\nA sit mollitia sit sunt ipsum eligendi quo veritatis.", "nisi enim perferendis" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { 3, "Aut consectetur odit deleniti suscipit adipisci deserunt mollitia dolores.", "eaque exercitationem dolores" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { 5, "Quia dolor consequatur ex necessitatibus dolor dolorem in nulla maxime.", "ratione ipsam repudiandae" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 3, 10, 1, "Repellat aspernatur laborum provident omnis. Ab qui error doloribus incidunt quia vitae voluptatem voluptatem. Quis occaecati eius.", "tempore sint molestiae" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 6, 8, 3, "Error error placeat.", "velit qui qui" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TargetLanguageId", "Text", "Title" },
                values: new object[] { 3, "Laudantium iusto illo.", "incidunt porro eum" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 10, 1, 3, "Distinctio dolores ut occaecati hic odio.", "eos voluptatem error" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 2, 8, 3, "Quia dolorem optio minus.", "aut enim qui" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 5, 9, 4, "Non eius eum.", "quisquam sapiente doloremque" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 2, 9, 3, "Voluptate ipsa inventore tempore accusamus voluptas.\nEst et est maiores accusamus.", "veniam corrupti veritatis" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vít Sýkora");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Cyprián Heretik");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hana Dočolomanská");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Ľubica Kostkaová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Miloslav Tomko");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Ervín Mokroš");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Zuzana Janíková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Ľuboš Obšut");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Cyprián Fico");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Tichomír Maslo");
        }
    }
}
