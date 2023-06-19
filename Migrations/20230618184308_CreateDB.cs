using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_19c.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerKilo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialsDelivery",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialsDelivery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seniority = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true),
                    ShiftSupervisor_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkersGroup",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkersGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialMaterialsDelivery",
                columns: table => new
                {
                    MaterialsDeliveriesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaterialsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMaterialsDelivery", x => new { x.MaterialsDeliveriesId, x.MaterialsId });
                    table.ForeignKey(
                        name: "FK_MaterialMaterialsDelivery_Material_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialMaterialsDelivery_MaterialsDelivery_MaterialsDeliveriesId",
                        column: x => x.MaterialsDeliveriesId,
                        principalTable: "MaterialsDelivery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderPrice = table.Column<float>(type: "real", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Person_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskReport",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftSupervisorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskReport_Person_ShiftSupervisorId",
                        column: x => x.ShiftSupervisorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialTask",
                columns: table => new
                {
                    MaterialsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TasksId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTask", x => new { x.MaterialsId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_MaterialTask_Material_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialTask_Task_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SawmillWorkerWorkersGroup",
                columns: table => new
                {
                    SawmillWorkersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkersGroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SawmillWorkerWorkersGroup", x => new { x.SawmillWorkersId, x.WorkersGroupsId });
                    table.ForeignKey(
                        name: "FK_SawmillWorkerWorkersGroup_Person_SawmillWorkersId",
                        column: x => x.SawmillWorkersId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SawmillWorkerWorkersGroup_WorkersGroup_WorkersGroupsId",
                        column: x => x.WorkersGroupsId,
                        principalTable: "WorkersGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskWorkersGroup",
                columns: table => new
                {
                    TasksId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkersGroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskWorkersGroup", x => new { x.TasksId, x.WorkersGroupsId });
                    table.ForeignKey(
                        name: "FK_TaskWorkersGroup_Task_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskWorkersGroup_WorkersGroup_WorkersGroupsId",
                        column: x => x.WorkersGroupsId,
                        principalTable: "WorkersGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkOnOrder",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOnOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOnOrder_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTaskReport",
                columns: table => new
                {
                    ReportsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TasksId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTaskReport", x => new { x.ReportsId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_TaskTaskReport_TaskReport_ReportsId",
                        column: x => x.ReportsId,
                        principalTable: "TaskReport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTaskReport_Task_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskWorkOnOrder",
                columns: table => new
                {
                    TasksId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkOnOrdersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskWorkOnOrder", x => new { x.TasksId, x.WorkOnOrdersId });
                    table.ForeignKey(
                        name: "FK_TaskWorkOnOrder_Task_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskWorkOnOrder_WorkOnOrder_WorkOnOrdersId",
                        column: x => x.WorkOnOrdersId,
                        principalTable: "WorkOnOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMaterialsDelivery_MaterialsId",
                table: "MaterialMaterialsDelivery",
                column: "MaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTask_TasksId",
                table: "MaterialTask",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SawmillWorkerWorkersGroup_WorkersGroupsId",
                table: "SawmillWorkerWorkersGroup",
                column: "WorkersGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskReport_ShiftSupervisorId",
                table: "TaskReport",
                column: "ShiftSupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTaskReport_TasksId",
                table: "TaskTaskReport",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskWorkersGroup_WorkersGroupsId",
                table: "TaskWorkersGroup",
                column: "WorkersGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskWorkOnOrder_WorkOnOrdersId",
                table: "TaskWorkOnOrder",
                column: "WorkOnOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOnOrder_OrderId",
                table: "WorkOnOrder",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialMaterialsDelivery");

            migrationBuilder.DropTable(
                name: "MaterialTask");

            migrationBuilder.DropTable(
                name: "SawmillWorkerWorkersGroup");

            migrationBuilder.DropTable(
                name: "TaskTaskReport");

            migrationBuilder.DropTable(
                name: "TaskWorkersGroup");

            migrationBuilder.DropTable(
                name: "TaskWorkOnOrder");

            migrationBuilder.DropTable(
                name: "MaterialsDelivery");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "TaskReport");

            migrationBuilder.DropTable(
                name: "WorkersGroup");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "WorkOnOrder");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
