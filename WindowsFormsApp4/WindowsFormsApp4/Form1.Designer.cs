namespace WindowsFormsApp4
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
            this.buttonControl = new System.Windows.Forms.Button();
            this.checkBoxControl = new System.Windows.Forms.CheckBox();
            this.labelControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonControl
            // 
            this.buttonControl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonControl.Location = new System.Drawing.Point(135, 157);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(108, 50);
            this.buttonControl.TabIndex = 0;
            this.buttonControl.Text = "確認";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // checkBoxControl
            // 
            this.checkBoxControl.AutoSize = true;
            this.checkBoxControl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxControl.Location = new System.Drawing.Point(317, 169);
            this.checkBoxControl.Name = "checkBoxControl";
            this.checkBoxControl.Size = new System.Drawing.Size(28, 27);
            this.checkBoxControl.TabIndex = 1;
            this.checkBoxControl.UseVisualStyleBackColor = true;
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl.Location = new System.Drawing.Point(352, 308);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(0, 33);
            this.labelControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.checkBoxControl);
            this.Controls.Add(this.buttonControl);
            this.Name = "Form1";
            this.Text = "if文学習";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonControl;
        private System.Windows.Forms.CheckBox checkBoxControl;
        private System.Windows.Forms.Label labelControl;
    }
}

