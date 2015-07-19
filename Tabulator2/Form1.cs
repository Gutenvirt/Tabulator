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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdParse_Click(object sender, EventArgs e)
        {

            string[,] parsedData = DataParser.Parser(Clipboard.GetText(TextDataFormat.Text));
            string htmlTable = HtmlFunctions.CreateHtmlTable(parsedData, txtTableNumber.Text, txtTableName.Text, txtTableNotes.Text, cbHasColumnTitles.Checked, cbExtraColRow.Checked ,cbHasSummaryRow.Checked,cbRowTitles.Checked);
            HtmlFragment.CopyToClipboard(htmlTable);
        }
    }
}
