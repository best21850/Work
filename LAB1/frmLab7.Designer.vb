<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab7
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
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveall = New System.Windows.Forms.Button()
        Me.btnblack = New System.Windows.Forms.Button()
        Me.btnblackall = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstAdd
        '
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.ItemHeight = 16
        Me.lstAdd.Location = New System.Drawing.Point(62, 86)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(207, 228)
        Me.lstAdd.TabIndex = 0
        '
        'cboOutput
        '
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(345, 86)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(163, 24)
        Me.cboOutput.TabIndex = 1
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.Color.Aqua
        Me.btnMove.ForeColor = System.Drawing.Color.Black
        Me.btnMove.Location = New System.Drawing.Point(275, 134)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(40, 23)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnMoveall
        '
        Me.btnMoveall.BackColor = System.Drawing.Color.Aqua
        Me.btnMoveall.ForeColor = System.Drawing.Color.Black
        Me.btnMoveall.Location = New System.Drawing.Point(275, 163)
        Me.btnMoveall.Name = "btnMoveall"
        Me.btnMoveall.Size = New System.Drawing.Size(40, 23)
        Me.btnMoveall.TabIndex = 2
        Me.btnMoveall.Text = ">>"
        Me.btnMoveall.UseVisualStyleBackColor = False
        '
        'btnblack
        '
        Me.btnblack.BackColor = System.Drawing.Color.Aqua
        Me.btnblack.ForeColor = System.Drawing.Color.Black
        Me.btnblack.Location = New System.Drawing.Point(275, 192)
        Me.btnblack.Name = "btnblack"
        Me.btnblack.Size = New System.Drawing.Size(40, 23)
        Me.btnblack.TabIndex = 2
        Me.btnblack.Text = "<"
        Me.btnblack.UseVisualStyleBackColor = False
        '
        'btnblackall
        '
        Me.btnblackall.BackColor = System.Drawing.Color.Aqua
        Me.btnblackall.ForeColor = System.Drawing.Color.Black
        Me.btnblackall.Location = New System.Drawing.Point(275, 221)
        Me.btnblackall.Name = "btnblackall"
        Me.btnblackall.Size = New System.Drawing.Size(40, 23)
        Me.btnblackall.TabIndex = 2
        Me.btnblackall.Text = "<<"
        Me.btnblackall.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.Enabled = False
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(62, 348)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(207, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(62, 387)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(207, 22)
        Me.txtAdd.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(301, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(207, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Aqua
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(198, 431)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(177, 67)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "ปิดโปรแกรม"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(81, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "โปรแกรมควบคุม ListBox - ComboBox"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(301, 387)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(207, 23)
        Me.lblOutput.TabIndex = 1
        '
        'frmLab7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 526)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnblackall)
        Me.Controls.Add(Me.btnblack)
        Me.Controls.Add(Me.btnMoveall)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.lstAdd)
        Me.Name = "frmLab7"
        Me.Text = "frmLab7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAdd As ListBox
    Friend WithEvents cboOutput As ComboBox
    Friend WithEvents btnMove As Button
    Friend WithEvents btnMoveall As Button
    Friend WithEvents btnblack As Button
    Friend WithEvents btnblackall As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
End Class
