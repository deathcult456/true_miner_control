namespace true_miner_control
{
    partial class Form1
    {
       
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.onglet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_lbry = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_dag_lbry = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_sia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_dag_sia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_decred = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_dag_decred = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EURj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EURmois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EURelecmois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_prix_conso = new System.Windows.Forms.Label();
            this.textBox_prixW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_consoW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_resultat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_equi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_dag = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_equi_link = new System.Windows.Forms.TextBox();
            this.textBox_dag_link = new System.Windows.Forms.TextBox();
            this.label_price_BTC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_pascal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_dag_pascal = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label_mining = new System.Windows.Forms.Label();
            this.onglet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // onglet
            // 
            this.onglet.Controls.Add(this.tabPage1);
            this.onglet.Controls.Add(this.tabPage2);
            this.onglet.Location = new System.Drawing.Point(12, 12);
            this.onglet.Name = "onglet";
            this.onglet.SelectedIndex = 0;
            this.onglet.Size = new System.Drawing.Size(747, 361);
            this.onglet.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.textBox_pascal);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.textBox_dag_pascal);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.textBox_lbry);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.textBox_dag_lbry);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBox_sia);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBox_dag_sia);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBox_decred);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox_dag_decred);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label_prix_conso);
            this.tabPage1.Controls.Add(this.textBox_prixW);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_consoW);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label_resultat);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_equi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox_dag);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rentabilitée";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(250, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Mh/s";
            // 
            // textBox_lbry
            // 
            this.textBox_lbry.Location = new System.Drawing.Point(202, 124);
            this.textBox_lbry.Name = "textBox_lbry";
            this.textBox_lbry.Size = new System.Drawing.Size(42, 20);
            this.textBox_lbry.TabIndex = 52;
            this.textBox_lbry.Text = "209";
            this.textBox_lbry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(151, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Lbry:";
            // 
            // textBox_dag_lbry
            // 
            this.textBox_dag_lbry.Location = new System.Drawing.Point(68, 124);
            this.textBox_dag_lbry.Name = "textBox_dag_lbry";
            this.textBox_dag_lbry.Size = new System.Drawing.Size(42, 20);
            this.textBox_dag_lbry.TabIndex = 50;
            this.textBox_dag_lbry.Text = "21";
            this.textBox_dag_lbry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "ETHER:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(116, 127);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Mh/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(250, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Mh/s";
            // 
            // textBox_sia
            // 
            this.textBox_sia.Location = new System.Drawing.Point(202, 101);
            this.textBox_sia.Name = "textBox_sia";
            this.textBox_sia.Size = new System.Drawing.Size(42, 20);
            this.textBox_sia.TabIndex = 46;
            this.textBox_sia.Text = "209";
            this.textBox_sia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "SIA:";
            // 
            // textBox_dag_sia
            // 
            this.textBox_dag_sia.Location = new System.Drawing.Point(68, 101);
            this.textBox_dag_sia.Name = "textBox_dag_sia";
            this.textBox_dag_sia.Size = new System.Drawing.Size(42, 20);
            this.textBox_dag_sia.TabIndex = 44;
            this.textBox_dag_sia.Text = "21";
            this.textBox_dag_sia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "ETHER:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Mh/s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Mh/s";
            // 
            // textBox_decred
            // 
            this.textBox_decred.Location = new System.Drawing.Point(202, 78);
            this.textBox_decred.Name = "textBox_decred";
            this.textBox_decred.Size = new System.Drawing.Size(42, 20);
            this.textBox_decred.TabIndex = 40;
            this.textBox_decred.Text = "209";
            this.textBox_decred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Decred:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Mh/s";
            // 
            // textBox_dag_decred
            // 
            this.textBox_dag_decred.Location = new System.Drawing.Point(68, 78);
            this.textBox_dag_decred.Name = "textBox_dag_decred";
            this.textBox_dag_decred.Size = new System.Drawing.Size(42, 20);
            this.textBox_dag_decred.TabIndex = 37;
            this.textBox_dag_decred.Text = "21";
            this.textBox_dag_decred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "ETHER:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mBTC,
            this.EURj,
            this.EURmois,
            this.EURelecmois});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(299, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(403, 162);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mBTC
            // 
            this.mBTC.HeaderText = "mBTC/j";
            this.mBTC.Name = "mBTC";
            // 
            // EURj
            // 
            this.EURj.HeaderText = "€/jours";
            this.EURj.Name = "EURj";
            // 
            // EURmois
            // 
            this.EURmois.HeaderText = "€brute/mois";
            this.EURmois.Name = "EURmois";
            // 
            // EURelecmois
            // 
            this.EURelecmois.HeaderText = "€net/mois";
            this.EURelecmois.Name = "EURelecmois";
            // 
            // label_prix_conso
            // 
            this.label_prix_conso.AutoSize = true;
            this.label_prix_conso.Location = new System.Drawing.Point(296, 263);
            this.label_prix_conso.Name = "label_prix_conso";
            this.label_prix_conso.Size = new System.Drawing.Size(16, 13);
            this.label_prix_conso.TabIndex = 34;
            this.label_prix_conso.Text = "---";
            // 
            // textBox_prixW
            // 
            this.textBox_prixW.Location = new System.Drawing.Point(231, 260);
            this.textBox_prixW.Name = "textBox_prixW";
            this.textBox_prixW.Size = new System.Drawing.Size(59, 20);
            this.textBox_prixW.TabIndex = 33;
            this.textBox_prixW.Text = "0.1449";
            this.textBox_prixW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "prix kW:";
            // 
            // textBox_consoW
            // 
            this.textBox_consoW.Location = new System.Drawing.Point(118, 260);
            this.textBox_consoW.Name = "textBox_consoW";
            this.textBox_consoW.Size = new System.Drawing.Size(59, 20);
            this.textBox_consoW.TabIndex = 31;
            this.textBox_consoW.Text = "750";
            this.textBox_consoW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "conso total rig (w):";
            // 
            // label_resultat
            // 
            this.label_resultat.AutoSize = true;
            this.label_resultat.Location = new System.Drawing.Point(105, 306);
            this.label_resultat.Name = "label_resultat";
            this.label_resultat.Size = new System.Drawing.Size(16, 13);
            this.label_resultat.TabIndex = 24;
            this.label_resultat.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sol/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mh/s";
            // 
            // textBox_equi
            // 
            this.textBox_equi.Location = new System.Drawing.Point(202, 31);
            this.textBox_equi.Name = "textBox_equi";
            this.textBox_equi.Size = new System.Drawing.Size(42, 20);
            this.textBox_equi.TabIndex = 21;
            this.textBox_equi.Text = "430";
            this.textBox_equi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ZCASH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ETHER:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_dag
            // 
            this.textBox_dag.Location = new System.Drawing.Point(202, 55);
            this.textBox_dag.Name = "textBox_dag";
            this.textBox_dag.Size = new System.Drawing.Size(42, 20);
            this.textBox_dag.TabIndex = 17;
            this.textBox_dag.Text = "31";
            this.textBox_dag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button_start);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_equi_link);
            this.tabPage2.Controls.Add(this.textBox_dag_link);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mining";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(588, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(588, 203);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(145, 30);
            this.button_start.TabIndex = 22;
            this.button_start.Text = "Lancer mining rentable";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "ZCASH start.bat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ETHER start.bat:";
            // 
            // textBox_equi_link
            // 
            this.textBox_equi_link.Location = new System.Drawing.Point(105, 52);
            this.textBox_equi_link.Name = "textBox_equi_link";
            this.textBox_equi_link.Size = new System.Drawing.Size(622, 20);
            this.textBox_equi_link.TabIndex = 19;
            this.textBox_equi_link.Text = "--";
            this.textBox_equi_link.Click += new System.EventHandler(this.textBox_equi_link_Click);
            // 
            // textBox_dag_link
            // 
            this.textBox_dag_link.Location = new System.Drawing.Point(105, 18);
            this.textBox_dag_link.Name = "textBox_dag_link";
            this.textBox_dag_link.Size = new System.Drawing.Size(622, 20);
            this.textBox_dag_link.TabIndex = 18;
            this.textBox_dag_link.Text = "--";
            this.textBox_dag_link.Click += new System.EventHandler(this.textBox_dag_link_Click);
            // 
            // label_price_BTC
            // 
            this.label_price_BTC.AutoSize = true;
            this.label_price_BTC.Location = new System.Drawing.Point(708, 390);
            this.label_price_BTC.Name = "label_price_BTC";
            this.label_price_BTC.Size = new System.Drawing.Size(16, 13);
            this.label_price_BTC.TabIndex = 27;
            this.label_price_BTC.Text = "...";
            this.label_price_BTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Prix du BTC:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(250, 154);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "Mh/s";
            // 
            // textBox_pascal
            // 
            this.textBox_pascal.Location = new System.Drawing.Point(202, 148);
            this.textBox_pascal.Name = "textBox_pascal";
            this.textBox_pascal.Size = new System.Drawing.Size(42, 20);
            this.textBox_pascal.TabIndex = 58;
            this.textBox_pascal.Text = "209";
            this.textBox_pascal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(151, 151);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "Pascal:";
            // 
            // textBox_dag_pascal
            // 
            this.textBox_dag_pascal.Location = new System.Drawing.Point(68, 148);
            this.textBox_dag_pascal.Name = "textBox_dag_pascal";
            this.textBox_dag_pascal.Size = new System.Drawing.Size(42, 20);
            this.textBox_dag_pascal.TabIndex = 56;
            this.textBox_dag_pascal.Text = "21";
            this.textBox_dag_pascal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "ETHER:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(116, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Mh/s";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label_mining
            // 
            this.label_mining.AutoSize = true;
            this.label_mining.Location = new System.Drawing.Point(24, 390);
            this.label_mining.Name = "label_mining";
            this.label_mining.Size = new System.Drawing.Size(16, 13);
            this.label_mining.TabIndex = 28;
            this.label_mining.Text = "...";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(769, 412);
            this.Controls.Add(this.label_mining);
            this.Controls.Add(this.onglet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_price_BTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "True miner control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.onglet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      //  private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabControl onglet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_price_BTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_resultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_equi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_dag;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_equi_link;
        private System.Windows.Forms.TextBox textBox_dag_link;
        private System.Windows.Forms.Label label_prix_conso;
        private System.Windows.Forms.TextBox textBox_prixW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_consoW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mBTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EURj;
        private System.Windows.Forms.DataGridViewTextBoxColumn EURmois;
        private System.Windows.Forms.DataGridViewTextBoxColumn EURelecmois;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_dag_decred;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_decred;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_sia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_dag_sia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_lbry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_dag_lbry;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_pascal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_dag_pascal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label_mining;
    }
    
}

