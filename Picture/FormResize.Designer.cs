namespace Picture
{
    partial class PhotoSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoSharp));
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonOpenPicture = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScale = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(12, 27);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(978, 494);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // buttonOpenPicture
            // 
            this.buttonOpenPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPicture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPicture.Location = new System.Drawing.Point(996, 27);
            this.buttonOpenPicture.Name = "buttonOpenPicture";
            this.buttonOpenPicture.Size = new System.Drawing.Size(183, 60);
            this.buttonOpenPicture.TabIndex = 1;
            this.buttonOpenPicture.Text = "Выбрать картинку";
            this.buttonOpenPicture.UseVisualStyleBackColor = true;
            this.buttonOpenPicture.Click += new System.EventHandler(this.buttonOpenPicture_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(1000, 93);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(179, 20);
            this.textBoxFileName.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(997, 462);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(183, 59);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Изменить картинку";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(996, 135);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(79, 19);
            this.labelScale.TabIndex = 5;
            this.labelScale.Text = "Масштаб:";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarScale.LargeChange = 10;
            this.trackBarScale.Location = new System.Drawing.Point(996, 165);
            this.trackBarScale.Maximum = 5000;
            this.trackBarScale.Minimum = 10;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(184, 45);
            this.trackBarScale.TabIndex = 6;
            this.trackBarScale.TickFrequency = 100;
            this.trackBarScale.Value = 100;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Метод ближайшего соседа",
            "Билинейная интерполяция"});
            this.comboBoxMethod.Location = new System.Drawing.Point(996, 238);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(183, 21);
            this.comboBoxMethod.TabIndex = 7;
            // 
            // labelMethod
            // 
            this.labelMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.Location = new System.Drawing.Point(997, 213);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(81, 19);
            this.labelMethod.TabIndex = 8;
            this.labelMethod.Text = "Алгоритм";
            // 
            // PhotoSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 533);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.trackBarScale);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonOpenPicture);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhotoSharp";
            this.Text = "Измения размера картинок";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonOpenPicture;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label labelMethod;
    }
}

