<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnDice3 = New System.Windows.Forms.Button()
        Me.BtnDice4 = New System.Windows.Forms.Button()
        Me.BtnDice5 = New System.Windows.Forms.Button()
        Me.BtnDice6 = New System.Windows.Forms.Button()
        Me.TxtBet = New System.Windows.Forms.TextBox()
        Me.BtnDice2 = New System.Windows.Forms.Button()
        Me.BtnDice1 = New System.Windows.Forms.Button()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.PicResult = New System.Windows.Forms.PictureBox()
        Me.LblResultTittle = New System.Windows.Forms.Label()
        Me.LblYourBet = New System.Windows.Forms.Label()
        Me.LblPoints = New System.Windows.Forms.Label()
        Me.LblPlayAgain = New System.Windows.Forms.Label()
        Me.BtnPlayAgain = New System.Windows.Forms.Button()
        Me.LblYourPointsNow = New System.Windows.Forms.Label()
        Me.TmrRoll = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Poppins Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(74, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(211, 56)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Dice Game"
        '
        'BtnDice3
        '
        Me.BtnDice3.BackgroundImage = Global.DiceGame.My.Resources.Resources.dice_3
        Me.BtnDice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDice3.Location = New System.Drawing.Point(244, 197)
        Me.BtnDice3.Name = "BtnDice3"
        Me.BtnDice3.Size = New System.Drawing.Size(75, 78)
        Me.BtnDice3.TabIndex = 3
        Me.BtnDice3.Tag = "3"
        Me.BtnDice3.UseVisualStyleBackColor = True
        '
        'BtnDice4
        '
        Me.BtnDice4.BackgroundImage = Global.DiceGame.My.Resources.Resources.dice_4
        Me.BtnDice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDice4.Location = New System.Drawing.Point(42, 299)
        Me.BtnDice4.Name = "BtnDice4"
        Me.BtnDice4.Size = New System.Drawing.Size(75, 78)
        Me.BtnDice4.TabIndex = 4
        Me.BtnDice4.Tag = "4"
        Me.BtnDice4.UseVisualStyleBackColor = True
        '
        'BtnDice5
        '
        Me.BtnDice5.BackgroundImage = Global.DiceGame.My.Resources.Resources.dice_5
        Me.BtnDice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDice5.Location = New System.Drawing.Point(142, 299)
        Me.BtnDice5.Name = "BtnDice5"
        Me.BtnDice5.Size = New System.Drawing.Size(75, 78)
        Me.BtnDice5.TabIndex = 5
        Me.BtnDice5.Tag = "5"
        Me.BtnDice5.UseVisualStyleBackColor = True
        '
        'BtnDice6
        '
        Me.BtnDice6.BackgroundImage = Global.DiceGame.My.Resources.Resources.dice_6
        Me.BtnDice6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDice6.Location = New System.Drawing.Point(244, 299)
        Me.BtnDice6.Name = "BtnDice6"
        Me.BtnDice6.Size = New System.Drawing.Size(75, 78)
        Me.BtnDice6.TabIndex = 6
        Me.BtnDice6.Tag = "6"
        Me.BtnDice6.UseVisualStyleBackColor = True
        '
        'TxtBet
        '
        Me.TxtBet.Location = New System.Drawing.Point(130, 117)
        Me.TxtBet.Name = "TxtBet"
        Me.TxtBet.Size = New System.Drawing.Size(100, 20)
        Me.TxtBet.TabIndex = 7
        '
        'BtnDice2
        '
        Me.BtnDice2.BackgroundImage = Global.DiceGame.My.Resources.Resources.dice_2
        Me.BtnDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDice2.Location = New System.Drawing.Point(142, 197)
        Me.BtnDice2.Name = "BtnDice2"
        Me.BtnDice2.Size = New System.Drawing.Size(75, 78)
        Me.BtnDice2.TabIndex = 2
        Me.BtnDice2.Tag = "2"
        Me.BtnDice2.UseVisualStyleBackColor = True
        '
        'BtnDice1
        '
        Me.BtnDice1.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDice1.BackgroundImage = Global.DiceGame.My.Resources.Resources.dice_1
        Me.BtnDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDice1.Location = New System.Drawing.Point(42, 197)
        Me.BtnDice1.Name = "BtnDice1"
        Me.BtnDice1.Size = New System.Drawing.Size(75, 78)
        Me.BtnDice1.TabIndex = 1
        Me.BtnDice1.Tag = "1"
        Me.BtnDice1.UseVisualStyleBackColor = True
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.Location = New System.Drawing.Point(150, 413)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(67, 28)
        Me.LblResult.TabIndex = 9
        Me.LblResult.Text = "Label1"
        '
        'PicResult
        '
        Me.PicResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicResult.Location = New System.Drawing.Point(94, 143)
        Me.PicResult.Name = "PicResult"
        Me.PicResult.Size = New System.Drawing.Size(172, 172)
        Me.PicResult.TabIndex = 10
        Me.PicResult.TabStop = False
        '
        'LblResultTittle
        '
        Me.LblResultTittle.AutoSize = True
        Me.LblResultTittle.Font = New System.Drawing.Font("Poppins Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResultTittle.Location = New System.Drawing.Point(112, 39)
        Me.LblResultTittle.Name = "LblResultTittle"
        Me.LblResultTittle.Size = New System.Drawing.Size(151, 42)
        Me.LblResultTittle.TabIndex = 11
        Me.LblResultTittle.Text = "YOU WON!"
        '
        'LblYourBet
        '
        Me.LblYourBet.AutoSize = True
        Me.LblYourBet.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYourBet.Location = New System.Drawing.Point(137, 385)
        Me.LblYourBet.Name = "LblYourBet"
        Me.LblYourBet.Size = New System.Drawing.Size(67, 28)
        Me.LblYourBet.TabIndex = 12
        Me.LblYourBet.Text = "Label1"
        '
        'LblPoints
        '
        Me.LblPoints.AutoSize = True
        Me.LblPoints.Font = New System.Drawing.Font("Poppins Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPoints.Location = New System.Drawing.Point(115, 81)
        Me.LblPoints.Name = "LblPoints"
        Me.LblPoints.Size = New System.Drawing.Size(128, 22)
        Me.LblPoints.TabIndex = 8
        Me.LblPoints.Text = "Your Points: 1000"
        '
        'LblPlayAgain
        '
        Me.LblPlayAgain.AutoSize = True
        Me.LblPlayAgain.Location = New System.Drawing.Point(256, 124)
        Me.LblPlayAgain.Name = "LblPlayAgain"
        Me.LblPlayAgain.Size = New System.Drawing.Size(0, 13)
        Me.LblPlayAgain.TabIndex = 13
        '
        'BtnPlayAgain
        '
        Me.BtnPlayAgain.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlayAgain.Location = New System.Drawing.Point(119, 79)
        Me.BtnPlayAgain.Name = "BtnPlayAgain"
        Me.BtnPlayAgain.Size = New System.Drawing.Size(133, 32)
        Me.BtnPlayAgain.TabIndex = 14
        Me.BtnPlayAgain.Text = "Play Again"
        Me.BtnPlayAgain.UseVisualStyleBackColor = True
        '
        'LblYourPointsNow
        '
        Me.LblYourPointsNow.AutoSize = True
        Me.LblYourPointsNow.Font = New System.Drawing.Font("Poppins Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYourPointsNow.Location = New System.Drawing.Point(114, 121)
        Me.LblYourPointsNow.Name = "LblYourPointsNow"
        Me.LblYourPointsNow.Size = New System.Drawing.Size(149, 19)
        Me.LblYourPointsNow.TabIndex = 15
        Me.LblYourPointsNow.Text = "Your points now: 1000"
        '
        'TmrRoll
        '
        Me.TmrRoll.Interval = 200
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 450)
        Me.Controls.Add(Me.LblYourPointsNow)
        Me.Controls.Add(Me.BtnPlayAgain)
        Me.Controls.Add(Me.LblPlayAgain)
        Me.Controls.Add(Me.LblYourBet)
        Me.Controls.Add(Me.LblResultTittle)
        Me.Controls.Add(Me.PicResult)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.LblPoints)
        Me.Controls.Add(Me.TxtBet)
        Me.Controls.Add(Me.BtnDice6)
        Me.Controls.Add(Me.BtnDice5)
        Me.Controls.Add(Me.BtnDice4)
        Me.Controls.Add(Me.BtnDice3)
        Me.Controls.Add(Me.BtnDice2)
        Me.Controls.Add(Me.BtnDice1)
        Me.Controls.Add(Me.LblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "Dice Game"
        CType(Me.PicResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnDice1 As Button
    Friend WithEvents BtnDice2 As Button
    Friend WithEvents BtnDice3 As Button
    Friend WithEvents BtnDice4 As Button
    Friend WithEvents BtnDice5 As Button
    Friend WithEvents BtnDice6 As Button
    Friend WithEvents TxtBet As TextBox
    Friend WithEvents LblResult As Label
    Friend WithEvents PicResult As PictureBox
    Friend WithEvents LblResultTittle As Label
    Friend WithEvents LblYourBet As Label
    Friend WithEvents LblPoints As Label
    Friend WithEvents LblPlayAgain As Label
    Friend WithEvents BtnPlayAgain As Button
    Friend WithEvents LblYourPointsNow As Label
    Friend WithEvents TmrRoll As Timer
End Class
