using CrudFixture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrudFixture.Data;
using System;
using System.Linq;


namespace CrudFixture.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)

        {
            using (var context = new FixtureContext(

                serviceProvider.GetRequiredService<

                    DbContextOptions<FixtureContext>>()))

            {

                if (context.Fixture.Any())

                {

                    return;   // DB has been seeded

                }

                context.Fixture.AddRange(
                    new Fixture
                    {

                    },
                    new Fixture
                    {
                        Fecha = 1,
                        Local = "Atético de Tucumán",
                        Visitante = "Racing Club",
                        Estadio = "Monumental José Fierro",
                        Dia = DateTime.Parse("8/13/2018 9:00:00 PM"),
                        Resultado = "2-2",
                    },
                    new Fixture
                    {
                        Fecha = 2,
                        Local = "Racing Club",
                        Visitante = "Vélez Sarsfield",
                        Estadio = "El Cilindro",
                        Dia= DateTime.Parse("8/19/2018 8:00:00 PM"),
                        Resultado = "2-0",
                    },
                    new Fixture
                    {
                        Fecha = 3,
                        Local = "Patronato",
                        Visitante = "Racing Club",
                        Estadio = "Presbítero Bartolomé Grella",
                        Dia = DateTime.Parse("8/24/2018 7:00:00 PM"),
                        Resultado = "0-3",
                    }
                    ,
                    new Fixture
                    {
                        Fecha = 4,
                        Local = "Racing Club",
                        Visitante = "Rosario Central",
                        Estadio = "El Cilindro	",
                        Dia = DateTime.Parse ("10/2/2018 11:00:00 AM"),
                        Resultado = "2-0",
                    },
                    new Fixture
                    {
                        Fecha = 5,
                        Local = "Lanús",
                        Visitante = "Racing Club",
                        Estadio = "Ciudad de Lanús",
                        Dia = DateTime.Parse("10/16/2018 5:45:00 PM"),
                        Resultado = "0-1",
                    },

                    new Fixture
                    {
                        Fecha = 6,
                        Local = "Racing Club",
                        Visitante = "Unión",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("10/24/2018 8:00:00 PM"),
                        Resultado = "1-0",
                    },
                    new Fixture
                    {
                        Fecha = 7,
                        Local = "Argentinos Juniors",
                        Visitante = "Racing Club",
                        Estadio = "Diego Armando Maradona",
                        Dia = DateTime.Parse("10/29/2018 8:00:00 PM"),
                        Resultado = "0-2",
                    },

                    new Fixture
                    {
                        Fecha = 8,
                        Local = "Racing Club",
                        Visitante = "Boca Juniors",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("11/7/2018 7:00:00 PM"),
                        Resultado = "2-2",
                    },
                    new Fixture
                    {
                        Fecha = 9,
                        Local = "San Martin de Tucumán",
                        Visitante = "Racing Club",
                        Estadio = "La Ciudad",
                        Dia = DateTime.Parse("11/21/2018 8:00:00 PM"),
                        Resultado = "2-1",
                    }
                    ,
                    new Fixture
                    {
                        Fecha = 10,
                        Local = "Racing Club",
                        Visitante = "San Lorenzo",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("11/28/2018 11:00 AM"),
                        Resultado = "2-1",
                    },
                    new Fixture
                    {
                        Fecha = 11,
                        Local = "Racing Club",
                        Visitante = "Newell´s Old Boys",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse ("11/4/2018 5:45:00 PM"),
                        Resultado = "1-0",
                    },

                    new Fixture
                    {
                        Fecha = 12,
                        Local = "Gimnasia y Esgrima (LP)",
                        Visitante = "Racing Club",
                        Estadio = "El Bosque",
                        Dia = DateTime.Parse ("11/11/2018 3:30:00 PM"),
                        Resultado = "0-3",
                    },
                    new Fixture
                    {
                        Fecha = 13,
                        Local = "Racing Club",
                        Visitante = "Banfield",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("11/25/2018 9:30:00 PM"),
                        Resultado = "0-0",
                    },

                    new Fixture
                    {
                        Fecha = 14,
                        Local = "	Talleres",
                        Visitante = "Racing Club",
                        Estadio = "Mario Alberto Kempes",
                        Dia = DateTime.Parse("12/3/2018 9:30:00 PM"),
                        Resultado = "1-3",
                    },
                    new Fixture
                    {
                        Fecha = 15,
                        Local = "	Racing Club",
                        Visitante = "San Martin de San Juan",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("12/9/2018 9:30:00 PM"),
                        Resultado = "1-0",
                    },

                    new Fixture
                    {
                        Fecha = 16,
                        Local = "Aldosivi",
                        Visitante = "	Racing Club",
                        Estadio = "José María Minelli",
                        Dia = DateTime.Parse("1/26/2019 9:30:00 PM"),
                        Resultado = "1-3",
                    },
                    new Fixture
                    {
                        Fecha = 17,
                        Local = "	Racing Club",
                        Visitante = "Huracán",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("2/3/2019 7:20:00 PM"),
                        Resultado = "3-1",
                    },

                    new Fixture
                    {
                        Fecha = 18,
                        Local = "River Plate",
                        Visitante = "	Racing Club",
                        Estadio = "Monumental",
                        Dia = DateTime.Parse("2/10/2019 7:20:00 PM"),
                        Resultado = "2-0",
                    },
                    new Fixture
                    {
                        Fecha = 19,
                        Local = "Racing Club",
                        Visitante = "Godoy Cruz",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("2/18/2019 9:10:00 PM"),
                        Resultado = "3-0",
                    },

                    new Fixture
                    {
                        Fecha = 20,
                        Local = "Independiente",
                        Visitante = "Racing Club",
                        Estadio = "Libertadores de América",
                        Dia = DateTime.Parse("2/23/2019 9:30:00 PM"),
                        Resultado = "1-3",
                    },
                    new Fixture
                    {
                        Fecha = 21,
                        Local = "Racing Club",
                        Visitante = "	Estudiantes (LP)",
                        Estadio = "El Cilindro",
                        Dia = DateTime.Parse("3/3/2019 7:20:00 PM"),
                        Resultado = "1-0",
                    },

                        new Fixture
                        {
                            Fecha = 22,
                            Local = "Colón",
                            Visitante = "Racing Club",
                            Estadio = "Brigadier Estanislao López",
                            Dia = DateTime.Parse("3/9/2019 7:20:00 PM"),
                            Resultado = "1-1",
                        },

                        new Fixture
                        {
                            Fecha = 23,
                            Local = "Racing Club",
                            Visitante = "Belgrano",
                            Estadio = "El Cilindro",
                            Dia = DateTime.Parse("3/16/2019 8:00:00 PM"),
                            Resultado = "1-0",
                        },

                        new Fixture
                        {
                            Fecha = 24,
                            Local = "Tigre",
                            Visitante = "Racing Club",
                            Estadio = "Monumental de Victoria	",
                            Dia = DateTime.Parse("3/31/2019 6:10:00 PM"),
                            Resultado = "1-1",
                        },
                        new Fixture
                        {
                            Fecha = 25,
                            Local = "Racing Club",
                            Visitante = "Defensa Y Justicia",
                            Estadio = "El Cilindro",
                            Dia = DateTime.Parse("4/7/2019 6:30:00 PM"),
                            Resultado = "1-1",
                        }
 
                );
                  context.SaveChanges();
            }
        }
    }
}


