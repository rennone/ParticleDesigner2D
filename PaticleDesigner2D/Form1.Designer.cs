namespace ParticleDesigner2D
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CanvasPanel_ = new System.Windows.Forms.Panel();
            this.ParameterPanel_ = new System.Windows.Forms.Panel();
            this.UpdateTimer_ = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CanvasPanel_
            // 
            this.CanvasPanel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel_.Location = new System.Drawing.Point(6, 6);
            this.CanvasPanel_.Name = "CanvasPanel_";
            this.CanvasPanel_.Size = new System.Drawing.Size(882, 600);
            this.CanvasPanel_.TabIndex = 0;
            // 
            // ParameterPanel_
            // 
            this.ParameterPanel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParameterPanel_.Location = new System.Drawing.Point(894, 6);
            this.ParameterPanel_.Name = "ParameterPanel_";
            this.ParameterPanel_.Size = new System.Drawing.Size(164, 600);
            this.ParameterPanel_.TabIndex = 1;
            // 
            // UpdateTimer_
            // 
            this.UpdateTimer_.Enabled = true;
            this.UpdateTimer_.Interval = 33;
            this.UpdateTimer_.Tick += new System.EventHandler(this.UpdateTimer__Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 611);
            this.Controls.Add(this.ParameterPanel_);
            this.Controls.Add(this.CanvasPanel_);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel_;
        private System.Windows.Forms.Panel ParameterPanel_;
        private System.Windows.Forms.Timer UpdateTimer_;
    }
}

