<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CIOAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiocatoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnullaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AobutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Punteggio1 = New System.Windows.Forms.Label()
        Me.Punteggio2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CIOAToolStripMenuItem, Me.AobutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.NewGameToolStripMenuItem.Text = "New Game "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CIOAToolStripMenuItem
        '
        Me.CIOAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GiocatoreToolStripMenuItem, Me.AnnullaToolStripMenuItem})
        Me.CIOAToolStripMenuItem.Name = "CIOAToolStripMenuItem"
        Me.CIOAToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.CIOAToolStripMenuItem.Text = "Modifica"
        '
        'GiocatoreToolStripMenuItem
        '
        Me.GiocatoreToolStripMenuItem.Name = "GiocatoreToolStripMenuItem"
        Me.GiocatoreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GiocatoreToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.GiocatoreToolStripMenuItem.Text = "Giocatore"
        '
        'AnnullaToolStripMenuItem
        '
        Me.AnnullaToolStripMenuItem.Name = "AnnullaToolStripMenuItem"
        Me.AnnullaToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.AnnullaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.AnnullaToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.AnnullaToolStripMenuItem.Text = "Annulla "
        '
        'AobutToolStripMenuItem
        '
        Me.AobutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.AobutToolStripMenuItem.Name = "AobutToolStripMenuItem"
        Me.AobutToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.AobutToolStripMenuItem.Text = "About "
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegolaToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RegolaToolStripMenuItem
        '
        Me.RegolaToolStripMenuItem.Name = "RegolaToolStripMenuItem"
        Me.RegolaToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.RegolaToolStripMenuItem.Text = "Regola "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 24)
        Me.ToolStripMenuItem1.Text = "Dado"
        '
        'A1
        '
        Me.A1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.A1.Location = New System.Drawing.Point(16, 30)
        Me.A1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(87, 80)
        Me.A1.TabIndex = 1
        Me.A1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.A1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.B2.Location = New System.Drawing.Point(111, 117)
        Me.B2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(87, 80)
        Me.B2.TabIndex = 2
        Me.B2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.B3.Location = New System.Drawing.Point(205, 117)
        Me.B3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(87, 80)
        Me.B3.TabIndex = 3
        Me.B3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.B3.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.C3.Location = New System.Drawing.Point(205, 204)
        Me.C3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(87, 80)
        Me.C3.TabIndex = 4
        Me.C3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.C3.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.C2.Location = New System.Drawing.Point(111, 204)
        Me.C2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(87, 80)
        Me.C2.TabIndex = 5
        Me.C2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.C2.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.C1.Location = New System.Drawing.Point(16, 204)
        Me.C1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(87, 80)
        Me.C1.TabIndex = 6
        Me.C1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.C1.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.B1.Location = New System.Drawing.Point(16, 117)
        Me.B1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(87, 80)
        Me.B1.TabIndex = 7
        Me.B1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.B1.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.A3.Location = New System.Drawing.Point(205, 30)
        Me.A3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(87, 80)
        Me.A3.TabIndex = 8
        Me.A3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.A2.Location = New System.Drawing.Point(111, 30)
        Me.A2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(87, 80)
        Me.A2.TabIndex = 9
        Me.A2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.A2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(307, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 36)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Giocatore 1 (X)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(300, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 36)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Point"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 192)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 36)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Giocatore 2 (O)"
        '
        'Punteggio1
        '
        Me.Punteggio1.AutoSize = True
        Me.Punteggio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punteggio1.Location = New System.Drawing.Point(371, 110)
        Me.Punteggio1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Punteggio1.Name = "Punteggio1"
        Me.Punteggio1.Size = New System.Drawing.Size(64, 69)
        Me.Punteggio1.TabIndex = 14
        Me.Punteggio1.Text = "0"
        '
        'Punteggio2
        '
        Me.Punteggio2.AutoSize = True
        Me.Punteggio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punteggio2.Location = New System.Drawing.Point(371, 228)
        Me.Punteggio2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Punteggio2.Name = "Punteggio2"
        Me.Punteggio2.Size = New System.Drawing.Size(64, 69)
        Me.Punteggio2.TabIndex = 15
        Me.Punteggio2.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 306)
        Me.Controls.Add(Me.Punteggio2)
        Me.Controls.Add(Me.Punteggio1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tris "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents A1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents C3 As System.Windows.Forms.Button
    Friend WithEvents C2 As System.Windows.Forms.Button
    Friend WithEvents C1 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents A3 As System.Windows.Forms.Button
    Friend WithEvents A2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CIOAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AobutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiocatoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Punteggio1 As System.Windows.Forms.Label
    Friend WithEvents Punteggio2 As System.Windows.Forms.Label
    Friend WithEvents AnnullaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
