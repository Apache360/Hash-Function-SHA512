
namespace Hash_Function
{
    partial class windowMain
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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.richTextBoxInput1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput1 = new System.Windows.Forms.RichTextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxSeparator = new System.Windows.Forms.TextBox();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.labelOutput1 = new System.Windows.Forms.Label();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.richTextBoxInput2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxOutput2 = new System.Windows.Forms.RichTextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 220);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(277, 23);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // richTextBoxInput1
            // 
            this.richTextBoxInput1.Location = new System.Drawing.Point(12, 63);
            this.richTextBoxInput1.Name = "richTextBoxInput1";
            this.richTextBoxInput1.Size = new System.Drawing.Size(277, 65);
            this.richTextBoxInput1.TabIndex = 1;
            this.richTextBoxInput1.Text = "";
            // 
            // richTextBoxOutput1
            // 
            this.richTextBoxOutput1.Location = new System.Drawing.Point(12, 149);
            this.richTextBoxOutput1.Name = "richTextBoxOutput1";
            this.richTextBoxOutput1.Size = new System.Drawing.Size(277, 65);
            this.richTextBoxOutput1.TabIndex = 4;
            this.richTextBoxOutput1.Text = "";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(300, 220);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(144, 23);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxSeparator
            // 
            this.textBoxSeparator.Location = new System.Drawing.Point(108, 12);
            this.textBoxSeparator.Name = "textBoxSeparator";
            this.textBoxSeparator.Size = new System.Drawing.Size(100, 23);
            this.textBoxSeparator.TabIndex = 7;
            this.textBoxSeparator.Text = ";";
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.Location = new System.Drawing.Point(12, 15);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(90, 15);
            this.labelSeparator.TabIndex = 8;
            this.labelSeparator.Text = "Input separator:";
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Location = new System.Drawing.Point(12, 45);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(64, 15);
            this.labelInput1.TabIndex = 9;
            this.labelInput1.Text = "Input data:";
            // 
            // labelOutput1
            // 
            this.labelOutput1.AutoSize = true;
            this.labelOutput1.Location = new System.Drawing.Point(12, 131);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(76, 15);
            this.labelOutput1.TabIndex = 10;
            this.labelOutput1.Text = "Output hash:";
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.Location = new System.Drawing.Point(300, 45);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(66, 15);
            this.labelInput2.TabIndex = 11;
            this.labelInput2.Text = "Input hash:";
            // 
            // richTextBoxInput2
            // 
            this.richTextBoxInput2.Location = new System.Drawing.Point(300, 63);
            this.richTextBoxInput2.Name = "richTextBoxInput2";
            this.richTextBoxInput2.Size = new System.Drawing.Size(277, 65);
            this.richTextBoxInput2.TabIndex = 12;
            this.richTextBoxInput2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Output data:";
            // 
            // richTextBoxOutput2
            // 
            this.richTextBoxOutput2.Location = new System.Drawing.Point(300, 149);
            this.richTextBoxOutput2.Name = "richTextBoxOutput2";
            this.richTextBoxOutput2.Size = new System.Drawing.Size(277, 65);
            this.richTextBoxOutput2.TabIndex = 14;
            this.richTextBoxOutput2.Text = "";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(214, 12);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 15;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(12, 252);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(30, 15);
            this.labelLog.TabIndex = 16;
            this.labelLog.Text = "Log:";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(48, 249);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(529, 103);
            this.richTextBoxLog.TabIndex = 17;
            this.richTextBoxLog.Text = "";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(451, 220);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(122, 23);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Stop Decrypting";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(300, 12);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(194, 23);
            this.buttonCopy.TabIndex = 19;
            this.buttonCopy.Text = "Copy output hash to input hash";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 364);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.richTextBoxOutput2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInput2);
            this.Controls.Add(this.labelInput2);
            this.Controls.Add(this.labelOutput1);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.textBoxSeparator);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.richTextBoxOutput1);
            this.Controls.Add(this.richTextBoxInput1);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "windowMain";
            this.Text = "Hash Function SHA512";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RichTextBox richTextBoxInput1;
        private System.Windows.Forms.RichTextBox richTextBoxOutput1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxSeparator;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Label labelOutput1;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.RichTextBox richTextBoxInput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxOutput2;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonCopy;
    }

}

