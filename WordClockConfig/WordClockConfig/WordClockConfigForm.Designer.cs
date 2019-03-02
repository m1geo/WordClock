namespace WordClockConfig
{
    partial class WordClockConfigForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.m_SaveButton = new System.Windows.Forms.Button();
            this.m_PortPicker = new System.Windows.Forms.ComboBox();
            this.m_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.m_TimePicker = new System.Windows.Forms.DateTimePicker();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(this.m_SaveButton, 1, 3);
            tableLayoutPanel1.Controls.Add(this.m_PortPicker, 1, 0);
            tableLayoutPanel1.Controls.Add(this.m_DatePicker, 1, 1);
            tableLayoutPanel1.Controls.Add(this.m_TimePicker, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new System.Drawing.Size(337, 197);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 0;
            label1.Text = "Serial port:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 13);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 13);
            label3.TabIndex = 2;
            label3.Text = "Time:";
            // 
            // m_SaveButton
            // 
            this.m_SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.m_SaveButton.Location = new System.Drawing.Point(66, 160);
            this.m_SaveButton.Name = "m_SaveButton";
            this.m_SaveButton.Size = new System.Drawing.Size(268, 23);
            this.m_SaveButton.TabIndex = 3;
            this.m_SaveButton.Text = "&Save Configuration";
            this.m_SaveButton.UseVisualStyleBackColor = true;
            this.m_SaveButton.Click += new System.EventHandler(this.SaveConfigurationClicked);
            // 
            // m_PortPicker
            // 
            this.m_PortPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PortPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_PortPicker.FormattingEnabled = true;
            this.m_PortPicker.Location = new System.Drawing.Point(66, 14);
            this.m_PortPicker.Name = "m_PortPicker";
            this.m_PortPicker.Size = new System.Drawing.Size(268, 21);
            this.m_PortPicker.TabIndex = 4;
            // 
            // m_DatePicker
            // 
            this.m_DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.m_DatePicker.Location = new System.Drawing.Point(66, 63);
            this.m_DatePicker.Name = "m_DatePicker";
            this.m_DatePicker.Size = new System.Drawing.Size(268, 20);
            this.m_DatePicker.TabIndex = 5;
            this.m_DatePicker.ValueChanged += new System.EventHandler(this.TimeChanged);
            // 
            // m_TimePicker
            // 
            this.m_TimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.m_TimePicker.Location = new System.Drawing.Point(66, 112);
            this.m_TimePicker.Name = "m_TimePicker";
            this.m_TimePicker.ShowUpDown = true;
            this.m_TimePicker.Size = new System.Drawing.Size(268, 20);
            this.m_TimePicker.TabIndex = 6;
            this.m_TimePicker.ValueChanged += new System.EventHandler(this.TimeChanged);
            // 
            // WordClockConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 197);
            this.Controls.Add(tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "WordClockConfigForm";
            this.Text = "WordClock Configuration";
            this.Load += new System.EventHandler(this.WordClockConfigForm_Load);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button m_SaveButton;
        private System.Windows.Forms.ComboBox m_PortPicker;
        private System.Windows.Forms.DateTimePicker m_DatePicker;
        private System.Windows.Forms.DateTimePicker m_TimePicker;
    }
}

