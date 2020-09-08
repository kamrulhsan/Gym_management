namespace GymManegmentApp
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionsButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 255);
            this.dataGridView1.TabIndex = 3;
            // 
            // questionsButton
            // 
            this.questionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.questionsButton.Image = global::GymManegmentApp.Properties.Resources.if_question_mark_811462;
            this.questionsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.questionsButton.Location = new System.Drawing.Point(397, 36);
            this.questionsButton.Name = "questionsButton";
            this.questionsButton.Size = new System.Drawing.Size(111, 59);
            this.questionsButton.TabIndex = 2;
            this.questionsButton.Text = "Questions ";
            this.questionsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.questionsButton.UseVisualStyleBackColor = true;
            this.questionsButton.Click += new System.EventHandler(this.questionsButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.viewButton.Image = global::GymManegmentApp.Properties.Resources.if_20_Photos_290130;
            this.viewButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.viewButton.Location = new System.Drawing.Point(254, 36);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(114, 59);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View";
            this.viewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.questionsButton);
            this.Controls.Add(this.viewButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button questionsButton;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}