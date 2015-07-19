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
        public static string CreateHtmlTable(string[,] data, string tblNumber, string tblName, string tblNotes, bool hasColTitles, bool hasExtraColRow, bool hasSummaryRow, bool hasRowTitles)
        {
            int nRows = data.GetLength(0);
            int nCols = data.GetLength(1);

            double fontSize = 11.0;

            int tWidth = 650;

            string tagHtmlStart = "<html>";
            string tagHtmlEnd = "</html>";
            string tagBodyStart = "<body>";
            string tagBodyEnd = "</body>";

            string tagHeading = "<head>" +
                                    "<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">" +
                                    "<meta content=\"Word.Document\" name=\"ProgId\">" +
                                    "<meta content=\"Microsoft Word 15\" name=\"Generator\">" +
                                "</head>";

            string tagStyleNoLine = " style='padding:0pt 5.4pt 0pt 5.4pt' ";
            string tagStyleDoubleLine = " style='border-bottom:double; padding:0pt 5.4pt 0pt 5.4pt' ";
            string tagstyleThinLine = " style='border-bottom:solid thin; padding:0pt 5.4pt 0pt 5.4pt' ";
            string tagStyleTopBottomLine = " style='border-top:solid thin;border-bottom:solid thin; padding:0pt 5.4pt 0pt 5.4pt' ";

            string tagAlignLeft = " valign=\"center\" align=\"left\" ";
            string tagAlignRight = " valign=\"center\" align=\"right\" ";

            string tagEnd = ">";

            string tagDataStart = "<td ";
            string tagRowStart = "<tr ";
            string tagTableStart = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=";
            string tagTableDataHeight = " style='height:17.5pt' ";
            string tagTableOtherHeight = " style='height:7.0pt' ";

            string tagPStart = "<p style='font-size:" + fontSize +"pt;font-family:\"Cambria\",serif'>";
            //string tagPStart = "<p style='font-size:" + fontSize + "pt;font-family:\"Courier New\",serif'>";
            
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
            sOut.AppendLine(tagRowStart + tagTableOtherHeight + tagEnd);
            sOut.AppendLine(tagDataStart + "colspan=\"" + nCols + "\"" + tagStyleNoLine + tagAlignLeft + tagEnd);
            sOut.AppendLine(tagPStart + tblNumber + tagPEnd);
            sOut.AppendLine(tagDataEnd);
            sOut.AppendLine(tagRowEnd);

            sOut.AppendLine(tagRowStart + tagTableOtherHeight + tagEnd);
            sOut.AppendLine(tagDataStart + "colspan=\"" + nCols + "\"" + tagStyleDoubleLine + tagAlignLeft + tagEnd);
            sOut.AppendLine(tagPStart + tagIStart + tblName + tagIEnd + tagPEnd);
            sOut.AppendLine(tagDataEnd);
            sOut.AppendLine(tagRowEnd);

            for (int i = 0; i < nRows; i++)
            {

                sOut.AppendLine(tagRowStart + tagTableDataHeight + tagEnd);
                /*
                if(hasExtraColRow && i==0)
                {
                    for (int h = 0; h < nCols; h++)
                    {
                        sOut.Append(tagDataStart);
                        if (h == 0 && hasRowTitles)
                            sOut.Append(tagStyleNoLine + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagStyleNoLine + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + tagBStart + " " + tagBEnd + tagPEnd);
                        sOut.Append(tagDataEnd);    
                    }
                    sOut.Append(tagRowEnd);
                }*/

                for (int j = 0; j < nCols; j++)
                {
                    sOut.AppendLine(tagDataStart);

                    if (hasExtraColRow  & i < 2)
                    {
                        switch (i)
                        {
                            case 0:
                                if (j == 0 && hasRowTitles)
                                    sOut.Append(tagStyleNoLine + tagAlignLeft + tagEnd);
                                else
                                    sOut.Append(tagStyleNoLine + tagAlignRight + tagEnd);
                                break;
                            case 1:
                                if (j == 0 && hasRowTitles)
                                    sOut.Append(tagstyleThinLine + tagAlignLeft + tagEnd);
                                else
                                    sOut.Append(tagstyleThinLine + tagAlignRight + tagEnd);
                                break;
                        }
                        
                        sOut.Append(tagPStart + tagBStart + data[i, j] + tagBEnd + tagPEnd);
                        continue;
                    }


                    if (i == 0 && hasColTitles)
                    {
                        if (j == 0 && hasRowTitles)
                            sOut.Append(tagstyleThinLine + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagstyleThinLine + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + tagBStart + data[i, j] + tagBEnd + tagPEnd);
                        continue;
                    }

                    if (hasSummaryRow & i == nRows - 1)
                    {
                        if (j == 0 && hasRowTitles)
                            sOut.Append(tagStyleTopBottomLine + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagStyleTopBottomLine + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + tagBStart + data[i, j] + tagBEnd + tagPEnd);
                        continue;
                    }

                    if (!hasSummaryRow & i == nRows - 1)
                    {
                        if (j == 0 && hasRowTitles)
                            sOut.Append(tagstyleThinLine  + tagAlignLeft + tagEnd);
                        else
                            sOut.Append(tagstyleThinLine + tagAlignRight + tagEnd);

                        sOut.Append(tagPStart + data[i, j]  + tagPEnd);
                        continue;
                    }

                    if (j == 0 && hasRowTitles)
                        sOut.Append(tagStyleNoLine + tagAlignLeft + tagEnd);
                    else
                        sOut.Append(tagStyleNoLine + tagAlignRight + tagEnd);

                    sOut.Append(tagPStart + data[i, j] + tagPEnd);
                    sOut.Append(tagDataEnd);
                }
                sOut.AppendLine(tagRowEnd);
            }

            sOut.AppendLine(tagRowStart + tagTableOtherHeight + tagEnd);
            sOut.AppendLine(tagDataStart + "colspan=\"" + nCols + "\"" + tagStyleNoLine + tagAlignLeft + tagEnd);
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
