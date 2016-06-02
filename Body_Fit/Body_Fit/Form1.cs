using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Fit
{
    public partial class Body_Fit_Program : Form
    {
        public Body_Fit_Program()
        {
            InitializeComponent();
        }

        private void button1Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1Man.Checked)
                {
                    double A, B, C, D;
                    A = (double.Parse(textBox4Hansh.Text)*0.55) - 2;
                    B = (double.Parse(textBox3Talia.Text)*0.29) - 4;
                    C = A + B;
                    D = (double.Parse(textBox2Visochina.Text)*0.24);
                    double maznini = (C - D) - 10;
                    double obshtiKilogrami = maznini*(double.Parse(textBox5Teglo.Text)/100);

                    //формулата на Katch-McArdle
                    double aktivnoTeglo = double.Parse(textBox5Teglo.Text) -
                                          (double.Parse(textBox5Teglo.Text)*(double.Parse(maznini.ToString())/100));
                    double RMR = 370 + (21.6*double.Parse(aktivnoTeglo.ToString()));
                    double aktivnost = 0;

                    if (radioButton1Zasednal.Checked)
                    {
                        aktivnost = +1.2;
                    }

                    if (radioButton2LekaAktivnost.Checked)
                    {
                        aktivnost = +1.375;
                    }

                    if (radioButton3UmerenaAktivnost.Checked)
                    {
                        aktivnost = +1.55;
                    }

                    if (radioButton4VisokaAktivnost.Checked)
                    {
                        aktivnost = +1.725;
                    }

                    double KalorienBalans = RMR*aktivnost;

                    //МЪЖЕ
                    if (maznini >= 3 && maznini < 6)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Състезателна форма\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                    }

                    if (maznini >= 6 && maznini < 9)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Много релефен\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                    }

                    if (maznini >= 9 && maznini < 12)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Релефен\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                    }

                    if (maznini >= 12 && maznini < 15)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Чист\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                    }

                    if (maznini >= 15 && maznini < 18)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Нормален\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                    }

                    if (maznini >= 18 && maznini < 22)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Леко затлъстял\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);

                        //В:Б:М
                        double otricatalenBalans = KalorienBalans - (KalorienBalans*0.15);

                        double vuglehidrati = (otricatalenBalans*0.45)/double.Parse(textBox2HraneniaDen.Text);
                        double gramaVuglehidrati = (vuglehidrati/4);

                        double protein = (otricatalenBalans*0.35) / double.Parse(textBox2HraneniaDen.Text); 
                        double gramaProtein = (protein/4);

                        double mazninite = (otricatalenBalans*0.20)/ double.Parse(textBox2HraneniaDen.Text);
                        double gramamaznini = (mazninite/9);
                        string hranenia = textBox2HraneniaDen.Text;
                        richTextBox1.Text +=
                            String.Format(
                                "\nОтрицателен калориен баланс: {0:f2} калории\nПри {1} хранения на ден, приема на В:Б:М е: \nВъглехидрати за едно хранене: {3:f2} грама = {2:f2} калории\nБелтъчини за едно хранене: {4:f2} грама = {5:f2} калории\nМазнини за едно хранене: {6:f2} грама = {7:f2} калории",
                                otricatalenBalans, hranenia, vuglehidrati, gramaVuglehidrati, gramaProtein, protein,
                                gramamaznini, mazninite);
                    }

                    if (maznini >= 22 && maznini < 26)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Затлъстял\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                        //В:Б:М
                        double otricatalenBalans = KalorienBalans - (KalorienBalans * 0.15);

                        double vuglehidrati = (otricatalenBalans * 0.45) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaVuglehidrati = (vuglehidrati / 4);

                        double protein = (otricatalenBalans * 0.35) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaProtein = (protein / 4);

                        double mazninite = (otricatalenBalans * 0.20) / double.Parse(textBox2HraneniaDen.Text);
                        double gramamaznini = (mazninite / 9);
                        string hranenia = textBox2HraneniaDen.Text;
                        richTextBox1.Text +=
                            String.Format(
                                "\nОтрицателен калориен баланс: {0:f2} калории\nПри {1} хранения на ден, приема на В:Б:М е: \nВъглехидрати за едно хранене: {3:f2} грама = {2:f2} калории\nБелтъчини за едно хранене: {4:f2} грама = {5:f2} калории\nМазнини за едно хранене: {6:f2} грама = {7:f2} калории",
                                otricatalenBalans, hranenia, vuglehidrati, gramaVuglehidrati, gramaProtein, protein,
                                gramamaznini, mazninite);

                    }

                    if (maznini >= 26)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Сериозно затлъстял\"\nКалориен баланс: {2:f2} калории",
                                maznini, obshtiKilogrami, KalorienBalans);
                        //В:Б:М
                        double otricatalenBalans = KalorienBalans - (KalorienBalans * 0.15);

                        double vuglehidrati = (otricatalenBalans * 0.45) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaVuglehidrati = (vuglehidrati / 4);

                        double protein = (otricatalenBalans * 0.35) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaProtein = (protein / 4);

                        double mazninite = (otricatalenBalans * 0.20) / double.Parse(textBox2HraneniaDen.Text);
                        double gramamaznini = (mazninite / 9);
                        string hranenia = textBox2HraneniaDen.Text;
                        richTextBox1.Text +=
                            String.Format(
                                "\nОтрицателен калориен баланс: {0:f2} калории\nПри {1} хранения на ден, приема на В:Б:М е: \nВъглехидрати за едно хранене: {3:f2} грама = {2:f2} калории\nБелтъчини за едно хранене: {4:f2} грама = {5:f2} калории\nМазнини за едно хранене: {6:f2} грама = {7:f2} калории",
                                otricatalenBalans, hranenia, vuglehidrati, gramaVuglehidrati, gramaProtein, protein,
                                gramamaznini, mazninite);

                    }
                    if (maznini <= 2)
                    {
                        richTextBox1.Text = "Много си слаб\n";
                    }
                }
                //ЖЕНИ
                if (radioButton2Woman.Checked)
                {
                    double A2, B2, C2, D2;
                    A2 = ((double.Parse(textBox4Hansh.Text)*0.55)) - 1;
                    B2 = ((double.Parse(textBox3Talia.Text))*0.29) - 2;
                    C2 = A2 + B2;
                    D2 = ((double.Parse(textBox2Visochina.Text)*0.24));
                    double maznini2 = (C2 - D2) - 10;
                    double obshtiKilogrami2 = maznini2*((double.Parse(textBox5Teglo.Text)/100));

                    //формулата на Katch-McArdle
                    double aktivnoTeglo2 = double.Parse(textBox5Teglo.Text) -
                                           (double.Parse(textBox5Teglo.Text)*(double.Parse(maznini2.ToString())/100));
                    double RMR2 = 370 + (21.6*double.Parse(aktivnoTeglo2.ToString()));
                    double aktivnost2 = 0;

                    if (radioButton1Zasednal.Checked)
                    {
                        aktivnost2 = +1.2;
                    }

                    if (radioButton2LekaAktivnost.Checked)
                    {
                        aktivnost2 = +1.375;
                    }

                    if (radioButton3UmerenaAktivnost.Checked)
                    {
                        aktivnost2 = +1.55;
                    }

                    if (radioButton4VisokaAktivnost.Checked)
                    {
                        aktivnost2 = +1.725;
                    }

                    double KalorienBalans2 = RMR2*aktivnost2;

                    if (maznini2 >= 7 && maznini2 < 10)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Състезателна форма\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);
                    }

                    if (maznini2 >= 10 && maznini2 < 12)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Много релефенa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);
                    }

                    if (maznini2 >= 12 && maznini2 < 15)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Релефенa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);
                    }

                    if (maznini2 >= 15 && maznini2 < 18)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Чистa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);
                    }

                    if (maznini2 >= 18 && maznini2 < 22)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Нормаленa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);
                    }

                    if (maznini2 >= 22 && maznini2 < 25)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Леко затлъстялa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);

                        //В:Б:М
                        double otricatalenBalans = KalorienBalans2 - (KalorienBalans2 * 0.15);

                        double vuglehidrati = (otricatalenBalans * 0.45) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaVuglehidrati = (vuglehidrati / 4);

                        double protein = (otricatalenBalans * 0.35) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaProtein = (protein / 4);

                        double mazninite = (otricatalenBalans * 0.20) / double.Parse(textBox2HraneniaDen.Text);
                        double gramamaznini = (mazninite / 9);
                        string hranenia = textBox2HraneniaDen.Text;
                        richTextBox1.Text +=
                            String.Format(
                                "\nОтрицателен калориен баланс: {0:f2} калории\nПри {1} хранения на ден, приема на В:Б:М е: \nВъглехидрати за едно хранене: {3:f2} грама = {2:f2} калории\nБелтъчини за едно хранене: {4:f2} грама = {5:f2} калории\nМазнини за едно хранене: {6:f2} грама = {7:f2} калории",
                                otricatalenBalans, hranenia, vuglehidrati, gramaVuglehidrati, gramaProtein, protein,
                                gramamaznini, mazninite);

                    }

                    if (maznini2 >= 25 && maznini2 < 30)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Затлъстялa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);

                        //В:Б:М
                        double otricatalenBalans = KalorienBalans2 - (KalorienBalans2 * 0.15);

                        double vuglehidrati = (otricatalenBalans * 0.45) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaVuglehidrati = (vuglehidrati / 4);

                        double protein = (otricatalenBalans * 0.35) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaProtein = (protein / 4);

                        double mazninite = (otricatalenBalans * 0.20) / double.Parse(textBox2HraneniaDen.Text);
                        double gramamaznini = (mazninite / 9);
                        string hranenia = textBox2HraneniaDen.Text;
                        richTextBox1.Text +=
                            String.Format(
                                "\nОтрицателен калориен баланс: {0:f2} калории\nПри {1} хранения на ден, приема на В:Б:М е: \nВъглехидрати за едно хранене: {3:f2} грама = {2:f2} калории\nБелтъчини за едно хранене: {4:f2} грама = {5:f2} калории\nМазнини за едно хранене: {6:f2} грама = {7:f2} калории",
                                otricatalenBalans, hranenia, vuglehidrati, gramaVuglehidrati, gramaProtein, protein,
                                gramamaznini, mazninite);

                    }

                    if (maznini2 >= 30)
                    {
                        richTextBox1.Text =
                            String.Format(
                                "Твоят % подкожни мазнини e: {0:f2} % \nОбщо кг мазнини: {1:f2} кг\nПопадаш в категорията \"Сериозно затлъстялa\"\nКалориен баланс: {2:f2} калории",
                                maznini2, obshtiKilogrami2, KalorienBalans2);

                        //В:Б:М
                        double otricatalenBalans = KalorienBalans2 - (KalorienBalans2 * 0.15);

                        double vuglehidrati = (otricatalenBalans * 0.45) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaVuglehidrati = (vuglehidrati / 4);

                        double protein = (otricatalenBalans * 0.35) / double.Parse(textBox2HraneniaDen.Text);
                        double gramaProtein = (protein / 4);

                        double mazninite = (otricatalenBalans * 0.20) / double.Parse(textBox2HraneniaDen.Text);
                        double gramamaznini = (mazninite / 9);
                        string hranenia = textBox2HraneniaDen.Text;
                        richTextBox1.Text +=
                            String.Format(
                                "\nОтрицателен калориен баланс: {0:f2} калории\nПри {1} хранения на ден, приема на В:Б:М е: \nВъглехидрати за едно хранене: {3:f2} грама = {2:f2} калории\nБелтъчини за едно хранене: {4:f2} грама = {5:f2} калории\nМазнини за едно хранене: {6:f2} грама = {7:f2} калории",
                                otricatalenBalans, hranenia, vuglehidrati, gramaVuglehidrati, gramaProtein, protein,
                                gramamaznini, mazninite);

                    }
                    if (maznini2 <= 6)
                    {
                        richTextBox1.Text = "Много си слаба\n";
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Моля попълнете всички полета");
            }
        }

        private void button2Clear_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in panel1.Controls)
            {
                txt = ctrl as TextBox;
                if (txt != null)
                {
                    txt.Text = "";
                    txt.BackColor = SystemColors.Window;
                    txt.Tag = false;
                }
            }
            richTextBox1.Clear();
        }

        private void button3Save_Click(object sender, EventArgs e)
        {
            string sv =
                String.Format(
                    "Дата: {0}\n\n\tИме: {1}\n\tВисочина: {2} см\n\tХанш: {3} см\n\tТалия: {4} см\n\tТегло: {5:f2} кг\n\n{6}",
                    dateTimePicker1.Text, textBox1Name.Text, textBox2Visochina.Text, textBox4Hansh.Text,
                    textBox3Talia.Text, textBox5Teglo.Text, richTextBox1.Text);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|Txt *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(save.FileName, sv);
            }
        }

        private void button4Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2Visochina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }

        private void textBox4Hansh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }

        private void textBox3Talia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }

        private void textBox5Teglo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }

        private void textBox2HraneniaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 49 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 44) e.Handled = true;
        }
    }
}