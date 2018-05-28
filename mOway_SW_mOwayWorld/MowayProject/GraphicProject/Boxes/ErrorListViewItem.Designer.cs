﻿namespace Moway.Project.GraphicProject.Boxes
{
    partial class ErrorListViewItem
    {
        /// <summary> 
        /// Variable of the designer required.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean the resources that are being used.
        /// </summary>
        /// <param name="disposing">true if the managed resources should be removed; false otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code generated by the Component Designer

        /// <summary> 
        /// Method necessary to support the Designer. It can not be modified 
        /// the content of the method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorListViewItem));
            this.lDiagram = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lDiagram
            // 
            this.lDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lDiagram.Location = new System.Drawing.Point(155, 0);
            this.lDiagram.Name = "lDiagram";
            this.lDiagram.Size = new System.Drawing.Size(100, 18);
            this.lDiagram.TabIndex = 0;
            this.lDiagram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lDiagram.Click += new System.EventHandler(this.DiagramErrorItem_Click);
            // 
            // lDescription
            // 
            this.lDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lDescription.Location = new System.Drawing.Point(20, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(134, 18);
            this.lDescription.TabIndex = 1;
            this.lDescription.Click += new System.EventHandler(this.DiagramErrorItem_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbIcon.Location = new System.Drawing.Point(4, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(12, 12);
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.DiagramErrorItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "error.png");
            this.imageList.Images.SetKeyName(1, "warning.png");
            // 
            // DiagramErrorItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lDiagram);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DiagramErrorItem";
            this.Size = new System.Drawing.Size(255, 18);
            this.Click += new System.EventHandler(this.DiagramErrorItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lDiagram;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ImageList imageList;
    }
}