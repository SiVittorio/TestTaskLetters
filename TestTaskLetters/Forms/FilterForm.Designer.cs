namespace TestTaskLetters.Forms
{
    partial class FilterForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterNameGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.filterNameCheckBox = new System.Windows.Forms.CheckBox();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.filterDateGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filterDateOffRb = new System.Windows.Forms.RadioButton();
            this.filterDateWeekRb = new System.Windows.Forms.RadioButton();
            this.filterDateThirty = new System.Windows.Forms.RadioButton();
            this.filterDateNinety = new System.Windows.Forms.RadioButton();
            this.filterDatePeriod = new System.Windows.Forms.RadioButton();
            this.filterDateSelectMenu = new System.Windows.Forms.TableLayoutPanel();
            this.filterDateToMtb = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterDateFromMtb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterAttributesGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.organisationCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryMethodCb = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.filterNameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.filterDateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.filterDateSelectMenu.SuspendLayout();
            this.filterAttributesGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.filterNameGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterDateGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.filterAttributesGroupBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.46808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.97872F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.72603F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 282);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filterNameGroupBox
            // 
            this.filterNameGroupBox.Controls.Add(this.splitContainer1);
            this.filterNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterNameGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filterNameGroupBox.Name = "filterNameGroupBox";
            this.filterNameGroupBox.Size = new System.Drawing.Size(935, 65);
            this.filterNameGroupBox.TabIndex = 0;
            this.filterNameGroupBox.TabStop = false;
            this.filterNameGroupBox.Text = "Фильтрация по имени";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.filterNameCheckBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.filterNameTextBox);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(929, 44);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 0;
            // 
            // filterNameCheckBox
            // 
            this.filterNameCheckBox.AutoSize = true;
            this.filterNameCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterNameCheckBox.Location = new System.Drawing.Point(0, 0);
            this.filterNameCheckBox.Name = "filterNameCheckBox";
            this.filterNameCheckBox.Size = new System.Drawing.Size(122, 44);
            this.filterNameCheckBox.TabIndex = 0;
            this.filterNameCheckBox.Text = "Активировать";
            this.filterNameCheckBox.UseVisualStyleBackColor = true;
            this.filterNameCheckBox.CheckedChanged += new System.EventHandler(this.filterNameCheckBox_CheckedChanged);
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterNameTextBox.Enabled = false;
            this.filterNameTextBox.Location = new System.Drawing.Point(0, 10);
            this.filterNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(249, 22);
            this.filterNameTextBox.TabIndex = 0;
            // 
            // filterDateGroupBox
            // 
            this.filterDateGroupBox.Controls.Add(this.splitContainer2);
            this.filterDateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateGroupBox.Location = new System.Drawing.Point(3, 74);
            this.filterDateGroupBox.Name = "filterDateGroupBox";
            this.filterDateGroupBox.Size = new System.Drawing.Size(935, 89);
            this.filterDateGroupBox.TabIndex = 1;
            this.filterDateGroupBox.TabStop = false;
            this.filterDateGroupBox.Text = "Фильтрация по дате";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 18);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.filterDateSelectMenu);
            this.splitContainer2.Size = new System.Drawing.Size(929, 68);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.88267F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.57373F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.62218F));
            this.tableLayoutPanel2.Controls.Add(this.filterDateOffRb, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.filterDateWeekRb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.filterDateThirty, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.filterDateNinety, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.filterDatePeriod, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // filterDateOffRb
            // 
            this.filterDateOffRb.AutoSize = true;
            this.filterDateOffRb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateOffRb.Location = new System.Drawing.Point(3, 3);
            this.filterDateOffRb.Name = "filterDateOffRb";
            this.filterDateOffRb.Size = new System.Drawing.Size(136, 19);
            this.filterDateOffRb.TabIndex = 0;
            this.filterDateOffRb.TabStop = true;
            this.filterDateOffRb.Text = "Отключить";
            this.filterDateOffRb.UseVisualStyleBackColor = true;
            // 
            // filterDateWeekRb
            // 
            this.filterDateWeekRb.AutoSize = true;
            this.filterDateWeekRb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateWeekRb.Location = new System.Drawing.Point(145, 3);
            this.filterDateWeekRb.Name = "filterDateWeekRb";
            this.filterDateWeekRb.Size = new System.Drawing.Size(187, 19);
            this.filterDateWeekRb.TabIndex = 1;
            this.filterDateWeekRb.TabStop = true;
            this.filterDateWeekRb.Text = "За последнюю неделю";
            this.filterDateWeekRb.UseVisualStyleBackColor = true;
            // 
            // filterDateThirty
            // 
            this.filterDateThirty.AutoSize = true;
            this.filterDateThirty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateThirty.Location = new System.Drawing.Point(338, 3);
            this.filterDateThirty.Name = "filterDateThirty";
            this.filterDateThirty.Size = new System.Drawing.Size(196, 19);
            this.filterDateThirty.TabIndex = 2;
            this.filterDateThirty.TabStop = true;
            this.filterDateThirty.Text = "За последние 30 дней";
            this.filterDateThirty.UseVisualStyleBackColor = true;
            // 
            // filterDateNinety
            // 
            this.filterDateNinety.AutoSize = true;
            this.filterDateNinety.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateNinety.Location = new System.Drawing.Point(540, 3);
            this.filterDateNinety.Name = "filterDateNinety";
            this.filterDateNinety.Size = new System.Drawing.Size(212, 19);
            this.filterDateNinety.TabIndex = 3;
            this.filterDateNinety.TabStop = true;
            this.filterDateNinety.Text = "За последние 90 дней";
            this.filterDateNinety.UseVisualStyleBackColor = true;
            // 
            // filterDatePeriod
            // 
            this.filterDatePeriod.AutoSize = true;
            this.filterDatePeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDatePeriod.Location = new System.Drawing.Point(758, 3);
            this.filterDatePeriod.Name = "filterDatePeriod";
            this.filterDatePeriod.Size = new System.Drawing.Size(168, 19);
            this.filterDatePeriod.TabIndex = 4;
            this.filterDatePeriod.TabStop = true;
            this.filterDatePeriod.Text = "Выбрать период";
            this.filterDatePeriod.UseVisualStyleBackColor = true;
            this.filterDatePeriod.CheckedChanged += new System.EventHandler(this.filterDatePeriod_CheckedChanged);
            // 
            // filterDateSelectMenu
            // 
            this.filterDateSelectMenu.ColumnCount = 5;
            this.filterDateSelectMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.49315F));
            this.filterDateSelectMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.50685F));
            this.filterDateSelectMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.filterDateSelectMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.filterDateSelectMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 658F));
            this.filterDateSelectMenu.Controls.Add(this.filterDateToMtb, 3, 0);
            this.filterDateSelectMenu.Controls.Add(this.label1, 0, 0);
            this.filterDateSelectMenu.Controls.Add(this.filterDateFromMtb, 1, 0);
            this.filterDateSelectMenu.Controls.Add(this.label2, 2, 0);
            this.filterDateSelectMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateSelectMenu.Enabled = false;
            this.filterDateSelectMenu.Location = new System.Drawing.Point(0, 0);
            this.filterDateSelectMenu.Name = "filterDateSelectMenu";
            this.filterDateSelectMenu.RowCount = 1;
            this.filterDateSelectMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterDateSelectMenu.Size = new System.Drawing.Size(929, 39);
            this.filterDateSelectMenu.TabIndex = 0;
            // 
            // filterDateToMtb
            // 
            this.filterDateToMtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateToMtb.Location = new System.Drawing.Point(168, 3);
            this.filterDateToMtb.Mask = "00/00/0000";
            this.filterDateToMtb.Name = "filterDateToMtb";
            this.filterDateToMtb.Size = new System.Drawing.Size(99, 22);
            this.filterDateToMtb.TabIndex = 3;
            this.filterDateToMtb.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "С";
            // 
            // filterDateFromMtb
            // 
            this.filterDateFromMtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDateFromMtb.Location = new System.Drawing.Point(26, 3);
            this.filterDateFromMtb.Mask = "00/00/0000";
            this.filterDateFromMtb.Name = "filterDateFromMtb";
            this.filterDateFromMtb.Size = new System.Drawing.Size(95, 22);
            this.filterDateFromMtb.TabIndex = 1;
            this.filterDateFromMtb.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(127, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "По";
            // 
            // filterAttributesGroupBox
            // 
            this.filterAttributesGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.filterAttributesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterAttributesGroupBox.Location = new System.Drawing.Point(3, 169);
            this.filterAttributesGroupBox.Name = "filterAttributesGroupBox";
            this.filterAttributesGroupBox.Size = new System.Drawing.Size(935, 110);
            this.filterAttributesGroupBox.TabIndex = 2;
            this.filterAttributesGroupBox.TabStop = false;
            this.filterAttributesGroupBox.Text = "Фильтрация по свойствам (не для Базовых писем)";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.29602F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.70398F));
            this.tableLayoutPanel3.Controls.Add(this.organisationCb, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.deliveryMethodCb, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83146F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16854F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(929, 89);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // organisationCb
            // 
            this.organisationCb.Dock = System.Windows.Forms.DockStyle.Left;
            this.organisationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organisationCb.FormattingEnabled = true;
            this.organisationCb.Location = new System.Drawing.Point(238, 33);
            this.organisationCb.Name = "organisationCb";
            this.organisationCb.Size = new System.Drawing.Size(184, 24);
            this.organisationCb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "По методу доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 59);
            this.label4.TabIndex = 1;
            this.label4.Text = "По организации-отправителю";
            // 
            // deliveryMethodCb
            // 
            this.deliveryMethodCb.Dock = System.Windows.Forms.DockStyle.Left;
            this.deliveryMethodCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryMethodCb.FormattingEnabled = true;
            this.deliveryMethodCb.Location = new System.Drawing.Point(238, 3);
            this.deliveryMethodCb.Name = "deliveryMethodCb";
            this.deliveryMethodCb.Size = new System.Drawing.Size(184, 24);
            this.deliveryMethodCb.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.acceptButton, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 329);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(941, 36);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(182, 30);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptButton.Location = new System.Drawing.Point(755, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(183, 30);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Применить фильтр";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 365);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.filterNameGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.filterDateGroupBox.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.filterDateSelectMenu.ResumeLayout(false);
            this.filterDateSelectMenu.PerformLayout();
            this.filterAttributesGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox filterNameGroupBox;
        private System.Windows.Forms.GroupBox filterDateGroupBox;
        private System.Windows.Forms.GroupBox filterAttributesGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox filterNameCheckBox;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton filterDateOffRb;
        private System.Windows.Forms.RadioButton filterDateWeekRb;
        private System.Windows.Forms.RadioButton filterDateThirty;
        private System.Windows.Forms.RadioButton filterDateNinety;
        private System.Windows.Forms.RadioButton filterDatePeriod;
        private System.Windows.Forms.TableLayoutPanel filterDateSelectMenu;
        private System.Windows.Forms.MaskedTextBox filterDateToMtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox filterDateFromMtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox organisationCb;
        private System.Windows.Forms.ComboBox deliveryMethodCb;
    }
}