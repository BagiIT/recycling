namespace EkoMaterijal
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.btn_obrada = new System.Windows.Forms.Button();
            this.btn_rezerviraj = new System.Windows.Forms.Button();
            this.btn_osvjezi = new System.Windows.Forms.Button();
            this.dgv_Materijali = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materijali)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Dodaj.BackColor = System.Drawing.Color.MintCream;
            this.btn_Dodaj.Location = new System.Drawing.Point(13, 228);
            this.btn_Dodaj.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(250, 75);
            this.btn_Dodaj.TabIndex = 0;
            this.btn_Dodaj.Text = "ZAPRIMI";
            this.btn_Dodaj.UseVisualStyleBackColor = false;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // btn_obrada
            // 
            this.btn_obrada.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_obrada.BackColor = System.Drawing.Color.MintCream;
            this.btn_obrada.Location = new System.Drawing.Point(275, 228);
            this.btn_obrada.Margin = new System.Windows.Forms.Padding(6);
            this.btn_obrada.Name = "btn_obrada";
            this.btn_obrada.Size = new System.Drawing.Size(250, 75);
            this.btn_obrada.TabIndex = 1;
            this.btn_obrada.Text = "OBRADA";
            this.btn_obrada.UseVisualStyleBackColor = false;
            this.btn_obrada.Click += new System.EventHandler(this.btn_obrada_Click);
            // 
            // btn_rezerviraj
            // 
            this.btn_rezerviraj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_rezerviraj.BackColor = System.Drawing.Color.MintCream;
            this.btn_rezerviraj.Location = new System.Drawing.Point(537, 228);
            this.btn_rezerviraj.Margin = new System.Windows.Forms.Padding(6);
            this.btn_rezerviraj.Name = "btn_rezerviraj";
            this.btn_rezerviraj.Size = new System.Drawing.Size(250, 75);
            this.btn_rezerviraj.TabIndex = 2;
            this.btn_rezerviraj.Text = "REZERVIRAJ";
            this.btn_rezerviraj.UseVisualStyleBackColor = false;
            this.btn_rezerviraj.Click += new System.EventHandler(this.btn_rezerviraj_Click);
            // 
            // btn_osvjezi
            // 
            this.btn_osvjezi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_osvjezi.BackColor = System.Drawing.Color.MintCream;
            this.btn_osvjezi.Location = new System.Drawing.Point(799, 228);
            this.btn_osvjezi.Margin = new System.Windows.Forms.Padding(6);
            this.btn_osvjezi.Name = "btn_osvjezi";
            this.btn_osvjezi.Size = new System.Drawing.Size(127, 75);
            this.btn_osvjezi.TabIndex = 4;
            this.btn_osvjezi.Text = "Osvjezi";
            this.btn_osvjezi.UseVisualStyleBackColor = false;
            this.btn_osvjezi.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Materijali
            // 
            this.dgv_Materijali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Materijali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Materijali.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_Materijali.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv_Materijali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Materijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materijali.Location = new System.Drawing.Point(15, 15);
            this.dgv_Materijali.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_Materijali.Name = "dgv_Materijali";
            this.dgv_Materijali.ReadOnly = true;
            this.dgv_Materijali.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgv_Materijali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Materijali.Size = new System.Drawing.Size(911, 201);
            this.dgv_Materijali.TabIndex = 3;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(941, 361);
            this.Controls.Add(this.btn_osvjezi);
            this.Controls.Add(this.dgv_Materijali);
            this.Controls.Add(this.btn_rezerviraj);
            this.Controls.Add(this.btn_obrada);
            this.Controls.Add(this.btn_Dodaj);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(957, 400);
            this.Name = "Frm_main";
            this.Text = "Glavno";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materijali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.Button btn_obrada;
        private System.Windows.Forms.Button btn_rezerviraj;
        private System.Windows.Forms.Button btn_osvjezi;
        private System.Windows.Forms.DataGridView dgv_Materijali;
    }
}