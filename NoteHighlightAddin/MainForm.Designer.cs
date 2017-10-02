using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
namespace NoteHighlightAddin
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            NoteHighlightForm.Properties.Settings settings3 = new NoteHighlightForm.Properties.Settings();
            this.btnCodeHighLight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_style = new System.Windows.Forms.ComboBox();
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_font = new System.Windows.Forms.ComboBox();
            this.cbx_lineNumber = new System.Windows.Forms.CheckBox();
            this.cbx_Clipboard = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBackground = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCodeHighLight
            // 
            this.btnCodeHighLight.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCodeHighLight.Location = new System.Drawing.Point(513, 0);
            this.btnCodeHighLight.Name = "btnCodeHighLight";
            this.btnCodeHighLight.Size = new System.Drawing.Size(90, 30);
            this.btnCodeHighLight.TabIndex = 0;
            this.btnCodeHighLight.Text = "OK";
            this.btnCodeHighLight.UseVisualStyleBackColor = true;
            this.btnCodeHighLight.Click += new System.EventHandler(this.btnCodeHighLight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Style";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // cbx_style
            // 
            this.cbx_style.FormattingEnabled = true;
            this.cbx_style.Location = new System.Drawing.Point(49, 23);
            this.cbx_style.Name = "cbx_style";
            this.cbx_style.Size = new System.Drawing.Size(81, 25);
            this.cbx_style.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(603, 346);
            this.txtCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbx_font);
            this.panel1.Controls.Add(this.cbx_lineNumber);
            this.panel1.Controls.Add(this.cbx_Clipboard);
            this.panel1.Controls.Add(this.cbx_style);
            this.panel1.Controls.Add(this.cbx_font);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 69);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font";
            // 
            // cbx_font
            // 
            this.cbx_font.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_font.FormattingEnabled = true;
            this.cbx_font.Location = new System.Drawing.Point(185, 23);
            this.cbx_font.Name = "cbx_font";
            this.cbx_font.Size = new System.Drawing.Size(140, 25);
            this.cbx_font.TabIndex = 3;
            this.cbx_font.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Cbx_font_DrawItem);
            this.cbx_font.SelectedIndexChanged +=
    new System.EventHandler(Cbx_font_SelectedIndexChanged);
            // 
            // cbx_lineNumber
            // 
            this.cbx_lineNumber.AutoSize = true;
            settings3.BackgroundColor = System.Drawing.Color.White;
            settings3.HighLightStyle = 0;
            settings3.SaveOnClipboard = false;
            settings3.SettingsKey = "";
            settings3.ShowLineNumber = true;
            this.cbx_lineNumber.Checked = settings3.ShowLineNumber;
            this.cbx_lineNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_lineNumber.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings3, "ShowLineNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbx_lineNumber.Location = new System.Drawing.Point(480, 27);
            this.cbx_lineNumber.Name = "cbx_lineNumber";
            this.cbx_lineNumber.Size = new System.Drawing.Size(120, 21);
            this.cbx_lineNumber.TabIndex = 2;
            this.cbx_lineNumber.Text = "Line Number(&N)";
            this.cbx_lineNumber.UseVisualStyleBackColor = true;
            // 
            // cbx_Clipboard
            // 
            this.cbx_Clipboard.AutoSize = true;
            this.cbx_Clipboard.Checked = settings3.SaveOnClipboard;
            this.cbx_Clipboard.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings3, "SaveOnClipboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbx_Clipboard.Location = new System.Drawing.Point(331, 27);
            this.cbx_Clipboard.Name = "cbx_Clipboard";
            this.cbx_Clipboard.Size = new System.Drawing.Size(151, 21);
            this.cbx_Clipboard.TabIndex = 1;
            this.cbx_Clipboard.Text = "Copy to Clipboard(&C)";
            this.cbx_Clipboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBackground);
            this.panel2.Controls.Add(this.btnCodeHighLight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 30);
            this.panel2.TabIndex = 2;
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(0, 0);
            this.btnBackground.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(90, 30);
            this.btnBackground.TabIndex = 1;
            this.btnBackground.Text = "Box Color";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 346);
            this.panel3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCodeHighLight;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 445);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.Text = "NoteHighLight";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.Load += new System.EventHandler(this.CodeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Cbx_font_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Font font = cbx_font.Font;
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily fontFamilie in installedFontCollection.Families)
            {
                if (cbx_font.Items[e.Index].ToString() == fontFamilie.Name)
                {
                    if (fontFamilie.IsStyleAvailable(FontStyle.Regular))
                        font = new Font(fontFamilie, font.Size);
                    break;
                }

            }
            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, cbx_font.Items[e.Index].ToString(),
              font, e.Bounds, cbx_font.ForeColor, TextFormatFlags.Left);
            e.DrawFocusRectangle();
        }
        private void Cbx_font_SelectedIndexChanged(object sender,
    System.EventArgs e)
        {
            string fontText = (string)cbx_font.SelectedItem;
            this.txtCode.Font = new Font(fontText,Font.Size);
        }
        #endregion

        private System.Windows.Forms.Button btnCodeHighLight;
        private System.Windows.Forms.CheckBox cbx_lineNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbx_Clipboard;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbx_style;
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbx_font;
        private Label label3;
    }
}