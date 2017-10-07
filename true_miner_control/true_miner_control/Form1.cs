using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Diagnostics;


namespace true_miner_control
{

    
    public partial class Form1 : Form
    {
        public string mining_renta = "null"; //"Equi" or "Dag"
        System.Diagnostics.Process proc = new System.Diagnostics.Process();

        public Form1()
        {
           
            InitializeComponent();
        }

        public class simplemultialgo
        {
            public string paying { get; set; }
            public string port { get; set; }
            public string name { get; set; }
            public string algo { get; set; }
        }

        public string Best_algo; 
    
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;

        }
       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox_pascal.Text = Properties.Settings.Default.save_textbox_pascal;
            textBox_dag_pascal.Text = Properties.Settings.Default.save_textbox_dag_pascal;
            textBox_lbry.Text = Properties.Settings.Default.save_textbox_lbry;
            textBox_dag_lbry.Text = Properties.Settings.Default.save_textbox_dag_lbry;
            textBox_sia.Text = Properties.Settings.Default.save_textbox_sia;
            textBox_dag_sia.Text = Properties.Settings.Default.save_textbox_dag_sia;
            textBox_dag.Text = Properties.Settings.Default.save_textbox_dag;
            textBox_dag_decred.Text = Properties.Settings.Default.save_textbox_dag_decred;
            textBox_decred.Text = Properties.Settings.Default.save_textbox_decred;
            textBox_dag_link.Text = Properties.Settings.Default.save_textbox_dag_link;
            textBox_equi.Text = Properties.Settings.Default.save_textbox_equi;
            textBox_equi_link.Text = Properties.Settings.Default.save_textbox_equi_link;
            textBox_consoW.Text = Properties.Settings.Default.save_textbox_W;
            textBox_prixW.Text = Properties.Settings.Default.save_textbox_prixW;
            timer1.Start();

