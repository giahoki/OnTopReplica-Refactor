using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OnTopReplica.Properties;
using System.Globalization;

namespace OnTopReplica.SidePanels {
    partial class OptionsPanel : SidePanel {

        public OptionsPanel() {
            InitializeComponent();

            LocalizePanel();
        }

        private void LocalizePanel() {
            groupLanguage.Text = Strings.SettingsLanguageTitle;
            lblLanguage.Text = Strings.SettingsRestartRequired;

            groupHotkeys.Text = Strings.SettingsHotKeyTitle;
            lblHotKeyShowHide.Text = Strings.SettingsHotKeyShowHide;
            lblHotKeyClone.Text = Strings.SettingsHotKeyClone;
            label1.Text = Strings.SettingsHotKeyDescription;

            btnClose.Text = Strings.MenuClose;
        }

        public override void OnFirstShown(MainForm form) {
            base.OnFirstShown(form);

            PopulateLanguageComboBox();

            //Stop hotkey handling and load current shortcuts
            form.MessagePumpManager.Get<OnTopReplica.MessagePumpProcessors.HotKeyManager>().Enabled = false;
            txtHotKeyShowHide.Text = Settings.Default.HotKeyShowHide;
            txtHotKeyClone.Text = Settings.Default.HotKeyCloneCurrent;
        }

        private void Close_click(object sender, EventArgs e) {
            OnRequestClosing();
        }

        public override string Title {
            get {
                return Strings.SettingsTitle;
            }
        }

        public override void OnClosing(MainForm form) {
            base.OnClosing(form);

            //Update hotkey settings and update processor
            Settings.Default.HotKeyShowHide = txtHotKeyShowHide.Text;
            Settings.Default.HotKeyCloneCurrent = txtHotKeyClone.Text;
            var manager = form.MessagePumpManager.Get<OnTopReplica.MessagePumpProcessors.HotKeyManager>();
            manager.RefreshHotkeys();
            manager.Enabled = true;
        }

        #region Language

        class CultureWrapper {
            public CultureWrapper(string name, CultureInfo culture, Image img) {
                Culture = culture;
                Image = img;
                Name = name;
            }
            public CultureInfo Culture { get; set; }
            public Image Image { get; set; }
            public string Name { get; set; }
        }

        CultureWrapper[] _languageList = {
            new CultureWrapper("Auto", CultureInfo.InvariantCulture, null),
            new CultureWrapper("English", new CultureInfo("en-US"), Resources.flag_usa),
            new CultureWrapper("Čeština", new CultureInfo("cs-CZ"), Resources.flag_czech),
            new CultureWrapper("Dansk", new CultureInfo("da-DK"), Resources.flag_danish),
            new CultureWrapper("Deutsch", new CultureInfo("de-DE"), Resources.flag_germany),
            new CultureWrapper("Español", new CultureInfo("es-ES"), Resources.flag_spanish),
            new CultureWrapper("Italiano", new CultureInfo("it-IT"), Resources.flag_ita),
            new CultureWrapper("Polski", new CultureInfo("pl-PL"), Resources.flag_poland),
            new CultureWrapper("Русский", new CultureInfo("ru-RU"), Resources.flag_russia),
            new CultureWrapper("简体中文", new CultureInfo("zh-CN"), Resources.flag_china),
            new CultureWrapper("繁體中文", new CultureInfo("zh-TW"), Resources.flag_taiwan),
            new CultureWrapper("Português", new CultureInfo("pt-BR"), Resources.flag_brazil),
            new CultureWrapper("日本語", new CultureInfo("ja-JP"), Resources.help),
        };

        private void PopulateLanguageComboBox() {
            comboLanguage.Items.Clear();

            var imageList = new ImageList() {
                ImageSize = new Size(16, 16),
                ColorDepth = ColorDepth.Depth32Bit
            };
            comboLanguage.IconList = imageList;

            int selectedIndex = 0;
            CultureInfo systemCulture = CultureInfo.InstalledUICulture;
            CultureInfo currentSetting = Settings.Default.Language;

            for (int i = 0; i < _languageList.Length; i++) {
                var langPair = _languageList[i];
                string displayName = langPair.Name;

                if (langPair.Culture.Equals(CultureInfo.InvariantCulture)) {
                    displayName = string.Format(Strings.LanguageAuto, systemCulture.DisplayName);
                }

                var item = new ImageComboBoxItem(displayName, langPair.Image != null ? imageList.Images.Count : -1) {
                    Tag = langPair.Culture
                };
                if (langPair.Image != null) {
                    imageList.Images.Add(langPair.Image);
                }
                comboLanguage.Items.Add(item);

                if (currentSetting != null && !currentSetting.Equals(CultureInfo.InvariantCulture)) {
                    if (langPair.Culture.Name == currentSetting.Name) {
                        selectedIndex = i;
                    }
                }
            }

            comboLanguage.SelectedIndex = selectedIndex;
        }

        private void LanguageBox_IndexChange(object sender, EventArgs e) {
            var item = comboLanguage.SelectedItem as ImageComboBoxItem;
            if (item == null)
                return;

            var culture = item.Tag as CultureInfo;
            if (culture != null && culture.Equals(CultureInfo.InvariantCulture)) {
                Settings.Default.Language = null;
            }
            else {
                Settings.Default.Language = culture;
            }
        }

        #endregion

    }

}
