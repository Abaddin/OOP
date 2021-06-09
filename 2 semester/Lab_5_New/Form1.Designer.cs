
namespace WindowsFormsApp1
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rhomb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(894, 91);
            this.circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(149, 50);
            this.circle.TabIndex = 1;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(894, 15);
            this.square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(149, 50);
            this.square.TabIndex = 2;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rhomb
            // 
            this.rhomb.Location = new System.Drawing.Point(894, 171);
            this.rhomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rhomb.Name = "rhomb";
            this.rhomb.Size = new System.Drawing.Size(149, 50);
            this.rhomb.TabIndex = 3;
            this.rhomb.Text = "Rhomb";
            this.rhomb.UseVisualStyleBackColor = true;
            this.rhomb.Click += new System.EventHandler(this.rhomb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(1, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 391);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rhomb);
            this.Controls.Add(this.square);
            this.Controls.Add(this.circle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button rhomb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

