using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Media;
namespace Görev_Takip
{
    public partial class Form1 : Form
    {
      
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }
        DataBase db = new DataBase();
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTimePicker.MinDate = DateTime.Now;
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "d MMMM yyyy - HH:mm";
            Control();
            getData();
            

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if(TaskTitle.Text.Length < 1 || TaskDesc.Text.Length < 1)
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru biçimde doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(this.DateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("Tarih şuandan büyük olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.Connect();
            string query = $"INSERT INTO [gorevler] (name, aciklama, isComplated, tarih) VALUES ('{TaskTitle.Text}', '{TaskDesc.Text}', 'false', '{DateTimePicker.Value.ToString("g")}')";

            int success = db.ExecuteNonQuery(query);
            if(success <= 0)
            {
                MessageBox.Show("Kaydetme sırasında hata oluştu", "Hata");
            }
            db.Close();
            getData();
        }
        private void getData()
        {
            db.Connect();
            OleDbDataReader reader = db.ExecuteReader("select * from gorevler");
            listView1.Items.Clear();
            while(reader.Read())
            {
                string durum = reader["isComplated"].ToString();
                bool status = Convert.ToBoolean(durum);
                if (status == false)
                {
                    ListViewItem sa = new ListViewItem();
                    sa.Text = reader["uuid"].ToString();
                    sa.SubItems.Add((string)reader["name"]);
                    sa.SubItems.Add((string)reader["aciklama"]);
                    sa.SubItems.Add("Devam Ediyor");
                    sa.SubItems.Add(reader["tarih"].ToString());
                    listView1.Items.Add(sa);
                }
                else
                {
                    continue;
                }
               
            }
            db.Close();
        }
        private void Control() {
            db.Connect();
            OleDbDataReader reader = db.ExecuteReader("select * from gorevler");
            while (reader.Read())
            {
                var sonTarih = (string)reader["tarih"];
                DateTime tarih = Convert.ToDateTime(sonTarih);
                if(tarih < DateTime.Now)
                {
                    string query = "update gorevler set " + $"isComplated='true'" + $"where uuid={reader["uuid"]}";

                    int status = db.ExecuteNonQuery(query);
                    if (status < 0) MessageBox.Show("Süresi dolan veriler güncellenirken hata oluştu","Hata");
                }
            }
            db.Close();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 60000; // 60000 milisaniye = 1 dakika
            timer.Tick += async (sender, e) => await VeritabaniTarihKontroluAsync();
            timer.Start();
        }
        SoundPlayer player = new SoundPlayer();
        private async Task VeritabaniTarihKontroluAsync()
        {
            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tasks.accdb;"))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand("SELECT * FROM gorevler", connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        var tasks = new List<Task>();

                        while (reader.Read())
                        {
                            if (reader["isComplated"].ToString() == "false")
                            {
                                tasks.Add(ProcessTaskAsync(reader));
                            }
                        }

                        await Task.WhenAll(tasks);
                    }
                }
            }
        }
        private async Task ProcessTaskAsync(OleDbDataReader reader)
        {
            string tarih = reader["tarih"].ToString();
            DateTime dateTime = Convert.ToDateTime(tarih);

            if (dateTime <= DateTime.Now)
            {
                player.SoundLocation = "timer.wav";
                player.PlayLooping();

                MessageBox.Show(reader["name"].ToString() + " isimli görevin süresi doldu!", "Süre Doldu", MessageBoxButtons.OK);
                player.Stop();
                player.Dispose();
                Control();
                getData();
            }
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count <= 0) { return; }
            var dialogResult = MessageBox.Show("Bu görevi silmek istediğinize eminmisiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No) return;
            string query = "delete from gorevler where uuid=" + listView1.SelectedItems[0].Text;
            db.Connect();
            int success = db.ExecuteNonQuery(query);
            if(success == 1)
            {
                MessageBox.Show("Görev silindi");
                Control();
                getData();
            }
            else
            {
                MessageBox.Show("Görev silinirken bir hata oluştu");
            }
            db.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0) { return; }
            var dialogResult = MessageBox.Show("Bu görevi tamamlamak istediğinize eminmisiniz?", "Tamamlandı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No) return;

            string query = "update gorevler set isComplated='true' where uuid=" + listView1.SelectedItems[0].Text;
            db.Connect();
            int success = db.ExecuteNonQuery(query);
            db.Close();
            if (success == 1)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text + " isimli görev tamamlandı olarak işaretlendi", "Başarılı", MessageBoxButtons.OK);
                Control();
                getData();
            }
            else { MessageBox.Show("Güncelleme işlemi sırasında hata oluştu"); }
        }
    }
}
