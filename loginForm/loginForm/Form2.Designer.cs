namespace loginForm
{
    partial class Form2
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
            this.milBox = new System.Windows.Forms.TextBox();
            this.metrBox = new System.Windows.Forms.TextBox();
            this.footBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metrBtn = new System.Windows.Forms.RadioButton();
            this.milBtn = new System.Windows.Forms.RadioButton();
            this.footBtn = new System.Windows.Forms.RadioButton();
            this.convertBtn = new System.Windows.Forms.Button();
            this.numb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.numb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.miladbox = new System.Windows.Forms.TextBox();
            this.hicribox = new System.Windows.Forms.TextBox();
            this.miladbtn = new System.Windows.Forms.RadioButton();
            this.hicribtn = new System.Windows.Forms.RadioButton();
            this.convert2btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milBox
            // 
            this.milBox.Location = new System.Drawing.Point(12, 25);
            this.milBox.Name = "milBox";
            this.milBox.Size = new System.Drawing.Size(100, 20);
            this.milBox.TabIndex = 0;
            // 
            // metrBox
            // 
            this.metrBox.Location = new System.Drawing.Point(12, 68);
            this.metrBox.Name = "metrBox";
            this.metrBox.Size = new System.Drawing.Size(100, 20);
            this.metrBox.TabIndex = 1;
            // 
            // footBox
            // 
            this.footBox.Location = new System.Drawing.Point(12, 113);
            this.footBox.Name = "footBox";
            this.footBox.Size = new System.Drawing.Size(100, 20);
            this.footBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "mil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "metr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "foot";
            // 
            // metrBtn
            // 
            this.metrBtn.AutoSize = true;
            this.metrBtn.Location = new System.Drawing.Point(200, 48);
            this.metrBtn.Name = "metrBtn";
            this.metrBtn.Size = new System.Drawing.Size(45, 17);
            this.metrBtn.TabIndex = 6;
            this.metrBtn.TabStop = true;
            this.metrBtn.Text = "metr";
            this.metrBtn.UseVisualStyleBackColor = true;
            this.metrBtn.CheckedChanged += new System.EventHandler(this.metrBtn_CheckedChanged);
            // 
            // milBtn
            // 
            this.milBtn.AutoSize = true;
            this.milBtn.Location = new System.Drawing.Point(200, 26);
            this.milBtn.Name = "milBtn";
            this.milBtn.Size = new System.Drawing.Size(37, 17);
            this.milBtn.TabIndex = 7;
            this.milBtn.TabStop = true;
            this.milBtn.Text = "mil";
            this.milBtn.UseVisualStyleBackColor = true;
            this.milBtn.CheckedChanged += new System.EventHandler(this.milBtn_CheckedChanged);
            // 
            // footBtn
            // 
            this.footBtn.AutoSize = true;
            this.footBtn.Location = new System.Drawing.Point(200, 71);
            this.footBtn.Name = "footBtn";
            this.footBtn.Size = new System.Drawing.Size(43, 17);
            this.footBtn.TabIndex = 8;
            this.footBtn.TabStop = true;
            this.footBtn.Text = "foot";
            this.footBtn.UseVisualStyleBackColor = true;
            this.footBtn.CheckedChanged += new System.EventHandler(this.footBtn_CheckedChanged);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(200, 110);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(172, 23);
            this.convertBtn.TabIndex = 9;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // numb
            // 
            this.numb.Location = new System.Drawing.Point(12, 185);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(39, 20);
            this.numb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Find Palendrom Numbers";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(200, 226);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(172, 23);
            this.findBtn.TabIndex = 12;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // numb2
            // 
            this.numb2.Location = new System.Drawing.Point(137, 185);
            this.numb2.Name = "numb2";
            this.numb2.Size = new System.Drawing.Size(235, 20);
            this.numb2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Milad<->Hicri Teqvim Conventoru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Milad ili daxil et:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hicri ili daxil et:";
            // 
            // miladbox
            // 
            this.miladbox.Location = new System.Drawing.Point(12, 321);
            this.miladbox.Name = "miladbox";
            this.miladbox.Size = new System.Drawing.Size(100, 20);
            this.miladbox.TabIndex = 17;
            // 
            // hicribox
            // 
            this.hicribox.Location = new System.Drawing.Point(12, 374);
            this.hicribox.Name = "hicribox";
            this.hicribox.Size = new System.Drawing.Size(100, 20);
            this.hicribox.TabIndex = 18;
            // 
            // miladbtn
            // 
            this.miladbtn.AutoSize = true;
            this.miladbtn.Location = new System.Drawing.Point(241, 321);
            this.miladbtn.Name = "miladbtn";
            this.miladbtn.Size = new System.Drawing.Size(50, 17);
            this.miladbtn.TabIndex = 19;
            this.miladbtn.TabStop = true;
            this.miladbtn.Text = "Milad";
            this.miladbtn.UseVisualStyleBackColor = true;
            this.miladbtn.CheckedChanged += new System.EventHandler(this.miladbtn_CheckedChanged);
            // 
            // hicribtn
            // 
            this.hicribtn.AutoSize = true;
            this.hicribtn.Location = new System.Drawing.Point(241, 374);
            this.hicribtn.Name = "hicribtn";
            this.hicribtn.Size = new System.Drawing.Size(48, 17);
            this.hicribtn.TabIndex = 20;
            this.hicribtn.TabStop = true;
            this.hicribtn.Text = "Hicrii";
            this.hicribtn.UseVisualStyleBackColor = true;
            this.hicribtn.CheckedChanged += new System.EventHandler(this.hicribtn_CheckedChanged);
            // 
            // convert2btn
            // 
            this.convert2btn.Location = new System.Drawing.Point(416, 374);
            this.convert2btn.Name = "convert2btn";
            this.convert2btn.Size = new System.Drawing.Size(221, 23);
            this.convert2btn.TabIndex = 21;
            this.convert2btn.Text = "convert";
            this.convert2btn.UseVisualStyleBackColor = true;
            this.convert2btn.Click += new System.EventHandler(this.convert2btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.convert2btn);
            this.Controls.Add(this.hicribtn);
            this.Controls.Add(this.miladbtn);
            this.Controls.Add(this.hicribox);
            this.Controls.Add(this.miladbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numb2);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numb);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.footBtn);
            this.Controls.Add(this.milBtn);
            this.Controls.Add(this.metrBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.footBox);
            this.Controls.Add(this.metrBox);
            this.Controls.Add(this.milBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox milBox;
        private System.Windows.Forms.TextBox metrBox;
        private System.Windows.Forms.TextBox footBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton metrBtn;
        private System.Windows.Forms.RadioButton milBtn;
        private System.Windows.Forms.RadioButton footBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox numb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox numb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox miladbox;
        private System.Windows.Forms.TextBox hicribox;
        private System.Windows.Forms.RadioButton miladbtn;
        private System.Windows.Forms.RadioButton hicribtn;
        private System.Windows.Forms.Button convert2btn;
        private System.Windows.Forms.Button button1;
    }
}