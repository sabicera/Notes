using System;
using System.IO;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the text from the files in the application files directory
            string generalFilePath = Path.Combine(Application.StartupPath, "general.txt");
            string grFilePath = Path.Combine(Application.StartupPath, "gr.txt");
            string gr1FilePath = Path.Combine(Application.StartupPath, "gr1.txt");
            string importantFilePath = Path.Combine(Application.StartupPath, "important.txt");

            if (File.Exists(generalFilePath))
            {
                string text = File.ReadAllText(generalFilePath);
                GeneralRichTextBox.Text = text;
            }
            if (File.Exists(grFilePath))
            {
                string text = File.ReadAllText(grFilePath);
                GRRichTextBox.Text = text;
            }
            if (File.Exists(gr1FilePath))
            {
                string text = File.ReadAllText(gr1FilePath);
                GRRichTextBox1.Text = text;
            }
            if (File.Exists(importantFilePath))
            {
                string text = File.ReadAllText(importantFilePath);
                ImportantRichTextBox.Text = text;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the text to separate files for each text box
            string generalFilePath = Path.Combine(Application.StartupPath, "general.txt");
            string grFilePath = Path.Combine(Application.StartupPath, "gr.txt");
            string gr1FilePath = Path.Combine(Application.StartupPath, "gr1.txt");
            string importantFilePath = Path.Combine(Application.StartupPath, "important.txt");

            File.WriteAllText(generalFilePath, GeneralRichTextBox.Text);
            File.WriteAllText(grFilePath, GRRichTextBox.Text);
            File.WriteAllText(gr1FilePath, GRRichTextBox1.Text);
            File.WriteAllText(importantFilePath, ImportantRichTextBox.Text);
        }
        // Delete Function
        private void DeleteGeneralButton_Click(object sender, EventArgs e)
        {
            GeneralRichTextBox.Text = "";
        }
        private void DeleteGRButton_Click(object sender, EventArgs e)
        {
            GRRichTextBox.Text = "";
        }
        private void DeleteGRButton1_Click(object sender, EventArgs e)
        {
            GRRichTextBox1.Text = "";
        }
        private void DeleteImportantButton_Click(object sender, EventArgs e)
        {
            ImportantRichTextBox.Text = "";
        }
        private void RichTextContextMenu(object sender, EventArgs e)
        {

        }
        private void GeneralRichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new();

                ToolStripMenuItem cutItem = new("Cut");
                cutItem.Click += (s, args) => GeneralRichTextBox.Cut();
                menu.Items.Add(cutItem);

                ToolStripMenuItem copyItem = new("Copy");
                copyItem.Click += (s, args) => GeneralRichTextBox.Copy();
                menu.Items.Add(copyItem);

                ToolStripMenuItem pasteItem = new("Paste");
                pasteItem.Click += (s, args) => GeneralRichTextBox.Paste();
                menu.Items.Add(pasteItem);

                menu.Show(GeneralRichTextBox, e.Location);
            }
        }
        private void GRRichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new();

                ToolStripMenuItem cutItem = new("Cut");
                cutItem.Click += (s, args) => GRRichTextBox.Cut();
                menu.Items.Add(cutItem);

                ToolStripMenuItem copyItem = new("Copy");
                copyItem.Click += (s, args) => GRRichTextBox.Copy();
                menu.Items.Add(copyItem);

                ToolStripMenuItem pasteItem = new("Paste");
                pasteItem.Click += (s, args) => GRRichTextBox.Paste();
                menu.Items.Add(pasteItem);

                menu.Show(GRRichTextBox, e.Location);
            }
        }
        private void GRRichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new();

                ToolStripMenuItem cutItem = new("Cut");
                cutItem.Click += (s, args) => GRRichTextBox1.Cut();
                menu.Items.Add(cutItem);

                ToolStripMenuItem copyItem = new("Copy");
                copyItem.Click += (s, args) => GRRichTextBox1.Copy();
                menu.Items.Add(copyItem);

                ToolStripMenuItem pasteItem = new("Paste");
                pasteItem.Click += (s, args) => GRRichTextBox1.Paste();
                menu.Items.Add(pasteItem);

                menu.Show(GRRichTextBox1, e.Location);
            }
        }
        private void ImportantRichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new();

                ToolStripMenuItem cutItem = new("Cut");
                cutItem.Click += (s, args) => ImportantRichTextBox.Cut();
                menu.Items.Add(cutItem);

                ToolStripMenuItem copyItem = new("Copy");
                copyItem.Click += (s, args) => ImportantRichTextBox.Copy();
                menu.Items.Add(copyItem);

                ToolStripMenuItem pasteItem = new("Paste");
                pasteItem.Click += (s, args) => ImportantRichTextBox.Paste();
                menu.Items.Add(pasteItem);

                menu.Show(ImportantRichTextBox, e.Location);
            }
        }
    }
}