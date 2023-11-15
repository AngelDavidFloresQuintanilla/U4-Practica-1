namespace U4_Practica_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPapas = new TextBox();
            txtRefresco = new TextBox();
            txtTe = new TextBox();
            txtSandwich = new TextBox();
            txtHotDog = new TextBox();
            txtHamburguesa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox7 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(15, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 429);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccion por pedidos";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 267);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(175, 36);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro pedido";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 209);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(436, 36);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "N.3 (Sandwich, Refresco, Papas fritas)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 144);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(423, 36);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "N.2 (Hot dog, Refresco, Papas fritas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 78);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(474, 36);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "N.1 (Hamburgesa, Refresco, Papas Fritas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtPapas);
            groupBox2.Controls.Add(txtRefresco);
            groupBox2.Controls.Add(txtTe);
            groupBox2.Controls.Add(txtSandwich);
            groupBox2.Controls.Add(txtHotDog);
            groupBox2.Controls.Add(txtHamburguesa);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(673, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 742);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alimentos seleccionados";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(350, 509);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(114, 75);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(350, 428);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(114, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(350, 349);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(350, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(350, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(350, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 548);
            label8.Name = "label8";
            label8.Size = new Size(133, 32);
            label8.TabIndex = 12;
            label8.Text = "Papas fritas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 471);
            label7.Name = "label7";
            label7.Size = new Size(104, 32);
            label7.TabIndex = 11;
            label7.Text = "Refresco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 392);
            label6.Name = "label6";
            label6.Size = new Size(38, 32);
            label6.TabIndex = 10;
            label6.Text = "Te";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 304);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 9;
            label5.Text = "Sandwich";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 234);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 8;
            label4.Text = "Hot dog";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 154);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 7;
            label3.Text = "Hamburgesa";
            // 
            // txtPapas
            // 
            txtPapas.Location = new Point(0, 545);
            txtPapas.Name = "txtPapas";
            txtPapas.Size = new Size(200, 39);
            txtPapas.TabIndex = 6;
            // 
            // txtRefresco
            // 
            txtRefresco.Location = new Point(0, 464);
            txtRefresco.Name = "txtRefresco";
            txtRefresco.Size = new Size(200, 39);
            txtRefresco.TabIndex = 5;
            // 
            // txtTe
            // 
            txtTe.Location = new Point(0, 389);
            txtTe.Name = "txtTe";
            txtTe.Size = new Size(200, 39);
            txtTe.TabIndex = 4;
            txtTe.TextChanged += textBox5_TextChanged;
            // 
            // txtSandwich
            // 
            txtSandwich.Location = new Point(0, 304);
            txtSandwich.Name = "txtSandwich";
            txtSandwich.Size = new Size(200, 39);
            txtSandwich.TabIndex = 3;
            // 
            // txtHotDog
            // 
            txtHotDog.Location = new Point(0, 231);
            txtHotDog.Name = "txtHotDog";
            txtHotDog.Size = new Size(200, 39);
            txtHotDog.TabIndex = 2;
            // 
            // txtHamburguesa
            // 
            txtHamburguesa.Location = new Point(0, 151);
            txtHamburguesa.Name = "txtHamburguesa";
            txtHamburguesa.Size = new Size(200, 39);
            txtHamburguesa.TabIndex = 1;
            txtHamburguesa.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 51);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 0;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 464);
            label1.Name = "label1";
            label1.Size = new Size(217, 37);
            label1.TabIndex = 2;
            label1.Text = "Total a cobrar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(73, 526);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 39);
            txtTotal.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(75, 613);
            button1.Name = "button1";
            button1.Size = new Size(185, 81);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(310, 613);
            button2.Name = "button2";
            button2.Size = new Size(173, 81);
            button2.TabIndex = 5;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(400, 444);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(200, 121);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 778);
            Controls.Add(pictureBox7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private TextBox txtTotal;
        private TextBox txtPapas;
        private TextBox txtRefresco;
        private TextBox txtTe;
        private TextBox txtSandwich;
        private TextBox txtHotDog;
        private TextBox txtHamburguesa;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
    }
}