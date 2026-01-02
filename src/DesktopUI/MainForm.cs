using LitJson;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using DesktopUI.Infrastructure.Entity;


namespace DesktopUI
{
    public partial class MainForm : Form
    {
        private BindingList<Account> accounts;    
        private ServerList[] serverList;
        public MainForm()
        {
            InitializeComponent();
            //
            //dataGridView1.DataSource = accounts;
            time.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer1.Start();      
            serverList = new ServerList[]
            {
                new ServerList{id=0,name="Vũ trụ 1",hostname="",port=0},
                new ServerList{id=1,name="Vũ trụ 2",hostname="",port=0},
                new ServerList{id=2,name="Vũ trụ 3",hostname="",port=0},
                new ServerList{id=3,name="Vũ trụ 4",hostname="",port=0},
                new ServerList{id=4,name="Vũ trụ 5",hostname="",port=0},
                new ServerList{id=5,name="Vũ trụ 6",hostname="",port=0},
                new ServerList{id=6,name="Vũ trụ 7",hostname="",port=0},
            };
            //
            index_server.Items.AddRange(serverList.Select(x=>x.name).ToArray());

        }
        private void Setting_Load(object sender, EventArgs e)
        {
            var FilePath = @"C:\Users\taida\project\winform-ui\src\DesktopUI\Infrastructure\Data\account.json";
            if (File.Exists(FilePath))
            {
                var data = File.ReadAllText(FilePath);
                //var list_account = new List<Account>();
                var datajson = JsonMapper.ToObject<List<Account>>(data);
                //var datajson = jsonmapper.toobject<account[]>(datatext);
                //foreach (var account in datajson) { list_account.Add(account); }             
                //List<Account> list = JsonConvert.DeserializeObject<List<Account>>(data);

                if (datajson == null)
                {
                    datajson = new List<Account>();
                }

                accounts = new BindingList<Account>(datajson);

                //dataGridView1.DataSource = accounts;
                dataGridView1.DataSource = accounts;
                accounts.ListChanged += Accounts_ListChanged;

            }
            else
            {
                accounts = new BindingList<Account>();
            }
        }

        private void Accounts_ListChanged(object? sender, ListChangedEventArgs e)
        {
            SaveDataToFile();
        }
        private void SaveDataToFile()
        {
            var json = JsonConvert.SerializeObject(accounts);
            //MessageBox.Show(json);
            File.WriteAllText(@"C:\Users\taida\project\winform-ui\src\DesktopUI\Infrastructure\Data\account.json", json);

        }
     
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[0];
                if (Convert.ToBoolean(checkbox.Value) == false)
                {
                    checkbox.Value = true;
                    accounts[row.Index].IsAuto = true;               
                }
            }

        }

        private void btnUnCheck_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[0];
                if (Convert.ToBoolean(checkbox.Value) == true)
                {
                    checkbox.Value = false;
                    accounts[row.Index].IsAuto = false;                  
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
            try
            {             
                BindingList<Account> lst = (BindingList<Account>)dataGridView1.DataSource;
                Account objQcc = new Account()
                {
                    IsAuto = false,
                    Username = username.Text,
                    Password = password.Text,
                    Server = index_server.Text.Substring(7),
                    Status = ""
                };
                lst.Add(objQcc);

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.CurrentRow.Index;
                    BindingList<Account> lst = (BindingList<Account>)dataGridView1.DataSource;
                    Account objQcc = new Account()
                    {
                        IsAuto = lst[index].IsAuto,
                        Username = username.Text,
                        Password = password.Text,
                        Server = index_server.Text.Substring(7),
                        Status = ""
                    };
                    lst[index] = objQcc;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.CurrentRow.Index;
                    BindingList<Account> lst = (BindingList<Account>)dataGridView1.DataSource;
                    lst.RemoveAt(index);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //load info
            int index = dataGridView1.CurrentRow.Index;
            BindingList<Account> lst = (BindingList<Account>)dataGridView1.DataSource;
            //
            username.Text = lst[index].Username;
            password.Text = lst[index].Password;          
            int idx_server = int.Parse(lst[index].Server) - 1;       
            index_server.SelectedIndex = serverList[idx_server].id;
            //more field ... 
        }
    }
}
