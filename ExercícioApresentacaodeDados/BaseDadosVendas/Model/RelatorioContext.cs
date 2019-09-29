using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDadosVendas.Model
{
    public class RelatorioContext
        //Aqui eu crio um cópia dos dados
    {
        public List<Vendas> listaDeVendas { get; set; }//declaro a lista pro compilador ver a lista, isso é criar uma propriedade
        public RelatorioContext()
        {
            listaDeVendas = new List<Vendas>();//instancia, criam um espaço de memória


            listaDeVendas.Add(new Vendas() { IdCarro =  1, ModeloCarro = "Risus Company	 ",                         ValorCarro = 7.200, QuantidadeVendas = 18,  DataVendas = DateTime.Parse("29/01/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  2, ModeloCarro = "Risus Associates	 ",                     ValorCarro = 9.961, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("10/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  3, ModeloCarro = "Et Libero Proin Foundation	 ",         ValorCarro = 8.710, QuantidadeVendas = 17,  DataVendas = DateTime.Parse("24/01/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  4, ModeloCarro = "Cursus Et Ltd	 ",                         ValorCarro = 9.010, QuantidadeVendas = 17,  DataVendas = DateTime.Parse("26/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  5, ModeloCarro = "Odio Etiam Ligula Company	 ",             ValorCarro = 5.245, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("16/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  6, ModeloCarro = "Eu Nibh Inc.	 ",                         ValorCarro = 7.922, QuantidadeVendas = 9,   DataVendas = DateTime.Parse("27/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  7, ModeloCarro = "Tellus Limited	 ",                     ValorCarro = 7.294, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("26/01/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  8, ModeloCarro = "Imperdiet PC	 ",                         ValorCarro = 8.305, QuantidadeVendas = 5,   DataVendas = DateTime.Parse("06/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro =  9, ModeloCarro = "Elit Inc.	 ",                             ValorCarro = 5.398, QuantidadeVendas = 18,  DataVendas = DateTime.Parse("09/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 10, ModeloCarro = "Quam A Limited	 ",                     ValorCarro = 5.398, QuantidadeVendas = 14,  DataVendas = DateTime.Parse("09/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 11, ModeloCarro = "Adipiscing Institute	 ",                 ValorCarro = 8.133, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("24/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 12, ModeloCarro = "Posuere At Velit Ltd	 ",                 ValorCarro = 5.121, QuantidadeVendas = 15,  DataVendas = DateTime.Parse("19/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 13, ModeloCarro = "Nunc In Industries	 ",                 ValorCarro = 8.902, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("21/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 14, ModeloCarro = "Integer Vitae Nibh Corporation	 ",     ValorCarro = 6.313, QuantidadeVendas = 20,  DataVendas = DateTime.Parse("02/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 15, ModeloCarro = "Tellus Nunc Lectus Company	 ",         ValorCarro = 9.650, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("20/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 16, ModeloCarro = "Suspendisse LLC	 ",                     ValorCarro = 5.319, QuantidadeVendas = 12,  DataVendas = DateTime.Parse("24/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 17, ModeloCarro = "Mauris Vestibulum Corporation	 ",         ValorCarro = 5.790, QuantidadeVendas = 5,   DataVendas = DateTime.Parse("14/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 18, ModeloCarro = "Sed Nec Corp.	 ",                         ValorCarro = 8.421, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("05/05/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 19, ModeloCarro = "Enim Nisl Elementum Inc.	 ",             ValorCarro = 5.904, QuantidadeVendas = 6,   DataVendas = DateTime.Parse("26/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 20, ModeloCarro = "Ac Mattis Semper Corporation	 ",         ValorCarro = 5.110, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("14/01/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 21, ModeloCarro = "Donec Tempus Lorem LLC	 ",             ValorCarro = 8.576, QuantidadeVendas = 16,  DataVendas = DateTime.Parse("29/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 22, ModeloCarro = "Tempor Augue Ac Ltd	 ",                 ValorCarro = 9.072, QuantidadeVendas = 16,  DataVendas = DateTime.Parse("09/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 23, ModeloCarro = "Diam Duis Mi LLC	 ",                     ValorCarro = 8.472, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("23/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 24, ModeloCarro = "Aliquam Corp.	 ",                         ValorCarro = 6.607, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("28/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 25, ModeloCarro = "Montes Institute	 ",                     ValorCarro = 6.176, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("19/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 26, ModeloCarro = "Hendrerit Institute	 ",                 ValorCarro = 8.387, QuantidadeVendas = 11,  DataVendas = DateTime.Parse("17/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 27, ModeloCarro = "Erat Etiam Vestibulum Corporation	 ",     ValorCarro = 7.584, QuantidadeVendas = 9,   DataVendas = DateTime.Parse("02/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 28, ModeloCarro = "Adipiscing Ltd	 ",                     ValorCarro = 7.887, QuantidadeVendas = 9,   DataVendas = DateTime.Parse("19/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 29, ModeloCarro = "In Tempus Eu Inc.	 ",                     ValorCarro = 5.233, QuantidadeVendas = 16,  DataVendas = DateTime.Parse("20/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 30, ModeloCarro = "Elit Institute	 ",                     ValorCarro = 7.359, QuantidadeVendas = 11,  DataVendas = DateTime.Parse("12/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 31, ModeloCarro = "Aliquam Erat LLC	 ",                     ValorCarro = 8.842, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("14/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 32, ModeloCarro = "A Feugiat Tellus PC	 ",                 ValorCarro = 9.176, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("10/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 33, ModeloCarro = "Aliquet Incorporated	 ",                 ValorCarro = 9.057, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("26/04/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 34, ModeloCarro = "Dolor Dolor Tempus Institute	 ",         ValorCarro = 8.433, QuantidadeVendas = 15,  DataVendas = DateTime.Parse("31/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 35, ModeloCarro = "Risus Odio Auctor PC	 ",                 ValorCarro = 8.286, QuantidadeVendas = 11,  DataVendas = DateTime.Parse("29/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 36, ModeloCarro = "Aliquet Molestie Tellus Corp.	 ",         ValorCarro = 8.779, QuantidadeVendas = 1,   DataVendas = DateTime.Parse("05/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 37, ModeloCarro = "Ipsum Corp.	 ",                         ValorCarro = 5.568, QuantidadeVendas = 15,  DataVendas = DateTime.Parse("10/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 38, ModeloCarro = "Mi Lacinia Foundation	 ",                 ValorCarro = 7.442, QuantidadeVendas = 20,  DataVendas = DateTime.Parse("09/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 39, ModeloCarro = "Cubilia Curae; Corp.	 ",                 ValorCarro = 8.421, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("26/05/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 40, ModeloCarro = "Velit Sed Malesuada Associates	 ",     ValorCarro = 9.841, QuantidadeVendas = 6,   DataVendas = DateTime.Parse("07/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 41, ModeloCarro = "Duis Foundation	 ",                     ValorCarro = 9.849, QuantidadeVendas = 6,   DataVendas = DateTime.Parse("08/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 42, ModeloCarro = "Erat Semper Consulting	 ",             ValorCarro = 6.168, QuantidadeVendas = 10,  DataVendas = DateTime.Parse("10/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 43, ModeloCarro = "Turpis Inc.	 ",                         ValorCarro = 7.758, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("12/08/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 44, ModeloCarro = "Aenean Industries	 ",                     ValorCarro = 8.770, QuantidadeVendas = 12,  DataVendas = DateTime.Parse("10/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 45, ModeloCarro = "Nulla Industries	 ",                     ValorCarro = 8.884, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("10/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 46, ModeloCarro = "Semper Egestas Urna Inc.	 ",             ValorCarro = 9.428, QuantidadeVendas = 11,  DataVendas = DateTime.Parse("26/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 47, ModeloCarro = "Donec Luctus Aliquet Industries	 ",     ValorCarro = 5.928, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("11/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 48, ModeloCarro = "Cum Sociis Natoque Foundation	 ",         ValorCarro = 7.506, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("21/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 49, ModeloCarro = "Vitae Sodales Limited	 ",                 ValorCarro = 8.912, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("22/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 50, ModeloCarro = "Tellus Sem Mollis Ltd	 ",                 ValorCarro = 9.615, QuantidadeVendas = 20,  DataVendas = DateTime.Parse("30/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 51, ModeloCarro = "Nulla Tincidunt LLC	 ",                 ValorCarro = 5.562, QuantidadeVendas = 19,  DataVendas = DateTime.Parse("22/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 52, ModeloCarro = "Sed Dictum Institute	 ",                 ValorCarro = 9.243, QuantidadeVendas = 14,  DataVendas = DateTime.Parse("26/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 53, ModeloCarro = "Sed Turpis Company	 ",                 ValorCarro = 7.243, QuantidadeVendas = 14,  DataVendas = DateTime.Parse("20/08/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 54, ModeloCarro = "Vitae Diam Proin Associates	 ",         ValorCarro = 6.631, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("10/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 55, ModeloCarro = "Curabitur Inc.	 ",                     ValorCarro = 8.090, QuantidadeVendas = 3,   DataVendas = DateTime.Parse("09/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 56, ModeloCarro = "Suscipit Est Ac LLC	 ",                 ValorCarro = 8.567, QuantidadeVendas = 15,  DataVendas = DateTime.Parse("08/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 57, ModeloCarro = "Neque Morbi Industries	 ",             ValorCarro = 5.171, QuantidadeVendas = 1,   DataVendas = DateTime.Parse("03/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 58, ModeloCarro = "Non Ltd	 ",                             ValorCarro = 5.102, QuantidadeVendas = 19,  DataVendas = DateTime.Parse("14/08/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 59, ModeloCarro = "Arcu Vestibulum Ante Institute	 ",     ValorCarro = 6.128, QuantidadeVendas = 1,   DataVendas = DateTime.Parse("08/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 60, ModeloCarro = "Nulla Foundation	 ",                     ValorCarro = 7.636, QuantidadeVendas = 6,   DataVendas = DateTime.Parse("14/04/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 61, ModeloCarro = "Quis Massa Mauris LLP	 ",                 ValorCarro = 5.053, QuantidadeVendas = 3,   DataVendas = DateTime.Parse("09/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 62, ModeloCarro = "Ut Incorporated	 ",                     ValorCarro = 6.922, QuantidadeVendas = 17,  DataVendas = DateTime.Parse("16/09/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 63, ModeloCarro = "Aenean Egestas Corp.	 ",                 ValorCarro = 8.142, QuantidadeVendas = 19,  DataVendas = DateTime.Parse("17/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 64, ModeloCarro = "Fusce Mi Lorem Consulting	 ",             ValorCarro = 8.312, QuantidadeVendas = 20,  DataVendas = DateTime.Parse("19/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 65, ModeloCarro = "A Sollicitudin Orci PC	 ",             ValorCarro = 5.864, QuantidadeVendas = 1,   DataVendas = DateTime.Parse("20/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 66, ModeloCarro = "Sociosqu Limited	 ",                     ValorCarro = 5.985, QuantidadeVendas = 12,  DataVendas = DateTime.Parse("28/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 67, ModeloCarro = "Ullamcorper Duis Cursus LLC	 ",         ValorCarro = 5.164, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("22/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 68, ModeloCarro = "Nibh Lacinia LLC	 ",                     ValorCarro = 7.760, QuantidadeVendas = 10,  DataVendas = DateTime.Parse("13/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 69, ModeloCarro = "Eu Dui Institute	 ",                     ValorCarro = 7.695, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("12/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 70, ModeloCarro = "Fringilla Purus Mauris Consulting	 ",     ValorCarro = 5.845, QuantidadeVendas = 6,   DataVendas = DateTime.Parse("01/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 71, ModeloCarro = "Donec Tempus Lorem Industries	 ",         ValorCarro = 8.472, QuantidadeVendas = 19,  DataVendas = DateTime.Parse("09/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 72, ModeloCarro = "Auctor Incorporated	 ",                 ValorCarro = 6.795, QuantidadeVendas = 1,   DataVendas = DateTime.Parse("04/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 73, ModeloCarro = "Enim Etiam Imperdiet Corporation	 ",     ValorCarro = 6.532, QuantidadeVendas = 13,  DataVendas = DateTime.Parse("14/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 74, ModeloCarro = "Non Cursus Non Industries	 ",             ValorCarro = 9.569, QuantidadeVendas = 16,  DataVendas = DateTime.Parse("25/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 75, ModeloCarro = "Ut Semper Incorporated	 ",             ValorCarro = 5.760, QuantidadeVendas = 18,  DataVendas = DateTime.Parse("14/01/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 76, ModeloCarro = "Sed Malesuada Corporation	 ",             ValorCarro = 6.561, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("06/03/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 77, ModeloCarro = "Sed Neque Consulting	 ",                 ValorCarro = 7.308, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("31/08/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 78, ModeloCarro = "Nisl Arcu PC	 ",                         ValorCarro = 7.260, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("19/06/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 79, ModeloCarro = "Euismod Est Consulting	 ",             ValorCarro = 6.020, QuantidadeVendas = 11,  DataVendas = DateTime.Parse("27/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 80, ModeloCarro = "Leo Vivamus Ltd	 ",                     ValorCarro = 5.055, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("22/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 81, ModeloCarro = "Tristique Neque Inc.	 ",                 ValorCarro = 9.268, QuantidadeVendas = 13,  DataVendas = DateTime.Parse("25/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 82, ModeloCarro = "In Lobortis PC	 ",                     ValorCarro = 5.539, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("18/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 83, ModeloCarro = "Nunc Ltd	 ",                             ValorCarro = 6.846, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("09/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 84, ModeloCarro = "Dictum Proin Limited	 ",                 ValorCarro = 5.543, QuantidadeVendas = 12,  DataVendas = DateTime.Parse("05/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 85, ModeloCarro = "Erat Vitae LLP	 ",                     ValorCarro = 5.060, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("12/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 86, ModeloCarro = "Pellentesque Ultricies Dignissim PC	 ", ValorCarro = 7.971, QuantidadeVendas = 15,  DataVendas = DateTime.Parse("25/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 87, ModeloCarro = "Phasellus Elit Company	 ",             ValorCarro = 5.350, QuantidadeVendas = 15,  DataVendas = DateTime.Parse("31/10/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 88, ModeloCarro = "Luctus Felis Ltd	 ",                     ValorCarro = 9.872, QuantidadeVendas = 13,  DataVendas = DateTime.Parse("06/01/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 89, ModeloCarro = "Dui Suspendisse PC	 ",                 ValorCarro = 6.878, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("06/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 90, ModeloCarro = "Odio Associates	 ",                     ValorCarro = 7.636, QuantidadeVendas = 18,  DataVendas = DateTime.Parse("24/07/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 91, ModeloCarro = "Vel Company	 ",                         ValorCarro = 7.410, QuantidadeVendas = 5,   DataVendas = DateTime.Parse("16/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 92, ModeloCarro = "Lobortis Institute	 ",                 ValorCarro = 5.110, QuantidadeVendas = 8,   DataVendas = DateTime.Parse("27/05/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 93, ModeloCarro = "Scelerisque Company	 ",                 ValorCarro = 7.983, QuantidadeVendas = 19,  DataVendas = DateTime.Parse("03/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 94, ModeloCarro = "Posuere Enim Company	 ",                 ValorCarro = 6.968, QuantidadeVendas = 19,  DataVendas = DateTime.Parse("22/04/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 95, ModeloCarro = "Sem Ut Corp.	 ",                         ValorCarro = 6.504, QuantidadeVendas = 11,  DataVendas = DateTime.Parse("02/02/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 96, ModeloCarro = "Dui Fusce Aliquam PC	 ",                 ValorCarro = 7.837, QuantidadeVendas = 2,   DataVendas = DateTime.Parse("08/12/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 97, ModeloCarro = "Nisl Sem Industries	 ",                 ValorCarro = 6.835, QuantidadeVendas = 5,   DataVendas = DateTime.Parse("14/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 98, ModeloCarro = "Vitae Corp.	 ",                         ValorCarro = 7.669, QuantidadeVendas = 7,   DataVendas = DateTime.Parse("09/11/2019") });
            listaDeVendas.Add(new Vendas() { IdCarro = 99, ModeloCarro = "Malesuada Incorporated	 ",             ValorCarro = 5.960, QuantidadeVendas = 4,   DataVendas = DateTime.Parse("26/09/2019") });
           listaDeVendas.Add(new Vendas() { IdCarro = 100, ModeloCarro = "Mauris Ltd	 ",                         ValorCarro = 8.974, QuantidadeVendas = 18,  DataVendas = DateTime.Parse("16/05/2019") });

        }


    }
}
