using System;
using System.Windows.Forms;

namespace OnTopReplica {
    public class OpacityDialog : Form {
        private TextBox textBox;
        private Button okButton;
        private Button cancelButton;

        public double OpacityPercent { get; private set; }

        public OpacityDialog(double currentOpacity) {
            this.Text = "Custom Opacity";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.Width = 250;
            this.Height = 120;

            textBox = new TextBox();
            textBox.Text = ((int)(currentOpacity * 100.0)).ToString();
            textBox.Location = new System.Drawing.Point(15, 15);
            textBox.Width = 200;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                    e.Handled = true;
                    return;
                }
                if (char.IsDigit(e.KeyChar)) {
                    string currentText = textBox.Text;
                    if (textBox.SelectionLength > 0) {
                        currentText = currentText.Remove(textBox.SelectionStart, textBox.SelectionLength);
                    }
                    string newText = currentText.Insert(textBox.SelectionStart, e.KeyChar.ToString());
                    if (int.TryParse(newText, out int val) && (val < 0 || val > 100)) {
                        e.Handled = true;
                        return;
                    }
                    if (e.KeyChar == '0' && newText.Length > 1 && newText.StartsWith("0")) {
                        e.Handled = true;
                    }
                }
            };
            textBox.TextChanged += (s, e) => {
                if (int.TryParse(textBox.Text, out int val)) {
                    string fixedText = val.ToString();
                    if (val > 100) fixedText = "100";
                    else if (val < 0) fixedText = "0";
                    if (textBox.Text != fixedText) {
                        int cursorPos = textBox.SelectionStart;
                        textBox.Text = fixedText;
                        textBox.SelectionStart = Math.Max(0, cursorPos - 1);
                    }
                }
                else if (textBox.Text.Length > 0) {
                    textBox.Text = "50";
                }
            };
            this.Controls.Add(textBox);

            okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new System.Drawing.Point(40, 50);
            this.Controls.Add(okButton);

            cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(130, 50);
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) {
            base.OnClosing(e);
            if (this.DialogResult == DialogResult.OK) {
                int val = 50;
                int.TryParse(textBox.Text, out val);
                if (val < 0) val = 0;
                if (val > 100) val = 100;
                OpacityPercent = (double)val / 100.0;
            }
        }
    }
}
