Imports System.Diagnostics.Eventing.Reader

Public Class FrmMain
    Dim points As Integer = 1000
    Dim random As New Random()
    Dim bet As Integer
    Dim betButton As Button
    Dim clickedButton As Button
    Dim rollsLeft As Integer = 12

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblPoints.Text = "Your points: " & points
        LblResult.Hide()
        LblResultTittle.Hide()
        LblYourBet.Hide()
        LblYourPointsNow.Hide()
        PicResult.Hide()
        BtnPlayAgain.Hide()
    End Sub

    Private Function RollDice() As Integer
        Dim random As New Random()
        Return random.Next(1, 7)
    End Function

    Private Sub BetButtonClick(sender As Object, e As EventArgs) Handles BtnDice1.Click, BtnDice2.Click, BtnDice3.Click, BtnDice4.Click, BtnDice5.Click, BtnDice6.Click
        clickedButton = DirectCast(sender, Button)
        Dim bet As Integer
        If Not String.IsNullOrEmpty(TxtBet.Text) AndAlso Integer.TryParse(TxtBet.Text, bet) AndAlso bet >= 0 Then
            If Not bet = 0 Then
                LblPoints.Hide()
                TxtBet.Hide()
                BtnDice1.Hide()
                BtnDice2.Hide()
                BtnDice3.Hide()
                BtnDice4.Hide()
                BtnDice5.Hide()
                BtnDice6.Hide()
                LblTitle.Hide()

                PicResult.Show()
                TmrRoll.Start()
            ElseIf bet > points Then
                MsgBox("A aposta não pode ser maior ou menor do que os pontos disponíveis.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Else
                MsgBox("Insira um valor válido para a aposta.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Insira um valor válido para a aposta.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TmrRoll_Tick(sender As Object, e As EventArgs) Handles TmrRoll.Tick


        If rollsLeft > 0 Then
            Dim imageIndex As Integer = random.Next(1, 7)
            PicResult.BackgroundImage = My.Resources.ResourceManager.GetObject("dice-" & imageIndex)
            rollsLeft -= 1
        Else
            TmrRoll.Stop()

            Dim buttonNumber As Integer = Convert.ToInt32(clickedButton.Tag)

            Dim bet As Integer = TxtBet.text
            If points >= bet And bet > 0 Then
                points = points - bet
                Dim diceResult As Integer = RollDice()

                If diceResult = buttonNumber Then
                    points += bet * 3
                    LblResultTittle.Show()
                    BtnPlayAgain.Show()
                    LblYourPointsNow.Show()
                    LblYourPointsNow.Text = "Your points now: " & points
                    LblYourBet.Text = "Your bet: " & buttonNumber
                    LblYourBet.Show()
                    LblResultTittle.Text = "You won!"
                    LblResult.Show()
                Else
                    LblResultTittle.Show()
                    LblYourBet.Show()
                    LblYourBet.Text = "Your bet: " & buttonNumber
                    LblResultTittle.Text = "You lost :/"
                    BtnPlayAgain.Show()
                    LblYourPointsNow.Show()
                    LblYourPointsNow.Text = "Your points now: " & points
                    LblResult.Show()
                End If

                PicResult.BackgroundImage = My.Resources.ResourceManager.GetObject("dice-" & diceResult)
                LblPoints.Text = "Your points: " & points
                LblResult.Text = "Result: " & diceResult
            End If
        End If
    End Sub

    Private Sub BtnPlayAgain_Click(sender As Object, e As EventArgs) Handles BtnPlayAgain.Click
        LblResult.Hide()
        LblResultTittle.Hide()
        LblYourBet.Hide()
        LblYourPointsNow.Hide()
        PicResult.Hide()
        BtnPlayAgain.Hide()

        LblPoints.Show()
        TxtBet.Show()
        BtnDice1.Show()
        BtnDice2.Show()
        BtnDice3.Show()
        BtnDice4.Show()
        BtnDice5.Show()
        BtnDice6.Show()
        LblTitle.Show()

        PicResult.Hide()
        LblResultTittle.Hide()
        BtnPlayAgain.Hide()
        LblYourPointsNow.Hide()
        TxtBet.Clear()
        rollsLeft = 12
    End Sub
End Class