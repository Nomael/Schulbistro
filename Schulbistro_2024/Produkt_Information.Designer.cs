namespace Schulbistro_2024
{
    partial class Produkt_Information
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_Ampel = new System.Windows.Forms.Label();
            this.lbl_Allegen = new System.Windows.Forms.Label();
            this.lbl_Zusatzstoffe = new System.Windows.Forms.Label();
            this.lbl_Kategorie = new System.Windows.Forms.Label();
            this.lbl_Preis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(361, 520);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(115, 34);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(16, 39);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(102, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "lbl_Name";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(21, 68);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(62, 20);
            this.lbl_Info.TabIndex = 2;
            this.lbl_Info.Text = "lbl_Info";
            // 
            // lbl_Ampel
            // 
            this.lbl_Ampel.AutoSize = true;
            this.lbl_Ampel.Location = new System.Drawing.Point(25, 173);
            this.lbl_Ampel.Name = "lbl_Ampel";
            this.lbl_Ampel.Size = new System.Drawing.Size(67, 16);
            this.lbl_Ampel.TabIndex = 3;
            this.lbl_Ampel.Text = "lbl_Ampel";
            // 
            // lbl_Allegen
            // 
            this.lbl_Allegen.AutoSize = true;
            this.lbl_Allegen.Location = new System.Drawing.Point(25, 216);
            this.lbl_Allegen.Name = "lbl_Allegen";
            this.lbl_Allegen.Size = new System.Drawing.Size(78, 16);
            this.lbl_Allegen.TabIndex = 4;
            this.lbl_Allegen.Text = "lbl_Allergen";
            // 
            // lbl_Zusatzstoffe
            // 
            this.lbl_Zusatzstoffe.AutoSize = true;
            this.lbl_Zusatzstoffe.Location = new System.Drawing.Point(25, 259);
            this.lbl_Zusatzstoffe.Name = "lbl_Zusatzstoffe";
            this.lbl_Zusatzstoffe.Size = new System.Drawing.Size(99, 16);
            this.lbl_Zusatzstoffe.TabIndex = 5;
            this.lbl_Zusatzstoffe.Text = "lbl_Zusatzstoffe";
            // 
            // lbl_Kategorie
            // 
            this.lbl_Kategorie.AutoSize = true;
            this.lbl_Kategorie.Location = new System.Drawing.Point(25, 133);
            this.lbl_Kategorie.Name = "lbl_Kategorie";
            this.lbl_Kategorie.Size = new System.Drawing.Size(86, 16);
            this.lbl_Kategorie.TabIndex = 6;
            this.lbl_Kategorie.Text = "lbl_Kategorie";
            // 
            // lbl_Preis
            // 
            this.lbl_Preis.AutoSize = true;
            this.lbl_Preis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preis.Location = new System.Drawing.Point(21, 88);
            this.lbl_Preis.Name = "lbl_Preis";
            this.lbl_Preis.Size = new System.Drawing.Size(74, 20);
            this.lbl_Preis.TabIndex = 7;
            this.lbl_Preis.Text = "lbl_Preis";
            // 
            // Produkt_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 566);
            this.Controls.Add(this.lbl_Preis);
            this.Controls.Add(this.lbl_Kategorie);
            this.Controls.Add(this.lbl_Zusatzstoffe);
            this.Controls.Add(this.lbl_Allegen);
            this.Controls.Add(this.lbl_Ampel);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Produkt_Information";
            this.Text = "Produkt Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_Ampel;
        private System.Windows.Forms.Label lbl_Allegen;
        private System.Windows.Forms.Label lbl_Zusatzstoffe;
        private System.Windows.Forms.Label lbl_Kategorie;
        private System.Windows.Forms.Label lbl_Preis;
    }
}