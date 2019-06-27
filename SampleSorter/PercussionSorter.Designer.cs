namespace SampleSorter {
	partial class PercussionSorter {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.selectDirectory = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.bBigKick = new System.Windows.Forms.Button();
            this.bPlaySample = new System.Windows.Forms.Button();
            this.bLittleSnare = new System.Windows.Forms.Button();
            this.bCHat = new System.Windows.Forms.Button();
            this.bOpenHat = new System.Windows.Forms.Button();
            this.bBigCymbal = new System.Windows.Forms.Button();
            this.bLittleCymbal = new System.Windows.Forms.Button();
            this.bChina = new System.Windows.Forms.Button();
            this.bPercussion = new System.Windows.Forms.Button();
            this.bBigSnare = new System.Windows.Forms.Button();
            this.bLittleKick = new System.Windows.Forms.Button();
            this.bFx = new System.Windows.Forms.Button();
            this.bOther = new System.Windows.Forms.Button();
            this.bGarbage = new System.Windows.Forms.Button();
            this.bClap = new System.Windows.Forms.Button();
            this.bSkip = new System.Windows.Forms.Button();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbLink = new System.Windows.Forms.RadioButton();
            this.bCustom0 = new System.Windows.Forms.Button();
            this.bCustom1 = new System.Windows.Forms.Button();
            this.bCustom2 = new System.Windows.Forms.Button();
            this.bCustom3 = new System.Windows.Forms.Button();
            this.bCustom4 = new System.Windows.Forms.Button();
            this.bCustom5 = new System.Windows.Forms.Button();
            this.bCustom6 = new System.Windows.Forms.Button();
            this.bCustom7 = new System.Windows.Forms.Button();
            this.bCustom8 = new System.Windows.Forms.Button();
            this.bCustom9 = new System.Windows.Forms.Button();
            this.gbFileAction = new System.Windows.Forms.GroupBox();
            this.bCustom10 = new System.Windows.Forms.Button();
            this.bCustom11 = new System.Windows.Forms.Button();
            this.bCustom12 = new System.Windows.Forms.Button();
            this.bCustom13 = new System.Windows.Forms.Button();
            this.bCustom14 = new System.Windows.Forms.Button();
            this.gbFileAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectDirectory
            // 
            this.selectDirectory.Location = new System.Drawing.Point(52, 29);
            this.selectDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.selectDirectory.Name = "selectDirectory";
            this.selectDirectory.Size = new System.Drawing.Size(150, 23);
            this.selectDirectory.TabIndex = 0;
            this.selectDirectory.Text = "Select Directory...";
            this.selectDirectory.UseVisualStyleBackColor = true;
            this.selectDirectory.Click += new System.EventHandler(this.selectDirectory_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(217, 32);
            this.tbDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.ReadOnly = true;
            this.tbDirectory.Size = new System.Drawing.Size(539, 20);
            this.tbDirectory.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(46, 133);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(219, 31);
            this.label.Text = "This sample is....";
            this.label.Visible = false;
            // 
            // bPlaySample
            // 
            this.bPlaySample.Location = new System.Drawing.Point(52, 73);
            this.bPlaySample.Margin = new System.Windows.Forms.Padding(2);
            this.bPlaySample.Name = "bPlaySample";
            this.bPlaySample.Size = new System.Drawing.Size(221, 43);
            this.bPlaySample.TabIndex = 2;
            this.bPlaySample.UseVisualStyleBackColor = true;
            this.bPlaySample.Visible = false;
            this.bPlaySample.Click += new System.EventHandler(this.bPlaySample_Click);
            // 
            // bSkip
            // 
            this.bSkip.Location = new System.Drawing.Point(298, 75);
            this.bSkip.Margin = new System.Windows.Forms.Padding(2);
            this.bSkip.Name = "bSkip";
            this.bSkip.Size = new System.Drawing.Size(123, 39);
            this.bSkip.TabIndex = 3;
            this.bSkip.Text = "Skip";
            this.bSkip.UseVisualStyleBackColor = true;
            this.bSkip.Visible = false;
            this.bSkip.Click += new System.EventHandler(this.bSkip_Click);
            // 
            // bGarbage
            // 
            this.bGarbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGarbage.Location = new System.Drawing.Point(449, 74);
            this.bGarbage.Margin = new System.Windows.Forms.Padding(2);
            this.bGarbage.Name = "bGarbage";
            this.bGarbage.Size = new System.Drawing.Size(123, 39);
            this.bGarbage.TabIndex = 4;
            this.bGarbage.Text = "GARBAGE";
            this.bGarbage.UseVisualStyleBackColor = true;
            this.bGarbage.Visible = false;
            this.bGarbage.Click += new System.EventHandler(this.bGarbage_Click);
            // 
            // bBigKick
            // 
            this.bBigKick.Location = new System.Drawing.Point(35, 180);
            this.bBigKick.Margin = new System.Windows.Forms.Padding(2);
            this.bBigKick.Name = "bBigKick";
            this.bBigKick.Size = new System.Drawing.Size(123, 39);
            this.bBigKick.TabIndex = 6;
            this.bBigKick.Text = "Big Kick";
            this.bBigKick.UseVisualStyleBackColor = true;
            this.bBigKick.Visible = false;
            this.bBigKick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bLittleSnare
            // 
            this.bLittleSnare.Location = new System.Drawing.Point(242, 230);
            this.bLittleSnare.Margin = new System.Windows.Forms.Padding(2);
            this.bLittleSnare.Name = "bLittleSnare";
            this.bLittleSnare.Size = new System.Drawing.Size(123, 39);
            this.bLittleSnare.TabIndex = 14;
            this.bLittleSnare.Text = "Little Snare";
            this.bLittleSnare.UseVisualStyleBackColor = true;
            this.bLittleSnare.Visible = false;
            this.bLittleSnare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCHat
            // 
            this.bCHat.Location = new System.Drawing.Point(35, 337);
            this.bCHat.Margin = new System.Windows.Forms.Padding(2);
            this.bCHat.Name = "bCHat";
            this.bCHat.Size = new System.Drawing.Size(123, 39);
            this.bCHat.TabIndex = 9;
            this.bCHat.Text = "Closed Hat";
            this.bCHat.UseVisualStyleBackColor = true;
            this.bCHat.Visible = false;
            this.bCHat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bOpenHat
            // 
            this.bOpenHat.Location = new System.Drawing.Point(242, 337);
            this.bOpenHat.Margin = new System.Windows.Forms.Padding(2);
            this.bOpenHat.Name = "bOpenHat";
            this.bOpenHat.Size = new System.Drawing.Size(123, 39);
            this.bOpenHat.TabIndex = 16;
            this.bOpenHat.Text = "Open Hat";
            this.bOpenHat.UseVisualStyleBackColor = true;
            this.bOpenHat.Visible = false;
            this.bOpenHat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bBigCymbal
            // 
            this.bBigCymbal.Location = new System.Drawing.Point(35, 391);
            this.bBigCymbal.Margin = new System.Windows.Forms.Padding(2);
            this.bBigCymbal.Name = "bBigCymbal";
            this.bBigCymbal.Size = new System.Drawing.Size(123, 39);
            this.bBigCymbal.TabIndex = 10;
            this.bBigCymbal.Text = "Big Cymbal";
            this.bBigCymbal.UseVisualStyleBackColor = true;
            this.bBigCymbal.Visible = false;
            this.bBigCymbal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bLittleCymbal
            // 
            this.bLittleCymbal.Location = new System.Drawing.Point(242, 391);
            this.bLittleCymbal.Margin = new System.Windows.Forms.Padding(2);
            this.bLittleCymbal.Name = "bLittleCymbal";
            this.bLittleCymbal.Size = new System.Drawing.Size(123, 39);
            this.bLittleCymbal.TabIndex = 17;
            this.bLittleCymbal.Text = "Little Cymbal";
            this.bLittleCymbal.UseVisualStyleBackColor = true;
            this.bLittleCymbal.Visible = false;
            this.bLittleCymbal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bChina
            // 
            this.bChina.Location = new System.Drawing.Point(35, 443);
            this.bChina.Margin = new System.Windows.Forms.Padding(2);
            this.bChina.Name = "bChina";
            this.bChina.Size = new System.Drawing.Size(123, 39);
            this.bChina.TabIndex = 11;
            this.bChina.Text = "China Cymbal";
            this.bChina.UseVisualStyleBackColor = true;
            this.bChina.Visible = false;
            this.bChina.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bPercussion
            // 
            this.bPercussion.Location = new System.Drawing.Point(242, 443);
            this.bPercussion.Margin = new System.Windows.Forms.Padding(2);
            this.bPercussion.Name = "bPercussion";
            this.bPercussion.Size = new System.Drawing.Size(123, 39);
            this.bPercussion.TabIndex = 18;
            this.bPercussion.Text = "Percussion";
            this.bPercussion.UseVisualStyleBackColor = true;
            this.bPercussion.Visible = false;
            this.bPercussion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bBigSnare
            // 
            this.bBigSnare.Location = new System.Drawing.Point(35, 230);
            this.bBigSnare.Margin = new System.Windows.Forms.Padding(2);
            this.bBigSnare.Name = "bBigSnare";
            this.bBigSnare.Size = new System.Drawing.Size(123, 39);
            this.bBigSnare.TabIndex = 7;
            this.bBigSnare.Text = "Big Snare";
            this.bBigSnare.UseVisualStyleBackColor = true;
            this.bBigSnare.Visible = false;
            this.bBigSnare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bLittleKick
            // 
            this.bLittleKick.Location = new System.Drawing.Point(242, 180);
            this.bLittleKick.Margin = new System.Windows.Forms.Padding(2);
            this.bLittleKick.Name = "bLittleKick";
            this.bLittleKick.Size = new System.Drawing.Size(123, 39);
            this.bLittleKick.TabIndex = 13;
            this.bLittleKick.Text = "Little Kick";
            this.bLittleKick.UseVisualStyleBackColor = true;
            this.bLittleKick.Visible = false;
            this.bLittleKick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bFx
            // 
            this.bFx.Location = new System.Drawing.Point(35, 283);
            this.bFx.Margin = new System.Windows.Forms.Padding(2);
            this.bFx.Name = "bFx";
            this.bFx.Size = new System.Drawing.Size(123, 39);
            this.bFx.TabIndex = 8;
            this.bFx.Text = "FX";
            this.bFx.UseVisualStyleBackColor = true;
            this.bFx.Visible = false;
            this.bFx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bOther
            // 
            this.bOther.Location = new System.Drawing.Point(35, 497);
            this.bOther.Margin = new System.Windows.Forms.Padding(2);
            this.bOther.Name = "bOther";
            this.bOther.Size = new System.Drawing.Size(123, 39);
            this.bOther.TabIndex = 12;
            this.bOther.Text = "Other";
            this.bOther.UseVisualStyleBackColor = true;
            this.bOther.Visible = false;
            this.bOther.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bClap
            // 
            this.bClap.Location = new System.Drawing.Point(242, 283);
            this.bClap.Margin = new System.Windows.Forms.Padding(2);
            this.bClap.Name = "bClap";
            this.bClap.Size = new System.Drawing.Size(123, 39);
            this.bClap.TabIndex = 15;
            this.bClap.Text = "Clap";
            this.bClap.UseVisualStyleBackColor = true;
            this.bClap.Visible = false;
            this.bClap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(6, 15);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(68, 17);
            this.rbMove.TabIndex = 0;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move file";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(6, 35);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(68, 17);
            this.rbCopy.TabIndex = 1;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "Copy File";
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // rbLink
            // 
            this.rbLink.AutoSize = true;
            this.rbLink.Location = new System.Drawing.Point(6, 55);
            this.rbLink.Name = "rbLink";
            this.rbLink.Size = new System.Drawing.Size(127, 17);
            this.rbLink.TabIndex = 2;
            this.rbLink.TabStop = true;
            this.rbLink.Text = "Create hard link to file";
            this.rbLink.UseVisualStyleBackColor = true;
            // 
            // bCustom0
            // 
            this.bCustom0.Location = new System.Drawing.Point(449, 230);
            this.bCustom0.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom0.Name = "bCustom0";
            this.bCustom0.Size = new System.Drawing.Size(123, 39);
            this.bCustom0.TabIndex = 21;
            this.bCustom0.Text = "(set)";
            this.bCustom0.UseVisualStyleBackColor = true;
            this.bCustom0.Visible = false;
            this.bCustom0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom1
            // 
            this.bCustom1.Location = new System.Drawing.Point(449, 180);
            this.bCustom1.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom1.Name = "bCustom1";
            this.bCustom1.Size = new System.Drawing.Size(123, 39);
            this.bCustom1.TabIndex = 20;
            this.bCustom1.Text = "(set)";
            this.bCustom1.UseVisualStyleBackColor = true;
            this.bCustom1.Visible = false;
            this.bCustom1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom2
            // 
            this.bCustom2.Location = new System.Drawing.Point(449, 283);
            this.bCustom2.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom2.Name = "bCustom2";
            this.bCustom2.Size = new System.Drawing.Size(123, 39);
            this.bCustom2.TabIndex = 22;
            this.bCustom2.Text = "(set)";
            this.bCustom2.UseVisualStyleBackColor = true;
            this.bCustom2.Visible = false;
            this.bCustom2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom3
            // 
            this.bCustom3.Location = new System.Drawing.Point(449, 337);
            this.bCustom3.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom3.Name = "bCustom3";
            this.bCustom3.Size = new System.Drawing.Size(123, 39);
            this.bCustom3.TabIndex = 23;
            this.bCustom3.Text = "(set)";
            this.bCustom3.UseVisualStyleBackColor = true;
            this.bCustom3.Visible = false;
            this.bCustom3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom4
            // 
            this.bCustom4.Location = new System.Drawing.Point(449, 391);
            this.bCustom4.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom4.Name = "bCustom4";
            this.bCustom4.Size = new System.Drawing.Size(123, 39);
            this.bCustom4.TabIndex = 24;
            this.bCustom4.Text = "(set)";
            this.bCustom4.UseVisualStyleBackColor = true;
            this.bCustom4.Visible = false;
            this.bCustom4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom5
            // 
            this.bCustom5.Location = new System.Drawing.Point(449, 443);
            this.bCustom5.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom5.Name = "bCustom5";
            this.bCustom5.Size = new System.Drawing.Size(123, 39);
            this.bCustom5.TabIndex = 25;
            this.bCustom5.Text = "(set)";
            this.bCustom5.UseVisualStyleBackColor = true;
            this.bCustom5.Visible = false;
            this.bCustom5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom6
            // 
            this.bCustom6.Location = new System.Drawing.Point(449, 496);
            this.bCustom6.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom6.Name = "bCustom6";
            this.bCustom6.Size = new System.Drawing.Size(123, 39);
            this.bCustom6.TabIndex = 26;
            this.bCustom6.Text = "(set)";
            this.bCustom6.UseVisualStyleBackColor = true;
            this.bCustom6.Visible = false;
            this.bCustom6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom7
            // 
            this.bCustom7.Location = new System.Drawing.Point(242, 496);
            this.bCustom7.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom7.Name = "bCustom7";
            this.bCustom7.Size = new System.Drawing.Size(123, 39);
            this.bCustom7.TabIndex = 19;
            this.bCustom7.Text = "(set)";
            this.bCustom7.UseVisualStyleBackColor = true;
            this.bCustom7.Visible = false;
            this.bCustom7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom8
            // 
            this.bCustom8.Location = new System.Drawing.Point(656, 180);
            this.bCustom8.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom8.Name = "bCustom8";
            this.bCustom8.Size = new System.Drawing.Size(123, 39);
            this.bCustom8.TabIndex = 27;
            this.bCustom8.Text = "(set)";
            this.bCustom8.UseVisualStyleBackColor = true;
            this.bCustom8.Visible = false;
            this.bCustom8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom9
            // 
            this.bCustom9.Location = new System.Drawing.Point(656, 230);
            this.bCustom9.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom9.Name = "bCustom9";
            this.bCustom9.Size = new System.Drawing.Size(123, 39);
            this.bCustom9.TabIndex = 28;
            this.bCustom9.Text = "(set)";
            this.bCustom9.UseVisualStyleBackColor = true;
            this.bCustom9.Visible = false;
            this.bCustom9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // gbFileAction
            // 
            this.gbFileAction.Controls.Add(this.rbMove);
            this.gbFileAction.Controls.Add(this.rbLink);
            this.gbFileAction.Controls.Add(this.rbCopy);
            this.gbFileAction.Location = new System.Drawing.Point(612, 75);
            this.gbFileAction.Name = "gbFileAction";
            this.gbFileAction.Size = new System.Drawing.Size(144, 82);
            this.gbFileAction.TabIndex = 5;
            this.gbFileAction.TabStop = false;
            this.gbFileAction.Text = "File Action";
            this.gbFileAction.Visible = false;
            // 
            // bCustom10
            // 
            this.bCustom10.Location = new System.Drawing.Point(656, 283);
            this.bCustom10.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom10.Name = "bCustom10";
            this.bCustom10.Size = new System.Drawing.Size(123, 39);
            this.bCustom10.TabIndex = 29;
            this.bCustom10.Text = "(set)";
            this.bCustom10.UseVisualStyleBackColor = true;
            this.bCustom10.Visible = false;
            this.bCustom10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom11
            // 
            this.bCustom11.Location = new System.Drawing.Point(656, 337);
            this.bCustom11.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom11.Name = "bCustom11";
            this.bCustom11.Size = new System.Drawing.Size(123, 39);
            this.bCustom11.TabIndex = 30;
            this.bCustom11.Text = "(set)";
            this.bCustom11.UseVisualStyleBackColor = true;
            this.bCustom11.Visible = false;
            this.bCustom11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom12
            // 
            this.bCustom12.Location = new System.Drawing.Point(656, 391);
            this.bCustom12.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom12.Name = "bCustom12";
            this.bCustom12.Size = new System.Drawing.Size(123, 39);
            this.bCustom12.TabIndex = 31;
            this.bCustom12.Text = "(set)";
            this.bCustom12.UseVisualStyleBackColor = true;
            this.bCustom12.Visible = false;
            this.bCustom12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom13
            // 
            this.bCustom13.Location = new System.Drawing.Point(656, 443);
            this.bCustom13.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom13.Name = "bCustom13";
            this.bCustom13.Size = new System.Drawing.Size(123, 39);
            this.bCustom13.TabIndex = 32;
            this.bCustom13.Text = "(set)";
            this.bCustom13.UseVisualStyleBackColor = true;
            this.bCustom13.Visible = false;
            this.bCustom13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // bCustom14
            // 
            this.bCustom14.Location = new System.Drawing.Point(656, 496);
            this.bCustom14.Margin = new System.Windows.Forms.Padding(2);
            this.bCustom14.Name = "bCustom14";
            this.bCustom14.Size = new System.Drawing.Size(123, 39);
            this.bCustom14.TabIndex = 33;
            this.bCustom14.Text = "(set)";
            this.bCustom14.UseVisualStyleBackColor = true;
            this.bCustom14.Visible = false;
            this.bCustom14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.custom_Click);
            // 
            // PercussionSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(811, 561);
            this.Controls.Add(this.bCustom14);
            this.Controls.Add(this.bCustom13);
            this.Controls.Add(this.bCustom12);
            this.Controls.Add(this.bCustom11);
            this.Controls.Add(this.bCustom10);
            this.Controls.Add(this.gbFileAction);
            this.Controls.Add(this.bCustom0);
            this.Controls.Add(this.bCustom1);
            this.Controls.Add(this.bCustom2);
            this.Controls.Add(this.bCustom3);
            this.Controls.Add(this.bCustom4);
            this.Controls.Add(this.bCustom5);
            this.Controls.Add(this.bCustom6);
            this.Controls.Add(this.bCustom7);
            this.Controls.Add(this.bCustom8);
            this.Controls.Add(this.bCustom9);
            this.Controls.Add(this.bSkip);
            this.Controls.Add(this.bClap);
            this.Controls.Add(this.bGarbage);
            this.Controls.Add(this.bOther);
            this.Controls.Add(this.bFx);
            this.Controls.Add(this.bLittleKick);
            this.Controls.Add(this.bBigSnare);
            this.Controls.Add(this.bPercussion);
            this.Controls.Add(this.bChina);
            this.Controls.Add(this.bLittleCymbal);
            this.Controls.Add(this.bBigCymbal);
            this.Controls.Add(this.bOpenHat);
            this.Controls.Add(this.bCHat);
            this.Controls.Add(this.bLittleSnare);
            this.Controls.Add(this.bPlaySample);
            this.Controls.Add(this.bBigKick);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.selectDirectory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PercussionSorter";
            this.Text = "Percussion Sorter";
            this.gbFileAction.ResumeLayout(false);
            this.gbFileAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button selectDirectory;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button bBigKick;
		private System.Windows.Forms.Button bPlaySample;
		private System.Windows.Forms.Button bLittleSnare;
		private System.Windows.Forms.Button bCHat;
		private System.Windows.Forms.Button bOpenHat;
		private System.Windows.Forms.Button bBigCymbal;
		private System.Windows.Forms.Button bLittleCymbal;
		private System.Windows.Forms.Button bChina;
		private System.Windows.Forms.Button bPercussion;
		private System.Windows.Forms.Button bBigSnare;
		private System.Windows.Forms.Button bLittleKick;
		private System.Windows.Forms.Button bFx;
		private System.Windows.Forms.Button bOther;
		private System.Windows.Forms.Button bGarbage;
		private System.Windows.Forms.Button bClap;
        private System.Windows.Forms.Button bSkip;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbLink;
        private System.Windows.Forms.Button bCustom0;
        private System.Windows.Forms.Button bCustom1;
        private System.Windows.Forms.Button bCustom2;
        private System.Windows.Forms.Button bCustom3;
        private System.Windows.Forms.Button bCustom4;
        private System.Windows.Forms.Button bCustom5;
        private System.Windows.Forms.Button bCustom6;
        private System.Windows.Forms.Button bCustom7;
        private System.Windows.Forms.Button bCustom8;
        private System.Windows.Forms.Button bCustom9;
        private System.Windows.Forms.GroupBox gbFileAction;
        private System.Windows.Forms.Button bCustom10;
        private System.Windows.Forms.Button bCustom11;
        private System.Windows.Forms.Button bCustom12;
        private System.Windows.Forms.Button bCustom13;
        private System.Windows.Forms.Button bCustom14;
    }
}

