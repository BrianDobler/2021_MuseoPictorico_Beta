namespace MuseoPictoricoG11.Pantallas
{
    partial class CargaProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaProgram));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelDeCarga = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlbarrita1 = new System.Windows.Forms.Panel();
            this.barrita2 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 29;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(75, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 19);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panelDeCarga);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(544, 13);
            this.panel6.TabIndex = 1;
            // 
            // panelDeCarga
            // 
            this.panelDeCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.panelDeCarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDeCarga.Location = new System.Drawing.Point(3, 3);
            this.panelDeCarga.Name = "panelDeCarga";
            this.panelDeCarga.Size = new System.Drawing.Size(45, 7);
            this.panelDeCarga.TabIndex = 2;
            this.panelDeCarga.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDeCarga_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlbarrita1
            // 
            this.pnlbarrita1.Location = new System.Drawing.Point(0, 379);
            this.pnlbarrita1.Name = "pnlbarrita1";
            this.pnlbarrita1.Size = new System.Drawing.Size(700, 10);
            this.pnlbarrita1.TabIndex = 35;
            // 
            // barrita2
            // 
            this.barrita2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.barrita2.Location = new System.Drawing.Point(-1, 382);
            this.barrita2.Name = "barrita2";
            this.barrita2.Size = new System.Drawing.Size(702, 101);
            this.barrita2.TabIndex = 34;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.pnlbarrita1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.panel5;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.panel6;
            // 
            // CargaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 396);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlbarrita1);
            this.Controls.Add(this.barrita2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(700, 396);
            this.Name = "CargaProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaProgram";
            this.Load += new System.EventHandler(this.CargaProgram_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CargaProgram_MouseMove);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelDeCarga;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlbarrita1;
        private System.Windows.Forms.Panel barrita2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}