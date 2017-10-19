namespace BoatUI.UI.Window
{
    partial class ControllUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllUI));
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.boat_graphics = new System.Windows.Forms.Panel();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.comButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rotateLeft
            // 
            this.rotateLeft.Location = new System.Drawing.Point(510, 396);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(75, 23);
            this.rotateLeft.TabIndex = 0;
            this.rotateLeft.Text = "Left";
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.rotateLeft_Click);
            // 
            // rotateRight
            // 
            this.rotateRight.Location = new System.Drawing.Point(591, 396);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(75, 23);
            this.rotateRight.TabIndex = 1;
            this.rotateRight.Text = "Right";
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // boat_graphics
            // 
            this.boat_graphics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boat_graphics.BackgroundImage")));
            this.boat_graphics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boat_graphics.Location = new System.Drawing.Point(375, 13);
            this.boat_graphics.Name = "boat_graphics";
            this.boat_graphics.Size = new System.Drawing.Size(291, 377);
            this.boat_graphics.TabIndex = 2;
            this.boat_graphics.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comPort
            // 
            this.comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPort.DropDownWidth = 80;
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(13, 399);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(80, 21);
            this.comPort.TabIndex = 4;
            this.comPort.DropDown += new System.EventHandler(this.comPort_DropDown);
            this.comPort.SelectedIndexChanged += new System.EventHandler(this.comPort_SelectedIndexChanged);
            // 
            // baudRate
            // 
            this.baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(99, 399);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(80, 21);
            this.baudRate.TabIndex = 5;
            this.baudRate.DropDown += new System.EventHandler(this.baudRate_DropDown);
            this.baudRate.SelectedIndexChanged += new System.EventHandler(this.baudRate_SelectedIndexChanged);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(185, 399);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(100, 20);
            this.sendText.TabIndex = 6;
            // 
            // comButton
            // 
            this.comButton.Location = new System.Drawing.Point(294, 398);
            this.comButton.Name = "comButton";
            this.comButton.Size = new System.Drawing.Size(75, 23);
            this.comButton.TabIndex = 7;
            this.comButton.Text = "Send/Connect";
            this.comButton.UseVisualStyleBackColor = true;
            this.comButton.Click += new System.EventHandler(this.comButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 381);
            this.listBox1.TabIndex = 8;
            // 
            // ControllUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 431);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comButton);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.boat_graphics);
            this.Controls.Add(this.rotateRight);
            this.Controls.Add(this.rotateLeft);
            this.Name = "ControllUI";
            this.Text = "ControllUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Panel boat_graphics;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button comButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}