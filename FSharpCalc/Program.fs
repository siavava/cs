
// Simple Calculator In F#
// ---------------------------
// Hi, This is my second F# windows program.

open System;
open System.Windows;
open System.Windows.Forms;
open System.Drawing;
open System.Drawing.Drawing2D;

type MainWindow() = 
    inherit Form()

    let btnNumbers: Button array = Array.zeroCreate 10

    let btnAdd = new Button()
    let btnMin = new Button()
    let btnMul = new Button()
    let btnDiv = new Button()

    let btnEqual = new Button()
    let btnClear = new Button()

    let lblDisplay = new Label()

    let mutable doClear = false

    let mutable operation = 0
    let mutable operand1 :Int64 = int64 0
    let mutable operand2 :Int64 = int64 0

    // Our initializer function
    member this.Init =
        this.Text <- "Simple Calculator In F#"
        this.Size <- new System.Drawing.Size(270, 400)
        this.FormBorderStyle <- FormBorderStyle.Fixed3D
        this.MaximizeBox <- false
        this.BackColor <- System.Drawing.Color.FromArgb(255, 225, 235)

        this.Paint.AddHandler(new Windows.Forms.PaintEventHandler(fun s pe -> this.Event_Paint(s, pe)))

        lblDisplay.Location <- Point(30, 90)
        lblDisplay.Size <- Size(190, 40)
        lblDisplay.Text <- "0"
        lblDisplay.BackColor <- System.Drawing.Color.White
        lblDisplay.Font <- new Font("Arial", 16.0f)
        lblDisplay.BorderStyle <- BorderStyle.Fixed3D
        lblDisplay.TextAlign <- ContentAlignment.BottomRight

        let mutable btnX = 30
        let mutable btnY = 300

        for i in 0 .. btnNumbers.Length - 1 do

            btnNumbers.[i] <- new Button()

            btnNumbers.[i].Location <- Point(btnX, btnY)
            btnNumbers.[i].Size <- Size(40, 40)
            btnNumbers.[i].Text <- i.ToString()
            //btnNumbers.[i].BackColor <- System.Drawing.Color.White
            btnNumbers.[i].Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Number_Pressed(s, e)))

            this.Controls.Add(btnNumbers.[i])

            if i = 0 then
                btnY <- btnY - 50
            else
                if i % 3 = 0 then
                    btnX <- 30
                    btnY <- btnY - 50
                else
                    btnX <- btnX + 50

        btnNumbers.[0].BackColor <- System.Drawing.Color.Yellow
        btnNumbers.[1].BackColor <- System.Drawing.Color.FromArgb(157, 238, 198)
        btnNumbers.[2].BackColor <- btnNumbers.[1].BackColor
        btnNumbers.[3].BackColor <- btnNumbers.[1].BackColor

        btnNumbers.[4].BackColor <- System.Drawing.Color.FromArgb(146, 216, 250)
        btnNumbers.[5].BackColor <- btnNumbers.[4].BackColor
        btnNumbers.[6].BackColor <- btnNumbers.[4].BackColor

        btnNumbers.[7].BackColor <- System.Drawing.Color.FromArgb(255, 184, 149)
        btnNumbers.[8].BackColor <- btnNumbers.[7].BackColor
        btnNumbers.[9].BackColor <- btnNumbers.[7].BackColor

        btnAdd.Location <- Point(180, 300)
        btnAdd.Size <- Size(40, 40)
        btnAdd.Text <- "+"
        btnAdd.BackColor <- System.Drawing.Color.FromArgb(187, 208, 185)
        btnAdd.Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Operation_Pressed(s, e)))

        btnMin.Location <- Point(180, 250)
        btnMin.Size <- Size(40, 40)
        btnMin.Text <- "-"
        btnMin.BackColor <- btnAdd.BackColor
        btnMin.Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Operation_Pressed(s, e)))

        btnMul.Location <- Point(180, 200)
        btnMul.Size <- Size(40, 40)
        btnMul.Text <- "*"
        btnMul.BackColor <- btnAdd.BackColor
        btnMul.Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Operation_Pressed(s, e)))

        btnDiv.Location <- Point(180, 150)
        btnDiv.Size <- Size(40, 40)
        btnDiv.Text <- "/"
        btnDiv.BackColor <- btnAdd.BackColor
        btnDiv.Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Operation_Pressed(s, e)))

        btnClear.Location <- Point(80, 300)
        btnClear.Size <- Size(40, 40)
        btnClear.Text <- "C"
        btnClear.Font <- new Font("Arial", 14.0f)
        btnClear.ForeColor <- System.Drawing.Color.White
        btnClear.BackColor <- System.Drawing.Color.Red
        btnClear.Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Clear_Pressed(s, e)))

        btnEqual.Location <- Point(130, 300)
        btnEqual.Size <- Size(40, 40)
        btnEqual.Text <- "="
        btnEqual.Font <- new Font("Arial", 16.0f)
        btnEqual.ForeColor <- System.Drawing.Color.White
        btnEqual.BackColor <- System.Drawing.Color.Gray

        btnEqual.Click.AddHandler(new System.EventHandler(fun s e -> this.Event_Equal_Pressed(s, e)))

        this.Controls.Add(lblDisplay)

        this.Controls.Add(btnClear)
        this.Controls.Add(btnEqual)
        this.Controls.Add(btnAdd)
        this.Controls.Add(btnMin)
        this.Controls.Add(btnMul)
        this.Controls.Add(btnDiv)

    member this.DoOperation() = 
        if operation = 1 then // Add
            lblDisplay.Text <- (operand1 + operand2).ToString()
        else if operation = 2 then // Min
            lblDisplay.Text <- (operand1 - operand2).ToString()
        else if operation = 3 then // Mul
            lblDisplay.Text <- (operand1 * operand2).ToString()
        else if operation = 4 then // Div
            lblDisplay.Text <- (operand1 / operand2).ToString()

    member this.Event_Clear_Pressed(sender : System.Object, e : System.EventArgs) = 
        operation <- 0
        operand1 <- int64 0
        operand2 <- int64 0

        lblDisplay.Text <- "0"

    member this.Event_Equal_Pressed(sender : System.Object, e : System.EventArgs) = 

        this.DoOperation()

        operand1 <- Int64.Parse(lblDisplay.Text)
        doClear <- true

    member this.downcastButton(b1 : Object) =
       match b1 with
       | :? Button as derived1 -> derived1
       | _ -> null

    member this.Event_Operation_Pressed(sender : System.Object, e : System.EventArgs) = 

        let btn = this.downcastButton(sender)

        operation <- 
            match btn.Text.[0] with 
            | '+' -> 1
            | '-' -> 2
            | '*' -> 3
            | '/' -> 4
            | _ -> 1
        doClear <- true

        if operand2 <> int64 0 then
            this.DoOperation()
            operand1 <- Int64.Parse(lblDisplay.Text)

    member this.Event_Number_Pressed(sender : System.Object, e : System.EventArgs) = 
        let btn = this.downcastButton(sender)

        if lblDisplay.Text = "0" then
            doClear <- true

        if doClear = true then
            lblDisplay.Text <- ""
            doClear <- false

        if lblDisplay.Text.Length < 17 then
            if operation = 0 then
                lblDisplay.Text <- lblDisplay.Text + btn.Text
                operand1 <- Int64.Parse(lblDisplay.Text)
            else
                lblDisplay.Text <- lblDisplay.Text + btn.Text
                operand2 <- Int64.Parse(lblDisplay.Text)

    // Our paint event
    member this.Event_Paint(sender : System.Object, e : PaintEventArgs) = 

        e.Graphics.SmoothingMode <- SmoothingMode.HighQuality
        e.Graphics.CompositingQuality <- CompositingQuality.HighQuality

[<STAThread>]
let START = 

    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    let mainWindow = new MainWindow()

    // Here we initialize our main window through calling this member function.
    mainWindow.Init

    //mainWindow.Show()
    // Lets run our application
    Application.Run(mainWindow)
