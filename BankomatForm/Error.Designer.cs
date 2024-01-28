namespace BankomatForm
{
    partial class ErrorNoBalans
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
            errorFormBalansLB = new Label();
            ErrorBalans_2_LB = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // errorFormBalansLB
            // 
            errorFormBalansLB.AutoSize = true;
            errorFormBalansLB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorFormBalansLB.ForeColor = SystemColors.ButtonFace;
            errorFormBalansLB.Location = new Point(12, 22);
            errorFormBalansLB.Name = "errorFormBalansLB";
            errorFormBalansLB.Size = new Size(111, 40);
            errorFormBalansLB.TabIndex = 0;
            errorFormBalansLB.Text = "Недостаточно \r\nсредств";
            // 
            // ErrorBalans_2_LB
            // 
            ErrorBalans_2_LB.AutoSize = true;
            ErrorBalans_2_LB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorBalans_2_LB.ForeColor = SystemColors.ButtonFace;
            ErrorBalans_2_LB.Location = new Point(370, 22);
            ErrorBalans_2_LB.Name = "ErrorBalans_2_LB";
            ErrorBalans_2_LB.Size = new Size(65, 60);
            ErrorBalans_2_LB.TabIndex = 1;
            ErrorBalans_2_LB.Text = "Введите\r\nдругую \r\nсумму";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(406, 125);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "ОТМЕНА";
            label1.Click += label1_Click;
            // 
            // ErrorNoBalans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = Properties.Resources.cray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(488, 176);
            Controls.Add(label1);
            Controls.Add(ErrorBalans_2_LB);
            Controls.Add(errorFormBalansLB);
            Location = new Point(162, 29);
            Name = "ErrorNoBalans";
            Text = "ОШИБКА";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorFormBalansLB;
        private Label ErrorBalans_2_LB;
        private Label label1;
    }
}