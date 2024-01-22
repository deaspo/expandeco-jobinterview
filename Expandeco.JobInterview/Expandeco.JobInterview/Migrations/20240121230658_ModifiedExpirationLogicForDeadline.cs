using Microsoft.EntityFrameworkCore.Migrations;

namespace Expandeco.JobInterview.Migrations
{
    public partial class ModifiedExpirationLogicForDeadline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ExpiredDeadline",
                table: "Deadline",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 5, 9, 3, "Aut aliquid nihil modi.\nReiciendis repudiandae labore rem iusto in ipsam.\nItaque beatae accusantium atque qui ex hic voluptas.\nEt magni ratione omnis et.\nOfficiis dolore dolores.", "nemo incidunt necessitatibus" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { 2, "Et pariatur et soluta esse. Beatae dolores nisi velit eligendi inventore nulla. Autem iste suscipit. Illo qui ipsa neque sapiente. Iure provident voluptas.", "aspernatur totam id" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { 5, "Voluptas id quia inventore.\nFugiat aut consequatur.\nVitae et et eos nihil laboriosam laboriosam.\nTotam ab inventore exercitationem corporis eum qui delectus blanditiis et.\nDolor et deleniti.\nDolore cumque blanditiis temporibus.", "repellendus necessitatibus excepturi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedById", "Text", "Title" },
                values: new object[] { 8, "alias", "aperiam veritatis eaque" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 9, 2, 3, "omnis", "voluptatum est minus" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedToId", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { null, 1, 4, "Eum nostrum ut libero possimus.", "beatae quo quia" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Text", "Title" },
                values: new object[] { "Repellendus ipsa quia et sed.", "tenetur quod harum" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 7, 1, "sit", "repudiandae harum ut" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 9, 2, "Soluta delectus nesciunt quia libero in possimus omnis corrupti est.", "quis vero praesentium" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 8, 1, "Fugit necessitatibus velit iure porro provident. Quo asperiores repellat nobis ratione deserunt magni qui. Molestiae voluptas quos voluptas sequi. Perspiciatis ab ipsum tempore.", "perferendis voluptatum ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bohdan Šidlo");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Aurélia Ďuricová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Bernard Slovák");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Denis Turčok");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Nataša Pelikánová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Albín Ďuriš");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Darina Jurkovičová");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Laura Rybníčeková");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Ferdinand Mojžiš");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Hugo Finka");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiredDeadline",
                table: "Deadline");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToId", "CreatedById", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 6, 10, 4, "Saepe omnis rerum quia quam quo consequatur unde aperiam voluptatem.", "aliquid et dolorem" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { 5, "Qui eveniet saepe provident rem et velit. Nesciunt omnis quasi voluptatem. Quam quia et voluptas id. Quia labore dolorem nostrum quo a quis in aut. Velit eligendi natus minus occaecati tempore vitae.", "ad tenetur rem" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToId", "Text", "Title" },
                values: new object[] { null, "Sit sunt ipsa nemo velit nesciunt et culpa.", "quam quo perspiciatis" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedById", "Text", "Title" },
                values: new object[] { 9, "Est et perspiciatis. Ex dolores a temporibus. Praesentium explicabo ea porro rerum a sit voluptatibus ipsum. Aliquid distinctio vel voluptatibus ea.", "distinctio et dolores" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedById", "SourceLanguageId", "TargetLanguageId", "Text", "Title" },
                values: new object[] { 10, 1, 4, "Vitae fugiat modi. Magnam velit aperiam dicta est eum accusamus officiis illum. Perspiciatis veniam placeat omnis unde omnis rerum est impedit dolorem. Molestiae repudiandae libero. Ut doloribus aliquid soluta placeat. Impedit et libero dolorem in aut beatae labore.", "sunt eum modi" });

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
                columns: new[] { "Text", "Title" },
                values: new object[] { "maxime", "in et quibusdam" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedToId", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 2, 2, "Veniam et cupiditate sint quidem aspernatur accusamus laborum.", "sint aliquam ipsum" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 10, 1, "Laudantium consectetur expedita earum mollitia neque exercitationem est quos. Libero cumque iure esse quibusdam aliquid. Rerum sed qui repellat magni provident distinctio. Ut exercitationem enim et non illum nesciunt. Autem voluptates vitae aut recusandae quia sequi ullam.", "vitae recusandae aut" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedById", "SourceLanguageId", "Text", "Title" },
                values: new object[] { 10, 2, "Et ex sed saepe dolorem odit ipsum. Quidem sed inventore aut reprehenderit. Voluptatem nobis accusantium incidunt quasi dolorum. Omnis aut hic ab fuga quae necessitatibus asperiores veniam. Nostrum natus placeat odit.", "quaerat optio iusto" });

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
        }
    }
}
