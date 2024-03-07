namespace Nearest_Launcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackGroundObject1 = new System.Windows.Forms.PictureBox();
            this.BackGroundObject2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NearestLabel = new System.Windows.Forms.PictureBox();
            this.VK = new System.Windows.Forms.Button();
            this.Discord = new System.Windows.Forms.Button();
            this.MainWindowSlide = new System.Windows.Forms.PictureBox();
            this.Play_button = new System.Windows.Forms.Button();
            this.SaveLogsCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Check_Update_Button = new System.Windows.Forms.Button();
            this.Download_progress = new System.Windows.Forms.ProgressBar();
            this.Download_Label = new System.Windows.Forms.Label();
            this.Percent_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundObject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundObject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearestLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGroundObject1
            // 
            this.BackGroundObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackGroundObject1.Location = new System.Drawing.Point(-1, 0);
            this.BackGroundObject1.Name = "BackGroundObject1";
            this.BackGroundObject1.Size = new System.Drawing.Size(1025, 45);
            this.BackGroundObject1.TabIndex = 0;
            this.BackGroundObject1.TabStop = false;
            // 
            // BackGroundObject2
            // 
            this.BackGroundObject2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackGroundObject2.Location = new System.Drawing.Point(61, 0);
            this.BackGroundObject2.Name = "BackGroundObject2";
            this.BackGroundObject2.Size = new System.Drawing.Size(260, 601);
            this.BackGroundObject2.TabIndex = 1;
            this.BackGroundObject2.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExitButton.BackgroundImage = global::Nearest_Launcher.Properties.Resources.NearestStage_Exit;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 10F);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExitButton.Location = new System.Drawing.Point(941, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 556);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 45);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NearestLabel
            // 
            this.NearestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NearestLabel.BackgroundImage = global::Nearest_Launcher.Properties.Resources.NearestStage_Label;
            this.NearestLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NearestLabel.Location = new System.Drawing.Point(1, 0);
            this.NearestLabel.Name = "NearestLabel";
            this.NearestLabel.Size = new System.Drawing.Size(126, 45);
            this.NearestLabel.TabIndex = 4;
            this.NearestLabel.TabStop = false;
            // 
            // VK
            // 
            this.VK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.VK.BackgroundImage = global::Nearest_Launcher.Properties.Resources.NearestLauncher_VK;
            this.VK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VK.FlatAppearance.BorderSize = 0;
            this.VK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.VK.Location = new System.Drawing.Point(61, 556);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(45, 45);
            this.VK.TabIndex = 5;
            this.VK.UseVisualStyleBackColor = true;
            this.VK.Click += new System.EventHandler(this.VK_Click);
            // 
            // Discord
            // 
            this.Discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Discord.BackgroundImage = global::Nearest_Launcher.Properties.Resources.NearestStage_Discord1;
            this.Discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Discord.FlatAppearance.BorderSize = 0;
            this.Discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Discord.Location = new System.Drawing.Point(112, 556);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(45, 45);
            this.Discord.TabIndex = 6;
            this.Discord.UseVisualStyleBackColor = true;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // MainWindowSlide
            // 
            this.MainWindowSlide.BackColor = System.Drawing.Color.Transparent;
            this.MainWindowSlide.Location = new System.Drawing.Point(-8, 0);
            this.MainWindowSlide.Name = "MainWindowSlide";
            this.MainWindowSlide.Size = new System.Drawing.Size(1042, 601);
            this.MainWindowSlide.TabIndex = 7;
            this.MainWindowSlide.TabStop = false;
            // 
            // Play_button
            // 
            this.Play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Play_button.BackgroundImage = global::Nearest_Launcher.Properties.Resources.NearestStage_Play;
            this.Play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_button.FlatAppearance.BorderSize = 0;
            this.Play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_button.Font = new System.Drawing.Font("Impact", 10F);
            this.Play_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Play_button.Location = new System.Drawing.Point(929, 556);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(95, 45);
            this.Play_button.TabIndex = 8;
            this.Play_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Play_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Play_button.UseVisualStyleBackColor = false;
            this.Play_button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // SaveLogsCheck
            // 
            this.SaveLogsCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveLogsCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveLogsCheck.Location = new System.Drawing.Point(836, 556);
            this.SaveLogsCheck.Name = "SaveLogsCheck";
            this.SaveLogsCheck.Size = new System.Drawing.Size(87, 45);
            this.SaveLogsCheck.TabIndex = 9;
            this.SaveLogsCheck.Text = "Сохранять старые логи";
            this.SaveLogsCheck.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.BackgroundImage = global::Nearest_Launcher.Properties.Resources.NearestStage_Log_Open;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(226, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 10;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Check_Update_Button
            // 
            this.Check_Update_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Check_Update_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Check_Update_Button.FlatAppearance.BorderSize = 0;
            this.Check_Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_Update_Button.Font = new System.Drawing.Font("Impact", 10F);
            this.Check_Update_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Check_Update_Button.Location = new System.Drawing.Point(735, 556);
            this.Check_Update_Button.Name = "Check_Update_Button";
            this.Check_Update_Button.Size = new System.Drawing.Size(95, 45);
            this.Check_Update_Button.TabIndex = 11;
            this.Check_Update_Button.Text = "Проверить Обновления";
            this.Check_Update_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Check_Update_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Check_Update_Button.UseVisualStyleBackColor = false;
            this.Check_Update_Button.Click += new System.EventHandler(this.Check_Update_Button_Click);
            // 
            // Download_progress
            // 
            this.Download_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Download_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Download_progress.Location = new System.Drawing.Point(327, 579);
            this.Download_progress.Name = "Download_progress";
            this.Download_progress.Size = new System.Drawing.Size(402, 15);
            this.Download_progress.Step = 1;
            this.Download_progress.TabIndex = 12;
            this.Download_progress.Visible = false;
            // 
            // Download_Label
            // 
            this.Download_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Download_Label.Location = new System.Drawing.Point(327, 560);
            this.Download_Label.Name = "Download_Label";
            this.Download_Label.Size = new System.Drawing.Size(402, 13);
            this.Download_Label.TabIndex = 13;
            this.Download_Label.Text = "label1";
            this.Download_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Download_Label.Visible = false;
            // 
            // Percent_label
            // 
            this.Percent_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Percent_label.Font = new System.Drawing.Font("Impact", 15F);
            this.Percent_label.Location = new System.Drawing.Point(730, 569);
            this.Percent_label.Name = "Percent_label";
            this.Percent_label.Size = new System.Drawing.Size(59, 32);
            this.Percent_label.TabIndex = 14;
            this.Percent_label.Text = "0%";
            this.Percent_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Percent_label.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Nearest_Launcher.Properties.Resources.BackGroundImage0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.ControlBox = false;
            this.Controls.Add(this.Percent_label);
            this.Controls.Add(this.Download_Label);
            this.Controls.Add(this.Download_progress);
            this.Controls.Add(this.Check_Update_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveLogsCheck);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.Discord);
            this.Controls.Add(this.VK);
            this.Controls.Add(this.NearestLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackGroundObject1);
            this.Controls.Add(this.BackGroundObject2);
            this.Controls.Add(this.MainWindowSlide);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Impact", 8.25F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nearest Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundObject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundObject2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearestLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGroundObject1;
        private System.Windows.Forms.PictureBox BackGroundObject2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox NearestLabel;
        private System.Windows.Forms.Button VK;
        private System.Windows.Forms.Button Discord;
        private System.Windows.Forms.PictureBox MainWindowSlide;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.CheckBox SaveLogsCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Check_Update_Button;
        private System.Windows.Forms.ProgressBar Download_progress;
        private System.Windows.Forms.Label Download_Label;
        private System.Windows.Forms.Label Percent_label;
    }
}

