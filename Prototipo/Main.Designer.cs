namespace Prototipo
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_Marca = new System.Windows.Forms.Panel();
            this.btn_Ord = new System.Windows.Forms.Button();
            this.btn_Cont = new System.Windows.Forms.Button();
            this.btn_Fran = new System.Windows.Forms.Button();
            this.btn_Sucursales = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pan_head = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pan_Marca);
            this.panel1.Controls.Add(this.btn_Ord);
            this.panel1.Controls.Add(this.btn_Cont);
            this.panel1.Controls.Add(this.btn_Fran);
            this.panel1.Controls.Add(this.btn_Sucursales);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 546);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // pan_Marca
            // 
            this.pan_Marca.BackColor = System.Drawing.Color.Red;
            this.pan_Marca.Location = new System.Drawing.Point(2, 205);
            this.pan_Marca.Name = "pan_Marca";
            this.pan_Marca.Size = new System.Drawing.Size(10, 28);
            this.pan_Marca.TabIndex = 1;
            // 
            // btn_Ord
            // 
            this.btn_Ord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Ord.FlatAppearance.BorderSize = 0;
            this.btn_Ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ord.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ord.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Ord.Image = global::Prototipo.Properties.Resources.bell;
            this.btn_Ord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ord.Location = new System.Drawing.Point(11, 315);
            this.btn_Ord.Name = "btn_Ord";
            this.btn_Ord.Size = new System.Drawing.Size(216, 28);
            this.btn_Ord.TabIndex = 6;
            this.btn_Ord.Text = "    Ordena en Línea";
            this.btn_Ord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ord.UseVisualStyleBackColor = false;
            this.btn_Ord.Click += new System.EventHandler(this.btn_Ord_Click);
            // 
            // btn_Cont
            // 
            this.btn_Cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Cont.FlatAppearance.BorderSize = 0;
            this.btn_Cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cont.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cont.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cont.Image = global::Prototipo.Properties.Resources.phone_call;
            this.btn_Cont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cont.Location = new System.Drawing.Point(12, 483);
            this.btn_Cont.Name = "btn_Cont";
            this.btn_Cont.Size = new System.Drawing.Size(216, 28);
            this.btn_Cont.TabIndex = 5;
            this.btn_Cont.Text = "    Contacto";
            this.btn_Cont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cont.UseVisualStyleBackColor = false;
            this.btn_Cont.Click += new System.EventHandler(this.btn_Cont_Click);
            // 
            // btn_Fran
            // 
            this.btn_Fran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Fran.FlatAppearance.BorderSize = 0;
            this.btn_Fran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fran.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fran.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Fran.Image = global::Prototipo.Properties.Resources.shop;
            this.btn_Fran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fran.Location = new System.Drawing.Point(11, 427);
            this.btn_Fran.Name = "btn_Fran";
            this.btn_Fran.Size = new System.Drawing.Size(216, 28);
            this.btn_Fran.TabIndex = 4;
            this.btn_Fran.Text = "    Franquicias";
            this.btn_Fran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fran.UseVisualStyleBackColor = false;
            this.btn_Fran.Click += new System.EventHandler(this.btn_Fran_Click);
            // 
            // btn_Sucursales
            // 
            this.btn_Sucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Sucursales.FlatAppearance.BorderSize = 0;
            this.btn_Sucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sucursales.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sucursales.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Sucursales.Image = global::Prototipo.Properties.Resources.restaurant;
            this.btn_Sucursales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sucursales.Location = new System.Drawing.Point(11, 371);
            this.btn_Sucursales.Name = "btn_Sucursales";
            this.btn_Sucursales.Size = new System.Drawing.Size(216, 28);
            this.btn_Sucursales.TabIndex = 3;
            this.btn_Sucursales.Text = "    Sucursales";
            this.btn_Sucursales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sucursales.UseVisualStyleBackColor = false;
            this.btn_Sucursales.Click += new System.EventHandler(this.btn_Sucursales_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Menu.Image = global::Prototipo.Properties.Resources.menu1;
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu.Location = new System.Drawing.Point(11, 259);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(216, 28);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "    Menú";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Home.Image = global::Prototipo.Properties.Resources.home;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(11, 203);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(216, 28);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "    Inicio";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pan_head
            // 
            this.pan_head.BackColor = System.Drawing.Color.Red;
            this.pan_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_head.Location = new System.Drawing.Point(228, 0);
            this.pan_head.Margin = new System.Windows.Forms.Padding(0);
            this.pan_head.Name = "pan_head";
            this.pan_head.Size = new System.Drawing.Size(832, 10);
            this.pan_head.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_Cerrar);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(228, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 150);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Oriental Wok";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cerrar.Image = global::Prototipo.Properties.Resources.turn_off;
            this.btn_Cerrar.Location = new System.Drawing.Point(725, 25);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(38, 34);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(24, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 140);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prototipo.Properties.Resources.Imagen2;
            this.pictureBox2.Location = new System.Drawing.Point(16, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prototipo.Properties.Resources.Imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(228, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 374);
            this.panel4.TabIndex = 9;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1060, 546);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pan_head);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan_head;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pan_Marca;
        private System.Windows.Forms.Button btn_Ord;
        private System.Windows.Forms.Button btn_Cont;
        private System.Windows.Forms.Button btn_Fran;
        private System.Windows.Forms.Button btn_Sucursales;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}