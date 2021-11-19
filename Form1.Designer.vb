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
        Me.lstItem = New System.Windows.Forms.ListBox
        Me.txtQ = New System.Windows.Forms.TextBox
        Me.lstPur = New System.Windows.Forms.ListBox
        Me.lstQ = New System.Windows.Forms.ListBox
        Me.lstPer = New System.Windows.Forms.ListBox
        Me.lstPrice = New System.Windows.Forms.ListBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.add = New System.Windows.Forms.Button
        Me.remove = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Items.AddRange(New Object() {"cake", "biscuit", "cooldrink", "chocolate", "chips", "tea", "coffee"})
        Me.lstItem.Location = New System.Drawing.Point(32, 109)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(120, 134)
        Me.lstItem.TabIndex = 0
        '
        'txtQ
        '
        Me.txtQ.Location = New System.Drawing.Point(182, 163)
        Me.txtQ.Name = "txtQ"
        Me.txtQ.Size = New System.Drawing.Size(100, 20)
        Me.txtQ.TabIndex = 1
        '
        'lstPur
        '
        Me.lstPur.FormattingEnabled = True
        Me.lstPur.Location = New System.Drawing.Point(315, 109)
        Me.lstPur.Name = "lstPur"
        Me.lstPur.Size = New System.Drawing.Size(120, 121)
        Me.lstPur.TabIndex = 2
        '
        'lstQ
        '
        Me.lstQ.FormattingEnabled = True
        Me.lstQ.Location = New System.Drawing.Point(483, 109)
        Me.lstQ.Name = "lstQ"
        Me.lstQ.Size = New System.Drawing.Size(120, 121)
        Me.lstQ.TabIndex = 3
        '
        'lstPer
        '
        Me.lstPer.FormattingEnabled = True
        Me.lstPer.Location = New System.Drawing.Point(656, 109)
        Me.lstPer.Name = "lstPer"
        Me.lstPer.Size = New System.Drawing.Size(120, 121)
        Me.lstPer.TabIndex = 4
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(818, 109)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(120, 121)
        Me.lstPrice.TabIndex = 5
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(838, 252)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(737, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Purchase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(480, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quatity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(653, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Per price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(815, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Price"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(223, 334)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 23)
        Me.add.TabIndex = 14
        Me.add.Text = "ADD"
        Me.add.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Location = New System.Drawing.Point(378, 334)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(75, 23)
        Me.remove.TabIndex = 15
        Me.remove.Text = "Remove"
        Me.remove.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(528, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(668, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 521)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstPer)
        Me.Controls.Add(Me.lstQ)
        Me.Controls.Add(Me.lstPur)
        Me.Controls.Add(Me.txtQ)
        Me.Controls.Add(Me.lstItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
    Friend WithEvents txtQ As System.Windows.Forms.TextBox
    Friend WithEvents lstPur As System.Windows.Forms.ListBox
    Friend WithEvents lstQ As System.Windows.Forms.ListBox
    Friend WithEvents lstPer As System.Windows.Forms.ListBox
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents remove As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

    Private Sub remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove.Click

    End Sub
    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        If lstItem.Items.IndexOf(0) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        ElseIf lstItem.Items.IndexOf(1) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        ElseIf lstItem.Items.IndexOf(2) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        ElseIf lstItem.Items.IndexOf(3) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        ElseIf lstItem.Items.IndexOf(4) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        ElseIf lstItem.Items.IndexOf(5) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        ElseIf lstItem.Items.IndexOf(6) Then
            lstPur.Items.Add(lstItem.Text)
            lstQ.Items.Add(txtQ.Text)
        End If

    End Sub
End Class
