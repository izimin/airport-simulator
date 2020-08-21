namespace Airport.UI
{
    partial class Rent
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
            this.btOK = new System.Windows.Forms.Button();
            this.mtCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPriceRent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(231, 176);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(211, 38);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "ПОДТВЕРДИТЬ АРЕНДУ";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // mtCalendar
            // 
            this.mtCalendar.Location = new System.Drawing.Point(6, 7);
            this.mtCalendar.Name = "mtCalendar";
            this.mtCalendar.TabIndex = 5;
            this.mtCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mtCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "До какого дня Вы хотите \r\nвзять в аренду самолет?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена за один\r\nдень аренды:";
            // 
            // lbPriceRent
            // 
            this.lbPriceRent.AutoSize = true;
            this.lbPriceRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPriceRent.Location = new System.Drawing.Point(376, 74);
            this.lbPriceRent.Name = "lbPriceRent";
            this.lbPriceRent.Size = new System.Drawing.Size(0, 20);
            this.lbPriceRent.TabIndex = 7;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPriceRent);
            this.Controls.Add(this.mtCalendar);
            this.Controls.Add(this.btOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(487, 270);
            this.Name = "Rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.MonthCalendar mtCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPriceRent;
    }
}