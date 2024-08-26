
namespace correios
{
    partial class Relatoriotodosdias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListarRelatorio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarRelatorio
            // 
            this.dgvListarRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarRelatorio.Location = new System.Drawing.Point(30, 95);
            this.dgvListarRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListarRelatorio.Name = "dgvListarRelatorio";
            this.dgvListarRelatorio.RowHeadersWidth = 51;
            this.dgvListarRelatorio.Size = new System.Drawing.Size(1119, 519);
            this.dgvListarRelatorio.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "RELATÓRIO COMPLETO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 657);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 63);
            this.button1.TabIndex = 21;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Relatoriotodosdias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListarRelatorio);
            this.Name = "Relatoriotodosdias";
            this.Text = "RELATÓRIO COMPLETO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}