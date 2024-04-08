<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Num3 = New System.Windows.Forms.Label()
        Me.BtnJogar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.imgResultado = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(235, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jogo 7 da Sorte"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Num1)
        Me.Panel1.Location = New System.Drawing.Point(170, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Num2)
        Me.Panel2.Location = New System.Drawing.Point(321, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Num3)
        Me.Panel3.Location = New System.Drawing.Point(474, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 2
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(16, 19)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(58, 67)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "0"
        Me.Num1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.Location = New System.Drawing.Point(19, 19)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(58, 67)
        Me.Num2.TabIndex = 1
        Me.Num2.Text = "0"
        Me.Num2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Num3
        '
        Me.Num3.AutoSize = True
        Me.Num3.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3.Location = New System.Drawing.Point(18, 19)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(58, 67)
        Me.Num3.TabIndex = 1
        Me.Num3.Text = "0"
        Me.Num3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnJogar
        '
        Me.BtnJogar.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogar.ForeColor = System.Drawing.Color.Blue
        Me.BtnJogar.Location = New System.Drawing.Point(33, 276)
        Me.BtnJogar.Name = "BtnJogar"
        Me.BtnJogar.Size = New System.Drawing.Size(102, 54)
        Me.BtnJogar.TabIndex = 3
        Me.BtnJogar.Text = "Jogar"
        Me.BtnJogar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Red
        Me.BtnSair.Location = New System.Drawing.Point(614, 389)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 34)
        Me.BtnSair.TabIndex = 4
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'imgResultado
        '
        Me.imgResultado.Location = New System.Drawing.Point(186, 241)
        Me.imgResultado.Name = "imgResultado"
        Me.imgResultado.Size = New System.Drawing.Size(366, 182)
        Me.imgResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgResultado.TabIndex = 5
        Me.imgResultado.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imgResultado)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnJogar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Num1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Num2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Num3 As Label
    Friend WithEvents BtnJogar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents imgResultado As PictureBox
End Class
