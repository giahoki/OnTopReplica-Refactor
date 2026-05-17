using OnTopReplica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsAero.Dwm;

namespace OnTopReplica.SidePanels {
    partial class AboutPanel : SidePanel {

        public AboutPanel() {
            InitializeComponent();

            //Display version number
            var ver = Application.ProductVersion;
            if (ver.EndsWith(".0")) ver = ver.Substring(0, ver.Length - 2);
            panelContents.lblVersion.Text = "Version: " + ver;
            labelVersion.Text = string.Format(Strings.AboutVersion, ver);
        }

        public override string Title {
            get {
                return Strings.AboutTitle;
            }
        }

        public override Padding GlassMargins {
            get {
                return new Padding(0, 0, 0, labelVersion.Height);
            }
        }

    }
}
