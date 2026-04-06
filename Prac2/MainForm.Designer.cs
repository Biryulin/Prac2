namespace Prac2
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.FLPTile = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNothing = new System.Windows.Forms.Label();
            this.buttonLeftx2 = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRightx2 = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FLPTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр продукции";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IvanovPrac2.Properties.Resources.beauty_logo;
            this.pictureBox1.Location = new System.Drawing.Point(723, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 10);
            this.panel1.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(54, 99);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(734, 20);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FLPTile
            // 
            this.FLPTile.Controls.Add(this.labelNothing);
            this.FLPTile.Location = new System.Drawing.Point(178, 136);
            this.FLPTile.Name = "FLPTile";
            this.FLPTile.Size = new System.Drawing.Size(456, 283);
            this.FLPTile.TabIndex = 6;
            // 
            // labelNothing
            // 
            this.labelNothing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNothing.AutoSize = true;
            this.labelNothing.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNothing.Location = new System.Drawing.Point(3, 0);
            this.labelNothing.Name = "labelNothing";
            this.labelNothing.Size = new System.Drawing.Size(133, 16);
            this.labelNothing.TabIndex = 0;
            this.labelNothing.Text = "Ничего не найдено";
            // 
            // buttonLeftx2
            // 
            this.buttonLeftx2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeftx2.Location = new System.Drawing.Point(13, 188);
            this.buttonLeftx2.Name = "buttonLeftx2";
            this.buttonLeftx2.Size = new System.Drawing.Size(36, 23);
            this.buttonLeftx2.TabIndex = 7;
            this.buttonLeftx2.Text = "<<";
            this.buttonLeftx2.UseVisualStyleBackColor = true;
            this.buttonLeftx2.Click += new System.EventHandler(this.buttonLeftx2_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(12, 217);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(34, 97);
            this.buttonLeft.TabIndex = 8;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRightx2
            // 
            this.buttonRightx2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRightx2.Location = new System.Drawing.Point(750, 188);
            this.buttonRightx2.Name = "buttonRightx2";
            this.buttonRightx2.Size = new System.Drawing.Size(38, 23);
            this.buttonRightx2.TabIndex = 9;
            this.buttonRightx2.Text = ">>";
            this.buttonRightx2.UseVisualStyleBackColor = true;
            this.buttonRightx2.Click += new System.EventHandler(this.buttonRightx2_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(750, 228);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(38, 108);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(310, 426);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(96, 16);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "0 из 0 Товаров";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonRightx2);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonLeftx2);
            this.Controls.Add(this.FLPTile);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Форма продукции";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FLPTile.ResumeLayout(false);
            this.FLPTile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel FLPTile;
        private System.Windows.Forms.Label labelNothing;
        private System.Windows.Forms.Button buttonLeftx2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRightx2;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelCount;
    }
}

