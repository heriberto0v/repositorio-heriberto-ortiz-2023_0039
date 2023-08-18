<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabChequeo = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbNivel = New System.Windows.Forms.GroupBox()
        Me.rbAlto = New System.Windows.Forms.RadioButton()
        Me.rbMedio = New System.Windows.Forms.RadioButton()
        Me.rbBajo = New System.Windows.Forms.RadioButton()
        Me.gbSintomas = New System.Windows.Forms.GroupBox()
        Me.rdAnsiedad = New System.Windows.Forms.RadioButton()
        Me.rdInsomnio = New System.Windows.Forms.RadioButton()
        Me.rdCongestionNasal = New System.Windows.Forms.RadioButton()
        Me.rdIndigestion = New System.Windows.Forms.RadioButton()
        Me.rdEstres = New System.Windows.Forms.RadioButton()
        Me.rbFatiga = New System.Windows.Forms.RadioButton()
        Me.rbMareado = New System.Windows.Forms.RadioButton()
        Me.rbDoloresMusculares = New System.Windows.Forms.RadioButton()
        Me.rbFiebre = New System.Windows.Forms.RadioButton()
        Me.rbGanasDeVomitar = New System.Windows.Forms.RadioButton()
        Me.tabResultado = New System.Windows.Forms.TabPage()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tabControl.SuspendLayout()
        Me.tabChequeo.SuspendLayout()
        Me.gbNivel.SuspendLayout()
        Me.gbSintomas.SuspendLayout()
        Me.tabResultado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabChequeo)
        Me.tabControl.Controls.Add(Me.tabResultado)
        Me.tabControl.Location = New System.Drawing.Point(-2, 1)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1357, 583)
        Me.tabControl.TabIndex = 0
        '
        'tabChequeo
        '
        Me.tabChequeo.BackColor = System.Drawing.Color.LightGray
        Me.tabChequeo.Controls.Add(Me.PictureBox1)
        Me.tabChequeo.Controls.Add(Me.DateTimePicker1)
        Me.tabChequeo.Controls.Add(Me.btnCheck)
        Me.tabChequeo.Controls.Add(Me.txtNombre)
        Me.tabChequeo.Controls.Add(Me.lblNombre)
        Me.tabChequeo.Controls.Add(Me.gbNivel)
        Me.tabChequeo.Controls.Add(Me.gbSintomas)
        Me.tabChequeo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tabChequeo.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.tabChequeo.Location = New System.Drawing.Point(4, 26)
        Me.tabChequeo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabChequeo.Name = "tabChequeo"
        Me.tabChequeo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabChequeo.Size = New System.Drawing.Size(1349, 553)
        Me.tabChequeo.TabIndex = 0
        Me.tabChequeo.Text = "Chequeo"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(765, 53)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(264, 25)
        Me.DateTimePicker1.TabIndex = 5
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(803, 140)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(226, 94)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "Chequeo"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(556, 53)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 25)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(487, 53)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 17)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'gbNivel
        '
        Me.gbNivel.Controls.Add(Me.rbAlto)
        Me.gbNivel.Controls.Add(Me.rbMedio)
        Me.gbNivel.Controls.Add(Me.rbBajo)
        Me.gbNivel.Location = New System.Drawing.Point(533, 189)
        Me.gbNivel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbNivel.Name = "gbNivel"
        Me.gbNivel.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbNivel.Size = New System.Drawing.Size(166, 163)
        Me.gbNivel.TabIndex = 1
        Me.gbNivel.TabStop = False
        Me.gbNivel.Text = "Nivel de molestia:"
        '
        'rbAlto
        '
        Me.rbAlto.AutoSize = True
        Me.rbAlto.Location = New System.Drawing.Point(8, 110)
        Me.rbAlto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbAlto.Name = "rbAlto"
        Me.rbAlto.Size = New System.Drawing.Size(58, 21)
        Me.rbAlto.TabIndex = 2
        Me.rbAlto.TabStop = True
        Me.rbAlto.Text = "Alto"
        Me.rbAlto.UseVisualStyleBackColor = True
        '
        'rbMedio
        '
        Me.rbMedio.AutoSize = True
        Me.rbMedio.Location = New System.Drawing.Point(8, 66)
        Me.rbMedio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbMedio.Name = "rbMedio"
        Me.rbMedio.Size = New System.Drawing.Size(73, 21)
        Me.rbMedio.TabIndex = 1
        Me.rbMedio.TabStop = True
        Me.rbMedio.Text = "Medio"
        Me.rbMedio.UseVisualStyleBackColor = True
        '
        'rbBajo
        '
        Me.rbBajo.AutoSize = True
        Me.rbBajo.Location = New System.Drawing.Point(8, 24)
        Me.rbBajo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbBajo.Name = "rbBajo"
        Me.rbBajo.Size = New System.Drawing.Size(61, 21)
        Me.rbBajo.TabIndex = 0
        Me.rbBajo.TabStop = True
        Me.rbBajo.Text = "Bajo"
        Me.rbBajo.UseVisualStyleBackColor = True
        '
        'gbSintomas
        '
        Me.gbSintomas.Controls.Add(Me.rdAnsiedad)
        Me.gbSintomas.Controls.Add(Me.rdInsomnio)
        Me.gbSintomas.Controls.Add(Me.rdCongestionNasal)
        Me.gbSintomas.Controls.Add(Me.rdIndigestion)
        Me.gbSintomas.Controls.Add(Me.rdEstres)
        Me.gbSintomas.Controls.Add(Me.rbFatiga)
        Me.gbSintomas.Controls.Add(Me.rbMareado)
        Me.gbSintomas.Controls.Add(Me.rbDoloresMusculares)
        Me.gbSintomas.Controls.Add(Me.rbFiebre)
        Me.gbSintomas.Controls.Add(Me.rbGanasDeVomitar)
        Me.gbSintomas.Font = New System.Drawing.Font("Cambria", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSintomas.Location = New System.Drawing.Point(11, 189)
        Me.gbSintomas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbSintomas.Name = "gbSintomas"
        Me.gbSintomas.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbSintomas.Size = New System.Drawing.Size(403, 352)
        Me.gbSintomas.TabIndex = 0
        Me.gbSintomas.TabStop = False
        Me.gbSintomas.Text = "Sintomas:"
        '
        'rdAnsiedad
        '
        Me.rdAnsiedad.AutoSize = True
        Me.rdAnsiedad.Location = New System.Drawing.Point(0, 197)
        Me.rdAnsiedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdAnsiedad.Name = "rdAnsiedad"
        Me.rdAnsiedad.Size = New System.Drawing.Size(101, 24)
        Me.rdAnsiedad.TabIndex = 9
        Me.rdAnsiedad.TabStop = True
        Me.rdAnsiedad.Text = "Ansiedad"
        Me.rdAnsiedad.UseVisualStyleBackColor = True
        '
        'rdInsomnio
        '
        Me.rdInsomnio.AutoSize = True
        Me.rdInsomnio.Location = New System.Drawing.Point(294, 197)
        Me.rdInsomnio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdInsomnio.Name = "rdInsomnio"
        Me.rdInsomnio.Size = New System.Drawing.Size(102, 24)
        Me.rdInsomnio.TabIndex = 8
        Me.rdInsomnio.TabStop = True
        Me.rdInsomnio.Text = "Insomnio"
        Me.rdInsomnio.UseVisualStyleBackColor = True
        '
        'rdCongestionNasal
        '
        Me.rdCongestionNasal.AutoSize = True
        Me.rdCongestionNasal.Location = New System.Drawing.Point(0, 110)
        Me.rdCongestionNasal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdCongestionNasal.Name = "rdCongestionNasal"
        Me.rdCongestionNasal.Size = New System.Drawing.Size(161, 24)
        Me.rdCongestionNasal.TabIndex = 7
        Me.rdCongestionNasal.TabStop = True
        Me.rdCongestionNasal.Text = "Congestion nasal"
        Me.rdCongestionNasal.UseVisualStyleBackColor = True
        '
        'rdIndigestion
        '
        Me.rdIndigestion.AutoSize = True
        Me.rdIndigestion.Location = New System.Drawing.Point(0, 154)
        Me.rdIndigestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdIndigestion.Name = "rdIndigestion"
        Me.rdIndigestion.Size = New System.Drawing.Size(117, 24)
        Me.rdIndigestion.TabIndex = 6
        Me.rdIndigestion.TabStop = True
        Me.rdIndigestion.Text = "Indigestion"
        Me.rdIndigestion.UseVisualStyleBackColor = True
        '
        'rdEstres
        '
        Me.rdEstres.AutoSize = True
        Me.rdEstres.Location = New System.Drawing.Point(294, 154)
        Me.rdEstres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdEstres.Name = "rdEstres"
        Me.rdEstres.Size = New System.Drawing.Size(78, 24)
        Me.rdEstres.TabIndex = 5
        Me.rdEstres.TabStop = True
        Me.rdEstres.Text = "Estres"
        Me.rdEstres.UseVisualStyleBackColor = True
        '
        'rbFatiga
        '
        Me.rbFatiga.AutoSize = True
        Me.rbFatiga.Location = New System.Drawing.Point(294, 110)
        Me.rbFatiga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbFatiga.Name = "rbFatiga"
        Me.rbFatiga.Size = New System.Drawing.Size(79, 24)
        Me.rbFatiga.TabIndex = 4
        Me.rbFatiga.TabStop = True
        Me.rbFatiga.Text = "Fatiga"
        Me.rbFatiga.UseVisualStyleBackColor = True
        '
        'rbMareado
        '
        Me.rbMareado.AutoSize = True
        Me.rbMareado.Location = New System.Drawing.Point(294, 24)
        Me.rbMareado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbMareado.Name = "rbMareado"
        Me.rbMareado.Size = New System.Drawing.Size(99, 24)
        Me.rbMareado.TabIndex = 0
        Me.rbMareado.TabStop = True
        Me.rbMareado.Text = "Mareado"
        Me.rbMareado.UseVisualStyleBackColor = True
        '
        'rbDoloresMusculares
        '
        Me.rbDoloresMusculares.AutoSize = True
        Me.rbDoloresMusculares.Location = New System.Drawing.Point(0, 66)
        Me.rbDoloresMusculares.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbDoloresMusculares.Name = "rbDoloresMusculares"
        Me.rbDoloresMusculares.Size = New System.Drawing.Size(183, 24)
        Me.rbDoloresMusculares.TabIndex = 3
        Me.rbDoloresMusculares.TabStop = True
        Me.rbDoloresMusculares.Text = "Dolores musculares"
        Me.rbDoloresMusculares.UseVisualStyleBackColor = True
        '
        'rbFiebre
        '
        Me.rbFiebre.AutoSize = True
        Me.rbFiebre.Location = New System.Drawing.Point(294, 66)
        Me.rbFiebre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbFiebre.Name = "rbFiebre"
        Me.rbFiebre.Size = New System.Drawing.Size(78, 24)
        Me.rbFiebre.TabIndex = 2
        Me.rbFiebre.TabStop = True
        Me.rbFiebre.Text = "Fiebre"
        Me.rbFiebre.UseVisualStyleBackColor = True
        '
        'rbGanasDeVomitar
        '
        Me.rbGanasDeVomitar.AutoSize = True
        Me.rbGanasDeVomitar.Location = New System.Drawing.Point(0, 24)
        Me.rbGanasDeVomitar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbGanasDeVomitar.Name = "rbGanasDeVomitar"
        Me.rbGanasDeVomitar.Size = New System.Drawing.Size(167, 24)
        Me.rbGanasDeVomitar.TabIndex = 1
        Me.rbGanasDeVomitar.TabStop = True
        Me.rbGanasDeVomitar.Text = "Ganas de vomitar"
        Me.rbGanasDeVomitar.UseVisualStyleBackColor = True
        '
        'tabResultado
        '
        Me.tabResultado.BackColor = System.Drawing.Color.Silver
        Me.tabResultado.Controls.Add(Me.PictureBox2)
        Me.tabResultado.Controls.Add(Me.progressBar)
        Me.tabResultado.Controls.Add(Me.lblResultado)
        Me.tabResultado.Location = New System.Drawing.Point(4, 26)
        Me.tabResultado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabResultado.Name = "tabResultado"
        Me.tabResultado.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabResultado.Size = New System.Drawing.Size(1349, 553)
        Me.tabResultado.TabIndex = 1
        Me.tabResultado.Text = "Resultado"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(-5, 250)
        Me.progressBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(1352, 302)
        Me.progressBar.TabIndex = 1
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(131, 98)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(12, 17)
        Me.lblResultado.TabIndex = 0
        Me.lblResultado.Text = ":"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.el_doc.My.Resources.Resources.pt
        Me.PictureBox1.Location = New System.Drawing.Point(44, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 120)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.el_doc.My.Resources.Resources.resultado
        Me.PictureBox2.Location = New System.Drawing.Point(20, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 121)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 582)
        Me.Controls.Add(Me.tabControl)
        Me.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "El mata sanos"
        Me.tabControl.ResumeLayout(False)
        Me.tabChequeo.ResumeLayout(False)
        Me.tabChequeo.PerformLayout()
        Me.gbNivel.ResumeLayout(False)
        Me.gbNivel.PerformLayout()
        Me.gbSintomas.ResumeLayout(False)
        Me.gbSintomas.PerformLayout()
        Me.tabResultado.ResumeLayout(False)
        Me.tabResultado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabChequeo As TabPage
    Friend WithEvents tabResultado As TabPage
    Friend WithEvents gbSintomas As GroupBox
    Friend WithEvents rbFatiga As RadioButton
    Friend WithEvents rbDoloresMusculares As RadioButton
    Friend WithEvents rbFiebre As RadioButton
    Friend WithEvents rbGanasDeVomitar As RadioButton
    Friend WithEvents rbMareado As RadioButton
    Friend WithEvents gbNivel As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents rbAlto As RadioButton
    Friend WithEvents rbMedio As RadioButton
    Friend WithEvents rbBajo As RadioButton
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rdAnsiedad As RadioButton
    Friend WithEvents rdInsomnio As RadioButton
    Friend WithEvents rdCongestionNasal As RadioButton
    Friend WithEvents rdIndigestion As RadioButton
    Friend WithEvents rdEstres As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
