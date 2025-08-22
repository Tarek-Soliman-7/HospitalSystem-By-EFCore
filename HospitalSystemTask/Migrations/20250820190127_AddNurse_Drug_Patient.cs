using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystemTask.Migrations
{
    /// <inheritdoc />
    public partial class AddNurse_Drug_Patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nurse_Drug_Patient",
                table: "Nurse_Drug_Patient");

            migrationBuilder.RenameTable(
                name: "Nurse_Drug_Patient",
                newName: "nurse_Drug_Patients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nurse_Drug_Patients",
                table: "nurse_Drug_Patients",
                columns: new[] { "Pat_Id", "Date", "Time" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_nurse_Drug_Patients",
                table: "nurse_Drug_Patients");

            migrationBuilder.RenameTable(
                name: "nurse_Drug_Patients",
                newName: "Nurse_Drug_Patient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nurse_Drug_Patient",
                table: "Nurse_Drug_Patient",
                columns: new[] { "Pat_Id", "Date", "Time" });
        }
    }
}
