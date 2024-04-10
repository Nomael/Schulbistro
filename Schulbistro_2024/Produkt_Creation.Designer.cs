namespace Schulbistro_2024
{
    partial class Produkt_Creation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.txt_Preis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_Kategorie = new System.Windows.Forms.ComboBox();
            this.lbl_Kategorie = new System.Windows.Forms.Label();
            this.cBox_Ampel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Allergen = new System.Windows.Forms.CheckedListBox();
            this.listBox_Zusatzstoffe = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(361, 520);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(115, 34);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(95, 10);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 22);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Info:";
            // 
            // txt_Info
            // 
            this.txt_Info.Location = new System.Drawing.Point(95, 38);
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.Size = new System.Drawing.Size(145, 22);
            this.txt_Info.TabIndex = 5;
            // 
            // txt_Preis
            // 
            this.txt_Preis.Location = new System.Drawing.Point(95, 66);
            this.txt_Preis.Name = "txt_Preis";
            this.txt_Preis.Size = new System.Drawing.Size(145, 22);
            this.txt_Preis.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preis:";
            // 
            // cBox_Kategorie
            // 
            this.cBox_Kategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Kategorie.FormattingEnabled = true;
            this.cBox_Kategorie.Location = new System.Drawing.Point(95, 126);
            this.cBox_Kategorie.Name = "cBox_Kategorie";
            this.cBox_Kategorie.Size = new System.Drawing.Size(146, 24);
            this.cBox_Kategorie.TabIndex = 9;
            // 
            // lbl_Kategorie
            // 
            this.lbl_Kategorie.AutoSize = true;
            this.lbl_Kategorie.Location = new System.Drawing.Point(12, 126);
            this.lbl_Kategorie.Name = "lbl_Kategorie";
            this.lbl_Kategorie.Size = new System.Drawing.Size(68, 16);
            this.lbl_Kategorie.TabIndex = 10;
            this.lbl_Kategorie.Text = "Kategorie:";
            // 
            // cBox_Ampel
            // 
            this.cBox_Ampel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Ampel.FormattingEnabled = true;
            this.cBox_Ampel.Location = new System.Drawing.Point(95, 184);
            this.cBox_Ampel.Name = "cBox_Ampel";
            this.cBox_Ampel.Size = new System.Drawing.Size(146, 24);
            this.cBox_Ampel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nutri-Score:";
            // 
            // listBox_Allergen
            // 
            this.listBox_Allergen.FormattingEnabled = true;
            this.listBox_Allergen.Location = new System.Drawing.Point(96, 247);
            this.listBox_Allergen.Name = "listBox_Allergen";
            this.listBox_Allergen.Size = new System.Drawing.Size(145, 123);
            this.listBox_Allergen.TabIndex = 13;
            // 
            // listBox_Zusatzstoffe
            // 
            this.listBox_Zusatzstoffe.FormattingEnabled = true;
            this.listBox_Zusatzstoffe.Location = new System.Drawing.Point(95, 408);
            this.listBox_Zusatzstoffe.Name = "listBox_Zusatzstoffe";
            this.listBox_Zusatzstoffe.Size = new System.Drawing.Size(145, 123);
            this.listBox_Zusatzstoffe.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Allergen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zusatzstoffe:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(361, 480);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 34);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Produkt_Creation
            // 
            this.ClientSize = new System.Drawing.Size(488, 566);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_Zusatzstoffe);
            this.Controls.Add(this.listBox_Allergen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBox_Ampel);
            this.Controls.Add(this.lbl_Kategorie);
            this.Controls.Add(this.cBox_Kategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Preis);
            this.Controls.Add(this.txt_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Name = "Produkt_Creation";
            this.Text = "Produkt Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Info;
        private System.Windows.Forms.TextBox txt_Preis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBox_Kategorie;
        private System.Windows.Forms.Label lbl_Kategorie;
        private System.Windows.Forms.ComboBox cBox_Ampel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox listBox_Allergen;
        private System.Windows.Forms.CheckedListBox listBox_Zusatzstoffe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
    }
}