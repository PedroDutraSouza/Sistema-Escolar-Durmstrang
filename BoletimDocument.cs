//Credito Design: Ondo Studio
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System;// para FontManager
using System.Collections.Generic;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
// using QuestPDF.Companion;   // descomente se tiver o pacote Companion instalado

namespace testePDF
{

    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Registration { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
    }

    public class SubjectGrade
    {
        public string Subject { get; set; }
        public string Grade { get; set; }
        public string Grade1 { get; set; } // Nota 1º Bimestre
        public string Grade2 { get; set; } // Nota 2º Bimestre
        public string Grade3 { get; set; } // Nota 3º Bimestre
        public string Grade4 { get; set; }
        public string Grade5 { get; set; } // Nota 3º Bimestre
        public string Grade6 { get; set; }// Nota 4º Bimestre
    };

    public class BoletimDocument : IDocument
    {
        private Student StudentInfo { get; }
        private List<SubjectGrade> Grades { get; }

        public BoletimDocument(Student student, List<SubjectGrade> grades)
        {
            StudentInfo = student ?? throw new ArgumentNullException(nameof(student));
            // MUDANÇA: 'new()' (C# 9.0) alterado para 'new List<SubjectGrade>()' (C# 7.3)
            Grades = grades ?? new List<SubjectGrade>();
        }

        public DocumentMetadata GetMetadata() => new DocumentMetadata()
        {
            Title = "Boletim Escolar",
            Author = "Escola Exemplo"
        };

        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.MarginTop(37);
                page.MarginLeft(50);
                page.MarginRight(50);
                page.PageColor(Color.FromHex("#E8E4CA"));
                page.DefaultTextStyle(x => x.FontSize(11));
                page.Background()
                .Image("D://De fato final//Durmstrang(final)//Resources//borda.png"); // <-- IMPORTANTE: Troque pelo nome do seu ficheiro


                // Cabeçalho
                page.Header().Background(Color.FromHex("#E8E4CA"))
                    .Height(120)
                    //.Background(Color.FromHex("#E8E4CA")
                    //.Padding(0)
                    //.BorderBottom(0)
                    .Row(row =>
                    {
                        row.ConstantItem(120).AlignLeft().Background(Color.FromHex("#E8E4CA")).Column(col =>
                        {
                            if (File.Exists("D://De fato final//Durmstrang(final)//Resources//logo1.png"))
                                col.Item().Container().Height(120).Image("D://De fato final//Durmstrang(final)//Resources//logo1.png");
                            else
                                col.Item().Text("[Logo]").FontSize(10).AlignRight();
                        });

                        row.RelativeItem().PaddingTop(25).Column(col =>
                        {
                            col.Item().Text("BOLETIM ESCOLAR").FontSize(36).FontFamily("IM FELL English SC").FontColor(Color.FromHex("#3e3922"));
                            col.Item().Text("    INSTITUTO DE APRENDIZAGEM MÁGICA DURMSTRANG").FontSize(12).FontFamily("IM FELL English SC").FontColor(Color.FromHex("#3e3922"));
                        });

                    });

