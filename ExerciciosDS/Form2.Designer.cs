namespace ExerciciosDS
{
    partial class frmexercicio1
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
            this.lbllitros = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.bntlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllitros
            // 
            this.lbllitros.AutoSize = true;
            this.lbllitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllitros.Location = new System.Drawing.Point(110, 83);
            this.lbllitros.Name = "lbllitros";
            this.lbllitros.Size = new System.Drawing.Size(287, 26);
            this.lbllitros.TabIndex = 0;
            this.lbllitros.Text = "Digite a quantidade de litros:";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.Location = new System.Drawing.Point(110, 136);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(404, 26);
            this.lblcod.TabIndex = 1;
            this.lblcod.Text = "Digite A para Alcool ou G para Gasolina:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(110, 200);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(185, 26);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "O valor a pagar é:";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(164, 347);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(109, 46);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // bntlimpar
            // 
            this.bntlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntlimpar.Location = new System.Drawing.Point(332, 347);
            this.bntlimpar.Name = "bntlimpar";
            this.bntlimpar.Size = new System.Drawing.Size(109, 46);
            this.bntlimpar.TabIndex = 4;
            this.bntlimpar.Text = "Limpar";
            this.bntlimpar.UseVisualStyleBackColor = true;
            this.bntlimpar.Click += new System.EventHandler(this.bntlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(495, 347);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(109, 46);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // txtlitros
            // 
            this.txtlitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlitros.Location = new System.Drawing.Point(403, 84);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(302, 27);
            this.txtlitros.TabIndex = 7;
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(520, 137);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(185, 27);
            this.txtcod.TabIndex = 8;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(301, 201);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(404, 27);
            this.txtresult.TabIndex = 9;
            // 
            // frmexercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.bntlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lbllitros);
            this.Name = "frmexercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1";
            this.Load += new System.EventHandler(this.frmexercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllitros;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button bntlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtresult;
    }
}