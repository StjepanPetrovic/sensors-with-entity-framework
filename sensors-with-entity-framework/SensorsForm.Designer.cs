namespace sensors_with_entity_framework
{
    partial class SensorsForm
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
            this.dgcSensors = new System.Windows.Forms.DataGridView();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcSensors
            // 
            this.dgcSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcSensors.Location = new System.Drawing.Point(29, 27);
            this.dgcSensors.Name = "dgcSensors";
            this.dgcSensors.RowHeadersWidth = 51;
            this.dgcSensors.RowTemplate.Height = 24;
            this.dgcSensors.Size = new System.Drawing.Size(741, 330);
            this.dgcSensors.TabIndex = 0;
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Location = new System.Drawing.Point(29, 381);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(154, 36);
            this.btnAddSensor.TabIndex = 1;
            this.btnAddSensor.Text = "Add sensor";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSensor
            // 
            this.btnDeleteSensor.Location = new System.Drawing.Point(616, 381);
            this.btnDeleteSensor.Name = "btnDeleteSensor";
            this.btnDeleteSensor.Size = new System.Drawing.Size(154, 36);
            this.btnDeleteSensor.TabIndex = 2;
            this.btnDeleteSensor.Text = "Delete sensor";
            this.btnDeleteSensor.UseVisualStyleBackColor = true;
            // 
            // SensorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteSensor);
            this.Controls.Add(this.btnAddSensor);
            this.Controls.Add(this.dgcSensors);
            this.Name = "SensorsForm";
            this.Text = "Sensors";
            ((System.ComponentModel.ISupportInitialize)(this.dgcSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcSensors;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.Button btnDeleteSensor;
    }
}