                // Conteúdo
                page.Content().Column(content =>
                {
                    // Info do aluno
                    content.Item().PaddingLeft(10).PaddingRight(10).Column(c =>
                    {
                        c.Item().Row(r =>
                        {
                            r.RelativeItem().Column(info =>
                            {
                                info.Item().PaddingBottom(10).Text($"NOME:       {StudentInfo.Name}").FontFamily("IM FELL English SC").FontSize(13).FontColor(Color.FromHex("#3e3922"));
                                info.Item().Text($"GRADE:      {StudentInfo.Class}").FontFamily("IM FELL English SC").FontSize(13).FontColor(Color.FromHex("#3e3922"));
                            });

                            r.RelativeItem().Column(info =>
                            {
                                info.Item().PaddingBottom(10).Text($"TURMA:      {StudentInfo.Registration}").AlignLeft().FontFamily("IM FELL English SC").FontSize(13).FontColor(Color.FromHex("#3e3922"));
                                info.Item().Text($"ANO:      {StudentInfo.Period}").AlignLeft().FontFamily("IM FELL English SC").FontSize(13).FontColor(Color.FromHex("#3e3922"));
                            });
                        });
                    });


                    //                          ESCALA DE NOTAS EXCLUIDA - NOTAS DE 0 A 10 EM SISTEMA BIMESTRAL SENDO UTILIZADAS

                    /*content.Item().PaddingTop(45).PaddingLeft(10).PaddingRight(10).Column(escalaNotas =>
                    {
                        escalaNotas.Item().PaddingBottom(10).Text("ESCALA DE LETRAS").FontSize(20).FontFamily("IM FELL English SC").FontColor(Color.FromHex("#3e3922"));

                        content.Item().Column(c =>
                        {
                            c.Item().Row(r =>
                            {
                                r.RelativeItem().Column(info =>
                                {
                                    info.Item().PaddingLeft(10).PaddingRight(10).Text($"A90-100").FontFamily("IM FELL English SC").FontSize(14).FontColor(Color.FromHex("#3e3922"));
                                    info.Item().PaddingLeft(10).PaddingRight(10).Text($"B80-89").FontFamily("IM FELL English SC").FontSize(14).FontColor(Color.FromHex("#3e3922"));
                                });

                                r.RelativeItem().Column(info =>
                                {
                                    info.Item().PaddingLeft(10).PaddingRight(10).Text($"C70-79").AlignLeft().FontFamily("IM FELL English SC").FontSize(14).FontColor(Color.FromHex("#3e3922"));
                                    info.Item().PaddingLeft(10).PaddingRight(10).Text($"D60-69").AlignLeft().FontFamily("IM FELL English SC").FontSize(14).FontColor(Color.FromHex("#3e3922"));
                                });
                                r.RelativeItem().Column(info =>
                                {
                                    info.Item().PaddingLeft(10).PaddingRight(10).Text($"E59-40").AlignLeft().FontFamily("IM FELL English SC").FontSize(14).FontColor(Color.FromHex("#3e3922"));
                                    info.Item().PaddingLeft(10).PaddingRight(10).Text($"F39-0").AlignLeft().FontFamily("IM FELL English SC").FontSize(14).FontColor(Color.FromHex("#3e3922"));
                                });
                            });
                        });
                    });*/

                    // Tabela de notas
                    content.Item().PaddingLeft(10).PaddingRight(10).Column(tableCol =>
                    {
                        tableCol.Item().Table(table =>
                        {
                            // 1. DEFINIÇÃO DE COLUNAS (Corrigido para 6 colunas)
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(2); // Disciplinas
                                columns.RelativeColumn(1); // 1ºbimestre
                                columns.RelativeColumn(1); // 2ºbimestre
                                columns.RelativeColumn(1); // 3ºbimestre
                                columns.RelativeColumn(1); // 4ºbimestre
                                columns.RelativeColumn(1); // Média anual
                            });

                            // 2. CABEÇALHO (Estilos aplicados diretamente, sem 'Action' helper)
                            table.Header(header =>
                            {
                                // Célula 1
                                header.Cell().PaddingTop(25).Background(Color.FromHex("#373737")).Border(0).Padding(5)
                                       .BorderColor(Color.FromHex("#373737"))
                                       .Background(Color.FromHex("#373737"))
                                       .Text("Disciplinas").FontFamily("IM FELL English SC")
                                       .FontColor(Color.FromHex("#F8F4EB")).FontSize(14);

                                // Célula 2
                                header.Cell().PaddingTop(25).Background(Color.FromHex("#373737")).Padding(5)
                                       .BorderBottom(0).BorderColor(Color.FromHex("#373737"))
                                       .Background(Color.FromHex("#373737"))
                                       .Text("1ºB").FontFamily("IM FELL English SC")
                                       .FontColor(Color.FromHex("#F8F4EB")).FontSize(14);

                                // Célula 3
                                header.Cell().PaddingTop(25).Background(Color.FromHex("#373737")).Padding(5)
                                       .BorderBottom(0).BorderColor(Color.FromHex("#373737"))
                                       .Text("2ºB").FontFamily("IM FELL English SC")
                                       .FontColor(Color.FromHex("#F8F4EB")).FontSize(14);

                                // Célula 4
                                header.Cell().PaddingTop(25).Background(Color.FromHex("#373737")).Padding(5)
                                       .BorderBottom(0).BorderColor(Color.FromHex("#373737"))
                                       .Background(Color.FromHex("#373737"))
                                       .Text("3ºB").FontFamily("IM FELL English SC")
                                       .FontColor(Color.FromHex("#F8F4EB")).FontSize(14);

                                // Célula 5
                                header.Cell().PaddingTop(25).Background(Color.FromHex("#373737")).Padding(5)
                                       .BorderBottom(0).BorderColor(Color.FromHex("#373737"))
                                       .Background(Color.FromHex("#373737"))
                                       .Text("4ºB").FontFamily("IM FELL English SC")
                                       .FontColor(Color.FromHex("#F8F4EB")).FontSize(14);

                                // Célula 6
                                header.Cell().PaddingTop(25).Background(Color.FromHex("#373737")).Padding(5)
                                       .BorderBottom(0).BorderColor(Color.FromHex("#373737"))
                                       .Background(Color.FromHex("#373737"))
                                       .Text("Média anual").FontFamily("IM FELL English SC")
                                       .FontColor(Color.FromHex("#F8F4EB")).FontSize(14);
                            });

                            // 3. CORPO DA TABELA
                            // Assumindo que 'Grades' é 'List<SubjectGrade>'
                            // E 'SubjectGrade' TEM as propriedades Grade1, Grade2, etc.
                            foreach (var g in Grades)
                            {

                                // --- Calcular Média Anual ---
                                // Define a cultura para "Português-Brasil" para entender a vírgula (ex: "7,5")
                                var culture = CultureInfo.GetCultureInfo("pt-BR");
                                var gradesList = new List<double>();
                                //int noteCount = 0;

                                if (double.TryParse(g.Grade1, NumberStyles.Any, culture, out double grade1))
                                    gradesList.Add(grade1);

                                if (double.TryParse(g.Grade2, NumberStyles.Any, culture, out double grade2))
                                    gradesList.Add(grade2);

                                if (double.TryParse(g.Grade3, NumberStyles.Any, culture, out double grade3))
                                    gradesList.Add(grade3);

                                if (double.TryParse(g.Grade4, NumberStyles.Any, culture, out double grade4))
                                    gradesList.Add(grade4);



                                double avg = gradesList.Count > 0 ? gradesList.Average() : 0;
                                string avgText = (avg == 0) ? "-" : avg.ToString("0.0", culture); // Formata para "6,8"

                                // --- Adicionar Células (Estilos aplicados diretamente) ---

                                // Célula 1: Disciplina
                                table.Cell().BorderLeft(1).BorderRight(1).BorderBottom(1)
                                     .BorderColor(Color.FromHex("#373737")).Padding(10)
                                     .Text(g.Subject ?? "-").FontFamily("IM FELL English SC");

                                // Célula 2: 1ºB
                                table.Cell().BorderRight(1).BorderBottom(1)
                                     .BorderColor(Color.FromHex("#373737")).Padding(10)
                                     .AlignCenter().Text(g.Grade1 ?? "-").FontFamily("IM FELL English SC");

                                // Célula 3: 2ºB
                                table.Cell().BorderRight(1).BorderBottom(1)
                                     .BorderColor(Color.FromHex("#373737")).Padding(10)
                                     .AlignCenter().Text(g.Grade2 ?? "-").FontFamily("IM FELL English SC");

                                // Célula 4: 3ºB
                                table.Cell().BorderRight(1).BorderBottom(1)
                                     .BorderColor(Color.FromHex("#373737")).Padding(10)
                                     .AlignCenter().Text(g.Grade3 ?? "-").FontFamily("IM FELL English SC");

                                // Célula 5: 4ºB
                                table.Cell().BorderRight(1).BorderBottom(1)
                                     .BorderColor(Color.FromHex("#373737")).Padding(10)
                                     .AlignCenter().Text(g.Grade4 ?? "-").FontFamily("IM FELL English SC");

                                // Célula 6: Média Anual
                                table.Cell().BorderRight(1).BorderBottom(1)
                                     .BorderColor(Color.FromHex("#373737")).Padding(10)
                                     .AlignCenter().Text(avgText).FontFamily("IM FELL English SC");
                            }
                        });
                    });

