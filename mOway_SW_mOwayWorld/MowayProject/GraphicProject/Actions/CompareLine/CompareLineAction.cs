﻿using System;
using System.IO;
using System.Xml;

using Moway.Simulator;
using Moway.Project.GraphicProject.DiagramLayout.Elements;

namespace Moway.Project.GraphicProject.Actions.CompareLine
{
    public class CompareLineAction : Conditional
    {
        #region Attributes

        private Side lineSensor = Side.Right;
        private ComparativeOp operation = ComparativeOp.Equal;
        private Variable compareVariable = null;
        private int compareValue = 0;

        #endregion

        #region Properties

        public Side LineSensor { get { return this.lineSensor; } }
        public ComparativeOp Operation { get { return this.operation; } }
        public Variable CompareVariable { get { return this.compareVariable; } }
        public int CompareValue { get { return this.compareValue; } }

        #endregion

        public CompareLineAction(string key)
        {
            this.key = key;
        }

        public CompareLineAction(string key, Side lineSensor, ComparativeOp operation, Variable compareVariable, int compareValue)
        {
            this.key = key;
            this.lineSensor = lineSensor;
            this.operation = operation;
            this.compareVariable = compareVariable;
            this.compareValue = compareValue;
        }

        public CompareLineAction(string key, XmlElement properties, System.Collections.Generic.SortedList<string, Variable> variables)
        {
            this.key = key;
            if (properties.Name != "properties")
                throw new ActionException("Can't create the action");
            foreach (XmlElement property in properties.ChildNodes)
            {
                switch (property.Name)
                {
                    case "version":
                        break;
                    case "lineSensor":
                        this.lineSensor = (Side)Enum.Parse(typeof(Side), property.InnerText);
                        break;
                    case "operation":
                        this.operation = (ComparativeOp)Enum.Parse(typeof(ComparativeOp), property.InnerText);
                        break;
                    case "compareVariable":
                        if (property.InnerText != "none")
                            this.compareVariable = variables[property.InnerText];
                        break;
                    case "compareValue":
                        this.compareValue = System.Convert.ToInt32(property.InnerText);
                        break;
                    default:
                        throw new ProjectException("Error el crear la acción");
                }
            }
        }

        public void UpdateSettings(Side lineSensor, ComparativeOp operation, Variable compareVariable, int compareValue)
        {
            this.lineSensor = lineSensor;
            this.operation = operation;
            this.compareVariable = compareVariable;
            this.compareValue = compareValue;
        }

        public override bool VariableUsed(Variable variable)
        {
            if (this.compareVariable == variable)
                return true;
            else
                return false;
        }

        public override Element Clone()
        {
            return new CompareLineAction(this.key, this.lineSensor, this.operation, this.compareVariable, this.compareValue);
        }

        public override void SaveInFile(XmlWriter file)
        {
            file.WriteStartElement("properties");
            file.WriteElementString("version", "0.1");
            file.WriteElementString("lineSensor", this.lineSensor.ToString());
            file.WriteElementString("operation", this.operation.ToString());
            if (compareVariable == null)
                file.WriteElementString("compareVariable", "none");
            else
                file.WriteElementString("compareVariable", this.compareVariable.Name);
            file.WriteElementString("compareValue", this.compareValue.ToString());
            file.WriteEndElement();
        }

        public override void WriteCode(StreamWriter writer, string labelFalse)
        {
            writer.WriteLine(";***************Module Compare Line************************************");
            writer.WriteLine("");
            writer.WriteLine(";**********************************************************************");
            writer.WriteLine("");
            if (this.lineSensor == Side.Left)
            {
                writer.WriteLine("  call    SEN_LINE_ANALOG");
                writer.WriteLine("  movf    SEN_LINE_L" + ",W");
            }
            else if (this.lineSensor == Side.Right)
            {
                writer.WriteLine("  call    SEN_LINE_ANALOG");
                writer.WriteLine("  movf    SEN_LINE_R" + ",W");
            }

            switch (this.operation)
            {
                case ComparativeOp.Bigger:
                    if (this.compareVariable == null)
                    {
                        writer.WriteLine("  addlw   ." + (255 - this.compareValue));
                        writer.WriteLine("  btfss   STATUS,C");
                        writer.WriteLine(labelFalse);
                    }
                    else
                    {
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfsc   STATUS,C");
                        writer.WriteLine(labelFalse);
                    }
                    break;
                case ComparativeOp.BiggerEqual:
                    if (this.compareVariable == null)
                    {
                        writer.WriteLine("  movwf   AUX_01");
                        writer.WriteLine("  clrf    AUX_00");
                        writer.WriteLine("  addlw   ." + (255 - this.compareValue));
                        writer.WriteLine("  btfss   STATUS,C");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  movf    AUX_01,W");
                        writer.WriteLine("  sublw   ." + (this.compareValue));
                        writer.WriteLine("  btfss   STATUS,Z");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  btfsc   AUX_00,1");
                        writer.WriteLine(labelFalse);
                    }
                    else
                    {
                        writer.WriteLine("  movwf   AUX_01");
                        writer.WriteLine("  clrf    AUX_00");
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfsc   STATUS,C");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  movf    AUX_01,W");
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfss   STATUS,Z");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  btfsc   AUX_00,1");
                        writer.WriteLine(labelFalse);
                    }
                    break;
                case ComparativeOp.Distinct:
                    if (this.compareVariable == null)
                    {
                        writer.WriteLine("  sublw   ." + (this.compareValue));
                        writer.WriteLine("  btfsc   STATUS,Z");
                        writer.WriteLine(labelFalse);
                    }
                    else
                    {
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfsc   STATUS,Z");
                        writer.WriteLine(labelFalse);
                    }

