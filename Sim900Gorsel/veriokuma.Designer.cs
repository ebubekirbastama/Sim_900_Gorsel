namespace Sim900Gorsel
{
    partial class veriokuma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veriokuma));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ebubekirYazılımV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.veriOkumayaBaşlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.portListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(740, 390);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ebubekirYazılımV01ToolStripMenuItem,
            this.toolStripSeparator1,
            this.veriOkumayaBaşlaToolStripMenuItem,
            this.portListeleToolStripMenuItem,
            this.bağlanToolStripMenuItem,
            this.bağlantıyıKesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 142);
            // 
            // ebubekirYazılımV01ToolStripMenuItem
            // 
            this.ebubekirYazılımV01ToolStripMenuItem.Enabled = false;
            this.ebubekirYazılımV01ToolStripMenuItem.Name = "ebubekirYazılımV01ToolStripMenuItem";
            this.ebubekirYazılımV01ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ebubekirYazılımV01ToolStripMenuItem.Text = "Ebubekir Yazılım V0.1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // veriOkumayaBaşlaToolStripMenuItem
            // 
            this.veriOkumayaBaşlaToolStripMenuItem.Name = "veriOkumayaBaşlaToolStripMenuItem";
            this.veriOkumayaBaşlaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.veriOkumayaBaşlaToolStripMenuItem.Text = "Veri Okumaya Başla";
            this.veriOkumayaBaşlaToolStripMenuItem.Click += new System.EventHandler(this.veriOkumayaBaşlaToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(165, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bağlantı Şekli";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(15, 24);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(131, 20);
            this.comboBoxEx1.TabIndex = 12;
            // 
            // portListeleToolStripMenuItem
            // 
            this.portListeleToolStripMenuItem.Name = "portListeleToolStripMenuItem";
            this.portListeleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.portListeleToolStripMenuItem.Text = "Port Listele";
            this.portListeleToolStripMenuItem.Click += new System.EventHandler(this.portListeleToolStripMenuItem_Click);
            // 
            // bağlanToolStripMenuItem
            // 
            this.bağlanToolStripMenuItem.Name = "bağlanToolStripMenuItem";
            this.bağlanToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bağlanToolStripMenuItem.Text = "Bağlan";
            this.bağlanToolStripMenuItem.Click += new System.EventHandler(this.bağlanToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, -23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı Kes";
            this.bağlantıyıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem_Click);
            // 
            // veriokuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "veriokuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Okuma";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ebubekirYazılımV01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem veriOkumayaBaşlaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.ToolStripMenuItem portListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
    }
}