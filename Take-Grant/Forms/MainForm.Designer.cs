﻿namespace TakeGrant
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
            this.accessMatrix = new System.Windows.Forms.DataGridView();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.graphLabel = new System.Windows.Forms.Label();
            this.drawGraphBtn = new System.Windows.Forms.Button();
            this.rootTabs = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.editMatrixPanel = new System.Windows.Forms.Panel();
            this.objCount = new System.Windows.Forms.NumericUpDown();
            this.objectsCountLabel = new System.Windows.Forms.Label();
            this.subjectsCountLabel = new System.Windows.Forms.Label();
            this.genRightsBtn = new System.Windows.Forms.Button();
            this.createMatrixBtn = new System.Windows.Forms.Button();
            this.clearRightsBtn = new System.Windows.Forms.Button();
            this.subjCount = new System.Windows.Forms.NumericUpDown();
            this.matrixTab = new System.Windows.Forms.TabPage();
            this.takeGrantTab = new System.Windows.Forms.TabPage();
            this.takeFromDropdown = new System.Windows.Forms.ComboBox();
            this.GiveToDropdown = new System.Windows.Forms.ComboBox();
            this.targetObjDropdown = new System.Windows.Forms.ComboBox();
            this.takeGrantPictureBox = new System.Windows.Forms.PictureBox();
            this.takeBtn = new System.Windows.Forms.Button();
            this.grantBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accessMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.rootTabs.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.editMatrixPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjCount)).BeginInit();
            this.matrixTab.SuspendLayout();
            this.takeGrantTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takeGrantPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accessMatrix
            // 
            this.accessMatrix.AllowUserToAddRows = false;
            this.accessMatrix.AllowUserToDeleteRows = false;
            this.accessMatrix.AllowUserToResizeColumns = false;
            this.accessMatrix.AllowUserToResizeRows = false;
            this.accessMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accessMatrix.Location = new System.Drawing.Point(4, 5);
            this.accessMatrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accessMatrix.MultiSelect = false;
            this.accessMatrix.Name = "accessMatrix";
            this.accessMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.accessMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.accessMatrix.Size = new System.Drawing.Size(1331, 825);
            this.accessMatrix.TabIndex = 4;
            this.accessMatrix.TabStop = false;
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphPictureBox.Location = new System.Drawing.Point(4, 177);
            this.graphPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(1331, 653);
            this.graphPictureBox.TabIndex = 5;
            this.graphPictureBox.TabStop = false;
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(4, 147);
            this.graphLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(343, 20);
            this.graphLabel.TabIndex = 6;
            this.graphLabel.Text = "Нажмите \"Построить граф\" чтобы начать...";
            // 
            // drawGraphBtn
            // 
            this.drawGraphBtn.Location = new System.Drawing.Point(1170, 113);
            this.drawGraphBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawGraphBtn.Name = "drawGraphBtn";
            this.drawGraphBtn.Size = new System.Drawing.Size(160, 54);
            this.drawGraphBtn.TabIndex = 7;
            this.drawGraphBtn.Text = "Построить граф";
            this.drawGraphBtn.UseVisualStyleBackColor = true;
            this.drawGraphBtn.Click += new System.EventHandler(this.DrawGraph);
            // 
            // rootTabs
            // 
            this.rootTabs.Controls.Add(this.settingsTab);
            this.rootTabs.Controls.Add(this.matrixTab);
            this.rootTabs.Controls.Add(this.takeGrantTab);
            this.rootTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTabs.Location = new System.Drawing.Point(0, 0);
            this.rootTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rootTabs.Name = "rootTabs";
            this.rootTabs.SelectedIndex = 0;
            this.rootTabs.Size = new System.Drawing.Size(1347, 868);
            this.rootTabs.TabIndex = 8;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.editMatrixPanel);
            this.settingsTab.Controls.Add(this.drawGraphBtn);
            this.settingsTab.Controls.Add(this.graphLabel);
            this.settingsTab.Controls.Add(this.graphPictureBox);
            this.settingsTab.Location = new System.Drawing.Point(4, 29);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsTab.Size = new System.Drawing.Size(1339, 835);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.Text = "Настройки";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // editMatrixPanel
            // 
            this.editMatrixPanel.Controls.Add(this.objCount);
            this.editMatrixPanel.Controls.Add(this.objectsCountLabel);
            this.editMatrixPanel.Controls.Add(this.subjectsCountLabel);
            this.editMatrixPanel.Controls.Add(this.genRightsBtn);
            this.editMatrixPanel.Controls.Add(this.createMatrixBtn);
            this.editMatrixPanel.Controls.Add(this.clearRightsBtn);
            this.editMatrixPanel.Controls.Add(this.subjCount);
            this.editMatrixPanel.Location = new System.Drawing.Point(8, 8);
            this.editMatrixPanel.Name = "editMatrixPanel";
            this.editMatrixPanel.Size = new System.Drawing.Size(557, 121);
            this.editMatrixPanel.TabIndex = 8;
            // 
            // objCount
            // 
            this.objCount.Location = new System.Drawing.Point(4, 80);
            this.objCount.Name = "objCount";
            this.objCount.Size = new System.Drawing.Size(272, 26);
            this.objCount.TabIndex = 6;
            // 
            // objectsCountLabel
            // 
            this.objectsCountLabel.AutoSize = true;
            this.objectsCountLabel.Location = new System.Drawing.Point(4, 56);
            this.objectsCountLabel.Name = "objectsCountLabel";
            this.objectsCountLabel.Size = new System.Drawing.Size(177, 20);
            this.objectsCountLabel.TabIndex = 5;
            this.objectsCountLabel.Text = "Количество объектов";
            // 
            // subjectsCountLabel
            // 
            this.subjectsCountLabel.AutoSize = true;
            this.subjectsCountLabel.Location = new System.Drawing.Point(3, 0);
            this.subjectsCountLabel.Name = "subjectsCountLabel";
            this.subjectsCountLabel.Size = new System.Drawing.Size(183, 20);
            this.subjectsCountLabel.TabIndex = 4;
            this.subjectsCountLabel.Text = "Количество субъектов";
            // 
            // genRightsBtn
            // 
            this.genRightsBtn.Location = new System.Drawing.Point(282, 56);
            this.genRightsBtn.Name = "genRightsBtn";
            this.genRightsBtn.Size = new System.Drawing.Size(130, 62);
            this.genRightsBtn.TabIndex = 3;
            this.genRightsBtn.Text = "Генерация прав";
            this.genRightsBtn.UseVisualStyleBackColor = true;
            this.genRightsBtn.Click += new System.EventHandler(this.GenerateRights);
            // 
            // createMatrixBtn
            // 
            this.createMatrixBtn.Location = new System.Drawing.Point(282, 8);
            this.createMatrixBtn.Name = "createMatrixBtn";
            this.createMatrixBtn.Size = new System.Drawing.Size(266, 41);
            this.createMatrixBtn.TabIndex = 2;
            this.createMatrixBtn.Text = "Создать матрицу";
            this.createMatrixBtn.UseVisualStyleBackColor = true;
            this.createMatrixBtn.Click += new System.EventHandler(this.CreateMatrix);
            // 
            // clearRightsBtn
            // 
            this.clearRightsBtn.Location = new System.Drawing.Point(418, 56);
            this.clearRightsBtn.Name = "clearRightsBtn";
            this.clearRightsBtn.Size = new System.Drawing.Size(130, 62);
            this.clearRightsBtn.TabIndex = 1;
            this.clearRightsBtn.Text = "Очистить права";
            this.clearRightsBtn.UseVisualStyleBackColor = true;
            this.clearRightsBtn.Click += new System.EventHandler(this.ClearRights);
            // 
            // subjCount
            // 
            this.subjCount.Location = new System.Drawing.Point(7, 23);
            this.subjCount.Name = "subjCount";
            this.subjCount.Size = new System.Drawing.Size(269, 26);
            this.subjCount.TabIndex = 0;
            // 
            // matrixTab
            // 
            this.matrixTab.Controls.Add(this.accessMatrix);
            this.matrixTab.Location = new System.Drawing.Point(4, 29);
            this.matrixTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matrixTab.Name = "matrixTab";
            this.matrixTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matrixTab.Size = new System.Drawing.Size(1339, 835);
            this.matrixTab.TabIndex = 1;
            this.matrixTab.Text = "Матрица доступа";
            this.matrixTab.UseVisualStyleBackColor = true;
            // 
            // takeGrantTab
            // 
            this.takeGrantTab.Controls.Add(this.label3);
            this.takeGrantTab.Controls.Add(this.label2);
            this.takeGrantTab.Controls.Add(this.label1);
            this.takeGrantTab.Controls.Add(this.grantBtn);
            this.takeGrantTab.Controls.Add(this.takeBtn);
            this.takeGrantTab.Controls.Add(this.takeGrantPictureBox);
            this.takeGrantTab.Controls.Add(this.targetObjDropdown);
            this.takeGrantTab.Controls.Add(this.GiveToDropdown);
            this.takeGrantTab.Controls.Add(this.takeFromDropdown);
            this.takeGrantTab.Location = new System.Drawing.Point(4, 29);
            this.takeGrantTab.Name = "takeGrantTab";
            this.takeGrantTab.Size = new System.Drawing.Size(1339, 835);
            this.takeGrantTab.TabIndex = 2;
            this.takeGrantTab.Text = "Take-Grant";
            this.takeGrantTab.UseVisualStyleBackColor = true;
            // 
            // takeFromDropdown
            // 
            this.takeFromDropdown.FormattingEnabled = true;
            this.takeFromDropdown.Location = new System.Drawing.Point(32, 50);
            this.takeFromDropdown.Name = "takeFromDropdown";
            this.takeFromDropdown.Size = new System.Drawing.Size(121, 28);
            this.takeFromDropdown.TabIndex = 0;
            // 
            // GiveToDropdown
            // 
            this.GiveToDropdown.FormattingEnabled = true;
            this.GiveToDropdown.Location = new System.Drawing.Point(159, 50);
            this.GiveToDropdown.Name = "GiveToDropdown";
            this.GiveToDropdown.Size = new System.Drawing.Size(121, 28);
            this.GiveToDropdown.TabIndex = 1;
            // 
            // targetObjDropdown
            // 
            this.targetObjDropdown.FormattingEnabled = true;
            this.targetObjDropdown.Location = new System.Drawing.Point(286, 50);
            this.targetObjDropdown.Name = "targetObjDropdown";
            this.targetObjDropdown.Size = new System.Drawing.Size(121, 28);
            this.targetObjDropdown.TabIndex = 2;
            // 
            // takeGrantPictureBox
            // 
            this.takeGrantPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.takeGrantPictureBox.Location = new System.Drawing.Point(0, 111);
            this.takeGrantPictureBox.Name = "takeGrantPictureBox";
            this.takeGrantPictureBox.Size = new System.Drawing.Size(1339, 724);
            this.takeGrantPictureBox.TabIndex = 3;
            this.takeGrantPictureBox.TabStop = false;
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(440, 37);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(159, 41);
            this.takeBtn.TabIndex = 4;
            this.takeBtn.Text = "Take";
            this.takeBtn.UseVisualStyleBackColor = true;
            // 
            // grantBtn
            // 
            this.grantBtn.Location = new System.Drawing.Point(605, 37);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(159, 42);
            this.grantBtn.TabIndex = 5;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 868);
            this.Controls.Add(this.rootTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TakeGrant";
            this.Load += new System.EventHandler(this.Initialize);
            ((System.ComponentModel.ISupportInitialize)(this.accessMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.rootTabs.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.editMatrixPanel.ResumeLayout(false);
            this.editMatrixPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjCount)).EndInit();
            this.matrixTab.ResumeLayout(false);
            this.takeGrantTab.ResumeLayout(false);
            this.takeGrantTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takeGrantPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView accessMatrix;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.Button drawGraphBtn;
        private System.Windows.Forms.TabControl rootTabs;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage matrixTab;
        private System.Windows.Forms.Panel editMatrixPanel;
        private System.Windows.Forms.Label subjectsCountLabel;
        private System.Windows.Forms.Button genRightsBtn;
        private System.Windows.Forms.Button createMatrixBtn;
        private System.Windows.Forms.Button clearRightsBtn;
        private System.Windows.Forms.NumericUpDown subjCount;
        private System.Windows.Forms.NumericUpDown objCount;
        private System.Windows.Forms.Label objectsCountLabel;
        private System.Windows.Forms.TabPage takeGrantTab;
        private System.Windows.Forms.PictureBox takeGrantPictureBox;
        private System.Windows.Forms.ComboBox targetObjDropdown;
        private System.Windows.Forms.ComboBox GiveToDropdown;
        private System.Windows.Forms.ComboBox takeFromDropdown;
        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

