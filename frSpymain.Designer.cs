namespace frSpy
{
    partial class frSpymain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSpymain));
            panel1 = new Panel();
            playbutton = new Button();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            toolTipexe = new ToolTip(components);
            buttonwantexe = new Button();
            toolTipcapav = new ToolTip(components);
            caparunbutton = new Button();
            button6 = new Button();
            toolTipcapavv = new ToolTip(components);
            caparunbutton2 = new Button();
            toolTipclear = new ToolTip(components);
            buttonclear = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabPage3 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            richTextBoxobfuscate = new RichTextBox();
            tabPage1 = new TabPage();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            buttonclearapktoolog = new Button();
            buttonfoldercompiled = new Button();
            buttonfolderdecompiled = new Button();
            richTextBoxapktoollog = new RichTextBox();
            textBoxapkfile = new TextBox();
            buttonsign = new Button();
            buttoncompile = new Button();
            buttondecompile = new Button();
            buttonapk = new Button();
            label5 = new Label();
            tabPage2 = new TabPage();
            label15 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxexedir = new TextBox();
            richTextBoxCapaOut = new RichTextBox();
            labelexeoutpuddir = new Label();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            label16 = new Label();
            label14 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(playbutton);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 103);
            panel1.TabIndex = 0;
            // 
            // playbutton
            // 
            playbutton.BackColor = Color.Black;
            playbutton.BackgroundImage = Properties.Resources.icons8_play_30;
            playbutton.BackgroundImageLayout = ImageLayout.Stretch;
            playbutton.Cursor = Cursors.Hand;
            playbutton.FlatStyle = FlatStyle.Popup;
            playbutton.Font = new Font("Arial", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playbutton.Location = new Point(75, 30);
            playbutton.Name = "playbutton";
            playbutton.Size = new Size(31, 32);
            playbutton.TabIndex = 11;
            toolTipclear.SetToolTip(playbutton, "Play Music");
            playbutton.UseVisualStyleBackColor = false;
            playbutton.Click += playbutton_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(7, 39);
            label11.Name = "label11";
            label11.Size = new Size(71, 14);
            label11.TabIndex = 11;
            label11.Text = "Play Music";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spy;
            pictureBox1.Location = new Point(333, -64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // toolTipexe
            // 
            toolTipexe.Popup += toolTipexe_Popup;
            // 
            // buttonwantexe
            // 
            buttonwantexe.BackgroundImage = Properties.Resources.icons8_exe_50;
            buttonwantexe.BackgroundImageLayout = ImageLayout.Stretch;
            buttonwantexe.Cursor = Cursors.Hand;
            buttonwantexe.Font = new Font("Arial", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonwantexe.Location = new Point(334, 5);
            buttonwantexe.Name = "buttonwantexe";
            buttonwantexe.Size = new Size(52, 50);
            buttonwantexe.TabIndex = 1;
            buttonwantexe.TextAlign = ContentAlignment.BottomCenter;
            toolTipexe.SetToolTip(buttonwantexe, "Select .exe");
            buttonwantexe.UseVisualStyleBackColor = true;
            buttonwantexe.Click += buttonwantexe_Click;
            // 
            // caparunbutton
            // 
            caparunbutton.BackgroundImage = Properties.Resources._1;
            caparunbutton.BackgroundImageLayout = ImageLayout.Stretch;
            caparunbutton.Cursor = Cursors.Hand;
            caparunbutton.Font = new Font("Arial", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caparunbutton.Location = new Point(392, 5);
            caparunbutton.Name = "caparunbutton";
            caparunbutton.Size = new Size(104, 50);
            caparunbutton.TabIndex = 5;
            toolTipcapav.SetToolTip(caparunbutton, "Show matched rules");
            caparunbutton.UseVisualStyleBackColor = true;
            caparunbutton.Click += runbutton_Click_1;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.Adobe_Express___file1;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Arial", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(824, 85);
            button6.Name = "button6";
            button6.Size = new Size(52, 51);
            button6.TabIndex = 10;
            toolTipclear.SetToolTip(button6, "Clear log");
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // caparunbutton2
            // 
            caparunbutton2.BackgroundImage = Properties.Resources._1;
            caparunbutton2.BackgroundImageLayout = ImageLayout.Stretch;
            caparunbutton2.Cursor = Cursors.Hand;
            caparunbutton2.Font = new Font("Arial", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caparunbutton2.Location = new Point(502, 5);
            caparunbutton2.Name = "caparunbutton2";
            caparunbutton2.Size = new Size(104, 50);
            caparunbutton2.TabIndex = 8;
            caparunbutton2.Text = "-v v";
            caparunbutton2.TextAlign = ContentAlignment.BottomCenter;
            toolTipcapavv.SetToolTip(caparunbutton2, "Show detailed rule match reasoning");
            caparunbutton2.UseVisualStyleBackColor = true;
            caparunbutton2.Click += caparunbutton2_Click;
            // 
            // buttonclear
            // 
            buttonclear.BackgroundImage = Properties.Resources.Adobe_Express___file1;
            buttonclear.BackgroundImageLayout = ImageLayout.Stretch;
            buttonclear.Cursor = Cursors.Hand;
            buttonclear.Font = new Font("Arial", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonclear.Location = new Point(824, 5);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(52, 51);
            buttonclear.TabIndex = 7;
            toolTipclear.SetToolTip(buttonclear, "Clear log");
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += buttonclear_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(richTextBoxobfuscate);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(882, 570);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Obfuscation/Deobfuscation";
            tabPage3.Click += tabPage3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(468, 13);
            label10.Name = "label10";
            label10.Size = new Size(137, 20);
            label10.TabIndex = 13;
            label10.Text = "Deobfucate exe/dll";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(300, 13);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 12;
            label9.Text = "Obfuscate apk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 7.85454559F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(502, 112);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 3;
            label3.Text = "*only .NET";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources._0_8AELQj3BcNv7wLnU;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(456, 36);
            button4.Name = "button4";
            button4.Size = new Size(162, 73);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 34, 34);
            button3.BackgroundImage = Properties.Resources.unnamed;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(274, 36);
            button3.Name = "button3";
            button3.Size = new Size(162, 73);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBoxobfuscate
            // 
            richTextBoxobfuscate.BackColor = Color.Black;
            richTextBoxobfuscate.ForeColor = Color.Lime;
            richTextBoxobfuscate.Location = new Point(3, 142);
            richTextBoxobfuscate.Name = "richTextBoxobfuscate";
            richTextBoxobfuscate.Size = new Size(873, 419);
            richTextBoxobfuscate.TabIndex = 0;
            richTextBoxobfuscate.Text = "Log output:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(buttonclearapktoolog);
            tabPage1.Controls.Add(buttonfoldercompiled);
            tabPage1.Controls.Add(buttonfolderdecompiled);
            tabPage1.Controls.Add(richTextBoxapktoollog);
            tabPage1.Controls.Add(textBoxapkfile);
            tabPage1.Controls.Add(buttonsign);
            tabPage1.Controls.Add(buttoncompile);
            tabPage1.Controls.Add(buttondecompile);
            tabPage1.Controls.Add(buttonapk);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(882, 570);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Static Code Analysis";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(210, 33);
            label8.Name = "label8";
            label8.Size = new Size(334, 14);
            label8.TabIndex = 21;
            label8.Text = "Enter the path to the apk file or click the apk button";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(800, 534);
            label6.Name = "label6";
            label6.Size = new Size(47, 14);
            label6.TabIndex = 20;
            label6.Text = "2.11.1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(747, 534);
            label7.Name = "label7";
            label7.Size = new Size(58, 14);
            label7.TabIndex = 19;
            label7.Text = "version:";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(707, 73);
            button2.Name = "button2";
            button2.Size = new Size(153, 23);
            button2.TabIndex = 17;
            button2.Text = "Signed apk folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonclearapktoolog
            // 
            buttonclearapktoolog.BackgroundImage = Properties.Resources.Adobe_Express___file;
            buttonclearapktoolog.BackgroundImageLayout = ImageLayout.Stretch;
            buttonclearapktoolog.Cursor = Cursors.Hand;
            buttonclearapktoolog.Location = new Point(826, 154);
            buttonclearapktoolog.Name = "buttonclearapktoolog";
            buttonclearapktoolog.Size = new Size(50, 51);
            buttonclearapktoolog.TabIndex = 16;
            toolTip1.SetToolTip(buttonclearapktoolog, "Clear log");
            buttonclearapktoolog.UseVisualStyleBackColor = true;
            buttonclearapktoolog.Click += buttonclearapktoolog_Click;
            // 
            // buttonfoldercompiled
            // 
            buttonfoldercompiled.Cursor = Cursors.Hand;
            buttonfoldercompiled.Font = new Font("Segoe UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonfoldercompiled.Location = new Point(707, 47);
            buttonfoldercompiled.Name = "buttonfoldercompiled";
            buttonfoldercompiled.Size = new Size(153, 23);
            buttonfoldercompiled.TabIndex = 15;
            buttonfoldercompiled.Text = "Compiled apk folder";
            buttonfoldercompiled.UseVisualStyleBackColor = true;
            buttonfoldercompiled.Click += buttonfoldercompiled_Click;
            // 
            // buttonfolderdecompiled
            // 
            buttonfolderdecompiled.Cursor = Cursors.Hand;
            buttonfolderdecompiled.Font = new Font("Segoe UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonfolderdecompiled.Location = new Point(707, 20);
            buttonfolderdecompiled.Name = "buttonfolderdecompiled";
            buttonfolderdecompiled.Size = new Size(153, 23);
            buttonfolderdecompiled.TabIndex = 14;
            buttonfolderdecompiled.Text = "Decompiled apk folder";
            buttonfolderdecompiled.UseVisualStyleBackColor = true;
            buttonfolderdecompiled.Click += buttonfolder_Click;
            // 
            // richTextBoxapktoollog
            // 
            richTextBoxapktoollog.BackColor = Color.Black;
            richTextBoxapktoollog.ForeColor = Color.Lime;
            richTextBoxapktoollog.Location = new Point(3, 211);
            richTextBoxapktoollog.Name = "richTextBoxapktoollog";
            richTextBoxapktoollog.Size = new Size(876, 350);
            richTextBoxapktoollog.TabIndex = 13;
            richTextBoxapktoollog.Text = "Log output:";
            // 
            // textBoxapkfile
            // 
            textBoxapkfile.Location = new Point(152, 50);
            textBoxapkfile.Name = "textBoxapkfile";
            textBoxapkfile.Size = new Size(454, 27);
            textBoxapkfile.TabIndex = 0;
            // 
            // buttonsign
            // 
            buttonsign.BackgroundImage = Properties.Resources._3;
            buttonsign.BackgroundImageLayout = ImageLayout.Stretch;
            buttonsign.Cursor = Cursors.Hand;
            buttonsign.Location = new Point(503, 106);
            buttonsign.Name = "buttonsign";
            buttonsign.Size = new Size(107, 99);
            buttonsign.TabIndex = 9;
            buttonsign.UseVisualStyleBackColor = true;
            buttonsign.Click += buttonsign_Click;
            // 
            // buttoncompile
            // 
            buttoncompile.BackgroundImage = Properties.Resources._2;
            buttoncompile.BackgroundImageLayout = ImageLayout.Stretch;
            buttoncompile.Cursor = Cursors.Hand;
            buttoncompile.Location = new Point(374, 106);
            buttoncompile.Name = "buttoncompile";
            buttoncompile.Size = new Size(107, 99);
            buttoncompile.TabIndex = 8;
            buttoncompile.UseVisualStyleBackColor = true;
            buttoncompile.Click += buttoncompile_Click;
            // 
            // buttondecompile
            // 
            buttondecompile.BackgroundImage = Properties.Resources.DECOMPILE;
            buttondecompile.BackgroundImageLayout = ImageLayout.Stretch;
            buttondecompile.Cursor = Cursors.Hand;
            buttondecompile.Location = new Point(240, 106);
            buttondecompile.Name = "buttondecompile";
            buttondecompile.Size = new Size(107, 99);
            buttondecompile.TabIndex = 7;
            buttondecompile.UseVisualStyleBackColor = true;
            buttondecompile.Click += buttondecompile_Click;
            // 
            // buttonapk
            // 
            buttonapk.BackColor = Color.White;
            buttonapk.BackgroundImage = Properties.Resources._5585899;
            buttonapk.BackgroundImageLayout = ImageLayout.Stretch;
            buttonapk.Cursor = Cursors.Hand;
            buttonapk.Location = new Point(624, 20);
            buttonapk.Name = "buttonapk";
            buttonapk.Size = new Size(77, 76);
            buttonapk.TabIndex = 6;
            toolTip2.SetToolTip(buttonapk, "Select .apk");
            buttonapk.UseVisualStyleBackColor = false;
            buttonapk.Click += buttonapk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 53);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 3;
            label5.Text = "Select APK File:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(caparunbutton2);
            tabPage2.Controls.Add(buttonclear);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(caparunbutton);
            tabPage2.Controls.Add(textBoxexedir);
            tabPage2.Controls.Add(richTextBoxCapaOut);
            tabPage2.Controls.Add(labelexeoutpuddir);
            tabPage2.Controls.Add(buttonwantexe);
            tabPage2.Font = new Font("Verdana", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(882, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Functional Static Analysis";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(654, 5);
            label15.Name = "label15";
            label15.Size = new Size(138, 51);
            label15.TabIndex = 11;
            label15.Text = "please wait up to \r\n5 seconds after \r\nclicking the button";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(807, 534);
            label1.Name = "label1";
            label1.Size = new Size(39, 14);
            label1.TabIndex = 10;
            label1.Text = "9.1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(754, 534);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 2;
            label2.Text = "version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 2);
            label4.Name = "label4";
            label4.Size = new Size(334, 14);
            label4.TabIndex = 6;
            label4.Text = "Enter the path to the exe file or click the exe button";
            // 
            // textBoxexedir
            // 
            textBoxexedir.Font = new Font("Arial", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxexedir.Location = new Point(6, 19);
            textBoxexedir.Name = "textBoxexedir";
            textBoxexedir.Size = new Size(317, 24);
            textBoxexedir.TabIndex = 4;
            // 
            // richTextBoxCapaOut
            // 
            richTextBoxCapaOut.BackColor = Color.Black;
            richTextBoxCapaOut.Font = new Font("Arial", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxCapaOut.ForeColor = Color.Lime;
            richTextBoxCapaOut.Location = new Point(3, 61);
            richTextBoxCapaOut.Name = "richTextBoxCapaOut";
            richTextBoxCapaOut.Size = new Size(876, 500);
            richTextBoxCapaOut.TabIndex = 0;
            richTextBoxCapaOut.Text = "Log output:";
            // 
            // labelexeoutpuddir
            // 
            labelexeoutpuddir.AutoSize = true;
            labelexeoutpuddir.Font = new Font("Arial", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelexeoutpuddir.Location = new Point(3, 3);
            labelexeoutpuddir.Name = "labelexeoutpuddir";
            labelexeoutpuddir.Size = new Size(0, 17);
            labelexeoutpuddir.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(-5, 91);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 603);
            tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Controls.Add(pictureBox3);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(pictureBox2);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(882, 570);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "About";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Black;
            label16.ForeColor = Color.White;
            label16.Location = new Point(264, 180);
            label16.Name = "label16";
            label16.Size = new Size(337, 40);
            label16.TabIndex = 6;
            label16.Text = "        The application will receive an update,\r\nyou can update it from the following github page";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Black;
            label14.Font = new Font("Arial", 6.890909F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(376, 262);
            label14.Name = "label14";
            label14.Size = new Size(130, 14);
            label14.TabIndex = 5;
            label14.Text = "made by Rafig Zarbaliyev";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Image = Properties.Resources.icons8_github_48;
            pictureBox4.Location = new Point(473, 454);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = Properties.Resources.icons8_instagram_50;
            pictureBox3.Location = new Point(376, 454);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Black;
            label13.ForeColor = Color.White;
            label13.Location = new Point(114, 90);
            label13.Name = "label13";
            label13.Size = new Size(680, 60);
            label13.TabIndex = 2;
            label13.Text = resources.GetString("label13.Text");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Black;
            label12.Font = new Font("Segoe UI Black", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(191, 23);
            label12.Name = "label12";
            label12.Size = new Size(519, 42);
            label12.TabIndex = 1;
            label12.Text = "Thank you for using For-RealSpy";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ezgif_29d1af0e313d25;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(882, 567);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // frSpymain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 685);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frSpymain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frSpy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ToolTip toolTipexe;
        private ToolTip toolTipcapav;
        private ToolTip toolTipcapavv;
        private ToolTip toolTipclear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private Label label8;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button buttonclearapktoolog;
        private Button buttonfoldercompiled;
        private Button buttonfolderdecompiled;
        private RichTextBox richTextBoxapktoollog;
        private TextBox textBoxapkfile;
        private Button buttonsign;
        private Button buttoncompile;
        private Button buttondecompile;
        private Button buttonapk;
        private Label label5;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Button caparunbutton2;
        private Button buttonclear;
        private Label label4;
        private Button caparunbutton;
        private TextBox textBoxexedir;
        private RichTextBox richTextBoxCapaOut;
        private Label labelexeoutpuddir;
        private Button buttonwantexe;
        private TabControl tabControl1;
        private RichTextBox richTextBoxobfuscate;
        private Button button3;
        private Button button4;
        private Label label3;
        private Button button6;
        private Label label10;
        private Label label9;
        private TabPage tabPage4;
        private PictureBox pictureBox2;
        private Label label11;
        private Button playbutton;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label label13;
        private Label label12;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}
