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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            Reverse_Button = new Button();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Reversing words";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(Reverse_Button, 0, 0);
            tableLayoutPanel1.Location = new Point(132, 580);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(365, 56);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(176, 3);
            button1.Name = "button1";
            button1.Size = new Size(186, 50);
            button1.TabIndex = 4;
            button1.Text = "Clean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Reverse_Button
            // 
            Reverse_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Reverse_Button.Location = new Point(3, 3);
            Reverse_Button.Name = "Reverse_Button";
            Reverse_Button.Size = new Size(164, 50);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 680);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Reverse_Button;
        private Label label2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}