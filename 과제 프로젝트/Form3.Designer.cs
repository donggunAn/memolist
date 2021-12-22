
namespace 과제_프로젝트
{
    partial class 리스트뷰
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listview = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelList = new System.Windows.Forms.Label();
            this.Listbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Content});
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(12, 75);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(284, 515);
            this.listview.TabIndex = 0;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
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
            this.labelList.Location = new System.Drawing.Point(12, 9);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(63, 33);
            this.labelList.TabIndex = 8;
            this.labelList.Text = "List";
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(214, 9);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(82, 33);
            this.Listbutton.TabIndex = 9;
            this.Listbutton.Text = "송신";
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.Listbutton_Click);
            // 
            // 리스트뷰
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 602);
            this.Controls.Add(this.Listbutton);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listview);
            this.Name = "리스트뷰";
            this.Text = "리스트뷰";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button Listbutton;
    }
}