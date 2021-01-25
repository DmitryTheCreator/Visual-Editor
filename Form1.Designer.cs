
namespace Visual_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.Panel();
            this.cmbxShape = new System.Windows.Forms.ComboBox();
            this.Instruments = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Instruments.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(12, 128);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1159, 537);
            this.Canvas.TabIndex = 0;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            // 
            // cmbxShape
            // 
            this.cmbxShape.BackColor = System.Drawing.Color.White;
            this.cmbxShape.DropDownWidth = 108;
            this.cmbxShape.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbxShape.FormattingEnabled = true;
            this.cmbxShape.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "Triangle"});
            this.cmbxShape.Location = new System.Drawing.Point(21, 22);
            this.cmbxShape.Name = "cmbxShape";
            this.cmbxShape.Size = new System.Drawing.Size(122, 33);
            this.cmbxShape.TabIndex = 16;
            this.cmbxShape.Text = "Figure";
            // 
            // Instruments
            // 
            this.Instruments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Instruments.BackColor = System.Drawing.Color.MediumPurple;
            this.Instruments.Controls.Add(this.cmbxShape);
            this.Instruments.Controls.Add(this.comboBox1);
            this.Instruments.Location = new System.Drawing.Point(12, 9);
            this.Instruments.Name = "Instruments";
            this.Instruments.Size = new System.Drawing.Size(1159, 113);
            this.Instruments.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownWidth = 108;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Квадрат",
            "Треугольник",
            "Круг"});
            this.comboBox1.Location = new System.Drawing.Point(183, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 33);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Фигура";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1183, 677);
            this.Controls.Add(this.Instruments);
            this.Controls.Add(this.Canvas);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Instruments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.ComboBox cmbxShape;
        private System.Windows.Forms.Panel Instruments;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

