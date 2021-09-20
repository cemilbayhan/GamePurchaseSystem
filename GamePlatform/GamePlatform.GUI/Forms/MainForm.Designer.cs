
namespace GamePlatform.GUI.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyExtraPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHorizantalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tltCustomer = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1108, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::GamePlatform.GUI.IconImages.cancel;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesListToolStripMenuItem,
            this.buyGameToolStripMenuItem,
            this.buyExtraPackageToolStripMenuItem});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.gamesToolStripMenuItem.Text = "Games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // gamesListToolStripMenuItem
            // 
            this.gamesListToolStripMenuItem.Name = "gamesListToolStripMenuItem";
            this.gamesListToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.gamesListToolStripMenuItem.Text = "Games List";
            this.gamesListToolStripMenuItem.Click += new System.EventHandler(this.gamesListToolStripMenuItem_Click);
            // 
            // buyGameToolStripMenuItem
            // 
            this.buyGameToolStripMenuItem.Name = "buyGameToolStripMenuItem";
            this.buyGameToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.buyGameToolStripMenuItem.Text = "Buy Game";
            this.buyGameToolStripMenuItem.Click += new System.EventHandler(this.buyGameToolStripMenuItem_Click);
            // 
            // buyExtraPackageToolStripMenuItem
            // 
            this.buyExtraPackageToolStripMenuItem.Name = "buyExtraPackageToolStripMenuItem";
            this.buyExtraPackageToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.buyExtraPackageToolStripMenuItem.Text = "Buy ExtraPackage";
            this.buyExtraPackageToolStripMenuItem.Click += new System.EventHandler(this.buyExtraPackageToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setHorizantalToolStripMenuItem,
            this.setVerticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // setHorizantalToolStripMenuItem
            // 
            this.setHorizantalToolStripMenuItem.Name = "setHorizantalToolStripMenuItem";
            this.setHorizantalToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.setHorizantalToolStripMenuItem.Text = "Set Horizantal";
            this.setHorizantalToolStripMenuItem.Click += new System.EventHandler(this.setHorizantalToolStripMenuItem_Click);
            // 
            // setVerticalToolStripMenuItem
            // 
            this.setVerticalToolStripMenuItem.Name = "setVerticalToolStripMenuItem";
            this.setVerticalToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.setVerticalToolStripMenuItem.Text = "Set Vertical";
            this.setVerticalToolStripMenuItem.Click += new System.EventHandler(this.setVerticalToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tltCustomer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1108, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tltCustomer
            // 
            this.tltCustomer.Name = "tltCustomer";
            this.tltCustomer.Size = new System.Drawing.Size(0, 18);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 694);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHorizantalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tltCustomer;
        private System.Windows.Forms.ToolStripMenuItem buyExtraPackageToolStripMenuItem;
    }
}