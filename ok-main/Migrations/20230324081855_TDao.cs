using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class TDao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "b6d4087a-7b6b-4ebf-8dd6-3ec1a0b14ddf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "02c6c31c-ee60-412b-b31f-4d7fbf5479b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "a0b20484-6a32-47a8-b7dd-98dc97309111");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f7bbe6e-cc04-4d4d-ba70-3ffd9abb1359", "AQAAAAEAACcQAAAAEIQMB01ojEYrGxGyD6m4Eu8GrCWadXFJE+9REEd7D0Rk9sLmWEmEMmw1rnpLKBEm5Q==", "8e5c487f-79ca-4753-a8fa-8d55d7484684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea10cc06-91fb-45c1-8d37-cf5d6ce7540f", "AQAAAAEAACcQAAAAEGfHc8t5A/qGkme7UexSPa5FVWKRHqmzFCQU7UEecfjZXgrOs+UUI4xv+o+1JjKP/Q==", "63713e65-3374-41e4-885c-06240eebf2b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "044f7c01-8aa3-4132-97d6-b1ccbf48dcc4", "AQAAAAEAACcQAAAAEEz59VbRbmQCyEStLsR55PFeZStndfsXUMmSiqc7H4iJEnsGYsUN0QCYsX8kM5FcjA==", "548afe98-960d-4af0-a0af-9120f56e11fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c650e42d-8b0b-40a3-ae81-cfd71ea75351", "AQAAAAEAACcQAAAAELF0B5C3dbN8qqNYp/UWUbcbhxZUgVriL4D4QRhwDwnNbVSrjLbVeJiia/WP3YXjJA==", "13182bf8-f7dd-4b5a-ba7e-f46c5e77064c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac00984b-5035-491e-b856-a000b469f9de", "AQAAAAEAACcQAAAAEPo3wIGewWAVqUp2BGa+JCX9dJx9nwPAi71Et3WksjbLG6FxV6k4+rP+BkAqdx+1UA==", "cafeb0da-e394-4092-b354-f8c7a8dbbc7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eea8671e-0af1-4b6a-815d-d8047ab3b428", "AQAAAAEAACcQAAAAEHUCGFvnBPbVKKObhnwau5xAom6FMUULTaXt0c8CHJsB8bl04I3UZA4ihSL3K8Fybg==", "8e7f68ee-88a3-49a4-a098-142725ae1b6b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "ff1f2338-804c-4b82-9248-5ad5987b4b9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "e715344d-9e06-4822-bfcb-84de50458e60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "87ad2e31-7e4f-46fa-bab6-8da05165ee3d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ac7baa6-fb7e-4d20-9e68-854dc45916a2", "AQAAAAEAACcQAAAAEMkZnyT6RpXPlxMqcODgkgi/Je4BYvrr7RWORj41WbW6/mHj1A1sQhLLjmpz/udyJA==", "1be5d604-5ab4-4851-935a-72ae224d5332" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "788c6d6a-8009-43a8-aa9f-fe029285fb1a", "AQAAAAEAACcQAAAAECDwukfRVTEzNSkl8G12pkfeAZ2IMIbQOIa/a2x/Ce87I6Dxd2icUKme23nXEzZt9w==", "7d67bb0e-1e6f-438d-b9be-00d3650a77f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "183a2942-4fc0-4dc7-98f7-f1fd077c48d2", "AQAAAAEAACcQAAAAEBsA74fkWwq5m6FbPvR7GSVQsfDOkTQKXBk878VcVESB04bTsilTIOmK18I2A+Ja7A==", "96c2499c-2075-48d2-bda6-5d04a8baa331" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb394e5-1014-4360-8f64-dd3febabed71", "AQAAAAEAACcQAAAAEGaEzlFYxOrK2+yLOLn6Zwatfucvhy0CDkZ9JuxqezdtdyJhaAMxzH3VCAzVvH5W0w==", "4945aa8b-ab00-4d8d-b027-cffcc9ccd659" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5575c51-4371-4c3b-a403-c14b66c2c6df", "AQAAAAEAACcQAAAAELJahoQPr2MjPfOIvfAuq+HtPh2UCfj3AgRH6fvWDnnSDV8QEsPkYpNMEosX9AN4pA==", "86e8a562-7c38-4084-ab68-be274f3ce037" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24c40654-1ad6-42bc-acf6-7740270e4dea", "AQAAAAEAACcQAAAAEBLBCr72BI+LTofizmPBu7ZYvVoqQSZHWoZDJ7nTnNDlgzgNy0N+czPTtqzsb5QO7w==", "28243a2c-7d4e-4e69-a52c-34da4ef1c4c8" });
        }
    }
}
