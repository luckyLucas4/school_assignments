using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediaregistret
{
    public partial class Form1 : Form
    {
        private List<Media> media = new List<Media>();
        private int selection = 0;

        public Form1()
        {
            InitializeComponent();
            Media media1 = new Media("Fin titel");
            rtb_media.Text = media1.ToString();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            bool correctInput = true;

            string title = "defaultTitle";
            if(tb_bookTitle.Text != "")
            {
                title = tb_bookTitle.Text;
            }
            else
            {
                tb_bookTitle.BackColor = Color.Salmon;
                lbl_bookMissing.Visible = true;
                correctInput = false;
            }

            string author = "defaultAuthor";
            if (tb_author.Text != "")
            {
                author = tb_author.Text;
            }
            else
            {
                tb_author.BackColor = Color.Salmon;
                lbl_bookMissing.Visible = true;
                correctInput = false;
            }

            int pages;
            pages = Convert.ToInt32(nr_nrPages.Value);
            if(correctInput == true)
            {
                media.Add(new Book(title, author, pages));
                lbl_bookMissing.Visible = false;
                UpdateTextOutput();
            }  
        }

        private void btn_addMovie_Click(object sender, EventArgs e)
        {
            bool correctInput = true;

            string title = "defaultTitle";
            if (tb_movTitle.Text != "")
            {
                title = tb_movTitle.Text;
            }
            else
            {
                tb_movTitle.BackColor = Color.Salmon;
                lbl_movMissing.Visible = true;
                correctInput = false;
            }

            string director = "defaultAuthor";
            if (tb_director.Text != "")
            {
                director = tb_director.Text;
            }
            else
            {
                tb_director.BackColor = Color.Salmon;
                lbl_movMissing.Visible = true;
                correctInput = false;
            }

            int length;
            length = Convert.ToInt32(nr_length.Value);

            if (correctInput == true)
            {
                media.Add(new Movie(title, director, length));
                lbl_movMissing.Visible = false;
                UpdateTextOutput();
                
            } 
        }

        private void UpdateTextOutput()
        {
            num_choice.Value = selection;
            string output = "";
            if (rb_all.Checked)
            {
                int counter = 0;
                foreach (Media m in media)
                {
                    output += "(" + media.IndexOf(m) + ") " + m.ToString();
                    if (counter == selection)
                    {
                        output += " *";
                    }
                    output += "\n";
                    counter++;
                }
            }
            else if (rb_books.Checked)
            {
                int counter = 0;
                foreach (Media m in media)
                { 
                    if(m is Book)
                    {
                        output += "(" + media.IndexOf(m) + ") " + m.ToString();
                        if (counter == selection)
                        {
                            output += " *";
                        }
                        output += "\n";
                    }
                    counter++;
                }
            }
            else if (rb_movies.Checked)
            {
                int counter = 0;
                foreach (Media m in media)
                {
                    
                    if (m is Movie)
                    {
                        output += "(" + media.IndexOf(m) + ") " + m.ToString();
                        if (counter == selection)
                        {
                            output += " *";
                        }
                        output += "\n";
                    }
                    counter++;
                }
            }
            
            rtb_media.Text = output;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string message = string.Format("Vill du ta bort media på position {0}?", selection);
            string caption = "Ta bort media";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if(result == System.Windows.Forms.DialogResult.OK && media.Count > 0)
            {
                media.RemoveAt(selection);
            }
            selection = 0;
            UpdateTextOutput();
        }

        private void tb_movTitle_Click(object sender, EventArgs e)
        {
            tb_movTitle.BackColor = Color.White;
        }

        private void tb_director_Click(object sender, EventArgs e)
        {
            tb_director.BackColor = Color.White;
        }

        private void tb_bookTitle_Click(object sender, EventArgs e)
        {
            tb_bookTitle.BackColor = Color.White;
        }

        private void tb_author_Click(object sender, EventArgs e)
        {
            tb_author.BackColor = Color.White;
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            selection = 0;
            UpdateTextOutput();
        }

        private void rb_books_CheckedChanged(object sender, EventArgs e)
        {
            selection = 0;
            UpdateTextOutput();
        }

        private void rb_movies_CheckedChanged(object sender, EventArgs e)
        {
            selection = 0;
            UpdateTextOutput();
        }

        private void num_choice_ValueChanged(object sender, EventArgs e)
        {
            if(media.Count == 0)
            {
                num_choice.Maximum = 0;
            }
            else
            {
                num_choice.Maximum = media.Count - 1;
            }
            selection = Convert.ToInt32(num_choice.Value);
            UpdateTextOutput();
        }
    }
}
