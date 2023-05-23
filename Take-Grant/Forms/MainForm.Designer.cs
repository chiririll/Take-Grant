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
            this.subjEditContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
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
            this.subjEditContainer.Location = new System.Drawing.Point(12, 12);
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
            this.panel1.Location = new System.Drawing.Point(226, 12);
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
            this.accessMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessMatrix.Location = new System.Drawing.Point(463, 12);
            this.accessMatrix.Name = "accessMatrix";
            this.accessMatrix.RowHeadersWidth = 51;
            this.accessMatrix.Size = new System.Drawing.Size(256, 194);
            this.accessMatrix.TabIndex = 4;
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Location = new System.Drawing.Point(188, 371);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(489, 297);
            this.graphPictureBox.TabIndex = 5;
            this.graphPictureBox.TabStop = false;
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(185, 355);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(35, 13);
            this.graphLabel.TabIndex = 6;
            this.graphLabel.Text = "label2";
            // 
            // drawGraphBtn
            // 
            this.drawGraphBtn.Location = new System.Drawing.Point(588, 330);
            this.drawGraphBtn.Name = "drawGraphBtn";
            this.drawGraphBtn.Size = new System.Drawing.Size(89, 35);
            this.drawGraphBtn.TabIndex = 7;
            this.drawGraphBtn.Text = "button1";
            this.drawGraphBtn.UseVisualStyleBackColor = true;
            this.drawGraphBtn.Click += new System.EventHandler(this.DrawGraph);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 732);
            this.Controls.Add(this.drawGraphBtn);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.accessMatrix);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subjEditContainer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Initialize);
            this.subjEditContainer.ResumeLayout(false);
            this.subjEditContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accessMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

