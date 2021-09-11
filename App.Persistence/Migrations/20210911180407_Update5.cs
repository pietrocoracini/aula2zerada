using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Persistence.Migrations
{
    public partial class Update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CidadeId",
                table: "Pessoa",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CidadeId",
                table: "Pessoa",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Cidade_CidadeId",
                table: "Pessoa",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Cidade_CidadeId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_CidadeId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Pessoa");
        }
    }
}
