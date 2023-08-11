namespace TestTaskLetters.Forms
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftGroupBox = new System.Windows.Forms.GroupBox();
            this.leftPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.incomingLettersButton = new System.Windows.Forms.Button();
            this.baseLettersButton = new System.Windows.Forms.Button();
            this.rightGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lettersDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.leftGroupBox.SuspendLayout();
            this.leftPanelButtons.SuspendLayout();
            this.rightGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lettersDataGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(832, 423);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            // 
            // leftGroupBox
            // 
            this.leftGroupBox.Controls.Add(this.leftPanelButtons);
            this.leftGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftGroupBox.Location = new System.Drawing.Point(0, 0);
            this.leftGroupBox.Name = "leftGroupBox";
            this.leftGroupBox.Size = new System.Drawing.Size(155, 423);
            this.leftGroupBox.TabIndex = 0;
            this.leftGroupBox.TabStop = false;
            // 
            // leftPanelButtons
            // 
            this.leftPanelButtons.ColumnCount = 1;
            this.leftPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanelButtons.Controls.Add(this.incomingLettersButton, 0, 1);
            this.leftPanelButtons.Controls.Add(this.baseLettersButton, 0, 0);
            this.leftPanelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelButtons.Location = new System.Drawing.Point(3, 18);
            this.leftPanelButtons.Name = "leftPanelButtons";
            this.leftPanelButtons.RowCount = 2;
            this.leftPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftPanelButtons.Size = new System.Drawing.Size(149, 87);
            this.leftPanelButtons.TabIndex = 3;
            // 
            // incomingLettersButton
            // 
            this.incomingLettersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingLettersButton.Location = new System.Drawing.Point(3, 47);
            this.incomingLettersButton.Name = "incomingLettersButton";
            this.incomingLettersButton.Size = new System.Drawing.Size(143, 36);
            this.incomingLettersButton.TabIndex = 1;
            this.incomingLettersButton.Text = "Входящие письма";
            this.incomingLettersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomingLettersButton.UseVisualStyleBackColor = true;
            this.incomingLettersButton.Click += new System.EventHandler(this.incomingLettersButton_Click);
            // 
            // baseLettersButton
            // 
            this.baseLettersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLettersButton.Location = new System.Drawing.Point(3, 3);
            this.baseLettersButton.Name = "baseLettersButton";
            this.baseLettersButton.Size = new System.Drawing.Size(143, 36);
            this.baseLettersButton.TabIndex = 0;
            this.baseLettersButton.Text = "Базовые письма";
            this.baseLettersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baseLettersButton.UseVisualStyleBackColor = true;
            this.baseLettersButton.Click += new System.EventHandler(this.baseLettersButton_Click);
            // 
            // rightGroupBox
            // 
            this.rightGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.rightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightGroupBox.Location = new System.Drawing.Point(0, 0);
            this.rightGroupBox.Name = "rightGroupBox";
            this.rightGroupBox.Size = new System.Drawing.Size(673, 423);
            this.rightGroupBox.TabIndex = 0;
            this.rightGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lettersDataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28278F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.71722F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(667, 402);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.filterButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(661, 31);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lettersDataGridView
            // 
            this.lettersDataGridView.AllowUserToAddRows = false;
            this.lettersDataGridView.AllowUserToResizeRows = false;
            this.lettersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lettersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lettersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lettersDataGridView.Location = new System.Drawing.Point(3, 40);
            this.lettersDataGridView.MultiSelect = false;
            this.lettersDataGridView.Name = "lettersDataGridView";
            this.lettersDataGridView.ReadOnly = true;
            this.lettersDataGridView.RowHeadersVisible = false;
            this.lettersDataGridView.RowHeadersWidth = 51;
            this.lettersDataGridView.RowTemplate.Height = 24;
            this.lettersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lettersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lettersDataGridView.ShowCellErrors = false;
            this.lettersDataGridView.ShowCellToolTips = false;
            this.lettersDataGridView.ShowEditingIcon = false;
            this.lettersDataGridView.ShowRowErrors = false;
            this.lettersDataGridView.Size = new System.Drawing.Size(661, 321);
            this.lettersDataGridView.TabIndex = 1;
            this.lettersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lettersDataGridView_CellDoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.createButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.openButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 367);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(661, 32);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createButton.Location = new System.Drawing.Point(443, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(215, 26);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Написать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButton.Location = new System.Drawing.Point(223, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(214, 26);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть письмо";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 26);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterButton.Location = new System.Drawing.Point(445, 3);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(213, 25);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 423);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(850, 470);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.leftGroupBox.ResumeLayout(false);
            this.leftPanelButtons.ResumeLayout(false);
            this.rightGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lettersDataGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox leftGroupBox;
        private System.Windows.Forms.GroupBox rightGroupBox;
        private System.Windows.Forms.TableLayoutPanel leftPanelButtons;
        private System.Windows.Forms.Button incomingLettersButton;
        private System.Windows.Forms.Button baseLettersButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView lettersDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button filterButton;
    }
}