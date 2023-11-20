namespace kişi_arama_836
{
    partial class Form1
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
            this.btnVarMi = new System.Windows.Forms.Button();
            this.lbİsim = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblKac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVarMi
            // 
            this.btnVarMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVarMi.Location = new System.Drawing.Point(196, 12);
            this.btnVarMi.Name = "btnVarMi";
            this.btnVarMi.Size = new System.Drawing.Size(161, 110);
            this.btnVarMi.TabIndex = 7;
            this.btnVarMi.Text = "Kişiyi ara ";
            this.btnVarMi.UseVisualStyleBackColor = true;
            this.btnVarMi.Click += new System.EventHandler(this.btnVarMi_Click);
            // 
            // lbİsim
            // 
            this.lbİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbİsim.FormattingEnabled = true;
            this.lbİsim.ItemHeight = 24;
            this.lbİsim.Items.AddRange(new object[] {
            "İlayda",
            "Ensar",
            "İkra",
            "Eslem",
            "Dİlda",
            "Zeynep",
            "Duygun",
            "Dayana",
            "Aren",
            "İlayda",
            "Eslem",
            "Dilda",
            "Ensar",
            "Zeynep",
            "Duygun",
            "Ensar",
            "İlayda",
            "Aren"});
            this.lbİsim.Location = new System.Drawing.Point(12, 12);
            this.lbİsim.Name = "lbİsim";
            this.lbİsim.Size = new System.Drawing.Size(160, 244);
            this.lbİsim.TabIndex = 6;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(382, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(172, 20);
            this.txtAra.TabIndex = 5;
            // 
            // lblKac
            // 
            this.lblKac.AutoSize = true;
            this.lblKac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKac.Location = new System.Drawing.Point(8, 305);
            this.lblKac.Name = "lblKac";
            this.lblKac.Size = new System.Drawing.Size(89, 24);
            this.lblKac.TabIndex = 4;
            this.lblKac.Text = "... Kişi var";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVarMi);
            this.Controls.Add(this.lbİsim);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblKac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVarMi;
        private System.Windows.Forms.ListBox lbİsim;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblKac;
    }
}

