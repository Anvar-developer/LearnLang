namespace LearnLang.WinForms
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
            Button Start;
            Mix = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            Back = new Button();
            Next = new Button();
            label1 = new Label();
            Validate = new Button();
            textBox1 = new TextBox();
            Start = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.None;
            Start.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.Location = new Point(41, 73);
            Start.Name = "Start";
            Start.RightToLeft = RightToLeft.No;
            Start.Size = new Size(159, 151);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Mix
            // 
            Mix.Anchor = AnchorStyles.None;
            Mix.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Mix.Location = new Point(282, 73);
            Mix.MinimumSize = new Size(144, 151);
            Mix.Name = "Mix";
            Mix.Size = new Size(144, 151);
            Mix.TabIndex = 1;
            Mix.Text = "Mix";
            Mix.UseVisualStyleBackColor = true;
            Mix.Click += Mix_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Start);
            panel1.Controls.Add(Mix);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 312);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(Back);
            panel2.Controls.Add(Next);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Validate);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 312);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // Back
            // 
            Back.Cursor = Cursors.IBeam;
            Back.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Back.Location = new Point(3, 3);
            Back.Name = "Back";
            Back.Size = new Size(83, 84);
            Back.TabIndex = 12;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Next
            // 
            Next.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Next.Location = new Point(280, 203);
            Next.Name = "Next";
            Next.Size = new Size(79, 81);
            Next.TabIndex = 11;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(146, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // Validate
            // 
            Validate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Validate.Location = new Point(146, 203);
            Validate.Name = "Validate";
            Validate.Size = new Size(80, 81);
            Validate.TabIndex = 9;
            Validate.Text = "Validate";
            Validate.UseVisualStyleBackColor = true;
            Validate.Click += Validate_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(146, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 33);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(505, 312);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Mix;
        private Button Start;
        private Panel panel1;
        private Panel panel2;
        private Button Next;
        private Label label1;
        private Button Validate;
        private TextBox textBox1;
        private Button Back;
    }
}
