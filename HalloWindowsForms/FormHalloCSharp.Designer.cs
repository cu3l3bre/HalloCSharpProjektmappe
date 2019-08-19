namespace HalloWindowsForms
{
    partial class FormHalloCSharp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Close = new System.Windows.Forms.Button();
            this.button_ShowText = new System.Windows.Forms.Button();
            this.label_Text = new System.Windows.Forms.Label();
            this.button_HideText = new System.Windows.Forms.Button();
            this.textBox_Eingabe = new System.Windows.Forms.TextBox();
            this.button_CountWords = new System.Windows.Forms.Button();
            this.label_NumberWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(671, 397);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(144, 65);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // button_ShowText
            // 
            this.button_ShowText.Location = new System.Drawing.Point(200, 12);
            this.button_ShowText.Name = "button_ShowText";
            this.button_ShowText.Size = new System.Drawing.Size(75, 23);
            this.button_ShowText.TabIndex = 1;
            this.button_ShowText.Text = "Show Text";
            this.button_ShowText.UseVisualStyleBackColor = true;
            this.button_ShowText.Click += new System.EventHandler(this.Button_ShowText_Click);
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text.ForeColor = System.Drawing.Color.Red;
            this.label_Text.Location = new System.Drawing.Point(12, 103);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(178, 20);
            this.label_Text.TabIndex = 2;
            this.label_Text.Text = "Das ist ein toller Text";
            // 
            // button_HideText
            // 
            this.button_HideText.Location = new System.Drawing.Point(200, 41);
            this.button_HideText.Name = "button_HideText";
            this.button_HideText.Size = new System.Drawing.Size(75, 23);
            this.button_HideText.TabIndex = 3;
            this.button_HideText.Text = "Hide Text";
            this.button_HideText.UseVisualStyleBackColor = true;
            this.button_HideText.Click += new System.EventHandler(this.Button_HideText_Click);
            // 
            // textBox_Eingabe
            // 
            this.textBox_Eingabe.Location = new System.Drawing.Point(12, 12);
            this.textBox_Eingabe.Multiline = true;
            this.textBox_Eingabe.Name = "textBox_Eingabe";
            this.textBox_Eingabe.Size = new System.Drawing.Size(182, 74);
            this.textBox_Eingabe.TabIndex = 4;
            this.textBox_Eingabe.TextChanged += new System.EventHandler(this.TextBox_Eingabe_TextChanged);
            // 
            // button_CountWords
            // 
            this.button_CountWords.Location = new System.Drawing.Point(327, 41);
            this.button_CountWords.Name = "button_CountWords";
            this.button_CountWords.Size = new System.Drawing.Size(93, 23);
            this.button_CountWords.TabIndex = 5;
            this.button_CountWords.Text = "Count Words";
            this.button_CountWords.UseVisualStyleBackColor = true;
            this.button_CountWords.Click += new System.EventHandler(this.Button_CountWords_Click);
            // 
            // label_NumberWords
            // 
            this.label_NumberWords.AutoSize = true;
            this.label_NumberWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberWords.ForeColor = System.Drawing.Color.Black;
            this.label_NumberWords.Location = new System.Drawing.Point(426, 44);
            this.label_NumberWords.Name = "label_NumberWords";
            this.label_NumberWords.Size = new System.Drawing.Size(19, 20);
            this.label_NumberWords.TabIndex = 6;
            this.label_NumberWords.Text = "0";
            // 
            // FormHalloCSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 474);
            this.Controls.Add(this.label_NumberWords);
            this.Controls.Add(this.button_CountWords);
            this.Controls.Add(this.textBox_Eingabe);
            this.Controls.Add(this.button_HideText);
            this.Controls.Add(this.label_Text);
            this.Controls.Add(this.button_ShowText);
            this.Controls.Add(this.button_Close);
            this.Name = "FormHalloCSharp";
            this.Text = "Hallo das ist ein Fenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_ShowText;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.Button button_HideText;
        public System.Windows.Forms.TextBox textBox_Eingabe;
        private System.Windows.Forms.Button button_CountWords;
        private System.Windows.Forms.Label label_NumberWords;
    }
}

