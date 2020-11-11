using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace Inmediata
{
	public class ctlMain : System.Windows.Forms.UserControl {
        public TextBox Inmediata;
        private Timer timer1;
        private IContainer components;

        public ctlMain()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.Inmediata = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Inmediata
            // 
            this.Inmediata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inmediata.BackColor = System.Drawing.Color.White;
            this.Inmediata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inmediata.ForeColor = System.Drawing.Color.Black;
            this.Inmediata.Location = new System.Drawing.Point(9, 8);
            this.Inmediata.Multiline = true;
            this.Inmediata.Name = "Inmediata";
            this.Inmediata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Inmediata.Size = new System.Drawing.Size(470, 360);
            this.Inmediata.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctlMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Inmediata);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(488, 376);
            this.Load += new System.EventHandler(this.ctlMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void ctlMain_Load(object sender, System.EventArgs e)
		{
		
		}

        private void timer1_Tick(object sender, EventArgs e) {
            this.Inmediata.Text = Plugin.GlobalValue;
        }
    }
}
