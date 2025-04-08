namespace LauncherFix
{
    partial class Launcher
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.pnl_SettingsMiddle = new System.Windows.Forms.Panel();
            this.pnl_SettingsLanguage = new System.Windows.Forms.Panel();
            this.cB_Language = new System.Windows.Forms.ComboBox();
            this.lbl_SelectLanguage = new System.Windows.Forms.Label();
            this.pnl_SettingsColorScheme = new System.Windows.Forms.Panel();
            this.lbl_ColorSchemeMain = new System.Windows.Forms.Label();
            this.cB_ColorSchemeMain = new System.Windows.Forms.ComboBox();
            this.pnl_SettingsTop = new System.Windows.Forms.Panel();
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_SettingsConfirm = new System.Windows.Forms.Button();
            this.pnl_bot = new System.Windows.Forms.Panel();
            this.btn_selected = new System.Windows.Forms.Button();
            this.btn_tradingbot = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_web = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimalize = new System.Windows.Forms.Button();
            this.pnl_middle = new System.Windows.Forms.Panel();
            this.pnl_tradingsimulator = new System.Windows.Forms.Panel();
            this.lbl_nametradingsimulator = new System.Windows.Forms.Label();
            this.lbl_tradingsimulator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_tradingsimulator = new System.Windows.Forms.Button();
            this.pnl_contractgenerator = new System.Windows.Forms.Panel();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.lbl_codegenerator = new System.Windows.Forms.Label();
            this.app_view = new System.Windows.Forms.PictureBox();
            this.btn_codegenerator = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnl_settings.SuspendLayout();
            this.pnl_SettingsMiddle.SuspendLayout();
            this.pnl_SettingsLanguage.SuspendLayout();
            this.pnl_SettingsColorScheme.SuspendLayout();
            this.pnl_SettingsTop.SuspendLayout();
            this.pnl_bot.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_middle.SuspendLayout();
            this.pnl_tradingsimulator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_contractgenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_view)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_settings
            // 
            this.pnl_settings.BackColor = System.Drawing.Color.Silver;
            this.pnl_settings.Controls.Add(this.pnl_SettingsMiddle);
            this.pnl_settings.Controls.Add(this.pnl_SettingsTop);
            this.pnl_settings.Controls.Add(this.btn_SettingsConfirm);
            this.pnl_settings.Location = new System.Drawing.Point(238, 0);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(389, 300);
            this.pnl_settings.TabIndex = 25;
            this.pnl_settings.Visible = false;
            // 
            // pnl_SettingsMiddle
            // 
            this.pnl_SettingsMiddle.BackColor = System.Drawing.Color.LightGray;
            this.pnl_SettingsMiddle.Controls.Add(this.pnl_SettingsLanguage);
            this.pnl_SettingsMiddle.Controls.Add(this.pnl_SettingsColorScheme);
            this.pnl_SettingsMiddle.Location = new System.Drawing.Point(15, 68);
            this.pnl_SettingsMiddle.Name = "pnl_SettingsMiddle";
            this.pnl_SettingsMiddle.Size = new System.Drawing.Size(359, 171);
            this.pnl_SettingsMiddle.TabIndex = 26;
            this.pnl_SettingsMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SettingsMiddle_Paint);
            // 
            // pnl_SettingsLanguage
            // 
            this.pnl_SettingsLanguage.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SettingsLanguage.Controls.Add(this.cB_Language);
            this.pnl_SettingsLanguage.Controls.Add(this.lbl_SelectLanguage);
            this.pnl_SettingsLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_SettingsLanguage.Location = new System.Drawing.Point(36, 27);
            this.pnl_SettingsLanguage.Margin = new System.Windows.Forms.Padding(15, 15, 15, 3);
            this.pnl_SettingsLanguage.Name = "pnl_SettingsLanguage";
            this.pnl_SettingsLanguage.Size = new System.Drawing.Size(289, 50);
            this.pnl_SettingsLanguage.TabIndex = 20;
            // 
            // cB_Language
            // 
            this.cB_Language.FormattingEnabled = true;
            this.cB_Language.Items.AddRange(new object[] {
            "Čeština (Czech)",
            "English",
            "中國人 (Chinese)",
            "Tiếng Việt (Vietnamese)",
            "한국어 (Korean)"});
            this.cB_Language.Location = new System.Drawing.Point(86, 23);
            this.cB_Language.Name = "cB_Language";
            this.cB_Language.Size = new System.Drawing.Size(112, 21);
            this.cB_Language.TabIndex = 1;
            // 
            // lbl_SelectLanguage
            // 
            this.lbl_SelectLanguage.AutoSize = true;
            this.lbl_SelectLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SelectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_SelectLanguage.Location = new System.Drawing.Point(0, 0);
            this.lbl_SelectLanguage.MinimumSize = new System.Drawing.Size(289, 0);
            this.lbl_SelectLanguage.Name = "lbl_SelectLanguage";
            this.lbl_SelectLanguage.Size = new System.Drawing.Size(289, 18);
            this.lbl_SelectLanguage.TabIndex = 0;
            this.lbl_SelectLanguage.Text = "Select language";
            this.lbl_SelectLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_SettingsColorScheme
            // 
            this.pnl_SettingsColorScheme.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SettingsColorScheme.Controls.Add(this.lbl_ColorSchemeMain);
            this.pnl_SettingsColorScheme.Controls.Add(this.cB_ColorSchemeMain);
            this.pnl_SettingsColorScheme.Location = new System.Drawing.Point(36, 95);
            this.pnl_SettingsColorScheme.Margin = new System.Windows.Forms.Padding(15, 15, 15, 3);
            this.pnl_SettingsColorScheme.Name = "pnl_SettingsColorScheme";
            this.pnl_SettingsColorScheme.Size = new System.Drawing.Size(289, 50);
            this.pnl_SettingsColorScheme.TabIndex = 21;
            // 
            // lbl_ColorSchemeMain
            // 
            this.lbl_ColorSchemeMain.AutoSize = true;
            this.lbl_ColorSchemeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ColorSchemeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ColorSchemeMain.Location = new System.Drawing.Point(0, 0);
            this.lbl_ColorSchemeMain.MinimumSize = new System.Drawing.Size(289, 0);
            this.lbl_ColorSchemeMain.Name = "lbl_ColorSchemeMain";
            this.lbl_ColorSchemeMain.Size = new System.Drawing.Size(289, 18);
            this.lbl_ColorSchemeMain.TabIndex = 21;
            this.lbl_ColorSchemeMain.Text = "Color scheme (main)";
            this.lbl_ColorSchemeMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cB_ColorSchemeMain
            // 
            this.cB_ColorSchemeMain.FormattingEnabled = true;
            this.cB_ColorSchemeMain.Items.AddRange(new object[] {
            "White",
            "Dark",
            "Black"});
            this.cB_ColorSchemeMain.Location = new System.Drawing.Point(86, 23);
            this.cB_ColorSchemeMain.Name = "cB_ColorSchemeMain";
            this.cB_ColorSchemeMain.Size = new System.Drawing.Size(112, 21);
            this.cB_ColorSchemeMain.TabIndex = 20;
            // 
            // pnl_SettingsTop
            // 
            this.pnl_SettingsTop.BackColor = System.Drawing.Color.LightGray;
            this.pnl_SettingsTop.Controls.Add(this.lbl_Settings);
            this.pnl_SettingsTop.Controls.Add(this.button2);
            this.pnl_SettingsTop.Location = new System.Drawing.Point(15, 15);
            this.pnl_SettingsTop.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnl_SettingsTop.Name = "pnl_SettingsTop";
            this.pnl_SettingsTop.Size = new System.Drawing.Size(359, 40);
            this.pnl_SettingsTop.TabIndex = 25;
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.AutoSize = true;
            this.lbl_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Settings.Location = new System.Drawing.Point(151, 10);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(68, 20);
            this.lbl_Settings.TabIndex = 22;
            this.lbl_Settings.Text = "Settings";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(324, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "✖";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_SettingsConfirm
            // 
            this.btn_SettingsConfirm.BackColor = System.Drawing.Color.LightGray;
            this.btn_SettingsConfirm.FlatAppearance.BorderSize = 0;
            this.btn_SettingsConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_SettingsConfirm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_SettingsConfirm.Location = new System.Drawing.Point(17, 252);
            this.btn_SettingsConfirm.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.btn_SettingsConfirm.Name = "btn_SettingsConfirm";
            this.btn_SettingsConfirm.Size = new System.Drawing.Size(359, 30);
            this.btn_SettingsConfirm.TabIndex = 23;
            this.btn_SettingsConfirm.Text = "Confirm";
            this.btn_SettingsConfirm.UseVisualStyleBackColor = false;
            this.btn_SettingsConfirm.Click += new System.EventHandler(this.btn_click);
            // 
            // pnl_bot
            // 
            this.pnl_bot.BackColor = System.Drawing.Color.DimGray;
            this.pnl_bot.Controls.Add(this.btn_selected);
            this.pnl_bot.Controls.Add(this.btn_tradingbot);
            this.pnl_bot.Location = new System.Drawing.Point(26, 421);
            this.pnl_bot.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.pnl_bot.Name = "pnl_bot";
            this.pnl_bot.Size = new System.Drawing.Size(840, 60);
            this.pnl_bot.TabIndex = 23;
            // 
            // btn_selected
            // 
            this.btn_selected.BackColor = System.Drawing.Color.Transparent;
            this.btn_selected.FlatAppearance.BorderSize = 0;
            this.btn_selected.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_selected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_selected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_selected.ForeColor = System.Drawing.Color.Black;
            this.btn_selected.Location = new System.Drawing.Point(418, 15);
            this.btn_selected.Margin = new System.Windows.Forms.Padding(5);
            this.btn_selected.Name = "btn_selected";
            this.btn_selected.Size = new System.Drawing.Size(40, 40);
            this.btn_selected.TabIndex = 10;
            this.btn_selected.Text = "📜";
            this.btn_selected.UseVisualStyleBackColor = false;
            this.btn_selected.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_tradingbot
            // 
            this.btn_tradingbot.BackColor = System.Drawing.Color.Transparent;
            this.btn_tradingbot.FlatAppearance.BorderSize = 0;
            this.btn_tradingbot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_tradingbot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_tradingbot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_tradingbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tradingbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_tradingbot.Location = new System.Drawing.Point(368, 15);
            this.btn_tradingbot.Margin = new System.Windows.Forms.Padding(5);
            this.btn_tradingbot.Name = "btn_tradingbot";
            this.btn_tradingbot.Size = new System.Drawing.Size(40, 40);
            this.btn_tradingbot.TabIndex = 12;
            this.btn_tradingbot.Text = "🤖";
            this.btn_tradingbot.UseVisualStyleBackColor = false;
            this.btn_tradingbot.Click += new System.EventHandler(this.btn_click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.DimGray;
            this.pnl_top.Controls.Add(this.btn_web);
            this.pnl_top.Controls.Add(this.btn_settings);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.btn_minimalize);
            this.pnl_top.Location = new System.Drawing.Point(26, 19);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(840, 60);
            this.pnl_top.TabIndex = 24;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // btn_web
            // 
            this.btn_web.BackColor = System.Drawing.Color.Transparent;
            this.btn_web.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_web.FlatAppearance.BorderSize = 0;
            this.btn_web.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_web.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_web.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_web.ForeColor = System.Drawing.Color.Black;
            this.btn_web.Location = new System.Drawing.Point(52, 9);
            this.btn_web.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_web.Name = "btn_web";
            this.btn_web.Size = new System.Drawing.Size(40, 40);
            this.btn_web.TabIndex = 5;
            this.btn_web.Text = "🌐";
            this.btn_web.UseVisualStyleBackColor = false;
            this.btn_web.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_settings.ForeColor = System.Drawing.Color.Black;
            this.btn_settings.Location = new System.Drawing.Point(7, 9);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(40, 40);
            this.btn_settings.TabIndex = 20;
            this.btn_settings.Text = "⚙️";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(356, 15);
            this.label1.MaximumSize = new System.Drawing.Size(840, 0);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(795, 9);
            this.btn_close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "✖";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_minimalize
            // 
            this.btn_minimalize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimalize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimalize.FlatAppearance.BorderSize = 0;
            this.btn_minimalize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_minimalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_minimalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_minimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_minimalize.ForeColor = System.Drawing.Color.Black;
            this.btn_minimalize.Location = new System.Drawing.Point(750, 9);
            this.btn_minimalize.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btn_minimalize.Name = "btn_minimalize";
            this.btn_minimalize.Size = new System.Drawing.Size(40, 40);
            this.btn_minimalize.TabIndex = 4;
            this.btn_minimalize.Text = "➖";
            this.btn_minimalize.UseVisualStyleBackColor = false;
            this.btn_minimalize.Click += new System.EventHandler(this.btn_click);
            // 
            // pnl_middle
            // 
            this.pnl_middle.BackColor = System.Drawing.Color.DimGray;
            this.pnl_middle.Controls.Add(this.pnl_settings);
            this.pnl_middle.Controls.Add(this.pnl_tradingsimulator);
            this.pnl_middle.Controls.Add(this.pnl_contractgenerator);
            this.pnl_middle.Location = new System.Drawing.Point(26, 99);
            this.pnl_middle.Margin = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.pnl_middle.Name = "pnl_middle";
            this.pnl_middle.Size = new System.Drawing.Size(840, 300);
            this.pnl_middle.TabIndex = 22;
            // 
            // pnl_tradingsimulator
            // 
            this.pnl_tradingsimulator.BackColor = System.Drawing.Color.Gray;
            this.pnl_tradingsimulator.Controls.Add(this.lbl_nametradingsimulator);
            this.pnl_tradingsimulator.Controls.Add(this.lbl_tradingsimulator);
            this.pnl_tradingsimulator.Controls.Add(this.pictureBox1);
            this.pnl_tradingsimulator.Controls.Add(this.btn_tradingsimulator);
            this.pnl_tradingsimulator.Location = new System.Drawing.Point(17, 20);
            this.pnl_tradingsimulator.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pnl_tradingsimulator.Name = "pnl_tradingsimulator";
            this.pnl_tradingsimulator.Size = new System.Drawing.Size(801, 262);
            this.pnl_tradingsimulator.TabIndex = 20;
            // 
            // lbl_nametradingsimulator
            // 
            this.lbl_nametradingsimulator.AutoSize = true;
            this.lbl_nametradingsimulator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nametradingsimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nametradingsimulator.Location = new System.Drawing.Point(394, 26);
            this.lbl_nametradingsimulator.MaximumSize = new System.Drawing.Size(840, 0);
            this.lbl_nametradingsimulator.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_nametradingsimulator.Name = "lbl_nametradingsimulator";
            this.lbl_nametradingsimulator.Size = new System.Drawing.Size(183, 26);
            this.lbl_nametradingsimulator.TabIndex = 19;
            this.lbl_nametradingsimulator.Text = "Trading Simulator";
            this.lbl_nametradingsimulator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tradingsimulator
            // 
            this.lbl_tradingsimulator.AutoSize = true;
            this.lbl_tradingsimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_tradingsimulator.Location = new System.Drawing.Point(390, 52);
            this.lbl_tradingsimulator.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbl_tradingsimulator.MinimumSize = new System.Drawing.Size(0, 150);
            this.lbl_tradingsimulator.Name = "lbl_tradingsimulator";
            this.lbl_tradingsimulator.Size = new System.Drawing.Size(389, 150);
            this.lbl_tradingsimulator.TabIndex = 18;
            this.lbl_tradingsimulator.Text = resources.GetString("lbl_tradingsimulator.Text");
            this.lbl_tradingsimulator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LauncherFix.Resources.trading_simulator;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_tradingsimulator
            // 
            this.btn_tradingsimulator.BackColor = System.Drawing.Color.DimGray;
            this.btn_tradingsimulator.FlatAppearance.BorderSize = 0;
            this.btn_tradingsimulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tradingsimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_tradingsimulator.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_tradingsimulator.Location = new System.Drawing.Point(678, 207);
            this.btn_tradingsimulator.Margin = new System.Windows.Forms.Padding(5);
            this.btn_tradingsimulator.Name = "btn_tradingsimulator";
            this.btn_tradingsimulator.Size = new System.Drawing.Size(118, 50);
            this.btn_tradingsimulator.TabIndex = 16;
            this.btn_tradingsimulator.Text = "Launch";
            this.btn_tradingsimulator.UseVisualStyleBackColor = false;
            this.btn_tradingsimulator.Click += new System.EventHandler(this.btn_click);
            // 
            // pnl_contractgenerator
            // 
            this.pnl_contractgenerator.BackColor = System.Drawing.Color.Gray;
            this.pnl_contractgenerator.Controls.Add(this.lbl_appname);
            this.pnl_contractgenerator.Controls.Add(this.lbl_codegenerator);
            this.pnl_contractgenerator.Controls.Add(this.app_view);
            this.pnl_contractgenerator.Controls.Add(this.btn_codegenerator);
            this.pnl_contractgenerator.Location = new System.Drawing.Point(19, 20);
            this.pnl_contractgenerator.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.pnl_contractgenerator.Name = "pnl_contractgenerator";
            this.pnl_contractgenerator.Size = new System.Drawing.Size(801, 262);
            this.pnl_contractgenerator.TabIndex = 3;
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_appname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_appname.Location = new System.Drawing.Point(394, 26);
            this.lbl_appname.MaximumSize = new System.Drawing.Size(840, 0);
            this.lbl_appname.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(167, 26);
            this.lbl_appname.TabIndex = 19;
            this.lbl_appname.Text = "Code Generator";
            this.lbl_appname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_codegenerator
            // 
            this.lbl_codegenerator.AutoSize = true;
            this.lbl_codegenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_codegenerator.Location = new System.Drawing.Point(390, 52);
            this.lbl_codegenerator.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbl_codegenerator.MinimumSize = new System.Drawing.Size(0, 150);
            this.lbl_codegenerator.Name = "lbl_codegenerator";
            this.lbl_codegenerator.Size = new System.Drawing.Size(389, 150);
            this.lbl_codegenerator.TabIndex = 18;
            this.lbl_codegenerator.Text = resources.GetString("lbl_codegenerator.Text");
            this.lbl_codegenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // app_view
            // 
            this.app_view.Image = global::LauncherFix.Resources.code_generator1;
            this.app_view.Location = new System.Drawing.Point(6, 5);
            this.app_view.Name = "app_view";
            this.app_view.Size = new System.Drawing.Size(367, 254);
            this.app_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.app_view.TabIndex = 17;
            this.app_view.TabStop = false;
            // 
            // btn_codegenerator
            // 
            this.btn_codegenerator.BackColor = System.Drawing.Color.DimGray;
            this.btn_codegenerator.FlatAppearance.BorderSize = 0;
            this.btn_codegenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_codegenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_codegenerator.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_codegenerator.Location = new System.Drawing.Point(678, 207);
            this.btn_codegenerator.Margin = new System.Windows.Forms.Padding(5);
            this.btn_codegenerator.Name = "btn_codegenerator";
            this.btn_codegenerator.Size = new System.Drawing.Size(118, 50);
            this.btn_codegenerator.TabIndex = 16;
            this.btn_codegenerator.Text = "Launch";
            this.btn_codegenerator.UseVisualStyleBackColor = false;
            this.btn_codegenerator.Click += new System.EventHandler(this.btn_click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnl_bot);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_middle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnl_settings.ResumeLayout(false);
            this.pnl_SettingsMiddle.ResumeLayout(false);
            this.pnl_SettingsLanguage.ResumeLayout(false);
            this.pnl_SettingsLanguage.PerformLayout();
            this.pnl_SettingsColorScheme.ResumeLayout(false);
            this.pnl_SettingsColorScheme.PerformLayout();
            this.pnl_SettingsTop.ResumeLayout(false);
            this.pnl_SettingsTop.PerformLayout();
            this.pnl_bot.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_middle.ResumeLayout(false);
            this.pnl_tradingsimulator.ResumeLayout(false);
            this.pnl_tradingsimulator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_contractgenerator.ResumeLayout(false);
            this.pnl_contractgenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.Panel pnl_SettingsMiddle;
        private System.Windows.Forms.ComboBox cB_Language;
        private System.Windows.Forms.Label lbl_SelectLanguage;
        private System.Windows.Forms.Panel pnl_SettingsColorScheme;
        private System.Windows.Forms.ComboBox cB_ColorSchemeMain;
        private System.Windows.Forms.Panel pnl_SettingsTop;
        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_SettingsConfirm;
        private System.Windows.Forms.Panel pnl_bot;
        private System.Windows.Forms.Button btn_selected;
        private System.Windows.Forms.Button btn_tradingbot;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_web;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimalize;
        private System.Windows.Forms.Panel pnl_middle;
        private System.Windows.Forms.Panel pnl_contractgenerator;
        private System.Windows.Forms.Button btn_codegenerator;
        private System.Windows.Forms.Panel pnl_SettingsLanguage;
        private System.Windows.Forms.Label lbl_ColorSchemeMain;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_codegenerator;
        private System.Windows.Forms.PictureBox app_view;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Panel pnl_tradingsimulator;
        private System.Windows.Forms.Label lbl_nametradingsimulator;
        private System.Windows.Forms.Label lbl_tradingsimulator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_tradingsimulator;
    }
}

