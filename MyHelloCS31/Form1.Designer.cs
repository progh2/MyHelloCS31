namespace MyHelloCS31
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreeting
            // 
            this.btnGreeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreeting.Font = new System.Drawing.Font("궁서체", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGreeting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGreeting.Location = new System.Drawing.Point(28, 12);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(191, 89);
            this.btnGreeting.TabIndex = 0;
            this.btnGreeting.Text = "환영 인사하기";
            this.btnGreeting.UseVisualStyleBackColor = true;
            this.btnGreeting.Click += new System.EventHandler(this.btnGreeting_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 113);
            this.Controls.Add(this.btnGreeting);
            this.Name = "FormMain";
            this.Text = "마이헬로우";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreeting;
    }
}

