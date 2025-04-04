namespace UnitTest_48_Bao
{
    partial class StudentList_48_Bao
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
            this.dgv_48_Bao = new System.Windows.Forms.DataGridView();
            this.btnAdd_48_Bao = new System.Windows.Forms.Button();
            this.btnFilter_48_Bao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_48_Bao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_48_Bao
            // 
            this.dgv_48_Bao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_48_Bao.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_48_Bao.Location = new System.Drawing.Point(0, 0);
            this.dgv_48_Bao.Name = "dgv_48_Bao";
            this.dgv_48_Bao.RowHeadersWidth = 51;
            this.dgv_48_Bao.RowTemplate.Height = 24;
            this.dgv_48_Bao.Size = new System.Drawing.Size(836, 334);
            this.dgv_48_Bao.TabIndex = 0;
            // 
            // btnAdd_48_Bao
            // 
            this.btnAdd_48_Bao.Location = new System.Drawing.Point(117, 374);
            this.btnAdd_48_Bao.Name = "btnAdd_48_Bao";
            this.btnAdd_48_Bao.Size = new System.Drawing.Size(90, 42);
            this.btnAdd_48_Bao.TabIndex = 1;
            this.btnAdd_48_Bao.Text = "Thêm";
            this.btnAdd_48_Bao.UseVisualStyleBackColor = true;
            this.btnAdd_48_Bao.Click += new System.EventHandler(this.btnAdd_48_Bao_Click);
            // 
            // btnFilter_48_Bao
            // 
            this.btnFilter_48_Bao.Location = new System.Drawing.Point(509, 374);
            this.btnFilter_48_Bao.Name = "btnFilter_48_Bao";
            this.btnFilter_48_Bao.Size = new System.Drawing.Size(132, 42);
            this.btnFilter_48_Bao.TabIndex = 1;
            this.btnFilter_48_Bao.Text = "Xét học bổng";
            this.btnFilter_48_Bao.UseVisualStyleBackColor = true;
            this.btnFilter_48_Bao.Click += new System.EventHandler(this.btnFilter_48_Bao_Click);
            // 
            // StudentList_48_Bao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 443);
            this.Controls.Add(this.btnFilter_48_Bao);
            this.Controls.Add(this.btnAdd_48_Bao);
            this.Controls.Add(this.dgv_48_Bao);
            this.Name = "StudentList_48_Bao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_48_Bao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_48_Bao;
        private System.Windows.Forms.Button btnAdd_48_Bao;
        private System.Windows.Forms.Button btnFilter_48_Bao;
    }
}