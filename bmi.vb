Imports System.Windows.Forms

Public Class BMICalculatorForm
    Inherits Form

    Private WithEvents Button1 As New Button()
    Private Label1 As New Label()
    Private TextBox1 As New TextBox()
    Private TextBox2 As New TextBox()

    Public Sub New()
        ' Set up the form
        Me.Text = "BMI Calculator"
        Me.Size = New Size(300, 200)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False

        ' Label for height input
        Label1.Text = "Enter your height (meters):"
        Label1.Location = New Point(20, 20)
        Me.Controls.Add(Label1)

        ' TextBox for height input
        TextBox1.Location = New Point(170, 20)
        Me.Controls.Add(TextBox1)

        ' Label for weight input
        Dim Label2 As New Label()
        Label2.Text = "Enter your weight (kilograms):"
        Label2.Location = New Point(20, 50)
        Me.Controls.Add(Label2)

        ' TextBox for weight input
        TextBox2.Location = New Point(200, 50)
        Me.Controls.Add(TextBox2)

        ' Button to calculate BMI
        Button1.Text = "Calculate BMI"
        Button1.Location = New Point(100, 80)
        Me.Controls.Add(Button1)

        ' Add an event handler for the button click
        AddHandler Button1.Click, AddressOf CalculateBMI
    End Sub

    Private Sub CalculateBMI(ByVal sender As Object, ByVal e As EventArgs)
        Dim height, weight, bmi As Single
        height = Val(TextBox1.Text)
        weight = Val(TextBox2.Text)

        ' Check if height and weight are valid values
        If height > 0 And weight > 0 Then
            ' Calculate BMI
            bmi = weight / (height ^ 2)

            ' Display the calculated BMI
            MessageBox.Show("Your BMI: " & bmi.ToString("F2"), "BMI Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Display an error message if height or weight is not valid
            MessageBox.Show("Please enter valid height and weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Shared Sub Main()
        Application.Run(New BMICalculatorForm())
    End Sub
End Class
