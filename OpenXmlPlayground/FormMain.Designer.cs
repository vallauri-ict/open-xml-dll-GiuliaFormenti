﻿namespace OpenXmlPlayground
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpleWordTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleWordTest
            // 
            this.btnSimpleWordTest.Location = new System.Drawing.Point(16, 15);
            this.btnSimpleWordTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpleWordTest.Name = "btnSimpleWordTest";
            this.btnSimpleWordTest.Size = new System.Drawing.Size(613, 28);
            this.btnSimpleWordTest.TabIndex = 0;
            this.btnSimpleWordTest.Text = "SIMPLE WORD DOCUMENT TEST";
            this.btnSimpleWordTest.UseVisualStyleBackColor = true;
            this.btnSimpleWordTest.Click += new System.EventHandler(this.btnSimpleWordTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(613, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "SIMPLE EXCEL DOCUMENT TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSimpleWordTest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "OpenXML Playground";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleWordTest;
        private System.Windows.Forms.Button button1;
    }
}

