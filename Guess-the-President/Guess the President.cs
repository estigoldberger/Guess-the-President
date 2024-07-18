using System.Data.SqlClient;
using System.Data;

namespace Match_the_President
{
    public partial class Guess_the_President : Form
    {
        int details = 0;
        DataGridView gv = new();
        public Guess_the_President()
        {
            InitializeComponent();
            btnStart.Click += Button1_Click;
            btnAnswer.Click += Button2_Click;

        }

        private void SetGridProperties()
        {
            var dt = GetDataTable("select 'Name'=  concat(FirstName,' ', LastName) from president p where Num= " + txtNum.Text);
            tblMain.Controls.Add(gv, 1, 2);
            gv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gv.Dock = DockStyle.Fill;
            gv.BackgroundColor = Color.Cyan;
            gv.BorderStyle = BorderStyle.None;
            gv.DataSource = dt;
            gv.AllowUserToAddRows = false;
            gv.Font = new Font("Arial", 14);
            gv.Margin = new(50, 40, 0, 10);

        }
        private DataTable GetDataTable(string sqlstatement)
        {

            DataTable dt = new();
            SqlConnection conn = new(GetConnectionString());
            conn.Open();
            SqlCommand cmd = new(sqlstatement, conn);
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        private void ShowPresNum()
        {
            btnAnswer.Enabled = true;
            int n = 0;
            bool b = int.TryParse(lblTurn.Text, out n);
            DataTable dt = GetDataTable("select * from president p ");
            Random rnd = new();
            details = rnd.Next(1, dt.Rows.Count);
            this.Tag = details;
            txtNum.Text = details.ToString();
            btnStart.Text = "Refresh";
            lblTurn.Text = (n + 1).ToString();

        }

        private string GetConnectionString()
        {

            string s = $"Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true";
            return s;
        }
        private string GetValueFromFirstRowAsString(DataTable tbl, string columname)
        {
            string value = "";
            if (tbl.Rows.Count > 0)
            {
                DataRow r = tbl.Rows[0];
                if (r[columname] != null && r[columname] is string)
                {
                    value = (string)r[columname];
                }

            }
            return value;
        }

        private void ShowResults()
        {
            btnStart.Text = "Start";
            var dt = GetDataTable("select 'And the president is: '= concat(FirstName,' ', LastName) from president p where Num= " + txtNum.Text);

            string s = GetValueFromFirstRowAsString(dt, "And the president is: ");

            if (s == txtGuess.Text)
            {
                int l = 0;
                bool bo = int.TryParse(lblPt.Text, out l);
                lblPt.Text = (l + 1).ToString();
                var response = MessageBox.Show("You guessed the president! Would you like to play again?", "", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    txtNum.Clear();
                    ShowPresNum();

                }
                else
                {

                    MessageBox.Show("Your score is: " + lblPt.Text);
                    this.Close();
                }
            }
            if (s != txtGuess.Text)
            {
                var response = MessageBox.Show("Whoops! Would you like to try again?", "", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    txtNum.Clear();
                    txtGuess.Clear();
                    ShowPresNum();
                }
                else
                {

                    if (lblPt.Text == "")
                    {
                        MessageBox.Show("Try again next time!");
                    }
                    else MessageBox.Show("Your score is: " + lblPt.Text);
                    this.Close();
                }

            }
            txtGuess.Clear();
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            ShowPresNum();

        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            lblAnswer.Text = "And the president is:";
            SetGridProperties();
            ShowResults();
        }
    }
}
