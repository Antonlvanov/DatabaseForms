﻿namespace Andmebass_TARpv23
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Kogus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nimetus_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.andmebaasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lisa_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otsipilt = new System.Windows.Forms.Button();
            this.connectDB_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmebaasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimetus";
            // 
            // Kogus
            // 
            this.Kogus.AutoSize = true;
            this.Kogus.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kogus.Location = new System.Drawing.Point(30, 99);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(77, 26);
            this.Kogus.TabIndex = 1;
            this.Kogus.Text = "Kogus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hind";
            // 
            // Nimetus_txt
            // 
            this.Nimetus_txt.Location = new System.Drawing.Point(142, 61);
            this.Nimetus_txt.Name = "Nimetus_txt";
            this.Nimetus_txt.Size = new System.Drawing.Size(119, 20);
            this.Nimetus_txt.TabIndex = 3;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(142, 99);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(119, 20);
            this.Kogus_txt.TabIndex = 4;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(142, 139);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(119, 20);
            this.Hind_txt.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 172);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lisa_btn
            // 
            this.lisa_btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisa_btn.Location = new System.Drawing.Point(35, 190);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(110, 40);
            this.lisa_btn.TabIndex = 7;
            this.lisa_btn.Text = "Lisa andmed";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kustuta_btn.Location = new System.Drawing.Point(151, 190);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(110, 40);
            this.kustuta_btn.TabIndex = 8;
            this.kustuta_btn.Text = "Kustuta";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            this.kustuta_btn.Click += new System.EventHandler(this.Kustuta_btn_Click);
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uuenda_btn.Location = new System.Drawing.Point(267, 190);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(110, 40);
            this.uuenda_btn.TabIndex = 9;
            this.uuenda_btn.Text = "Uuenda";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            this.uuenda_btn.Click += new System.EventHandler(this.Uuenda_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(516, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 153);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // otsipilt
            // 
            this.otsipilt.Location = new System.Drawing.Point(666, 197);
            this.otsipilt.Name = "otsipilt";
            this.otsipilt.Size = new System.Drawing.Size(99, 33);
            this.otsipilt.TabIndex = 11;
            this.otsipilt.Text = "Otsi pilt";
            this.otsipilt.UseVisualStyleBackColor = true;
            this.otsipilt.Click += new System.EventHandler(this.otsipilt_Click);
            // 
            // connectDB_btn
            // 
            this.connectDB_btn.Location = new System.Drawing.Point(556, 197);
            this.connectDB_btn.Name = "connectDB_btn";
            this.connectDB_btn.Size = new System.Drawing.Size(93, 33);
            this.connectDB_btn.TabIndex = 12;
            this.connectDB_btn.Text = "Lisa andmebaas";
            this.connectDB_btn.UseVisualStyleBackColor = true;
            this.connectDB_btn.Click += new System.EventHandler(this.connectDB_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectDB_btn);
            this.Controls.Add(this.otsipilt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Nimetus_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmebaasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Kogus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nimetus_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource andmebaasDataSetBindingSource;

        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button otsipilt;
        private System.Windows.Forms.Button connectDB_btn;
    }
}

