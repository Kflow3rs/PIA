Public Class Form3
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Potencia_cc.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub txtAnguloIncidente_TextChanged(sender As Object, e As EventArgs) Handles corriente_cc.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim vcc As Double
        Dim pcc As Double
        Dim icc As Double
        Dim vvo As Double
        Dim pvo As Double
        Dim ico As Double
        Dim ka As Double
        Dim valta As Double
        Dim vbaja As Double
        Dim factorp As Double
        Dim hz As Double
        Dim a As Double

        Dim rh As Double
        Dim rx As Double
        Dim xlx As Double
        Dim xlh As Double
        Dim r2ch As Double
        Dim rch As Double
        Dim x2lmch As Double
        Dim xlmch As Double

        Dim ccarga As Double
        Dim e1m As Double
        Dim zl As Double
        Dim E1 As Double
        Dim E2 As Double
        Dim zexc As Double
        Dim yexc As Double
        Dim iexc As Double
        Dim cim As Double
        Dim cic As Double
        Dim pc As Double
        Dim i1 As Double
        Dim ptcu As Double
        Dim ve1 As Double
        Dim fp1 As Double
        Dim eficiencia As Double
        Dim reg As Double


        vcc = Double.Parse(voltaje_cc.Text)
        pcc = Double.Parse(Potencia_cc.Text)
        icc = Double.Parse(corriente_cc.Text)
        vvo = Double.Parse(voltaje_Vo.Text)
        pvo = Double.Parse(Potencia_vo.Text)
        ico = Double.Parse(corriente_vo.Text)
        ka = Double.Parse(Kva.Text)
        valta = Double.Parse(voltaje_alta.Text)
        vbaja = Double.Parse(voltaje_baja.Text)
        factorp = Double.Parse(fp.Text)
        hz = Double.Parse(frecuencia.Text)

        a = valta / vbaja
        rh = (pcc / (icc) ^ 2) / 2
        rx = rh / (a ^ 2)
        xlh = (Math.Sqrt(((vcc / icc) ^ 2) - ((2 * rh) ^ 2))) / 2
        xlx = xlh / (a ^ 2)
        r2ch = (pvo / ico ^ 2) - rx
        rch = (a ^ 2) * r2ch
        x2lmch = (Math.Sqrt(((vvo / ico) ^ 2) - ((rx + r2ch) ^ 2))) - xlx
        xlmch = a ^ 2 * x2lmch


        ccarga = ka / vbaja
        zl = vbaja / ccarga
        E2 = ccarga * (rx + xlx) + vbaja
        E1 = (a ^ 2) * E2
        zexc = rch + xlmch
        yexc = 1 / zexc
        iexc = E1 / zexc
        i1 = iexc + (ccarga / a)
        ptcu = (i1 ^ 2 * rh) + (ccarga ^ 2 * rx)
        ve1 = E1 + i1 * (rh + xlh)
        reg = (((ve1 / a) - vbaja) / vbaja) * 100


        MessageBox.Show("Segun los valores ingresados, los valores dentro del transformador son: " & vbCrLf &
                       " a = " & a & " rh = " & rh & " rx = " & rx & " xlx = " & xlx & vbCrLf &
                        " xlh = " & xlh & " xlmch = " & xlmch & vbCrLf & vbCrLf &
                        " Y segun estos valores, los parametros de funcionamiento son: " & vbCrLf & vbCrLf &
                        "corriente de carga = " & ccarga & " impedancia de carga = " & zl & vbCrLf & vbCrLf &
                        "Voltaje inducido E1 = " & E1 & " Voltaje inducido E2 = " & E2 & vbCrLf & vbCrLf &
                        "Impedancia de Excitacion = " & zexc & " Admitancia de Excitacion = " & yexc & vbCrLf & vbCrLf &
                        "Corriente de excitacion = " & iexc & " Corriente de entrada = " & i1 & vbCrLf & vbCrLf &
                        "Perdidas por el nucleo de cobre = " & ptcu & " Voltaje de entrada inicial = " & ve1 & vbCrLf & vbCrLf &
                        "Regulacion de voltaje a plena carga = " & reg )



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub voltaje_cc_TextChanged(sender As Object, e As EventArgs) Handles voltaje_cc.TextChanged

    End Sub
End Class