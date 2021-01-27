namespace Presentation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cboxUpdateFrequency = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPodcast = new System.Windows.Forms.Button();
            this.btnShowPodcastByCategory = new System.Windows.Forms.Button();
            this.btnRemovedMarkedPodcast = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.addCategory = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.gridFeed = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequencys = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Avsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lbEpisodes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podcast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategorier";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(118, 621);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(57, 20);
            this.lblAvsnitt.TabIndex = 0;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Beskrivning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Category:";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(249, 429);
            this.txtBoxURL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(193, 26);
            this.txtBoxURL.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.AccessibleName = "cboxCategory";
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(249, 466);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(193, 28);
            this.cbCategory.TabIndex = 5;
            // 
            // cboxUpdateFrequency
            // 
            this.cboxUpdateFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUpdateFrequency.FormattingEnabled = true;
            this.cboxUpdateFrequency.Location = new System.Drawing.Point(249, 509);
            this.cboxUpdateFrequency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboxUpdateFrequency.Name = "cboxUpdateFrequency";
            this.cboxUpdateFrequency.Size = new System.Drawing.Size(193, 28);
            this.cboxUpdateFrequency.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Uppdateringsintervall";
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.Location = new System.Drawing.Point(449, 429);
            this.btnAddPodcast.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(118, 40);
            this.btnAddPodcast.TabIndex = 6;
            this.btnAddPodcast.Text = "Add podcast";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // btnShowPodcastByCategory
            // 
            this.btnShowPodcastByCategory.Location = new System.Drawing.Point(449, 466);
            this.btnShowPodcastByCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnShowPodcastByCategory.Name = "btnShowPodcastByCategory";
            this.btnShowPodcastByCategory.Size = new System.Drawing.Size(234, 35);
            this.btnShowPodcastByCategory.TabIndex = 7;
            this.btnShowPodcastByCategory.Text = "Show podcast by category";
            this.btnShowPodcastByCategory.UseVisualStyleBackColor = true;
            this.btnShowPodcastByCategory.Click += new System.EventHandler(this.btnShowPodcastByCategory_Click);
            // 
            // btnRemovedMarkedPodcast
            // 
            this.btnRemovedMarkedPodcast.Location = new System.Drawing.Point(449, 509);
            this.btnRemovedMarkedPodcast.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRemovedMarkedPodcast.Name = "btnRemovedMarkedPodcast";
            this.btnRemovedMarkedPodcast.Size = new System.Drawing.Size(238, 40);
            this.btnRemovedMarkedPodcast.TabIndex = 8;
            this.btnRemovedMarkedPodcast.Text = "Remove marked podcast";
            this.btnRemovedMarkedPodcast.UseVisualStyleBackColor = true;
            this.btnRemovedMarkedPodcast.Click += new System.EventHandler(this.btnRemovedMarkedPodcast_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(756, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Category name:";
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(885, 400);
            this.textCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(382, 26);
            this.textCategory.TabIndex = 10;
            this.textCategory.Text = "dfd";
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(753, 451);
            this.addCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(114, 51);
            this.addCategory.TabIndex = 11;
            this.addCategory.Text = "Add category";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click_1);
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(872, 451);
            this.btnChangeName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(126, 49);
            this.btnChangeName.TabIndex = 11;
            this.btnChangeName.Text = "Change name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(1002, 451);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(126, 49);
            this.btnRemoveCategory.TabIndex = 11;
            this.btnRemoveCategory.Text = "Remove category";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 20;
            this.lbCategory.Location = new System.Drawing.Point(811, 59);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(530, 304);
            this.lbCategory.TabIndex = 13;
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.lbCategory_SelectedIndexChanged);
            // 
            // gridFeed
            // 
            this.gridFeed.AllowUserToAddRows = false;
            this.gridFeed.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFeed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Frequencys,
            this.Avsnitt,
            this.Category});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFeed.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridFeed.Location = new System.Drawing.Point(89, 59);
            this.gridFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridFeed.Name = "gridFeed";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFeed.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridFeed.RowHeadersWidth = 51;
            this.gridFeed.RowTemplate.Height = 33;
            this.gridFeed.Size = new System.Drawing.Size(663, 314);
            this.gridFeed.TabIndex = 14;
            this.gridFeed.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFeed_CellValueChanged);
            this.gridFeed.CurrentCellDirtyStateChanged += new System.EventHandler(this.gridFeedCurrentCellDirtyStateChanged);
            this.gridFeed.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridFeed_DataError);
            this.gridFeed.SelectionChanged += new System.EventHandler(this.gridFeed_SelectionChanged);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 80;
            // 
            // Frequencys
            // 
            this.Frequencys.HeaderText = "Frequency";
            this.Frequencys.MinimumWidth = 10;
            this.Frequencys.Name = "Frequencys";
            this.Frequencys.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Frequencys.Width = 90;
            // 
            // Avsnitt
            // 
            this.Avsnitt.HeaderText = "Episode";
            this.Avsnitt.MinimumWidth = 6;
            this.Avsnitt.Name = "Avsnitt";
            this.Avsnitt.ReadOnly = true;
            this.Avsnitt.Width = 90;
            // 
            // Category
            // 
            this.Category.HeaderText = "Categories";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.Width = 125;
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.FormattingEnabled = true;
            this.lbEpisodes.ItemHeight = 20;
            this.lbEpisodes.Location = new System.Drawing.Point(122, 659);
            this.lbEpisodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(620, 224);
            this.lbEpisodes.TabIndex = 15;
            this.lbEpisodes.SelectedIndexChanged += new System.EventHandler(this.lbEpisodes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(249, 549);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(193, 26);
            this.txtBoxName.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "Show all podcasts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(778, 659);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(602, 224);
            this.txtBoxDescription.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1850, 1276);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lbEpisodes);
            this.Controls.Add(this.gridFeed);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemovedMarkedPodcast);
            this.Controls.Add(this.btnShowPodcastByCategory);
            this.Controls.Add(this.btnAddPodcast);
            this.Controls.Add(this.cboxUpdateFrequency);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cboxUpdateFrequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPodcast;
        private System.Windows.Forms.Button btnShowPodcastByCategory;
        private System.Windows.Forms.Button btnRemovedMarkedPodcast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.DataGridView gridFeed;
        private System.Windows.Forms.ListBox lbEpisodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn Frequencys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avsnitt;
        private System.Windows.Forms.DataGridViewComboBoxColumn Category;
        private System.Windows.Forms.TextBox txtBoxDescription;
    }
}

