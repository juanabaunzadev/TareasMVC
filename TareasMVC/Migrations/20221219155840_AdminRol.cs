using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                if not exists(Select id from AspNetRoles where Id = '8b88122b-71e4-4f57-9b75-a7d2d9700368')
                begin
                insert AspNetRoles values ('8b88122b-71e4-4f57-9b75-a7d2d9700368', 'admin', 'Admin', null)
                end
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from [dbo].[AspNetRoles] where Id = '8b88122b-71e4-4f57-9b75-a7d2d9700368'
            ");
        }
    }
}
