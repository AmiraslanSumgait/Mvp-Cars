namespace MVP.Views
{
    partial class MainView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxVendor = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.txtBoxTransmission = new System.Windows.Forms.TextBox();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnLoadCars = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Transmission";
            // 
            // txtBoxVendor
            // 
            this.txtBoxVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxVendor.Location = new System.Drawing.Point(374, 51);
            this.txtBoxVendor.Name = "txtBoxVendor";
            this.txtBoxVendor.Size = new System.Drawing.Size(203, 47);
            this.txtBoxVendor.TabIndex = 5;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxModel.Location = new System.Drawing.Point(374, 151);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(203, 47);
            this.txtBoxModel.TabIndex = 6;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxYear.Location = new System.Drawing.Point(374, 376);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(203, 47);
            this.txtBoxYear.TabIndex = 8;
            // 
            // txtBoxTransmission
            // 
            this.txtBoxTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxTransmission.Location = new System.Drawing.Point(374, 483);
            this.txtBoxTransmission.Name = "txtBoxTransmission";
            this.txtBoxTransmission.Size = new System.Drawing.Size(203, 47);
            this.txtBoxTransmission.TabIndex = 9;
            // 
            // listBoxCar
            // 
            this.listBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.ItemHeight = 37;
            this.listBoxCar.Location = new System.Drawing.Point(727, 46);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(343, 485);
            this.listBoxCar.TabIndex = 10;
            // 
            // btnAddCar
            // 
            this.btnAddCar.AutoSize = true;
            this.btnAddCar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCar.Location = new System.Drawing.Point(438, 573);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(146, 51);
            this.btnAddCar.TabIndex = 11;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnLoadCars
            // 
            this.btnLoadCars.AutoSize = true;
            this.btnLoadCars.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadCars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadCars.Location = new System.Drawing.Point(894, 573);
            this.btnLoadCars.Name = "btnLoadCars";
            this.btnLoadCars.Size = new System.Drawing.Size(176, 51);
            this.btnLoadCars.TabIndex = 12;
            this.btnLoadCars.Text = "Load Cars";
            this.btnLoadCars.UseVisualStyleBackColor = false;
            this.btnLoadCars.Click += new System.EventHandler(this.btnLoadCars_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(374, 266);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(203, 47);
            this.comboBoxColor.TabIndex = 13;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 693);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.btnLoadCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.listBoxCar);
            this.Controls.Add(this.txtBoxTransmission);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxVendor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxVendor;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.TextBox txtBoxTransmission;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnLoadCars;
        private System.Windows.Forms.ComboBox comboBoxColor;
    }
}