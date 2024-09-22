namespace Alter
{
    partial class AgeCalculator
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
            Title = new Label();
            DaysLabel = new Label();
            DaysTitle = new Label();
            WeekLabel = new Label();
            WeekTitle = new Label();
            OrLabel = new Label();
            OrLabel2 = new Label();
            YearLabel = new Label();
            YearTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(144, 9);
            Title.Name = "Title";
            Title.Size = new Size(570, 90);
            Title.TabIndex = 0;
            Title.Text = "VentiLovers Age:";
            Title.Click += label1_Click;
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.Font = new Font("Comic Sans MS", 39.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DaysLabel.ImageAlign = ContentAlignment.TopCenter;
            DaysLabel.Location = new Point(507, 134);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Size = new Size(160, 75);
            DaysLabel.TabIndex = 1;
            DaysLabel.Text = "6969";
            DaysLabel.TextAlign = ContentAlignment.MiddleCenter;
            DaysLabel.Click += label1_Click_1;
            // 
            // DaysTitle
            // 
            DaysTitle.AutoSize = true;
            DaysTitle.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DaysTitle.Location = new Point(214, 119);
            DaysTitle.Name = "DaysTitle";
            DaysTitle.Size = new Size(234, 90);
            DaysTitle.TabIndex = 2;
            DaysTitle.Text = "days :";
            // 
            // WeekLabel
            // 
            WeekLabel.AutoSize = true;
            WeekLabel.Font = new Font("Comic Sans MS", 39.75F, FontStyle.Bold | FontStyle.Italic);
            WeekLabel.Location = new Point(507, 236);
            WeekLabel.Name = "WeekLabel";
            WeekLabel.Size = new Size(128, 75);
            WeekLabel.TabIndex = 3;
            WeekLabel.Text = "420";
            // 
            // WeekTitle
            // 
            WeekTitle.AutoSize = true;
            WeekTitle.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Italic);
            WeekTitle.Location = new Point(214, 236);
            WeekTitle.Name = "WeekTitle";
            WeekTitle.Size = new Size(276, 90);
            WeekTitle.TabIndex = 4;
            WeekTitle.Text = "weeks :";
            WeekTitle.Click += WeekTitle_Click;
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrLabel.Location = new Point(369, 209);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(0, 67);
            OrLabel.TabIndex = 5;
            // 
            // OrLabel2
            // 
            OrLabel2.AutoSize = true;
            OrLabel2.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrLabel2.Location = new Point(369, 359);
            OrLabel2.Name = "OrLabel2";
            OrLabel2.Size = new Size(0, 67);
            OrLabel2.TabIndex = 6;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Comic Sans MS", 39.75F, FontStyle.Bold | FontStyle.Italic);
            YearLabel.Location = new Point(507, 359);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(128, 75);
            YearLabel.TabIndex = 7;
            YearLabel.Text = "420";
            // 
            // YearTitle
            // 
            YearTitle.AutoSize = true;
            YearTitle.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Italic);
            YearTitle.Location = new Point(214, 344);
            YearTitle.Name = "YearTitle";
            YearTitle.Size = new Size(263, 90);
            YearTitle.TabIndex = 8;
            YearTitle.Text = "years :";
            YearTitle.Click += YearTitle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(683, 428);
            label1.Name = "label1";
            label1.Size = new Size(0, 90);
            label1.TabIndex = 9;
            label1.Click += label1_Click_2;
            // 
            // AgeCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(851, 510);
            Controls.Add(label1);
            Controls.Add(YearTitle);
            Controls.Add(YearLabel);
            Controls.Add(OrLabel2);
            Controls.Add(OrLabel);
            Controls.Add(WeekTitle);
            Controls.Add(WeekLabel);
            Controls.Add(DaysTitle);
            Controls.Add(DaysLabel);
            Controls.Add(Title);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgeCalculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label DaysLabel;
        private Label DaysTitle;
        private Label WeekLabel;
        private Label WeekTitle;
        private Label OrLabel;
        private Label OrLabel2;
        private Label YearLabel;
        private Label YearTitle;
        private Label label1;
    }
}
