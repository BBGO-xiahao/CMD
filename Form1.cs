using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 转移数量的图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1210, 500);
            textBox11.SelectionStart = textBox11.TextLength;
            textBox11.ScrollToCaret();
            textBox13.SelectionStart = textBox13.TextLength;
            textBox13.ScrollToCaret();
            textBox6.SelectionStart =textBox6.TextLength;
            textBox6.ScrollToCaret();

        }
        wenjian Wenjian1 = new wenjian();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择源文件存放目录";
                if (folder.ShowDialog() == DialogResult.OK)
                {

                    string sPath = folder.SelectedPath;
                    textBox1.Text = sPath;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择目标文件存放目录";
                if (folder.ShowDialog() == DialogResult.OK)
                {

                    string sPath = folder.SelectedPath;
                    textBox2.Text = sPath;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择源文件存放目录";
                if (folder.ShowDialog() == DialogResult.OK)
                {

                    string sPath = folder.SelectedPath;
                    textBox3.Text = sPath;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择目标文件存放目录";
                if (folder.ShowDialog() == DialogResult.OK)
                {

                    string sPath = folder.SelectedPath;
                    textBox4.Text = sPath;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择源文件存放目录";
                if (folder.ShowDialog() == DialogResult.OK)
                {

                    string sPath = folder.SelectedPath;
                    textBox5.Text = sPath;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择目标文件存放目录";
                if (folder.ShowDialog() == DialogResult.OK)
                {

                    string sPath = folder.SelectedPath;
                    textBox5.Text = sPath;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)//复制
        {
            button3.BackColor = SystemColors.Control;
            if (radioButton1.Checked == true)
            {

                Thread Threaddel = new Thread(delegate () { Wenjian1.copy1(@textBox1.Text, @textBox2.Text, textBox7.Text, Convert.ToInt32(textBox8.Text)); });
                Threaddel.Start();
                ProcessDelegate showProcess = delegate ()
                {
                    while (true)
                    {
                        if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                        {
                            button3.BackColor = Color.Green;
                            break;
                        }
                    }


                };

                Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                Threadde2.Start();

            }
            if (radioButton2.Checked == true)
            {
                if (textBox14.Text.Length>3)
                {
                    string[] arr_str = new string[1000];
                    if (textBox14.Text.Length>3)
                    {
                        arr_str = Strings.Split(textBox14.Text.Trim(), "\n");
                    }
                    Thread Threaddel = new Thread(delegate () { Wenjian1.Copy2(@textBox1.Text, @textBox2.Text, textBox7.Text, Convert.ToInt32(textBox8.Text), arr_str); });
                    Threaddel.Start();
                    ProcessDelegate showProcess = delegate ()
                    {
                        while (true)
                        {
                            if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                            {
                                button3.BackColor = Color.Green;
                                break;
                            }
                        }


                    };
                    Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                    Threadde2.Start();
                }
                else
                {
                    Thread Threaddel = new Thread(delegate () { Wenjian1.copy2(@textBox1.Text, @textBox2.Text, textBox7.Text, Convert.ToInt32(textBox8.Text)); });
                    Threaddel.Start();
                    ProcessDelegate showProcess = delegate ()
                    {
                        while (true)
                        {
                            if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                            {
                                button3.BackColor = Color.Green;
                                break;
                            }
                        }


                    };
                    Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                    Threadde2.Start();
                }
               


            }
            if (radioButton3.Checked == true)
            {
                Thread Threaddel = new Thread(delegate () { Wenjian1.copy3(@textBox1.Text, @textBox2.Text, textBox7.Text, Convert.ToInt32(textBox8.Text)); });
                Threaddel.Start();
                ProcessDelegate showProcess = delegate ()
                {
                    while (true)
                    {
                        if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                        {
                            button3.BackColor = Color.Green;
                            break;
                        }
                    }


                };

                Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                Threadde2.Start();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton5.Checked = true;
            radioButton8.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.Control;
            if (radioButton6.Checked == true)
            {
                Thread Threaddel = new Thread(delegate () { Wenjian1.moveto1(@textBox3.Text, @textBox4.Text, textBox10.Text, Convert.ToInt32(textBox9.Text)); });
                Threaddel.Start();
                ProcessDelegate showProcess = delegate ()
                {
                    while (true)
                    {
                        if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                        {
                            button4.BackColor = Color.Green;
                            Threaddel.Abort();
                            break;
                        }
                    }


                };

                Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                Threadde2.Start();

            }
            if (radioButton5.Checked == true)
            {
                if (textBox15.Text.Length>3)
                {
                    string[] arr_str = new string[1000];
                    if (textBox15.Text.Length > 3)
                    {
                        arr_str = Strings.Split(textBox15.Text.Trim(), "\n");
                    }
                    Thread Threaddel = new Thread(delegate () { Wenjian1.Moveto2(@textBox3.Text, @textBox4.Text, textBox10.Text, Convert.ToInt32(textBox9.Text), arr_str); });
                    Threaddel.Start();
                    ProcessDelegate showProcess = delegate ()
                    {
                        while (true)
                        {
                            if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                            {
                                button4.BackColor = Color.Green;
                                break;
                            }
                        }


                    };
                    Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                    Threadde2.Start();

                }
                else
                {
                    Thread Threaddel = new Thread(delegate () { Wenjian1.moveto2(@textBox3.Text, @textBox4.Text, textBox10.Text, Convert.ToInt32(textBox9.Text)); });
                    Threaddel.Start();
                    ProcessDelegate showProcess = delegate ()
                    {
                        while (true)
                        {
                            if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                            {
                                button4.BackColor = Color.Green;
                                break;
                            }
                        }


                    };
                    Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                    Threadde2.Start();
                }




            }
            if (radioButton4.Checked == true)
            {
                Thread Threaddel = new Thread(delegate () { Wenjian1.moveto3(@textBox3.Text, @textBox4.Text, textBox10.Text, Convert.ToInt32(textBox9.Text)); });
                Threaddel.Start();
                ProcessDelegate showProcess = delegate ()
                {
                    while (true)
                    {
                        if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                        {
                            button7.BackColor = Color.Green;
                            break;
                        }
                    }


                };

                Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                Threadde2.Start();

            }
        }//剪切
        public delegate void ProcessDelegate();
        private void button7_Click(object sender, EventArgs e)
        {
         
            button7.BackColor = SystemColors.Control;
            if (radioButton9.Checked == true)
            {
                Thread Threaddel = new Thread(delegate () { Wenjian1.del1(@textBox5.Text, textBox12.Text); });
                Threaddel.Start();
                ProcessDelegate showProcess = delegate ()
                {
                    while (true)
                    {
                        if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                        {
                            button7.BackColor = Color.Green;
                            break;
                        }
                    }


                };
               
                Thread Threadde2= new Thread(new ThreadStart(showProcess));
                Threadde2.Start();
            }
            if (radioButton8.Checked == true)
            {
                if (textBox16.Text.Length>3 )
                {
                    string[] arr_str = new string[1000];
                    if (textBox16.Text.Length > 3)
                    {
                        arr_str = Strings.Split(textBox16.Text.Trim(), "\n");
                    }
                    Thread Threaddel = new Thread(delegate () { Wenjian1.Del2(@textBox5.Text, textBox12.Text, arr_str); });
                    Threaddel.Start();
                    ProcessDelegate showProcess = delegate ()
                    {
                        while (true)
                        {
                            if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                            {
                                button7.BackColor = Color.Green;
                                break;
                            }
                        }


                    };

                    Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                    Threadde2.Start();
                }
                else
                {
                    Thread Threaddel = new Thread(delegate () { Wenjian1.del2(@textBox5.Text, textBox12.Text); });
                    Threaddel.Start();
                    ProcessDelegate showProcess = delegate ()
                    {
                        while (true)
                        {
                            if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                            {
                                button7.BackColor = Color.Green;
                                break;
                            }
                        }


                    };

                    Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                    Threadde2.Start();
                }
               

            }
            if (radioButton7.Checked == true)
            {
                Thread Threaddel = new Thread(delegate () { Wenjian1.del3(@textBox5.Text, textBox12.Text); });
                Threaddel.Start();
                ProcessDelegate showProcess = delegate ()
                {
                    while (true)
                    {
                        if (Convert.ToInt32(Threaddel.ThreadState) == 16)
                        {
                            button7.BackColor = Color.Green;
                            break;
                        }
                    }


                };

                Thread Threadde2 = new Thread(new ThreadStart(showProcess));
                Threadde2.Start();
            }
        }//删除
    }
}
