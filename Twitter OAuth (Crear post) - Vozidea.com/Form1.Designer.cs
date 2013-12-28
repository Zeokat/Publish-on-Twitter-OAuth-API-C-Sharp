namespace Twitter_OAuth__Crear_post____Vozidea.com
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_consumerk = new System.Windows.Forms.TextBox();
            this.textBox_consumers = new System.Windows.Forms.TextBox();
            this.textBox_atoken = new System.Windows.Forms.TextBox();
            this.textBox_atokensecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_post = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumer Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumer Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Access Token";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Access Token Secret";
            // 
            // textBox_consumerk
            // 
            this.textBox_consumerk.Location = new System.Drawing.Point(93, 6);
            this.textBox_consumerk.Name = "textBox_consumerk";
            this.textBox_consumerk.Size = new System.Drawing.Size(438, 20);
            this.textBox_consumerk.TabIndex = 4;
            // 
            // textBox_consumers
            // 
            this.textBox_consumers.Location = new System.Drawing.Point(106, 32);
            this.textBox_consumers.Name = "textBox_consumers";
            this.textBox_consumers.Size = new System.Drawing.Size(425, 20);
            this.textBox_consumers.TabIndex = 5;
            // 
            // textBox_atoken
            // 
            this.textBox_atoken.Location = new System.Drawing.Point(94, 58);
            this.textBox_atoken.Name = "textBox_atoken";
            this.textBox_atoken.Size = new System.Drawing.Size(437, 20);
            this.textBox_atoken.TabIndex = 6;
            // 
            // textBox_atokensecret
            // 
            this.textBox_atokensecret.Location = new System.Drawing.Point(128, 84);
            this.textBox_atokensecret.Name = "textBox_atokensecret";
            this.textBox_atokensecret.Size = new System.Drawing.Size(403, 20);
            this.textBox_atokensecret.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Texto del Tweet (máximo 140 caracteres):";
            // 
            // textBox_post
            // 
            this.textBox_post.Location = new System.Drawing.Point(15, 128);
            this.textBox_post.MaxLength = 140;
            this.textBox_post.Multiline = true;
            this.textBox_post.Name = "textBox_post";
            this.textBox_post.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_post.Size = new System.Drawing.Size(516, 62);
            this.textBox_post.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar Tweet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_post);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_atokensecret);
            this.Controls.Add(this.textBox_atoken);
            this.Controls.Add(this.textBox_consumers);
            this.Controls.Add(this.textBox_consumerk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Twitter OAuth (Crear Post) - Vozidea.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_consumerk;
        private System.Windows.Forms.TextBox textBox_consumers;
        private System.Windows.Forms.TextBox textBox_atoken;
        private System.Windows.Forms.TextBox textBox_atokensecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_post;
        private System.Windows.Forms.Button button1;
    }
}

