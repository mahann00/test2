namespace calculator00
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblnumber1 = new System.Windows.Forms.Label();
            this.lbhnumber2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtnumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumber1
            // 
            resources.ApplyResources(this.lblnumber1, "lblnumber1");
            this.lblnumber1.Name = "lblnumber1";
            this.lblnumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbhnumber2
            // 
            resources.ApplyResources(this.lbhnumber2, "lbhnumber2");
            this.lbhnumber2.Name = "lbhnumber2";
            this.lbhnumber2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnumber1
            // 
            resources.ApplyResources(this.txtnumber1, "txtnumber1");
            this.txtnumber1.Name = "txtnumber1";
            // 
            // txtnumber2
            // 
            resources.ApplyResources(this.txtnumber2, "txtnumber2");
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.ValueChanged += new System.EventHandler(this.txtnumber2_ValueChanged);
            // 
            // btnplus
            // 
            resources.ApplyResources(this.btnplus, "btnplus");
            this.btnplus.Name = "btnplus";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnmultiple
            // 
            resources.ApplyResources(this.btnmultiple, "btnmultiple");
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.UseVisualStyleBackColor = true;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // btnminus
            // 
            resources.ApplyResources(this.btnminus, "btnminus");
            this.btnminus.Name = "btnminus";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btndivide
            // 
            resources.ApplyResources(this.btndivide, "btndivide");
            this.btndivide.Name = "btndivide";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lbhnumber2);
            this.Controls.Add(this.lblnumber1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumber1;
        private System.Windows.Forms.Label lbhnumber2;
        private System.Windows.Forms.NumericUpDown txtnumber1;
        private System.Windows.Forms.NumericUpDown txtnumber2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btndivide;
    }
}

