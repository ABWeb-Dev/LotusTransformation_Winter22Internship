﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusTransformation.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AdminClientNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminClientNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientAccountInformation",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleInitial = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccountInformation", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "ClientContactInformation",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateOrProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIPorPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContactInformation", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_ClientContactInformation_ClientAccountInformation_ContactID",
                        column: x => x.ContactID,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDocuments",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDocuments", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientDocuments_ClientAccountInformation_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "ClientPostSessionResponses",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionSix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPostSession = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPostSessionResponses", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientPostSessionResponses_ClientAccountInformation_ClientPostSession",
                        column: x => x.ClientPostSession,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "ClientPreSessionResponses",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionSix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionSeven = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPreSession = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPreSessionResponses", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientPreSessionResponses_ClientAccountInformation_ClientPreSession",
                        column: x => x.ClientPreSession,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "ClientWorkInformation",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyStreetAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyStreetAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompnayCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientWorkInformation", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientWorkInformation_ClientAccountInformation_EmploymentID",
                        column: x => x.EmploymentID,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocuments_DocumentID",
                table: "ClientDocuments",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPostSessionResponses_ClientPostSession",
                table: "ClientPostSessionResponses",
                column: "ClientPostSession");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreSessionResponses_ClientPreSession",
                table: "ClientPreSessionResponses",
                column: "ClientPreSession");

            migrationBuilder.CreateIndex(
                name: "IX_ClientWorkInformation_EmploymentID",
                table: "ClientWorkInformation",
                column: "EmploymentID",
                unique: true,
                filter: "[EmploymentID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AdminClientNotes");

            migrationBuilder.DropTable(
                name: "ClientContactInformation");

            migrationBuilder.DropTable(
                name: "ClientDocuments");

            migrationBuilder.DropTable(
                name: "ClientPostSessionResponses");

            migrationBuilder.DropTable(
                name: "ClientPreSessionResponses");

            migrationBuilder.DropTable(
                name: "ClientWorkInformation");

            migrationBuilder.DropTable(
                name: "ClientAccountInformation");
        }
    }
}
