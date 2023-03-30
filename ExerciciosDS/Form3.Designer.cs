namespace ExerciciosDS
{
    partial class frmexercicio2
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcularwhile = new System.Windows.Forms.Button();
            this.btncalculardowhile = new System.Windows.Forms.Button();
            this.btncalcularfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(69, 79);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(421, 24);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite o número da tabuada que deseja calcular: ";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(69, 154);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(133, 24);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "O resultado é: ";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(496, 79);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(138, 29);
            this.txtnum.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(208, 154);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtresult.Size = new System.Drawing.Size(426, 174);
            this.txtresult.TabIndex = 3;
            // 
            // btncalcularwhile
            // 
            this.btncalcularwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularwhile.Location = new System.Drawing.Point(73, 366);
            this.btncalcularwhile.Name = "btncalcularwhile";
            this.btncalcularwhile.Size = new System.Drawing.Size(104, 37);
            this.btncalcularwhile.TabIndex = 4;
            this.btncalcularwhile.Text = "Calcular ";
            this.btncalcularwhile.UseVisualStyleBackColor = true;
            this.btncalcularwhile.Click += new System.EventHandler(this.btncalcularwhile_Click);
            // 
            // btncalculardowhile
            // 
            this.btncalculardowhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculardowhile.Location = new System.Drawing.Point(211, 366);
            this.btncalculardowhile.Name = "btncalculardowhile";
            this.btncalculardowhile.Size = new System.Drawing.Size(104, 37);
            this.btncalculardowhile.TabIndex = 5;
            this.btncalculardowhile.Text = "Calcular";
            this.btncalculardowhile.UseVisualStyleBackColor = true;
            this.btncalculardowhile.Click += new System.EventHandler(this.btncalculardowhile_Click);
            // 
            // btncalcularfor
            // 
            this.btncalcularfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularfor.Location = new System.Drawing.Point(345, 366);
            this.btncalcularfor.Name = "btncalcularfor";
            this.btncalcularfor.Size = new System.Drawing.Size(104, 37);
            this.btncalcularfor.TabIndex = 6;
            this.btncalcularfor.Text = "Calcular";
            this.btncalcularfor.UseVisualStyleBackColor = true;
            this.btncalcularfor.Click += new System.EventHandler(this.btncalcularfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(480, 366);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(104, 37);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(631, 366);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(104, 37);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmexercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcularfor);
            this.Controls.Add(this.btncalculardowhile);
            this.Controls.Add(this.btncalcularwhile);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Name = "frmexercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcularwhile;
        private System.Windows.Forms.Button btncalculardowhile;
        private System.Windows.Forms.Button btncalcularfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}