using Microsoft.EntityFrameworkCore;
using SQLitePCL;

public class Context : DbContext
{
    public DbSet<Empleados> Empleados { get; set; }
    public DbSet<Profesiones> Profesiones { get; set; }
    public DbSet<Departamentos> Departamentos { get; set; }
    public DbSet<Puestos> Puestos { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Profesiones>().HasData(
            new Profesiones
            {
                ProfesionId = 1,
                Nombre = "Ingenierio"
            
            },

            new Profesiones
            {
                ProfesionId = 2,
                Nombre = "Medico"
            },

            new Profesiones
                {
                ProfesionId = 3,
                Nombre = "Derecho"
                }
            );
                    modelBuilder.Entity<Departamentos>().HasData(
                        new Departamentos
                        {
                            DepartamentoId = 7,
                            ProfesionId = 2,
                            Nombre = "Medicina Interna"
                            
                        },

                        new Departamentos
                        {
                            DepartamentoId = 8,
                            ProfesionId = 2,
                            Nombre = "Cirugia General"
                            
                        },

                        new Departamentos
                        {
                            DepartamentoId = 9,
                            ProfesionId = 2,
                            Nombre = "Pediatria"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 10,
                            ProfesionId = 2,
                            Nombre = "Neurologia"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 11,
                            ProfesionId = 2,
                            Nombre = "Psiquiatria"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 12,
                            ProfesionId = 2,
                            Nombre = "Medicina de Emergencia"
                        },
                        new Departamentos
                        {
                            DepartamentoId = 13,
                            ProfesionId = 3,
                            Nombre = "Derecho Civil"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 14,
                            ProfesionId = 3,
                            Nombre = "Derecho de la Salud"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 15,
                            ProfesionId = 3,
                            Nombre = "Derecho Internacional"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 16,
                            ProfesionId = 3,
                            Nombre = "Derecho Laboral",

                        },

                        new Departamentos
                        {
                            DepartamentoId = 17,
                            ProfesionId = 3,
                            Nombre = "Derecho de Familia"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 18,
                            ProfesionId = 3,
                            Nombre = "Derecho Penal",

                        },
                        new Departamentos
                        {
                            DepartamentoId = 1,
                            ProfesionId = 1,
                            Nombre = "Ingenieria Civil"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 2,
                            ProfesionId = 1,
                            Nombre = "Ingenieria Mecanica"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 3,
                            ProfesionId = 1,
                            Nombre = "Ingenieria Quimica"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 4,
                            ProfesionId = 1,
                            Nombre = "Ingenieria en Sistemas"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 5,
                            ProfesionId = 1,
                            Nombre = "Ingenieria Aeroespacial"
                        },

                        new Departamentos
                        {
                            DepartamentoId = 6,
                            ProfesionId = 1,
                            Nombre = "Ingenieria de Software"
                        }
        );

        modelBuilder.Entity<Puestos>().HasData(
                                new Puestos
                                {
                                    PuestoId = 1,
                                    DepartamentoId = 1,
                                    Nombre = "Ingenierio de estructuras"
                                },

                                new Puestos
                                {
                                    PuestoId = 2,
                                    DepartamentoId = 1,
                                    Nombre = "Ingenierio en construccion"
                                },

                                new Puestos
                                {
                                    PuestoId = 3,
                                    DepartamentoId = 1,
                                    Nombre = "Ingenierio geotecnico"
                                },

                                new Puestos
                                {
                                    PuestoId = 4,
                                    DepartamentoId = 1,
                                    Nombre = "Inspector de obras"
                                },

                                new Puestos
                                {
                                    PuestoId = 5,
                                    DepartamentoId = 1,
                                    Nombre = "Ingenierio de carreteras y transporte"
                                },

                                new Puestos
                                {
                                    PuestoId = 6,
                                    DepartamentoId = 2,
                                    Nombre = "Ingeniero de diseño mecánico"
                                },

                                new Puestos
                                {
                                    PuestoId = 7,
                                    DepartamentoId = 2,
                                    Nombre = "Ingeniero de producción"
                                },

                                new Puestos
                                {
                                    PuestoId = 8,
                                    DepartamentoId = 2,
                                    Nombre = "Ingeniero de mantenimiento industrial"
                                },

                                new Puestos
                                {
                                    PuestoId = 9,
                                    DepartamentoId = 2,
                                    Nombre = "Ingeniero de automatización y control"
                                },

                                new Puestos
                                {
                                    PuestoId = 10,
                                    DepartamentoId = 2,
                                    Nombre = "Ingeniero de energía"
                                },

                                new Puestos
                                {
                                    PuestoId = 11,
                                    DepartamentoId = 3,
                                    Nombre = "Ingeniero de procesos químicos"
                                },

                                new Puestos
                                {
                                    PuestoId = 12,
                                    DepartamentoId = 3,
                                    Nombre = "Ingeniero de control de calidad"
                                },

                                new Puestos
                                {
                                    PuestoId = 13,
                                    DepartamentoId = 3,
                                    Nombre = "Ingeniero de producción de químicos"
                                },

                                new Puestos
                                {
                                    PuestoId = 14,
                                    DepartamentoId = 3,
                                    Nombre = "Ingeniero de seguridad industrial"
                                },

                                new Puestos
                                {
                                    PuestoId = 15,
                                    DepartamentoId = 3,
                                    Nombre = "Ingeniero ambiental"
                                },

                                new Puestos
                                {
                                    PuestoId = 16,
                                    DepartamentoId = 4,
                                    Nombre = "Desarrollador de software"
                                },

                                new Puestos
                                {
                                    PuestoId = 17,
                                    DepartamentoId = 4,
                                    Nombre = "Ingeniero de redes"
                                },

                                new Puestos
                                {
                                    PuestoId = 18,
                                    DepartamentoId = 4,
                                    Nombre = "Administrador de bases de datos"
                                },

                                new Puestos
                                {
                                    PuestoId = 19,
                                    DepartamentoId = 4,
                                    Nombre = "Analista de sistemas"
                                },

                                new Puestos
                                {
                                    PuestoId = 20,
                                    DepartamentoId = 4,
                                    Nombre = "Ingeniero de seguridad informática"
                                },

                                new Puestos
                                {
                                    PuestoId = 21,
                                    DepartamentoId = 5,
                                    Nombre = "Ingeniero de propulsión aeroespacial"
                                },

                                new Puestos
                                {
                                    PuestoId = 22,
                                    DepartamentoId = 5,
                                    Nombre = "Diseñador de aeronaves"
                                },

                                new Puestos
                                {
                                    PuestoId = 23,
                                    DepartamentoId = 5,
                                    Nombre = "Ingeniero de sistemas aviónicos"
                                },

                                new Puestos
                                {
                                    PuestoId = 24,
                                    DepartamentoId = 5,
                                    Nombre = "Analista de estrés y fatiga"
                                },

                                new Puestos
                                {
                                    PuestoId = 25,
                                    DepartamentoId = 5,
                                    Nombre = "Ingeniero de materiales aeroespaciales"
                                },
                                
                                new Puestos
                                {
                                    PuestoId = 26,
                                    DepartamentoId = 6,
                                    Nombre = "Desarrollador de aplicaciones móviles"
                                },

                                new Puestos
                                {
                                    PuestoId = 27,
                                    DepartamentoId = 6,
                                    Nombre = "Ingeniero de QA / Tester de Software"
                                },

                                new Puestos
                                {
                                    PuestoId = 28,
                                    DepartamentoId = 6,
                                    Nombre = "Arquitecto de software"
                                },

                                new Puestos
                                {
                                    PuestoId = 29,
                                    DepartamentoId = 6,
                                    Nombre = "Ingeniero de DevOps"
                                },

                                new Puestos
                                {
                                    PuestoId = 30,
                                    DepartamentoId = 6,
                                    Nombre = "Analista de seguridad de software"
                                },

                                new Puestos
                                {
                                    PuestoId = 31,
                                    DepartamentoId = 7,
                                    Nombre = "Médico internista"
                                },

                                new Puestos
                                {
                                    PuestoId = 32,
                                    DepartamentoId = 7,
                                    Nombre = "Cardiólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 33,
                                    DepartamentoId = 7,
                                    Nombre = "Neumólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 34,
                                    DepartamentoId = 7,
                                    Nombre = "Gastroenterólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 35,
                                    DepartamentoId = 7,
                                    Nombre = "Nefrólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 36,
                                    DepartamentoId = 8,
                                    Nombre = "Cirujano general"
                                },

                                new Puestos
                                {
                                    PuestoId = 37,
                                    DepartamentoId = 8,
                                    Nombre = "Cirujano oncológico"
                                },

                                new Puestos
                                {
                                    PuestoId = 38,
                                    DepartamentoId = 8,
                                    Nombre = "Cirujano de trauma"
                                },

                                new Puestos
                                {
                                    PuestoId = 39,
                                    DepartamentoId = 8,
                                    Nombre = "Cirujano vascular"
                                },

                                new Puestos
                                {
                                    PuestoId = 40,
                                    DepartamentoId = 8,
                                    Nombre = "Cirujano laparoscópico"
                                },

                                new Puestos
                                {
                                    PuestoId = 41,
                                    DepartamentoId = 9,
                                    Nombre = "Pediatra general"
                                },

                                new Puestos
                                {
                                    PuestoId = 42,
                                    DepartamentoId = 9,
                                    Nombre = "Neonatólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 43,
                                    DepartamentoId = 9,
                                    Nombre = "Pediatra infectólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 44,
                                    DepartamentoId = 9,
                                    Nombre = "Pediatra cardiólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 45,
                                    DepartamentoId = 9,
                                    Nombre = "Pediatra Neurologo"
                                },

                                new Puestos
                                {
                                    PuestoId = 46,
                                    DepartamentoId = 10,
                                    Nombre = "Neurólogo clínico"
                                },

                                new Puestos
                                {
                                    PuestoId = 47,
                                    DepartamentoId = 10,
                                    Nombre = "Neurólogo infantil"
                                },

                                new Puestos
                                {
                                    PuestoId = 48,
                                    DepartamentoId = 10,
                                    Nombre = "Neurólogo vascular"
                                },

                                new Puestos
                                {
                                    PuestoId = 49,
                                    DepartamentoId = 10,
                                    Nombre = "Neurólogo epileptólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 50,
                                    DepartamentoId = 10,
                                    Nombre = "Neurólogo neurofisiólogo"
                                },

                                new Puestos
                                {
                                    PuestoId = 51,
                                    DepartamentoId = 11,
                                    Nombre = "Psiquiatra clínico"
                                },

                                new Puestos
                                {
                                    PuestoId = 52,
                                    DepartamentoId = 11,
                                    Nombre = "Psiquiatra forense"
                                },

                                new Puestos
                                {
                                    PuestoId = 53,
                                    DepartamentoId = 11,
                                    Nombre = "Psiquiatra de niños y adolescentes"
                                },

                                new Puestos
                                {
                                    PuestoId = 54,
                                    DepartamentoId = 11,
                                    Nombre = "Psiquiatra geriátrico"
                                },

                                new Puestos
                                {
                                    PuestoId = 55,
                                    DepartamentoId = 11,
                                    Nombre = "Psiquiatra de adicciones"
                                },

                                new Puestos
                                {
                                    PuestoId = 56,
                                    DepartamentoId = 12,
                                    Nombre = "Médico de emergencia"
                                },

                                new Puestos
                                {
                                    PuestoId = 57,
                                    DepartamentoId = 12,
                                    Nombre = "Médico de trauma"
                                },

                                new Puestos
                                {
                                    PuestoId = 58,
                                    DepartamentoId = 12,
                                    Nombre = "Médico de sala de urgencias"
                                },

                                new Puestos
                                {
                                    PuestoId = 59,
                                    DepartamentoId = 12,
                                    Nombre = "Coordinador de emergencias"
                                },

                                new Puestos
                                {
                                    PuestoId = 60,
                                    DepartamentoId = 12,
                                    Nombre = "Médico de cuidados intensivos"
                                },

                                new Puestos
                                {
                                    PuestoId = 61,
                                    DepartamentoId = 13,
                                    Nombre = "Notario"
                                },

                                new Puestos
                                {
                                    PuestoId = 62,
                                    DepartamentoId = 13,
                                    Nombre = "Abogado de familia"
                                },

                                new Puestos
                                {
                                    PuestoId = 63,
                                    DepartamentoId = 13,
                                    Nombre = "Abogado de propiedad"
                                },

                                new Puestos
                                {
                                    PuestoId = 64,
                                    DepartamentoId = 13,
                                    Nombre = "Litigante civil"
                                },

                                new Puestos
                                {
                                    PuestoId = 65,
                                    DepartamentoId = 13,
                                    Nombre = "Mediador civil"
                                },

                                new Puestos
                                {
                                    PuestoId = 66,
                                    DepartamentoId = 14,
                                    Nombre = "Asesor legal de instituciones de salud"
                                },

                                new Puestos
                                {
                                    PuestoId = 67,
                                    DepartamentoId = 14,
                                    Nombre = "Abogado de responsabilidad médica"
                                },

                                new Puestos
                                {
                                    PuestoId = 68,
                                    DepartamentoId = 14,
                                    Nombre = "Abogado de seguros de salud"
                                },

                                new Puestos
                                {
                                    PuestoId = 69,
                                    DepartamentoId = 14,
                                    Nombre = "Abogado de etica médica"
                                },

                                new Puestos
                                {
                                    PuestoId = 70,
                                    DepartamentoId = 14,
                                    Nombre = "Asesor legal de laboratorios médicos"
                                },

                                new Puestos
                                {
                                    PuestoId = 71,
                                    DepartamentoId = 15,
                                    Nombre = "Abogado de derecho internacional público"
                                },

                                new Puestos
                                {
                                    PuestoId = 72,
                                    DepartamentoId = 15,
                                    Nombre = "Asesor legal de organizaciones internacionales"
                                },

                                new Puestos
                                {
                                    PuestoId = 73,
                                    DepartamentoId = 15,
                                    Nombre = "Abogado de comercio internacional"
                                },

                                new Puestos
                                {
                                    PuestoId = 74,
                                    DepartamentoId = 15,
                                    Nombre = "Abogado de derechos humanos"
                                },

                                new Puestos
                                {
                                    PuestoId = 75,
                                    DepartamentoId = 15,
                                    Nombre = "Diplomático"
                                },

                                 new Puestos
                                {
                                    PuestoId = 76,
                                    DepartamentoId = 16,
                                    Nombre = "Abogado laboralista"
                                },

                                new Puestos
                                {
                                    PuestoId = 77,
                                    DepartamentoId = 16,
                                    Nombre = "Asesor legal de recursos humanos"
                                },

                                new Puestos
                                {
                                    PuestoId = 78,
                                    DepartamentoId = 16,
                                    Nombre = "Arbitro laboral"
                                },

                                new Puestos
                                {
                                    PuestoId = 79,
                                    DepartamentoId = 16,
                                    Nombre = "Mediador laboral"
                                },

                                new Puestos
                                {
                                    PuestoId = 80,
                                    DepartamentoId = 16,
                                    Nombre = "Abogado de seguridad laboral"
                                },

                                new Puestos
                                {
                                    PuestoId = 81,
                                    DepartamentoId = 17,
                                    Nombre = "Abogado de divorcio"
                                },

                                new Puestos
                                {
                                    PuestoId = 82,
                                    DepartamentoId = 17,
                                    Nombre = "Abogado de custodia"
                                },

                                new Puestos
                                {
                                    PuestoId = 83,
                                    DepartamentoId = 17,
                                    Nombre = "Mediador familiar"
                                },

                                new Puestos
                                {
                                    PuestoId = 84,
                                    DepartamentoId = 17,
                                    Nombre = "Abogado de adopciones"
                                },

                                new Puestos
                                {
                                    PuestoId = 85,
                                    DepartamentoId = 17,
                                    Nombre = "Abogado de violencia doméstica"
                                },

                                 new Puestos
                                {
                                    PuestoId = 86,
                                    DepartamentoId = 18,
                                    Nombre = "Fiscal"
                                },

                                new Puestos
                                {
                                    PuestoId = 87,
                                    DepartamentoId = 18,
                                    Nombre = "Abogado defensor penal"
                                },

                                new Puestos
                                {
                                    PuestoId = 88,
                                    DepartamentoId = 18,
                                    Nombre = "Juez de lo penal"
                                },

                                new Puestos
                                {
                                    PuestoId = 89,
                                    DepartamentoId = 18,
                                    Nombre = "Investigador criminal"
                                },

                                new Puestos
                                {
                                    PuestoId = 90,
                                    DepartamentoId = 18,
                                    Nombre = "Abogado de libertad condicional"
                                }
            );
        }
    }