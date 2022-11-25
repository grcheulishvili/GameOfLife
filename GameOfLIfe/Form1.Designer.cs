namespace GameOfLife
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SizeNud1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RunCheckbox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GridCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DelayNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DensityNud = new System.Windows.Forms.NumericUpDown();
            this.GliderButton = new System.Windows.Forms.Button();
            this.RowButton = new System.Windows.Forms.Button();
            this.SpaceshipButton = new System.Windows.Forms.Button();
            this.GunButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            // 
            // SizeNud1
            // 
            resources.ApplyResources(this.SizeNud1, "SizeNud1");
            this.SizeNud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeNud1.Name = "SizeNud1";
            this.SizeNud1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNud1.ValueChanged += new System.EventHandler(this.SizeNud_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResetButton
            // 
            resources.ApplyResources(this.ResetButton, "ResetButton");
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RunCheckbox
            // 
            resources.ApplyResources(this.RunCheckbox, "RunCheckbox");
            this.RunCheckbox.Checked = true;
            this.RunCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunCheckbox.Name = "RunCheckbox";
            this.RunCheckbox.UseVisualStyleBackColor = true;
            this.RunCheckbox.CheckedChanged += new System.EventHandler(this.RunCheckbox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GridCheckbox
            // 
            resources.ApplyResources(this.GridCheckbox, "GridCheckbox");
            this.GridCheckbox.Checked = true;
            this.GridCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridCheckbox.Name = "GridCheckbox";
            this.GridCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // DelayNud
            // 
            resources.ApplyResources(this.DelayNud, "DelayNud");
            this.DelayNud.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DelayNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DelayNud.Name = "DelayNud";
            this.DelayNud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNud.ValueChanged += new System.EventHandler(this.DelayNud_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DensityNud
            // 
            resources.ApplyResources(this.DensityNud, "DensityNud");
            this.DensityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DensityNud.Name = "DensityNud";
            this.DensityNud.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.DensityNud.ValueChanged += new System.EventHandler(this.DensityNud_ValueChanged);
            // 
            // GliderButton
            // 
            resources.ApplyResources(this.GliderButton, "GliderButton");
            this.GliderButton.Name = "GliderButton";
            this.GliderButton.UseVisualStyleBackColor = true;
            this.GliderButton.Click += new System.EventHandler(this.GliderButton_Click);
            // 
            // RowButton
            // 
            resources.ApplyResources(this.RowButton, "RowButton");
            this.RowButton.Name = "RowButton";
            this.RowButton.UseVisualStyleBackColor = true;
            this.RowButton.Click += new System.EventHandler(this.RowButton_Click);
            // 
            // SpaceshipButton
            // 
            resources.ApplyResources(this.SpaceshipButton, "SpaceshipButton");
            this.SpaceshipButton.Name = "SpaceshipButton";
            this.SpaceshipButton.UseVisualStyleBackColor = true;
            this.SpaceshipButton.Click += new System.EventHandler(this.SpaceshipButton_Click);
            // 
            // GunButton
            // 
            resources.ApplyResources(this.GunButton, "GunButton");
            this.GunButton.Name = "GunButton";
            this.GunButton.UseVisualStyleBackColor = true;
            this.GunButton.Click += new System.EventHandler(this.GunButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.GunButton);
            this.Controls.Add(this.SpaceshipButton);
            this.Controls.Add(this.RowButton);
            this.Controls.Add(this.GliderButton);
            this.Controls.Add(this.DensityNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelayNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridCheckbox);
            this.Controls.Add(this.RunCheckbox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeNud1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown SizeNud1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox RunCheckbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox GridCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DelayNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DensityNud;
        private System.Windows.Forms.Button GliderButton;
        private System.Windows.Forms.Button RowButton;
        private System.Windows.Forms.Button SpaceshipButton;
        private System.Windows.Forms.Button GunButton;
    }
}
