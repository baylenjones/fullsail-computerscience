namespace Game_of_Life
{
    partial class ModalDialog
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.numericUniverse = new System.Windows.Forms.NumericUpDown();
            this.numericMiliseconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUniverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(205, 144);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(294, 144);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // numericUniverse
            // 
            this.numericUniverse.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUniverse.Location = new System.Drawing.Point(137, 30);
            this.numericUniverse.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUniverse.Name = "numericUniverse";
            this.numericUniverse.Size = new System.Drawing.Size(120, 20);
            this.numericUniverse.TabIndex = 2;
            this.numericUniverse.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericMiliseconds
            // 
            this.numericMiliseconds.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericMiliseconds.Location = new System.Drawing.Point(137, 70);
            this.numericMiliseconds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMiliseconds.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericMiliseconds.Name = "numericMiliseconds";
            this.numericMiliseconds.Size = new System.Drawing.Size(120, 20);
            this.numericMiliseconds.TabIndex = 3;
            this.numericMiliseconds.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Universe Size: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miliseconds: ";
            // 
            // ModalDialog
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(381, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericMiliseconds);
            this.Controls.Add(this.numericUniverse);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUniverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiliseconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown numericUniverse;
        private System.Windows.Forms.NumericUpDown numericMiliseconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}