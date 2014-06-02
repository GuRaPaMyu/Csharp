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
      this.display1 = new graph_protting.Display();
      this.SuspendLayout();
      // 
      // display1
      // 
      this.display1.BackColor = System.Drawing.SystemColors.HotTrack;
      this.display1.Location = new System.Drawing.Point(12, 12);
      this.display1.Name = "display1";
      this.display1.Size = new System.Drawing.Size(860, 438);
      this.display1.TabIndex = 5;
      // 
      // OSC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 462);
      this.Controls.Add(this.display1);
      this.Name = "OSC";
      this.Text = "Oscilloscope-Cs";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form1Closed);
      this.Load += new System.EventHandler(this.form1Load);
      this.SizeChanged += new System.EventHandler(this.form1SizeChanged);
      this.ResumeLayout(false);

        }

        #endregion

        private Display display1;
    }
}

