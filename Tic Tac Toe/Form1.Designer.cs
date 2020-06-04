namespace Tic_Tac_Toe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnHost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJoin);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblTurn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(240, 28);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 36);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(6, 38);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(80, 17);
            this.lblTurn.TabIndex = 0;
            this.lblTurn.Text = "IP Address:";
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(12, 98);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(335, 38);
            this.btnHost.TabIndex = 4;
            this.btnHost.Text = "Become Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 158);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnHost;
    }
}

