<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_LoadingMethode
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.Laden_Ordner_suchmodus = New System.Windows.Forms.ComboBox()
        Me.Check_CreateFolder = New Film_Info__Organizer.VistaTextCheck()
        Me.Check_search = New Film_Info__Organizer.VistaTextCheck()
        Me.Check_MediaInfo = New Film_Info__Organizer.VistaTextCheck()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(215, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(186, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(87, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(96, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(87, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Wenn ein neuer Film gefunden wird:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 14)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Immer anzeigen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.PictureBox16)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 49)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox16
        '
        Me.PictureBox16.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox16.Image = Global.Film_Info__Organizer.My.Resources.Resources.infobar
        Me.PictureBox16.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox16.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(413, 41)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 66
        Me.PictureBox16.TabStop = False
        '
        'Laden_Ordner_suchmodus
        '
        Me.Laden_Ordner_suchmodus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Laden_Ordner_suchmodus.FormattingEnabled = True
        Me.Laden_Ordner_suchmodus.Items.AddRange(New Object() {"Schnelle Suche", "Normale Suche", "Ausführliche Suche"})
        Me.Laden_Ordner_suchmodus.Location = New System.Drawing.Point(59, 51)
        Me.Laden_Ordner_suchmodus.Name = "Laden_Ordner_suchmodus"
        Me.Laden_Ordner_suchmodus.Size = New System.Drawing.Size(156, 23)
        Me.Laden_Ordner_suchmodus.TabIndex = 12
        '
        'Check_CreateFolder
        '
        Me.Check_CreateFolder.BackColor = System.Drawing.Color.Transparent
        Me.Check_CreateFolder.Checked = False
        Me.Check_CreateFolder.Image = Global.Film_Info__Organizer.Toolbar16.Normal_hinzufuegen
        Me.Check_CreateFolder.Location = New System.Drawing.Point(14, 129)
        Me.Check_CreateFolder.Margin = New System.Windows.Forms.Padding(5)
        Me.Check_CreateFolder.Name = "Check_CreateFolder"
        Me.Check_CreateFolder.Padding = New System.Windows.Forms.Padding(1)
        Me.Check_CreateFolder.Size = New System.Drawing.Size(387, 29)
        Me.Check_CreateFolder.sText = "Ordner erstellen"
        Me.Check_CreateFolder.TabIndex = 9
        Me.Check_CreateFolder.Tooltip = "Nachfragen, ob ein eigener Ordner erstellt werden soll, wenn ein Film keinen eige" & _
            "nen Ordner besitzt."
        '
        'Check_search
        '
        Me.Check_search.BackColor = System.Drawing.Color.Transparent
        Me.Check_search.Checked = False
        Me.Check_search.Image = Global.Film_Info__Organizer.Toolbar16.Suche_datenbank
        Me.Check_search.Location = New System.Drawing.Point(14, 48)
        Me.Check_search.Margin = New System.Windows.Forms.Padding(5)
        Me.Check_search.Name = "Check_search"
        Me.Check_search.Padding = New System.Windows.Forms.Padding(1)
        Me.Check_search.Size = New System.Drawing.Size(387, 29)
        Me.Check_search.sText = "                                                       starten"
        Me.Check_search.TabIndex = 1
        Me.Check_search.Tooltip = Nothing
        '
        'Check_MediaInfo
        '
        Me.Check_MediaInfo.BackColor = System.Drawing.Color.Transparent
        Me.Check_MediaInfo.Checked = False
        Me.Check_MediaInfo.Image = Global.Film_Info__Organizer.Toolbar16.mediainfoicon16
        Me.Check_MediaInfo.Location = New System.Drawing.Point(14, 87)
        Me.Check_MediaInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.Check_MediaInfo.Name = "Check_MediaInfo"
        Me.Check_MediaInfo.Padding = New System.Windows.Forms.Padding(1)
        Me.Check_MediaInfo.Size = New System.Drawing.Size(387, 32)
        Me.Check_MediaInfo.sText = "MediaInfo abrufen"
        Me.Check_MediaInfo.TabIndex = 2
        Me.Check_MediaInfo.Tooltip = Nothing
        '
        'Dialog_LoadingMethode
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(413, 225)
        Me.Controls.Add(Me.Laden_Ordner_suchmodus)
        Me.Controls.Add(Me.Check_CreateFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Check_search)
        Me.Controls.Add(Me.Check_MediaInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog_LoadingMethode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Check_search As Film_Info__Organizer.VistaTextCheck
    Friend WithEvents Check_MediaInfo As Film_Info__Organizer.VistaTextCheck
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Check_CreateFolder As Film_Info__Organizer.VistaTextCheck
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents Laden_Ordner_suchmodus As System.Windows.Forms.ComboBox

End Class
