namespace Foosh
{
    partial class Foosh
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCastKey = new System.Windows.Forms.ComboBox();
            this.cmbHookKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delayMin = new System.Windows.Forms.NumericUpDown();
            this.delayMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.isFishing = new System.Windows.Forms.CheckBox();
            this.catchSmall = new System.Windows.Forms.CheckBox();
            this.catchMedium = new System.Windows.Forms.CheckBox();
            this.catchLarge = new System.Windows.Forms.CheckBox();
            this.isRelease = new System.Windows.Forms.CheckBox();
            this.cmbReleaseKey = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isChum = new System.Windows.Forms.CheckBox();
            this.cmbChumKey = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delayMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cast Key";
            // 
            // cmbCastKey
            // 
            this.cmbCastKey.FormattingEnabled = true;
            this.cmbCastKey.Location = new System.Drawing.Point(72, 0);
            this.cmbCastKey.Name = "cmbCastKey";
            this.cmbCastKey.Size = new System.Drawing.Size(160, 21);
            this.cmbCastKey.TabIndex = 1;
            this.cmbCastKey.SelectedIndexChanged += new System.EventHandler(this.cmbCastKey_SelectedIndexChanged);
            // 
            // cmbHookKey
            // 
            this.cmbHookKey.FormattingEnabled = true;
            this.cmbHookKey.Location = new System.Drawing.Point(72, 24);
            this.cmbHookKey.Name = "cmbHookKey";
            this.cmbHookKey.Size = new System.Drawing.Size(160, 21);
            this.cmbHookKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hook Key";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(16, 169);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(56, 169);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(176, 20);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "UNKNOWN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delay Min";
            // 
            // delayMin
            // 
            this.delayMin.Location = new System.Drawing.Point(56, 97);
            this.delayMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayMin.Name = "delayMin";
            this.delayMin.Size = new System.Drawing.Size(56, 20);
            this.delayMin.TabIndex = 7;
            this.delayMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // delayMax
            // 
            this.delayMax.Location = new System.Drawing.Point(176, 97);
            this.delayMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayMax.Name = "delayMax";
            this.delayMax.Size = new System.Drawing.Size(56, 20);
            this.delayMax.TabIndex = 9;
            this.delayMax.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay Max";
            // 
            // isFishing
            // 
            this.isFishing.AutoSize = true;
            this.isFishing.Location = new System.Drawing.Point(8, 121);
            this.isFishing.Name = "isFishing";
            this.isFishing.Size = new System.Drawing.Size(78, 17);
            this.isFishing.TabIndex = 10;
            this.isFishing.Text = "Autofishing";
            this.isFishing.UseVisualStyleBackColor = true;
            this.isFishing.CheckedChanged += new System.EventHandler(this.isFishing_CheckedChanged);
            // 
            // catchSmall
            // 
            this.catchSmall.AutoSize = true;
            this.catchSmall.Location = new System.Drawing.Point(8, 145);
            this.catchSmall.Name = "catchSmall";
            this.catchSmall.Size = new System.Drawing.Size(51, 17);
            this.catchSmall.TabIndex = 11;
            this.catchSmall.Text = "Small";
            this.catchSmall.UseVisualStyleBackColor = true;
            this.catchSmall.CheckedChanged += new System.EventHandler(this.catchSmall_CheckedChanged);
            // 
            // catchMedium
            // 
            this.catchMedium.AutoSize = true;
            this.catchMedium.Location = new System.Drawing.Point(88, 145);
            this.catchMedium.Name = "catchMedium";
            this.catchMedium.Size = new System.Drawing.Size(63, 17);
            this.catchMedium.TabIndex = 12;
            this.catchMedium.Text = "Medium";
            this.catchMedium.UseVisualStyleBackColor = true;
            this.catchMedium.CheckedChanged += new System.EventHandler(this.catchMedium_CheckedChanged);
            // 
            // catchLarge
            // 
            this.catchLarge.AutoSize = true;
            this.catchLarge.Location = new System.Drawing.Point(168, 145);
            this.catchLarge.Name = "catchLarge";
            this.catchLarge.Size = new System.Drawing.Size(53, 17);
            this.catchLarge.TabIndex = 13;
            this.catchLarge.Text = "Large";
            this.catchLarge.UseVisualStyleBackColor = true;
            this.catchLarge.CheckedChanged += new System.EventHandler(this.catchLarge_CheckedChanged);
            // 
            // isRelease
            // 
            this.isRelease.AutoSize = true;
            this.isRelease.Location = new System.Drawing.Point(168, 121);
            this.isRelease.Name = "isRelease";
            this.isRelease.Size = new System.Drawing.Size(65, 17);
            this.isRelease.TabIndex = 14;
            this.isRelease.Text = "Release";
            this.isRelease.UseVisualStyleBackColor = true;
            this.isRelease.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbReleaseKey
            // 
            this.cmbReleaseKey.FormattingEnabled = true;
            this.cmbReleaseKey.Location = new System.Drawing.Point(72, 48);
            this.cmbReleaseKey.Name = "cmbReleaseKey";
            this.cmbReleaseKey.Size = new System.Drawing.Size(160, 21);
            this.cmbReleaseKey.TabIndex = 16;
            this.cmbReleaseKey.SelectedIndexChanged += new System.EventHandler(this.cmbReleaseKey_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Release Key";
            // 
            // isChum
            // 
            this.isChum.AutoSize = true;
            this.isChum.Location = new System.Drawing.Point(88, 121);
            this.isChum.Name = "isChum";
            this.isChum.Size = new System.Drawing.Size(53, 17);
            this.isChum.TabIndex = 17;
            this.isChum.Text = "Chum";
            this.isChum.UseVisualStyleBackColor = true;
            this.isChum.CheckedChanged += new System.EventHandler(this.isChum_CheckedChanged);
            // 
            // cmbChumKey
            // 
            this.cmbChumKey.FormattingEnabled = true;
            this.cmbChumKey.Location = new System.Drawing.Point(72, 72);
            this.cmbChumKey.Name = "cmbChumKey";
            this.cmbChumKey.Size = new System.Drawing.Size(160, 21);
            this.cmbChumKey.TabIndex = 19;
            this.cmbChumKey.SelectedIndexChanged += new System.EventHandler(this.cmbChumKey_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Chum Key";
            // 
            // Foosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 193);
            this.Controls.Add(this.cmbChumKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isChum);
            this.Controls.Add(this.cmbReleaseKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isRelease);
            this.Controls.Add(this.catchLarge);
            this.Controls.Add(this.catchMedium);
            this.Controls.Add(this.catchSmall);
            this.Controls.Add(this.isFishing);
            this.Controls.Add(this.delayMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delayMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.cmbHookKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCastKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Foosh";
            this.Text = "Foosh";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Foosh_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Foosh_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.delayMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCastKey;
        private System.Windows.Forms.ComboBox cmbHookKey;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown delayMin;
        private System.Windows.Forms.NumericUpDown delayMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isFishing;
        private System.Windows.Forms.CheckBox catchSmall;
        private System.Windows.Forms.CheckBox catchMedium;
        private System.Windows.Forms.CheckBox catchLarge;
        private System.Windows.Forms.CheckBox isRelease;
        private System.Windows.Forms.ComboBox cmbReleaseKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isChum;
        private System.Windows.Forms.ComboBox cmbChumKey;
        private System.Windows.Forms.Label label6;
    }
}

