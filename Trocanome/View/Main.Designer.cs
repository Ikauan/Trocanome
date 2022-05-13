
namespace Trocanome.View
{
    partial class Main
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
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxDe = new System.Windows.Forms.TextBox();
            this.tbxPara = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(80, 66);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 15);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(80, 146);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 15);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(80, 238);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(30, 15);
            this.lblPara.TabIndex = 2;
            this.lblPara.Text = "Para";
            this.lblPara.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(80, 84);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(273, 23);
            this.tbxEndereco.TabIndex = 3;
            // 
            // tbxDe
            // 
            this.tbxDe.Location = new System.Drawing.Point(80, 164);
            this.tbxDe.Name = "tbxDe";
            this.tbxDe.Size = new System.Drawing.Size(273, 23);
            this.tbxDe.TabIndex = 4;
            // 
            // tbxPara
            // 
            this.tbxPara.Location = new System.Drawing.Point(80, 256);
            this.tbxPara.Name = "tbxPara";
            this.tbxPara.Size = new System.Drawing.Size(273, 23);
            this.tbxPara.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(379, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(26, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(80, 316);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(94, 44);
            this.btnTrocar.TabIndex = 7;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbxPara);
            this.Controls.Add(this.tbxDe);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblEndereco);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxDe;
        private System.Windows.Forms.TextBox tbxPara;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}