
namespace TurnBaseCombat
{
    public partial class MainForm : Form
    {
        bool HeroTurn = true;

        int HeroLifeMax = 40;
        int HeroLifeCurrent = 40;
        int MonsterLifeMax = 20;
        int MonsterLifeCurrent = 20;

        int HeroAttackForce = 5;
        int MonsterAttackForce = 7;

        int HeroHeal = 5;
        int MonsterHeal = 3;
        public MainForm()
        {
            InitializeComponent();
            BeginGame();
        }

        private void BeginGame()
        {
            ImgHero.Image = Properties.Resources.HeroNeutral;
            ImgMonster.Image = Properties.Resources.MonsterNeutral;
            HeroLifePoint.Text = HeroLifeCurrent + "/" + HeroLifeMax;
            MonsterLifePoint.Text = MonsterLifeCurrent + "/" + MonsterLifeMax;
            HeroLife.Width = 183;
            MonsterLife.Width = 183;
            AttackButton.Enabled = false;
            HealButton.Enabled = false;

            UpdateGame();
        }

        private void UpdateGame()
        {                     
            LabelDescrption.Text = "";
            if (HeroLifeCurrent > 0 && MonsterLifeCurrent > 0)
            {
                if (HeroTurn)
                {
                    TurnLabel.Text = "Player's Turn!";
                    AttackButton.Enabled = true;
                    HealButton.Enabled = true;
                }
                else
                {
                    TurnLabel.Text = "Monster's Turn!";
                    AttackButton.Enabled = false;
                    HealButton.Enabled = false;
                    MonsterTurn();
                }
            }
            else
            {
                if (HeroLifeCurrent <= 0)
                {
                    LabelDescrption.Text = "The hero was defeated!";
                    ImgHero.Image = Properties.Resources.HeroLoss;
                    AttackButton.Enabled = false;
                    HealButton.Enabled = false;
                }
                else
                {
                    LabelDescrption.Text = "The hero was victorious!";
                    ImgMonster.Image = Properties.Resources.MonsterLoss;
                    AttackButton.Enabled = false;
                    HealButton.Enabled = false;
                }
            }
        }

        private async void AttackButton_Click(object sender, EventArgs e)
        {
            ImgHero.Image = Properties.Resources.HeroAttack;
            MonsterLifeCurrent -= HeroAttackForce;
            MonsterLifePoint.Text = MonsterLifeCurrent + "/" + MonsterLifeMax;
            MonsterLife.Width = (183 * MonsterLifeCurrent) / MonsterLifeMax;
            LabelDescrption.Text = "The Hero attacks causing " + HeroAttackForce + " damage!";
            await Task.Delay(2000);
            ImgHero.Image = Properties.Resources.HeroNeutral;
            HeroTurn = false;
            UpdateGame();
        }

        private async void HealButton_Click(object sender, EventArgs e)
        {
            HeroLifeCurrent += HeroHeal;
            if (HeroLifeCurrent > HeroLifeMax)
            {
                HeroLifeCurrent = HeroLifeMax;
            }
            HeroLifePoint.Text = HeroLifeCurrent + "/" + HeroLifeMax;
            HeroLife.Width = (183 * HeroLifeCurrent) / HeroLifeMax;
            LabelDescrption.Text = "The Hero heals " + HeroHeal + " points!";
            await Task.Delay(2000);
            HeroTurn = false;
            UpdateGame();
        }

        private async void MonsterTurn()
        {
            Random random = new Random();
            int choice = random.Next(0, 2);
            if (choice == 0)
            {
                ImgMonster.Image = Properties.Resources.MonsterAttack;
                HeroLifeCurrent -= MonsterAttackForce;
                HeroLifePoint.Text = HeroLifeCurrent + "/" + HeroLifeMax;
                HeroLife.Width = (183 * HeroLifeCurrent) / HeroLifeMax;
                LabelDescrption.Text = "The Monsters attacks causing " + MonsterAttackForce + " damage!";
                await Task.Delay(2000);
                ImgMonster.Image = Properties.Resources.MonsterNeutral;
                HeroTurn = true;
                UpdateGame();
            } 
            else
            {
                MonsterLifeCurrent += MonsterHeal;
                if (MonsterLifeCurrent > MonsterLifeMax)
                {
                    MonsterLifeCurrent = MonsterLifeMax;
                }
                MonsterLifePoint.Text = MonsterLifeCurrent + "/" + MonsterLifeMax;
                MonsterLife.Width = (183 * MonsterLifeCurrent) / MonsterLifeMax;
                LabelDescrption.Text = "The Monster heals " + MonsterHeal + " points!";
                await Task.Delay(2000);
                HeroTurn = true;
                UpdateGame();
            }
        }
    }
}
