using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusTransformation.Migrations
{
    public partial class Initial : Migration
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: true),
                    EmploymentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccountInformation", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "ClientContactInformation",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateOrProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIPorPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContactInformation", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_ClientContactInformation_ClientAccountInformation_ClientID",
                        column: x => x.ClientID,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "ClientDocuments",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientAccountInformationClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDocuments", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientDocuments_ClientAccountInformation_ClientAccountInformationClientID",
                        column: x => x.ClientAccountInformationClientID,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "ClientPostSessionResponses",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionSix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientAccountInformationClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPostSessionResponses", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientPostSessionResponses_ClientAccountInformation_ClientAccountInformationClientID",
                        column: x => x.ClientAccountInformationClientID,
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
                    ClientAccountInformationClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPreSessionResponses", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientPreSessionResponses_ClientAccountInformation_ClientAccountInformationClientID",
                        column: x => x.ClientAccountInformationClientID,
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
                    CompanyStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientWorkInformation", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ClientWorkInformation_ClientAccountInformation_ClientID",
                        column: x => x.ClientID,
                        principalTable: "ClientAccountInformation",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientAccountInformation_ContactID",
                table: "ClientAccountInformation",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientAccountInformation_EmploymentID",
                table: "ClientAccountInformation",
                column: "EmploymentID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContactInformation_ClientID",
                table: "ClientContactInformation",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocuments_ClientAccountInformationClientID",
                table: "ClientDocuments",
                column: "ClientAccountInformationClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPostSessionResponses_ClientAccountInformationClientID",
                table: "ClientPostSessionResponses",
                column: "ClientAccountInformationClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreSessionResponses_ClientAccountInformationClientID",
                table: "ClientPreSessionResponses",
                column: "ClientAccountInformationClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientWorkInformation_ClientID",
                table: "ClientWorkInformation",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAccountInformation_ClientContactInformation_ContactID",
                table: "ClientAccountInformation",
                column: "ContactID",
                principalTable: "ClientContactInformation",
                principalColumn: "ContactID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAccountInformation_ClientWorkInformation_EmploymentID",
                table: "ClientAccountInformation",
                column: "EmploymentID",
                principalTable: "ClientWorkInformation",
                principalColumn: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAccountInformation_ClientContactInformation_ContactID",
                table: "ClientAccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientAccountInformation_ClientWorkInformation_EmploymentID",
                table: "ClientAccountInformation");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AdminClientNotes");

            migrationBuilder.DropTable(
                name: "ClientDocuments");

            migrationBuilder.DropTable(
                name: "ClientPostSessionResponses");

            migrationBuilder.DropTable(
                name: "ClientPreSessionResponses");

            migrationBuilder.DropTable(
                name: "ClientContactInformation");

            migrationBuilder.DropTable(
                name: "ClientWorkInformation");

            migrationBuilder.DropTable(
                name: "ClientAccountInformation");
        }
    }
}
