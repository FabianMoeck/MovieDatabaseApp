namespace MovieDatabaseApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieList = new System.Windows.Forms.ListBox();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.AZradio = new System.Windows.Forms.RadioButton();
            this.Ratingradio = new System.Windows.Forms.RadioButton();
            this.NewObjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieList
            // 
            this.MovieList.FormattingEnabled = true;
            this.MovieList.Location = new System.Drawing.Point(12, 55);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(808, 407);
            this.MovieList.TabIndex = 0;
            // 
            // ConsoleText
            // 
            this.ConsoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleText.Location = new System.Drawing.Point(12, 470);
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.Size = new System.Drawing.Size(808, 26);
            this.ConsoleText.TabIndex = 1;
            this.ConsoleText.Text = "Console";
            // 
            // AZradio
            // 
            this.AZradio.AutoSize = true;
            this.AZradio.Checked = true;
            this.AZradio.Location = new System.Drawing.Point(330, 24);
            this.AZradio.Name = "AZradio";
            this.AZradio.Size = new System.Drawing.Size(83, 17);
            this.AZradio.TabIndex = 2;
            this.AZradio.TabStop = true;
            this.AZradio.Text = "Alphabetical";
            this.AZradio.UseVisualStyleBackColor = true;
            // 
            // Ratingradio
            // 
            this.Ratingradio.AutoSize = true;
            this.Ratingradio.Location = new System.Drawing.Point(421, 24);
            this.Ratingradio.Name = "Ratingradio";
            this.Ratingradio.Size = new System.Drawing.Size(56, 17);
            this.Ratingradio.TabIndex = 2;
            this.Ratingradio.Text = "Rating";
            this.Ratingradio.UseVisualStyleBackColor = true;
            // 
            // NewObjectBtn
            // 
            this.NewObjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewObjectBtn.Location = new System.Drawing.Point(678, 18);
            this.NewObjectBtn.Name = "NewObjectBtn";
            this.NewObjectBtn.Size = new System.Drawing.Size(142, 31);
            this.NewObjectBtn.TabIndex = 3;
            this.NewObjectBtn.Text = "New Show";
            this.NewObjectBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 502);
            this.Controls.Add(this.NewObjectBtn);
            this.Controls.Add(this.Ratingradio);
            this.Controls.Add(this.AZradio);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.MovieList);
            this.Name = "Form1";
            this.Text = "ShowDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieList;
        private System.Windows.Forms.TextBox ConsoleText;
        private System.Windows.Forms.RadioButton AZradio;
        private System.Windows.Forms.RadioButton Ratingradio;
        private System.Windows.Forms.Button NewObjectBtn;
    }
}

