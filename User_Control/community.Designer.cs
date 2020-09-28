namespace Serial_Communication.User_Control
{
    partial class community
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.추천수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최신순ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaContextMenuStrip2 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.제목ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.카테고리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.gunaContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추천수ToolStripMenuItem,
            this.조회수ToolStripMenuItem,
            this.최신순ToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(111, 70);
            // gunaContextMenuStrip2
            // 
            this.gunaContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제목ToolStripMenuItem,
            this.내용ToolStripMenuItem,
            this.카테고리ToolStripMenuItem});
            this.gunaContextMenuStrip2.Name = "gunaContextMenuStrip2";
            this.gunaContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip2.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip2.Size = new System.Drawing.Size(123, 70);
            // community
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "community";
            this.Size = new System.Drawing.Size(368, 658);
            this.Load += new System.EventHandler(this.community_Load);
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.gunaContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추천수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조회수ToolStripMenuItem;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 제목ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 카테고리ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 최신순ToolStripMenuItem;
    }
}
