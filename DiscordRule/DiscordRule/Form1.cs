using NetFwTypeLib;
namespace DiscordRule
{
    public partial class Form1 : Form
    {
        private String RuleName = "Discord";
        private INetFwRule? DiscordRule = null;
        private Dictionary<String, INetFwRule> Dic = new Dictionary<string, INetFwRule>();
        public Form1() {
            InitializeComponent();
            this.TopMost = true;
            try
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                var currentProfiles = fwPolicy2.CurrentProfileTypes;

                // List of rules
                // List<INetFwRule> RuleList = new List<INetFwRule>();

                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name.IndexOf(RuleName) != -1)
                    {
                        DiscordRule = rule;
                        Dic.Add(rule.Name, rule);   
                        comboBox1.Items.Add(rule.Name);
                        comboBox1.SelectedText = rule.Name;
                    }
                }
            }
            catch (Exception r)
            {
                Console.WriteLine("Error deleting a Firewall rule");
            }
            timer1.Enabled = true;
        }

        private void btnEnableRule_Click(object sender, EventArgs e) {
            if (DiscordRule == null) return;
            if (DiscordRule.Enabled)
            {
                btnEnableRule.Text = "���_�s�u";
                DiscordRule.Enabled = false;
            } else
            {
                btnEnableRule.Text = "���\�s�u";
                DiscordRule.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (DiscordRule == null)
            {
                this.Text = "NULL";
                return;
            }
            if (DiscordRule.Enabled)
            {
                this.BackColor = Color.Red;
                this.Text = "Enabled";
                btnEnableRule.Text = "���\�s�u";
            } else
            {
                this.BackColor = Color.Green;
                this.Text = "Disabled";
                btnEnableRule.Text = "���_�s�u";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
             Dic.TryGetValue(comboBox1.SelectedItem.ToString(), out DiscordRule);
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e) {
            if (cbTopMost.Checked)
            {
                this.TopMost = true;
            } else
            {
                this.TopMost = false;
            }
        }
    }
}