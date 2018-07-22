namespace HeroZeroCalculator
{
    public partial class frmCalculator : MetroFramework.Forms.MetroForm
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        void Calculate()
        {
            if (txtForce.Text.Trim() == string.Empty)
            {
                txtForce.Select(); return;
            }
            else if (txtCondition.Text.Trim() == string.Empty)
            {
                txtCondition.Select(); return;
            }
            else if (txtBrain.Text.Trim() == string.Empty)
            {
                txtBrain.Select(); return;
            }
            else if (txtIntuition.Text.Trim() == string.Empty)
            {
                txtIntuition.Select(); return;
            }
            else if (txtLevel.Text.Trim() == string.Empty)
            {
                txtLevel.Select(); return;
            }

            double force = System.Convert.ToDouble(txtForce.Text.Trim()),
                brain = System.Convert.ToDouble(txtBrain.Text.Trim()),
                intuition = System.Convert.ToDouble(txtIntuition.Text.Trim()),
                condition = System.Convert.ToDouble(txtCondition.Text.Trim()),
                level = System.Convert.ToDouble(txtLevel.Text.Trim());

            if (level == 0) return;

            double points = (force + brain + intuition + condition) / level;

            lblAMax.Text = (points * level).ToString();
            lblAAverage.Text = string.Format("{0:f1}", points);

            if (points < 10) lblAPoints.Text = "Terrível";
            else if (points < 20) lblAPoints.Text = "Ruim";
            else if (points < 30) lblAPoints.Text = "Fraco";
            else if (points < 40) lblAPoints.Text = "Bom";
            else if (points < 50) lblAPoints.Text = "Formidável";
            else if (points < 60) lblAPoints.Text = "Magnífico";
            else if (points < 70) lblAPoints.Text = "Sobrenatural";
            else if (points < 80) lblAPoints.Text = "Titan";
            else if (points < 90) lblAPoints.Text = "Mito";
            else if (points < 100) lblAPoints.Text = "Magnífico";
            else lblAPoints.Text = "Lendário";
        }

        private void frmCalculator_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picForce.Select();
        }

        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
            Calculate();
        }

        private void txtForce_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (char)8 != e.KeyChar)
                e.Handled = true;
        }

        private void txtCondition_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (char)8 != e.KeyChar)
                e.Handled = true;
        }

        private void txtBrain_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (char)8 != e.KeyChar)
                e.Handled = true;
        }

        private void txtIntuition_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (char)8 != e.KeyChar)
                e.Handled = true;
        }

        private void txtLevel_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (char)8 != e.KeyChar)
                e.Handled = true;
        }

        private void txtForce_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                Calculate();
        }

        private void txtCondition_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                Calculate();
        }

        private void txtBrain_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                Calculate();
        }

        private void txtIntuition_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                Calculate();
        }

        private void txtLevel_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                Calculate();
        }

        private void frmCalculator_Load(object sender, System.EventArgs e)
        {
            picForce.Select();
        }

        private void créditosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Programa desenvolvido por Lucas Naja", "Créditos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void gitHubToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/LucasNaja/hero-zero-calculator");
        }

        private void frmCalculator_Click(object sender, System.EventArgs e)
        {
            picLevel.Select();
        }

        private void tsmiFirstPlan_Click(object sender, System.EventArgs e)
        {
            if (tsmiFirstPlan.Checked)
            {
                this.TopMost = false; tsmiFirstPlan.Checked = false;
            }
            else
            {
                this.TopMost = true; tsmiFirstPlan.Checked = true;
            }
        }
    }
}