namespace ParalAlg
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
            this.StartTxt = new System.Windows.Forms.TextBox();
            this.FinishTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEdge = new System.Windows.Forms.Button();
            this.EdgesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteLastEdge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTxt
            // 
            this.StartTxt.Location = new System.Drawing.Point(13, 13);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.Size = new System.Drawing.Size(51, 20);
            this.StartTxt.TabIndex = 0;
            this.StartTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartTxt_KeyDown);
            // 
            // FinishTxt
            // 
            this.FinishTxt.Location = new System.Drawing.Point(108, 13);
            this.FinishTxt.Name = "FinishTxt";
            this.FinishTxt.Size = new System.Drawing.Size(52, 20);
            this.FinishTxt.TabIndex = 1;
            this.FinishTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FinishTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "->";
            // 
            // AddEdge
            // 
            this.AddEdge.Location = new System.Drawing.Point(185, 13);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(99, 22);
            this.AddEdge.TabIndex = 3;
            this.AddEdge.Text = "Добавить дугу";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.Click += new System.EventHandler(this.AddEdge_Click);
            // 
            // EdgesListView
            // 
            this.EdgesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.EdgesListView.Enabled = false;
            this.EdgesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.EdgesListView.Location = new System.Drawing.Point(290, 12);
            this.EdgesListView.Name = "EdgesListView";
            this.EdgesListView.Size = new System.Drawing.Size(145, 211);
            this.EdgesListView.TabIndex = 4;
            this.EdgesListView.UseCompatibleStateImageBehavior = false;
            this.EdgesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 47;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 47;
            // 
            // DeleteLastEdge
            // 
            this.DeleteLastEdge.Location = new System.Drawing.Point(290, 229);
            this.DeleteLastEdge.Name = "DeleteLastEdge";
            this.DeleteLastEdge.Size = new System.Drawing.Size(145, 22);
            this.DeleteLastEdge.TabIndex = 5;
            this.DeleteLastEdge.Text = "Удалить дугу";
            this.DeleteLastEdge.UseVisualStyleBackColor = true;
            this.DeleteLastEdge.Click += new System.EventHandler(this.DeleteLastEdge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteLastEdge);
            this.Controls.Add(this.EdgesListView);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishTxt);
            this.Controls.Add(this.StartTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartTxt;
        private System.Windows.Forms.TextBox FinishTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEdge;
        private System.Windows.Forms.ListView EdgesListView;
        private System.Windows.Forms.Button DeleteLastEdge;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

