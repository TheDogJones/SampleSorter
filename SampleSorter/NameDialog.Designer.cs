namespace SampleSorter
{
    partial class NameDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameDialog));
            this.lEnter = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bOkay = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lEnter
            // 
            this.lEnter.AutoSize = true;
            this.lEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnter.Location = new System.Drawing.Point(10, 20);
            this.lEnter.Name = "lEnter";
            this.lEnter.Size = new System.Drawing.Size(134, 17);
            this.lEnter.TabIndex = 0;
            this.lEnter.Text = "Enter new value: ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(144, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(341, 23);
            this.tbName.TabIndex = 1;
            // 
            // bOkay
            // 
            this.bOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOkay.Location = new System.Drawing.Point(317, 47);
            this.bOkay.Name = "bOkay";
            this.bOkay.Size = new System.Drawing.Size(75, 23);
            this.bOkay.TabIndex = 2;
            this.bOkay.Text = "OK";
            this.bOkay.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(410, 47);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // NameDialog
            // 
            this.AcceptButton = this.bOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(497, 84);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOkay);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameDialog";
            this.Text = "Custom Field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEnter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bOkay;
        private System.Windows.Forms.Button bCancel;
    }
}