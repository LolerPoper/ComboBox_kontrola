namespace ComboBox_kontrola
{
    partial class Form1
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
            this.CmbOdabir = new System.Windows.Forms.ComboBox();
            this.TxtOdabir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbOdabir
            // 
            this.CmbOdabir.FormattingEnabled = true;
            this.CmbOdabir.Items.AddRange(new object[] {
            "IT menadzment",
            "aplikativno programiranje",
            "internet programiranje",
            "informacioni sistemi"});
            this.CmbOdabir.Location = new System.Drawing.Point(48, 54);
            this.CmbOdabir.Name = "CmbOdabir";
            this.CmbOdabir.Size = new System.Drawing.Size(194, 21);
            this.CmbOdabir.TabIndex = 0;
            this.CmbOdabir.SelectedIndexChanged += new System.EventHandler(this.CmbOdabir_SelectedIndexChanged);
            // 
            // TxtOdabir
            // 
            this.TxtOdabir.Location = new System.Drawing.Point(48, 128);
            this.TxtOdabir.Name = "TxtOdabir";
            this.TxtOdabir.ReadOnly = true;
            this.TxtOdabir.Size = new System.Drawing.Size(194, 20);
            this.TxtOdabir.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 227);
            this.Controls.Add(this.TxtOdabir);
            this.Controls.Add(this.CmbOdabir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbOdabir;
        private System.Windows.Forms.TextBox TxtOdabir;
    }
}

