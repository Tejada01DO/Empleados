using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegistroEmpleados.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfesionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    ProfesionId = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PuestoId = table.Column<int>(type: "INTEGER", nullable: false),
                    AFP = table.Column<decimal>(type: "TEXT", nullable: false),
                    SeguroMedico = table.Column<decimal>(type: "TEXT", nullable: false),
                    Impuesto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Descuento = table.Column<decimal>(type: "TEXT", nullable: false),
                    HorasExtras = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Profesiones",
                columns: table => new
                {
                    ProfesionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesiones", x => x.ProfesionId);
                });

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    PuestoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.PuestoId);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "DepartamentoId", "Nombre", "ProfesionId" },
                values: new object[,]
                {
                    { 1, "Ingenieria Civil", 1 },
                    { 2, "Ingenieria Mecanica", 1 },
                    { 3, "Ingenieria Quimica", 1 },
                    { 4, "Ingenieria en Sistemas", 1 },
                    { 5, "Ingenieria Aeroespacial", 1 },
                    { 6, "Ingenieria de Software", 1 },
                    { 7, "Medicina Interna", 2 },
                    { 8, "Cirugia General", 2 },
                    { 9, "Pediatria", 2 },
                    { 10, "Neurologia", 2 },
                    { 11, "Psiquiatria", 2 },
                    { 12, "Medicina de Emergencia", 2 },
                    { 13, "Derecho Civil", 3 },
                    { 14, "Derecho de la Salud", 3 },
                    { 15, "Derecho Internacional", 3 },
                    { 16, "Derecho Laboral", 3 },
                    { 17, "Derecho de Familia", 3 },
                    { 18, "Derecho Penal", 3 }
                });

            migrationBuilder.InsertData(
                table: "Profesiones",
                columns: new[] { "ProfesionId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Ingenierio" },
                    { 2, "Medico" },
                    { 3, "Derecho" }
                });

            migrationBuilder.InsertData(
                table: "Puestos",
                columns: new[] { "PuestoId", "DepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Ingenierio de estructuras" },
                    { 2, 1, "Ingenierio en construccion" },
                    { 3, 1, "Ingenierio geotecnico" },
                    { 4, 1, "Inspector de obras" },
                    { 5, 1, "Ingenierio de carreteras y transporte" },
                    { 6, 2, "Ingeniero de diseño mecánico" },
                    { 7, 2, "Ingeniero de producción" },
                    { 8, 2, "Ingeniero de mantenimiento industrial" },
                    { 9, 2, "Ingeniero de automatización y control" },
                    { 10, 2, "Ingeniero de energía" },
                    { 11, 3, "Ingeniero de procesos químicos" },
                    { 12, 3, "Ingeniero de control de calidad" },
                    { 13, 3, "Ingeniero de producción de químicos" },
                    { 14, 3, "Ingeniero de seguridad industrial" },
                    { 15, 3, "Ingeniero ambiental" },
                    { 16, 4, "Desarrollador de software" },
                    { 17, 4, "Ingeniero de redes" },
                    { 18, 4, "Administrador de bases de datos" },
                    { 19, 4, "Analista de sistemas" },
                    { 20, 4, "Ingeniero de seguridad informática" },
                    { 21, 5, "Ingeniero de propulsión aeroespacial" },
                    { 22, 5, "Diseñador de aeronaves" },
                    { 23, 5, "Ingeniero de sistemas aviónicos" },
                    { 24, 5, "Analista de estrés y fatiga" },
                    { 25, 5, "Ingeniero de materiales aeroespaciales" },
                    { 26, 6, "Desarrollador de aplicaciones móviles" },
                    { 27, 6, "Ingeniero de QA / Tester de Software" },
                    { 28, 6, "Arquitecto de software" },
                    { 29, 6, "Ingeniero de DevOps" },
                    { 30, 6, "Analista de seguridad de software" },
                    { 31, 7, "Médico internista" },
                    { 32, 7, "Cardiólogo" },
                    { 33, 7, "Neumólogo" },
                    { 34, 7, "Gastroenterólogo" },
                    { 35, 7, "Nefrólogo" },
                    { 36, 8, "Cirujano general" },
                    { 37, 8, "Cirujano oncológico" },
                    { 38, 8, "Cirujano de trauma" },
                    { 39, 8, "Cirujano vascular" },
                    { 40, 8, "Cirujano laparoscópico" },
                    { 41, 9, "Pediatra general" },
                    { 42, 9, "Neonatólogo" },
                    { 43, 9, "Pediatra infectólogo" },
                    { 44, 9, "Pediatra cardiólogo" },
                    { 45, 9, "Pediatra Neurologo" },
                    { 46, 10, "Neurólogo clínico" },
                    { 47, 10, "Neurólogo infantil" },
                    { 48, 10, "Neurólogo vascular" },
                    { 49, 10, "Neurólogo epileptólogo" },
                    { 50, 10, "Neurólogo neurofisiólogo" },
                    { 51, 11, "Psiquiatra clínico" },
                    { 52, 11, "Psiquiatra forense" },
                    { 53, 11, "Psiquiatra de niños y adolescentes" },
                    { 54, 11, "Psiquiatra geriátrico" },
                    { 55, 11, "Psiquiatra de adicciones" },
                    { 56, 12, "Médico de emergencia" },
                    { 57, 12, "Médico de trauma" },
                    { 58, 12, "Médico de sala de urgencias" },
                    { 59, 12, "Coordinador de emergencias" },
                    { 60, 12, "Médico de cuidados intensivos" },
                    { 61, 13, "Notario" },
                    { 62, 13, "Abogado de familia" },
                    { 63, 13, "Abogado de propiedad" },
                    { 64, 13, "Litigante civil" },
                    { 65, 13, "Mediador civil" },
                    { 66, 14, "Asesor legal de instituciones de salud" },
                    { 67, 14, "Abogado de responsabilidad médica" },
                    { 68, 14, "Abogado de seguros de salud" },
                    { 69, 14, "Abogado de etica médica" },
                    { 70, 14, "Asesor legal de laboratorios médicos" },
                    { 71, 15, "Abogado de derecho internacional público" },
                    { 72, 15, "Asesor legal de organizaciones internacionales" },
                    { 73, 15, "Abogado de comercio internacional" },
                    { 74, 15, "Abogado de derechos humanos" },
                    { 75, 15, "Diplomático" },
                    { 76, 16, "Abogado laboralista" },
                    { 77, 16, "Asesor legal de recursos humanos" },
                    { 78, 16, "Arbitro laboral" },
                    { 79, 16, "Mediador laboral" },
                    { 80, 16, "Abogado de seguridad laboral" },
                    { 81, 17, "Abogado de divorcio" },
                    { 82, 17, "Abogado de custodia" },
                    { 83, 17, "Mediador familiar" },
                    { 84, 17, "Abogado de adopciones" },
                    { 85, 17, "Abogado de violencia doméstica" },
                    { 86, 18, "Fiscal" },
                    { 87, 18, "Abogado defensor penal" },
                    { 88, 18, "Juez de lo penal" },
                    { 89, 18, "Investigador criminal" },
                    { 90, 18, "Abogado de libertad condicional" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Profesiones");

            migrationBuilder.DropTable(
                name: "Puestos");
        }
    }
}
