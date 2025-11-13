//Importa Bibliotecas
using BoletimApp;
using connection; 
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization; 
using System.IO;
using System.Windows.Forms;

namespace Durmstrang
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            CarregarMaterias(); 
            CarregarTabela();   
        }

        // ... (Os métodos CarregarMaterias, CarregarTabela, sobreNos_Click, button5_Click, e button2_Click permanecem os mesmos da resposta anterior) ...
        #region Métodos de Carregamento e Pesquisa (Sem Alteração)

        /// <summary>
        /// NOVO MÉTODO: Carrega as matérias no comboBox1
        /// </summary>
        private void CarregarMaterias()
        {
            using (var con = Conexao.Conectar())
            {
                try
                {
                    // Busca apenas matérias distintas
                    string sql = "SELECT DISTINCT nome_materia FROM materias ORDER BY nome_materia";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Adiciona uma opção "Todas" no início
                    DataRow row = dt.NewRow();
                    row["nome_materia"] = "Todas as Matérias"; // Texto para "sem filtro"
                    dt.Rows.InsertAt(row, 0);

                    // Configura o ComboBox
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "nome_materia";
                    comboBox1.ValueMember = "nome_materia"; // Pode usar o mesmo
                    comboBox1.SelectedIndex = 0; // Deixa "Todas as Matérias" selecionado
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar matérias: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// MÉTODO ATUALIZADO: Aceita parâmetros opcionais de filtro
        /// </summary>
        /// <param name="nome">Nome ou sobrenome para pesquisar (parcial)</param>
        /// <param name="materia">Nome exato da matéria para filtrar</param>
        private void CarregarTabela(string nome = null, string materia = null)
        {
            using (var con = Conexao.Conectar())
            {
                try
                {
                    // Base da sua consulta SQL
                    string sql = @"
                        SELECT 
                            alunos.id_aluno,
                            alunos.nome_aluno,
                            alunos.sobrenome,
                            materias.nome_materia,
                            notas.B1,
                            notas.B2,
                            notas.B3,
                            notas.B4,
                            notas.final
                        FROM alunos 
                        INNER JOIN notas ON alunos.id_aluno = notas.id_aluno
                        INNER JOIN materias ON notas.id_materia = materias.id_materia
                    ";

                    // --- Lógica de Filtro Dinâmico ---
                    var whereClauses = new List<string>();
                    var parameters = new List<MySqlParameter>();

                    // 1. Filtro de Nome
                    if (!string.IsNullOrWhiteSpace(nome))
                    {
                        // Usamos CONCAT para pesquisar no nome completo
                        whereClauses.Add("CONCAT(alunos.nome_aluno, ' ', alunos.sobrenome) LIKE @nome");
                        parameters.Add(new MySqlParameter("@nome", $"%{nome}%")); // % = pesquisa parcial
                    }

                    // 2. Filtro de Matéria
                    if (!string.IsNullOrWhiteSpace(materia) && materia != "Todas as Matérias")
                    {
                        whereClauses.Add("materias.nome_materia = @materia");
                        parameters.Add(new MySqlParameter("@materia", materia)); // Nome exato
                    }

                    // 3. Monta a query final
                    if (whereClauses.Count > 0)
                    {
                        sql += " WHERE " + string.Join(" AND ", whereClauses);
                    }

                    sql += " ORDER BY alunos.nome_aluno, materias.nome_materia;"; // Opcional: ordenar
                    // --- Fim da Lógica de Filtro ---

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                    
                    if (parameters.Count > 0)
                    {
                        da.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBoletim.DataSource = dt;

                    // Oculta a coluna ID
                    if (dgvBoletim.Columns.Contains("id_aluno"))
                    {
                        dgvBoletim.Columns["id_aluno"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
                }
            }
        }

        //Voltar
        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        /// <summary>
        /// MÉTODO ATUALIZADO: Botão de Pesquisa
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            // 1. Pega os valores dos campos
            string nomePesquisa = digiteD.Text.Trim(); // 'digiteD' é o seu TextBox
            string materiaPesquisa = comboBox1.Text;

            // 2. Chama o CarregarTabela com os filtros
            CarregarTabela(nomePesquisa, materiaPesquisa);
        }

        //Imprimir Boletim
        private void button2_Click(object sender, EventArgs e)
        {
            int alunoId = 0;

            if (dgvBoletim.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um aluno na tabela.", "Nenhum Aluno Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                object cellValue = dgvBoletim.CurrentRow.Cells["id_aluno"].Value;

                if (cellValue == null || !int.TryParse(cellValue.ToString(), out alunoId))
                {
                    MessageBox.Show("Não foi possível obter o ID do aluno selecionado.\nVerifique se a coluna 'id_aluno' existe no DataGridView e tem um valor numérico.", "Erro ao Ler ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar ler o ID do aluno: {ex.Message}\n\nVerifique o nome da coluna no código do 'button2_Click'.", "Erro de Coluna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alunoId > 0)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    BoletimGenerator generator = new BoletimGenerator();
                    string filePath = generator.GerarBoletim(alunoId);

                    this.Cursor = Cursors.Default;

                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        var result = MessageBox.Show($"PDF gerado com sucesso em:\n{filePath}\n\nDeseja abri-lo agora?", "Sucesso!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            Process.Start(new ProcessStartInfo { FileName = filePath, UseShellExecute = true });
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro desconhecido e o PDF não foi gerado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show($"Ocorreu um erro ao gerar o PDF:\n{ex.Message}", "Erro na Geração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        // --- INÍCIO DA NOVA IMPLEMENTAÇÃO (Salvar Notas) ---

        /// <summary>
        /// MÉTODO NOVO: Botão de Salvar/Editar Notas
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // --- 1. Validar Entradas do Formulário ---
                string nomeAluno = digiteD.Text.Trim();
                string nomeMateria = comboBox1.Text;

                if (string.IsNullOrWhiteSpace(nomeAluno))
                {
                    MessageBox.Show("Por favor, digite o nome de um aluno.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    digiteD.Focus();
                    return;
                }

                if (nomeMateria == "Todas as Matérias")
                {
                    MessageBox.Show("Por favor, selecione uma matéria específica para salvar a nota.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                    return;
                }

                // Parse e valida notas (0-10)
                // O método ParseAndValidateGrade retorna 'decimal?' (nullable)
                // Retorna 'null' se o campo estiver vazio
                // Lança uma exceção se o valor for inválido (não-numérico ou fora do range)
                decimal? b1 = ParseAndValidateGrade(primeiroBimestre);
                decimal? b2 = ParseAndValidateGrade(segundoBimestre);
                decimal? b3 = ParseAndValidateGrade(terceiroBimestre);
                decimal? b4 = ParseAndValidateGrade(quartoBimestre);

                // Verificar se pelo menos uma nota foi digitada
                if (!b1.HasValue && !b2.HasValue && !b3.HasValue && !b4.HasValue)
                {
                    MessageBox.Show("Por favor, insira pelo menos uma nota para salvar.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    primeiroBimestre.Focus();
                    return;
                }

                // --- 2. Validar IDs no Banco de Dados ---
                int? alunoId;
                int? materiaId;

                using (var con = Conexao.Conectar())
                {
                    // Valida se o aluno existe
                    alunoId = GetAlunoIdPorNome(con, nomeAluno);
                    if (!alunoId.HasValue)
                    {
                        MessageBox.Show($"Aluno '{nomeAluno}' não foi encontrado no banco de dados.\nVerifique se o nome está correto.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Valida se a matéria existe
                    materiaId = GetMateriaIdPorNome(con, nomeMateria);
                    if (!materiaId.HasValue)
                    {
                        // Isso não deve acontecer se o ComboBox carregou corretamente
                        MessageBox.Show($"Matéria '{nomeMateria}' não encontrada.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // --- 3. Verificar se a nota já existe (Lógica INSERT vs UPDATE) ---
                    int? notaId = GetNotaId(con, alunoId.Value, materiaId.Value);

                    if (notaId.HasValue)
                    {
                        // 4.a. UPDATE: Atualiza apenas as notas preenchidas
                        ExecutarUpdateNotas(con, alunoId.Value, materiaId.Value, b1, b2, b3, b4);
                    }
                    else
                    {
                        // 4.b. INSERT: Cria um novo registro
                        ExecutarInsertNotas(con, alunoId.Value, materiaId.Value, b1, b2, b3, b4);
                    }
                } // Conexão fechada

                // --- 5. Feedback e Refresh ---
                MessageBox.Show("Notas salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos de nota após salvar
                primeiroBimestre.Text = "";
                segundoBimestre.Text = "";
                terceiroBimestre.Text = "";
                quartoBimestre.Text = "";

                // Recarrega a tabela para mostrar os dados atualizados
                CarregarTabela(digiteD.Text, comboBox1.Text);
            }
            catch (Exception ex)
            {
                // Captura erros do ParseAndValidateGrade ou de acesso ao BD
                MessageBox.Show($"Ocorreu um erro ao salvar as notas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Métodos Auxiliares para Salvar Notas

        /// <summary>
        /// MÉTODO NOVO: Valida e converte uma nota de um TextBox.
        /// </summary>
        /// <returns>decimal? (null se vazio, valor decimal se válido)</returns>
        /// <exception cref="Exception">Lança exceção se o valor for inválido.</exception>
        private decimal? ParseAndValidateGrade(TextBox tb)
        {
            // Se o campo está vazio, retorna 'null'. Isso é usado para "não atualizar".
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                return null;
            }

            // Substitui vírgula por ponto para consistência com o BD (Cultura Invariante)
            string gradeText = tb.Text.Replace(',', '.');

            // Tenta converter para decimal
            if (decimal.TryParse(gradeText, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal grade))
            {
                // Verifica o range 0-10
                if (grade >= 0 && grade <= 10)
                {
                    return grade; // Sucesso
                }
                else
                {
                    // Erro: Fora do range
                    tb.Focus();
                    throw new Exception($"A nota em '{tb.Name}' ({grade}) deve estar entre 0 e 10.");
                }
            }
            else
            {
                // Erro: Não é um número
                tb.Focus();
                throw new Exception($"O valor em '{tb.Name}' ({tb.Text}) não é um número decimal válido.");
            }
        }

        /// <summary>
        /// MÉTODO NOVO: Busca o ID do aluno pelo nome (parcial).
        /// </summary>
        private int? GetAlunoIdPorNome(MySqlConnection con, string nome)
        {
            // Usa LIKE (como na pesquisa) para encontrar o aluno
            string sql = "SELECT id_aluno FROM alunos WHERE CONCAT(nome_aluno, ' ', sobrenome) LIKE @nome LIMIT 1";
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return null; // Não encontrado
        }

        /// <summary>
        /// MÉTODO NOVO: Busca o ID da matéria pelo nome exato.
        /// </summary>
        private int? GetMateriaIdPorNome(MySqlConnection con, string nomeMateria)
        {
            string sql = "SELECT id_materia FROM materias WHERE nome_materia = @nome LIMIT 1";
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nome", nomeMateria);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return null; // Não encontrado
        }

        /// <summary>
        /// MÉTODO NOVO: Verifica se já existe um registro de nota.
        /// </summary>
        private int? GetNotaId(MySqlConnection con, int alunoId, int materiaId)
        {
            string sql = "SELECT id_notas FROM notas WHERE id_aluno = @alunoId AND id_materia = @materiaId LIMIT 1";
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@alunoId", alunoId);
                cmd.Parameters.AddWithValue("@materiaId", materiaId);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return null; // Não existe
        }

        /// <summary>
        /// MÉTODO NOVO: Insere um novo registro de nota.
        /// </summary>
        private void ExecutarInsertNotas(MySqlConnection con, int alunoId, int materiaId, decimal? b1, decimal? b2, decimal? b3, decimal? b4)
        {
            string sql = @"
                INSERT INTO notas (id_aluno, id_materia, B1, B2, B3, B4) 
                VALUES (@alunoId, @materiaId, @B1, @B2, @B3, @B4)";

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@alunoId", alunoId);
                cmd.Parameters.AddWithValue("@materiaId", materiaId);

                // Converte 'null' (decimal?) para DBNull.Value (para o banco)
                cmd.Parameters.AddWithValue("@B1", (object)b1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@B2", (object)b2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@B3", (object)b3 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@B4", (object)b4 ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// MÉTODO NOVO: Atualiza um registro de nota existente.
        /// </summary>
        private void ExecutarUpdateNotas(MySqlConnection con, int alunoId, int materiaId, decimal? b1, decimal? b2, decimal? b3, decimal? b4)
        {
            // Monta a query dinamicamente para atualizar SOMENTE os campos preenchidos
            var setClauses = new List<string>();
            var parameters = new List<MySqlParameter>();

            // Adiciona a cláusula SET apenas se o valor não for 'null' (não estava em branco)
            if (b1.HasValue)
            {
                setClauses.Add("B1 = @B1");
                parameters.Add(new MySqlParameter("@B1", b1.Value));
            }
            if (b2.HasValue)
            {
                setClauses.Add("B2 = @B2");
                parameters.Add(new MySqlParameter("@B2", b2.Value));
            }
            if (b3.HasValue)
            {
                setClauses.Add("B3 = @B3");
                parameters.Add(new MySqlParameter("@B3", b3.Value));
            }
            if (b4.HasValue)
            {
                setClauses.Add("B4 = @B4");
                parameters.Add(new MySqlParameter("@B4", b4.Value));
            }

            // O check principal no button1_Click já garante que setClauses.Count > 0

            string sql = "UPDATE notas SET " + string.Join(", ", setClauses) +
                         " WHERE id_aluno = @alunoId AND id_materia = @materiaId";

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                cmd.Parameters.AddWithValue("@alunoId", alunoId);
                cmd.Parameters.AddWithValue("@materiaId", materiaId);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        // --- FIM DA NOVA IMPLEMENTAÇÃO ---


        // --- Eventos vazios (pode deixar como estão) ---
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // O carregamento agora está no construtor
        }

        private void digiteD_TextChanged(object sender, EventArgs e)
        {

        }

        private void primeiroBimestre_TextChanged(object sender, EventArgs e)
        {

        }

        private void segundoBimestre_TextChanged(object sender, EventArgs e)
        {

        }

        private void terceiroBimestre_TextChanged(object sender, EventArgs e)
        {

        }

        private void quartoBimestre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}