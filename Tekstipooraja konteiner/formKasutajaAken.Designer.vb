<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
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
        Me.components = New System.ComponentModel.Container()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtSisendtekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.txtCnt = New System.Windows.Forms.Label()
        Me.btnAlgo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValjundTekst3 = New System.Windows.Forms.TextBox()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(52, 187)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(93, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Sisendtekst"
        '
        'txtSisendtekst
        '
        Me.txtSisendtekst.Location = New System.Drawing.Point(274, 187)
        Me.txtSisendtekst.Name = "txtSisendtekst"
        Me.txtSisendtekst.Size = New System.Drawing.Size(432, 26)
        Me.txtSisendtekst.TabIndex = 1
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(274, 287)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(432, 26)
        Me.txtValjundTekst1.TabIndex = 2
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(274, 434)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(432, 26)
        Me.txtValjundTekst2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pööramine funktsiooniga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pööramine protseduuriga"
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(274, 334)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(179, 35)
        Me.btnPoora1.TabIndex = 6
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(274, 486)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(179, 37)
        Me.btnPoora2.TabIndex = 7
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(860, 85)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(80, 35)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(1010, 85)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(80, 35)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'txtCnt
        '
        Me.txtCnt.AutoSize = True
        Me.txtCnt.Location = New System.Drawing.Point(713, 192)
        Me.txtCnt.Name = "txtCnt"
        Me.txtCnt.Size = New System.Drawing.Size(0, 20)
        Me.txtCnt.TabIndex = 10
        '
        'btnAlgo
        '
        Me.btnAlgo.Location = New System.Drawing.Point(274, 621)
        Me.btnAlgo.Name = "btnAlgo"
        Me.btnAlgo.Size = New System.Drawing.Size(179, 37)
        Me.btnAlgo.TabIndex = 13
        Me.btnAlgo.Text = "Pööra algorimiga"
        Me.btnAlgo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 569)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Pööramine algoritmiliselt"
        '
        'txtValjundTekst3
        '
        Me.txtValjundTekst3.Location = New System.Drawing.Point(274, 569)
        Me.txtValjundTekst3.Name = "txtValjundTekst3"
        Me.txtValjundTekst3.Size = New System.Drawing.Size(432, 26)
        Me.txtValjundTekst3.TabIndex = 11
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(872, 183)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(120, 24)
        Me.CheckBox.TabIndex = 14
        Me.CheckBox.Text = "Algoritmiline"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 772)
        Me.Controls.Add(Me.CheckBox)
        Me.Controls.Add(Me.btnAlgo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValjundTekst3)
        Me.Controls.Add(Me.txtCnt)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendtekst)
        Me.Controls.Add(Me.label1)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtSisendtekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents txtCnt As Label
    Friend WithEvents btnAlgo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValjundTekst3 As TextBox
    Friend WithEvents CheckBox As CheckBox
End Class
