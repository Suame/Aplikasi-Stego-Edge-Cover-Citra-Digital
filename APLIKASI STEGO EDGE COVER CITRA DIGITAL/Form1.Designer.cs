namespace APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL
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
            this.pcboxCover = new System.Windows.Forms.PictureBox();
            this.pcboxEmbedStego = new System.Windows.Forms.PictureBox();
            this.lblCoverImage = new System.Windows.Forms.Label();
            this.lblStegoImage = new System.Windows.Forms.Label();
            this.tabCtrlMenu = new System.Windows.Forms.TabControl();
            this.tabPageEmbed = new System.Windows.Forms.TabPage();
            this.pcBoxOpenCover = new System.Windows.Forms.PictureBox();
            this.btnEmbed = new System.Windows.Forms.Button();
            this.txtBoxEmbedMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabPageExtract = new System.Windows.Forms.TabPage();
            this.pcBoxOpenStego = new System.Windows.Forms.PictureBox();
            this.lblSecMess = new System.Windows.Forms.Label();
            this.lblStegoIm = new System.Windows.Forms.Label();
            this.pcBoxExtractStegoImage = new System.Windows.Forms.PictureBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtBoxExtractMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxEmbedStego)).BeginInit();
            this.tabCtrlMenu.SuspendLayout();
            this.tabPageEmbed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenCover)).BeginInit();
            this.tabPageExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenStego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxExtractStegoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxCover
            // 
            this.pcboxCover.BackColor = System.Drawing.Color.FloralWhite;
            this.pcboxCover.Location = new System.Drawing.Point(8, 138);
            this.pcboxCover.Name = "pcboxCover";
            this.pcboxCover.Size = new System.Drawing.Size(300, 300);
            this.pcboxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxCover.TabIndex = 1;
            this.pcboxCover.TabStop = false;
            // 
            // pcboxEmbedStego
            // 
            this.pcboxEmbedStego.BackColor = System.Drawing.Color.FloralWhite;
            this.pcboxEmbedStego.Location = new System.Drawing.Point(410, 138);
            this.pcboxEmbedStego.Name = "pcboxEmbedStego";
            this.pcboxEmbedStego.Size = new System.Drawing.Size(300, 300);
            this.pcboxEmbedStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxEmbedStego.TabIndex = 2;
            this.pcboxEmbedStego.TabStop = false;
            // 
            // lblCoverImage
            // 
            this.lblCoverImage.AutoSize = true;
            this.lblCoverImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoverImage.Location = new System.Drawing.Point(19, 113);
            this.lblCoverImage.Name = "lblCoverImage";
            this.lblCoverImage.Size = new System.Drawing.Size(96, 16);
            this.lblCoverImage.TabIndex = 3;
            this.lblCoverImage.Text = "Cover Image";
            // 
            // lblStegoImage
            // 
            this.lblStegoImage.AutoSize = true;
            this.lblStegoImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStegoImage.Location = new System.Drawing.Point(417, 113);
            this.lblStegoImage.Name = "lblStegoImage";
            this.lblStegoImage.Size = new System.Drawing.Size(96, 16);
            this.lblStegoImage.TabIndex = 4;
            this.lblStegoImage.Text = "Stego Image";
            // 
            // tabCtrlMenu
            // 
            this.tabCtrlMenu.Controls.Add(this.tabPageEmbed);
            this.tabCtrlMenu.Controls.Add(this.tabPageExtract);
            this.tabCtrlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMenu.Name = "tabCtrlMenu";
            this.tabCtrlMenu.SelectedIndex = 0;
            this.tabCtrlMenu.Size = new System.Drawing.Size(731, 471);
            this.tabCtrlMenu.TabIndex = 5;
            // 
            // tabPageEmbed
            // 
            this.tabPageEmbed.BackColor = System.Drawing.Color.SeaShell;
            this.tabPageEmbed.Controls.Add(this.pcBoxOpenCover);
            this.tabPageEmbed.Controls.Add(this.btnEmbed);
            this.tabPageEmbed.Controls.Add(this.txtBoxEmbedMessage);
            this.tabPageEmbed.Controls.Add(this.lblMessage);
            this.tabPageEmbed.Controls.Add(this.lblStegoImage);
            this.tabPageEmbed.Controls.Add(this.lblCoverImage);
            this.tabPageEmbed.Controls.Add(this.pcboxEmbedStego);
            this.tabPageEmbed.Controls.Add(this.pcboxCover);
            this.tabPageEmbed.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmbed.Name = "tabPageEmbed";
            this.tabPageEmbed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmbed.Size = new System.Drawing.Size(723, 445);
            this.tabPageEmbed.TabIndex = 0;
            this.tabPageEmbed.Text = "Embed";
            // 
            // pcBoxOpenCover
            // 
            this.pcBoxOpenCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpenCover.Image = global::APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL.Properties.Resources.open;
            this.pcBoxOpenCover.Location = new System.Drawing.Point(130, 106);
            this.pcBoxOpenCover.Name = "pcBoxOpenCover";
            this.pcBoxOpenCover.Size = new System.Drawing.Size(26, 23);
            this.pcBoxOpenCover.TabIndex = 8;
            this.pcBoxOpenCover.TabStop = false;
            this.pcBoxOpenCover.Click += new System.EventHandler(this.pcBoxOpen_Click);
            // 
            // btnEmbed
            // 
            this.btnEmbed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmbed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbed.Location = new System.Drawing.Point(318, 266);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(80, 33);
            this.btnEmbed.TabIndex = 7;
            this.btnEmbed.Text = "Embed";
            this.btnEmbed.UseVisualStyleBackColor = true;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // txtBoxEmbedMessage
            // 
            this.txtBoxEmbedMessage.Location = new System.Drawing.Point(8, 40);
            this.txtBoxEmbedMessage.Multiline = true;
            this.txtBoxEmbedMessage.Name = "txtBoxEmbedMessage";
            this.txtBoxEmbedMessage.Size = new System.Drawing.Size(702, 53);
            this.txtBoxEmbedMessage.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(19, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(121, 16);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Secret Message";
            // 
            // tabPageExtract
            // 
            this.tabPageExtract.BackColor = System.Drawing.Color.SeaShell;
            this.tabPageExtract.Controls.Add(this.txtBoxExtractMessage);
            this.tabPageExtract.Controls.Add(this.btnExtract);
            this.tabPageExtract.Controls.Add(this.pcBoxExtractStegoImage);
            this.tabPageExtract.Controls.Add(this.lblSecMess);
            this.tabPageExtract.Controls.Add(this.lblStegoIm);
            this.tabPageExtract.Controls.Add(this.pcBoxOpenStego);
            this.tabPageExtract.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtract.Name = "tabPageExtract";
            this.tabPageExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExtract.Size = new System.Drawing.Size(723, 445);
            this.tabPageExtract.TabIndex = 3;
            this.tabPageExtract.Text = "Extract";
            // 
            // pcBoxOpenStego
            // 
            this.pcBoxOpenStego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpenStego.Image = global::APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL.Properties.Resources.open;
            this.pcBoxOpenStego.Location = new System.Drawing.Point(132, 10);
            this.pcBoxOpenStego.Name = "pcBoxOpenStego";
            this.pcBoxOpenStego.Size = new System.Drawing.Size(26, 23);
            this.pcBoxOpenStego.TabIndex = 9;
            this.pcBoxOpenStego.TabStop = false;
            this.pcBoxOpenStego.Click += new System.EventHandler(this.pcBoxOpenStego_Click);
            // 
            // lblSecMess
            // 
            this.lblSecMess.AutoSize = true;
            this.lblSecMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecMess.Location = new System.Drawing.Point(415, 17);
            this.lblSecMess.Name = "lblSecMess";
            this.lblSecMess.Size = new System.Drawing.Size(121, 16);
            this.lblSecMess.TabIndex = 11;
            this.lblSecMess.Text = "Secret Message";
            // 
            // lblStegoIm
            // 
            this.lblStegoIm.AutoSize = true;
            this.lblStegoIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStegoIm.Location = new System.Drawing.Point(21, 17);
            this.lblStegoIm.Name = "lblStegoIm";
            this.lblStegoIm.Size = new System.Drawing.Size(96, 16);
            this.lblStegoIm.TabIndex = 10;
            this.lblStegoIm.Text = "Stego Image";
            // 
            // pcBoxExtractStegoImage
            // 
            this.pcBoxExtractStegoImage.BackColor = System.Drawing.Color.FloralWhite;
            this.pcBoxExtractStegoImage.Location = new System.Drawing.Point(17, 49);
            this.pcBoxExtractStegoImage.Name = "pcBoxExtractStegoImage";
            this.pcBoxExtractStegoImage.Size = new System.Drawing.Size(300, 300);
            this.pcBoxExtractStegoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxExtractStegoImage.TabIndex = 12;
            this.pcBoxExtractStegoImage.TabStop = false;
            // 
            // btnExtract
            // 
            this.btnExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(324, 188);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(80, 33);
            this.btnExtract.TabIndex = 13;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtBoxExtractMessage
            // 
            this.txtBoxExtractMessage.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBoxExtractMessage.Location = new System.Drawing.Point(411, 45);
            this.txtBoxExtractMessage.Multiline = true;
            this.txtBoxExtractMessage.Name = "txtBoxExtractMessage";
            this.txtBoxExtractMessage.ReadOnly = true;
            this.txtBoxExtractMessage.Size = new System.Drawing.Size(296, 391);
            this.txtBoxExtractMessage.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 470);
            this.Controls.Add(this.tabCtrlMenu);
            this.Name = "Form1";
            this.Text = "APLIKASI STEGANOGRAFI EDGE COVER CITRA DIGITAL";
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxEmbedStego)).EndInit();
            this.tabCtrlMenu.ResumeLayout(false);
            this.tabPageEmbed.ResumeLayout(false);
            this.tabPageEmbed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenCover)).EndInit();
            this.tabPageExtract.ResumeLayout(false);
            this.tabPageExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenStego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxExtractStegoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxCover;
        private System.Windows.Forms.PictureBox pcboxEmbedStego;
        private System.Windows.Forms.Label lblCoverImage;
        private System.Windows.Forms.Label lblStegoImage;
        private System.Windows.Forms.TabControl tabCtrlMenu;
        private System.Windows.Forms.TabPage tabPageEmbed;
        private System.Windows.Forms.TabPage tabPageExtract;
        private System.Windows.Forms.TextBox txtBoxEmbedMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnEmbed;
        private System.Windows.Forms.PictureBox pcBoxOpenCover;
        private System.Windows.Forms.PictureBox pcBoxOpenStego;
        private System.Windows.Forms.TextBox txtBoxExtractMessage;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.PictureBox pcBoxExtractStegoImage;
        private System.Windows.Forms.Label lblSecMess;
        private System.Windows.Forms.Label lblStegoIm;
    }
}

