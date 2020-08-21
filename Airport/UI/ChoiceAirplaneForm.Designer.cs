namespace Airport.UI
{
    partial class ChoiceAirplaneForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAirplanes = new System.Windows.Forms.DataGridView();
            this.ClmnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCarrying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPassengerCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFuelConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnRangeFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAssign = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplanes)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAirplanes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.532567F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.46743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvAirplanes
            // 
            this.dgvAirplanes.AllowUserToAddRows = false;
            this.dgvAirplanes.AllowUserToDeleteRows = false;
            this.dgvAirplanes.AllowUserToResizeRows = false;
            this.dgvAirplanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAirplanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAirplanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirplanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnModel,
            this.ClmnCarrying,
            this.ClmnPassengerCapacity,
            this.ClmnFuelConsumption,
            this.ClmnSpeed,
            this.ClmnRangeFlight});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAirplanes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAirplanes.EnableHeadersVisualStyles = false;
            this.dgvAirplanes.Location = new System.Drawing.Point(3, 7);
            this.dgvAirplanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirplanes.Name = "dgvAirplanes";
            this.dgvAirplanes.ReadOnly = true;
            this.dgvAirplanes.RowHeadersVisible = false;
            this.dgvAirplanes.RowTemplate.Height = 24;
            this.dgvAirplanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAirplanes.Size = new System.Drawing.Size(869, 374);
            this.dgvAirplanes.TabIndex = 1;
            this.dgvAirplanes.SelectionChanged += new System.EventHandler(this.dgvAirplanes_SelectionChanged);
            this.dgvAirplanes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvAirplanes_MouseUp);
            // 
            // ClmnModel
            // 
            this.ClmnModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnModel.FillWeight = 523.858F;
            this.ClmnModel.HeaderText = "Model";
            this.ClmnModel.Name = "ClmnModel";
            this.ClmnModel.ReadOnly = true;
            this.ClmnModel.Width = 120;
            // 
            // ClmnCarrying
            // 
            this.ClmnCarrying.FillWeight = 15.2284F;
            this.ClmnCarrying.HeaderText = "Carrying";
            this.ClmnCarrying.Name = "ClmnCarrying";
            this.ClmnCarrying.ReadOnly = true;
            // 
            // ClmnPassengerCapacity
            // 
            this.ClmnPassengerCapacity.FillWeight = 15.2284F;
            this.ClmnPassengerCapacity.HeaderText = "Passenger capacity";
            this.ClmnPassengerCapacity.Name = "ClmnPassengerCapacity";
            this.ClmnPassengerCapacity.ReadOnly = true;
            // 
            // ClmnFuelConsumption
            // 
            this.ClmnFuelConsumption.FillWeight = 15.2284F;
            this.ClmnFuelConsumption.HeaderText = "Fuel consumption";
            this.ClmnFuelConsumption.Name = "ClmnFuelConsumption";
            this.ClmnFuelConsumption.ReadOnly = true;
            // 
            // ClmnSpeed
            // 
            this.ClmnSpeed.FillWeight = 15.2284F;
            this.ClmnSpeed.HeaderText = "Speed";
            this.ClmnSpeed.Name = "ClmnSpeed";
            this.ClmnSpeed.ReadOnly = true;
            // 
            // ClmnRangeFlight
            // 
            this.ClmnRangeFlight.FillWeight = 15.2284F;
            this.ClmnRangeFlight.HeaderText = "Range flight";
            this.ClmnRangeFlight.Name = "ClmnRangeFlight";
            this.ClmnRangeFlight.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.84868F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.15132F));
            this.tableLayoutPanel2.Controls.Add(this.btCancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btAssign, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 385);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(869, 96);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancel.Font = new System.Drawing.Font("Calibri", 23.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(427, 2);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(439, 92);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAssign
            // 
            this.btAssign.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAssign.Enabled = false;
            this.btAssign.Font = new System.Drawing.Font("Calibri", 23.25F, System.Drawing.FontStyle.Italic);
            this.btAssign.Location = new System.Drawing.Point(3, 2);
            this.btAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAssign.Name = "btAssign";
            this.btAssign.Size = new System.Drawing.Size(418, 92);
            this.btAssign.TabIndex = 1;
            this.btAssign.Text = "Assign";
            this.btAssign.UseVisualStyleBackColor = true;
            this.btAssign.Click += new System.EventHandler(this.btAssign_Click);
            // 
            // ChoiceAirplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChoiceAirplaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceAirplaneForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplanes)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvAirplanes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCarrying;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPassengerCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnFuelConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnRangeFlight;
    }
}