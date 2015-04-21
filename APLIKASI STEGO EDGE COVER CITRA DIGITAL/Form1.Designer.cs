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
            this.tabCtrlMenu = new System.Windows.Forms.TabControl();
            this.tabPageEmbed = new System.Windows.Forms.TabPage();
            this.btnResetEmbed = new System.Windows.Forms.Button();
            this.pcBoxSave = new System.Windows.Forms.PictureBox();
            this.txtBoxStegoKey = new System.Windows.Forms.TextBox();
            this.lblStegoKey = new System.Windows.Forms.Label();
            this.pcBoxOpenCover = new System.Windows.Forms.PictureBox();
            this.btnEmbed = new System.Windows.Forms.Button();
            this.txtBoxEmbedMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblStegoImage = new System.Windows.Forms.Label();
            this.lblCoverImage = new System.Windows.Forms.Label();
            this.pcboxEmbedStego = new System.Windows.Forms.PictureBox();
            this.pcboxCover = new System.Windows.Forms.PictureBox();
            this.tabPageExtract = new System.Windows.Forms.TabPage();
            this.btnResetExtract = new System.Windows.Forms.Button();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtBoxExtractMessage = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.lblSecMess = new System.Windows.Forms.Label();
            this.lblStegoIm = new System.Windows.Forms.Label();
            this.pcBoxExtractStegoImage = new System.Windows.Forms.PictureBox();
            this.pcBoxOpenStego = new System.Windows.Forms.PictureBox();
            this.tabCtrlMenu.SuspendLayout();
            this.tabPageEmbed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxEmbedStego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCover)).BeginInit();
            this.tabPageExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxExtractStegoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenStego)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlMenu
            // 
            this.tabCtrlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlMenu.Controls.Add(this.tabPageEmbed);
            this.tabCtrlMenu.Controls.Add(this.tabPageExtract);
            this.tabCtrlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMenu.Name = "tabCtrlMenu";
            this.tabCtrlMenu.SelectedIndex = 0;
            this.tabCtrlMenu.Size = new System.Drawing.Size(977, 634);
            this.tabCtrlMenu.TabIndex = 5;
            // 
            // tabPageEmbed
            // 
            this.tabPageEmbed.BackColor = System.Drawing.Color.SeaShell;
            this.tabPageEmbed.Controls.Add(this.btnResetEmbed);
            this.tabPageEmbed.Controls.Add(this.pcBoxSave);
            this.tabPageEmbed.Controls.Add(this.txtBoxStegoKey);
            this.tabPageEmbed.Controls.Add(this.lblStegoKey);
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
            this.tabPageEmbed.Size = new System.Drawing.Size(969, 608);
            this.tabPageEmbed.TabIndex = 0;
            this.tabPageEmbed.Text = "Embed";
            // 
            // btnResetEmbed
            // 
            this.btnResetEmbed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetEmbed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEmbed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEmbed.ForeColor = System.Drawing.Color.DarkRed;
            this.btnResetEmbed.Location = new System.Drawing.Point(909, 8);
            this.btnResetEmbed.Name = "btnResetEmbed";
            this.btnResetEmbed.Size = new System.Drawing.Size(50, 25);
            this.btnResetEmbed.TabIndex = 22;
            this.btnResetEmbed.Text = "Reset";
            this.btnResetEmbed.UseVisualStyleBackColor = true;
            this.btnResetEmbed.Click += new System.EventHandler(this.btnResetEmbed_Click);
            // 
            // pcBoxSave
            // 
            this.pcBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxSave.Image = global::APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL.Properties.Resources.save;
            this.pcBoxSave.Location = new System.Drawing.Point(666, 163);
            this.pcBoxSave.Name = "pcBoxSave";
            this.pcBoxSave.Size = new System.Drawing.Size(26, 23);
            this.pcBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxSave.TabIndex = 19;
            this.pcBoxSave.TabStop = false;
            this.pcBoxSave.Click += new System.EventHandler(this.pcBoxSave_Click);
            // 
            // txtBoxStegoKey
            // 
            this.txtBoxStegoKey.BackColor = System.Drawing.Color.OldLace;
            this.txtBoxStegoKey.Location = new System.Drawing.Point(855, 165);
            this.txtBoxStegoKey.Multiline = true;
            this.txtBoxStegoKey.Name = "txtBoxStegoKey";
            this.txtBoxStegoKey.ReadOnly = true;
            this.txtBoxStegoKey.Size = new System.Drawing.Size(92, 26);
            this.txtBoxStegoKey.TabIndex = 18;
            // 
            // lblStegoKey
            // 
            this.lblStegoKey.AutoSize = true;
            this.lblStegoKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStegoKey.Location = new System.Drawing.Point(756, 170);
            this.lblStegoKey.Name = "lblStegoKey";
            this.lblStegoKey.Size = new System.Drawing.Size(95, 16);
            this.lblStegoKey.TabIndex = 9;
            this.lblStegoKey.Text = "Stego Key  : ";
            // 
            // pcBoxOpenCover
            // 
            this.pcBoxOpenCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpenCover.Image = global::APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL.Properties.Resources.open;
            this.pcBoxOpenCover.Location = new System.Drawing.Point(143, 163);
            this.pcBoxOpenCover.Name = "pcBoxOpenCover";
            this.pcBoxOpenCover.Size = new System.Drawing.Size(26, 23);
            this.pcBoxOpenCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxOpenCover.TabIndex = 8;
            this.pcBoxOpenCover.TabStop = false;
            this.pcBoxOpenCover.Click += new System.EventHandler(this.pcBoxOpen_Click);
            // 
            // btnEmbed
            // 
            this.btnEmbed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmbed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbed.Location = new System.Drawing.Point(446, 374);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(80, 33);
            this.btnEmbed.TabIndex = 7;
            this.btnEmbed.Text = "Embed";
            this.btnEmbed.UseVisualStyleBackColor = true;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // txtBoxEmbedMessage
            // 
            this.txtBoxEmbedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmbedMessage.Location = new System.Drawing.Point(11, 48);
            this.txtBoxEmbedMessage.Multiline = true;
            this.txtBoxEmbedMessage.Name = "txtBoxEmbedMessage";
            this.txtBoxEmbedMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxEmbedMessage.Size = new System.Drawing.Size(948, 99);
            this.txtBoxEmbedMessage.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(19, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(121, 16);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Secret Message";
            // 
            // lblStegoImage
            // 
            this.lblStegoImage.AutoSize = true;
            this.lblStegoImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStegoImage.Location = new System.Drawing.Point(554, 170);
            this.lblStegoImage.Name = "lblStegoImage";
            this.lblStegoImage.Size = new System.Drawing.Size(96, 16);
            this.lblStegoImage.TabIndex = 4;
            this.lblStegoImage.Text = "Stego Image";
            // 
            // lblCoverImage
            // 
            this.lblCoverImage.AutoSize = true;
            this.lblCoverImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoverImage.Location = new System.Drawing.Point(32, 170);
            this.lblCoverImage.Name = "lblCoverImage";
            this.lblCoverImage.Size = new System.Drawing.Size(96, 16);
            this.lblCoverImage.TabIndex = 3;
            this.lblCoverImage.Text = "Cover Image";
            // 
            // pcboxEmbedStego
            // 
            this.pcboxEmbedStego.BackColor = System.Drawing.Color.FloralWhite;
            this.pcboxEmbedStego.Location = new System.Drawing.Point(547, 195);
            this.pcboxEmbedStego.Name = "pcboxEmbedStego";
            this.pcboxEmbedStego.Size = new System.Drawing.Size(400, 400);
            this.pcboxEmbedStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxEmbedStego.TabIndex = 2;
            this.pcboxEmbedStego.TabStop = false;
            // 
            // pcboxCover
            // 
            this.pcboxCover.BackColor = System.Drawing.Color.FloralWhite;
            this.pcboxCover.Location = new System.Drawing.Point(21, 195);
            this.pcboxCover.Name = "pcboxCover";
            this.pcboxCover.Size = new System.Drawing.Size(400, 400);
            this.pcboxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxCover.TabIndex = 1;
            this.pcboxCover.TabStop = false;
            // 
            // tabPageExtract
            // 
            this.tabPageExtract.BackColor = System.Drawing.Color.SeaShell;
            this.tabPageExtract.Controls.Add(this.btnResetExtract);
            this.tabPageExtract.Controls.Add(this.txtBoxKey);
            this.tabPageExtract.Controls.Add(this.lblKey);
            this.tabPageExtract.Controls.Add(this.txtBoxExtractMessage);
            this.tabPageExtract.Controls.Add(this.btnExtract);
            this.tabPageExtract.Controls.Add(this.lblSecMess);
            this.tabPageExtract.Controls.Add(this.lblStegoIm);
            this.tabPageExtract.Controls.Add(this.pcBoxExtractStegoImage);
            this.tabPageExtract.Controls.Add(this.pcBoxOpenStego);
            this.tabPageExtract.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtract.Name = "tabPageExtract";
            this.tabPageExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExtract.Size = new System.Drawing.Size(969, 608);
            this.tabPageExtract.TabIndex = 3;
            this.tabPageExtract.Text = "Extract";
            // 
            // btnResetExtract
            // 
            this.btnResetExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetExtract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetExtract.ForeColor = System.Drawing.Color.DarkRed;
            this.btnResetExtract.Location = new System.Drawing.Point(910, 9);
            this.btnResetExtract.Name = "btnResetExtract";
            this.btnResetExtract.Size = new System.Drawing.Size(50, 25);
            this.btnResetExtract.TabIndex = 21;
            this.btnResetExtract.Text = "Reset";
            this.btnResetExtract.UseVisualStyleBackColor = true;
            this.btnResetExtract.Click += new System.EventHandler(this.btnResetExtract_Click);
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(20, 66);
            this.txtBoxKey.Multiline = true;
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(131, 26);
            this.txtBoxKey.TabIndex = 17;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(24, 38);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(79, 16);
            this.lblKey.TabIndex = 16;
            this.lblKey.Text = "Stego Key";
            // 
            // txtBoxExtractMessage
            // 
            this.txtBoxExtractMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxExtractMessage.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBoxExtractMessage.Location = new System.Drawing.Point(548, 66);
            this.txtBoxExtractMessage.Multiline = true;
            this.txtBoxExtractMessage.Name = "txtBoxExtractMessage";
            this.txtBoxExtractMessage.ReadOnly = true;
            this.txtBoxExtractMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxExtractMessage.Size = new System.Drawing.Size(400, 519);
            this.txtBoxExtractMessage.TabIndex = 14;
            // 
            // btnExtract
            // 
            this.btnExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(444, 247);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(80, 33);
            this.btnExtract.TabIndex = 13;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // lblSecMess
            // 
            this.lblSecMess.AutoSize = true;
            this.lblSecMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecMess.Location = new System.Drawing.Point(549, 38);
            this.lblSecMess.Name = "lblSecMess";
            this.lblSecMess.Size = new System.Drawing.Size(121, 16);
            this.lblSecMess.TabIndex = 11;
            this.lblSecMess.Text = "Secret Message";
            // 
            // lblStegoIm
            // 
            this.lblStegoIm.AutoSize = true;
            this.lblStegoIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStegoIm.Location = new System.Drawing.Point(24, 128);
            this.lblStegoIm.Name = "lblStegoIm";
            this.lblStegoIm.Size = new System.Drawing.Size(96, 16);
            this.lblStegoIm.TabIndex = 10;
            this.lblStegoIm.Text = "Stego Image";
            // 
            // pcBoxExtractStegoImage
            // 
            this.pcBoxExtractStegoImage.BackColor = System.Drawing.Color.FloralWhite;
            this.pcBoxExtractStegoImage.Location = new System.Drawing.Point(20, 160);
            this.pcBoxExtractStegoImage.Name = "pcBoxExtractStegoImage";
            this.pcBoxExtractStegoImage.Size = new System.Drawing.Size(400, 400);
            this.pcBoxExtractStegoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxExtractStegoImage.TabIndex = 12;
            this.pcBoxExtractStegoImage.TabStop = false;
            // 
            // pcBoxOpenStego
            // 
            this.pcBoxOpenStego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpenStego.Image = global::APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL.Properties.Resources.open;
            this.pcBoxOpenStego.Location = new System.Drawing.Point(135, 121);
            this.pcBoxOpenStego.Name = "pcBoxOpenStego";
            this.pcBoxOpenStego.Size = new System.Drawing.Size(26, 23);
            this.pcBoxOpenStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxOpenStego.TabIndex = 9;
            this.pcBoxOpenStego.TabStop = false;
            this.pcBoxOpenStego.Click += new System.EventHandler(this.pcBoxOpenStego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 633);
            this.Controls.Add(this.tabCtrlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "APLIKASI STEGANOGRAFI EDGE COVER CITRA DIGITAL";
            this.tabCtrlMenu.ResumeLayout(false);
            this.tabPageEmbed.ResumeLayout(false);
            this.tabPageEmbed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxEmbedStego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCover)).EndInit();
            this.tabPageExtract.ResumeLayout(false);
            this.tabPageExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxExtractStegoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpenStego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlMenu;
        private System.Windows.Forms.TabPage tabPageExtract;
        private System.Windows.Forms.PictureBox pcBoxOpenStego;
        private System.Windows.Forms.TextBox txtBoxExtractMessage;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.PictureBox pcBoxExtractStegoImage;
        private System.Windows.Forms.Label lblSecMess;
        private System.Windows.Forms.Label lblStegoIm;
        private System.Windows.Forms.TabPage tabPageEmbed;
        private System.Windows.Forms.PictureBox pcBoxOpenCover;
        private System.Windows.Forms.Button btnEmbed;
        private System.Windows.Forms.TextBox txtBoxEmbedMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblStegoImage;
        private System.Windows.Forms.Label lblCoverImage;
        private System.Windows.Forms.PictureBox pcboxEmbedStego;
        private System.Windows.Forms.PictureBox pcboxCover;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtBoxStegoKey;
        private System.Windows.Forms.Label lblStegoKey;
        private System.Windows.Forms.PictureBox pcBoxSave;
        private System.Windows.Forms.Button btnResetExtract;
        private System.Windows.Forms.Button btnResetEmbed;
    }
}

