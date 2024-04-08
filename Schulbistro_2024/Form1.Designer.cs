namespace Pulsdaten
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
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Panel_Buttons = new System.Windows.Forms.Panel();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.lbl_HeadName = new System.Windows.Forms.Label();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.btn_SimulateData = new System.Windows.Forms.Button();
            this.btn_CheckUser = new System.Windows.Forms.Button();
            this.tLPanel_Main.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.Panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPanel_Main
            // 
            this.tLPanel_Main.ColumnCount = 1;
            this.tLPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Main.Controls.Add(this.Panel_Header, 0, 0);
            this.tLPanel_Main.Controls.Add(this.Panel_Buttons, 0, 1);
            this.tLPanel_Main.Controls.Add(this.Panel_Content, 0, 2);
            this.tLPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tLPanel_Main.Name = "tLPanel_Main";
            this.tLPanel_Main.RowCount = 3;
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.516887F));
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.810573F));
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.67254F));
            this.tLPanel_Main.Size = new System.Drawing.Size(1264, 681);
            this.tLPanel_Main.TabIndex = 0;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_Header.Controls.Add(this.lbl_HeadName);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Header.Location = new System.Drawing.Point(3, 3);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1258, 52);
            this.Panel_Header.TabIndex = 0;
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.Controls.Add(this.btn_CheckUser);
            this.Panel_Buttons.Controls.Add(this.btn_SimulateData);
            this.Panel_Buttons.Controls.Add(this.btn_CreateUser);
            this.Panel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Buttons.Location = new System.Drawing.Point(3, 61);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(1258, 54);
            this.Panel_Buttons.TabIndex = 1;
            // 
            // Panel_Content
            // 
            this.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Content.Location = new System.Drawing.Point(3, 121);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(1258, 557);
            this.Panel_Content.TabIndex = 2;
            // 
            // lbl_HeadName
            // 
            this.lbl_HeadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_HeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadName.ForeColor = System.Drawing.Color.White;
            this.lbl_HeadName.Location = new System.Drawing.Point(0, 0);
            this.lbl_HeadName.Name = "lbl_HeadName";
            this.lbl_HeadName.Size = new System.Drawing.Size(1258, 52);
            this.lbl_HeadName.TabIndex = 0;
            this.lbl_HeadName.Text = "Pulsdaten";
            this.lbl_HeadName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(155, 6);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(117, 42);
            this.btn_CreateUser.TabIndex = 0;
            this.btn_CreateUser.TabStop = false;
            this.btn_CreateUser.Text = "Nutzer erstellen";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            // 
            // btn_SimulateData
            // 
            this.btn_SimulateData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SimulateData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SimulateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SimulateData.Location = new System.Drawing.Point(558, 6);
            this.btn_SimulateData.Name = "btn_SimulateData";
            this.btn_SimulateData.Size = new System.Drawing.Size(130, 42);
            this.btn_SimulateData.TabIndex = 1;
            this.btn_SimulateData.TabStop = false;
            this.btn_SimulateData.Text = "Daten Simulieren";
            this.btn_SimulateData.UseVisualStyleBackColor = true;
            // 
            // btn_CheckUser
            // 
            this.btn_CheckUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CheckUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckUser.Location = new System.Drawing.Point(940, 6);
            this.btn_CheckUser.Name = "btn_CheckUser";
            this.btn_CheckUser.Size = new System.Drawing.Size(117, 42);
            this.btn_CheckUser.TabIndex = 2;
            this.btn_CheckUser.TabStop = false;
            this.btn_CheckUser.Text = "Nutzerdaten";
            this.btn_CheckUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tLPanel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pulsdaten";
            this.tLPanel_Main.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPanel_Main;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label lbl_HeadName;
        private System.Windows.Forms.Panel Panel_Buttons;
        private System.Windows.Forms.Panel Panel_Content;
        private System.Windows.Forms.Button btn_CheckUser;
        private System.Windows.Forms.Button btn_SimulateData;
        private System.Windows.Forms.Button btn_CreateUser;
    }
}

