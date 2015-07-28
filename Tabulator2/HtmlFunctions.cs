using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.IO;

namespace Tabulator2
{
    public static class HtmlFunctions
    {
        public static string CreateHtmlTable(string[,] data, string tblNumber, string tblName, string tblNotes, bool hasColTitles, bool hasExtraColRow, bool hasSummaryRow, bool hasRowTitles, bool isBanded, double fontSize, string tWidth)
        {
            int nRows = data.GetLength(0);
            int nCols = data.GetLength(1);

            if (tWidth[tWidth.Length - 1] != '%')
                tWidth += '%';

            string tagHtmlStart = "<html>";
            string tagHtmlEnd = "</html>";
            string tagBodyStart = "<body>";
            string tagBodyEnd = "</body>";

            string tagHeading = "<head>" +
                                    "<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">" +
                                    "<meta content=\"Word.Document\" name=\"ProgId\">" +
                                    "<meta content=\"Microsoft Word 15\" name=\"Generator\">" +
                                "</head>";

            string tagStyleStart = "style='";
            string tagStyleNoLine = " ";
            string tagStyleDoubleLine = " border-bottom:double; ";
            string tagstyleThinLine = " border-bottom:solid thin; ";
            string tagStyleTopBottomLine = " border-top:solid thin; border-bottom:solid thin; ";
            string tagStyleBackground = " background:#F2F2F2; ";
            string tagStylePadding = " padding:0pt 5.4pt 0pt 5.4pt; ";
            string tagStyleEnd = "'";

            string tagAlignLeft = " valign=\"center\" align=\"left\" ";
            string tagAlignRight = " valign=\"center\" align=\"right\" ";

            string tagEnd = ">";

            string tagTDStart = "<td ";
            string tagTRStart = "<tr ";
            string tagTableStart = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=";
            string tagTableDataHeight = " style='height:16.5pt' ";
            string tagTableOtherHeight = " style='height:7pt' ";

            string tagPStart = "<p style='font-size:" + fontSize + "pt;font-family:\"Cambria\",serif'>";
            //string tagPStart = "<p style='font-size:" + fontSize + "pt;font-family:\"Courier New\",serif'>";


            if (fontSize < 7)
            {
                fontSize = 7;
            }

            string tagPEnd = "</p>";
            string tagBStart = "<b>";
            string tagBEnd = "</b>";
            string tagIStart = "<i>";
            string tagIEnd = "</i>";
            string tagRowEnd = "</tr>";
            string tagDataEnd = "</td>";
            string tagTableEnd = "</table>";

            var sOut = new StringBuilder();

            sOut.AppendLine(tagHtmlStart);
            sOut.AppendLine(tagHeading);
            sOut.AppendLine(tagBodyStart);

            sOut.AppendLine(tagTableStart + tWidth + tagEnd);
            sOut.AppendLine(tagTRStart + tagTableOtherHeight + tagEnd);
            sOut.AppendLine(tagTDStart + "colspan=\"" + nCols + "\"" + tagStyleStart + tagStylePadding + tagStyleNoLine + tagStyleEnd + tagAlignLeft + tagEnd);
            sOut.AppendLine(tagPStart + tblNumber + tagPEnd);
            sOut.AppendLine(tagDataEnd);
            sOut.AppendLine(tagRowEnd);

            sOut.AppendLine(tagTRStart + tagTableOtherHeight + tagEnd);
            sOut.AppendLine(tagTDStart + "colspan=\"" + nCols + "\"" + tagStyleStart + tagStylePadding + tagStyleDoubleLine + tagStyleEnd + tagAlignLeft + tagEnd);
            sOut.AppendLine(tagPStart + tagIStart + tblName + tagIEnd + tagPEnd);
            sOut.AppendLine(tagDataEnd);
            sOut.AppendLine(tagRowEnd);

            for (int i = 0; i < nRows; i++)
            {
                sOut.AppendLine(tagTRStart + tagTableDataHeight + tagEnd);

                if (isBanded && i % 2 == 1)
                {
                    tagStyleStart += tagStyleBackground;

                    if (hasColTitles && i == 0)
                        tagStyleStart = "style='";

                    if (hasExtraColRow && i == 1)
                        tagStyleStart = "style='";

                    if (hasSummaryRow && i == nRows - 1)
                        tagStyleStart = "style='";
                }
                else
                {
                    tagStyleStart = "style='";
                }

                for (int j = 0; j < nCols; j++)
                {
                    sOut.AppendLine(tagTDStart);

                    if (hasExtraColRow & i < 2)
                    {
                        switch (i)
                        {
                            case 0:
                                if (j == 0 && hasRowTitles)
                                    sOut.Append(tagStyleStart + tagStylePadding + tagStyleNoLine + tagStyleEnd + tagAlignLeft + tagEnd);
                                else
                                    sOut.Append(tagStyleStart + tagStylePadding + tagStyleNoLine + tagStyleEnd + tagAlignRight + tagEnd);
                                break;
                            case 1:
                                if (j == 0 && hasRowTitles)
                                    sOut.Append(tagStyleStart + tagStylePadding + tagstyleThinLine + tagStyleEnd + tagAlignLeft + tagEnd);
                                else
                                    sOut.Append(tagStyleStart + tagStylePadding + tagstyleThinLine + tagStyleEnd + tagAlignRight + tagEnd);
                                break;
                        }

                        sOut.Append(tagPStart + tagBStart + data[i, j] + tagBEnd + tagPEnd);
                        continue;
                    }


                    if (i == 0 && hasColTitles)
                    {
                        if (j == 0 && hasRowTitles)
                            sOut.Append(tagStyleStart + tagStylePadding + tagstyleThinLine + tagStyleEnd + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagStyleStart + tagStylePadding + tagstyleThinLine + tagStyleEnd + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + tagBStart + data[i, j] + tagBEnd + tagPEnd);
                        continue;
                    }

                    if (hasSummaryRow & i == nRows - 1)
                    {
                        if (j == 0 && hasRowTitles)
                            sOut.Append(tagStyleStart + tagStylePadding + tagStyleTopBottomLine + tagStyleEnd + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagStyleStart + tagStylePadding + tagStyleTopBottomLine + tagStyleEnd + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + tagBStart + data[i, j] + tagBEnd + tagPEnd);
                        continue;
                    }

                    if (!hasSummaryRow & i == nRows - 1)
                    {
                        if (j == 0 && hasRowTitles)
                            sOut.Append(tagStyleStart + tagStylePadding + tagstyleThinLine + tagStyleEnd + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagStyleStart + tagStylePadding + tagstyleThinLine + tagStyleEnd + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + data[i, j] + tagPEnd);
                        continue;
                    }

                    if (j == 0 && hasRowTitles)
                        sOut.Append(tagStyleStart + tagStylePadding + tagStyleNoLine + tagStyleEnd + tagAlignLeft + tagEnd);
                    else
                        sOut.Append(tagStyleStart + tagStylePadding + tagStyleNoLine + tagStyleEnd + tagAlignRight + tagEnd);

                    sOut.Append(tagPStart + data[i, j] + tagPEnd);
                    sOut.Append(tagDataEnd);
                }
                sOut.AppendLine(tagRowEnd);
            }

            sOut.AppendLine(tagTRStart + tagTableOtherHeight + tagEnd);
            sOut.AppendLine(tagTDStart + "colspan=\"" + nCols + "\"" + tagStyleStart + tagStylePadding + tagStyleNoLine + tagStyleEnd + tagAlignLeft + tagEnd);
            sOut.AppendLine(tagPStart + tblNotes + tagPEnd);
            sOut.AppendLine(tagDataEnd);
            sOut.AppendLine(tagRowEnd);

            sOut.AppendLine(tagTableEnd);
            sOut.AppendLine(tagBodyEnd);
            sOut.AppendLine(tagHtmlEnd);

            return sOut.ToString();
        }
    }
}
