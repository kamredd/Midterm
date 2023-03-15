Public Class frmBuilding
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decMeasure As Decimal
        Dim ConMeasure As Decimal
        Dim FinalCon As Decimal

        Dim decToMeter As Decimal = 0.0254D
        Dim decToInch As Decimal = 39.37D

        Dim stringMeter As String = " meter(s)"
        Dim stringInch As String = " inch(es)"

        If IsNumeric(txtValue.Text) Then
            decMeasure = Convert.ToDecimal(txtValue.Text)
            If decMeasure > 0 Then

                'if statements for each radio button
                If rbtnIn.Checked Then
                    ConMeasure = decToMeter
                Else
                    ConMeasure = decToInch
                End If

                'make calculations and display
                FinalCon = ConMeasure * decMeasure
                If rbtnIn.Checked Then
                    lblCon.Text = decMeasure.ToString & stringInch & " is " & FinalCon.ToString & stringMeter & "."
                    lblCon.Visible = True

                Else
                    lblCon.Text = decMeasure.ToString & stringMeter & " is " & FinalCon.ToString & stringInch & "."
                    lblCon.Visible = True
                End If


            Else
                'dislpay message about being negative
                MsgBox("Please enter a positive value.", 5, "Input Error")
                txtValue.Text = ""
                txtValue.Focus()
            End If
        Else
            'display message about being letters
            MsgBox("Please enter a numeric value.", 5, "Input Error")
            txtValue.Text = ""
            txtValue.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Text = ""
        txtValue.Focus()
        lblCon.Text = ""
        lblCon.Visible = False
        rbtnIn.Checked = True
    End Sub
End Class
