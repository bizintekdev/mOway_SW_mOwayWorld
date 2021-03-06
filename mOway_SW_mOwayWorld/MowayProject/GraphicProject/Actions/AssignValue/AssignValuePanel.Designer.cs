﻿namespace Moway.Project.GraphicProject.Actions.AssignValue
{
    partial class AssignValuePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignValuePanel));
            this.cbVariable = new Moway.Template.Controls.MowayComboBox();
            this.lVariable = new System.Windows.Forms.Label();
            this.cbAsignVariable = new Moway.Template.Controls.MowayComboBox();
            this.nudValue = new Moway.Template.Controls.MowayNumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lValueHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lActionName
            // 
            resources.ApplyResources(this.lActionName, "lActionName");
            // 
            // cbVariable
            // 
            this.cbVariable.BackColor = System.Drawing.Color.White;
            this.cbVariable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVariable.DropDownHeight = 100;
            this.cbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbVariable, "cbVariable");
            this.cbVariable.FormattingEnabled = true;
            this.cbVariable.Items.AddRange(new object[] {
            resources.GetString("cbVariable.Items")});
            this.cbVariable.Name = "cbVariable";
            this.cbVariable.SelectedIndexChanged += new System.EventHandler(this.CbVariable_SelectedIndexChanged);
            // 
            // lVariable
            // 
            resources.ApplyResources(this.lVariable, "lVariable");
            this.lVariable.Name = "lVariable";
            // 
            // cbAsignVariable
            // 
            this.cbAsignVariable.BackColor = System.Drawing.Color.White;
            this.cbAsignVariable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignVariable.DropDownHeight = 100;
            this.cbAsignVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbAsignVariable, "cbAsignVariable");
            this.cbAsignVariable.FormattingEnabled = true;
            this.cbAsignVariable.Name = "cbAsignVariable";
            this.cbAsignVariable.SelectedIndexChanged += new System.EventHandler(this.CbAsignVariable_SelectedIndexChanged);
            // 
            // nudValue
            // 
            this.nudValue.BackColor = System.Drawing.Color.White;
            this.nudValue.DecimalPlaces = 0;
            resources.ApplyResources(this.nudValue, "nudValue");
            this.nudValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValue.ValueChanged += new System.EventHandler(this.NudValue_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lValueHelp
            // 
            resources.ApplyResources(this.lValueHelp, "lValueHelp");
            this.lValueHelp.Name = "lValueHelp";
            // 
            // AssignValuePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lValueHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVariable);
            this.Controls.Add(this.lVariable);
            this.Controls.Add(this.cbAsignVariable);
            this.Controls.Add(this.nudValue);
            this.Name = "AssignValuePanel";
            resources.ApplyResources(this, "$this");
            this.Controls.SetChildIndex(this.lActionName, 0);
            this.Controls.SetChildIndex(this.nudValue, 0);
            this.Controls.SetChildIndex(this.cbAsignVariable, 0);
            this.Controls.SetChildIndex(this.lVariable, 0);
            this.Controls.SetChildIndex(this.cbVariable, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lValueHelp, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Moway.Template.Controls.MowayComboBox cbVariable;
        private System.Windows.Forms.Label lVariable;
        private Moway.Template.Controls.MowayComboBox cbAsignVariable;
        private Moway.Template.Controls.MowayNumericUpDown nudValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lValueHelp;
    }
}
