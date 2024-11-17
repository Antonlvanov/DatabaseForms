using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andmebass_TARpv23
{
    public partial class Form1 : Form
    {
        static string filePath;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            FindDB();
            if (conn != null) { NaitaAndmed(); }
        }

        public void FindDB()
        {
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.mdf");

            if (File.Exists(filePath))
            {
                conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={filePath};Integrated Security=True");
            }
            else
            {
                MessageBox.Show("База данных не найдена. Подключите новую базу данных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void NaitaAndmed()
        {
            if (conn == null)
            {
                MessageBox.Show("Подключение к базе данных не настроено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Toode", conn);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Insert into Toode(Nimetus, Kogus, Hind, Pilt) Values (@toode,@kogus,@hind,@pilt)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.Parameters.AddWithValue("@pilt", Nimetus_txt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Andmebaasiga viga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }
        }

        private void Kustuta_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0)
            {
                try
                {
                    int deletedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM Toode WHERE Id=@id",conn);
                    cmd.Parameters.AddWithValue("@id", deletedId);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();

                    MessageBox.Show("Kirje kustutatud");
                }
                catch (Exception)
                {
                    MessageBox.Show("Viga kustutamisel");
                }
            }
            else
            {
                MessageBox.Show("Valige kustutamiseks kirje");
            }

        }

        private void Uuenda_btn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Toode SET Nimetus=@toode, Kogus=@kogus, Hind=@hind WHERE id=@id", conn);
                    
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                    MessageBox.Show("Andmebaas edukalt uuendatud");
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }
        }

        int ID = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
            Nimetus_txt = (TextBox)dataGridView1.Rows[e.RowIndex].Cells["Nimetus"].Value;
            Kogus_txt = (TextBox)dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value;
            Hind_txt = (TextBox)dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value;
        }
        OpenFileDialog open;
        SaveFileDialog save;

        private void otsipilt_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Pictures\";
            open.Multiselect = false;
            open.Filter = "Images Files (*.jpeg;*.png;*.bmp;*.jpg;|*.jpeg;*.png;*.bmp;*.jpg";
            FileInfo openfile = new FileInfo(@"C:\Users\opilane\Pictures\"+open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Nimetus_txt != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\..\Pildid");
                string extension = Path.GetExtension(open.FileName);

                save.FileName = Nimetus_txt.Text+extension;
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension (open.FileName);
                if (save.ShowDialog() == DialogResult.OK && Nimetus_txt != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    pictureBox1.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või ole cancel vajatud");
            }
        }

        private void connectDB_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                Multiselect = false,
                Filter = "Database Files (*.mdf)|*.mdf"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string projectRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");
                    string databasesFolder = Path.Combine(projectRoot, "Databases");
                    Directory.CreateDirectory(databasesFolder);

                    // Новый путь для базы данных
                    string newFilePath = Path.Combine(databasesFolder, Path.GetFileName(open.FileName));

                    // Копируем файл базы данных
                    File.Copy(open.FileName, newFilePath, overwrite: true);

                    // Обновляем путь для подключения
                    filePath = newFilePath;
                    conn.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={filePath};Integrated Security=True";

                    // Проверяем подключение
                    conn.Open();
                    conn.Close();

                    MessageBox.Show("База данных успешно подключена.");
                    NaitaAndmed(); // Обновляем данные в интерфейсе
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
