
namespace v0513
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.mybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mybutton
            // 
            this.mybutton.BackColor = System.Drawing.Color.OrangeRed;
            this.mybutton.Font = new System.Drawing.Font("Stencil Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mybutton.ForeColor = System.Drawing.Color.Blue;
            this.mybutton.Location = new System.Drawing.Point(0, 0);
            this.mybutton.Name = "mybutton";
            this.mybutton.Size = new System.Drawing.Size(175, 73);
            this.mybutton.TabIndex = 0;
            this.mybutton.Text = "ボタン";
            this.mybutton.UseVisualStyleBackColor = false;
            this.mybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mybutton);
            this.Enabled = false;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mybutton;
    }
}

