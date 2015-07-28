namespace Tabulator2
{
    partial class FrmMain
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
            this.cmdParse = new System.Windows.Forms.Button();
            this.cbHasColumnTitles = new System.Windows.Forms.CheckBox();
            this.cbHasSummaryRow = new System.Windows.Forms.CheckBox();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableNotes = new System.Windows.Forms.TextBox();
            this.cbRowTitles = new System.Windows.Forms.CheckBox();
            this.cbExtraColRow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableWidth = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbBandedRows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdParse
            // 
            this.cmdParse.Location = new System.Drawing.Point(262, 10);
            this.cmdParse.Name = "cmdParse";
            this.cmdParse.Size = new System.Drawing.Size(153, 23);
            this.cmdParse.TabIndex = 7;
            this.cmdParse.Text = "Parse Clipboard";
            this.cmdParse.UseVisualStyleBackColor = true;
            this.cmdParse.Click += new System.EventHandler(this.cmdParse_Click);
            // 
            // cbHasColumnTitles
            // 
            this.cbHasColumnTitles.AutoSize = true;
            this.cbHasColumnTitles.Checked = true;
            this.cbHasColumnTitles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHasColumnTitles.Location = new System.Drawing.Point(12, 163);
            this.cbHasColumnTitles.Name = "cbHasColumnTitles";
            this.cbHasColumnTitles.Size = new System.Drawing.Size(104, 17);
            this.cbHasColumnTitles.TabIndex = 3;
            this.cbHasColumnTitles.Text = "Column Titles -->";
            this.cbHasColumnTitles.UseVisualStyleBackColor = true;
            // 
            // cbHasSummaryRow
            // 
            this.cbHasSummaryRow.AutoSize = true;
            this.cbHasSummaryRow.Checked = true;
            this.cbHasSummaryRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHasSummaryRow.Location = new System.Drawing.Point(12, 209);
            this.cbHasSummaryRow.Name = "cbHasSummaryRow";
            this.cbHasSummaryRow.Size = new System.Drawing.Size(94, 17);
            this.cbHasSummaryRow.TabIndex = 6;
            this.cbHasSummaryRow.Text = "Summary Row";
            this.cbHasSummaryRow.UseVisualStyleBackColor = true;
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(379, 164);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(36, 20);
            this.txtFontSize.TabIndex = 6;
            this.txtFontSize.Text = "11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Font Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(80, 38);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(335, 20);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.Text = "Results of Analysis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Table Number:";
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(80, 12);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(176, 20);
            this.txtTableNumber.TabIndex = 0;
            this.txtTableNumber.Text = "Table 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Table Notes:";
            // 
            // txtTableNotes
            // 
            this.txtTableNotes.AcceptsReturn = true;
            this.txtTableNotes.Location = new System.Drawing.Point(80, 64);
            this.txtTableNotes.Multiline = true;
            this.txtTableNotes.Name = "txtTableNotes";
            this.txtTableNotes.Size = new System.Drawing.Size(335, 93);
            this.txtTableNotes.TabIndex = 2;
            // 
            // cbRowTitles
            // 
            this.cbRowTitles.AutoSize = true;
            this.cbRowTitles.Checked = true;
            this.cbRowTitles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRowTitles.Location = new System.Drawing.Point(12, 186);
            this.cbRowTitles.Name = "cbRowTitles";
            this.cbRowTitles.Size = new System.Drawing.Size(76, 17);
            this.cbRowTitles.TabIndex = 5;
            this.cbRowTitles.Text = "Row Titles";
            this.cbRowTitles.UseVisualStyleBackColor = true;
            // 
            // cbExtraColRow
            // 
            this.cbExtraColRow.AutoSize = true;
            this.cbExtraColRow.Location = new System.Drawing.Point(112, 163);
            this.cbExtraColRow.Name = "cbExtraColRow";
            this.cbExtraColRow.Size = new System.Drawing.Size(98, 17);
            this.cbExtraColRow.TabIndex = 4;
            this.cbExtraColRow.Text = "Double Header";
            this.cbExtraColRow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Table Width:";
            // 
            // txtTableWidth
            // 
            this.txtTableWidth.Location = new System.Drawing.Point(379, 190);
            this.txtTableWidth.Name = "txtTableWidth";
            this.txtTableWidth.Size = new System.Drawing.Size(36, 20);
            this.txtTableWidth.TabIndex = 15;
            this.txtTableWidth.Text = "100%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(376, 214);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Ready";
            // 
            // cbBandedRows
            // 
            this.cbBandedRows.AutoSize = true;
            this.cbBandedRows.Location = new System.Drawing.Point(112, 186);
            this.cbBandedRows.Name = "cbBandedRows";
            this.cbBandedRows.Size = new System.Drawing.Size(93, 17);
            this.cbBandedRows.TabIndex = 18;
            this.cbBandedRows.Text = "Banded Rows";
            this.cbBandedRows.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 236);
            this.Controls.Add(this.cbBandedRows);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableWidth);
            this.Controls.Add(this.cbExtraColRow);
            this.Controls.Add(this.cbRowTitles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.cbHasSummaryRow);
            this.Controls.Add(this.cbHasColumnTitles);
            this.Controls.Add(this.cmdParse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabulator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdParse;
        private System.Windows.Forms.CheckBox cbHasColumnTitles;
        private System.Windows.Forms.CheckBox cbHasSummaryRow;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableNotes;
        private System.Windows.Forms.CheckBox cbRowTitles;
        private System.Windows.Forms.CheckBox cbExtraColRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableWidth;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbBandedRows;
    }
}

