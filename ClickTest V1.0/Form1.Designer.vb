<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkinMain = New ClickTest_V1._0.FormSkin()
        Me.ButtonOpen = New ClickTest_V1._0.FlatMini()
        Me.ButtonClose = New ClickTest_V1._0.FlatClose()
        Me.TabControl = New ClickTest_V1._0.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonStoped = New ClickTest_V1._0.FlatButton()
        Me.LabelSelectTimer = New ClickTest_V1._0.FlatLabel()
        Me.ButtonClickTester = New System.Windows.Forms.Button()
        Me.LabelTotalCps = New ClickTest_V1._0.FlatLabel()
        Me.LabelCps = New ClickTest_V1._0.FlatLabel()
        Me.GroupBoxTheme = New ClickTest_V1._0.FlatGroupBox()
        Me.ButtonClolorPurple = New ClickTest_V1._0.FlatButton()
        Me.ButtonClolorRed = New ClickTest_V1._0.FlatButton()
        Me.ButtonClolorCyan = New ClickTest_V1._0.FlatButton()
        Me.ButtonClolorOrange = New ClickTest_V1._0.FlatButton()
        Me.ButtonClolorBlue = New ClickTest_V1._0.FlatButton()
        Me.ButtonClolorLimeGreen = New ClickTest_V1._0.FlatButton()
        Me.ButtonMain = New ClickTest_V1._0.FlatButton()
        Me.NumericSelectTimer = New ClickTest_V1._0.FlatNumeric()
        Me.Credit = New System.Windows.Forms.TabPage()
        Me.LabelCredit = New ClickTest_V1._0.FlatLabel()
        Me.FormSkinMain.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxTheme.SuspendLayout()
        Me.Credit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'FormSkinMain
        '
        Me.FormSkinMain.BackColor = System.Drawing.Color.Black
        Me.FormSkinMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkinMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkinMain.Controls.Add(Me.ButtonOpen)
        Me.FormSkinMain.Controls.Add(Me.ButtonClose)
        Me.FormSkinMain.Controls.Add(Me.TabControl)
        Me.FormSkinMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkinMain.FlatColor = System.Drawing.Color.DimGray
        Me.FormSkinMain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkinMain.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkinMain.HeaderMaximize = False
        Me.FormSkinMain.Location = New System.Drawing.Point(0, 0)
        Me.FormSkinMain.Name = "FormSkinMain"
        Me.FormSkinMain.Size = New System.Drawing.Size(1100, 600)
        Me.FormSkinMain.TabIndex = 0
        Me.FormSkinMain.Text = "ClickTester V1.0"
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpen.BackColor = System.Drawing.Color.White
        Me.ButtonOpen.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ButtonOpen.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.ButtonOpen.Location = New System.Drawing.Point(1032, 26)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(18, 18)
        Me.ButtonOpen.TabIndex = 1
        Me.ButtonOpen.Text = "FlatMini1"
        Me.ButtonOpen.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.White
        Me.ButtonClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ButtonClose.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.ButtonClose.Location = New System.Drawing.Point(1056, 26)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(18, 18)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TabControl
        '
        Me.TabControl.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TabControl.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.Credit)
        Me.TabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl.ItemSize = New System.Drawing.Size(120, 40)
        Me.TabControl.Location = New System.Drawing.Point(0, 50)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1100, 550)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ButtonStoped)
        Me.TabPage1.Controls.Add(Me.LabelSelectTimer)
        Me.TabPage1.Controls.Add(Me.ButtonClickTester)
        Me.TabPage1.Controls.Add(Me.LabelTotalCps)
        Me.TabPage1.Controls.Add(Me.LabelCps)
        Me.TabPage1.Controls.Add(Me.GroupBoxTheme)
        Me.TabPage1.Controls.Add(Me.ButtonMain)
        Me.TabPage1.Controls.Add(Me.NumericSelectTimer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1092, 502)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tester"
        '
        'ButtonStoped
        '
        Me.ButtonStoped.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStoped.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonStoped.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStoped.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStoped.Location = New System.Drawing.Point(546, 400)
        Me.ButtonStoped.Name = "ButtonStoped"
        Me.ButtonStoped.Rounded = False
        Me.ButtonStoped.Size = New System.Drawing.Size(288, 54)
        Me.ButtonStoped.TabIndex = 22
        Me.ButtonStoped.Text = "Annuler le Test"
        Me.ButtonStoped.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ButtonStoped.Visible = False
        '
        'LabelSelectTimer
        '
        Me.LabelSelectTimer.AutoSize = True
        Me.LabelSelectTimer.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectTimer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LabelSelectTimer.Location = New System.Drawing.Point(24, 400)
        Me.LabelSelectTimer.Name = "LabelSelectTimer"
        Me.LabelSelectTimer.Size = New System.Drawing.Size(184, 21)
        Me.LabelSelectTimer.TabIndex = 21
        Me.LabelSelectTimer.Text = "Durée du test en seconds"
        '
        'ButtonClickTester
        '
        Me.ButtonClickTester.Font = New System.Drawing.Font("Segoe UI", 26.25!)
        Me.ButtonClickTester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonClickTester.Location = New System.Drawing.Point(25, 23)
        Me.ButtonClickTester.Name = "ButtonClickTester"
        Me.ButtonClickTester.Size = New System.Drawing.Size(1041, 313)
        Me.ButtonClickTester.TabIndex = 20
        Me.ButtonClickTester.Text = "Clique"
        Me.ButtonClickTester.UseVisualStyleBackColor = True
        '
        'LabelTotalCps
        '
        Me.LabelTotalCps.AutoSize = True
        Me.LabelTotalCps.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotalCps.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalCps.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LabelTotalCps.Location = New System.Drawing.Point(241, 429)
        Me.LabelTotalCps.Name = "LabelTotalCps"
        Me.LabelTotalCps.Size = New System.Drawing.Size(290, 25)
        Me.LabelTotalCps.TabIndex = 19
        Me.LabelTotalCps.Text = "Tu a fait 10 CPS pour 10 seconds."
        '
        'LabelCps
        '
        Me.LabelCps.AutoSize = True
        Me.LabelCps.BackColor = System.Drawing.Color.Transparent
        Me.LabelCps.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCps.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LabelCps.Location = New System.Drawing.Point(240, 398)
        Me.LabelCps.Name = "LabelCps"
        Me.LabelCps.Size = New System.Drawing.Size(89, 32)
        Me.LabelCps.TabIndex = 18
        Me.LabelCps.Text = "CPS 10"
        '
        'GroupBoxTheme
        '
        Me.GroupBoxTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GroupBoxTheme.BaseColor = System.Drawing.Color.Transparent
        Me.GroupBoxTheme.Controls.Add(Me.ButtonClolorPurple)
        Me.GroupBoxTheme.Controls.Add(Me.ButtonClolorRed)
        Me.GroupBoxTheme.Controls.Add(Me.ButtonClolorCyan)
        Me.GroupBoxTheme.Controls.Add(Me.ButtonClolorOrange)
        Me.GroupBoxTheme.Controls.Add(Me.ButtonClolorBlue)
        Me.GroupBoxTheme.Controls.Add(Me.ButtonClolorLimeGreen)
        Me.GroupBoxTheme.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTheme.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBoxTheme.Location = New System.Drawing.Point(843, 359)
        Me.GroupBoxTheme.Name = "GroupBoxTheme"
        Me.GroupBoxTheme.ShowText = True
        Me.GroupBoxTheme.Size = New System.Drawing.Size(234, 108)
        Me.GroupBoxTheme.TabIndex = 17
        Me.GroupBoxTheme.Text = "Choix du Thème"
        '
        'ButtonClolorPurple
        '
        Me.ButtonClolorPurple.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClolorPurple.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ButtonClolorPurple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClolorPurple.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonClolorPurple.Location = New System.Drawing.Point(121, 41)
        Me.ButtonClolorPurple.Name = "ButtonClolorPurple"
        Me.ButtonClolorPurple.Rounded = False
        Me.ButtonClolorPurple.Size = New System.Drawing.Size(29, 54)
        Me.ButtonClolorPurple.TabIndex = 10
        Me.ButtonClolorPurple.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonClolorRed
        '
        Me.ButtonClolorRed.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClolorRed.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonClolorRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClolorRed.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonClolorRed.Location = New System.Drawing.Point(191, 41)
        Me.ButtonClolorRed.Name = "ButtonClolorRed"
        Me.ButtonClolorRed.Rounded = False
        Me.ButtonClolorRed.Size = New System.Drawing.Size(29, 54)
        Me.ButtonClolorRed.TabIndex = 8
        Me.ButtonClolorRed.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonClolorCyan
        '
        Me.ButtonClolorCyan.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClolorCyan.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ButtonClolorCyan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClolorCyan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonClolorCyan.Location = New System.Drawing.Point(16, 41)
        Me.ButtonClolorCyan.Name = "ButtonClolorCyan"
        Me.ButtonClolorCyan.Rounded = False
        Me.ButtonClolorCyan.Size = New System.Drawing.Size(29, 54)
        Me.ButtonClolorCyan.TabIndex = 15
        Me.ButtonClolorCyan.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonClolorOrange
        '
        Me.ButtonClolorOrange.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClolorOrange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonClolorOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClolorOrange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonClolorOrange.Location = New System.Drawing.Point(86, 41)
        Me.ButtonClolorOrange.Name = "ButtonClolorOrange"
        Me.ButtonClolorOrange.Rounded = False
        Me.ButtonClolorOrange.Size = New System.Drawing.Size(29, 54)
        Me.ButtonClolorOrange.TabIndex = 12
        Me.ButtonClolorOrange.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonClolorBlue
        '
        Me.ButtonClolorBlue.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClolorBlue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonClolorBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClolorBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonClolorBlue.Location = New System.Drawing.Point(156, 41)
        Me.ButtonClolorBlue.Name = "ButtonClolorBlue"
        Me.ButtonClolorBlue.Rounded = False
        Me.ButtonClolorBlue.Size = New System.Drawing.Size(29, 54)
        Me.ButtonClolorBlue.TabIndex = 14
        Me.ButtonClolorBlue.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonClolorLimeGreen
        '
        Me.ButtonClolorLimeGreen.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClolorLimeGreen.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonClolorLimeGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClolorLimeGreen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonClolorLimeGreen.Location = New System.Drawing.Point(51, 41)
        Me.ButtonClolorLimeGreen.Name = "ButtonClolorLimeGreen"
        Me.ButtonClolorLimeGreen.Rounded = False
        Me.ButtonClolorLimeGreen.Size = New System.Drawing.Size(29, 54)
        Me.ButtonClolorLimeGreen.TabIndex = 13
        Me.ButtonClolorLimeGreen.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonMain
        '
        Me.ButtonMain.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMain.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMain.Location = New System.Drawing.Point(25, 23)
        Me.ButtonMain.Name = "ButtonMain"
        Me.ButtonMain.Rounded = False
        Me.ButtonMain.Size = New System.Drawing.Size(1042, 313)
        Me.ButtonMain.TabIndex = 2
        Me.ButtonMain.Text = "Commencer"
        Me.ButtonMain.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'NumericSelectTimer
        '
        Me.NumericSelectTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.NumericSelectTimer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.NumericSelectTimer.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.NumericSelectTimer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NumericSelectTimer.ForeColor = System.Drawing.Color.White
        Me.NumericSelectTimer.Location = New System.Drawing.Point(25, 424)
        Me.NumericSelectTimer.Maximum = CType(100, Long)
        Me.NumericSelectTimer.Minimum = CType(1, Long)
        Me.NumericSelectTimer.Name = "NumericSelectTimer"
        Me.NumericSelectTimer.Size = New System.Drawing.Size(183, 30)
        Me.NumericSelectTimer.TabIndex = 0
        Me.NumericSelectTimer.Text = "FlatNumeric1"
        Me.NumericSelectTimer.Value = CType(1, Long)
        '
        'Credit
        '
        Me.Credit.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Credit.Controls.Add(Me.LabelCredit)
        Me.Credit.Location = New System.Drawing.Point(4, 44)
        Me.Credit.Name = "Credit"
        Me.Credit.Padding = New System.Windows.Forms.Padding(3)
        Me.Credit.Size = New System.Drawing.Size(1092, 502)
        Me.Credit.TabIndex = 1
        Me.Credit.Text = "Credit"
        '
        'LabelCredit
        '
        Me.LabelCredit.AutoSize = True
        Me.LabelCredit.BackColor = System.Drawing.Color.Transparent
        Me.LabelCredit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCredit.ForeColor = System.Drawing.Color.White
        Me.LabelCredit.Location = New System.Drawing.Point(6, 49)
        Me.LabelCredit.Name = "LabelCredit"
        Me.LabelCredit.Size = New System.Drawing.Size(52, 21)
        Me.LabelCredit.TabIndex = 0
        Me.LabelCredit.Text = "Credit"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.FormSkinMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkinMain.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBoxTheme.ResumeLayout(False)
        Me.Credit.ResumeLayout(False)
        Me.Credit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkinMain As FormSkin
    Friend WithEvents ButtonOpen As FlatMini
    Friend WithEvents ButtonClose As FlatClose
    Friend WithEvents TabControl As FlatTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Credit As TabPage
    Friend WithEvents LabelCredit As FlatLabel
    Friend WithEvents ButtonMain As FlatButton
    Friend WithEvents NumericSelectTimer As FlatNumeric
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonClolorCyan As FlatButton
    Friend WithEvents ButtonClolorBlue As FlatButton
    Friend WithEvents ButtonClolorLimeGreen As FlatButton
    Friend WithEvents ButtonClolorOrange As FlatButton
    Friend WithEvents ButtonClolorPurple As FlatButton
    Friend WithEvents ButtonClolorRed As FlatButton
    Friend WithEvents GroupBoxTheme As FlatGroupBox
    Friend WithEvents LabelTotalCps As FlatLabel
    Friend WithEvents LabelCps As FlatLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonClickTester As Button
    Friend WithEvents LabelSelectTimer As FlatLabel
    Friend WithEvents ButtonStoped As FlatButton
End Class
