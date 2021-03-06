﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Moway.Project.GraphicProject.Actions.AssignSpeed
{
    public partial class AssignSpeedPanel : ActionPanel
    {
        #region Attributes

        private AssignSpeedAction action;

        #endregion

        public AssignSpeedPanel(AssignSpeedAction action)
        {
            InitializeComponent();
            this.action = action;
        }

        protected override void LoadSettings()
        {
            if (this.action.AssignVariable != null)
                this.cbAssignVariable.SelectedItem = this.action.AssignVariable.Name;
            if (this.action.Wheel == Side.Left)
                this.rbLeftSpeed.Checked = true;
        }

        protected override void SaveSettings()
        {
            Variable variable = GraphManager.GetVariable(this.cbAssignVariable.SelectedItem.ToString());
            Side sensor = Side.Right;
            if (this.rbLeftSpeed.Checked)
                sensor = Side.Left;
            this.action.UpdateSettings(variable, sensor);
        }

        public override void AddVariable(Variable variable)
        {
            this.cbAssignVariable.Items.Add(variable.Name);
        }

        private void CbAssignVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.autoSave)
                this.SaveSettings();
        }

        private void RbSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.autoSave)
                this.SaveSettings();
        }
    }
}
