namespace WinForms_Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCircle = new Button();
            panelCanvas = new FlowLayoutPanel();
            btnSquare = new Button();
            btnTriangle = new Button();
            btnClear = new Button();
            btnColor = new Button();
            colorDialog = new ColorDialog();
            btnUndo = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            btnPen = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCircle
            // 
            btnCircle.Location = new Point(43, 48);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(112, 34);
            btnCircle.TabIndex = 0;
            btnCircle.Text = "Cirkel";
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // panelCanvas
            // 
            panelCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCanvas.Location = new Point(43, 125);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(707, 299);
            panelCanvas.TabIndex = 1;
            panelCanvas.Paint += panelCanvas_Paint;
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(242, 48);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(112, 34);
            btnSquare.TabIndex = 2;
            btnSquare.Text = "Fyrkant";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Location = new Point(442, 48);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(112, 34);
            btnTriangle.TabIndex = 3;
            btnTriangle.Text = "Triangel";
            btnTriangle.UseVisualStyleBackColor = true;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(638, 48);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Rensa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(43, 8);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(112, 34);
            btnColor.TabIndex = 5;
            btnColor.Text = "Färg";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(638, 8);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(112, 34);
            btnUndo.TabIndex = 6;
            btnUndo.Text = "Ångra";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(442, 8);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 8;
            btnOpen.Text = "Öppna fil";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnPen
            // 
            btnPen.Location = new Point(688, 404);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(112, 34);
            btnPen.TabIndex = 10;
            btnPen.Text = "Penna";
            btnPen.UseVisualStyleBackColor = true;
            btnPen.Click += btnPen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 97);
            label1.Name = "label1";
            label1.Size = new Size(676, 25);
            label1.TabIndex = 11;
            label1.Text = "Välj en färg och figur, håll ner musen och dra här nedan för att rita den valda figuren";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnPen);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(btnUndo);
            Controls.Add(btnColor);
            Controls.Add(btnClear);
            Controls.Add(btnTriangle);
            Controls.Add(btnSquare);
            Controls.Add(panelCanvas);
            Controls.Add(btnCircle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCircle;
        private FlowLayoutPanel panelCanvas;
        private Button btnSquare;
        private Button btnTriangle;
        private Button btnClear;
        private Button btnColor;
        private ColorDialog colorDialog;
        private Button btnUndo;
        private Button btnSave;
        private Button btnOpen;
        private Button btnPen;
        private Label label1;
    }
}