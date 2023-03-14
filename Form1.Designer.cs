namespace Notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl = new TabControl();
            GeneralTabPage = new TabPage();
            DeleteGeneralButton = new Button();
            GeneralRichTextBox = new RichTextBox();
            GRTabPage = new TabPage();
            DeleteGRButton = new Button();
            GRRichTextBox = new RichTextBox();
            GRTabPage1 = new TabPage();
            DeleteGRButton1 = new Button();
            GRRichTextBox1 = new RichTextBox();
            ImportantTabPage = new TabPage();
            DeleteImportantButton = new Button();
            ImportantRichTextBox = new RichTextBox();
            ContextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            TabControl.SuspendLayout();
            GeneralTabPage.SuspendLayout();
            GRTabPage.SuspendLayout();
            GRTabPage1.SuspendLayout();
            ImportantTabPage.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(GeneralTabPage);
            TabControl.Controls.Add(GRTabPage);
            TabControl.Controls.Add(GRTabPage1);
            TabControl.Controls.Add(ImportantTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(491, 490);
            TabControl.TabIndex = 0;
            // 
            // GeneralTabPage
            // 
            GeneralTabPage.Controls.Add(DeleteGeneralButton);
            GeneralTabPage.Controls.Add(GeneralRichTextBox);
            GeneralTabPage.Location = new Point(4, 24);
            GeneralTabPage.Name = "GeneralTabPage";
            GeneralTabPage.Padding = new Padding(3);
            GeneralTabPage.Size = new Size(483, 462);
            GeneralTabPage.TabIndex = 0;
            GeneralTabPage.Text = "Γενικά";
            GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteGeneralButton
            // 
            DeleteGeneralButton.AutoSize = true;
            DeleteGeneralButton.BackColor = Color.Red;
            DeleteGeneralButton.ForeColor = SystemColors.ControlText;
            DeleteGeneralButton.Location = new Point(179, 9);
            DeleteGeneralButton.Name = "DeleteGeneralButton";
            DeleteGeneralButton.Size = new Size(124, 38);
            DeleteGeneralButton.TabIndex = 7;
            DeleteGeneralButton.Text = "Διαγραφή Όλων";
            DeleteGeneralButton.UseVisualStyleBackColor = false;
            DeleteGeneralButton.Click += DeleteGeneralButton_Click;
            // 
            // GeneralRichTextBox
            // 
            GeneralRichTextBox.BackColor = SystemColors.Info;
            GeneralRichTextBox.Dock = DockStyle.Bottom;
            GeneralRichTextBox.Location = new Point(3, 53);
            GeneralRichTextBox.Name = "GeneralRichTextBox";
            GeneralRichTextBox.Size = new Size(477, 406);
            GeneralRichTextBox.TabIndex = 6;
            GeneralRichTextBox.Text = "";
            GeneralRichTextBox.ContextMenuStripChanged += RichTextContextMenu;
            GeneralRichTextBox.MouseDown += GeneralRichTextBox_MouseDown;
            // 
            // GRTabPage
            // 
            GRTabPage.Controls.Add(DeleteGRButton);
            GRTabPage.Controls.Add(GRRichTextBox);
            GRTabPage.Location = new Point(4, 24);
            GRTabPage.Name = "GRTabPage";
            GRTabPage.Padding = new Padding(3);
            GRTabPage.Size = new Size(483, 462);
            GRTabPage.TabIndex = 1;
            GRTabPage.Text = "Ελλάδα";
            GRTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteGRButton
            // 
            DeleteGRButton.AutoSize = true;
            DeleteGRButton.BackColor = Color.Red;
            DeleteGRButton.ForeColor = SystemColors.ControlText;
            DeleteGRButton.Location = new Point(179, 9);
            DeleteGRButton.Name = "DeleteGRButton";
            DeleteGRButton.Size = new Size(124, 38);
            DeleteGRButton.TabIndex = 5;
            DeleteGRButton.Text = "Διαγραφή Όλων";
            DeleteGRButton.UseVisualStyleBackColor = false;
            DeleteGRButton.Click += DeleteGRButton_Click;
            // 
            // GRRichTextBox
            // 
            GRRichTextBox.BackColor = SystemColors.Info;
            GRRichTextBox.Dock = DockStyle.Bottom;
            GRRichTextBox.Location = new Point(3, 53);
            GRRichTextBox.Name = "GRRichTextBox";
            GRRichTextBox.Size = new Size(477, 406);
            GRRichTextBox.TabIndex = 4;
            GRRichTextBox.Text = "";
            GRRichTextBox.ContextMenuStripChanged += RichTextContextMenu;
            GRRichTextBox.MouseDown += GRRichTextBox_MouseDown;
            // 
            // GRTabPage1
            // 
            GRTabPage1.Controls.Add(DeleteGRButton1);
            GRTabPage1.Controls.Add(GRRichTextBox1);
            GRTabPage1.Location = new Point(4, 24);
            GRTabPage1.Name = "GRTabPage1";
            GRTabPage1.Padding = new Padding(3);
            GRTabPage1.Size = new Size(483, 462);
            GRTabPage1.TabIndex = 2;
            GRTabPage1.Text = "Ελλάδα";
            GRTabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteGRButton1
            // 
            DeleteGRButton1.AutoSize = true;
            DeleteGRButton1.BackColor = Color.Red;
            DeleteGRButton1.ForeColor = SystemColors.ControlText;
            DeleteGRButton1.Location = new Point(179, 9);
            DeleteGRButton1.Name = "DeleteGRButton1";
            DeleteGRButton1.Size = new Size(124, 38);
            DeleteGRButton1.TabIndex = 3;
            DeleteGRButton1.Text = "Διαγραφή Όλων";
            DeleteGRButton1.UseVisualStyleBackColor = false;
            DeleteGRButton1.Click += DeleteGRButton1_Click;
            // 
            // GRRichTextBox1
            // 
            GRRichTextBox1.BackColor = SystemColors.Info;
            GRRichTextBox1.Dock = DockStyle.Bottom;
            GRRichTextBox1.Location = new Point(3, 53);
            GRRichTextBox1.Name = "GRRichTextBox1";
            GRRichTextBox1.Size = new Size(477, 406);
            GRRichTextBox1.TabIndex = 2;
            GRRichTextBox1.Text = "";
            GRRichTextBox1.ContextMenuStripChanged += RichTextContextMenu;
            GRRichTextBox1.MouseDown += GRRichTextBox1_MouseDown;
            // 
            // ImportantTabPage
            // 
            ImportantTabPage.BackColor = Color.White;
            ImportantTabPage.Controls.Add(DeleteImportantButton);
            ImportantTabPage.Controls.Add(ImportantRichTextBox);
            ImportantTabPage.Location = new Point(4, 24);
            ImportantTabPage.Name = "ImportantTabPage";
            ImportantTabPage.Padding = new Padding(3);
            ImportantTabPage.RightToLeft = RightToLeft.No;
            ImportantTabPage.Size = new Size(483, 462);
            ImportantTabPage.TabIndex = 3;
            ImportantTabPage.Text = "Σημαντικά";
            // 
            // DeleteImportantButton
            // 
            DeleteImportantButton.AutoSize = true;
            DeleteImportantButton.BackColor = Color.Red;
            DeleteImportantButton.ForeColor = SystemColors.ControlText;
            DeleteImportantButton.Location = new Point(179, 9);
            DeleteImportantButton.Name = "DeleteImportantButton";
            DeleteImportantButton.Size = new Size(124, 38);
            DeleteImportantButton.TabIndex = 1;
            DeleteImportantButton.Text = "Διαγραφή Όλων";
            DeleteImportantButton.UseVisualStyleBackColor = false;
            DeleteImportantButton.Click += DeleteImportantButton_Click;
            // 
            // ImportantRichTextBox
            // 
            ImportantRichTextBox.BackColor = SystemColors.Info;
            ImportantRichTextBox.Dock = DockStyle.Bottom;
            ImportantRichTextBox.Location = new Point(3, 53);
            ImportantRichTextBox.Name = "ImportantRichTextBox";
            ImportantRichTextBox.Size = new Size(477, 406);
            ImportantRichTextBox.TabIndex = 0;
            ImportantRichTextBox.Text = "";
            ImportantRichTextBox.ContextMenuStripChanged += RichTextContextMenu;
            ImportantRichTextBox.MouseDown += ImportantRichTextBox_MouseDown;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(103, 70);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(102, 22);
            toolStripMenuItem1.Text = "Cut";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(102, 22);
            toolStripMenuItem2.Text = "Copy";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(102, 22);
            toolStripMenuItem3.Text = "Paste";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(491, 490);
            Controls.Add(TabControl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(507, 529);
            Name = "Form1";
            Text = "My Notes";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ContextMenuStripChanged += RichTextContextMenu;
            TabControl.ResumeLayout(false);
            GeneralTabPage.ResumeLayout(false);
            GeneralTabPage.PerformLayout();
            GRTabPage.ResumeLayout(false);
            GRTabPage.PerformLayout();
            GRTabPage1.ResumeLayout(false);
            GRTabPage1.PerformLayout();
            ImportantTabPage.ResumeLayout(false);
            ImportantTabPage.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage GeneralTabPage;
        private TabPage GRTabPage;
        private TabPage GRTabPage1;
        private TabPage ImportantTabPage;
        private Button DeleteImportantButton;
        private RichTextBox ImportantRichTextBox;
        private Button DeleteGRButton1;
        private RichTextBox GRRichTextBox1;
        private Button DeleteGeneralButton;
        private RichTextBox GeneralRichTextBox;
        private Button DeleteGRButton;
        private RichTextBox GRRichTextBox;
        private new ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}