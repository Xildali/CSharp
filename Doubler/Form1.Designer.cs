
namespace Doubler
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
            this.btnInc = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbGuessNumber = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOperations = new System.Windows.Forms.Label();
            this.lbCurrentNumber = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(15, 80);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(75, 23);
            this.btnInc.TabIndex = 0;
            this.btnInc.Text = "+1";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(96, 80);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "x2";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(269, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbGuessNumber
            // 
            this.lbGuessNumber.AutoSize = true;
            this.lbGuessNumber.Location = new System.Drawing.Point(144, 9);
            this.lbGuessNumber.Name = "lbGuessNumber";
            this.lbGuessNumber.Size = new System.Drawing.Size(13, 13);
            this.lbGuessNumber.TabIndex = 3;
            this.lbGuessNumber.Text = "0";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(269, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Загаданное число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество операцций:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текущее число:";
            // 
            // lbOperations
            // 
            this.lbOperations.AutoSize = true;
            this.lbOperations.Location = new System.Drawing.Point(145, 31);
            this.lbOperations.Name = "lbOperations";
            this.lbOperations.Size = new System.Drawing.Size(35, 13);
            this.lbOperations.TabIndex = 8;
            this.lbOperations.Text = "label4";
            // 
            // lbCurrentNumber
            // 
            this.lbCurrentNumber.AutoSize = true;
            this.lbCurrentNumber.Location = new System.Drawing.Point(147, 53);
            this.lbCurrentNumber.Name = "lbCurrentNumber";
            this.lbCurrentNumber.Size = new System.Drawing.Size(35, 13);
            this.lbCurrentNumber.TabIndex = 9;
            this.lbCurrentNumber.Text = "label4";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(177, 80);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Отменить";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 122);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lbCurrentNumber);
            this.Controls.Add(this.lbOperations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbGuessNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnInc);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbGuessNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOperations;
        private System.Windows.Forms.Label lbCurrentNumber;
        private System.Windows.Forms.Button btnUndo;
    }
}

