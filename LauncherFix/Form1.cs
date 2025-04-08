using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovableForm;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using ContractGenerator;
using trading_simulator;

namespace LauncherFix
{
    public partial class Launcher : Form
    {

        //private string Language;
        //private bool CloseLaungherOnAPPLaunch;
        private Color hover = Color.DarkMagenta;
        //private string ColorScheme;


        private Color Scheme_Ligher;
        private Color Scheme_Darker;
        private Color Scheme_Text;

        private bool codegenerator = false;
        private bool tradingsimulator = false;
        public Launcher()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            setSettings();


            //    Language = Properties.Settings.Default.Language;
              //  CloseLaungherOnAPPLaunch = Properties.Settings.Default.CloseLauncherOnAPPStart;
                //hover = Properties.Settings.Default.HoverColor;
                //ColorScheme = Properties.Settings.Default.ColorScheme; */

            string download_msg = Properties.Resources.Download;

            btn_codegenerator.Text = download_msg;
            language();



        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) // zpristupneni pohyblovosti okna aplikace
        {
            MovableForm.MovableForm.MouseDown(e, MouseButtons.Left, Handle);
        }


        private void language()
        {

            // Detekce vybraného jazyka a poté zavolání LanguageHandler funkce
            if (Properties.Settings.Default.Language == "Čeština (Czech)")
            {
                LanguageHandler("cs-CZ");
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                LanguageHandler("");
            }
            else if (Properties.Settings.Default.Language == "中國人 (Chinese)")
            {
                LanguageHandler("zh-CN");
            }
            else if (Properties.Settings.Default.Language == "Tiếng Việt (Vietnamese)")
            {
                LanguageHandler("vi-VN");
            }
            else if (Properties.Settings.Default.Language == "한국어 (Korean)")
            {
                LanguageHandler("ko-KR");
            }


            // Nastavení obsahu textu jednotlivých komponent na daný text.
            btn_codegenerator.Text = Properties.Resources.Download;
            lbl_Settings.Text = Properties.Resources.Settings;
            lbl_ColorSchemeMain.Text = Properties.Resources.SelectColorSchemeMainMSG;
            lbl_SelectLanguage.Text = Properties.Resources.SelectLanguageMSG;
            btn_SettingsConfirm.Text = Properties.Resources.ConfirmMSG;

        }


  

