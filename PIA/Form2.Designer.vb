﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Principal"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(698, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 65)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(692, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(538, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Obten ángulos de Refracción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(595, 46)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Obten coeficientes de refracción"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(381, 65)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cerrar Simulador"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 543)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