                    break;
                case ComparativeOp.Equal:
                    if (this.compareVariable == null)
                    {
                        writer.WriteLine("  sublw   ." + (this.compareValue));
                        writer.WriteLine("  btfss   STATUS,Z");
                        writer.WriteLine(labelFalse);
                    }
                    else
                    {
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfss   STATUS,Z");
                        writer.WriteLine(labelFalse);
                    }
                    break;
                case ComparativeOp.Smaller:
                    if (this.compareVariable == null)
                    {
                        writer.WriteLine("  addlw   ." + (255 - this.compareValue + 1));
                        writer.WriteLine("  btfsc   STATUS,C");
                        writer.WriteLine(labelFalse);
                    }
                    else
                    {
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfss   STATUS,C");
                        writer.WriteLine(labelFalse);
                    }
                    break;
                case ComparativeOp.SmallerEqual:
                    if (this.compareVariable == null)
                    {
                        writer.WriteLine("  movwf   AUX_01");
                        writer.WriteLine("  clrf    AUX_00");
                        writer.WriteLine("  addlw   ." + (255 - this.compareValue + 1));
                        writer.WriteLine("  btfsc   STATUS,C");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  movf    AUX_01,W");
                        writer.WriteLine("  sublw   ." + (this.compareValue));
                        writer.WriteLine("  btfss   STATUS,Z");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  btfsc   AUX_00,1");
                        writer.WriteLine(labelFalse);
                    }
                    else
                    {
                        writer.WriteLine("  movwf   AUX_01");
                        writer.WriteLine("  clrf    AUX_00");
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfss   STATUS,C");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  movf    AUX_01,W");
                        writer.WriteLine("  subwf   " + this.compareVariable.Name + ",W");
                        writer.WriteLine("  btfss   STATUS,Z");
                        writer.WriteLine("  incf    AUX_00,F");
                        writer.WriteLine("  btfsc   AUX_00,1");
                        writer.WriteLine(labelFalse);
                    }
                    break;
                default:
                    writer.WriteLine("; Not allowed");
                    break;
            }
            writer.WriteLine("");
            writer.WriteLine(";***********************************************************************");

        }

        public override bool Simulate(MowayModel mowayModel)
        {
            int modelValueAux = 0;
            int compareValueAux = 0;

            // Save sensor model value
            if (this.lineSensor == Side.Right)
                modelValueAux = mowayModel.LineSensors.RightSensor;
            else
                modelValueAux = mowayModel.LineSensors.LeftSensor;

            // Save value to compare with
            if (this.compareVariable == null)
                compareValueAux = this.compareValue;
            else
                compareValueAux = mowayModel.GetRegister(this.compareVariable.Name).Value;


            switch (this.operation)
            {
                case ComparativeOp.Bigger:
                    if (modelValueAux > compareValueAux)
                        return true;
                    else
                        return false;

                case ComparativeOp.BiggerEqual:
                    if (modelValueAux >= compareValueAux)
                        return true;
                    else
                        return false;

                case ComparativeOp.Distinct:
                    if (modelValueAux != compareValueAux)
                        return true;
                    else
                        return false;

                case ComparativeOp.Equal:
                    if (modelValueAux == compareValueAux)
                        return true;
                    else
                        return false;

                case ComparativeOp.Smaller:
                    if (modelValueAux < compareValueAux)
                        return true;
                    else
                        return false;

                case ComparativeOp.SmallerEqual:
                    if (modelValueAux <= compareValueAux)
                        return true;
                    else
                        return false;

                default:
                    return false;
            }
        }
    }
}
