Public Class Form1

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSFLIGHTSCHOOLDataSet.ASSESSMENT' table. You can move, or remove it, as needed.
        Me.ASSESSMENTTableAdapter.Fill(Me.SSFLIGHTSCHOOLDataSet.ASSESSMENT)
        'TODO: This line of code loads data into the 'SSFLIGHTSCHOOLDataSet.FLIGHTS' table. You can move, or remove it, as needed.
        Me.FLIGHTSTableAdapter.Fill(Me.SSFLIGHTSCHOOLDataSet.FLIGHTS)
        'TODO: This line of code loads data into the 'SSFLIGHTSCHOOLDataSet.INSTRUCTOR' table. You can move, or remove it, as needed.
        Me.INSTRUCTORTableAdapter.Fill(Me.SSFLIGHTSCHOOLDataSet.INSTRUCTOR)
        'TODO: This line of code loads data into the 'SSFLIGHTSCHOOLDataSet.PILOT' table. You can move, or remove it, as needed.
        Me.PILOTTableAdapter.Fill(Me.SSFLIGHTSCHOOLDataSet.PILOT)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
