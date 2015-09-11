namespace graph_protting
{
  partial class Display
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

    #region コンポーネント デザイナーで生成されたコード

    /// <summary> 
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Lime;
      this.label1.Location = new System.Drawing.Point(14, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "1.00 V/Div";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Lime;
      this.label2.Location = new System.Drawing.Point(15, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(128, 32);
      this.label2.TabIndex = 1;
      this.label2.Text = "0.1 ms/Div";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.DecimalPlaces = 2;
      this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numericUpDown1.Location = new System.Drawing.Point(20, 79);
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
      this.numericUpDown1.TabIndex = 2;
      this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.VoltageValueChanged);
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.DecimalPlaces = 2;
      this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numericUpDown2.Location = new System.Drawing.Point(19, 104);
      this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(120, 19);
      this.numericUpDown2.TabIndex = 3;
      this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numericUpDown2.ValueChanged += new System.EventHandler(this.TimeValueChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(860, 438);
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPaint);
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.DecimalPlaces = 2;
      this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numericUpDown3.Location = new System.Drawing.Point(19, 129);
      this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(120, 19);
      this.numericUpDown3.TabIndex = 5;
      this.numericUpDown3.ValueChanged += new System.EventHandler(this.triggerLevelChanged);
      this.numericUpDown3.SizeChanged += new System.EventHandler(this.triggerLevelChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Lime;
      this.label3.Location = new System.Drawing.Point(15, 151);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 32);
      this.label3.TabIndex = 6;
      this.label3.Text = "0.00 V";
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(761, 0);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(99, 16);
      this.radioButton1.TabIndex = 7;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "立ち上がりEdge";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(761, 22);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(99, 16);
      this.radioButton2.TabIndex = 8;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "立ち下がりEdge";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.triggerModeChanged);
      // 
      // serialPort1
      // 
      this.serialPort1.PortName = "COM4";
      this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceived);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(506, 177);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(351, 261);
      this.textBox1.TabIndex = 9;
      // 
      // Display
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.HotTrack;
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Display";
      this.Size = new System.Drawing.Size(860, 438);
      this.Load += new System.EventHandler(this.DisplayLoad);
      this.SizeChanged += new System.EventHandler(this.DisplaySizeChanged);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.TextBox textBox1;
  }
}
