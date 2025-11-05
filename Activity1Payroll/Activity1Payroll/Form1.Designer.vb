<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtphil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdaywork = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpagibig = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsss = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(37, 38)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(87, 20)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Full name:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(173, 38)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(264, 22)
        Me.txtname.TabIndex = 1
        '
        'txtposition
        '
        Me.txtposition.Location = New System.Drawing.Point(173, 75)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(264, 22)
        Me.txtposition.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(Admin, Personnel, Worker, Utility)"
        '
        'txtphil
        '
        Me.txtphil.Location = New System.Drawing.Point(173, 171)
        Me.txtphil.Name = "txtphil"
        Me.txtphil.Size = New System.Drawing.Size(264, 22)
        Me.txtphil.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Philhealth:"
        '
        'txtdaywork
        '
        Me.txtdaywork.Location = New System.Drawing.Point(240, 134)
        Me.txtdaywork.Name = "txtdaywork"
        Me.txtdaywork.Size = New System.Drawing.Size(197, 22)
        Me.txtdaywork.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "No. of days worked:"
        '
        'txtpagibig
        '
        Me.txtpagibig.Location = New System.Drawing.Point(173, 247)
        Me.txtpagibig.Name = "txtpagibig"
        Me.txtpagibig.Size = New System.Drawing.Size(264, 22)
        Me.txtpagibig.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pag-ibig:"
        '
        'txtsss
        '
        Me.txtsss.Location = New System.Drawing.Point(173, 210)
        Me.txtsss.Name = "txtsss"
        Me.txtsss.Size = New System.Drawing.Size(264, 22)
        Me.txtsss.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "SSS:"
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(337, 291)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(100, 30)
        Me.btncompute.TabIndex = 13
        Me.btncompute.Text = "Compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 353)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.txtpagibig)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsss)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtphil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdaywork)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.Name = "Form1"
        Me.Text = "Payroll Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtposition As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtphil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdaywork As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpagibig As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsss As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btncompute As Button
End Class
