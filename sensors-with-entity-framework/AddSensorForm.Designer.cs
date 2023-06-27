namespace sensors_with_entity_framework
{
    partial class AddSensorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddNewSensor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelNewSensor = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnAddNewSensor
            // 
            this.btnAddNewSensor.Location = new System.Drawing.Point(23, 142);
            this.btnAddNewSensor.Name = "btnAddNewSensor";
            this.btnAddNewSensor.Size = new System.Drawing.Size(135, 38);
            this.btnAddNewSensor.TabIndex = 2;
            this.btnAddNewSensor.Text = "Add";
            this.btnAddNewSensor.UseVisualStyleBackColor = true;
            this.btnAddNewSensor.Click += new System.EventHandler(this.btnAddNewSensor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit:";
            // 
            // btnCancelNewSensor
            // 
            this.btnCancelNewSensor.Location = new System.Drawing.Point(164, 142);
            this.btnCancelNewSensor.Name = "btnCancelNewSensor";
            this.btnCancelNewSensor.Size = new System.Drawing.Size(135, 38);
            this.btnCancelNewSensor.TabIndex = 7;
            this.btnCancelNewSensor.Text = "Cancel";
            this.btnCancelNewSensor.UseVisualStyleBackColor = true;
            this.btnCancelNewSensor.Click += new System.EventHandler(this.btnCancelNewSensor_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(111, 58);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 24);
            this.cbType.TabIndex = 8;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(111, 97);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(188, 24);
            this.cbUnit.TabIndex = 9;
            // 
            // AddSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 205);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCancelNewSensor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewSensor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddSensorForm";
            this.Text = "AddSensorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddNewSensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelNewSensor;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbUnit;
    }
}