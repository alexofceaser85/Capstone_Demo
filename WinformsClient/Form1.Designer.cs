namespace WinFormsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gradeGradeValueInput = new System.Windows.Forms.TextBox();
            this.gradeSubjectInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.gradeSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradeNameInput = new System.Windows.Forms.TextBox();
            this.gradeGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gradeGridView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.61702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.38298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gradeGradeValueInput, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.gradeSubjectInput, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gradeSubmitButton, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.gradeNameInput, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 203);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gradeGradeValueInput
            // 
            this.gradeGradeValueInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeGradeValueInput.Location = new System.Drawing.Point(3, 148);
            this.gradeGradeValueInput.Name = "gradeGradeValueInput";
            this.gradeGradeValueInput.Size = new System.Drawing.Size(788, 23);
            this.gradeGradeValueInput.TabIndex = 6;
            // 
            // gradeSubjectInput
            // 
            this.gradeSubjectInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeSubjectInput.Location = new System.Drawing.Point(3, 90);
            this.gradeSubjectInput.Name = "gradeSubjectInput";
            this.gradeSubjectInput.Size = new System.Drawing.Size(788, 23);
            this.gradeSubjectInput.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // gradeSubmitButton
            // 
            this.gradeSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gradeSubmitButton.Location = new System.Drawing.Point(359, 177);
            this.gradeSubmitButton.Name = "gradeSubmitButton";
            this.gradeSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.gradeSubmitButton.TabIndex = 1;
            this.gradeSubmitButton.Text = "Submit";
            this.gradeSubmitButton.UseVisualStyleBackColor = true;
            this.gradeSubmitButton.Click += new System.EventHandler(this.gradeSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grade";
            // 
            // gradeNameInput
            // 
            this.gradeNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeNameInput.Location = new System.Drawing.Point(3, 32);
            this.gradeNameInput.Name = "gradeNameInput";
            this.gradeNameInput.Size = new System.Drawing.Size(788, 23);
            this.gradeNameInput.TabIndex = 4;
            // 
            // gradeGridView
            // 
            this.gradeGridView.AllowUserToAddRows = false;
            this.gradeGridView.AllowUserToDeleteRows = false;
            this.gradeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeGridView.Location = new System.Drawing.Point(3, 245);
            this.gradeGridView.Name = "gradeGridView";
            this.gradeGridView.ReadOnly = true;
            this.gradeGridView.RowTemplate.Height = 25;
            this.gradeGridView.Size = new System.Drawing.Size(794, 202);
            this.gradeGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox gradeGradeValueInput;
        private TextBox gradeSubjectInput;
        private Label NameLabel;
        private Button gradeSubmitButton;
        private Label label1;
        private Label label2;
        private TextBox gradeNameInput;
        private DataGridView gradeGridView;
    }
}