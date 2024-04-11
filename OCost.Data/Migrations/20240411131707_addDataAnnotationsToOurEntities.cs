using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCoast.Data.Migrations
{
    /// <inheritdoc />
    public partial class addDataAnnotationsToOurEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_AspNetUsers_ApplicationUserId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAdministrators_AspNetUsers_ApplicationUserId",
                table: "SystemAdministrators");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Banks");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SystemAdministrators",
                newName: "SystemAdministratorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Responses",
                newName: "ResponseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RequestSuppliers",
                newName: "RequestSupplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Requests",
                newName: "RequestId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RequestLines",
                newName: "RequestLineId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductSuppliers",
                newName: "ProductSupplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "DescriptionEn");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductCategories",
                newName: "ProductCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Payments",
                newName: "PaymentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderLines",
                newName: "OrderLineId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Invoices",
                newName: "InvoiceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Banks",
                newName: "BankId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "SystemAdministrators",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Suppliers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPrice",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Banks",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Banks",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "Created_At", "PasswordHash", "SecurityStamp", "Updated_at" },
                values: new object[] { "1a02d858-4ee8-4b9e-ae03-8cc9b4587dd6", new DateTime(2024, 4, 11, 16, 17, 6, 208, DateTimeKind.Local).AddTicks(7403), "AQAAAAIAAYagAAAAEB0j+a1s4oA5fokYvoW6ZuK/bAKZOOBFsdFzBnHisfuEf2u3qyUS9aXpU1gmwk2q4g==", "35d654c8-f3e8-43e2-8cb6-ce9d5e234fc4", new DateTime(2024, 4, 11, 16, 17, 6, 208, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_AspNetUsers_ApplicationUserId",
                table: "Suppliers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAdministrators_AspNetUsers_ApplicationUserId",
                table: "SystemAdministrators",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_AspNetUsers_ApplicationUserId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAdministrators_AspNetUsers_ApplicationUserId",
                table: "SystemAdministrators");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Banks");

            migrationBuilder.RenameColumn(
                name: "SystemAdministratorId",
                table: "SystemAdministrators",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Suppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ResponseId",
                table: "Responses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RequestSupplierId",
                table: "RequestSuppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                table: "Requests",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RequestLineId",
                table: "RequestLines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductSupplierId",
                table: "ProductSuppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DescriptionEn",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "ProductCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Payments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderLineId",
                table: "OrderLines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InvoiceId",
                table: "Invoices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BankId",
                table: "Banks",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "SystemAdministrators",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Suppliers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UnitPrice",
                table: "OrderLines",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1446937-109c-4e1a-97ce-0560442484f5",
                columns: new[] { "ConcurrencyStamp", "Created_At", "PasswordHash", "SecurityStamp", "Updated_at" },
                values: new object[] { "48173659-149c-4b77-b18e-5c07f161c6c3", new DateTime(2024, 4, 8, 14, 11, 58, 262, DateTimeKind.Local).AddTicks(1252), "AQAAAAIAAYagAAAAEFiuNy8qq5ggwvciEzjjmi1RxExZOtQBe6k/kTauNSeF34Q2gbSeUn648lCKHOaJPw==", "ff4cd832-d26f-4584-a251-026105a7baa6", new DateTime(2024, 4, 8, 14, 11, 58, 262, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_AspNetUsers_ApplicationUserId",
                table: "Suppliers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAdministrators_AspNetUsers_ApplicationUserId",
                table: "SystemAdministrators",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
