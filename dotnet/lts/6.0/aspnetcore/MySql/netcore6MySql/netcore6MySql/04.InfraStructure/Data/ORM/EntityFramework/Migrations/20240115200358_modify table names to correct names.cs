using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace netcore6MySql._04.InfraStructure.Data.ORM.EntityFramework.Migrations
{
    public partial class modifytablenamestocorrectnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_DocumentType_DocumentTypeId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_GenderIdentity_GenderIdentityId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_PersonType_PersonTypeId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonType",
                table: "PersonType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenderIdentity",
                table: "GenderIdentity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentType",
                table: "DocumentType");

            migrationBuilder.RenameTable(
                name: "PersonType",
                newName: "Person_Type");

            migrationBuilder.RenameTable(
                name: "GenderIdentity",
                newName: "Gender_identity");

            migrationBuilder.RenameTable(
                name: "DocumentType",
                newName: "Document_Type");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Persons",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clients",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Person_Type",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Gender_identity",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Document_Type",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person_Type",
                table: "Person_Type",
                column: "PersonTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender_identity",
                table: "Gender_identity",
                column: "GenderIdentityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document_Type",
                table: "Document_Type",
                column: "DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Document_Type_DocumentTypeId",
                table: "Persons",
                column: "DocumentTypeId",
                principalTable: "Document_Type",
                principalColumn: "DocumentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Gender_identity_GenderIdentityId",
                table: "Persons",
                column: "GenderIdentityId",
                principalTable: "Gender_identity",
                principalColumn: "GenderIdentityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Person_Type_PersonTypeId",
                table: "Persons",
                column: "PersonTypeId",
                principalTable: "Person_Type",
                principalColumn: "PersonTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Document_Type_DocumentTypeId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Gender_identity_GenderIdentityId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Person_Type_PersonTypeId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person_Type",
                table: "Person_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender_identity",
                table: "Gender_identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document_Type",
                table: "Document_Type");

            migrationBuilder.RenameTable(
                name: "Person_Type",
                newName: "PersonType");

            migrationBuilder.RenameTable(
                name: "Gender_identity",
                newName: "GenderIdentity");

            migrationBuilder.RenameTable(
                name: "Document_Type",
                newName: "DocumentType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Persons",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clients",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PersonType",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GenderIdentity",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DocumentType",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonType",
                table: "PersonType",
                column: "PersonTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenderIdentity",
                table: "GenderIdentity",
                column: "GenderIdentityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentType",
                table: "DocumentType",
                column: "DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_DocumentType_DocumentTypeId",
                table: "Persons",
                column: "DocumentTypeId",
                principalTable: "DocumentType",
                principalColumn: "DocumentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_GenderIdentity_GenderIdentityId",
                table: "Persons",
                column: "GenderIdentityId",
                principalTable: "GenderIdentity",
                principalColumn: "GenderIdentityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PersonType_PersonTypeId",
                table: "Persons",
                column: "PersonTypeId",
                principalTable: "PersonType",
                principalColumn: "PersonTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
