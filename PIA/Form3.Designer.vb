<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAnguloIncidente = New System.Windows.Forms.TextBox()
        Me.txtMedioIncidente = New System.Windows.Forms.TextBox()
        Me.txtMedioRefraccion = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ángulos de Refracción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ángulo de Incidencia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 46)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "n del medio incidente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(480, 46)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "n del medio de refracción:"
        '
        'txtAnguloIncidente
        '
        Me.txtAnguloIncidente.Location = New System.Drawing.Point(533, 135)
        Me.txtAnguloIncidente.Name = "txtAnguloIncidente"
        Me.txtAnguloIncidente.Size = New System.Drawing.Size(296, 44)
        Me.txtAnguloIncidente.TabIndex = 4
        '
        'txtMedioIncidente
        '
        Me.txtMedioIncidente.Location = New System.Drawing.Point(535, 223)
        Me.txtMedioIncidente.Name = "txtMedioIncidente"
        Me.txtMedioIncidente.Size = New System.Drawing.Size(296, 44)
        Me.txtMedioIncidente.TabIndex = 5
        '
        'txtMedioRefraccion
        '
        Me.txtMedioRefraccion.Location = New System.Drawing.Point(540, 305)
        Me.txtMedioRefraccion.Name = "txtMedioRefraccion"
        Me.txtMedioRefraccion.Size = New System.Drawing.Size(296, 44)
        Me.txtMedioRefraccion.TabIndex = 6
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(934, 122)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(202, 174)
        Me.btncalcular.TabIndex = 7
        Me.btncalcular.Text = "Calcular:"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(20, 382)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(899, 88)
        Me.txtResultado.TabIndex = 8
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(842, 614)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(320, 90)
        Me.btnmenu.TabIndex = 9
        Me.btnmenu.Text = "Menu Principal"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 732)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtMedioRefraccion)
        Me.Controls.Add(Me.txtMedioIncidente)
        Me.Controls.Add(Me.txtAnguloIncidente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAnguloIncidente As TextBox
    Friend WithEvents txtMedioIncidente As TextBox
    Friend WithEvents txtMedioRefraccion As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnmenu As Button
End Class