        private void setSettings() // funkce pro aktualizaci nastaveni preferenci uživatele
        {
            try
            {
                // Detekce vybraného barevného schéma
                if (Properties.Settings.Default.ColorScheme == "White")

                {
                    Scheme_Ligher = Color.FromArgb(222, 222, 222);
                    Scheme_Darker = Color.Silver;
                    Scheme_Text = Color.FromArgb(64, 64, 64);
                }
                else if (Properties.Settings.Default.ColorScheme == "Dark")
                {
                    Scheme_Ligher = Color.DimGray;
                    Scheme_Darker = Color.FromArgb(75, 75, 75);
                    Scheme_Text = Color.LightGray;
                }
                else if (Properties.Settings.Default.ColorScheme == "Black")
                {
                    Scheme_Ligher = Color.FromArgb(44, 44, 44);
                    Scheme_Darker = Color.FromArgb(33, 33, 33);
                    Scheme_Text = Color.FromArgb(200, 200, 200);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // hlavni aplikace (form)
            this.BackColor = Scheme_Darker;
            pnl_top.BackColor = Scheme_Ligher;
            pnl_bot.BackColor = Scheme_Ligher;
            pnl_middle.BackColor = Scheme_Ligher;
            pnl_contractgenerator.BackColor = Scheme_Ligher;
            btn_codegenerator.BackColor = Scheme_Ligher;
            // panel s nastavenim
            pnl_settings.BackColor = Scheme_Darker;
            pnl_SettingsMiddle.BackColor = Scheme_Ligher;
            pnl_SettingsTop.BackColor = Scheme_Ligher;
            btn_SettingsConfirm.BackColor = Scheme_Ligher;
            btn_tradingbot.BackColor = Scheme_Ligher;
            btn_tradingsimulator.BackColor = Scheme_Ligher;
            pnl_tradingsimulator.BackColor = Scheme_Ligher;

            // zobrazeni vybranych preferenci nastaveni po vypnuti a zapnuti aplikace
            cB_Language.Text = Properties.Settings.Default.Language;
            cB_ColorSchemeMain.Text = Properties.Settings.Default.ColorScheme;

            // Zavolání funkce, která nastaví všem specifickým kompontentům barevné schéma pro zredukování obsahu kódu
            DetectObjects(this);
        }

    private void DetectObjects(Control parent) // zdroj: https://learn.microsoft.com/en-us/answers/questions/1380697/controls-inside-controls
    {
        foreach (Control control in parent.Controls)
        {
            // detekce vsech buttonu, labelu a checkboxu
            if (control is Button btn || control is Label lbl || control is CheckBox checkB)
            {
                control.ForeColor = Scheme_Text;
            }
            // detekce pokud je objekt napriklad vlozen v panelu
            else if (control.HasChildren)
            {
                DetectObjects(control);
            }
        }
    }

    private void unselect()
        {
            btn_tradingbot.Font = new Font("Arial", 14);
            btn_selected.Font = new Font("Arial", 14);
            pnl_tradingsimulator.Visible = false;
            pnl_contractgenerator.Visible = false;
        }

    private void btn_click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        if (btn != null)
        {
            switch (btn.Text)
            {
                case "🤖":
                        unselect();
                        lbl_appname.Text = "Trading Simulator";
                        app_view.Image = Resources.trading_simulator;
                        btn_tradingbot.Font = new Font("Arial", 20);
                        pnl_tradingsimulator.Visible = true;
                        break;
                case "📜":
                        unselect();
                        lbl_appname.Text = "Code Generator";
                        app_view.Image = LauncherFix.Resources.code_generator1;
                        btn_selected.Font = new Font("Arial", 20);
                        pnl_contractgenerator.Visible = true;
                        break;
                case "➖":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "🌐":
                        // odkaz na vlastni web
                        System.Diagnostics.Process.Start("facebook.com");

                        break;
                case "⚙️":
                    btn_settings.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                    pnl_settings.Visible = true;
                    btn_settings.ForeColor = hover;
                    break;
                default:
                    break;

            }
            //detekce nazvu buttonu, jelikoz nektere buttony maji stejny text (X-ko), nebo se zmeni text buttnu pri zmene jazyka.
            switch (btn.Name)
            {
                case "btn_SettingsConfirm":
                    SettingsUpdater();
                    setSettings();
                  language();
                    break;
                case "btn_tradingsimulator":
                    // odkaz na stazeni na vlastnim webu
                    if(Class1.launched == false)
                        {
                            Class1.Launch();
                        }
                    else
                        {
                            MessageBox.Show("Error, trading simulator is already running...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                case "btn_codegenerator":
                        if (Class2.launched == false)
                        {
                           
                            Class2.Launch();
                            codegenerator = true;
                        }
                        else
                        {
                            MessageBox.Show("Error, trading simulator is already running...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    break;
                case "button2":
                    btn_settings.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                    pnl_settings.Visible = false;
                    btn_settings.ForeColor = Scheme_Text;
                    break;
                case "btn_close":
                    Properties.Settings.Default.Save();
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    } // vseobecny event pro kliknuti na jakykoliv button, tento event je pak rucne prirazen vsem buttnum


        private void SaveSettingsToJson(string languageCode, string theme)
        {
            // Dokumentace pro práci s JSON - https://learn.microsoft.com/en-us/dotnet/api/system.text.json?view=net-9.0
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            try
            {
                var settingsData = new
                {
                    Language = languageCode,
                    Theme = theme,
                };

                // Zformátování stringu do typu json (aby vše nebylo v jednom řádku....)
                string jsonString = JsonSerializer.Serialize(settingsData);

                File.WriteAllText(jsonFilePath, jsonString);
                MessageBox.Show($"JSON File Path: {jsonFilePath}\nJSON Data:\n{jsonString}", "Settings Saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving settings to JSON: {ex.Message}");
                MessageBox.Show($"Error saving settings to JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SettingsUpdater()
        {
            string selectedLanguage = cB_Language.SelectedItem?.ToString() ?? ""; 
            string selectedTheme = cB_ColorSchemeMain.SelectedItem?.ToString() ?? "";


            Properties.Settings.Default.Language = selectedLanguage;
            Properties.Settings.Default.ColorScheme = selectedTheme;

            // !! nutnost ulozeni dat, bez toho prikazu by se data nikdy neulozila
            Properties.Settings.Default.Save();


            SaveSettingsToJson(selectedLanguage, selectedTheme); 

        }

        private void LanguageHandler(string language)
    {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }

        private void pnl_SettingsMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            MovableForm.MovableForm.MouseDown(e, MouseButtons.Left, Handle);
        }
    }
}