using Microsoft.EntityFrameworkCore.Migrations;

namespace Expandeco.JobInterview.Migrations
{
    public partial class UpdatedTranslationController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_TypeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TypeId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 3, 10, 1, 4, "Magnam autem quaerat voluptas est.\nEa molestiae quia illo qui.\nVoluptas consequuntur repudiandae soluta modi.\nPerferendis consectetur tempore.\nNobis itaque tempore voluptatum voluptatem quae ratione.\nA sit mollitia sit sunt ipsum eligendi quo veritatis.", "nisi enim perferendis" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 3, 10, "Aut consectetur odit deleniti suscipit adipisci deserunt mollitia dolores.", "eaque exercitationem dolores" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 5, 9, 1, "Quia dolor consequatur ex necessitatibus dolor dolorem in nulla maxime.", "ratione ipsam repudiandae" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 10, 1, "Repellat aspernatur laborum provident omnis. Ab qui error doloribus incidunt quia vitae voluptatem voluptatem. Quis occaecati eius.", "tempore sint molestiae" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedToId", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 6, 1, 3, "Error error placeat.", "velit qui qui" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Text", "Title" },
                values: new object[] { "Laudantium iusto illo.", "incidunt porro eum" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { null, 10, "Distinctio dolores ut occaecati hic odio.", "eos voluptatem error" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 2, 8, 2, 3, "Quia dolorem optio minus.", "aut enim qui" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 5, 9, 2, "Non eius eum.", "quisquam sapiente doloremque" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 2, 9, "Voluptate ipsa inventore tempore accusamus voluptas.\nEst et est maiores accusamus.", "veniam corrupti veritatis" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 5, 8, 2, 3, "Quod atque inventore qui iusto ea atque. Ut dolor architecto iure voluptatem ipsam dolorem minima incidunt. In asperiores earum.", "deleniti asperiores est" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { null, 8, "Unde velit ipsa sit et.\nDeleniti esse quo voluptatem reprehenderit qui quas explicabo.\nVoluptatem sit velit voluptas expedita aliquid.\nAnimi nihil quis.\nDolorem perferendis et velit sint quam.", "est quis molestiae" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 6, 8, 2, "Minima temporibus facilis illo.\nRem eaque blanditiis.\nEst repellendus consequatur earum corrupti mollitia suscipit ipsa tenetur necessitatibus.\nTemporibus sint ut ut voluptatem est.\nQuaerat quae fugiat aliquid aliquam.", "ad dolores pariatur" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 8, 2, "Consectetur quidem fugit quo. Cupiditate itaque qui saepe dolorum. Quis voluptas omnis tempore.", "ut qui aliquid" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedToId", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 2, 4, "Repellendus enim consequatur natus sed corrupti et enim. Sit voluptates rerum. Id odit eum blanditiis harum at illum perferendis aliquam reprehenderit. Eaque eos velit omnis. Vel odit magni.", "quia autem non" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Text", "Title" },
                values: new object[] { "Molestias laboriosam quia rem corporis ipsa.\nQuod et eveniet magni non.\nNon aut est cupiditate in nostrum at voluptatem.\nTempora dolor quibusdam ad.\nOdio id quia unde quia veritatis occaecati placeat ab beatae.", "facilis suscipit dicta" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 6, 8, "Non dolor aperiam consequatur nobis iure ut nisi minima fugit. Cum doloremque quae et alias. Ut a accusamus dolor dolor fugiat non a similique.", "eum saepe non" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 3, 10, 1, 4, "Enim eos repellendus nesciunt quia totam itaque id. Et odit officia eum explicabo eos ipsa quis omnis et. Quas at sed magnam quas in earum aspernatur natus eaque. Voluptatem quia ullam quos atque ipsum quo alias. Eveniet autem et voluptas doloremque.", "dolor quidem suscipit" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedToId", "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { null, 8, 1, "Maxime sed expedita animi cupiditate quo.\nAt aut nulla eum.", "ut in ex" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedToId", "CreatedById", "Text", "Title" },
                values: new object[] { 3, 10, "quo", "in omnis sed" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ondrej Kolnik");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bohumil Beňo");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Bernard Krajčo");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Patrik Krajíček");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ignác Senko");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Dobromila Lubinová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Klement Thomka");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Silvester Jánošík");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Štefánia Liptáková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Silvia Dvončová");

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
    }
}
