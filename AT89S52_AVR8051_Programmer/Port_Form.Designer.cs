
namespace AT89S52_AVR8051_Programmer
{
    partial class Port_Form
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
            this.components = new System.ComponentModel.Container();
            this.arrow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flash = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Back_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // arrow
            // 
            this.arrow.AutoSize = true;
            this.arrow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow.Location = new System.Drawing.Point(383, 335);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(53, 61);
            this.arrow.TabIndex = 35;
            this.arrow.Text = "⮮";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Upload Dedicated hex file in Arduino to make ISP Programmer";
            // 
            // flash
            // 
            this.flash.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash.Location = new System.Drawing.Point(341, 401);
            this.flash.Name = "flash";
            this.flash.Size = new System.Drawing.Size(131, 38);
            this.flash.TabIndex = 32;
            this.flash.Text = "Flash";
            this.flash.UseVisualStyleBackColor = false;
            this.flash.Click += new System.EventHandler(this.flash_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(11, 401);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 38);
            this.Back_btn.TabIndex = 49;
            this.Back_btn.Text = "<<Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Available Ports";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 24);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Port_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Port_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port_Form";
            this.Load += new System.EventHandler(this.Port_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label arrow;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button flash;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}