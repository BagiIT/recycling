namespace EkoMaterijal
{
    partial class Frm_zaprimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_zaprimi));
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_TrenStanje = new System.Windows.Forms.TextBox();
            this.txt_Kapac = new System.Windows.Forms.TextBox();
            this.txt_NovStanj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mat = new System.Windows.Forms.Label();
            this.nud_added = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_added)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.Color.MintCream;
            this.btn_cancle.Location = new System.Drawing.Point(15, 318);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(288, 62);
            this.btn_cancle.TabIndex = 0;
            this.btn_cancle.Text = "ODUSTANI";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.MintCream;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_confirm.Location = new System.Drawing.Point(315, 318);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(6);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(380, 62);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "POTVRDI";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_TrenStanje
            // 
            this.txt_TrenStanje.BackColor = System.Drawing.Color.MintCream;
            this.txt_TrenStanje.Location = new System.Drawing.Point(15, 43);
            this.txt_TrenStanje.Margin = new System.Windows.Forms.Padding(6);
            this.txt_TrenStanje.Name = "txt_TrenStanje";
            this.txt_TrenStanje.ReadOnly = true;
            this.txt_TrenStanje.Size = new System.Drawing.Size(269, 34);
            this.txt_TrenStanje.TabIndex = 2;
            // 
            // txt_Kapac
            // 
            this.txt_Kapac.BackColor = System.Drawing.Color.MintCream;
            this.txt_Kapac.Location = new System.Drawing.Point(426, 43);
            this.txt_Kapac.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Kapac.Name = "txt_Kapac";
            this.txt_Kapac.ReadOnly = true;
            this.txt_Kapac.Size = new System.Drawing.Size(269, 34);
            this.txt_Kapac.TabIndex = 3;
            // 
            // txt_NovStanj
            // 
            this.txt_NovStanj.BackColor = System.Drawing.Color.MintCream;
            this.txt_NovStanj.Location = new System.Drawing.Point(15, 272);
            this.txt_NovStanj.Margin = new System.Windows.Forms.Padding(6);
            this.txt_NovStanj.Name = "txt_NovStanj";
            this.txt_NovStanj.ReadOnly = true;
            this.txt_NovStanj.Size = new System.Drawing.Size(269, 34);
            this.txt_NovStanj.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Novo stanje skladista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trenutno na skladistu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(504, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kapacitet skladista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dodana kolicina";
            // 
            // lbl_mat
            // 
            this.lbl_mat.AutoSize = true;
            this.lbl_mat.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mat.Location = new System.Drawing.Point(498, 149);
            this.lbl_mat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mat.Name = "lbl_mat";
            this.lbl_mat.Size = new System.Drawing.Size(204, 65);
            this.lbl_mat.TabIndex = 10;
            this.lbl_mat.Text = "Platsika";
            // 
            // nud_added
            // 
            this.nud_added.BackColor = System.Drawing.Color.MintCream;
            this.nud_added.Location = new System.Drawing.Point(15, 149);
            this.nud_added.Margin = new System.Windows.Forms.Padding(6);
            this.nud_added.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_added.Name = "nud_added";
            this.nud_added.Size = new System.Drawing.Size(269, 34);
            this.nud_added.TabIndex = 11;
            this.nud_added.ValueChanged += new System.EventHandler(this.nud_added_ValueChanged);
            // 
            // Frm_zaprimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(710, 386);
            this.Controls.Add(this.nud_added);
            this.Controls.Add(this.lbl_mat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NovStanj);
            this.Controls.Add(this.txt_Kapac);
            this.Controls.Add(this.txt_TrenStanje);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_cancle);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_zaprimi";
            this.Text = "Frm_zaprimi";
            this.Load += new System.EventHandler(this.Frm_zaprimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_added)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_TrenStanje;
        private System.Windows.Forms.TextBox txt_Kapac;
        private System.Windows.Forms.TextBox txt_NovStanj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mat;
        private System.Windows.Forms.NumericUpDown nud_added;
    }
}