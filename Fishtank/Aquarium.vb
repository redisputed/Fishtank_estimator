Public Class Aquarium
    ' Actions  and code in this form take inspiration from 
    ' Starting Out With Visual Basic. 2010 Fifth Edition Tony Gaddis and Kip Irvine

    Const decGUPPIE_PRICE As Decimal = 1.0
    Const decANGEL_FISH_PRICE As Decimal = 1.5
    Const decCLOWN_FISH_PRICE As Decimal = 2.0

    Const decBASIC_FILTER_PRICE As Decimal = 5.0
    Const decSUPER_QUIET_FILTER_PRICE As Decimal = 10.0
    Const decLONG_TERM_FILTER_PRICE As Decimal = 15.0

    Private Sub clearData()
        'reset the display labels
        lblVolume.Text = "Volume: "
        lblCapacity.Text = "Capacity: "
        lblFishCapacity.Text = "Max # Fish: "
        lblHeight.Text = "Height: "
        lblLength.Text = "Length: "
        lblWidth.Text = "Width: "

        'clear the subtotal and total fields
        txtFishSubtotal.Clear()
        txtFilterSubtotal.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub resetOptions()
        'reset the options listbox and radio buttons
        'TODO replace with combo box
        lstFishSelect.SelectedIndex = -1
        radBasicFilter.Checked = False
        radSuperQtFilter.Checked = False
        radLongLifeFilter.Checked = False

    End Sub

    Private Function calcFishQuant(ByVal decCapacity) As Integer
        'one fish per gallon, use truncate to strip rational component
        Return Math.Truncate(decCapacity)

    End Function

    Private Function calcFishSubtotal(ByVal intFishQuant) As Decimal
        Dim decFishSubtotal As Decimal = 0.0
        'TODO Rewrite to account for database fish info

        If lstFishSelect.SelectedIndex <> -1 Then
            Select Case lstFishSelect.SelectedIndex
                Case 0
                    'Guppies $1
                    decFishSubtotal = intFishQuant * decGUPPIE_PRICE

                Case 1
                    'Angel Fish $1.50
                    decFishSubtotal = intFishQuant * decANGEL_FISH_PRICE

                Case 2
                    'Clown Fish $2
                    decFishSubtotal = intFishQuant * decCLOWN_FISH_PRICE

                Case Else
                    'Error
                    MsgBox("Something went terribly wrong... Exiting program!")
                    Me.Close()

            End Select
        Else
            MsgBox("Please select a Fish from the list and recaclulate.")

        End If

        Return decFishSubtotal
    End Function

    Private Function calcFilterSize(decCapacity) As Integer
        Dim intFilterSize As Integer = 0

        'one filter per whole 5 gallons (inital integer division by 1 to prevent rounding
        intFilterSize = Math.Truncate(decCapacity) \ 5


        'account for fractional 5 gallons
        If Math.Truncate(decCapacity) Mod 5 > 0 Then
            intFilterSize += 1
        End If

        Return intFilterSize
    End Function

    Private Function calcFilterSubtotal(ByVal decCapacity) As Decimal
        Dim decSubtotal As Decimal = 0.0

        If radBasicFilter.Checked = True Then
            'basic filter $5 per size
            decSubtotal = calcFilterSize(decCapacity) * decBASIC_FILTER_PRICE

        ElseIf radSuperQtFilter.Checked = True Then
            'Super Quiet filter $10 per size
            decSubtotal = calcFilterSize(decCapacity) * decSUPER_QUIET_FILTER_PRICE

        ElseIf radLongLifeFilter.Checked = True Then
            'long life filter $15 per size
            decSubtotal = calcFilterSize(decCapacity) * decLONG_TERM_FILTER_PRICE

        Else
            MsgBox("Please select a filter.")

        End If

        Return decSubtotal

    End Function

    Private Function calcTotal(ByVal decFishSubtotal, ByVal decFilterSubtotal) As Decimal
        Const decSALES_TAX As Decimal = 1.0

        Return (decFishSubtotal + decFilterSubtotal) * decSALES_TAX

    End Function

    Private Function calcMaxSubscript(ByVal decMinLength, ByRef decMaxLength) As Integer
        Return Math.Truncate(decMaxLength - decMinLength)
    End Function

    Private Function calcVolume(ByVal decHeight, ByVal decLength, ByVal decwidth) As Decimal
        'Volume = Height * Length * Width
        Return (decHeight * decLength * decwidth)
    End Function

    Private Function calcCapacity(ByVal decVolume) As Decimal
        'Capacity = Volume / 231
        Return (decVolume / 231)
    End Function

    Private Sub btnClearInput_Click(sender As Object, e As EventArgs) Handles btnClearInput.Click
        'Clear the textboxes and reset the form
        txtInputHeight.Clear()
        txtInputLength.Clear()
        txtInputWidth.Clear()

        picFishTankWireFrame.Visible = False
        lblVolume.Visible = False
        lblCapacity.Visible = False
        lblFishCapacity.Visible = False
        lblHeight.Visible = False
        lblLength.Visible = False
        lblWidth.Visible = False

        clearData()
        resetOptions()

        txtInputHeight.Focus()

    End Sub

    Private Sub btnCalcVolume_Click(sender As Object, e As EventArgs) Handles btnCalcVolume.Click
        'make sure the display is reset
        clearData()

        'Calculate Volume of the tank and capacity in gallons
        Dim decHeight As Decimal = 0D
        Dim decLength As Decimal = 0D
        Dim decWidth As Decimal = 0D
        Dim decVolume As Decimal = 0D
        Dim decCapacity As Decimal = 0D
        Dim decFishSubtotal As Decimal = 0D
        Dim decFilterSubtotal As Decimal = 0D
        Dim decTotal As Decimal = 0D

        Dim intFishQuant As Integer = 0

        Try
            decHeight = CDec(txtInputHeight.Text)
            decLength = CDec(txtInputLength.Text)
            decWidth = CDec(txtInputWidth.Text)

        Catch ex As InvalidCastException
            MessageBox.Show("Error: Please provide all values before pressing Enter")

        End Try

        decVolume = calcVolume(decHeight, decLength, decWidth)

        decCapacity = calcCapacity(decVolume)

        'determine max number of fish
        intFishQuant = calcFishQuant(decCapacity)

        'prepare data
        lblVolume.Text &= decVolume.ToString("n2") & " in.^3"
        lblCapacity.Text &= decCapacity.ToString("n2") & " gallons"
        lblFishCapacity.Text &= intFishQuant.ToString("n0") & " fish"
        lblHeight.Text &= decHeight.ToString("n2") & " in."
        lblLength.Text &= decLength.ToString("n2") & " in."
        lblWidth.Text &= decWidth.ToString("n2") & " in."

        'display data
        picFishTankWireFrame.Visible = True
        lblVolume.Visible = True
        lblCapacity.Visible = True
        lblFishCapacity.Visible = True
        lblHeight.Visible = True
        lblLength.Visible = True
        lblWidth.Visible = True

        'calculate and display fish subtotal
        decFishSubtotal = calcFishSubtotal(intFishQuant)
        txtFishSubtotal.Text = decFishSubtotal.ToString("c")

        'calculate and display filter subtotal
        decFilterSubtotal = calcFilterSubtotal(decCapacity)
        txtFilterSubtotal.Text = decFilterSubtotal.ToString("c")

        'calculate and display grand total
        decTotal = calcTotal(decFishSubtotal, decFilterSubtotal)
        txtTotal.Text = decTotal.ToString("c")


    End Sub

    Private Sub txtInputHeight_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtInputHeight.Validating
        Dim decHeight As Decimal = 0

        If Not (txtInputHeight.Text = String.Empty) Then

            Try
                decHeight = CDec(txtInputHeight.Text)

                If decHeight >= 12 And decHeight <= 72 Then
                    'good input
                    e.Cancel = False
                Else
                    'bad input
                    MessageBox.Show("Height must be 12 - 72 inches")
                    e.Cancel = True

                End If

            Catch ex As InvalidCastException
                MessageBox.Show("Error: Please enter a numeric value")
                e.Cancel = True

            End Try
        End If
    End Sub

    Private Sub txtInputLength_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtInputLength.Validating
        Dim decLength As Decimal = 0

        If Not (txtInputLength.Text = String.Empty) Then
            Try
                decLength = CDec(txtInputLength.Text)

                If decLength >= 12 And decLength <= 96 Then
                    'good input
                    e.Cancel = False
                Else
                    'bad input
                    MessageBox.Show("Length must be 12 - 96 inches")
                    e.Cancel = True

                End If

            Catch ex As InvalidCastException
                MessageBox.Show("Error: Please enter a numeric value")
                e.Cancel = True

            End Try

        End If
    End Sub

    Private Sub txtInputWidth_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtInputWidth.Validating
        Dim decWidth As Decimal = 0

        If Not (txtInputWidth.Text = String.Empty) Then
            Try
                decWidth = CDec(txtInputWidth.Text)

                If decWidth >= 12 And decWidth <= 96 Then
                    'good input
                    e.Cancel = False
                Else
                    'bad input
                    MessageBox.Show("Width must be 12 - 96 inches")
                    e.Cancel = True

                End If

            Catch ex As InvalidCastException
                MessageBox.Show("Error: Please enter a numeric value")
                e.Cancel = True

            End Try

        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtInputMaxLength_GotFocus(sender As Object, e As EventArgs) Handles txtInputMaxLength.GotFocus
        lblInputLength.Text = "Min Length"
    End Sub

    Private Sub txtInputMaxLength_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtInputMaxLength.Validating
        Dim decLength As Decimal = 0
        If Not (txtInputLength.Text = String.Empty) Then

            If Not (txtInputMaxLength.Text = String.Empty) Then
                Try
                    decLength = CDec(txtInputMaxLength.Text)

                    If decLength >= 12 And decLength <= 96 Then
                        'good input
                        e.Cancel = False
                    Else
                        'bad input
                        MessageBox.Show("Length must be 12 - 96 inches")
                        e.Cancel = True

                    End If

                    If decLength <= CDec(txtInputLength.Text) Then
                        MessageBox.Show("Max Length must be larger than Min Length")
                    End If

                Catch ex As InvalidCastException
                    MessageBox.Show("Error: Please enter a numeric value")
                    e.Cancel = True

                End Try

            End If
        Else
            MessageBox.Show("Length Estimator requires a value for Min Length")
            txtInputLength.Focus()
        End If
    End Sub

    Private Sub btnEstimate_Click(sender As Object, e As EventArgs) Handles btnEstimate.Click
        Dim frmEstimator As New EstimateGrid

        Dim decHeight As Decimal
        Dim decWidth As Decimal
        Dim decMinLength As Decimal
        Dim decMaxLength As Decimal
        Dim intIndex As Integer = 0

        Dim intMaxSubscript As Integer = 0
        'Determine the subscript for the parallel arrays
        intMaxSubscript = calcMaxSubscript(CDec(txtInputLength.Text), CDec(txtInputMaxLength.Text))

        Dim decLengths(intMaxSubscript) As Decimal
        Dim decVolumes(intMaxSubscript) As Decimal
        Dim decCapacities(intMaxSubscript) As Decimal
        Dim intNumFish(intMaxSubscript) As Integer
        Dim decCostFish(intMaxSubscript) As Decimal
        Dim intNumFilters(intMaxSubscript) As Integer
        Dim decCostFilters(intMaxSubscript) As Decimal
        Dim decTotalCost(intMaxSubscript) As Decimal


        Try
            decHeight = CDec(txtInputHeight.Text)
            decWidth = CDec(txtInputWidth.Text)
            decMinLength = CDec(txtInputLength.Text)
            decMaxLength = CDec(txtInputMaxLength.Text)

        Catch ex As InvalidCastException
            MessageBox.Show("Error: Please provide all values before pressing Enter")

        End Try

        For decLength As Decimal = decMinLength To decMaxLength Step 1
            decLengths(intIndex) = decLength
            decVolumes(intIndex) = calcVolume(decHeight, decLength, decWidth)
            decCapacities(intIndex) = calcCapacity(decVolumes(intIndex))
            intNumFish(intIndex) = calcFishQuant(decCapacities(intIndex))
            decCostFish(intIndex) = calcFishSubtotal(intNumFish(intIndex))
            intNumFilters(intIndex) = calcFilterSize(decCapacities(intIndex))
            decCostFilters(intIndex) = calcFilterSubtotal(decCapacities(intIndex))
            decTotalCost(intIndex) = calcTotal(decCostFish(intIndex), decCostFilters(intIndex))

            intIndex += 1

        Next


        For i As Integer = 0 To intMaxSubscript Step 1
            Dim item As New DataGridViewRow
            item.CreateCells(frmEstimator.dgLengthEstimate)
            With item
                .Cells(0).Value = decLengths(i).ToString("n2")
                .Cells(1).Value = decWidth.ToString("n2")
                .Cells(2).Value = decHeight.ToString("n2")
                .Cells(3).Value = decVolumes(i).ToString("n2")
                .Cells(4).Value = decCapacities(i).ToString("n2")
                .Cells(5).Value = intNumFish(i).ToString("n")
                .Cells(6).Value = decCostFish(i).ToString("c2")
                .Cells(7).Value = intNumFilters(i).ToString("n")
                .Cells(8).Value = decCostFilters(i).ToString("c2")
                .Cells(9).Value = decTotalCost(i).ToString("c2")
            End With
            '---add the row---
            frmEstimator.dgLengthEstimate.Rows.Add(item)
        Next

        frmEstimator.ShowDialog()

    End Sub
End Class
