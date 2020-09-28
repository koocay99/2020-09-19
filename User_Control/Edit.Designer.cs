namespace Serial_Communication.User_Control
{
    partial class Edit
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.keydownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keydownToolStripMenuItem,
            this.RunToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.ColorTable = null;
            this.contextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.contextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // keydownToolStripMenuItem
            // 
            this.keydownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArrowToolStripMenuItem,
            this.VolumeToolStripMenuItem,
            this.FuncToolStripMenuItem,
            this.SubkeyToolStripMenuItem});
            this.keydownToolStripMenuItem.Name = "keydownToolStripMenuItem";
            this.keydownToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.keydownToolStripMenuItem.Text = "키 입력";
            // 
            // ArrowToolStripMenuItem
            // 
            this.ArrowToolStripMenuItem.Name = "ArrowToolStripMenuItem";
            this.ArrowToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ArrowToolStripMenuItem.Text = "방향키";
            // 
            // VolumeToolStripMenuItem
            // 
            this.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem";
            this.VolumeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.VolumeToolStripMenuItem.Text = "불륨";
            // 
            // FuncToolStripMenuItem
            // 
            this.FuncToolStripMenuItem.Name = "FuncToolStripMenuItem";
            this.FuncToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.FuncToolStripMenuItem.Text = "펑션";
            // 
            // SubkeyToolStripMenuItem
            // 
            this.SubkeyToolStripMenuItem.Name = "SubkeyToolStripMenuItem";
            this.SubkeyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SubkeyToolStripMenuItem.Text = "기능";
            // 
            // RunToolStripMenuItem
            // 
            this.RunToolStripMenuItem.Name = "RunToolStripMenuItem";
            this.RunToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.RunToolStripMenuItem.Text = "프로그램 실행";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(358, 658);
            this.Load += new System.EventHandler(this.Edit_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI.WinForms.GunaContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keydownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FuncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubkeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunToolStripMenuItem;
    }
}
