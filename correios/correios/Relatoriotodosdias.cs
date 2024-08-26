using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace correios
{
    public partial class Relatoriotodosdias : Form
    {
        public Relatoriotodosdias()
        {
            InitializeComponent();
        }

        private void Relatoriotodosdias_Load(object sender, EventArgs e)
        {
            // Configurar o DataGridView no evento Load para definir as colunas
            ConfigurarColunasDataGridView();

            // Carregar o XML e exibir no DataGridView
            var relatorioMensal = CarregarRelatorioMensal("C:\\correios\\RelatorioDiario.xml");
            if (relatorioMensal != null)
            {
                ExibirRelatorioNoDataGridView(relatorioMensal);
            }
            else
            {
                MessageBox.Show("Não foi possível carregar o relatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private RelatorioMensal CarregarRelatorioMensal(string caminhoArquivo)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(RelatorioMensal));
                using (var stream = new FileStream(caminhoArquivo, FileMode.Open))
                {
                    return (RelatorioMensal)serializer.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o arquivo XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ExibirRelatorioNoDataGridView(RelatorioMensal relatorioMensal)
        {
            // Definir a fonte de dados
            dgvListarRelatorio.DataSource = relatorioMensal.RelatoriosDiarios;
        }

        private void ConfigurarColunasDataGridView()
        {
            // Configurar as colunas do DataGridView manualmente
            dgvListarRelatorio.AutoGenerateColumns = false;
            dgvListarRelatorio.Columns.Clear();

            dgvListarRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data",
                HeaderText = "Data",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } // Formatar a data
            });

            dgvListarRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EncomendasCadastradasHoje",
                HeaderText = "Cadastradas Hoje",
                Width = 100
            });

            dgvListarRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EncomendasBaixadasHoje",
                HeaderText = "Baixadas Hoje",
                Width = 100
            });

            dgvListarRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EncomendasBaixadasHojeCadastradasHoje",
                HeaderText = "Baixadas Cadastradas Hoje",
                Width = 150
            });

            // Ajustar estilo do DataGridView
            AjustarEstiloDataGridView();
        }

        private void AjustarEstiloDataGridView()
        {
            // Configura o tamanho da fonte das células
            dgvListarRelatorio.DefaultCellStyle.Font = new Font("Arial", 12); // Define a fonte e o tamanho desejados para as células

            // Configura o tamanho da fonte dos cabeçalhos das colunas
            dgvListarRelatorio.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Define a fonte, o tamanho e o estilo dos cabeçalhos

            // Configura o alinhamento dos textos das células
            dgvListarRelatorio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinha o texto das células ao centro

            // Configura o alinhamento dos textos dos cabeçalhos das colunas
            dgvListarRelatorio.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinha o texto dos cabeçalhos ao centro
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListarRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementar ações ao clicar nas células, se necessário
        }
    }

    [XmlRoot("RelatorioMensal")]
    public class RelatorioMensal
    {
        [XmlArray("RelatoriosDiarios")]
        [XmlArrayItem("RelatorioDiario")]
        public List<RelatorioDiario> RelatoriosDiarios { get; set; }
    }

    public class RelatorioDiario
    {
        public DateTime Data { get; set; }
        public int EncomendasCadastradasHoje { get; set; }
        public int EncomendasBaixadasHoje { get; set; }
        public int EncomendasBaixadasHojeCadastradasHoje { get; set; }
    }
}
