using Microsoft.EntityFrameworkCore.Migrations;

namespace OyunKiralamaSitesimain.Migrations
{
    public partial class dboyun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "01901865-4b25-43a5-92f3-1021fc95e8a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "61f8bae9-b639-4a2b-a1dd-9eef8437a3e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01a6e0e0-58a9-457d-94f8-f38eefc7dd38", "AQAAAAEAACcQAAAAEBwlFp7EYpJ/UnSk2RpaI/XT5+wjjvHZZeD3KKx+WYTaCIEpsAPc8cXnor9qCY3mew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab63f5ed-c825-4623-a619-509b6edd87a8", "AQAAAAEAACcQAAAAEKWZNeh41pqa44BFADP+uOjrDyvzz1GY74Xps15RFGJSFO/KznDpOBzSP7A2QZOvrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79595730-19d7-4cf6-87e4-dc84de8e2e3a", "AQAAAAEAACcQAAAAEJlob1xn7s74qKx1NRajdlrBDgZzE+Qa9ksgC7kgDzCyjRQZaOIXuVQo3E4SGMQqsA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b4d9b5c6-d882-491d-96be-135bde63b5f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "46067e0d-280d-47eb-b191-9a038cc51714");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b866b8d9-6579-4448-89da-8a67cef57270", "AQAAAAEAACcQAAAAEDjOem0A1Hl/e2WOCvmtIGpIjBOAA5c12VRsFlAsgedcrjz9MLK/ajj1kcqc+qjf8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21e1de11-2255-43a2-899c-4cd85ea848b8", "AQAAAAEAACcQAAAAEGHvwzKO5XI4mcB2ZWeglRi+1ZiJtCSeCzrcAZyKiRNQs27q45LiOZIW8q6lOLlsWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b87d2f3-5318-446a-ad0b-7f2c2d3c58b1", "AQAAAAEAACcQAAAAEDnJFHEbryJegsAyKkdCNML7ubRpfD0ZuR6Yo85yOCwVe62CEA+0GvghsHIOL1cfow==" });
        }
    }
}
