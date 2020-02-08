namespace Sim900Gorsel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ebubekirYazılımV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komutYollaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bağlantı Şekli";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(22, 27);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(131, 20);
            this.comboBoxEx1.TabIndex = 5;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ebubekirYazılımV01ToolStripMenuItem,
            this.portListeleToolStripMenuItem,
            this.bağlanToolStripMenuItem,
            this.bağlantıyıKesToolStripMenuItem,
            this.komutYollaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 114);
            // 
            // ebubekirYazılımV01ToolStripMenuItem
            // 
            this.ebubekirYazılımV01ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ebubekirYazılımV01ToolStripMenuItem.Name = "ebubekirYazılımV01ToolStripMenuItem";
            this.ebubekirYazılımV01ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ebubekirYazılımV01ToolStripMenuItem.Text = "Ebubekir Yazılım V0.1";
            // 
            // portListeleToolStripMenuItem
            // 
            this.portListeleToolStripMenuItem.Name = "portListeleToolStripMenuItem";
            this.portListeleToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.portListeleToolStripMenuItem.Text = "Port Listele";
            this.portListeleToolStripMenuItem.Click += new System.EventHandler(this.portListeleToolStripMenuItem_Click);
            // 
            // bağlanToolStripMenuItem
            // 
            this.bağlanToolStripMenuItem.Name = "bağlanToolStripMenuItem";
            this.bağlanToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bağlanToolStripMenuItem.Text = "Bağlan";
            this.bağlanToolStripMenuItem.Click += new System.EventHandler(this.bağlanToolStripMenuItem_Click);
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı Kes";
            this.bağlantıyıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem_Click);
            // 
            // komutYollaToolStripMenuItem
            // 
            this.komutYollaToolStripMenuItem.Name = "komutYollaToolStripMenuItem";
            this.komutYollaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.komutYollaToolStripMenuItem.Text = "Komut Yolla";
            this.komutYollaToolStripMenuItem.Click += new System.EventHandler(this.komutYollaToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, -27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "......";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(707, 323);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(619, 29);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(639, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "At Komutu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(731, 388);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms Oku";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ebubekirYazılımV01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem komutYollaToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.Label label2;
    }
}

