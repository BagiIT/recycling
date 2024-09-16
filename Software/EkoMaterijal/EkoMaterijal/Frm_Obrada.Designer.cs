namespace EkoMaterijal
{
    partial class Frm_Obrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Obrada));
            this.nud_added = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mat = new System.Windows.Forms.Label();
            this.txt_newOstatak = new System.Windows.Forms.TextBox();
            this.txt_rezerviraniMat = new System.Windows.Forms.TextBox();
            this.btn_potvrdi = new System.Windows.Forms.Button();
            this.btn_odustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_added)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_added
            // 
            this.nud_added.BackColor = System.Drawing.Color.MintCream;
            this.nud_added.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_added.Location = new System.Drawing.Point(20, 139);
            this.nud_added.Margin = new System.Windows.Forms.Padding(6);
            this.nud_added.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_added.Name = "nud_added";
            this.nud_added.Size = new System.Drawing.Size(220, 34);
            this.nud_added.TabIndex = 31;
            this.nud_added.ValueChanged += new System.EventHandler(this.nud_added_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ostatak materijala za obradu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Obradjena kolicina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Materijali za obradu";
            // 
            // lbl_mat
            // 
            this.lbl_mat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mat.AutoSize = true;
            this.lbl_mat.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mat.Location = new System.Drawing.Point(368, 12);
            this.lbl_mat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mat.Name = "lbl_mat";
            this.lbl_mat.Size = new System.Drawing.Size(204, 65);
            this.lbl_mat.TabIndex = 24;
            this.lbl_mat.Text = "Platsika";
            // 
            // txt_newOstatak
            // 
            this.txt_newOstatak.BackColor = System.Drawing.Color.MintCream;
            this.txt_newOstatak.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_newOstatak.Location = new System.Drawing.Point(20, 265);
            this.txt_newOstatak.Margin = new System.Windows.Forms.Padding(6);
            this.txt_newOstatak.Name = "txt_newOstatak";
            this.txt_newOstatak.ReadOnly = true;
            this.txt_newOstatak.Size = new System.Drawing.Size(269, 34);
            this.txt_newOstatak.TabIndex = 23;
            // 
            // txt_rezerviraniMat
            // 
            this.txt_rezerviraniMat.BackColor = System.Drawing.Color.MintCream;
            this.txt_rezerviraniMat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_rezerviraniMat.Location = new System.Drawing.Point(20, 43);
            this.txt_rezerviraniMat.Margin = new System.Windows.Forms.Padding(6);
            this.txt_rezerviraniMat.Name = "txt_rezerviraniMat";
            this.txt_rezerviraniMat.ReadOnly = true;
            this.txt_rezerviraniMat.Size = new System.Drawing.Size(269, 34);
            this.txt_rezerviraniMat.TabIndex = 21;
            // 
            // btn_potvrdi
            // 
            this.btn_potvrdi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_potvrdi.BackColor = System.Drawing.Color.MintCream;
            this.btn_potvrdi.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_potvrdi.Location = new System.Drawing.Point(252, 324);
            this.btn_potvrdi.Margin = new System.Windows.Forms.Padding(6);
            this.btn_potvrdi.Name = "btn_potvrdi";
            this.btn_potvrdi.Size = new System.Drawing.Size(320, 50);
            this.btn_potvrdi.TabIndex = 20;
            this.btn_potvrdi.Text = "POTVRDI";
            this.btn_potvrdi.UseVisualStyleBackColor = false;
            this.btn_potvrdi.Click += new System.EventHandler(this.btn_potvrdi_Click);
            // 
            // btn_odustani
            // 
            this.btn_odustani.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_odustani.BackColor = System.Drawing.Color.MintCream;
            this.btn_odustani.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odustani.Location = new System.Drawing.Point(20, 324);
            this.btn_odustani.Margin = new System.Windows.Forms.Padding(6);
            this.btn_odustani.Name = "btn_odustani";
            this.btn_odustani.Size = new System.Drawing.Size(220, 50);
            this.btn_odustani.TabIndex = 19;
            this.btn_odustani.Text = "ODUSTANI";
            this.btn_odustani.UseVisualStyleBackColor = false;
            this.btn_odustani.Click += new System.EventHandler(this.btn_odustani_Click);
            // 
            // Frm_Obrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(587, 389);
            this.Controls.Add(this.nud_added);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_mat);
            this.Controls.Add(this.txt_newOstatak);
            this.Controls.Add(this.txt_rezerviraniMat);
            this.Controls.Add(this.btn_potvrdi);
            this.Controls.Add(this.btn_odustani);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Obrada";
            this.Text = "Frm_Obrada";
            this.Load += new System.EventHandler(this.Frm_Obrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_added)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_added;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mat;
        private System.Windows.Forms.TextBox txt_newOstatak;
        private System.Windows.Forms.TextBox txt_rezerviraniMat;
        private System.Windows.Forms.Button btn_potvrdi;
        private System.Windows.Forms.Button btn_odustani;
    }
}