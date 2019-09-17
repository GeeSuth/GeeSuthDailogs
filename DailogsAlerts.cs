using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeeDailogsSuth
{
    public class DailogsAlerts
    {
        Form form = new Form();
        /// <summary>
        /// call this for dangerous box
        /// </summary>
        /// <param name="imagebrand"> image for application , you can send the resourse. name or path </param>
        /// <param name="imageAlert"> image for image in box , you can send the resourse. name or path </param>
        /// <param name="titleApplication"> Title of application , this be in bottom center on box  </param>
        /// <param name="ExTitle"> title of execption </param>
        /// <param name="txtMsg"> content of Message </param>
        /// <returns> </returns>
        public Form AlertsBoxDangerous(Bitmap imagebrand, Bitmap imageAlert, string titleApplication,string ExTitle, string txtMsg)
        {
            #region Dailog
            form = new Form();
            Panel pn1 = new System.Windows.Forms.Panel();
            Panel pn2 = new System.Windows.Forms.Panel();
            Panel pn3 = new System.Windows.Forms.Panel();
            Button btnExit = new System.Windows.Forms.Button();
            PictureBox picWarning = new System.Windows.Forms.PictureBox();
            TextBox txtMessage = new System.Windows.Forms.TextBox();
            PictureBox picBrand = new System.Windows.Forms.PictureBox();
            Label lblTitle = new System.Windows.Forms.Label();
            Label lblApplicationName = new System.Windows.Forms.Label();

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            pn1 = new System.Windows.Forms.Panel();
            pn2 = new System.Windows.Forms.Panel();
            pn3 = new System.Windows.Forms.Panel();
            btnExit = new System.Windows.Forms.Button();
            picWarning = new System.Windows.Forms.PictureBox();
            txtMessage = new System.Windows.Forms.TextBox();
            picBrand = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblApplicationName = new System.Windows.Forms.Label();
            pn1.SuspendLayout();
            pn2.SuspendLayout();
            pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).BeginInit();
            form.SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = System.Drawing.Color.White;
            pn1.Controls.Add(txtMessage);
            pn1.Controls.Add(picWarning);
            pn1.Controls.Add(pn3);
            pn1.Controls.Add(pn2);
            pn1.Location = new System.Drawing.Point(8, 1);
            pn1.Name = "pn1";
            pn1.Size = new System.Drawing.Size(455, 173);
            pn1.TabIndex = 0;
            // 
            // pn2
            // 
            pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn2.Controls.Add(lblApplicationName);
            pn2.Controls.Add(picBrand);
            pn2.Controls.Add(btnExit);
            pn2.Location = new System.Drawing.Point(1, 0);
            pn2.Name = "pn2";
            pn2.Size = new System.Drawing.Size(454, 40);
            pn2.TabIndex = 0;
            // 
            // pn3
            // 
            pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn3.Controls.Add(lblTitle);
            pn3.Location = new System.Drawing.Point(1, 133);
            pn3.Name = "pn3";
            pn3.Size = new System.Drawing.Size(454, 40);
            pn3.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            btnExit.Location = new System.Drawing.Point(424, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(25, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // picWarning
            // 
            picWarning.Image = ((System.Drawing.Image)(imageAlert));
            picWarning.Location = new System.Drawing.Point(4, 46);
            picWarning.Name = "picWarning";
            picWarning.Size = new System.Drawing.Size(70, 81);
            picWarning.TabIndex = 2;
            picWarning.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMessage.Location = new System.Drawing.Point(80, 46);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtMessage.Size = new System.Drawing.Size(365, 81);
            txtMessage.TabIndex = 3;
            txtMessage.ReadOnly = true;
            txtMessage.BackColor = System.Drawing.Color.White;
            // 
            // picBrand
            // 
            picBrand.Image = ((System.Drawing.Image)(imagebrand));
            picBrand.Location = new System.Drawing.Point(3, 4);
            picBrand.Name = "picBrand";
            picBrand.Size = new System.Drawing.Size(35, 30);
            picBrand.TabIndex = 1;
            picBrand.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("TheSansArabic Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(127, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTitle.Size = new System.Drawing.Size(201, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = ExTitle;
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApplicationName.Location = new System.Drawing.Point(58, 12);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new System.Drawing.Size(124, 14);
            lblApplicationName.TabIndex = 2;
            lblApplicationName.Text = titleApplication + " | ";
            // 
            // Form1
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor =  System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            form.ClientSize = new System.Drawing.Size(465, 175);
            form.Controls.Add(pn1);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = "Form1";
            form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Text = "Form1";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn3.ResumeLayout(false);
            pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).EndInit();
            form.ResumeLayout(false);

            #endregion



            txtMessage.Text = txtMsg;
            form.RightToLeftLayout = true;
            form.RightToLeft = RightToLeft.Yes;

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.GetWorkingArea(form);
            form.Location = new Point(workingArea.Right - form.Size.Width - 20,
                                      workingArea.Bottom - form.Size.Height - 20);

            btnExit.Click += BtnExit_Click;


            Form dialogResult = form;
            return dialogResult;

        }
        /// <summary>
        /// call this for Warning box
        /// </summary>
        /// <param name="imagebrand"> image for application , you can send the resourse. name or path </param>
        /// <param name="imageAlert"> image for image in box , you can send the resourse. name or path </param>
        /// <param name="titleApplication"> Title of application , this be in bottom center on box  </param>
        /// <param name="ExTitle"> title of execption </param>
        /// <param name="txtMsg"> content of Message </param>
        /// <returns> </returns>
        public Form AlertsBoxWarning(Bitmap imagebrand, Bitmap imageAlert, string titleApplication, string ExTitle, string txtMsg)
        {
            #region Dailog
            form = new Form();
            Panel pn1 = new System.Windows.Forms.Panel();
            Panel pn2 = new System.Windows.Forms.Panel();
            Panel pn3 = new System.Windows.Forms.Panel();
            Button btnExit = new System.Windows.Forms.Button();
            PictureBox picWarning = new System.Windows.Forms.PictureBox();
            TextBox txtMessage = new System.Windows.Forms.TextBox();
            PictureBox picBrand = new System.Windows.Forms.PictureBox();
            Label lblTitle = new System.Windows.Forms.Label();
            Label lblApplicationName = new System.Windows.Forms.Label();

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            pn1 = new System.Windows.Forms.Panel();
            pn2 = new System.Windows.Forms.Panel();
            pn3 = new System.Windows.Forms.Panel();
            btnExit = new System.Windows.Forms.Button();
            picWarning = new System.Windows.Forms.PictureBox();
            txtMessage = new System.Windows.Forms.TextBox();
            picBrand = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblApplicationName = new System.Windows.Forms.Label();
            pn1.SuspendLayout();
            pn2.SuspendLayout();
            pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).BeginInit();
            form.SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = System.Drawing.Color.White;
            pn1.Controls.Add(txtMessage);
            pn1.Controls.Add(picWarning);
            pn1.Controls.Add(pn3);
            pn1.Controls.Add(pn2);
            pn1.Location = new System.Drawing.Point(8, 1);
            pn1.Name = "pn1";
            pn1.Size = new System.Drawing.Size(455, 173);
            pn1.TabIndex = 0;
            // 
            // pn2
            // 
            pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn2.Controls.Add(lblApplicationName);
            pn2.Controls.Add(picBrand);
            pn2.Controls.Add(btnExit);
            pn2.Location = new System.Drawing.Point(1, 0);
            pn2.Name = "pn2";
            pn2.Size = new System.Drawing.Size(454, 40);
            pn2.TabIndex = 0;
            // 
            // pn3
            // 
            pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn3.Controls.Add(lblTitle);
            pn3.Location = new System.Drawing.Point(1, 133);
            pn3.Name = "pn3";
            pn3.Size = new System.Drawing.Size(454, 40);
            pn3.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            btnExit.Location = new System.Drawing.Point(424, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(25, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // picWarning
            // 
            picWarning.Image = ((System.Drawing.Image)(imageAlert));
            picWarning.Location = new System.Drawing.Point(4, 46);
            picWarning.Name = "picWarning";
            picWarning.Size = new System.Drawing.Size(70, 81);
            picWarning.TabIndex = 2;
            picWarning.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMessage.Location = new System.Drawing.Point(80, 46);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtMessage.Size = new System.Drawing.Size(365, 81);
            txtMessage.TabIndex = 3;
            txtMessage.ReadOnly = true;
            txtMessage.BackColor = System.Drawing.Color.White;
            // 
            // picBrand
            // 
            picBrand.Image = ((System.Drawing.Image)(imagebrand));
            picBrand.Location = new System.Drawing.Point(3, 4);
            picBrand.Name = "picBrand";
            picBrand.Size = new System.Drawing.Size(35, 30);
            picBrand.TabIndex = 1;
            picBrand.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("TheSansArabic Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(127, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTitle.Size = new System.Drawing.Size(201, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = ExTitle;
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApplicationName.Location = new System.Drawing.Point(58, 12);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new System.Drawing.Size(124, 14);
            lblApplicationName.TabIndex = 2;
            lblApplicationName.Text = titleApplication + " | ";
            // 
            // Form1
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(141)))), ((int)(((byte)(18)))));
            form.ClientSize = new System.Drawing.Size(465, 175);
            form.Controls.Add(pn1);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = "Form1";
            form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Text = "Form1";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn3.ResumeLayout(false);
            pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).EndInit();
            form.ResumeLayout(false);

            #endregion



            txtMessage.Text = txtMsg;
            form.RightToLeftLayout = true;
            form.RightToLeft = RightToLeft.Yes;

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.GetWorkingArea(form);
            form.Location = new Point(workingArea.Right - form.Size.Width - 20,
                                      workingArea.Bottom - form.Size.Height - 20);

            btnExit.Click += BtnExit_Click;


            Form dialogResult = form;
            return dialogResult;

        }
        /// <summary>
        /// call this for Successful box
        /// </summary>
        /// <param name="imagebrand"> image for application , you can send the resourse. name or path </param>
        /// <param name="imageAlert"> image for image in box , you can send the resourse. name or path </param>
        /// <param name="titleApplication"> Title of application , this be in bottom center on box  </param>
        /// <param name="ExTitle"> title of execption </param>
        /// <param name="txtMsg"> content of Message </param>
        /// <returns> </returns>
        public Form AlertsBoxSuccessful(Bitmap imagebrand, Bitmap imageAlert, string titleApplication, string ExTitle, string txtMsg)
        {
            #region Dailog
            form = new Form();
            Panel pn1 = new System.Windows.Forms.Panel();
            Panel pn2 = new System.Windows.Forms.Panel();
            Panel pn3 = new System.Windows.Forms.Panel();
            Button btnExit = new System.Windows.Forms.Button();
            PictureBox picWarning = new System.Windows.Forms.PictureBox();
            TextBox txtMessage = new System.Windows.Forms.TextBox();
            PictureBox picBrand = new System.Windows.Forms.PictureBox();
            Label lblTitle = new System.Windows.Forms.Label();
            Label lblApplicationName = new System.Windows.Forms.Label();

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            pn1 = new System.Windows.Forms.Panel();
            pn2 = new System.Windows.Forms.Panel();
            pn3 = new System.Windows.Forms.Panel();
            btnExit = new System.Windows.Forms.Button();
            picWarning = new System.Windows.Forms.PictureBox();
            txtMessage = new System.Windows.Forms.TextBox();
            picBrand = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblApplicationName = new System.Windows.Forms.Label();
            pn1.SuspendLayout();
            pn2.SuspendLayout();
            pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).BeginInit();
            form.SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = System.Drawing.Color.White;
            pn1.Controls.Add(txtMessage);
            pn1.Controls.Add(picWarning);
            pn1.Controls.Add(pn3);
            pn1.Controls.Add(pn2);
            pn1.Location = new System.Drawing.Point(8, 1);
            pn1.Name = "pn1";
            pn1.Size = new System.Drawing.Size(455, 173);
            pn1.TabIndex = 0;
            // 
            // pn2
            // 
            pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn2.Controls.Add(lblApplicationName);
            pn2.Controls.Add(picBrand);
            pn2.Controls.Add(btnExit);
            pn2.Location = new System.Drawing.Point(1, 0);
            pn2.Name = "pn2";
            pn2.Size = new System.Drawing.Size(454, 40);
            pn2.TabIndex = 0;
            // 
            // pn3
            // 
            pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn3.Controls.Add(lblTitle);
            pn3.Location = new System.Drawing.Point(1, 133);
            pn3.Name = "pn3";
            pn3.Size = new System.Drawing.Size(454, 40);
            pn3.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            btnExit.Location = new System.Drawing.Point(424, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(25, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // picWarning
            // 
            picWarning.Image = ((System.Drawing.Image)(imageAlert));
            picWarning.Location = new System.Drawing.Point(4, 46);
            picWarning.Name = "picWarning";
            picWarning.Size = new System.Drawing.Size(70, 81);
            picWarning.TabIndex = 2;
            picWarning.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMessage.Location = new System.Drawing.Point(80, 46);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtMessage.Size = new System.Drawing.Size(365, 81);
            txtMessage.TabIndex = 3;
            txtMessage.ReadOnly = true;
            txtMessage.BackColor = System.Drawing.Color.White;
            // 
            // picBrand
            // 
            picBrand.Image = ((System.Drawing.Image)(imagebrand));
            picBrand.Location = new System.Drawing.Point(3, 4);
            picBrand.Name = "picBrand";
            picBrand.Size = new System.Drawing.Size(35, 30);
            picBrand.TabIndex = 1;
            picBrand.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("TheSansArabic Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(127, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTitle.Size = new System.Drawing.Size(201, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = ExTitle;
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApplicationName.Location = new System.Drawing.Point(58, 12);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new System.Drawing.Size(124, 14);
            lblApplicationName.TabIndex = 2;
            lblApplicationName.Text = titleApplication + " | ";
            // 
            // Form1
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(184)))), ((int)(((byte)(11)))));
            form.ClientSize = new System.Drawing.Size(465, 175);
            form.Controls.Add(pn1);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = "Form1";
            form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Text = "Form1";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn3.ResumeLayout(false);
            pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).EndInit();
            form.ResumeLayout(false);

            #endregion



            txtMessage.Text = txtMsg;
            form.RightToLeftLayout = true;
            form.RightToLeft = RightToLeft.Yes;

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.GetWorkingArea(form);
            form.Location = new Point(workingArea.Right - form.Size.Width - 20,
                                      workingArea.Bottom - form.Size.Height - 20);

            btnExit.Click += BtnExit_Click;


            Form dialogResult = form;
            return dialogResult;

        }
        /// <summary>
        /// call this for Informative box
        /// </summary>
        /// <param name="imagebrand"> image for application , you can send the resourse. name or path </param>
        /// <param name="imageAlert"> image for image in box , you can send the resourse. name or path </param>
        /// <param name="titleApplication"> Title of application , this be in bottom center on box  </param>
        /// <param name="ExTitle"> title of execption </param>
        /// <param name="txtMsg"> content of Message </param>
        /// <returns> </returns>
        public Form AlertsBoxInfo(Bitmap imagebrand, Bitmap imageAlert, string titleApplication, string ExTitle, string txtMsg)
        {
            #region Dailog
            form = new Form();
            Panel pn1 = new System.Windows.Forms.Panel();
            Panel pn2 = new System.Windows.Forms.Panel();
            Panel pn3 = new System.Windows.Forms.Panel();
            Button btnExit = new System.Windows.Forms.Button();
            PictureBox picWarning = new System.Windows.Forms.PictureBox();
            TextBox txtMessage = new System.Windows.Forms.TextBox();
            PictureBox picBrand = new System.Windows.Forms.PictureBox();
            Label lblTitle = new System.Windows.Forms.Label();
            Label lblApplicationName = new System.Windows.Forms.Label();

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            pn1 = new System.Windows.Forms.Panel();
            pn2 = new System.Windows.Forms.Panel();
            pn3 = new System.Windows.Forms.Panel();
            btnExit = new System.Windows.Forms.Button();
            picWarning = new System.Windows.Forms.PictureBox();
            txtMessage = new System.Windows.Forms.TextBox();
            picBrand = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblApplicationName = new System.Windows.Forms.Label();
            pn1.SuspendLayout();
            pn2.SuspendLayout();
            pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).BeginInit();
            form.SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = System.Drawing.Color.White;
            pn1.Controls.Add(txtMessage);
            pn1.Controls.Add(picWarning);
            pn1.Controls.Add(pn3);
            pn1.Controls.Add(pn2);
            pn1.Location = new System.Drawing.Point(8, 1);
            pn1.Name = "pn1";
            pn1.Size = new System.Drawing.Size(455, 173);
            pn1.TabIndex = 0;
            // 
            // pn2
            // 
            pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn2.Controls.Add(lblApplicationName);
            pn2.Controls.Add(picBrand);
            pn2.Controls.Add(btnExit);
            pn2.Location = new System.Drawing.Point(1, 0);
            pn2.Name = "pn2";
            pn2.Size = new System.Drawing.Size(454, 40);
            pn2.TabIndex = 0;
            // 
            // pn3
            // 
            pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn3.Controls.Add(lblTitle);
            pn3.Location = new System.Drawing.Point(1, 133);
            pn3.Name = "pn3";
            pn3.Size = new System.Drawing.Size(454, 40);
            pn3.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            btnExit.Location = new System.Drawing.Point(424, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(25, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // picWarning
            // 
            picWarning.Image = ((System.Drawing.Image)(imageAlert));
            picWarning.Location = new System.Drawing.Point(4, 46);
            picWarning.Name = "picWarning";
            picWarning.Size = new System.Drawing.Size(70, 81);
            picWarning.TabIndex = 2;
            picWarning.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMessage.Location = new System.Drawing.Point(80, 46);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtMessage.Size = new System.Drawing.Size(365, 81);
            txtMessage.TabIndex = 3;
            txtMessage.ReadOnly = true;
            txtMessage.BackColor = System.Drawing.Color.White;
            // 
            // picBrand
            // 
            picBrand.Image = ((System.Drawing.Image)(imagebrand));
            picBrand.Location = new System.Drawing.Point(3, 4);
            picBrand.Name = "picBrand";
            picBrand.Size = new System.Drawing.Size(35, 30);
            picBrand.TabIndex = 1;
            picBrand.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("TheSansArabic Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(127, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTitle.Size = new System.Drawing.Size(201, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = ExTitle;
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApplicationName.Location = new System.Drawing.Point(58, 12);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new System.Drawing.Size(124, 14);
            lblApplicationName.TabIndex = 2;
            lblApplicationName.Text = titleApplication + " | ";
            // 
            // Form1
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            form.ClientSize = new System.Drawing.Size(465, 175);
            form.Controls.Add(pn1);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = "Form1";
            form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Text = "Form1";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn3.ResumeLayout(false);
            pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).EndInit();
            form.ResumeLayout(false);

            #endregion



            txtMessage.Text = txtMsg;
            form.RightToLeftLayout = true;
            form.RightToLeft = RightToLeft.Yes;

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.GetWorkingArea(form);
            form.Location = new Point(workingArea.Right - form.Size.Width - 20,
                                      workingArea.Bottom - form.Size.Height - 20);

            btnExit.Click += BtnExit_Click;


            Form dialogResult = form;
            return dialogResult;

        }

        /// <summary>
        /// call this for Informative box
        /// </summary>
        /// <param name="imagebrand"> image for application , you can send the resourse. name or path </param>
        /// <param name="imageAlert"> image for image in box , you can send the resourse. name or path </param>
        /// <param name="titleApplication"> Title of application , this be in bottom center on box  </param>
        /// <param name="ExTitle"> title of execption </param>
        /// <param name="txtMsg"> content of Message </param>
        /// <param name="colorOfBorder"> Send The HTML colors here you want by Ex: '#00000' </param>
        /// <returns> </returns>
        public Form AlertsBoxByMoreOptions(Bitmap imagebrand,Bitmap imageAlert,string titleApplication,string titleEx,string txtMsg,string colorOfBorder)
       {
            #region Dailog
            form = new Form();
            Panel pn1 = new System.Windows.Forms.Panel();
            Panel pn2 = new System.Windows.Forms.Panel();
            Panel pn3 = new System.Windows.Forms.Panel();
            Button btnExit = new System.Windows.Forms.Button();
            PictureBox picWarning = new System.Windows.Forms.PictureBox();
            TextBox txtMessage = new System.Windows.Forms.TextBox();
            PictureBox picBrand = new System.Windows.Forms.PictureBox();
            Label lblTitle = new System.Windows.Forms.Label();
            Label lblApplicationName = new System.Windows.Forms.Label();

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            pn1 = new System.Windows.Forms.Panel();
            pn2 = new System.Windows.Forms.Panel();
            pn3 = new System.Windows.Forms.Panel();
            btnExit = new System.Windows.Forms.Button();
            picWarning = new System.Windows.Forms.PictureBox();
            txtMessage = new System.Windows.Forms.TextBox();
            picBrand = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblApplicationName = new System.Windows.Forms.Label();
            pn1.SuspendLayout();
            pn2.SuspendLayout();
            pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).BeginInit();
            form.SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = System.Drawing.Color.White;
            pn1.Controls.Add(txtMessage);
            pn1.Controls.Add(picWarning);
            pn1.Controls.Add(pn3);
            pn1.Controls.Add(pn2);
            pn1.Location = new System.Drawing.Point(8, 1);
            pn1.Name = "pn1";
            pn1.Size = new System.Drawing.Size(455, 173);
            pn1.TabIndex = 0;
            // 
            // pn2
            // 
            pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn2.Controls.Add(lblApplicationName);
            pn2.Controls.Add(picBrand);
            pn2.Controls.Add(btnExit);
            pn2.Location = new System.Drawing.Point(1, 0);
            pn2.Name = "pn2";
            pn2.Size = new System.Drawing.Size(454, 40);
            pn2.TabIndex = 0;
            // 
            // pn3
            // 
            pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            pn3.Controls.Add(lblTitle);
            pn3.Location = new System.Drawing.Point(1, 133);
            pn3.Name = "pn3";
            pn3.Size = new System.Drawing.Size(454, 40);
            pn3.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            btnExit.Location = new System.Drawing.Point(424, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(25, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // picWarning
            // 
            picWarning.Image = ((System.Drawing.Image)(imageAlert));
            picWarning.Location = new System.Drawing.Point(4, 46);
            picWarning.Name = "picWarning";
            picWarning.Size = new System.Drawing.Size(70, 81);
            picWarning.TabIndex = 2;
            picWarning.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMessage.Location = new System.Drawing.Point(80, 46);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtMessage.Size = new System.Drawing.Size(365, 81);
            txtMessage.TabIndex = 3;
            txtMessage.ReadOnly = true;
            txtMessage.BackColor =  System.Drawing.Color.White;
            // 
            // picBrand
            // 
            picBrand.Image = ((System.Drawing.Image)(imagebrand));
            picBrand.Location = new System.Drawing.Point(3, 4);
            picBrand.Name = "picBrand";
            picBrand.Size = new System.Drawing.Size(35, 30);
            picBrand.TabIndex = 1;
            picBrand.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("TheSansArabic Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(127, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTitle.Size = new System.Drawing.Size(201, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "|" +titleEx + "|";
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApplicationName.Location = new System.Drawing.Point(58, 12);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new System.Drawing.Size(124, 14);
            lblApplicationName.TabIndex = 2;
            lblApplicationName.Text =  titleApplication +" | ";
            // 
            // Form1
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor =  System.Drawing.ColorTranslator.FromHtml(colorOfBorder);
            form.ClientSize = new System.Drawing.Size(465, 175);
            form.Controls.Add(pn1);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = "Form1";
            form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Text = "Form1";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn3.ResumeLayout(false);
            pn3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(picBrand)).EndInit();
            form.ResumeLayout(false);

            #endregion



            txtMessage.Text = txtMsg;
            form.RightToLeftLayout = true;
            form.RightToLeft = RightToLeft.Yes;

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.GetWorkingArea(form);
            form.Location = new Point(workingArea.Right - form.Size.Width - 20,
                                      workingArea.Bottom - form.Size.Height - 20);

            btnExit.Click += BtnExit_Click;


            Form dialogResult = form;
            return dialogResult;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            form.Close();
        }
        public void CloseAlert()
        {
            form.Close();
        }
    }
}
