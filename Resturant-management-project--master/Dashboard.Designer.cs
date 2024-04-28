namespace E_Project
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboardtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pizzabtn = new System.Windows.Forms.Button();
            this.Burgerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 525);
            this.panel1.TabIndex = 0;
            // 
            // dashboardtxt
            // 
            this.dashboardtxt.AutoSize = true;
            this.dashboardtxt.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardtxt.Location = new System.Drawing.Point(84, 9);
            this.dashboardtxt.Name = "dashboardtxt";
            this.dashboardtxt.Size = new System.Drawing.Size(168, 32);
            this.dashboardtxt.TabIndex = 1;
            this.dashboardtxt.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "_____________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "FastFood &  Plater";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 158);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pizzabtn
            // 
            this.pizzabtn.BackgroundImage = global::E_Project.Properties.Resources.pizza2;
            this.pizzabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzabtn.Location = new System.Drawing.Point(381, 129);
            this.pizzabtn.Name = "pizzabtn";
            this.pizzabtn.Size = new System.Drawing.Size(271, 158);
            this.pizzabtn.TabIndex = 5;
            this.pizzabtn.UseVisualStyleBackColor = true;
            // 
            // Burgerbtn
            // 
            this.Burgerbtn.BackgroundImage = global::E_Project.Properties.Resources.Burger;
            this.Burgerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Burgerbtn.Location = new System.Drawing.Point(80, 129);
            this.Burgerbtn.Name = "Burgerbtn";
            this.Burgerbtn.Size = new System.Drawing.Size(271, 158);
            this.Burgerbtn.TabIndex = 4;
            this.Burgerbtn.UseVisualStyleBackColor = true;
            this.Burgerbtn.Click += new System.EventHandler(this.Burgerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Burgar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pizza";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 664);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pizzabtn);
            this.Controls.Add(this.Burgerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardtxt);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dashboardtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Burgerbtn;
        private System.Windows.Forms.Button pizzabtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}