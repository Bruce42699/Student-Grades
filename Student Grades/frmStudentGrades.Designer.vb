<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeader = New Label()
        txtGrade = New TextBox()
        lblCaption = New Label()
        btnProcess = New Button()
        lbResult = New Label()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Location = New Point(48, 31)
        lblHeader.Margin = New Padding(4, 0, 4, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(187, 28)
        lblHeader.TabIndex = 0
        lblHeader.Text = "STUDENT GRADES"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(57, 89)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(125, 34)
        txtGrade.TabIndex = 1
        ' 
        ' lblCaption
        ' 
        lblCaption.AutoSize = True
        lblCaption.Location = New Point(231, 92)
        lblCaption.Name = "lblCaption"
        lblCaption.Size = New Size(206, 28)
        lblCaption.TabIndex = 2
        lblCaption.Text = "Your overall grade is"
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(71, 167)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(94, 40)
        btnProcess.TabIndex = 3
        btnProcess.Text = "Process"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' lbResult
        ' 
        lbResult.AutoSize = True
        lbResult.Location = New Point(294, 172)
        lbResult.Name = "lbResult"
        lbResult.Size = New Size(0, 28)
        lbResult.TabIndex = 4
        ' 
        ' frmStudentGrades
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 630)
        Controls.Add(lbResult)
        Controls.Add(btnProcess)
        Controls.Add(lblCaption)
        Controls.Add(txtGrade)
        Controls.Add(lblHeader)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "frmStudentGrades"
        Text = "Student Grades"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblCaption As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents lbResult As Label

End Class
