namespace TurnBaseCombat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TitleLabel = new Label();
            TurnLabel = new Label();
            ImgHero = new PictureBox();
            ImgMonster = new PictureBox();
            pictureBox3 = new PictureBox();
            LabelDescrption = new Label();
            HeroLife = new Panel();
            HeroLifePoint = new Label();
            MonsterLife = new Panel();
            MonsterLifePoint = new Label();
            AttackButton = new Button();
            HealButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ImgHero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgMonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(152, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(498, 33);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "READY FOR THE BATTLE ADVENTURER";
            // 
            // TurnLabel
            // 
            TurnLabel.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TurnLabel.ForeColor = Color.White;
            TurnLabel.Location = new Point(284, 97);
            TurnLabel.Name = "TurnLabel";
            TurnLabel.Size = new Size(231, 27);
            TurnLabel.TabIndex = 1;
            TurnLabel.Text = "Placeholder Turno";
            TurnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImgHero
            // 
            ImgHero.Image = Properties.Resources.HeroNeutral;
            ImgHero.Location = new Point(73, 159);
            ImgHero.Name = "ImgHero";
            ImgHero.Size = new Size(183, 183);
            ImgHero.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgHero.TabIndex = 2;
            ImgHero.TabStop = false;
            // 
            // ImgMonster
            // 
            ImgMonster.Image = Properties.Resources.MonsterNeutral;
            ImgMonster.Location = new Point(537, 159);
            ImgMonster.Name = "ImgMonster";
            ImgMonster.Size = new Size(183, 183);
            ImgMonster.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgMonster.TabIndex = 3;
            ImgMonster.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(373, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // LabelDescrption
            // 
            LabelDescrption.ForeColor = Color.White;
            LabelDescrption.Location = new Point(262, 293);
            LabelDescrption.Name = "LabelDescrption";
            LabelDescrption.Size = new Size(269, 19);
            LabelDescrption.TabIndex = 5;
            LabelDescrption.Text = "Description Placeholder";
            LabelDescrption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeroLife
            // 
            HeroLife.BackColor = Color.Green;
            HeroLife.Location = new Point(73, 348);
            HeroLife.Name = "HeroLife";
            HeroLife.Size = new Size(183, 24);
            HeroLife.TabIndex = 6;
            // 
            // HeroLifePoint
            // 
            HeroLifePoint.BackColor = Color.Transparent;
            HeroLifePoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeroLifePoint.ForeColor = Color.White;
            HeroLifePoint.Location = new Point(73, 375);
            HeroLifePoint.Name = "HeroLifePoint";
            HeroLifePoint.Size = new Size(183, 24);
            HeroLifePoint.TabIndex = 8;
            HeroLifePoint.Text = "40/40";
            HeroLifePoint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonsterLife
            // 
            MonsterLife.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MonsterLife.BackColor = Color.Red;
            MonsterLife.Location = new Point(537, 348);
            MonsterLife.Name = "MonsterLife";
            MonsterLife.RightToLeft = RightToLeft.Yes;
            MonsterLife.Size = new Size(183, 24);
            MonsterLife.TabIndex = 7;
            // 
            // MonsterLifePoint
            // 
            MonsterLifePoint.BackColor = Color.Transparent;
            MonsterLifePoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonsterLifePoint.ForeColor = Color.White;
            MonsterLifePoint.Location = new Point(537, 375);
            MonsterLifePoint.Name = "MonsterLifePoint";
            MonsterLifePoint.Size = new Size(183, 24);
            MonsterLifePoint.TabIndex = 9;
            MonsterLifePoint.Text = "20/20";
            MonsterLifePoint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AttackButton
            // 
            AttackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttackButton.Location = new Point(73, 402);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(87, 26);
            AttackButton.TabIndex = 8;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // HealButton
            // 
            HealButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HealButton.Location = new Point(169, 402);
            HealButton.Name = "HealButton";
            HealButton.Size = new Size(87, 26);
            HealButton.TabIndex = 9;
            HealButton.Text = "Heal";
            HealButton.UseVisualStyleBackColor = true;
            HealButton.Click += HealButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(HeroLifePoint);
            Controls.Add(MonsterLifePoint);
            Controls.Add(HealButton);
            Controls.Add(AttackButton);
            Controls.Add(MonsterLife);
            Controls.Add(HeroLife);
            Controls.Add(LabelDescrption);
            Controls.Add(pictureBox3);
            Controls.Add(ImgMonster);
            Controls.Add(ImgHero);
            Controls.Add(TurnLabel);
            Controls.Add(TitleLabel);
            ImeMode = ImeMode.On;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Combat Game";
            ((System.ComponentModel.ISupportInitialize)ImgHero).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgMonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label TurnLabel;
        private PictureBox ImgHero;
        private PictureBox ImgMonster;
        private PictureBox pictureBox3;
        private Label LabelDescrption;
        private Panel HeroLife;
        private Panel MonsterLife;
        private Label HeroLifePoint;
        private Label MonsterLifePoint;
        private Button AttackButton;
        private Button HealButton;
    }
}
