using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystemTask.Migrations
{
    /// <inheritdoc />
    public partial class Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Word_Id",
                table: "Nurses",
                newName: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Con_Id",
                table: "Patients",
                column: "Con_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Cons_Pat_Id",
                table: "Patient_Cons",
                column: "Pat_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_Ward_Id",
                table: "Nurses",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_nurse_Drug_Patients_Drug_Code",
                table: "nurse_Drug_Patients",
                column: "Drug_Code");

            migrationBuilder.CreateIndex(
                name: "IX_nurse_Drug_Patients_Nur_Num",
                table: "nurse_Drug_Patients",
                column: "Nur_Num");

            migrationBuilder.AddForeignKey(
                name: "FK_Drug_Brands_Drugs_Code",
                table: "Drug_Brands",
                column: "Code",
                principalTable: "Drugs",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_nurse_Drug_Patients_Drugs_Drug_Code",
                table: "nurse_Drug_Patients",
                column: "Drug_Code",
                principalTable: "Drugs",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_nurse_Drug_Patients_Nurses_Nur_Num",
                table: "nurse_Drug_Patients",
                column: "Nur_Num",
                principalTable: "Nurses",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_nurse_Drug_Patients_Patients_Pat_Id",
                table: "nurse_Drug_Patients",
                column: "Pat_Id",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Wards_Ward_Id",
                table: "Nurses",
                column: "Ward_Id",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Cons_Consultants_Con_Id",
                table: "Patient_Cons",
                column: "Con_Id",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Cons_Patients_Pat_Id",
                table: "Patient_Cons",
                column: "Pat_Id",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Consultants_Con_Id",
                table: "Patients",
                column: "Con_Id",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Wards_Ward_Id",
                table: "Patients",
                column: "Ward_Id",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drug_Brands_Drugs_Code",
                table: "Drug_Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_nurse_Drug_Patients_Drugs_Drug_Code",
                table: "nurse_Drug_Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_nurse_Drug_Patients_Nurses_Nur_Num",
                table: "nurse_Drug_Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_nurse_Drug_Patients_Patients_Pat_Id",
                table: "nurse_Drug_Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Wards_Ward_Id",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Cons_Consultants_Con_Id",
                table: "Patient_Cons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Cons_Patients_Pat_Id",
                table: "Patient_Cons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Consultants_Con_Id",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Wards_Ward_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Con_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patient_Cons_Pat_Id",
                table: "Patient_Cons");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_Ward_Id",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_nurse_Drug_Patients_Drug_Code",
                table: "nurse_Drug_Patients");

            migrationBuilder.DropIndex(
                name: "IX_nurse_Drug_Patients_Nur_Num",
                table: "nurse_Drug_Patients");

            migrationBuilder.RenameColumn(
                name: "Ward_Id",
                table: "Nurses",
                newName: "Word_Id");

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
        }
    }
}
