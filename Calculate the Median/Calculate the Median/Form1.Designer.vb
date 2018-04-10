<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromCalMedian
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblArray = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Randomly Generated Integer Array"
        '
        'lblArray
        '
        Me.lblArray.AutoSize = True
        Me.lblArray.Location = New System.Drawing.Point(34, 64)
        Me.lblArray.Name = "lblArray"
        Me.lblArray.Size = New System.Drawing.Size(39, 13)
        Me.lblArray.TabIndex = 1
        Me.lblArray.Text = "Label2"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(37, 110)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Median Value"
        '
        'lblMedian
        '
        Me.lblMedian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedian.Location = New System.Drawing.Point(267, 119)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(100, 23)
        Me.lblMedian.TabIndex = 4
        Me.lblMedian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fromCalMedian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 261)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblArray)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fromCalMedian"
        Me.Text = "Calculate the Median"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblArray As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMedian As Label
End Class
