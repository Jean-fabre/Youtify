namespace Youtify
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
            this.webbrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webbrowser
            // 
            this.webbrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbrowser.Location = new System.Drawing.Point(0, 0);
            this.webbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbrowser.Name = "webbrowser";
            this.webbrowser.Size = new System.Drawing.Size(1352, 956);
            this.webbrowser.TabIndex = 0;
            this.webbrowser.Url = new System.Uri("https://accounts.spotify.com/en/authorize?client_id=5b10a95186374649ad215135159e9" +
        "abc&response_type=code&redirect_uri=https:%2F%2Fgithub.com%2FJean-fabre&scope=us" +
        "er-library-modify", System.UriKind.Absolute);
            this.webbrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webbrowser_Navigated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 956);
            this.Controls.Add(this.webbrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webbrowser;
    }
}

