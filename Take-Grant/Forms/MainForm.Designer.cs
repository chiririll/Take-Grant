namespace TakeGrant
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
            this.subjEditContainer = new System.Windows.Forms.Panel();
            this.subjEditName = new System.Windows.Forms.TextBox();
            this.subjEditNameLabel = new System.Windows.Forms.Label();
            this.subjEditRemoveBtn = new System.Windows.Forms.Button();
            this.subjEditSaveBtn = new System.Windows.Forms.Button();
            this.subjEditChooseDropdown = new System.Windows.Forms.ComboBox();
            this.subjEditHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.accessMatrix = new System.Windows.Forms.DataGridView();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.graphLabel = new System.Windows.Forms.Label();
            this.drawGraphBtn = new System.Windows.Forms.Button();
            this.rootTabs = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.matrixTab = new System.Windows.Forms.TabPage();
            this.subjEditContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.rootTabs.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.matrixTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjEditContainer
            // 
            this.subjEditContainer.Controls.Add(this.subjEditName);
            this.subjEditContainer.Controls.Add(this.subjEditNameLabel);
            this.subjEditContainer.Controls.Add(this.subjEditRemoveBtn);
            this.subjEditContainer.Controls.Add(this.subjEditSaveBtn);
            this.subjEditContainer.Controls.Add(this.subjEditChooseDropdown);
            this.subjEditContainer.Controls.Add(this.subjEditHeader);
            this.subjEditContainer.Location = new System.Drawing.Point(15, 23);
            this.subjEditContainer.Name = "subjEditContainer";
            this.subjEditContainer.Size = new System.Drawing.Size(208, 194);
            this.subjEditContainer.TabIndex = 2;
            // 
            // subjEditName
            // 
            this.subjEditName.Location = new System.Drawing.Point(8, 67);
            this.subjEditName.Name = "subjEditName";
            this.subjEditName.Size = new System.Drawing.Size(187, 20);
            this.subjEditName.TabIndex = 6;
            // 
            // subjEditNameLabel
            // 
            this.subjEditNameLabel.AutoSize = true;
            this.subjEditNameLabel.Location = new System.Drawing.Point(5, 51);
            this.subjEditNameLabel.Name = "subjEditNameLabel";
            this.subjEditNameLabel.Size = new System.Drawing.Size(57, 13);
            this.subjEditNameLabel.TabIndex = 5;
            this.subjEditNameLabel.Text = "Название";
            // 
            // subjEditRemoveBtn
            // 
            this.subjEditRemoveBtn.Location = new System.Drawing.Point(5, 164);
            this.subjEditRemoveBtn.Name = "subjEditRemoveBtn";
            this.subjEditRemoveBtn.Size = new System.Drawing.Size(200, 23);
            this.subjEditRemoveBtn.TabIndex = 4;
            this.subjEditRemoveBtn.Text = "Удалить субъект";
            this.subjEditRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // subjEditSaveBtn
            // 
            this.subjEditSaveBtn.Location = new System.Drawing.Point(5, 135);
            this.subjEditSaveBtn.Name = "subjEditSaveBtn";
            this.subjEditSaveBtn.Size = new System.Drawing.Size(200, 23);
            this.subjEditSaveBtn.TabIndex = 3;
            this.subjEditSaveBtn.Text = "Сохранить";
            this.subjEditSaveBtn.UseVisualStyleBackColor = true;
            // 
            // subjEditChooseDropdown
            // 
            this.subjEditChooseDropdown.FormattingEnabled = true;
            this.subjEditChooseDropdown.Location = new System.Drawing.Point(8, 23);
            this.subjEditChooseDropdown.Name = "subjEditChooseDropdown";
            this.subjEditChooseDropdown.Size = new System.Drawing.Size(187, 21);
            this.subjEditChooseDropdown.TabIndex = 2;
            // 
            // subjEditHeader
            // 
            this.subjEditHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjEditHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjEditHeader.Location = new System.Drawing.Point(0, 0);
            this.subjEditHeader.Name = "subjEditHeader";
            this.subjEditHeader.Size = new System.Drawing.Size(208, 20);
            this.subjEditHeader.TabIndex = 0;
            this.subjEditHeader.Text = "Редактирование субъекта";
            this.subjEditHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(239, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 194);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование объекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessMatrix
            // 
            this.accessMatrix.AllowUserToAddRows = false;
            this.accessMatrix.AllowUserToDeleteRows = false;
            this.accessMatrix.AllowUserToResizeColumns = false;
            this.accessMatrix.AllowUserToResizeRows = false;
            this.accessMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accessMatrix.Location = new System.Drawing.Point(3, 3);
            this.accessMatrix.MultiSelect = false;
            this.accessMatrix.Name = "accessMatrix";
            this.accessMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.accessMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.accessMatrix.Size = new System.Drawing.Size(1038, 700);
            this.accessMatrix.TabIndex = 4;
            this.accessMatrix.TabStop = false;
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Location = new System.Drawing.Point(39, 319);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(489, 297);
            this.graphPictureBox.TabIndex = 5;
            this.graphPictureBox.TabStop = false;
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(36, 303);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(35, 13);
            this.graphLabel.TabIndex = 6;
            this.graphLabel.Text = "label2";
            // 
            // drawGraphBtn
            // 
            this.drawGraphBtn.Location = new System.Drawing.Point(439, 278);
            this.drawGraphBtn.Name = "drawGraphBtn";
            this.drawGraphBtn.Size = new System.Drawing.Size(89, 35);
            this.drawGraphBtn.TabIndex = 7;
            this.drawGraphBtn.Text = "button1";
            this.drawGraphBtn.UseVisualStyleBackColor = true;
            this.drawGraphBtn.Click += new System.EventHandler(this.DrawGraph);
            // 
            // rootTabs
            // 
            this.rootTabs.Controls.Add(this.settingsTab);
            this.rootTabs.Controls.Add(this.matrixTab);
            this.rootTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTabs.Location = new System.Drawing.Point(0, 0);
            this.rootTabs.Name = "rootTabs";
            this.rootTabs.SelectedIndex = 0;
            this.rootTabs.Size = new System.Drawing.Size(1052, 732);
            this.rootTabs.TabIndex = 8;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.subjEditContainer);
            this.settingsTab.Controls.Add(this.drawGraphBtn);
            this.settingsTab.Controls.Add(this.graphLabel);
            this.settingsTab.Controls.Add(this.panel1);
            this.settingsTab.Controls.Add(this.graphPictureBox);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1044, 706);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.Text = "Настройки";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // matrixTab
            // 
            this.matrixTab.Controls.Add(this.accessMatrix);
            this.matrixTab.Location = new System.Drawing.Point(4, 22);
            this.matrixTab.Name = "matrixTab";
            this.matrixTab.Padding = new System.Windows.Forms.Padding(3);
            this.matrixTab.Size = new System.Drawing.Size(1044, 706);
            this.matrixTab.TabIndex = 1;
            this.matrixTab.Text = "Матрица доступа";
            this.matrixTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 732);
            this.Controls.Add(this.rootTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TakeGrant";
            this.Load += new System.EventHandler(this.Initialize);
            this.subjEditContainer.ResumeLayout(false);
            this.subjEditContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accessMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.rootTabs.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.matrixTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel subjEditContainer;
        private System.Windows.Forms.ComboBox subjEditChooseDropdown;
        private System.Windows.Forms.Label subjEditHeader;
        private System.Windows.Forms.Button subjEditSaveBtn;
        private System.Windows.Forms.Button subjEditRemoveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subjEditNameLabel;
        private System.Windows.Forms.TextBox subjEditName;
        private System.Windows.Forms.DataGridView accessMatrix;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.Button drawGraphBtn;
        private System.Windows.Forms.TabControl rootTabs;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage matrixTab;
    }
}

