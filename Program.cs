// Credito Design: Ondo Studio
using Durmstrang;
using QuestPDF.Drawing; 
using QuestPDF.Infrastructure;
using System;
using System.IO;
using System.Windows.Forms;


namespace BoletimApp
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //usa licença comunitaria do QuestPDF
            QuestPDF.Settings.License = LicenseType.Community;

            // Registra fonte externa
            var fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fonts", "IMFellEnglishSC-Regular.ttf");
            if (File.Exists(fontPath))
            {
                using (var fs = File.OpenRead(fontPath))
                {
                    FontManager.RegisterFont(fs);
                }
            }
            else
            {
                MessageBox.Show($"Aviso: Fonte não encontrada em {fontPath}", "Fonte Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Inicia a aplicação começando pelo o Form1.
            Application.Run(new Form1());
        }
    }
}