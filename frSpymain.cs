using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text;

namespace frSpy
{
    public partial class frSpymain : Form
    {
        
        SoundPlayer player = new SoundPlayer();
        bool isPlaying = false;
        private bool isMouseDown = false;
        private Point lastLocation;
        public frSpymain()
        {
            InitializeComponent();
            //richTextBoxCapaOut.Visible = false;
            string mahniYolu = Path.Combine(Application.StartupPath, "res", "music", "solo.wav");
            if (File.Exists(mahniYolu))
            {
                player = new SoundPlayer(mahniYolu);
            }
            else
            {
                MessageBox.Show("Error: solo.wav not found.");
            }
            this.panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            richTextBoxCapaOut.ReadOnly = true;
            richTextBoxapktoollog.ReadOnly = true;
            richTextBoxobfuscate.ReadOnly = true;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (isMouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y
                );
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {

            isMouseDown = false;
        }
        private void buttonwantexe_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecet A exe file";
            openFileDialog.Filter = "Pe (*.exe)|*.exe";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string secilenDosyaYolu = openFileDialog.FileName;
                textBoxexedir.Text = (secilenDosyaYolu);

            }
        }
        private void runbutton_Click_1(object sender, EventArgs e)
        {
            richTextBoxCapaOut.Visible = true;
            richTextBoxCapaOut.Clear();
            string exePath = textBoxexedir.Text.Trim();
            string appDir = Application.StartupPath;
            string capaPath = Path.Combine(appDir, "res", "capa", "capa.exe");

            if (!File.Exists(capaPath))
            {
                MessageBox.Show("capa not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(exePath))
            {
                MessageBox.Show("Entered .exe file not found!", "frSpy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string arguments = $"/C \"\"{capaPath}\" -v \"{exePath}\"\"";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.OutputDataReceived += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(ev.Data))
                {
                    richTextBoxCapaOut.Invoke((MethodInvoker)(() =>
                    {
                        richTextBoxobfuscate.ScrollToCaret();
                        richTextBoxCapaOut.AppendText(ev.Data + Environment.NewLine);
                    }));
                }
            };

            process.ErrorDataReceived += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(ev.Data))
                {
                    richTextBoxCapaOut.Invoke((MethodInvoker)(() =>
                    {
                        richTextBoxCapaOut.AppendText("" + ev.Data + Environment.NewLine);
                    }));
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            label15.Text = string.Empty;
            richTextBoxCapaOut.Clear();
        }

        private void caparunbutton2_Click(object sender, EventArgs e)
        {
            richTextBoxCapaOut.Visible = true;
            richTextBoxCapaOut.Clear();
            string exePath = textBoxexedir.Text.Trim();
            string appDir = Application.StartupPath;
            string capaPath = Path.Combine(appDir, "res", "capa", "capa.exe");

            if (!File.Exists(capaPath))
            {
                MessageBox.Show("capa not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(exePath))
            {
                MessageBox.Show("Entered .exe file not found!", "frSpy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string arguments = $"/C \"\"{capaPath}\" -vv \"{exePath}\"\"";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.OutputDataReceived += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(ev.Data))
                {
                    richTextBoxCapaOut.Invoke((MethodInvoker)(() =>
                    {
                        richTextBoxCapaOut.AppendText(ev.Data + Environment.NewLine);
                    }));
                }
            };

            process.ErrorDataReceived += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(ev.Data))
                {
                    richTextBoxCapaOut.Invoke((MethodInvoker)(() =>
                    {
                        richTextBoxobfuscate.ScrollToCaret();
                        richTextBoxCapaOut.AppendText("" + ev.Data + Environment.NewLine);
                    }));
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }





        private void buttondecompile_Click(object sender, EventArgs e)
        {
            string appStart = Application.StartupPath;
            string jarPath = Path.Combine(appStart, "res", "apk", "apktool.jar");

            if (!File.Exists(textBoxapkfile.Text))
            {
                MessageBox.Show("Entered apk. file not found!", "frSpy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(jarPath))
            {
                MessageBox.Show("apktool.jar not found!");
                return;
            }

            string apkName = Path.GetFileNameWithoutExtension(textBoxapkfile.Text);
            string outputFolder = Path.Combine(appStart, "Decompiled apks", apkName);

            Process process = new Process();
            process.StartInfo.FileName = "java";
            process.StartInfo.Arguments = $"-jar \"{jarPath}\" d \"{textBoxapkfile.Text}\" -o \"{outputFolder}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.EnableRaisingEvents = true;

            process.OutputDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(ea.Data + Environment.NewLine);
                    }));
                }
            };

            process.ErrorDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(ea.Data + Environment.NewLine);
                    }));
                }
            };


            process.Exited += (s, ea) =>
            {

                if (process.ExitCode == 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(Environment.NewLine + "Successfully decompiled!" + Environment.NewLine);
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(Environment.NewLine + "Decompile failed. Exit code: " + process.ExitCode + Environment.NewLine);
                    }));
                }
            };

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start decompile process: " + ex.Message);
            }

        }

        private void buttonapk_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecet A apk file";
            openFileDialog.Filter = "apk (*.apk)|*.apk";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            richTextBoxapktoollog.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string secilenapkyolu = openFileDialog.FileName;
                textBoxapkfile.Text = (secilenapkyolu);

            }
        }

        private void buttonfolder_Click(object sender, EventArgs e)
        {
            string folder = Path.Combine(Application.StartupPath, "Decompiled apks");

            if (Directory.Exists(folder))
            {
                Process.Start("explorer.exe", folder);
            }
            else
            {
                MessageBox.Show("Decompiled folder not found: " + folder);
            }
        }

        private void buttoncompile_Click(object sender, EventArgs e)
        {
            string appStart = Application.StartupPath;
            string jarPath = Path.Combine(appStart, "res", "apk", "apktool.jar");

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Decompiled APK Folder";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string inputFolder = dialog.SelectedPath;

                if (!Directory.Exists(inputFolder))
                {
                    MessageBox.Show("Selected folder does not exist.");
                    return;
                }

                if (!File.Exists(jarPath))
                {
                    MessageBox.Show("apktool.jar not found!");
                    return;
                }

                string apkName = new DirectoryInfo(inputFolder).Name;
                string outputFolder = Path.Combine(appStart, "Compiled apks");
                string outputApk = Path.Combine(outputFolder, apkName + ".apk");

                Directory.CreateDirectory(outputFolder);

                Process process = new Process();
                process.StartInfo.FileName = "java";
                process.StartInfo.Arguments = $"-jar \"{jarPath}\" b \"{inputFolder}\" -o \"{outputApk}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                process.OutputDataReceived += (s, ea) =>
                {
                    if (!string.IsNullOrEmpty(ea.Data))
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            richTextBoxapktoollog.AppendText(ea.Data + Environment.NewLine);
                        }));
                    }
                };

                process.ErrorDataReceived += (s, ea) =>
                {
                    if (!string.IsNullOrEmpty(ea.Data))
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            richTextBoxapktoollog.AppendText(ea.Data + Environment.NewLine);
                        }));
                    }
                };

                try
                {
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to start compile process: " + ex.Message);
                }
            }
        }

        private void buttonfoldercompiled_Click(object sender, EventArgs e)
        {
            string folder = Path.Combine(Application.StartupPath, "Compiled apks");

            if (Directory.Exists(folder))
            {
                Process.Start("explorer.exe", folder);
            }
            else
            {
                MessageBox.Show("Decompiled folder not found: " + folder);
            }
        }

        private void buttonclearapktoolog_Click(object sender, EventArgs e)
        {
            richTextBoxapktoollog.Clear();
        }

        private void buttonsign_Click(object sender, EventArgs e)
        {
            string appStart = Application.StartupPath;
            string signerJarPath = Path.Combine(appStart, "res", "apk", "uber-apk-signer.jar");
            string apkToSignPath = textBoxapkfile.Text;

            if (!File.Exists(apkToSignPath))
            {
                MessageBox.Show("Entered .apk file not found!", "frSpy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(signerJarPath))
            {
                MessageBox.Show("uber-apk-signer.jar not found!");
                return;
            }

            string outputFolder = Path.Combine(appStart, "Signed apks");
            Directory.CreateDirectory(outputFolder);

            Process process = new Process();
            process.StartInfo.FileName = "java";
            process.StartInfo.Arguments = $"-jar \"{signerJarPath}\" -a \"{apkToSignPath}\" --debug -o \"{outputFolder}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.EnableRaisingEvents = true;

            process.OutputDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(ea.Data + Environment.NewLine);
                    }));
                }
            };

            process.ErrorDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(ea.Data + Environment.NewLine);
                    }));
                }
            };

            process.Exited += (s, ea) =>
            {
                if (process.ExitCode == 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(Environment.NewLine + "Successfully signed!" + Environment.NewLine);
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        richTextBoxapktoollog.AppendText(Environment.NewLine + "Signing failed. Exit code: " + process.ExitCode + Environment.NewLine);
                    }));
                }
            };

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start signing process: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folder = Path.Combine(Application.StartupPath, "Signed apks");

            if (Directory.Exists(folder))
            {
                Process.Start("explorer.exe", folder);
            }
            else
            {
                MessageBox.Show("Decompiled folder not found: " + folder);
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|(*.dll)|*.dll";
            openFileDialog.Title = "Select an obfuscated .NET executable";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string exePath = openFileDialog.FileName;
            string appDir = Application.StartupPath;
            string de4dotPath = Path.Combine(appDir, "res", "de4dot", "de4dot.exe");

            if (!File.Exists(de4dotPath))
            {
                MessageBox.Show("de4dot not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(exePath))
            {
                MessageBox.Show("Selected .exe or .dll file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string arguments = $"/C \"\"{de4dotPath}\" \"{exePath}\"\"";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.OutputDataReceived += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(ev.Data))
                {
                    richTextBoxobfuscate.Invoke((MethodInvoker)(() =>
                    {
                        richTextBoxobfuscate.AppendText(ev.Data + Environment.NewLine);
                    }));
                }
            };

            process.ErrorDataReceived += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(ev.Data))
                {
                    richTextBoxobfuscate.Invoke((MethodInvoker)(() =>
                    {
                        richTextBoxobfuscate.ScrollToCaret();
                        richTextBoxobfuscate.AppendText("" + ev.Data + Environment.NewLine);
                    }));
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBoxobfuscate.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            richTextBoxobfuscate.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "APK Files|*.apk|All Files|*.*",
                Title = "Select an APK file"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string apkPath = openFileDialog.FileName;
            AppendText("Selected APK: " + apkPath);

            string startupPath = Application.StartupPath;
            string apkEditorJarPath = Path.Combine(startupPath, "res", "apkeditor", "apkeditor.jar");

            if (!File.Exists(apkEditorJarPath))
            {
                AppendText("Error: apkeditor.jar not found. Expected location: " + apkEditorJarPath);
                return;
            }

            string outputFolder = Path.Combine(startupPath, "Obfuscated apk");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
                AppendText("Output folder created: " + outputFolder);
            }

            string outputFile = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(apkPath) + "_obfuscated.apk");
            string arguments = $"-jar \"{apkEditorJarPath}\" p -i \"{apkPath}\" -o \"{outputFile}\"";
            AppendText("Command created: java " + arguments);

            await Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "java",
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = startupPath
                };

                Process process = new Process
                {
                    StartInfo = psi,
                    EnableRaisingEvents = true
                };

                process.OutputDataReceived += (s, evt) =>
                {
                    if (!string.IsNullOrEmpty(evt.Data))
                        AppendTextSafe(evt.Data);
                };

                process.ErrorDataReceived += (s, evt) =>
                {
                    if (!string.IsNullOrEmpty(evt.Data))
                        AppendTextSafe("" + evt.Data);
                };

                try
                {
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    AppendTextSafe("Process started...");
                    process.WaitForExit();
                    AppendTextSafe("Process finished. Output file: " + outputFile);
                }
                catch (Exception ex)
                {
                    AppendTextSafe("Error during process: " + ex.Message);
                }
            });
        }

        private void AppendText(string text)
        {
            richTextBoxobfuscate.AppendText(text + Environment.NewLine);
            richTextBoxobfuscate.ScrollToCaret();
        }

        private void AppendTextSafe(string text)
        {
            if (richTextBoxobfuscate.InvokeRequired)
            {
                richTextBoxobfuscate.Invoke(new Action(() =>
                {
                    AppendText(text);
                }));
            }
            else
            {
                AppendText(text);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            richTextBoxobfuscate.Clear();
        }


        private void playbutton_Click_1(object sender, EventArgs e)
        {
            if (player == null) return;

            if (!isPlaying)
            {
                player.PlayLooping();
                isPlaying = true;
            }
            else
            {
                player.Stop();
                isPlaying = false;
            }
        }

        private void toolTipexe_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/rafok2v9c/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://github.com/rafigk2v9c",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}