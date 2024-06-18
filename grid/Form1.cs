using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;
using System.Net.WebSockets;

namespace grid
{
    public partial class Form1 : Form
    {
        public int id_user = 0;
        public int quantidade = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string query = $"update login_user set nome = @nome, email = @email, senha = @senha where id = {id_user}";
            SqlCommand cmd = new SqlCommand(query, cn.conn);
            cmd.Parameters.AddWithValue("nome", tb_nome.Text);
            cmd.Parameters.AddWithValue("email", tb_email.Text);
            cmd.Parameters.AddWithValue("senha", tb_senha.Text);

            cn.conn.Open();
            var reg = cmd.ExecuteNonQuery();
            MessageBox.Show($"{reg} linha afetada");
            cn.conn.Close();

            timer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string query = "select * from login_user";
            SqlCommand cmd = new SqlCommand(query, cn.conn);

            try
            {

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de carregamento {ex}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string query = "select * from login_user";
            SqlCommand cmd = new SqlCommand(query, cn.conn);

            try
            {

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de carregamento {ex}");
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_user = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                tb_nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                tb_email.Text = grid.CurrentRow.Cells[2].Value.ToString();
                tb_senha.Text = grid.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string query = "select * from login_user";
            SqlCommand cmd = new SqlCommand(query, cn.conn);

            try
            {

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de carregamento {ex}");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            quantidade++;
            lb_timer.Text = quantidade.ToString();
            if (quantidade > 2)
            {

                Connection cn = new Connection();
                string query = "select * from login_user";
                SqlCommand cmd = new SqlCommand(query, cn.conn);

                try
                {

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    grid.DataSource = dt;

                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Erro de carregamento {ex}");
                }

                quantidade = 0;
                timer.Enabled = false;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string query = "insert into login_user(nome,email,senha)values(@nome,@email,@senha); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(query, cn.conn);
            cmd.Parameters.AddWithValue("nome", tb_nome.Text);
            cmd.Parameters.AddWithValue("email", tb_email.Text) ;
            cmd.Parameters.AddWithValue("senha", tb_senha.Text);

            cn.conn.Open();
            var registro = cmd.ExecuteNonQuery();
            MessageBox.Show($"{registro} registro afetado");
            cn.conn.Close();
            timer.Enabled = true;

        }
    }
}
