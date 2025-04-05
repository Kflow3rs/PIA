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
        Me.corriente_cc = New System.Windows.Forms.TextBox()
        Me.voltaje_cc = New System.Windows.Forms.TextBox()
        Me.Potencia_cc = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Potencia_vo = New System.Windows.Forms.TextBox()
        Me.voltaje_Vo = New System.Windows.Forms.TextBox()
        Me.corriente_vo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.voltaje_alta = New System.Windows.Forms.TextBox()
        Me.voltaje_baja = New System.Windows.Forms.TextBox()
        Me.Kva = New System.Windows.Forms.TextBox()
        Me.fp = New System.Windows.Forms.TextBox()
        Me.frecuencia = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parametros de un transformador"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1201, 131)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingresa los Datos correspondientes a las pruebas realizadas en el transformador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(463, 52)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prueba Corto Circuito"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(331, 46)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prueba de Vacio"
        '
        'corriente_cc
        '
        Me.corriente_cc.Location = New System.Drawing.Point(1128, 307)
        Me.corriente_cc.Name = "corriente_cc"
        Me.corriente_cc.Size = New System.Drawing.Size(182, 44)
        Me.corriente_cc.TabIndex = 4
        '
        'voltaje_cc
        '
        Me.voltaje_cc.Location = New System.Drawing.Point(247, 297)
        Me.voltaje_cc.Name = "voltaje_cc"
        Me.voltaje_cc.Size = New System.Drawing.Size(180, 44)
        Me.voltaje_cc.TabIndex = 5
        '
        'Potencia_cc
        '
        Me.Potencia_cc.Location = New System.Drawing.Point(677, 302)
        Me.Potencia_cc.Name = "Potencia_cc"
        Me.Potencia_cc.Size = New System.Drawing.Size(173, 44)
        Me.Potencia_cc.TabIndex = 6
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(963, 182)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(341, 90)
        Me.btncalcular.TabIndex = 7
        Me.btncalcular.Text = "Calcular:"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(60, 17)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(171, 50)
        Me.btnmenu.TabIndex = 9
        Me.btnmenu.Text = "<----"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 46)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Voltaje "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(921, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 46)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Corriente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(475, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 46)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Potencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 425)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 46)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Potencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(924, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 46)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Corriente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 46)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Voltaje "
        '
        'Potencia_vo
        '
        Me.Potencia_vo.Location = New System.Drawing.Point(678, 430)
        Me.Potencia_vo.Name = "Potencia_vo"
        Me.Potencia_vo.Size = New System.Drawing.Size(173, 44)
        Me.Potencia_vo.TabIndex = 15
        '
        'voltaje_Vo
        '
        Me.voltaje_Vo.Location = New System.Drawing.Point(247, 425)
        Me.voltaje_Vo.Name = "voltaje_Vo"
        Me.voltaje_Vo.Size = New System.Drawing.Size(180, 44)
        Me.voltaje_Vo.TabIndex = 14
        '
        'corriente_vo
        '
        Me.corriente_vo.Location = New System.Drawing.Point(1125, 425)
        Me.corriente_vo.Name = "corriente_vo"
        Me.corriente_vo.Size = New System.Drawing.Size(182, 44)
        Me.corriente_vo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 583)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(279, 46)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Voltaje de Alta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 647)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(291, 46)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Voltaje de Baja"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 708)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 46)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "kVA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(621, 583)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(357, 46)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Factor de Potencia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(621, 650)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(218, 46)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Frecuencia"
        '
        'voltaje_alta
        '
        Me.voltaje_alta.Location = New System.Drawing.Point(367, 588)
        Me.voltaje_alta.Name = "voltaje_alta"
        Me.voltaje_alta.Size = New System.Drawing.Size(180, 44)
        Me.voltaje_alta.TabIndex = 24
        '
        'voltaje_baja
        '
        Me.voltaje_baja.Location = New System.Drawing.Point(367, 651)
        Me.voltaje_baja.Name = "voltaje_baja"
        Me.voltaje_baja.Size = New System.Drawing.Size(180, 44)
        Me.voltaje_baja.TabIndex = 25
        '
        'Kva
        '
        Me.Kva.Location = New System.Drawing.Point(367, 710)
        Me.Kva.Name = "Kva"
        Me.Kva.Size = New System.Drawing.Size(180, 44)
        Me.Kva.TabIndex = 26
        '
        'fp
        '
        Me.fp.Location = New System.Drawing.Point(1001, 588)
        Me.fp.Name = "fp"
        Me.fp.Size = New System.Drawing.Size(180, 44)
        Me.fp.TabIndex = 27
        '
        'frecuencia
        '
        Me.frecuencia.Location = New System.Drawing.Point(1000, 652)
        Me.frecuencia.Name = "frecuencia"
        Me.frecuencia.Size = New System.Drawing.Size(180, 44)
        Me.frecuencia.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 502)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(513, 52)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Datos del transformador"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1788, 793)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.frecuencia)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.Kva)
        Me.Controls.Add(Me.voltaje_baja)
        Me.Controls.Add(Me.voltaje_alta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Potencia_vo)
        Me.Controls.Add(Me.voltaje_Vo)
        Me.Controls.Add(Me.corriente_vo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Potencia_cc)
        Me.Controls.Add(Me.voltaje_cc)
        Me.Controls.Add(Me.corriente_cc)
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
    Friend WithEvents corriente_cc As TextBox
    Friend WithEvents voltaje_cc As TextBox
    Friend WithEvents Potencia_cc As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Potencia_vo As TextBox
    Friend WithEvents voltaje_Vo As TextBox
    Friend WithEvents corriente_vo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents voltaje_alta As TextBox
    Friend WithEvents voltaje_baja As TextBox
    Friend WithEvents Kva As TextBox
    Friend WithEvents fp As TextBox
    Friend WithEvents frecuencia As TextBox
    Friend WithEvents Label16 As Label
End Class
