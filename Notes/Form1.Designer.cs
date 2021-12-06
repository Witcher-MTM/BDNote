
namespace Notes
{
    partial class Form1
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
            this.titleTB = new System.Windows.Forms.TextBox();
            this.bodyTB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.noteList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTB
            // 
            this.titleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.titleTB.Location = new System.Drawing.Point(12, 12);
            this.titleTB.Multiline = true;
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(353, 44);
            this.titleTB.TabIndex = 0;
            this.titleTB.Text = "Title";
            this.titleTB.Visible = false;
            this.titleTB.Click += new System.EventHandler(this.titleTB_Click);
            // 
            // bodyTB
            // 
            this.bodyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bodyTB.Location = new System.Drawing.Point(12, 62);
            this.bodyTB.Multiline = true;
            this.bodyTB.Name = "bodyTB";
            this.bodyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bodyTB.Size = new System.Drawing.Size(353, 348);
            this.bodyTB.TabIndex = 0;
            this.bodyTB.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 416);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // noteList
            // 
            this.noteList.FormattingEnabled = true;
            this.noteList.Location = new System.Drawing.Point(12, 12);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(353, 394);
            this.noteList.TabIndex = 2;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.noteList_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(145, 416);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "add new";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(290, 416);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.noteList);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bodyTB);
            this.Controls.Add(this.titleTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox bodyTB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox noteList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
    }
}

