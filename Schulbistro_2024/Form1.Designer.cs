namespace Schulbistro_2024
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_HeadName = new System.Windows.Forms.Label();
            this.tControl_Content = new System.Windows.Forms.TabControl();
            this.tPage_Produktsortiment = new System.Windows.Forms.TabPage();
            this.tLPanel_Produkte = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.dGView_Produkte = new System.Windows.Forms.DataGridView();
            this.tPage_Login = new System.Windows.Forms.TabPage();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tBox_Passwort = new System.Windows.Forms.TextBox();
            this.tBox_Account = new System.Windows.Forms.TextBox();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.tPage_Info = new System.Windows.Forms.TabPage();
            this.tPage_PVerwaltung = new System.Windows.Forms.TabPage();
            this.tPage_Stats = new System.Windows.Forms.TabPage();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.tLPanel_Main.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.tControl_Content.SuspendLayout();
            this.tPage_Produktsortiment.SuspendLayout();
            this.tLPanel_Produkte.SuspendLayout();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Produkte)).BeginInit();
            this.tPage_Login.SuspendLayout();
            this.tPage_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPanel_Main
            // 
            this.tLPanel_Main.ColumnCount = 1;
            this.tLPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Main.Controls.Add(this.panel_Header, 0, 0);
            this.tLPanel_Main.Controls.Add(this.tControl_Content, 0, 1);
            this.tLPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tLPanel_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tLPanel_Main.Name = "tLPanel_Main";
            this.tLPanel_Main.RowCount = 2;
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Main.Size = new System.Drawing.Size(1097, 471);
            this.tLPanel_Main.TabIndex = 0;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Header.Controls.Add(this.lbl_HeadName);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header.Location = new System.Drawing.Point(4, 4);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1089, 60);
            this.panel_Header.TabIndex = 0;
            // 
            // lbl_HeadName
            // 
            this.lbl_HeadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_HeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadName.ForeColor = System.Drawing.Color.White;
            this.lbl_HeadName.Location = new System.Drawing.Point(0, 0);
            this.lbl_HeadName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeadName.Name = "lbl_HeadName";
            this.lbl_HeadName.Size = new System.Drawing.Size(1089, 60);
            this.lbl_HeadName.TabIndex = 0;
            this.lbl_HeadName.Text = "Schulbistro Manna";
            this.lbl_HeadName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tControl_Content
            // 
            this.tControl_Content.Controls.Add(this.tPage_Produktsortiment);
            this.tControl_Content.Controls.Add(this.tPage_Login);
            this.tControl_Content.Controls.Add(this.tPage_Info);
            this.tControl_Content.Controls.Add(this.tPage_PVerwaltung);
            this.tControl_Content.Controls.Add(this.tPage_Stats);
            this.tControl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tControl_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tControl_Content.Location = new System.Drawing.Point(3, 71);
            this.tControl_Content.Name = "tControl_Content";
            this.tControl_Content.SelectedIndex = 0;
            this.tControl_Content.Size = new System.Drawing.Size(1091, 397);
            this.tControl_Content.TabIndex = 1;
            this.tControl_Content.TabStop = false;
            // 
            // tPage_Produktsortiment
            // 
            this.tPage_Produktsortiment.Controls.Add(this.tLPanel_Produkte);
            this.tPage_Produktsortiment.Location = new System.Drawing.Point(4, 27);
            this.tPage_Produktsortiment.Name = "tPage_Produktsortiment";
            this.tPage_Produktsortiment.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Produktsortiment.Size = new System.Drawing.Size(1083, 366);
            this.tPage_Produktsortiment.TabIndex = 0;
            this.tPage_Produktsortiment.Text = "Produktsortiment";
            this.tPage_Produktsortiment.UseVisualStyleBackColor = true;
            // 
            // tLPanel_Produkte
            // 
            this.tLPanel_Produkte.ColumnCount = 1;
            this.tLPanel_Produkte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Produkte.Controls.Add(this.panel_Search, 0, 0);
            this.tLPanel_Produkte.Controls.Add(this.dGView_Produkte, 0, 1);
            this.tLPanel_Produkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Produkte.Location = new System.Drawing.Point(3, 3);
            this.tLPanel_Produkte.Name = "tLPanel_Produkte";
            this.tLPanel_Produkte.RowCount = 2;
            this.tLPanel_Produkte.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Produkte.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Produkte.Size = new System.Drawing.Size(1077, 360);
            this.tLPanel_Produkte.TabIndex = 0;
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.tBox_Search);
            this.panel_Search.Controls.Add(this.lbl_Search);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Search.Location = new System.Drawing.Point(3, 3);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(1071, 48);
            this.panel_Search.TabIndex = 0;
            // 
            // tBox_Search
            // 
            this.tBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Search.Location = new System.Drawing.Point(184, 7);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(216, 36);
            this.tBox_Search.TabIndex = 1;
            this.tBox_Search.TabStop = false;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(3, 10);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(175, 29);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Produktsuche:";
            // 
            // dGView_Produkte
            // 
            this.dGView_Produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Produkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGView_Produkte.Location = new System.Drawing.Point(3, 57);
            this.dGView_Produkte.Name = "dGView_Produkte";
            this.dGView_Produkte.RowHeadersWidth = 51;
            this.dGView_Produkte.RowTemplate.Height = 24;
            this.dGView_Produkte.Size = new System.Drawing.Size(1071, 300);
            this.dGView_Produkte.TabIndex = 1;
            // 
            // tPage_Login
            // 
            this.tPage_Login.Controls.Add(this.lbl_Passwort);
            this.tPage_Login.Controls.Add(this.btn_Login);
            this.tPage_Login.Controls.Add(this.lbl_Account);
            this.tPage_Login.Controls.Add(this.tBox_Account);
            this.tPage_Login.Controls.Add(this.tBox_Passwort);
            this.tPage_Login.Location = new System.Drawing.Point(4, 27);
            this.tPage_Login.Name = "tPage_Login";
            this.tPage_Login.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Login.Size = new System.Drawing.Size(1083, 366);
            this.tPage_Login.TabIndex = 1;
            this.tPage_Login.Text = "Login";
            this.tPage_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(454, 203);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(175, 41);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.TabStop = false;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // tBox_Passwort
            // 
            this.tBox_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBox_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Passwort.Location = new System.Drawing.Point(562, 112);
            this.tBox_Passwort.Name = "tBox_Passwort";
            this.tBox_Passwort.PasswordChar = '*';
            this.tBox_Passwort.Size = new System.Drawing.Size(228, 36);
            this.tBox_Passwort.TabIndex = 3;
            this.tBox_Passwort.TabStop = false;
            // 
            // tBox_Account
            // 
            this.tBox_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBox_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Account.Location = new System.Drawing.Point(562, 45);
            this.tBox_Account.Name = "tBox_Account";
            this.tBox_Account.Size = new System.Drawing.Size(228, 36);
            this.tBox_Account.TabIndex = 2;
            this.tBox_Account.TabStop = false;
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.Location = new System.Drawing.Point(356, 115);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(124, 29);
            this.lbl_Passwort.TabIndex = 1;
            this.lbl_Passwort.Text = "Passwort:";
            // 
            // lbl_Account
            // 
            this.lbl_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(356, 48);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(187, 29);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "Account Name:";
            // 
            // tPage_Info
            // 
            this.tPage_Info.Controls.Add(this.lbl_AccountName);
            this.tPage_Info.Controls.Add(this.lbl_Info);
            this.tPage_Info.Location = new System.Drawing.Point(4, 27);
            this.tPage_Info.Name = "tPage_Info";
            this.tPage_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Info.Size = new System.Drawing.Size(1083, 366);
            this.tPage_Info.TabIndex = 2;
            this.tPage_Info.Text = "Info";
            this.tPage_Info.UseVisualStyleBackColor = true;
            // 
            // tPage_PVerwaltung
            // 
            this.tPage_PVerwaltung.Location = new System.Drawing.Point(4, 27);
            this.tPage_PVerwaltung.Name = "tPage_PVerwaltung";
            this.tPage_PVerwaltung.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PVerwaltung.Size = new System.Drawing.Size(1083, 366);
            this.tPage_PVerwaltung.TabIndex = 3;
            this.tPage_PVerwaltung.Text = "Produkt Verwaltung";
            this.tPage_PVerwaltung.UseVisualStyleBackColor = true;
            // 
            // tPage_Stats
            // 
            this.tPage_Stats.Location = new System.Drawing.Point(4, 27);
            this.tPage_Stats.Name = "tPage_Stats";
            this.tPage_Stats.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Stats.Size = new System.Drawing.Size(1083, 366);
            this.tPage_Stats.TabIndex = 4;
            this.tPage_Stats.Text = "Statistik";
            this.tPage_Stats.UseVisualStyleBackColor = true;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(42, 63);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(186, 29);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "Angemeldet als:";
            // 
            // lbl_AccountName
            // 
            this.lbl_AccountName.AutoSize = true;
            this.lbl_AccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountName.Location = new System.Drawing.Point(245, 63);
            this.lbl_AccountName.Name = "lbl_AccountName";
            this.lbl_AccountName.Size = new System.Drawing.Size(72, 29);
            this.lbl_AccountName.TabIndex = 1;
            this.lbl_AccountName.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 471);
            this.Controls.Add(this.tLPanel_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Schulbistro";
            this.tLPanel_Main.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.tControl_Content.ResumeLayout(false);
            this.tPage_Produktsortiment.ResumeLayout(false);
            this.tLPanel_Produkte.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Produkte)).EndInit();
            this.tPage_Login.ResumeLayout(false);
            this.tPage_Login.PerformLayout();
            this.tPage_Info.ResumeLayout(false);
            this.tPage_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPanel_Main;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_HeadName;
        private System.Windows.Forms.TabControl tControl_Content;
        private System.Windows.Forms.TabPage tPage_Produktsortiment;
        private System.Windows.Forms.TabPage tPage_Login;
        private System.Windows.Forms.TabPage tPage_Info;
        private System.Windows.Forms.TabPage tPage_PVerwaltung;
        private System.Windows.Forms.TabPage tPage_Stats;
        private System.Windows.Forms.TableLayoutPanel tLPanel_Produkte;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridView dGView_Produkte;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tBox_Passwort;
        private System.Windows.Forms.TextBox tBox_Account;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_AccountName;
    }
}

