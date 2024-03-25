<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Gradetxtbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Calculatebtn = New Button()
        Answertxt = New Label()
        SuspendLayout()
        ' 
        ' Gradetxtbox
        ' 
        Gradetxtbox.Location = New Point(349, 112)
        Gradetxtbox.Name = "Gradetxtbox"
        Gradetxtbox.Size = New Size(125, 27)
        Gradetxtbox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(326, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 20)
        Label1.TabIndex = 1
        Label1.Text = "Student Grade Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Grade"
        ' 
        ' Calculatebtn
        ' 
        Calculatebtn.Location = New Point(362, 197)
        Calculatebtn.Name = "Calculatebtn"
        Calculatebtn.Size = New Size(94, 29)
        Calculatebtn.TabIndex = 2
        Calculatebtn.Text = "Calculate"
        Calculatebtn.UseVisualStyleBackColor = True
        ' 
        ' Answertxt
        ' 
        Answertxt.AutoSize = True
        Answertxt.Location = New Point(542, 197)
        Answertxt.Name = "Answertxt"
        Answertxt.Size = New Size(0, 20)
        Answertxt.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Calculatebtn)
        Controls.Add(Answertxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Gradetxtbox)
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Gradetxtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Calculatebtn As Button
    Friend WithEvents Answertxt As Label

End Class
