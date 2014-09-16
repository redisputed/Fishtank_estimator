Imports System.IO

Public Class EstimateGrid


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub

    Private Sub btnOutputText_Click(sender As Object, e As EventArgs) Handles btnOutputText.Click
        Dim dtmSaveDate As DateTime = DateTime.Now
        Dim strFileName As String
        Dim strDatePattern As String = "MMddyy-HHmmss"

        strFileName = "AquariumEstimate-" & dtmSaveDate.ToString(strDatePattern) & ".txt"

        'The following text file output code comes from user greg on stackoverflow.com
        'http://stackoverflow.com/questions/6686852/datagridview-to-csv-file
        'accessed 09/09/2014

        Dim headers = (From header As DataGridViewColumn In dgLengthEstimate.Columns.Cast(Of DataGridViewColumn)() _
             Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In dgLengthEstimate.Rows.Cast(Of DataGridViewRow)() _
                   Where Not row.IsNewRow _
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter(strFileName)
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start(strFileName)



    End Sub
End Class