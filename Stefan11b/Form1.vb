Public Class Form1
    'Dim a, b, h, ha, r As Decimal

    ' Деклариране на променливите, които ще ни бъдат нужни
    Dim squareA, rectangleA, trapezeA, coneR, coneH, rectangleB, trapezeB, circleR, cylinderR, trapezeH, cylinderH, coneL As Double
    Dim clear As String = String.Empty

    Private Sub squareATxt_TextChanged(sender As Object, e As EventArgs) Handles squareATxt.TextChanged
        ' променливата присвоява стойност от текстово поле на страната на квадрата
        squareA = squareATxt.Text
    End Sub

    Private Sub rectangleAtxt_TextChanged(sender As Object, e As EventArgs) Handles rectangleATxt.TextChanged
        ' променливата присвоява стойност от текстово поле на първата страна на правоъгълника
        rectangleA = rectangleATxt.Text
    End Sub

    Private Sub rectangleBTxt_TextChanged(sender As Object, e As EventArgs) Handles rectangleBTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на втората страна на правоъгълника
        rectangleB = rectangleBTxt.Text
    End Sub

    Private Sub circleTxt_TextChanged(sender As Object, e As EventArgs) Handles circleRTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на радиуса на окръжността
        circleR = circleRTxt.Text
    End Sub

    Private Sub trapezeATxt_TextChanged(sender As Object, e As EventArgs) Handles trapezeATxt.TextChanged
        ' променливата присвоява стойност от текстово поле на първата основа на трапеца
        trapezeA = trapezeATxt.Text
    End Sub

    Private Sub trapezeBTxt_TextChanged(sender As Object, e As EventArgs) Handles trapezeBTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на втората основа на трапеца
        trapezeB = trapezeBTxt.Text
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles trapezeHTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на височината на трапеца
        trapezeH = trapezeHTxt.Text
    End Sub

    Private Sub cylinderRTxt_TextChanged(sender As Object, e As EventArgs) Handles cylinderRTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на радиуса на цилиндъра
        cylinderR = cylinderRTxt.Text
    End Sub

    Private Sub cylinderHTxt_TextChanged(sender As Object, e As EventArgs) Handles cylinderHTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на височината на цилиндъра
        cylinderH = cylinderHTxt.Text
    End Sub

    Private Sub coneATxt_TextChanged(sender As Object, e As EventArgs) Handles coneRTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на радиуса на конуса
        coneR = coneRTxt.Text
    End Sub

    Private Sub coneHaTxt_TextChanged(sender As Object, e As EventArgs) Handles coneHTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на височината на конуса
        coneH = coneHTxt.Text
    End Sub

    Private Sub coneLTxt_TextChanged(sender As Object, e As EventArgs) Handles coneLTxt.TextChanged
        ' променливата присвоява стойност от текстово поле на обаразуващата на конуса
        coneL = coneLTxt.Text
    End Sub

    Private Sub squareTourBtn_Click(sender As Object, e As EventArgs) Handles squareResultBtn.Click
        ' задаване на стойноста на текстовото поле на квадрата което е обиколката
        squareResultTxt.Text = squareA * 4
        ' задаване на стойноста на текстовото поле на квадрата което е лицето
        squareSecondResultTxt.Text = squareA * squareA
    End Sub

    Private Sub rectangleТourBtn_Click(sender As Object, e As EventArgs) Handles rectangleResultBtn.Click
        '  задаване на стойноста на текстовото поле на правоъгълника което е обиколката
        rectangleResultTxt.Text = Val((rectangleA * 2) + (rectangleB * 2))
        'задаване на стойноста на текстовото поле на правоъгълника което е лицето
        rectangleSecondResultTxt.Text = Val(rectangleA * rectangleB)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TriangleТourBtn_Click(sender As Object, e As EventArgs) Handles CircleResultBtn.Click
        ' задаване на стойноста на текстовото поле на кръга което е лицето
        circleResultTxt.Text = Val(Math.PI + Math.Sqrt(circleR))
        ' задаване на стойноста на текстовото поле на кръга което е обиколката
        circleSecondResultTxt.Text = Val(2 * Math.PI + circleR)
    End Sub

    Private Sub trapezeResultBtn_Click(sender As Object, e As EventArgs) Handles trapezeResultBtn.Click
        ' задаване на стойноста на текстовото поле на трапеца което е лицето
        trapezeResultTxt.Text = Val(((trapezeA + trapezeB) * trapezeH) / 0.5)
    End Sub

    Private Sub cylinderResultBtn_Click(sender As Object, e As EventArgs) Handles cylinderResultBtn.Click
        ' задаване на стойноста на текстовото поле на цилиндъра което е обема
        cylinderResultTxt.Text = Val(Math.PI * Math.Sqrt(cylinderR) * cylinderH)
        ' задаване на стойноста на текстовото поле на цилиндъра което е околна повърхнина
        cylinderSecondResultTxt.Text = Val(2 * Math.PI * cylinderR * cylinderH)
    End Sub

    Private Sub coneResultBtn_Click(sender As Object, e As EventArgs) Handles coneResultBtn.Click
        ' задаване на стойноста на текстовото поле на конуса което е обема
        coneResultTxt.Text = Val((Math.PI * Math.Sqrt(coneR) * coneH) / 3)
        ' задаване на стойноста на текстовото поле на конуса което е околна повърхнина
        coneSecondResultTxt.Text = Val(Math.PI * coneR * coneL)
    End Sub

    ' Метод който изчиства всички 
    Public Sub ClearAllTextBoxes()
        ' изчиства текстовото поле на квадрата
        squareATxt.Text = clear
        squareResultTxt.Text = clear
        squareSecondResultTxt.Text = clear
        ' изчиства текстовото поле на кръга 
        circleRTxt.Text = clear
        circleResultTxt.Text = clear
        circleSecondResultTxt.Text = clear
        ' изчиства текстовото поле на правоъгълника
        rectangleATxt.Text = clear
        rectangleBTxt.Text = clear
        rectangleResultTxt.Text = clear
        rectangleSecondResultTxt.Text = clear
        ' изчиства текстовото поле на трапеца
        trapezeATxt.Text = clear
        trapezeBTxt.Text = clear
        trapezeHTxt.Text = clear
        trapezeResultTxt.Text = clear
        ' изчиства текстовото поле на цилиндъра
        cylinderRTxt.Text = clear
        cylinderHTxt.Text = clear
        cylinderResultTxt.Text = clear
        cylinderSecondResultTxt.Text = clear
        ' изчиства текстовото поле на коноса
        coneRTxt.Text = clear
        coneHTxt.Text = clear
        coneResultTxt.Text = clear
        coneSecondResultTxt.Text = clear

        'squareATxt.Clear() !!!,
    End Sub

    Private Sub squareClearBtn_Click(sender As Object, e As EventArgs) Handles squareClearBtn.Click
        ' метода изчиства текстовите полета на квадрата
        ClearAllTextBoxes()
    End Sub
    Private Sub TriangleClearBtn_Click(sender As Object, e As EventArgs) Handles circleClearBtn.Click
        ' метода изчиства текстовите полета на правоъгълника
        ClearAllTextBoxes()
    End Sub

    Private Sub rectangleClearBtn_Click(sender As Object, e As EventArgs) Handles rectangleClearBtn.Click
        ' метода изчиства текстовите полета на кръга
        ClearAllTextBoxes()
    End Sub

    Private Sub trapezeClearBtn_Click(sender As Object, e As EventArgs) Handles trapezeClearBtn.Click
        ' метода изчиства текстовите полета на трапеца
        ClearAllTextBoxes()
    End Sub

    Private Sub cylinderClearBtn_Click(sender As Object, e As EventArgs) Handles cylinderClearBtn.Click
        ' метода изчиства текстовите полета на цилиндъра
        ClearAllTextBoxes()
    End Sub
    Private Sub coneClearBtn_Click(sender As Object, e As EventArgs) Handles coneClearBtn.Click
        ' метода изчиства текстовите полета на конуса
        ClearAllTextBoxes()
    End Sub

End Class
