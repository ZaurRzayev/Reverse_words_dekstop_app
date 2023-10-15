namespace Solution1
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
            label1 = new Label();
            Words = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Reverse_Button = new Button();
            label2 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Word";
            label1.Click += label1_Click;
            // 
            // Words
            // 
            Words.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Words.Location = new Point(12, 27);
            Words.Name = "Words";
            Words.Size = new Size(801, 23);
            Words.TabIndex = 1;
            Words.TextChanged += Words_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(Reverse_Button, 0, 0);
            tableLayoutPanel1.Location = new Point(132, 512);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(372, 57);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Reverse_Button
            // 
            Reverse_Button.Location = new Point(3, 3);
            Reverse_Button.Name = "Reverse_Button";
            Reverse_Button.Size = new Size(170, 51);
            Reverse_Button.TabIndex = 0;
            Reverse_Button.Text = "Reverse";
            Reverse_Button.UseVisualStyleBackColor = true;
            Reverse_Button.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(180, 3);
            button1.Name = "button1";
            button1.Size = new Size(186, 51);
            button1.TabIndex = 4;
            button1.Text = "Clean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 581);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Words);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Words;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Reverse_Button;
        private Label label2;
        private Button button1;
    }
}