                    // Observações
                    content.Item().PaddingTop(30).Column(c =>
                    {
                        c.Item().PaddingLeft(10).PaddingRight(10).Text("Observações:").FontFamily("IM FELL English SC");
                        c.Item().PaddingLeft(5).PaddingRight(5).Padding(6).Height(80).Border(1)
                            .Text("  Aluno com bom desempenho geral. Continuar com acompanhamento pedagógico.").FontFamily("IM FELL English SC");
                    });

                    // Assinaturas
                    content.Item().PaddingLeft(10).PaddingRight(10).PaddingTop(40).Row(r =>
                    {
                        r.RelativeItem().Column(sig =>
                        {
                            sig.Item().AlignCenter().PaddingVertical(0).BorderBottom(1);
                            sig.Item().AlignCenter().Text("Assinatura do Professor: ____________________________________________").FontSize(10).FontFamily("IM FELL English SC");
                        });




                    });
                });

                // Rodapé
                page.Footer().PaddingBottom(50).AlignCenter().Text(x =>
                {
                    x.Span("Instituto Durmstrang — ").FontFamily("IM FELL English SC");
                    x.Span(DateTime.Now.ToString("dd/MM/yyyy")).FontFamily("IM FELL English SC").FontSize(10);
                });
            });

        }
    }
}
