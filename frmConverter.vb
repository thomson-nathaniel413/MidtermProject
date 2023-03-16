Public Class frmConverter
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' upon button click: exit program
        Close()
    End Sub

    Private Sub frmConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' upon form load: clear text fields, hide result label, and set default radio button
        btnClear_Click(Me, e)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' upon button click: clear text fields, hide result label, focus txtMeasure, and set default radio button
        txtMeasure.Text = ""
        lblResult.Text = ""
        lblResult.Visible = False
        txtMeasure.Focus()
        radInToM.Checked = True

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' upon button click: verify input, perform conversions, display output

        ' variable definitions

        Dim decMeasureInput As Decimal
        Dim decMeasureOutput As Decimal = 0D
        Dim strInputUnit As String
        Dim strOutputUnit As String

        ' verify input from txtMeasure
        If (IsNumeric(txtMeasure.Text)) Then
            ' input was a number
            ' retrieve the value
            decMeasureInput = Convert.ToDecimal(txtMeasure.Text)

            ' verify input is a positive number
            If (decMeasureInput > 0) Then
                ' input was a positive number

                ' selection block determining conversion type
                If (radInToM.Checked) Then
                    ' conversion type is inches -> meters
                    strInputUnit = "inches"
                    strOutputUnit = "meters"

                    ' perform calculation
                    decMeasureOutput = decMeasureInput * 0.0254D
                Else
                    ' conversion type is meters -> inches
                    strInputUnit = "meters"
                    strOutputUnit = "inches"

                    ' perform calculation
                    decMeasureOutput = decMeasureInput * 39.37008D
                End If

                ' display result
                lblResult.Text = decMeasureInput.ToString() & " " & strInputUnit & " is " & decMeasureOutput.ToString("F2") & " " & strOutputUnit
                lblResult.Visible = True
            Else
                ' input was 0 or negative
                MsgBox("You must enter a number greater than zero!")
            End If
        Else
            ' input was not a number
            MsgBox("You must input a number!")
        End If



    End Sub
End Class
