namespace RPG
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
            this.btnNextBattle = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacterLevel = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyItem = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.lblCharacterXP = new System.Windows.Forms.Label();
            this.lblCharacterHP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextBattle
            // 
            this.btnNextBattle.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBattle.Location = new System.Drawing.Point(304, 64);
            this.btnNextBattle.Name = "btnNextBattle";
            this.btnNextBattle.Size = new System.Drawing.Size(129, 40);
            this.btnNextBattle.TabIndex = 0;
            this.btnNextBattle.Text = "Next Battle";
            this.btnNextBattle.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(304, 110);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(129, 40);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(304, 185);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(129, 43);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseItem.Location = new System.Drawing.Point(304, 234);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(129, 45);
            this.btnUseItem.TabIndex = 3;
            this.btnUseItem.Text = "Use Item";
            this.btnUseItem.UseVisualStyleBackColor = true;
            // 
            // pbCharacter
            // 
            this.pbCharacter.Image = global::RPG.Properties.Resources.lecter;
            this.pbCharacter.Location = new System.Drawing.Point(92, 64);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(206, 242);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 4;
            this.pbCharacter.TabStop = false;
            // 
            // pbEnemy
            // 
            this.pbEnemy.Image = global::RPG.Properties.Resources.Pennywise_the_clown;
            this.pbEnemy.Location = new System.Drawing.Point(439, 64);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(212, 242);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy.TabIndex = 5;
            this.pbEnemy.TabStop = false;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(86, 30);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(77, 31);
            this.lblCharacterName.TabIndex = 6;
            this.lblCharacterName.Text = "Name";
            // 
            // lblCharacterLevel
            // 
            this.lblCharacterLevel.AutoSize = true;
            this.lblCharacterLevel.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterLevel.Location = new System.Drawing.Point(205, 30);
            this.lblCharacterLevel.Name = "lblCharacterLevel";
            this.lblCharacterLevel.Size = new System.Drawing.Size(93, 31);
            this.lblCharacterLevel.TabIndex = 7;
            this.lblCharacterLevel.Text = ":[Level]";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.Location = new System.Drawing.Point(461, 30);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(153, 31);
            this.lblEnemyName.TabIndex = 8;
            this.lblEnemyName.Text = "Enemy Name";
            // 
            // lblEnemyItem
            // 
            this.lblEnemyItem.AutoSize = true;
            this.lblEnemyItem.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyItem.Location = new System.Drawing.Point(383, 340);
            this.lblEnemyItem.Name = "lblEnemyItem";
            this.lblEnemyItem.Size = new System.Drawing.Size(188, 31);
            this.lblEnemyItem.TabIndex = 9;
            this.lblEnemyItem.Text = "Carrying: [Items]";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.Location = new System.Drawing.Point(447, 309);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(99, 31);
            this.lblEnemyHP.TabIndex = 10;
            this.lblEnemyHP.Text = "HP: ~0~";
            // 
            // lblCharacterXP
            // 
            this.lblCharacterXP.AutoSize = true;
            this.lblCharacterXP.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterXP.Location = new System.Drawing.Point(115, 340);
            this.lblCharacterXP.Name = "lblCharacterXP";
            this.lblCharacterXP.Size = new System.Drawing.Size(98, 31);
            this.lblCharacterXP.TabIndex = 11;
            this.lblCharacterXP.Text = "XP: ~0~";
            // 
            // lblCharacterHP
            // 
            this.lblCharacterHP.AutoSize = true;
            this.lblCharacterHP.Font = new System.Drawing.Font("Poor Richard", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterHP.Location = new System.Drawing.Point(113, 309);
            this.lblCharacterHP.Name = "lblCharacterHP";
            this.lblCharacterHP.Size = new System.Drawing.Size(99, 31);
            this.lblCharacterHP.TabIndex = 12;
            this.lblCharacterHP.Text = "HP: ~0~";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 69);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(304, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(129, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 419);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(276, 67);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCharacterHP);
            this.Controls.Add(this.lblCharacterXP);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.lblEnemyItem);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblCharacterLevel);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnNextBattle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextBattle;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblCharacterLevel;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyItem;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Label lblCharacterXP;
        private System.Windows.Forms.Label lblCharacterHP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

