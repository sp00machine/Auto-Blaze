<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AutoBlaze
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoBlaze))
        Me.BlazeButton = New System.Windows.Forms.Button()
        Me.LoadBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ABEvery = New System.Windows.Forms.RadioButton()
        Me.ABTimed = New System.Windows.Forms.RadioButton()
        Me.ABOff = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TimeChooser = New System.Windows.Forms.TextBox()
        Me.TickChooser = New System.Windows.Forms.ComboBox()
        Me.AMPMChooser = New System.Windows.Forms.ComboBox()
        Me.ABSuper = New System.Windows.Forms.RadioButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlazeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlazeButton
        '
        Me.BlazeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlazeButton.Location = New System.Drawing.Point(248, 226)
        Me.BlazeButton.Name = "BlazeButton"
        Me.BlazeButton.Size = New System.Drawing.Size(75, 23)
        Me.BlazeButton.TabIndex = 0
        Me.BlazeButton.Text = "Blaze It!"
        Me.BlazeButton.UseVisualStyleBackColor = True
        '
        'LoadBar
        '
        Me.LoadBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadBar.Location = New System.Drawing.Point(13, 226)
        Me.LoadBar.Name = "LoadBar"
        Me.LoadBar.Size = New System.Drawing.Size(229, 23)
        Me.LoadBar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "AutoBlaze Settings"
        '
        'ABEvery
        '
        Me.ABEvery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ABEvery.AutoSize = True
        Me.ABEvery.Location = New System.Drawing.Point(6, 62)
        Me.ABEvery.Name = "ABEvery"
        Me.ABEvery.Size = New System.Drawing.Size(81, 17)
        Me.ABEvery.TabIndex = 8
        Me.ABEvery.Text = "Blaze Every"
        Me.ABEvery.UseVisualStyleBackColor = True
        '
        'ABTimed
        '
        Me.ABTimed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ABTimed.AutoSize = True
        Me.ABTimed.Location = New System.Drawing.Point(6, 41)
        Me.ABTimed.Name = "ABTimed"
        Me.ABTimed.Size = New System.Drawing.Size(63, 17)
        Me.ABTimed.TabIndex = 7
        Me.ABTimed.Text = "Blaze at"
        Me.ABTimed.UseVisualStyleBackColor = True
        '
        'ABOff
        '
        Me.ABOff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ABOff.AutoSize = True
        Me.ABOff.Checked = True
        Me.ABOff.Location = New System.Drawing.Point(6, 17)
        Me.ABOff.Name = "ABOff"
        Me.ABOff.Size = New System.Drawing.Size(90, 17)
        Me.ABOff.TabIndex = 6
        Me.ABOff.TabStop = True
        Me.ABOff.Text = "AutoBlaze Off"
        Me.ABOff.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 145)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TimeChooser)
        Me.Panel1.Controls.Add(Me.TickChooser)
        Me.Panel1.Controls.Add(Me.AMPMChooser)
        Me.Panel1.Controls.Add(Me.ABSuper)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ABEvery)
        Me.Panel1.Controls.Add(Me.ABTimed)
        Me.Panel1.Controls.Add(Me.ABOff)
        Me.Panel1.Location = New System.Drawing.Point(176, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 118)
        Me.Panel1.TabIndex = 2
        '
        'TimeChooser
        '
        Me.TimeChooser.Location = New System.Drawing.Point(72, 42)
        Me.TimeChooser.Name = "TimeChooser"
        Me.TimeChooser.Size = New System.Drawing.Size(40, 20)
        Me.TimeChooser.TabIndex = 13
        Me.TimeChooser.Text = "4:20"
        '
        'TickChooser
        '
        Me.TickChooser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TickChooser.AutoCompleteCustomSource.AddRange(New String() {"5", "10", "15", "30", "45", "60", "120"})
        Me.TickChooser.FormattingEnabled = True
        Me.TickChooser.Items.AddRange(New Object() {"5", "10", "15", "30", "45", "60"})
        Me.TickChooser.Location = New System.Drawing.Point(93, 62)
        Me.TickChooser.Name = "TickChooser"
        Me.TickChooser.Size = New System.Drawing.Size(66, 21)
        Me.TickChooser.TabIndex = 12
        Me.TickChooser.Text = "5"
        '
        'AMPMChooser
        '
        Me.AMPMChooser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AMPMChooser.FormattingEnabled = True
        Me.AMPMChooser.Items.AddRange(New Object() {"AM", "PM"})
        Me.AMPMChooser.Location = New System.Drawing.Point(118, 41)
        Me.AMPMChooser.MaxLength = 2
        Me.AMPMChooser.Name = "AMPMChooser"
        Me.AMPMChooser.Size = New System.Drawing.Size(41, 21)
        Me.AMPMChooser.TabIndex = 11
        Me.AMPMChooser.Text = "PM"
        '
        'ABSuper
        '
        Me.ABSuper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ABSuper.AutoSize = True
        Me.ABSuper.Location = New System.Drawing.Point(6, 85)
        Me.ABSuper.Name = "ABSuper"
        Me.ABSuper.Size = New System.Drawing.Size(82, 17)
        Me.ABSuper.TabIndex = 10
        Me.ABSuper.TabStop = True
        Me.ABSuper.Text = "Super Blaze"
        Me.ABSuper.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "AutoBlaze"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Double Click to Open AutoBlaze"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BlazeTimer
        '
        Me.BlazeTimer.Enabled = True
        Me.BlazeTimer.Interval = 1000
        '
        'AutoBlaze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoadBar)
        Me.Controls.Add(Me.BlazeButton)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "AutoBlaze"
        Me.Text = "AutoBlaze"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BlazeButton As Button
    Friend WithEvents LoadBar As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents ABEvery As RadioButton
    Friend WithEvents ABTimed As RadioButton
    Friend WithEvents ABOff As RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ABSuper As RadioButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlazeTimer As Timer
    Friend WithEvents AMPMChooser As ComboBox
    Friend WithEvents TickChooser As ComboBox
    Friend WithEvents TimeChooser As TextBox
End Class