            timer3.Interval = 1000;
            timer3.Start();
        }
       


        private void timer1_Tick(object sender, EventArgs e)
        {
            string price_BTC_EUR = "";
            double BTC_EUR = 0;
            
            //try {
                // A FAIRE REMPLACER , PAR .
                // calcule watt/j /mois------------------------------------------------------------------------------
                double prixW = double.Parse(textBox_prixW.Text, System.Globalization.CultureInfo.InvariantCulture);
                double consoW = double.Parse(textBox_consoW.Text, System.Globalization.CultureInfo.InvariantCulture);
                double prixConsoD = Math.Round(((consoW / 1000)*24) * prixW, 4);
                double prixConsoM = Math.Round(prixConsoD * 30, 4);
                
                label_prix_conso.Text = prixConsoD.ToString() + "€/j " + prixConsoM.ToString() + "€/mois";
                //---------------------------------------------------------------------------------------------------

                WebClient client = new WebClient();
                string nicehash_json = client.DownloadString("https://api.nicehash.com/api?method=simplemultialgo.info"); //get price/mining/ratio
                string BTC_EUR_json = client.DownloadString("https://blockchain.info/fr/ticker"); // get btc in euro


                // "port":3333,"name":"scrypt", "algo":0
                //"port":3334,"name":"sha256","algo":1
                //"port":3335,"name":"scryptnf","algo":2
                //"port":3336,"name":"x11","algo":3
                //"port":3337,"name":"x13","algo":4
                //"port":3338,"name":"keccak","algo":5
                //"port":3339,"name":"x15","algo":6
                //"port":3340,"name":"nist5","algo":7
                //"port":3341,"name":"neoscrypt","algo":8
                //"port":3342,"name":"lyra2re","algo":9
                //"port":3343,"name":"whirlpoolx","algo":10
                //"port":3344,"name":"qubit","algo":11
                //"port":3345,"name":"quark","algo":12
                //"port":3346,"name":"axiom","algo":13
                //"port":3347,"name":"lyra2rev2","algo":14
                //"port":3348,"name":"scryptjanenf16","algo":15
                //"port":3349,"name":"blake256r8","algo":16
                //"port":3350,"name":"blake256r14","algo":17
                //"port":3351,"name":"blake256r8vnl","algo":18
                //"port":3352,"name":"hodl","algo":19
                //"port":3353,"name":"daggerhashimoto","algo":20
                //"port":3354,"name":"decred","algo":21
                //"port":3355,"name":"cryptonight","algo":22
                //"port":3356,"name":"lbry","algo":23
                //"port":3357,"name":"equihash","algo":24 
                //"port":3358,"name":"pascal","algo":25                                                                                  
                //"port":3359,"name":"x11gost","algo":26                                                                                  
                //"port":3360,"name":"sia","algo":27                                                                                 
                //"port":3361,"name":"blake2s","algo":28                                                                                  
                //"port":3362,"name":"skunk","algo":29


                string [,] nicehash_data = new string [30,3];//[N°algo][0(name),1(port),2(paying)]

                if (nicehash_json != "" || BTC_EUR_json != "")
                {
                    // nicehash-------------------------------------------------------------------------------
                    JObject nicehash_Deserialize = JObject.Parse(nicehash_json);
                    IList<JToken> results = nicehash_Deserialize["result"]["simplemultialgo"].Children().ToList();
                    IList<simplemultialgo> searchResults = new List<simplemultialgo>();

                    for (int i = 0; i<29; i++)
                     {

                        foreach (JToken result in results)
                        {
                        simplemultialgo searchResult = result.ToObject<simplemultialgo>();
                        searchResults.Add(searchResult);
                            if (i.ToString() == searchResult.algo)
                             {
                              nicehash_data[i, 0] = searchResult.name;
                              nicehash_data[i, 1] = searchResult.port;
                              nicehash_data[i, 2] = searchResult.paying;
                            }
                        }
                }
               

                    // blockchain-------------------------------------------------------------------------------
                    JObject o = JObject.Parse(BTC_EUR_json);
                    string Price_BTC = (string)o.SelectToken("EUR.last");
                    price_BTC_EUR = Price_BTC;
                    BTC_EUR = double.Parse(price_BTC_EUR, System.Globalization.CultureInfo.InvariantCulture);
                    label_price_BTC.Text = (Math.Round(BTC_EUR, 1)).ToString() + "€";

                    // calcules-------------------------------------------------------------------------------
                    if (textBox_dag.Text != "" || textBox_equi.Text != "")
                    {
                    button_start.Enabled = true;

                    //DAG PASCAL
                    double BTC_day_dag_pascal = ((double.Parse(textBox_dag_pascal.Text) / 1000) * double.Parse(nicehash_data[20, 2], System.Globalization.CultureInfo.InvariantCulture)) + ((double.Parse(textBox_pascal.Text) / 1000) * double.Parse(nicehash_data[25, 2], System.Globalization.CultureInfo.InvariantCulture));
                    string EUR_by_day_dag_pascal = Math.Round((BTC_day_dag_pascal * BTC_EUR), 3).ToString();
                    //DAG SIA
                    double BTC_day_dag_lbry = ((double.Parse(textBox_dag_lbry.Text) / 1000) * double.Parse(nicehash_data[20, 2], System.Globalization.CultureInfo.InvariantCulture)) + ((double.Parse(textBox_lbry.Text) / 1000) * double.Parse(nicehash_data[23, 2], System.Globalization.CultureInfo.InvariantCulture));
                    string EUR_by_day_dag_lbry = Math.Round((BTC_day_dag_lbry * BTC_EUR), 3).ToString();
                    //DAG SIA
                    double BTC_day_dag_sia = ((double.Parse(textBox_dag_sia.Text) / 1000) * double.Parse(nicehash_data[20, 2], System.Globalization.CultureInfo.InvariantCulture)) + ((double.Parse(textBox_decred.Text) / 1000) * double.Parse(nicehash_data[27, 2], System.Globalization.CultureInfo.InvariantCulture));
                    string EUR_by_day_dag_sia = Math.Round((BTC_day_dag_sia * BTC_EUR), 3).ToString();
                    //DAG DECRED
                    double BTC_day_dag_decred = ((double.Parse(textBox_dag_decred.Text) / 1000) * double.Parse(nicehash_data[20, 2], System.Globalization.CultureInfo.InvariantCulture)) + ((double.Parse(textBox_decred.Text) / 1000) * double.Parse(nicehash_data[21, 2], System.Globalization.CultureInfo.InvariantCulture));
                    string EUR_by_day_dag_decred = Math.Round((BTC_day_dag_decred * BTC_EUR), 3).ToString();
                    //DAG
                    double BTC_day_dag = (double.Parse(textBox_dag.Text) / 1000) * double.Parse(nicehash_data[20, 2], System.Globalization.CultureInfo.InvariantCulture); //dag en Mh/s donc *1000 pour allez au Gh/s
                    string EUR_by_day_dag = Math.Round((BTC_day_dag * BTC_EUR), 3).ToString();
                    //EQUI
                    double BTC_day_equi = (double.Parse(textBox_equi.Text) / 1000000000) * double.Parse(nicehash_data[24, 2], System.Globalization.CultureInfo.InvariantCulture);  //equi en h/s donc *1 000 000
                    string EUR_by_day_equi = Math.Round((BTC_day_equi * BTC_EUR), 3).ToString();

                    //--------------------------ROW------------------------------------------------------------------------- 

                    dataGridView1.Rows.Clear(); // clear les anciennes value
                       
                    //ETHER 
                    string[] row0 = { Math.Round((BTC_day_equi * 1000), 3).ToString(), (double.Parse(EUR_by_day_equi)).ToString(), ((double.Parse(EUR_by_day_equi)) * 30).ToString(), (((double.Parse(EUR_by_day_equi)) * 30) - prixConsoM).ToString() };                      
                    dataGridView1.Rows.Add(row0);
                        
                    //DAG:
                    string[] row1 = { Math.Round((BTC_day_dag * 1000), 3).ToString(), (double.Parse(EUR_by_day_dag)).ToString(), ((double.Parse(EUR_by_day_dag)) * 30).ToString(), (((double.Parse(EUR_by_day_dag)) * 30) - prixConsoM).ToString() };
                    dataGridView1.Rows.Add(row1);

                    //DAG_ether:
                    string[] row2 = { Math.Round((BTC_day_dag_decred * 1000), 3).ToString(), (double.Parse(EUR_by_day_dag_decred)).ToString(), ((double.Parse(EUR_by_day_dag_decred)) * 30).ToString(), (((double.Parse(EUR_by_day_dag_decred)) * 30) - prixConsoM).ToString() };
                    dataGridView1.Rows.Add(row2);

                    //DAG_sia:
                    string[] row3 = { Math.Round((BTC_day_dag_sia * 1000), 3).ToString(), (double.Parse(EUR_by_day_dag_sia)).ToString(), ((double.Parse(EUR_by_day_dag_sia)) * 30).ToString(), (((double.Parse(EUR_by_day_dag_sia)) * 30) - prixConsoM).ToString() };
                    dataGridView1.Rows.Add(row3);

                    //DAG_lbry:
                    string[] row4 = { Math.Round((BTC_day_dag_lbry * 1000), 3).ToString(), (double.Parse(EUR_by_day_dag_lbry)).ToString(), ((double.Parse(EUR_by_day_dag_lbry)) * 30).ToString(), (((double.Parse(EUR_by_day_dag_lbry)) * 30) - prixConsoM).ToString() };
                    dataGridView1.Rows.Add(row4);

                    //DAG_pascal:
                    string[] row5 = { Math.Round((BTC_day_dag_pascal * 1000), 3).ToString(), (double.Parse(EUR_by_day_dag_pascal)).ToString(), ((double.Parse(EUR_by_day_dag_pascal)) * 30).ToString(), (((double.Parse(EUR_by_day_dag_pascal)) * 30) - prixConsoM).ToString() };
                    dataGridView1.Rows.Add(row5);

                    dataGridView1.CurrentCell = null; // deselectioner la premier cellule sinon c'est moche

                  
                }
                else // else les textbox des hash sont vides 
                    {
                        button_start.Enabled = false;
                        label_resultat.Text = "erreur de hashrate";
                    }
                }
                else // else pas reussi a recupéré les json probleme d'internet
                {
                    button_start.Enabled = false;
                    label_resultat.Text = "erreur DATA web";
                }

                timer1.Interval = 10000;
            /*}
            catch {
                timer1.Stop();
                MessageBox.Show("Erreur dans les calcules, réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            }
          */
         
        }
        private void textBox_equi_link_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*|bat files (*.bat)|*.bat";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox_equi_link.Text = openFileDialog1.FileName;
            }
        }
        private void textBox_dag_link_Click(object sender, System.EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*|bat files (*.bat)|*.bat";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox_dag_link.Text = openFileDialog1.FileName;
            }
           
        }
        private void textBox_dag_link_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.save_textbox_pascal = textBox_pascal.Text;
            Properties.Settings.Default.save_textbox_dag_pascal = textBox_dag_pascal.Text;
            Properties.Settings.Default.save_textbox_lbry = textBox_lbry.Text;
            Properties.Settings.Default.save_textbox_dag_lbry = textBox_dag_lbry.Text;
            Properties.Settings.Default.save_textbox_sia = textBox_sia.Text;
            Properties.Settings.Default.save_textbox_dag_sia = textBox_dag_sia.Text;
            Properties.Settings.Default.save_textbox_dag = textBox_dag.Text;
            Properties.Settings.Default.save_textbox_dag_decred = textBox_dag_decred.Text;
            Properties.Settings.Default.save_textbox_decred = textBox_decred.Text;
            Properties.Settings.Default.save_textbox_equi = textBox_equi.Text;
            Properties.Settings.Default.save_textbox_dag_link = textBox_dag_link.Text;
            Properties.Settings.Default.save_textbox_equi_link = textBox_equi_link.Text;
            Properties.Settings.Default.save_textbox_prixW = textBox_prixW.Text;
            Properties.Settings.Default.save_textbox_W = textBox_consoW.Text;

            Properties.Settings.Default.Save();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox_dag_link.Text = openFileDialog1.FileName;
        }
        private void textBox_equi_link_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_start_Click(object sender, EventArgs e)
        {
            timer2.Interval = 1000; //changement tous les 10 second pour test
            timer2.Start();
        }

        public string already_mining = "null";

        private void timer2_Tick(object sender, EventArgs e)
        {
            //------------------------------IF---------------------------------------------------------------------

            if (BTC_day_dag > BTC_day_equi)
            {
                mining_renta = "Dag";
                label_resultat.Text = "faut miner l'ETHER: " + Math.Round((BTC_day_dag * 1000), 3) + " mBTC/day";
                //label_resultat_euro.Text = EUR_by_day_dag + " EUR/day   " + (double.Parse(EUR_by_day_dag)) * 30 + "EUR/MONTH";
            }
            else
            {
                mining_renta = "Equi";
                label_resultat.Text = "faut miner le ZCASH: " + Math.Round((BTC_day_equi * 1000), 3) + " mBTC/day";
                //label_resultat_euro.Text = EUR_by_day_equi + " EUR/day   " + (double.Parse(EUR_by_day_equi)) * 30 + "EUR/MONTH";
            }
            //---------------------------------------------------------------------------------------------------

            if (textBox_dag_link.Text != "" || textBox_equi_link.Text != "")
            {
                button2.Enabled = true;
                if (mining_renta == "Dag" & already_mining != "Dag")
                {
                    try
                    {
                        timer2.Stop();
                        proc.CloseMainWindow();
                        proc.Kill();
                        proc.Close();
                        already_mining = "null";
                    }
                    catch{ }

                    already_mining = "Dag";                               
                    proc.StartInfo.FileName = textBox_dag_link.Text;
                    proc.Start();                 
                }

                else if (mining_renta == "Equi" & already_mining != "Equi")
                {
                    try
                    {
                        timer2.Stop();
                        proc.CloseMainWindow();
                        proc.Kill();
                        proc.Close();
                        already_mining = "null";
                    }
                    catch { }
                       
                    already_mining = "Equi";
                    proc.StartInfo.FileName = textBox_equi_link.Text;            
                    proc.Start();
                    
                }
            }
            else
            {
                MessageBox.Show("Entrer lien vers le .bat", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            try
            {
                timer2.Stop();
                proc.CloseMainWindow();
                proc.Kill();
                proc.Close();                     
                already_mining = "null";
            }
            catch 
            {
                //
            }

        }



            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
