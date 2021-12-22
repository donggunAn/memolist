
namespace 과제_프로젝트
{
    partial class Memo
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
            this.memopush = new System.Windows.Forms.Button();
            this.boxContent = new System.Windows.Forms.TextBox();
            this.boxtitle = new System.Windows.Forms.TextBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.memoContent = new System.Windows.Forms.Label();
            this.listview = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelList = new System.Windows.Forms.Label();
            this.Listbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memopush
            // 
            this.memopush.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.memopush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.memopush.Location = new System.Drawing.Point(440, 9);
            this.memopush.Name = "memopush";
            this.memopush.Size = new System.Drawing.Size(114, 34);
            this.memopush.TabIndex = 1;
            this.memopush.Text = "송신";
            this.memopush.UseVisualStyleBackColor = false;
            this.memopush.Click += new System.EventHandler(this.memopush_Click);
            // 
            // boxContent
            // 
            this.boxContent.Location = new System.Drawing.Point(12, 68);
            this.boxContent.Multiline = true;
            this.boxContent.Name = "boxContent";
            this.boxContent.Size = new System.Drawing.Size(540, 105);
            this.boxContent.TabIndex = 3;
            // 
            // boxtitle
            // 
            this.boxtitle.Location = new System.Drawing.Point(81, 9);
            this.boxtitle.Multiline = true;
            this.boxtitle.Name = "boxtitle";
            this.boxtitle.Size = new System.Drawing.Size(353, 34);
            this.boxtitle.TabIndex = 5;
            this.boxtitle.TextChanged += new System.EventHandler(this.Boxtitle_TextChanged);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltitle.Location = new System.Drawing.Point(10, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(69, 33);
            this.labeltitle.TabIndex = 7;
            this.labeltitle.Text = "title";
            this.labeltitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // memoContent
            // 
            this.memoContent.AutoSize = true;
            this.memoContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoContent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoContent.Location = new System.Drawing.Point(8, 46);
            this.memoContent.Name = "memoContent";
            this.memoContent.Size = new System.Drawing.Size(74, 19);
            this.memoContent.TabIndex = 9;
            this.memoContent.Text = "Content";
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Content});
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(12, 231);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(284, 467);
            this.listview.TabIndex = 10;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            this.listview.SelectedIndexChanged += new System.EventHandler(this.listview_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 80;
            // 
            // Content
            // 
            this.Content.Text = "Content";
            this.Content.Width = 200;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelList.Location = new System.Drawing.Point(10, 195);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(63, 33);
            this.labelList.TabIndex = 11;
            this.labelList.Text = "List";
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(214, 195);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(82, 33);
            this.Listbutton.TabIndex = 12;
            this.Listbutton.Text = "송신";
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.Listbutton_Click);
            // 
            // Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 713);
            this.Controls.Add(this.Listbutton);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.memoContent);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.boxtitle);
            this.Controls.Add(this.boxContent);
            this.Controls.Add(this.memopush);
            this.Name = "Memo";
            this.Text = "메모글";
            this.Load += new System.EventHandler(this.Memo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memopush;
        private System.Windows.Forms.TextBox boxContent;
        private System.Windows.Forms.TextBox boxtitle;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label memoContent;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button Listbutton;
    }
}

