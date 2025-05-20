namespace vtep
{
    partial class FormVtep
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
            this.textBoxVtep1 = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSaveTextBoxVtep1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxVtep1
            // 
            this.textBoxVtep1.Location = new System.Drawing.Point(51, 37);
            this.textBoxVtep1.Multiline = true;
            this.textBoxVtep1.Name = "textBoxVtep1";
            this.textBoxVtep1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxVtep1.Size = new System.Drawing.Size(680, 298);
            this.textBoxVtep1.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(51, 368);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(107, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(608, 368);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(123, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSaveTextBoxVtep1
            // 
            this.buttonSaveTextBoxVtep1.Location = new System.Drawing.Point(290, 368);
            this.buttonSaveTextBoxVtep1.Name = "buttonSaveTextBoxVtep1";
            this.buttonSaveTextBoxVtep1.Size = new System.Drawing.Size(176, 23);
            this.buttonSaveTextBoxVtep1.TabIndex = 3;
            this.buttonSaveTextBoxVtep1.Text = "Save Text";
            this.buttonSaveTextBoxVtep1.UseVisualStyleBackColor = true;
            this.buttonSaveTextBoxVtep1.Click += new System.EventHandler(this.buttonSaveText_Click);
            this.buttonSaveTextBoxVtep1.Visible = false;
            this.buttonSaveTextBoxVtep1.Enabled = false;
            // 
            // FormVtep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveTextBoxVtep1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxVtep1);
            this.Name = "FormVtep";
            this.Text = "vtep";
            this.Load += new System.EventHandler(this.FormVtep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVtep1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSaveTextBoxVtep1;
    }
}