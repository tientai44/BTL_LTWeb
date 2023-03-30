using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class Kum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "3bac7616-d859-429e-9424-3ca5f6142ebc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "d9218d25-303a-4dc8-a295-55a97b1f3145");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "ac99c03a-51e5-4bcd-b555-c0d664442407");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d83361aa-226f-4190-8795-22d4fb572d1e", "AQAAAAEAACcQAAAAEI75IKdpQWVDPW1EC124BhPqQM5NS8WlCRMKJNEk2/S0/qT1HppZgFev91jSy33zYQ==", "fa3c346a-e444-488a-8b75-1b590ac78556" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "151163c3-4f92-4415-805a-05391f677768", "AQAAAAEAACcQAAAAEPvLuDmCfrdW7oWckQHMJMwk9s8k+9oK4tpVZhQtWsLnhCCj8K/blNN1MvEQI4UZZA==", "87cbc5b0-4d72-4dc4-9c6d-60914d3f5612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4facc453-372c-4ca6-bb24-8be2da0a6515", "AQAAAAEAACcQAAAAECrCb36AcTSOyPHIy40mTNF2NQ+WTIdK4IuO2I9WBoJR3oE+sJ+4wsA3ZJmkUU0+5w==", "05c1c139-c2e1-4970-b98e-62731d22cb8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93788144-9528-463e-8f02-b77d9de19de8", "AQAAAAEAACcQAAAAEEMg9QJ0GklPTkKjCzHLHEHkVTFJIqifZJ33qwLY8qNU+BZyB0s68A0MmWY2Y12ifA==", "e3e6823f-636d-418b-9e75-cb7a7baaff9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a17ce5e8-05d4-4a83-a844-5a2d261743a2", "AQAAAAEAACcQAAAAENybcAlasJtczMLHh+Wctfups04u44+i0MGF/0OyBmxVbg1DLjhdWLYS82ixIlCp3Q==", "3e6aec71-4039-4e0d-982d-33ef4e89ffcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d21fcb7-e8df-4df3-a04f-c2a312f6846b", "AQAAAAEAACcQAAAAELhS7UGAocjgvdc0JjwrSZtG0/oz18EIaZrsh2Wh4Ue2TJZiSS5MHXivkPPZDhzPsw==", "aa0bff58-9007-47a5-b004-de0fed6ebf30" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
