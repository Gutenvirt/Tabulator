using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabulator2
{
    public partial class FrmMain : Form
    {
        int tableNum = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void cmdParse_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Processing";

            double fontSize = 0.0;
            double.TryParse(txtFontSize.Text, out fontSize);

            string[,] parsedData = DataParser.Parser(Clipboard.GetText(TextDataFormat.Text));
            string htmlTable = HtmlFunctions.CreateHtmlTable(parsedData,
                txtTableNumber.Text,
                txtTableName.Text,
                txtTableNotes.Text,
                cbHasColumnTitles.Checked,
                cbExtraColRow.Checked,
                cbHasSummaryRow.Checked,
                cbRowTitles.Checked,
                cbBandedRows.Checked,
                fontSize,
                txtTableWidth.Text);

            HtmlFragment.CopyToClipboard(htmlTable);

            tableNum++;
            txtTableNumber.Text = "Table " + tableNum;

            lblStatus.Text = "Ready";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtTableNumber.Text = "Table " + tableNum;
            this.ActiveControl = txtTableNumber;
        }
    }
}
