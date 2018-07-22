namespace HeroZeroCalculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.tip = new MetroFramework.Components.MetroToolTip();
            this.picLevel = new System.Windows.Forms.PictureBox();
            this.picIntuition = new System.Windows.Forms.PictureBox();
            this.picBrain = new System.Windows.Forms.PictureBox();
            this.picCondition = new System.Windows.Forms.PictureBox();
            this.picForce = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblIntuition = new System.Windows.Forms.Label();
            this.lblForce = new System.Windows.Forms.Label();
            this.txtIntuition = new System.Windows.Forms.TextBox();
            this.lblBrain = new System.Windows.Forms.Label();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtBrain = new System.Windows.Forms.TextBox();
            this.pStatus = new System.Windows.Forms.Panel();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblAMax = new System.Windows.Forms.Label();
            this.lblAAverage = new System.Windows.Forms.Label();
            this.lblAPoints = new System.Windows.Forms.Label();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCredits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFirstPlan = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntuition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForce)).BeginInit();
            this.pStatus.SuspendLayout();
            this.msOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.AutoPopDelay = 5000;
            this.tip.InitialDelay = 350;
            this.tip.ReshowDelay = 100;
            this.tip.Style = MetroFramework.MetroColorStyle.Orange;
            this.tip.StyleManager = null;
            this.tip.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // picLevel
            // 
            this.picLevel.Image = ((System.Drawing.Image)(resources.GetObject("picLevel.Image")));
            this.picLevel.Location = new System.Drawing.Point(113, 219);
            this.picLevel.Name = "picLevel";
            this.picLevel.Size = new System.Drawing.Size(31, 31);
            this.picLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLevel.TabIndex = 45;
            this.picLevel.TabStop = false;
            this.tip.SetToolTip(this.picLevel, "Nível");
            this.picLevel.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // picIntuition
            // 
            this.picIntuition.Image = ((System.Drawing.Image)(resources.GetObject("picIntuition.Image")));
            this.picIntuition.Location = new System.Drawing.Point(113, 181);
            this.picIntuition.Name = "picIntuition";
            this.picIntuition.Size = new System.Drawing.Size(31, 31);
            this.picIntuition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIntuition.TabIndex = 44;
            this.picIntuition.TabStop = false;
            this.tip.SetToolTip(this.picIntuition, "Intuição");
            this.picIntuition.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // picBrain
            // 
            this.picBrain.Image = ((System.Drawing.Image)(resources.GetObject("picBrain.Image")));
            this.picBrain.Location = new System.Drawing.Point(113, 143);
            this.picBrain.Name = "picBrain";
            this.picBrain.Size = new System.Drawing.Size(31, 31);
            this.picBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrain.TabIndex = 43;
            this.picBrain.TabStop = false;
            this.tip.SetToolTip(this.picBrain, "Cérebro");
            this.picBrain.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // picCondition
            // 
            this.picCondition.Image = ((System.Drawing.Image)(resources.GetObject("picCondition.Image")));
            this.picCondition.Location = new System.Drawing.Point(113, 105);
            this.picCondition.Name = "picCondition";
            this.picCondition.Size = new System.Drawing.Size(31, 31);
            this.picCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCondition.TabIndex = 42;
            this.picCondition.TabStop = false;
            this.tip.SetToolTip(this.picCondition, "Condição");
            this.picCondition.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // picForce
            // 
            this.picForce.Image = ((System.Drawing.Image)(resources.GetObject("picForce.Image")));
            this.picForce.Location = new System.Drawing.Point(113, 67);
            this.picForce.Name = "picForce";
            this.picForce.Size = new System.Drawing.Size(31, 31);
            this.picForce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForce.TabIndex = 41;
            this.picForce.TabStop = false;
            this.tip.SetToolTip(this.picForce, "Força");
            this.picForce.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Black;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(585, 217);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calcular";
            this.tip.SetToolTip(this.btnCalculate, "Calcular média");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.Black;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevel.ForeColor = System.Drawing.Color.Orange;
            this.txtLevel.Location = new System.Drawing.Point(154, 219);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtLevel.MaxLength = 9;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ShortcutsEnabled = false;
            this.txtLevel.Size = new System.Drawing.Size(184, 31);
            this.txtLevel.TabIndex = 4;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLevel_KeyDown);
            this.txtLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLevel_KeyPress);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(44, 221);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(67, 25);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Nível:";
            this.lblLevel.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblIntuition
            // 
            this.lblIntuition.AutoSize = true;
            this.lblIntuition.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntuition.Location = new System.Drawing.Point(15, 183);
            this.lblIntuition.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIntuition.Name = "lblIntuition";
            this.lblIntuition.Size = new System.Drawing.Size(96, 25);
            this.lblIntuition.TabIndex = 0;
            this.lblIntuition.Text = "Intuição:";
            this.lblIntuition.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForce.Location = new System.Drawing.Point(38, 69);
            this.lblForce.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(73, 25);
            this.lblForce.TabIndex = 0;
            this.lblForce.Text = "Força:";
            this.lblForce.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // txtIntuition
            // 
            this.txtIntuition.BackColor = System.Drawing.Color.Black;
            this.txtIntuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIntuition.ForeColor = System.Drawing.Color.Orange;
            this.txtIntuition.Location = new System.Drawing.Point(154, 181);
            this.txtIntuition.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtIntuition.MaxLength = 9;
            this.txtIntuition.Name = "txtIntuition";
            this.txtIntuition.ShortcutsEnabled = false;
            this.txtIntuition.Size = new System.Drawing.Size(184, 31);
            this.txtIntuition.TabIndex = 3;
            this.txtIntuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIntuition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIntuition_KeyDown);
            this.txtIntuition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntuition_KeyPress);
            // 
            // lblBrain
            // 
            this.lblBrain.AutoSize = true;
            this.lblBrain.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrain.Location = new System.Drawing.Point(18, 145);
            this.lblBrain.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBrain.Name = "lblBrain";
            this.lblBrain.Size = new System.Drawing.Size(93, 25);
            this.lblBrain.TabIndex = 0;
            this.lblBrain.Text = "Cérebro:";
            this.lblBrain.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // txtForce
            // 
            this.txtForce.BackColor = System.Drawing.Color.Black;
            this.txtForce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForce.ForeColor = System.Drawing.Color.Orange;
            this.txtForce.Location = new System.Drawing.Point(154, 67);
            this.txtForce.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtForce.MaxLength = 9;
            this.txtForce.Name = "txtForce";
            this.txtForce.ShortcutsEnabled = false;
            this.txtForce.Size = new System.Drawing.Size(184, 31);
            this.txtForce.TabIndex = 0;
            this.txtForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtForce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtForce_KeyDown);
            this.txtForce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForce_KeyPress);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(6, 107);
            this.lblCondition.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(105, 25);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "Condição:";
            this.lblCondition.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.Color.Black;
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.ForeColor = System.Drawing.Color.Orange;
            this.txtCondition.Location = new System.Drawing.Point(154, 105);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCondition.MaxLength = 9;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ShortcutsEnabled = false;
            this.txtCondition.Size = new System.Drawing.Size(184, 31);
            this.txtCondition.TabIndex = 1;
            this.txtCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCondition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCondition_KeyDown);
            this.txtCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondition_KeyPress);
            // 
            // txtBrain
            // 
            this.txtBrain.BackColor = System.Drawing.Color.Black;
            this.txtBrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrain.ForeColor = System.Drawing.Color.Orange;
            this.txtBrain.Location = new System.Drawing.Point(154, 143);
            this.txtBrain.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBrain.MaxLength = 9;
            this.txtBrain.Name = "txtBrain";
            this.txtBrain.ShortcutsEnabled = false;
            this.txtBrain.Size = new System.Drawing.Size(184, 31);
            this.txtBrain.TabIndex = 2;
            this.txtBrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrain_KeyDown);
            this.txtBrain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrain_KeyPress);
            // 
            // pStatus
            // 
            this.pStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStatus.Controls.Add(this.lblMax);
            this.pStatus.Controls.Add(this.lblAverage);
            this.pStatus.Controls.Add(this.lblPoints);
            this.pStatus.Controls.Add(this.lblAMax);
            this.pStatus.Controls.Add(this.lblAAverage);
            this.pStatus.Controls.Add(this.lblAPoints);
            this.pStatus.Location = new System.Drawing.Point(358, 67);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(347, 141);
            this.pStatus.TabIndex = 0;
            this.pStatus.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblMax.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(17, 18);
            this.lblMax.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(170, 23);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Total de pontos:";
            this.lblMax.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAverage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(7, 58);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(180, 23);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Média de pontos:";
            this.lblAverage.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPoints.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(80, 97);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(107, 23);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Seu nível:";
            this.lblPoints.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblAMax
            // 
            this.lblAMax.AutoSize = true;
            this.lblAMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAMax.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMax.Location = new System.Drawing.Point(187, 18);
            this.lblAMax.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAMax.Name = "lblAMax";
            this.lblAMax.Size = new System.Drawing.Size(149, 23);
            this.lblAMax.TabIndex = 0;
            this.lblAMax.Text = "Aguardando...";
            this.lblAMax.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblAAverage
            // 
            this.lblAAverage.AutoSize = true;
            this.lblAAverage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAAverage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAAverage.Location = new System.Drawing.Point(187, 58);
            this.lblAAverage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAAverage.Name = "lblAAverage";
            this.lblAAverage.Size = new System.Drawing.Size(149, 23);
            this.lblAAverage.TabIndex = 0;
            this.lblAAverage.Text = "Aguardando...";
            this.lblAAverage.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // lblAPoints
            // 
            this.lblAPoints.AutoSize = true;
            this.lblAPoints.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAPoints.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPoints.Location = new System.Drawing.Point(187, 97);
            this.lblAPoints.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAPoints.Name = "lblAPoints";
            this.lblAPoints.Size = new System.Drawing.Size(149, 23);
            this.lblAPoints.TabIndex = 0;
            this.lblAPoints.Text = "Aguardando...";
            this.lblAPoints.Click += new System.EventHandler(this.frmCalculator_Click);
            // 
            // msOptions
            // 
            this.msOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.msOptions.Location = new System.Drawing.Point(0, 5);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(67, 24);
            this.msOptions.TabIndex = 46;
            this.msOptions.Text = "Opções";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCredits,
            this.tsmiGitHub,
            this.tsmiFirstPlan});
            this.tsmiOptions.ForeColor = System.Drawing.Color.Black;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(59, 20);
            this.tsmiOptions.Text = "Opções";
            // 
            // tsmiCredits
            // 
            this.tsmiCredits.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCredits.Image")));
            this.tsmiCredits.Name = "tsmiCredits";
            this.tsmiCredits.Size = new System.Drawing.Size(180, 22);
            this.tsmiCredits.Text = "Créditos";
            this.tsmiCredits.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // tsmiGitHub
            // 
            this.tsmiGitHub.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGitHub.Image")));
            this.tsmiGitHub.Name = "tsmiGitHub";
            this.tsmiGitHub.Size = new System.Drawing.Size(180, 22);
            this.tsmiGitHub.Text = "GitHub";
            this.tsmiGitHub.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // tsmiFirstPlan
            // 
            this.tsmiFirstPlan.Checked = true;
            this.tsmiFirstPlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiFirstPlan.Name = "tsmiFirstPlan";
            this.tsmiFirstPlan.Size = new System.Drawing.Size(180, 22);
            this.tsmiFirstPlan.Text = "Primeiro plano";
            this.tsmiFirstPlan.Click += new System.EventHandler(this.tsmiFirstPlan_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 266);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.picLevel);
            this.Controls.Add(this.picIntuition);
            this.Controls.Add(this.picBrain);
            this.Controls.Add(this.picCondition);
            this.Controls.Add(this.picForce);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblIntuition);
            this.Controls.Add(this.lblForce);
            this.Controls.Add(this.txtIntuition);
            this.Controls.Add(this.lblBrain);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtBrain);
            this.Controls.Add(this.msOptions);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msOptions;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Calculadora Hero Zero";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.Click += new System.EventHandler(this.frmCalculator_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmCalculator_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntuition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForce)).EndInit();
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroToolTip tip;
        private System.Windows.Forms.PictureBox picLevel;
        private System.Windows.Forms.PictureBox picIntuition;
        private System.Windows.Forms.PictureBox picBrain;
        private System.Windows.Forms.PictureBox picCondition;
        private System.Windows.Forms.PictureBox picForce;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblIntuition;
        private System.Windows.Forms.Label lblForce;
        private System.Windows.Forms.TextBox txtIntuition;
        private System.Windows.Forms.Label lblBrain;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtBrain;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblAMax;
        private System.Windows.Forms.Label lblAAverage;
        private System.Windows.Forms.Label lblAPoints;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiCredits;
        private System.Windows.Forms.ToolStripMenuItem tsmiGitHub;
        private System.Windows.Forms.ToolStripMenuItem tsmiFirstPlan;
    }
}

