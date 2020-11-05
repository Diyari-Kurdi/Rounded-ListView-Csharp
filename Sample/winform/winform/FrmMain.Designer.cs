namespace winform
{
    partial class FrmMain
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLColor = new System.Windows.Forms.Button();
            this.btnPColor = new System.Windows.Forms.Button();
            this.lColor = new System.Windows.Forms.Panel();
            this.pColor = new System.Windows.Forms.Panel();
            this.CD = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(366, 360);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 24);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(366, 330);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(148, 24);
            this.txtCategory.TabIndex = 9;
            this.txtCategory.Text = "Category";
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChoose.Location = new System.Drawing.Point(366, 288);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(148, 36);
            this.btnChoose.TabIndex = 8;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.Location = new System.Drawing.Point(366, 170);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(148, 112);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(366, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fLPanel
            // 
            this.fLPanel.AutoSize = true;
            this.fLPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fLPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fLPanel.Location = new System.Drawing.Point(0, 0);
            this.fLPanel.Name = "fLPanel";
            this.fLPanel.Size = new System.Drawing.Size(0, 441);
            this.fLPanel.TabIndex = 11;
            // 
            // btnLColor
            // 
            this.btnLColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLColor.Location = new System.Drawing.Point(366, 44);
            this.btnLColor.Name = "btnLColor";
            this.btnLColor.Size = new System.Drawing.Size(148, 36);
            this.btnLColor.TabIndex = 12;
            this.btnLColor.Text = "Line Color";
            this.btnLColor.UseVisualStyleBackColor = true;
            this.btnLColor.Click += new System.EventHandler(this.btnLColor_Click);
            // 
            // btnPColor
            // 
            this.btnPColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPColor.Location = new System.Drawing.Point(366, 128);
            this.btnPColor.Name = "btnPColor";
            this.btnPColor.Size = new System.Drawing.Size(148, 36);
            this.btnPColor.TabIndex = 13;
            this.btnPColor.Text = "Panel Color";
            this.btnPColor.UseVisualStyleBackColor = true;
            this.btnPColor.Click += new System.EventHandler(this.btnPColor_Click);
            // 
            // lColor
            // 
            this.lColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lColor.BackColor = System.Drawing.Color.Black;
            this.lColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lColor.Location = new System.Drawing.Point(366, 2);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(148, 36);
            this.lColor.TabIndex = 14;
            // 
            // pColor
            // 
            this.pColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pColor.BackColor = System.Drawing.Color.White;
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColor.Location = new System.Drawing.Point(366, 86);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(148, 36);
            this.pColor.TabIndex = 15;
            // 
            // CD
            // 
            this.CD.FullOpen = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 441);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.btnPColor);
            this.Controls.Add(this.btnLColor);
            this.Controls.Add(this.fLPanel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel fLPanel;
        private System.Windows.Forms.Button btnLColor;
        private System.Windows.Forms.Button btnPColor;
        private System.Windows.Forms.Panel lColor;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.ColorDialog CD;
    }
}

