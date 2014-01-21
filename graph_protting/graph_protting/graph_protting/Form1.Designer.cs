namespace graph_protting
{
    partial class OSC
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(860, 438);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picturebox1_paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
      this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label1.ForeColor = System.Drawing.Color.Lime;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "2 V/Div";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
      this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label2.ForeColor = System.Drawing.Color.Lime;
      this.label2.Location = new System.Drawing.Point(12, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 21);
      this.label2.TabIndex = 2;
      this.label2.Text = "1 ms/Div";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.DecimalPlaces = 2;
      this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numericUpDown1.Location = new System.Drawing.Point(12, 57);
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(79, 19);
      this.numericUpDown1.TabIndex = 3;
      this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.VoltageVallueChanged);
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(12, 82);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(79, 19);
      this.numericUpDown2.TabIndex = 4;
      // 
      // OSC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 462);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Name = "OSC";
      this.Text = "Hashimoto_OSC";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.SizeChanged += new System.EventHandler(this.form_sizechng);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

