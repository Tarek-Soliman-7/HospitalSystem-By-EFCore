using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystemTask.Migrations
{
    /// <inheritdoc />
    public partial class ooWardNurse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HostsId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wards_Nurse_Num",
                table: "Wards",
                column: "Nurse_Num",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AssignedId",
                table: "Patients",
                column: "AssignedId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_HostsId",
                table: "Patients",
                column: "HostsId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientId",
                table: "Patients",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Consultants_AssignedId",
                table: "Patients",
                column: "AssignedId",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Patients_PatientId",
                table: "Patients",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Wards_HostsId",
                table: "Patients",
                column: "HostsId",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Nurses_Nurse_Num",
                table: "Wards",
                column: "Nurse_Num",
                principalTable: "Nurses",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Consultants_AssignedId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Patients_PatientId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Wards_HostsId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Nurses_Nurse_Num",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_Nurse_Num",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AssignedId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_HostsId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AssignedId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "HostsId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Patients");
        }
    }
}
