namespace MovieDatabaseApp
{
    partial class AddWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Season = new System.Windows.Forms.Label();
            this.lbl_Ep = new System.Windows.Forms.Label();
            this.lbl_Comp = new System.Windows.Forms.Label();
            this.lbl_CS = new System.Windows.Forms.Label();
            this.lbl_CE = new System.Windows.Forms.Label();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.num_Seasons = new System.Windows.Forms.NumericUpDown();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.ck_Completed = new System.Windows.Forms.CheckBox();
            this.num_Episodes = new System.Windows.Forms.NumericUpDown();
            this.num_CurrentS = new System.Windows.Forms.NumericUpDown();
            this.num_CurrentEp = new System.Windows.Forms.NumericUpDown();
            this.num_Rating = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Seasons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Episodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CurrentS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CurrentEp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add new Show";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(13, 49);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Season
            // 
            this.lbl_Season.AutoSize = true;
            this.lbl_Season.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Season.Location = new System.Drawing.Point(13, 86);
            this.lbl_Season.Name = "lbl_Season";
            this.lbl_Season.Size = new System.Drawing.Size(72, 20);
            this.lbl_Season.TabIndex = 2;
            this.lbl_Season.Text = "Seasons";
            // 
            // lbl_Ep
            // 
            this.lbl_Ep.AutoSize = true;
            this.lbl_Ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ep.Location = new System.Drawing.Point(13, 121);
            this.lbl_Ep.Name = "lbl_Ep";
            this.lbl_Ep.Size = new System.Drawing.Size(75, 20);
            this.lbl_Ep.TabIndex = 3;
            this.lbl_Ep.Text = "Episodes";
            // 
            // lbl_Comp
            // 
            this.lbl_Comp.AutoSize = true;
            this.lbl_Comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comp.Location = new System.Drawing.Point(13, 161);
            this.lbl_Comp.Name = "lbl_Comp";
            this.lbl_Comp.Size = new System.Drawing.Size(95, 20);
            this.lbl_Comp.TabIndex = 4;
            this.lbl_Comp.Text = "Completed?";
            // 
            // lbl_CS
            // 
            this.lbl_CS.AutoSize = true;
            this.lbl_CS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CS.Location = new System.Drawing.Point(13, 203);
            this.lbl_CS.Name = "lbl_CS";
            this.lbl_CS.Size = new System.Drawing.Size(121, 20);
            this.lbl_CS.TabIndex = 5;
            this.lbl_CS.Text = "Current Season";
            // 
            // lbl_CE
            // 
            this.lbl_CE.AutoSize = true;
            this.lbl_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CE.Location = new System.Drawing.Point(13, 243);
            this.lbl_CE.Name = "lbl_CE";
            this.lbl_CE.Size = new System.Drawing.Size(124, 20);
            this.lbl_CE.TabIndex = 6;
            this.lbl_CE.Text = "Current Episode";
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.AutoSize = true;
            this.lbl_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rating.Location = new System.Drawing.Point(13, 282);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(56, 20);
            this.lbl_Rating.TabIndex = 7;
            this.lbl_Rating.Text = "Rating";
            // 
            // num_Seasons
            // 
            this.num_Seasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Seasons.Location = new System.Drawing.Point(148, 86);
            this.num_Seasons.Name = "num_Seasons";
            this.num_Seasons.Size = new System.Drawing.Size(189, 22);
            this.num_Seasons.TabIndex = 8;
            this.num_Seasons.ValueChanged += new System.EventHandler(this.num_Seasons_ValueChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(148, 49);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(189, 22);
            this.txt_Name.TabIndex = 9;
            // 
            // ck_Completed
            // 
            this.ck_Completed.AutoSize = true;
            this.ck_Completed.Location = new System.Drawing.Point(148, 161);
            this.ck_Completed.Name = "ck_Completed";
            this.ck_Completed.Size = new System.Drawing.Size(15, 14);
            this.ck_Completed.TabIndex = 10;
            this.ck_Completed.UseVisualStyleBackColor = true;
            this.ck_Completed.CheckedChanged += new System.EventHandler(this.ck_Completed_CheckedChanged);
            // 
            // num_Episodes
            // 
            this.num_Episodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Episodes.Location = new System.Drawing.Point(148, 121);
            this.num_Episodes.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_Episodes.Name = "num_Episodes";
            this.num_Episodes.Size = new System.Drawing.Size(189, 22);
            this.num_Episodes.TabIndex = 11;
            this.num_Episodes.ValueChanged += new System.EventHandler(this.num_Episodes_ValueChanged);
            // 
            // num_CurrentS
            // 
            this.num_CurrentS.Location = new System.Drawing.Point(148, 203);
            this.num_CurrentS.Name = "num_CurrentS";
            this.num_CurrentS.Size = new System.Drawing.Size(189, 22);
            this.num_CurrentS.TabIndex = 12;
            this.num_CurrentS.ValueChanged += new System.EventHandler(this.num_CurrentS_ValueChanged);
            // 
            // num_CurrentEp
            // 
            this.num_CurrentEp.Location = new System.Drawing.Point(148, 243);
            this.num_CurrentEp.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_CurrentEp.Name = "num_CurrentEp";
            this.num_CurrentEp.Size = new System.Drawing.Size(189, 22);
            this.num_CurrentEp.TabIndex = 13;
            this.num_CurrentEp.ValueChanged += new System.EventHandler(this.num_CurrentEp_ValueChanged);
            // 
            // num_Rating
            // 
            this.num_Rating.DecimalPlaces = 1;
            this.num_Rating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Rating.Location = new System.Drawing.Point(148, 282);
            this.num_Rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Rating.Name = "num_Rating";
            this.num_Rating.Size = new System.Drawing.Size(189, 22);
            this.num_Rating.TabIndex = 14;
            this.num_Rating.ValueChanged += new System.EventHandler(this.num_Rating_ValueChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(242, 323);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 23);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add Show";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // AddWindow
            // 
            this.ClientSize = new System.Drawing.Size(375, 375);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.num_Rating);
            this.Controls.Add(this.num_CurrentEp);
            this.Controls.Add(this.num_CurrentS);
            this.Controls.Add(this.num_Episodes);
            this.Controls.Add(this.ck_Completed);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.num_Seasons);
            this.Controls.Add(this.lbl_Rating);
            this.Controls.Add(this.lbl_CE);
            this.Controls.Add(this.lbl_CS);
            this.Controls.Add(this.lbl_Comp);
            this.Controls.Add(this.lbl_Ep);
            this.Controls.Add(this.lbl_Season);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddWindow";
            this.Text = "Add Show";
            ((System.ComponentModel.ISupportInitialize)(this.num_Seasons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Episodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CurrentS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CurrentEp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Season;
        private System.Windows.Forms.Label lbl_Ep;
        private System.Windows.Forms.Label lbl_Comp;
        private System.Windows.Forms.Label lbl_CS;
        private System.Windows.Forms.Label lbl_CE;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.NumericUpDown num_Seasons;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.CheckBox ck_Completed;
        private System.Windows.Forms.NumericUpDown num_Episodes;
        private System.Windows.Forms.NumericUpDown num_CurrentS;
        private System.Windows.Forms.NumericUpDown num_CurrentEp;
        private System.Windows.Forms.NumericUpDown num_Rating;
        private System.Windows.Forms.Button btn_Add;
    }
}