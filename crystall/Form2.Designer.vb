<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.searchtext = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.codingbtn = New System.Windows.Forms.Button()
        Me.noncodingbtn = New System.Windows.Forms.Button()
        Me.nametxet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'searchtext
        '
        Me.searchtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtext.Location = New System.Drawing.Point(86, 200)
        Me.searchtext.Name = "searchtext"
        Me.searchtext.Size = New System.Drawing.Size(233, 38)
        Me.searchtext.TabIndex = 49
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(86, 136)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(233, 32)
        Me.label1.TabIndex = 42
        Me.label1.Text = "Search Condition"
        '
        'addbtn
        '
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.Location = New System.Drawing.Point(327, 259)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(298, 52)
        Me.addbtn.TabIndex = 35
        Me.addbtn.Text = "show specified city"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'codingbtn
        '
        Me.codingbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.codingbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codingbtn.Location = New System.Drawing.Point(677, 192)
        Me.codingbtn.Name = "codingbtn"
        Me.codingbtn.Size = New System.Drawing.Size(592, 43)
        Me.codingbtn.TabIndex = 50
        Me.codingbtn.Text = "Show Search in Crystall report in coding"
        Me.codingbtn.UseVisualStyleBackColor = False
        '
        'noncodingbtn
        '
        Me.noncodingbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.noncodingbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noncodingbtn.Location = New System.Drawing.Point(747, 254)
        Me.noncodingbtn.Name = "noncodingbtn"
        Me.noncodingbtn.Size = New System.Drawing.Size(507, 43)
        Me.noncodingbtn.TabIndex = 51
        Me.noncodingbtn.Text = "Show Crystall report without coding"
        Me.noncodingbtn.UseVisualStyleBackColor = False
        '
        'nametxet
        '
        Me.nametxet.AutoSize = True
        Me.nametxet.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxet.Location = New System.Drawing.Point(388, 203)
        Me.nametxet.Name = "nametxet"
        Me.nametxet.Size = New System.Drawing.Size(168, 32)
        Me.nametxet.TabIndex = 52
        Me.nametxet.Text = "Desired City"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1343, 608)
        Me.Controls.Add(Me.nametxet)
        Me.Controls.Add(Me.noncodingbtn)
        Me.Controls.Add(Me.codingbtn)
        Me.Controls.Add(Me.searchtext)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.addbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchtext As Windows.Forms.TextBox
    Private WithEvents label1 As Windows.Forms.Label
    Private WithEvents addbtn As Windows.Forms.Button
    Friend WithEvents codingbtn As Windows.Forms.Button
    Friend WithEvents noncodingbtn As Windows.Forms.Button
    Friend WithEvents nametxet As Windows.Forms.Label
End Class
