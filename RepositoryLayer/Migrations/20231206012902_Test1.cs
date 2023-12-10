using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1ad468c7-84df-4d59-bd20-f5b41004a6bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "00ca6575-b8bb-4236-b15d-ac77402cc04b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "dd386f40-b883-4e18-a31f-258a0eb99da5");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Oncologist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Internist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "dentist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Otorhinolaryngologist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Orthopedic ");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Neurologist");

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Dermatology" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ded33e53-ad9c-4fdd-a035-41dc6a68c639");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5a225ecf-6afd-4232-963b-3a4a9ca1c048");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d685341f-801d-4c46-acc2-6cd4c82a48c8");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Dermatology");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Oncologist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Internist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "dentist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Otorhinolaryngologist");

            migrationBuilder.UpdateData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Orthopedic ");

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Neurologist" });
        }
    }
}
